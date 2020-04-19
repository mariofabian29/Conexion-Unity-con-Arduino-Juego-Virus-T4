//Inicio los potenciómetros en los pines analógicos A2 A3 A4 y el botón en el pin digital 7
int PotenciometroAnalog1 = A2;
int PotenciometroAnalog2 = A3;
int PotenciometroAnalog3 = A4;
const int BotonDigital = 7;

//Variable donde se almacenan los datos recibidos
int dato1 = 0;
int dato2 = 0;
int dato3 = 0;
int dato4 = 0;

//Variable donde se almacenan los datos ya mapeados
int Mapeado1;
int Mapeado2;
int Mapeado3;

void setup() {
  //Inicialización de los potenciómetros
  Serial.begin(9600);
  pinMode(PotenciometroAnalog1, INPUT);
  pinMode(PotenciometroAnalog2, INPUT);
  pinMode(PotenciometroAnalog3, INPUT);
  pinMode(BotonDigital, INPUT);

  digitalWrite(BotonDigital, HIGH);

}

void loop() {
  //Almacenar los datos de los potenciómetros en la variable
  dato1 = analogRead(PotenciometroAnalog1);
  dato2 = analogRead(PotenciometroAnalog2);
  dato3 = analogRead(PotenciometroAnalog3);

  //Mapeo de los datos almacenados en la linea anterior
  Mapeado1 = map(dato1, 0, 1024, 0, 4);
  Mapeado2 = map(dato2, 0, 1024, 0, 17);
  Mapeado3 = map(dato3, 0, 1024, 0, 6);

  if (digitalRead(BotonDigital) == HIGH) // if the switch is pressed
  {
    dato4 = 1;
  }
  else if (digitalRead(BotonDigital) == LOW) {
    dato4 = 0;
  }

  Serial.print(Mapeado1);
Serial.print(",");
Serial.print(Mapeado2);
Serial.print(",");
Serial.print(Mapeado3);
Serial.print(",");
Serial.println(dato4);
Serial.flush();
delay(20);
}







//Fin del código
