#include <Wire.h> 
#include <LiquidCrystal_I2C.h>
#include <Servo.h>
#define SERVO_VAO 5
#define SERVO_RA 6
#define btndo_vao 3
#define btnxanh_ra 4
Servo sv_vao, sv_ra; 
LiquidCrystal_I2C lcd(0x27, 16, 2);
int a=0 , b=0, c=0, d=0, e=0, f=0;
int count=0;
void setup()
{
  // initialize the LCD
 Serial.begin(9600);
  lcd.begin();
  lcd.backlight();
  sv_vao.attach(SERVO_VAO);
  sv_ra.attach(SERVO_RA);
  pinMode(btndo_vao, INPUT_PULLUP);
  pinMode(btnxanh_ra, INPUT_PULLUP);
}
void loop()
{
   if(digitalRead(btndo_vao)==0)
    {
      sv_vao.write(40);
      delay(4000);
      sv_vao.write(107);
    }
   else
    sv_vao.write(107);
  if(digitalRead(btnxanh_ra)==0)
    {
      sv_ra.write(80);
      delay(4000);
      sv_ra.write(170);
    }
   else
    sv_ra.write(170);
    ////////////////
  if(digitalRead(8)==0)
  {
          a = 1;
  }
  else
  {
    a = 0;
   }

   if(digitalRead(9)==0)
  {
          b = 1;
  }
  else
  {
    b = 0;
   }
   if(digitalRead(10)==0)
  {
          c = 1;
  }
  else
  {
    c= 0;
   }

   if(digitalRead(11)==0)
  {
          d = 1;
  }
  else
  {
    d = 0;
   }
   if(digitalRead(12)==0)
  {
          e = 1;
  }
  else
  {
    e = 0;
  }
   if(digitalRead(13)==0)
  {
          f = 1;
  }
  else
  {
    f = 0;
  }

   count = a+b+c+d+e+f;
     //lcd.setCursor(12,0);
  //lcd.print(count);


  if (count == 6) 
  {
     lcd.setCursor(0,1);
    lcd.print("Full slot, Sorry");
  }
  else
  {
       lcd.setCursor(0,1);
        //lcd.print("Welcome, ");
        lcd.print(6 - count);
        lcd.print(" Slot available");
  }

 lcd.setCursor(3,0);
 lcd.print("TK Parking");
}
