
#include "DFRobot_PH.h"
#include "DFRobot_EC.h"
#include <EEPROM.h>
#include <dht11.h>
dht11 DHT;

#define DHT11_PIN A0
#define PH_PIN A1
#define EC_PIN A2
String textForSMS;
float p = 0;
float e = 0;
int t = 0;
int h = 0;
float  voltagePH, voltageEC, phValue, ecValue, temperature = 25;
DFRobot_PH ph;
DFRobot_EC ec;

void setup()
{

  Serial.begin(115200);
  ph.begin();
  ec.begin();
  Serial.begin(9600);
}
void loop()
{
  char cmd[10];
  static unsigned long timepoint = millis();
  if (millis() - timepoint > 1000U) {                      //time interval: 1s
    timepoint = millis();
    temperature = readTemperature();                   // read your temperature sensor to execute temperature compensation
    voltagePH = analogRead(PH_PIN) / 1024.0 * 5000;      // read the ph voltage
    p    = (-1.6302 * ph.readPH( voltagePH, temperature) + 13.205);      // convert voltage to pH with temperature compensation
    
    voltageEC = analogRead(EC_PIN) / 1024.0 * 5000;
    e    = ec.readEC(voltageEC, temperature);      // convert voltage to EC with temperature compensation
    t = (DHT.temperature * 1.8 + 32);   //Convert Celsius to fahrenheit
    

   
    h = (DHT.humidity);

    textForSMS = textForSMS + p + "," + e + "," + t + "," + h + ",";
    Serial.println(textForSMS);
      textForSMS = "";

    delay(2000);
  }
}

float readTemperature()     //DHT11 check
{
  int chk = DHT.read(DHT11_PIN);    // READ DATA= DHT.read(DHT11_PIN);    // READ DATA
  Serial.print("DHT11, \t");
  switch (chk) {
    case DHTLIB_OK:
      Serial.print("OK,\n");
      break;
    case DHTLIB_ERROR_CHECKSUM:
      Serial.print("Checksum error,\t");
      break;
    case DHTLIB_ERROR_TIMEOUT:
      Serial.print("Time out error,\t");
      break;
    default:
      Serial.print("Unknown error,\t");
      break;
  }
}
