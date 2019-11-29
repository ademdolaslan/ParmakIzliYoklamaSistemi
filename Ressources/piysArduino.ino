#include <Adafruit_Fingerprint.h>
#include <SoftwareSerial.h>
SoftwareSerial mySerial(2, 3);
Adafruit_Fingerprint finger = Adafruit_Fingerprint(&mySerial);
void setup()  
{
  Serial.begin(9600);
  while (!Serial);
  delay(100);
  finger.begin(57600);  
  if (finger.verifyPassword()) 
  {
    Serial.println("Parmak izi sensörü bulundu.");
  }
  else 
  {
    Serial.println("Parmak izi sensörü bulunamadı.(");
    while (1) { delay(1); }
  }
  Serial.println("Parmak Bekleniyor.");
}
void loop()                     
{  
  Serial.println(getFingerprintIDez());
  delay(50);
}
String getFingerprintIDez() 
{
  uint8_t p = finger.getImage();
  if (p != FINGERPRINT_OK)  return "a";

  p = finger.image2Tz();
  if (p != FINGERPRINT_OK)  return "b";

  p = finger.fingerFastSearch();
  if (p != FINGERPRINT_OK)  return "c";  
  return String(finger.fingerID); 
}
