
namespace App
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.plthongso = new System.Windows.Forms.Panel();
            this.plSolieu = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEXCEL = new System.Windows.Forms.Button();
            this.btnXoadata = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDoam = new System.Windows.Forms.TextBox();
            this.txtNhietdo = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.plConnect = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNgatketnoi = new System.Windows.Forms.Button();
            this.btnKetnoi = new System.Windows.Forms.Button();
            this.txtVitri = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbBAUD = new System.Windows.Forms.ComboBox();
            this.cbCOM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGV_Data = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diadiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nhietdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer_UpdateData = new System.Windows.Forms.Timer(this.components);
            this.timer_ReadData = new System.Windows.Forms.Timer(this.components);
            this.plthongso.SuspendLayout();
            this.plSolieu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plConnect.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // plthongso
            // 
            this.plthongso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plthongso.Controls.Add(this.plSolieu);
            this.plthongso.Controls.Add(this.plConnect);
            this.plthongso.Dock = System.Windows.Forms.DockStyle.Top;
            this.plthongso.Location = new System.Drawing.Point(0, 0);
            this.plthongso.Name = "plthongso";
            this.plthongso.Size = new System.Drawing.Size(1547, 300);
            this.plthongso.TabIndex = 0;
            // 
            // plSolieu
            // 
            this.plSolieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plSolieu.Controls.Add(this.groupBox2);
            this.plSolieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plSolieu.Location = new System.Drawing.Point(711, 0);
            this.plSolieu.Name = "plSolieu";
            this.plSolieu.Size = new System.Drawing.Size(832, 296);
            this.plSolieu.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEXCEL);
            this.groupBox2.Controls.Add(this.btnXoadata);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtDoam);
            this.groupBox2.Controls.Add(this.txtNhietdo);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 292);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Số";
            // 
            // btnEXCEL
            // 
            this.btnEXCEL.FlatAppearance.BorderSize = 2;
            this.btnEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXCEL.Location = new System.Drawing.Point(479, 224);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(184, 46);
            this.btnEXCEL.TabIndex = 3;
            this.btnEXCEL.Text = "EXCEL";
            this.btnEXCEL.UseVisualStyleBackColor = true;
            this.btnEXCEL.Click += new System.EventHandler(this.btnEXCEL_Click);
            // 
            // btnXoadata
            // 
            this.btnXoadata.FlatAppearance.BorderSize = 2;
            this.btnXoadata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoadata.Location = new System.Drawing.Point(134, 224);
            this.btnXoadata.Name = "btnXoadata";
            this.btnXoadata.Size = new System.Drawing.Size(184, 46);
            this.btnXoadata.TabIndex = 3;
            this.btnXoadata.Text = "Xóa";
            this.btnXoadata.UseVisualStyleBackColor = true;
            this.btnXoadata.Click += new System.EventHandler(this.btnXoadata_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::App.Properties.Resources.icons8_percentage_48;
            this.pictureBox2.Location = new System.Drawing.Point(719, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::App.Properties.Resources.icons8_celsius_48;
            this.pictureBox1.Location = new System.Drawing.Point(301, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtDoam
            // 
            this.txtDoam.BackColor = System.Drawing.Color.White;
            this.txtDoam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoam.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoam.Location = new System.Drawing.Point(567, 74);
            this.txtDoam.Name = "txtDoam";
            this.txtDoam.Size = new System.Drawing.Size(161, 68);
            this.txtDoam.TabIndex = 1;
            this.txtDoam.Text = "00";
            // 
            // txtNhietdo
            // 
            this.txtNhietdo.BackColor = System.Drawing.Color.White;
            this.txtNhietdo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNhietdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhietdo.Location = new System.Drawing.Point(154, 74);
            this.txtNhietdo.Name = "txtNhietdo";
            this.txtNhietdo.Size = new System.Drawing.Size(152, 68);
            this.txtNhietdo.TabIndex = 1;
            this.txtNhietdo.Text = "00";
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::App.Properties.Resources.icons8_snow_96;
            this.button6.Location = new System.Drawing.Point(397, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 160);
            this.button6.TabIndex = 0;
            this.button6.Text = "Độ ẩm";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::App.Properties.Resources.icons8_temperature_96;
            this.button5.Location = new System.Drawing.Point(6, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 160);
            this.button5.TabIndex = 0;
            this.button5.Text = "Nhiệt độ ";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // plConnect
            // 
            this.plConnect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plConnect.Controls.Add(this.groupBox1);
            this.plConnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.plConnect.Location = new System.Drawing.Point(0, 0);
            this.plConnect.Name = "plConnect";
            this.plConnect.Size = new System.Drawing.Size(711, 296);
            this.plConnect.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNgatketnoi);
            this.groupBox1.Controls.Add(this.btnKetnoi);
            this.groupBox1.Controls.Add(this.txtVitri);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbBAUD);
            this.groupBox1.Controls.Add(this.cbCOM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết Nối";
            // 
            // btnNgatketnoi
            // 
            this.btnNgatketnoi.BackColor = System.Drawing.Color.Red;
            this.btnNgatketnoi.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnNgatketnoi.FlatAppearance.BorderSize = 2;
            this.btnNgatketnoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgatketnoi.Location = new System.Drawing.Point(468, 109);
            this.btnNgatketnoi.Name = "btnNgatketnoi";
            this.btnNgatketnoi.Size = new System.Drawing.Size(207, 52);
            this.btnNgatketnoi.TabIndex = 4;
            this.btnNgatketnoi.Text = "Ngắt kết nối ";
            this.btnNgatketnoi.UseVisualStyleBackColor = false;
            this.btnNgatketnoi.Click += new System.EventHandler(this.btnNgatketnoi_Click);
            // 
            // btnKetnoi
            // 
            this.btnKetnoi.BackColor = System.Drawing.Color.Blue;
            this.btnKetnoi.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnKetnoi.FlatAppearance.BorderSize = 2;
            this.btnKetnoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetnoi.Location = new System.Drawing.Point(468, 32);
            this.btnKetnoi.Name = "btnKetnoi";
            this.btnKetnoi.Size = new System.Drawing.Size(207, 52);
            this.btnKetnoi.TabIndex = 4;
            this.btnKetnoi.Text = "Kết nối ";
            this.btnKetnoi.UseVisualStyleBackColor = false;
            this.btnKetnoi.Click += new System.EventHandler(this.btnKetnoi_Click);
            // 
            // txtVitri
            // 
            this.txtVitri.AllowDrop = true;
            this.txtVitri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.txtVitri.ForeColor = System.Drawing.Color.White;
            this.txtVitri.Location = new System.Drawing.Point(142, 212);
            this.txtVitri.Name = "txtVitri";
            this.txtVitri.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtVitri.Size = new System.Drawing.Size(559, 38);
            this.txtVitri.TabIndex = 3;
            this.txtVitri.Text = "Hòa Khánh Bắc, Liên Chiểu, Đà Nẵng ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::App.Properties.Resources.icons8_location_40;
            this.button1.Location = new System.Drawing.Point(25, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vị trí";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbBAUD
            // 
            this.cbBAUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.cbBAUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBAUD.ForeColor = System.Drawing.Color.White;
            this.cbBAUD.FormattingEnabled = true;
            this.cbBAUD.Items.AddRange(new object[] {
            "Select Baudrate...",
            "9600",
            "19200",
            "38400",
            "56000",
            "115200"});
            this.cbBAUD.Location = new System.Drawing.Point(142, 117);
            this.cbBAUD.Name = "cbBAUD";
            this.cbBAUD.Size = new System.Drawing.Size(281, 39);
            this.cbBAUD.TabIndex = 1;
            // 
            // cbCOM
            // 
            this.cbCOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.cbCOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCOM.ForeColor = System.Drawing.Color.White;
            this.cbCOM.FormattingEnabled = true;
            this.cbCOM.Location = new System.Drawing.Point(142, 40);
            this.cbCOM.Name = "cbCOM";
            this.cbCOM.Size = new System.Drawing.Size(281, 39);
            this.cbCOM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "BAUD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGV_Data);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1547, 603);
            this.panel1.TabIndex = 1;
            // 
            // dataGV_Data
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGV_Data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGV_Data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dataGV_Data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Diadiem,
            this.Thoigian,
            this.Nhietdo,
            this.Doam});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGV_Data.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGV_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_Data.GridColor = System.Drawing.Color.Aqua;
            this.dataGV_Data.Location = new System.Drawing.Point(0, 0);
            this.dataGV_Data.Name = "dataGV_Data";
            this.dataGV_Data.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_Data.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGV_Data.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGV_Data.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGV_Data.RowTemplate.Height = 24;
            this.dataGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGV_Data.Size = new System.Drawing.Size(1543, 599);
            this.dataGV_Data.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 125;
            // 
            // Diadiem
            // 
            this.Diadiem.HeaderText = "Địa điểm";
            this.Diadiem.MinimumWidth = 6;
            this.Diadiem.Name = "Diadiem";
            this.Diadiem.ReadOnly = true;
            this.Diadiem.Width = 200;
            // 
            // Thoigian
            // 
            this.Thoigian.HeaderText = "Thời gian";
            this.Thoigian.MinimumWidth = 6;
            this.Thoigian.Name = "Thoigian";
            this.Thoigian.ReadOnly = true;
            this.Thoigian.Width = 150;
            // 
            // Nhietdo
            // 
            this.Nhietdo.HeaderText = "Nhiệt độ";
            this.Nhietdo.MinimumWidth = 6;
            this.Nhietdo.Name = "Nhietdo";
            this.Nhietdo.ReadOnly = true;
            this.Nhietdo.Width = 125;
            // 
            // Doam
            // 
            this.Doam.HeaderText = "Độ ẩm";
            this.Doam.MinimumWidth = 6;
            this.Doam.Name = "Doam";
            this.Doam.ReadOnly = true;
            this.Doam.Width = 125;
            // 
            // timer_UpdateData
            // 
            this.timer_UpdateData.Interval = 60000;
            this.timer_UpdateData.Tick += new System.EventHandler(this.timer_UpdateData_Tick);
            // 
            // timer_ReadData
            // 
            this.timer_ReadData.Tick += new System.EventHandler(this.timer_ReadData_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1547, 903);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plthongso);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giám sát nhiệt độ và độ ẩm";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.plthongso.ResumeLayout(false);
            this.plSolieu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plConnect.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plthongso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGV_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diadiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nhietdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doam;
        private System.Windows.Forms.Panel plSolieu;
        private System.Windows.Forms.Panel plConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVitri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbBAUD;
        private System.Windows.Forms.ComboBox cbCOM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNgatketnoi;
        private System.Windows.Forms.Button btnKetnoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNhietdo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtDoam;
        private System.Windows.Forms.Button btnEXCEL;
        private System.Windows.Forms.Button btnXoadata;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer_UpdateData;
        private System.Windows.Forms.Timer timer_ReadData;
    }
}

