
#include "DFRobot_PH.h"
#include "DFRobot_EC.h"
#include <EEPROM.h>
#include <dht11.h>
dht11 DHT;

#define DHT11_PIN A0
#define PH_PIN A1
#define EC_PIN A2
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
    phValue    = ph.readPH(voltagePH, temperature);      // convert voltage to pH with temperature compensation
    Serial.print("pH:");
    Serial.print(phValue , 2);
    voltageEC = analogRead(EC_PIN) / 1024.0 * 5000;
    ecValue    = ec.readEC(voltageEC, temperature);      // convert voltage to EC with temperature compensation
    Serial.print(", EC:");
    Serial.print(ecValue, 2);
    Serial.println("ms/cm");
    
    Serial.print("Temperature = ");             //Print out temperature
    Serial.print(DHT.temperature * 1.8 + 32);   //Convert Celsius to fahrenheit
    Serial.println("F");

    Serial.print("Humidity = ");        //Print relative humidity
    Serial.print(DHT.humidity);
    Serial.println("%");
    Serial.print('\n');
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
