// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
   
//     {

      
//       if (firstNumber > secondNumber)
//         Console.WriteLine("первое число больше");
//   else if (firstNumber < secondNumber)
//       Console.WriteLine("второе число больше");
//   else
//         Console.WriteLine("числа равны");
//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 6;
//             secondNumber = 3;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }







using System;

public class Answer {
    
  static int FindMax(int a, int b, int c)
    {
      // Введите свое решение ниже
   
   int max;
    max = a;
  if (b > a)
    
  max = b;
   if (c > max)
    max = c;
    return max;
    }

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 1;
           b = 10;
           c = 8;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}