#include <16F877A.h>
#device ADC=16

#FUSES WDT                    //No Watch Dog Timer
#FUSES NOBROWNOUT               //No brownout reset
#FUSES NOLVP                    //No low voltage prgming, B3(PIC16) or B5(PIC18) used for I/O

//#device ICD=TRUE
#use delay(crystal=8MHz)

