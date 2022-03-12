using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO.Ports;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;

namespace App
{
    public partial class frmMain : Form
    {
        public SerialPort serial = new SerialPort();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //splitContainer1.SplitterDistance = 600;
            get_PortName(cbCOM);
            tab_Data();
            loadData("Data", dataGV_Data);
            cbBAUD.SelectedIndex = 0;
            cbCOM.SelectedIndex = 0;
            serial.DataReceived += Serial_DataReceived;
            timer_UpdateData.Start();
        }

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String Nhietdo = serial.ReadTo("|").ToString();
            String Doam = serial.ReadTo("|").ToString();

            txtNhietdo.Invoke((MethodInvoker)delegate
            {
                txtNhietdo.Text = Nhietdo;
            });
            txtDoam.Invoke((MethodInvoker)delegate
            {
                txtDoam.Text = Doam;
            });
            serial.DiscardInBuffer();
        }
        #region Function connect RS232
        public void connect_Port(SerialPort serial, string COM, int Baud)
        {
            try
            {
                if (serial.IsOpen)
                {
                    serial.Close();
                    serial.PortName = COM;
                    serial.BaudRate = Baud;
                    serial.Open();
                    MessageBox.Show("Kết nối lại Port " + COM + " với Baudrate = " + Baud, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    serial.PortName = COM;
                    serial.BaudRate = Baud;
                    serial.Open();
                    MessageBox.Show("Kết nối thành công Port " + COM + " với Baudrate = " + Baud, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Port không hợp lệ!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void disconnect_Port(SerialPort serial)
        {
            if (serial.IsOpen)
            {
                serial.Close();
                MessageBox.Show("Ngắt kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã ngắt kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void get_PortName(ComboBox cbCOM)
        {
            List<String> tList = new List<String>();

            cbCOM.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                tList.Add(s);
            }

            tList.Sort();
            cbCOM.Items.Add("Select COM port...");
            cbCOM.Items.AddRange(tList.ToArray());
        }
        #endregion

        #region button ket noi
        private void btnKetnoi_Click(object sender, EventArgs e)
        {
            try
            {
                int baud = int.Parse(cbBAUD.Text);
                String COM = cbCOM.Text;
                connect_Port(serial, COM, baud);
                serial.Write("S");
            }
            catch (Exception)
            {
                MessageBox.Show("Tốc độ baudrate không hợp lệ!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNgatketnoi_Click(object sender, EventArgs e)
        {
            disconnect_Port(serial);
            get_PortName(cbCOM);
            cbCOM.SelectedIndex = 0;
            cbBAUD.SelectedIndex = 0;
            txtNhietdo.Text = "00";
            txtDoam.Text = "00";
        }
        #endregion

        #region xu ly Data
        private void tab_Data()
        {

            dataGV_Data.AutoGenerateColumns = false;
            const int NumberColumn = 4;
            dataGV_Data.ColumnCount = NumberColumn;
            string[] list = new string[NumberColumn] { "Diadiem", "Thoigian", "Nhietdo", "Doam" };
            string[] header_name = new string[NumberColumn] { "Địa Điểm ", "Thời Gian","Nhiệt Độ ( độ C ) ", "Độ Ẩm ( % )"};
            int[] width_col = new int[NumberColumn] { 425, 225, 225, 225 };
            for (int i = 0; i < NumberColumn; i++)
            {
                dataGV_Data.Columns[i].Name = list[i];
                dataGV_Data.Columns[i].DataPropertyName = list[i];
                dataGV_Data.Columns[i].HeaderText = header_name[i];
                dataGV_Data.Columns[i].Width = width_col[i];
                dataGV_Data.Columns[i].ValueType = typeof(String);
                dataGV_Data.Columns[i].Visible = true;
            }
        }

        // load data vao datagridview
        private void loadData(string source, DataGridView data)
        {
            System.Data.DataTable my_data = new System.Data.DataTable();
            //OleDbDataReader reader = Program.DataBase.SelectSQL("SELECT * FROM " + source);
            my_data.Load(Program.DataBase.SelectSQL("SELECT * FROM " + source));
            data.DataSource = my_data;
            my_data.Dispose();

        }
        // Xuat EXCEL
        public void ToExcel(DataGridView data, string fileName, string worksheetName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //worksheet = workbook.Sheets[1];
                //đặt tên cho sheet
                worksheet.Name = worksheetName;

                // export header trong DataGridView
                for (int i = 0; i < data.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = data.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < data.RowCount - 1; i++)
                {
                    for (int j = 0; j < data.ColumnCount; j++)
                    {
                        //worksheet.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                        if (data.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
        #endregion

        private void btnXoadata_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                try
                {
                    String sql = "Delete FROM Data";
                    Program.DataBase.UpdateSQL(sql);
                    loadData("Data", dataGV_Data);
                    MessageBox.Show("Xóa dữ liệu thành công");
                }
                catch(Exception)
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel|*.xls|Excel 2010|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ToExcel(dataGV_Data, saveFileDialog1.FileName, "Dữ Liệu");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void timer_UpdateData_Tick(object sender, EventArgs e)
        {
            try
            {
                if (serial.IsOpen)
                {
                    String sql = "insert into Data (Diadiem, Thoigian, Nhietdo, Doam) values ('" + txtVitri.Text + "', '"
                    + DateTime.Now.ToString("g") + "','" + txtNhietdo.Text + "','" + txtDoam.Text + "') ";
                    OleDbDataReader reader = Program.DataBase.SelectSQL(sql);

                    loadData("Data", dataGV_Data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập Nhật thất bại");
            }
        }

        private void timer_ReadData_Tick(object sender, EventArgs e)
        {
            //if(DT != null)
            //{
                //txtNhietdo.Text = DT[0];
                //txtDoam.Text = DT[1];
            //    DT = null;
            //}
        }
    }
}
