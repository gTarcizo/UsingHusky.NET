using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingHusky.NET.Classes
{
   public class Subtract : Calculate
   {
      public Subtract(int[] numbers) : base(numbers)
      {
         SubtractNumbers(numbers);
      }

      public int SubtractNumbers(int[] numbers)
      {
         Result = 0;
         foreach (var number in numbers)
         {
            Result -= number;
         }
         return Result;
      }
   }
}
