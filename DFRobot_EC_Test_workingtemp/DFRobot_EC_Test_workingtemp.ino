/*
   file DFRobot_EC.ino
   @ https://github.com/DFRobot/DFRobot_EC

   This is the sample code for Gravity: Analog Electrical Conductivity Sensor / Meter Kit V2 (K=1.0), SKU: DFR0300.
   In order to guarantee precision, a temperature sensor such as DS18B20 is needed, to execute automatic temperature compensation.
   You can send commands in the serial monitor to execute the calibration.
   Serial Commands:
     enterec -> enter the calibration mode
     calec -> calibrate with the standard buffer solution, two buffer solutions(1413us/cm and 12.88ms/cm) will be automaticlly recognized
     exitec -> save the calibrated parameters and exit from calibration mode

   Copyright   [DFRobot](http://www.dfrobot.com), 2018
   Copyright   GNU Lesser General Public License

   version  V1.0
   date  2018-03-21
*/

#include "DFRobot_EC.h"
#include <EEPROM.h>
#include <dht11.h>
dht11 DHT;

#define DHT11_PIN A0
#define EC_PIN A2
float voltage, ecValue, temperature = 25;
DFRobot_EC ec;

void setup()
{
  Serial.begin(115200);
  ec.begin();
  Serial.begin(9600);
}

void loop()
{
  static unsigned long timepoint = millis();
  if (millis() - timepoint > 1000U) //time interval: 1s
  {
    timepoint = millis();
    voltage = analogRead(EC_PIN) / 1024.0 * 5000; // read the voltage
    temperature = readTemperature();          // read your temperature sensor to execute temperature compensation
    ecValue =  ec.readEC(voltage, temperature); // convert voltage to EC with temperature compensation
    Serial.print("temperature:");
    Serial.print(DHT.temperature * 1.8 + 32);
    Serial.print("^F  EC:");
    Serial.print(ecValue, 2);
    Serial.println("ms/cm");
  }
  ec.calibration(voltage, temperature);         // calibration process by Serail CMD
}

float readTemperature()
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