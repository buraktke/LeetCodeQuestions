using global;
using IntToRoman;

namespace Calismalar
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public void Question1()
        {
            int[] nums = new int[] { 2, 4, 5, 1, 3 };
            QTwoSum q1 = new QTwoSum();
            int[] numsS = q1.TwoSum(nums, 8);

            Console.WriteLine(numsS[0] + " " + numsS[1]);
        }
        public void Question2()
        {
            QPalindromeNumber d = new();
            Console.WriteLine(d.PalindromeNumber(121));
        }
        public void Question3()
        {
            string[] d = new[] { "flower", "flow", "flight", "fl" };
            QLongestCommonPrefix k = new();
            Console.WriteLine(k.LongestCommonPrefix(d));
        }
        public void Question4()
        {
            QRomanToInt q4 = new QRomanToInt();
            Console.WriteLine(q4.RomanToInt("MCMXCIV"));
        }
        public void Question5()
        {
            QParkingSystem parkingSystem = new QParkingSystem(2, 1, 4);
            Console.WriteLine(parkingSystem.AddCar(1));
            Console.WriteLine(parkingSystem.AddCar(1));
            Console.WriteLine(parkingSystem.AddCar(1));
            Console.WriteLine(parkingSystem.AddCar(2));
            Console.WriteLine(parkingSystem.AddCar(2));
            Console.WriteLine(parkingSystem.AddCar(3));
            Console.WriteLine(parkingSystem.AddCar(3));
        }
        public void Question6()
        {
            #region Çözüm 1
            QMyHashMap myHashMap = new QMyHashMap();
            myHashMap.Put(1, 12);
            myHashMap.Put(2, 8);
            Console.WriteLine(myHashMap.Get(3));
            Console.WriteLine(myHashMap.Get(2));
            myHashMap.Remove(2);
            Console.WriteLine(myHashMap.Get(2));
            Console.WriteLine(myHashMap.Get(1));
            #endregion

            #region Çözüm 2
            QMyHashMap2 myHashMap2 = new QMyHashMap2();
            myHashMap2.Put(1, 12);
            myHashMap2.Put(2, 8);
            Console.WriteLine(myHashMap2.Get(3));
            Console.WriteLine(myHashMap2.Get(2));
            myHashMap2.Remove(2);
            Console.WriteLine(myHashMap2.Get(2));
            Console.WriteLine(myHashMap2.Get(1));
            #endregion
        }
        public void Question7()
        {
            QMyHashSet myHasSet = new QMyHashSet();
            myHasSet.Add(1);
            myHasSet.Add(2);
            myHasSet.Add(3);
            myHasSet.Remove(2);
            Console.WriteLine(myHasSet.Contains(1));
            Console.WriteLine(myHasSet.Contains(2));
        }
        public void Question8()
        {
            #region Çözüm 1
            QMyStack qMyStack = new QMyStack();
            qMyStack.Push(1);
            qMyStack.Push(2);
            qMyStack.Push(3);
            qMyStack.Push(4);
            qMyStack.Push(2);
            Console.WriteLine(qMyStack.Top());
            Console.WriteLine(qMyStack.Pop());
            Console.WriteLine(qMyStack.Top());
            Console.WriteLine(qMyStack.Empty());
            #endregion

            #region Çözüm 2
            QMyStack2 qMyStack2 = new QMyStack2();
            qMyStack2.Push(1);
            qMyStack2.Push(2);
            qMyStack2.Push(3);
            qMyStack2.Push(4);
            qMyStack2.Push(2);
            Console.WriteLine(qMyStack2.Top());
            Console.WriteLine(qMyStack2.Pop());
            Console.WriteLine(qMyStack2.Top());
            Console.WriteLine(qMyStack2.Empty());
            #endregion
        }
        public void Question9()
        {
            QIntToRoman qIntToRoman = new QIntToRoman();
            Console.WriteLine(qIntToRoman.IntToRoman(3749));
        }

    }
}
