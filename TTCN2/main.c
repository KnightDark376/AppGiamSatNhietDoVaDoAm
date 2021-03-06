#include <main.h>

setup_wdt(WDT_1000MS);
#use rs232(baud=9600, xmit=PIN_C6,rcv=PIN_C7)
#use fast_io(B)
#use fast_io(D)
#define RED             PIN_D1
#define BLUE            PIN_D0

#define LCD_ENABLE_PIN  PIN_B3
#define LCD_RS_PIN      PIN_B1
#define LCD_RW_PIN      PIN_B2
#define LCD_DATA4       PIN_B4
#define LCD_DATA5       PIN_B5
#define LCD_DATA6       PIN_B6
#define LCD_DATA7       PIN_B7
#include <lcd.c>

#define DATA            PIN_D7

#bit Data_Pin_TRIS = 0x88.7
#bit Data_Pin = 0x08.7

int8 RH_byte1;
int8 RH_byte2;
int8 T_byte1;
int8 T_byte2;
char str[20];
void DHT11_start()
{ 
   Data_Pin_TRIS = 0;
   Data_Pin = 0;
   delay_ms(18);
   Data_Pin = 1;
   Data_Pin_TRIS = 1;
   delay_us(40); // doi 20-40us thi data xuong 0
   if(Data_Pin == 0)
   {
      delay_us(80); //doi 80us thi Data len 1
      if(Data_Pin == 1)
      {
         delay_us(80);
      }
      output_low(RED);
   }
   else output_high(RED);
}
void Read_DTH11()
{
   int1 test=0;
   int a[40];
   
   while(test==0)
   { 
      DHT11_start();
      //lcd_gotoxy(1,1);
      //printf(lcd_putc,"Dang ket noi...");
      //Nhan du lieu
      for(int i = 0; i<40; i++)
      {
         while(Data_Pin == 0); //doi len 1
         delay_us(50);
         if(Data_Pin == 1) //trong >28us ma data van =1 thi se gui bit 1
         {
            a[i] = 1;
            while(Data_Pin == 1){}  //doi xuong 0, ket thuc qua trinh nhan 1 bit
         }
         else a[i] = 0;
      }  
      //Xu ly du lieu
      for(i=0; i<8; i++)
      RH_byte1 = (RH_byte1<<1) | a[i]; //RH_byte1 = bit0.byte RH_byte1 (=0) + a[i](= 0 or1) 
      for(i=8; i<16; i++)
      RH_byte2 = (RH_byte2<<1) | a[i]; 
      for(i=16; i<24; i++)
      T_byte1 = (T_byte1<<1) | a[i]; 
      for(i=24; i<32; i++)
      T_byte2 = (T_byte2<<1) | a[i]; 
      for(i=32; i<40; i++)
      int8 CheckSum = (CheckSum<<1) | a[i]; //CheckSum =byte5
      if(CheckSum == T_byte1 + T_byte2 + RH_byte1+ RH_byte2) test=1;
    }
}

void main()
{
   port_b_pullups(0);
   set_tris_b(0);
   set_tris_d(0);
   output_low(RED);
   output_low(BLUE);
   lcd_init();
   lcd_putc("\f");
   int1 flash = 0;
   while(TRUE)
   {
      restart_wdt();
      delay_ms(500);
      Read_DTH11();
      
      if (flash == 0)
      {
         lcd_gotoxy(1,1);
         printf(lcd_putc,"Do am       %d ", RH_byte1);
         lcd_putc("%");
         lcd_gotoxy(1,2);
         printf(lcd_putc,"Nhiet do    %doC", T_byte1);
         
      }
      if (flash == 1)
      {
         lcd_gotoxy(1,1);
         printf(lcd_putc,"Do am   :   %d ", RH_byte1);
         lcd_putc("%");
         lcd_gotoxy(1,2);
         printf(lcd_putc,"Nhiet do:   %doC", T_byte1);
      }
      if (flash == 0) flash = 1;
      else flash = 0;
      sprintf(str,"%d|%d|", T_byte1, RH_byte1);
      puts(str);
   }

}
