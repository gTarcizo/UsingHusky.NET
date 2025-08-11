namespace UsingHusky.NET.Classes
{
   public class Sum : Calculate
   {
      public Sum(int[] numbers) : base(numbers)
      {
         SumNumbers(numbers);
      }

      public int SumNumbers(int[] numbers)
      {
         Result = 0;
         foreach (var number in numbers)
         {
            Result += number;
         }
         return Result;
      }
   }
}
