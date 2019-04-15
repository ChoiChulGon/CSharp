using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("asdasdasdas");
            string aFriend = "Bill"; //변수
            Console.WriteLine(aFriend);
            Console.WriteLine("tt" + aFriend);

            string firstFriend = "maria";
            string secondFriend = "Sage";
            Console.WriteLine("My Friend are "+firstFriend+" and {secondFriend}");

            string greeting = "Hello world";
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine(string.Format("[{0}]", trimmedGreeting));

            greeting = greeting.Replace("Hello", "Greeting");
            Console.WriteLine(greeting);
            Console.WriteLine(greeting.ToUpper());
            Console.WriteLine(greeting.ToLower());

            string strVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Console.WriteLine("c# version : "+strVersion);
            int i = int.MaxValue;
            float f = float.MinValue;
            Console.WriteLine(i + "  " + f);
            
            Console.WriteLine("=========================================");

            int? val = null;
            Console.WriteLine(val + "is null?");

            val = 101;
            Console.WriteLine(val);

            bool? boolVal = null;
            
            //int?를 int로 할당 (Nullable의 .Value 속성을 사용) , 컴파일하면 .NET의 Nullable<T> 타입으로 변환됨.
            Nullable<int> j = null;
            j = 10;
            int k = j.Value;
            Console.WriteLine("k :" + k);
        }
    }
}