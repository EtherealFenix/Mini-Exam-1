using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Welcome to the 10 person BMI calculator.");
    string[] positions = new string[10]{"1st","2nd","3rd","4th","5th","6th","7th","8th","9th","10th"};
    
    for (int i=0; i<10; i++){
      Console.WriteLine("Please input the name of the "+positions[i]+" person:");
      string name = Console.ReadLine();
      Console.WriteLine("Please input the height in inches of the "+positions[i]+" person:");
      double height = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Please input the weight in pounds of the "+positions[i]+" person:");
      double weight = Convert.ToDouble(Console.ReadLine());
      double BMI = 703*weight/height/height;
      Console.WriteLine("The BMI of "+name+" is "+BMI+".");
      //unclear why designer request this part be written in 2nd person, when it is unlikely the user is all 10 people.
      if (BMI<18.5){
        Console.WriteLine("You are underweight.");
      }
      else if (BMI<25){
        Console.WriteLine("You are normal weight.");
      }
      else if (BMI<30){
        Console.WriteLine("You are overweight.");
      }
      else{
        Console.WriteLine("You are obese.");
      }
    }

  }
}