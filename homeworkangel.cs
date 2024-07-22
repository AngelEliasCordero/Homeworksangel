using System;
class HelloWorld {
  static void Main(string[] args) {
    
    Console.WriteLine("Enter the first number: ");
    string input1 = Console.ReadLine();
    
    Console.WriteLine("Enter the second number: ");
    string input2 = Console.ReadLine();
    
    try {
        
        int number1 = Convert.ToInt32(input1);
        int number2 = Convert.ToInt32(input2);
        
        int result = number1 / number2;
        Console.WriteLine($"The result of {number1} divided by {number2} is: {result}");
        
    }
    
    catch (FormatException ){
        
        Console.WriteLine("Error: one or two of the input are not interger.");
        
    }
    
    catch (DivideByZeroException){
        
        Console.WriteLine("Error: you can not divide by zero");
    }
     
     
     }
    
  }
