#define red 11
#define green 10
#define blue 9
 
void setup() 
{
  Serial.begin(9600);
  pinMode(red, OUTPUT);
  pinMode(green, OUTPUT);
  pinMode(blue, OUTPUT);
}
 
 
void loop() 
{
  char data = Serial.read();
  switch(data)
  {
    case 'r':
      digitalWrite(red, HIGH);
      break;
    
    case 'g':
      digitalWrite(green, HIGH);  
      break;
    
    case 'b':
      digitalWrite(blue, HIGH);  
      break;

  case 'o':
      digitalWrite(red, LOW); 
      digitalWrite(green, LOW);
      digitalWrite(blue, LOW);
      break;
  }   
}

