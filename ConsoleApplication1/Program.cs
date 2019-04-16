using System;
using System.Collections;
using System.Diagnostics.Eventing.Reader;
using System.Xml;

namespace ConsoleApplication1
{
    internal class Program //internal : 동일한 어셈블리 코드에서는 형식이나 멤버에 액세스할 수 있지만 다른 어셈블리의 코드에서 액세스 불가
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
            float f = float.MinValue;

        
            
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
            
            CSVar obj = new CSVar();
            obj.Method1();
            //value 참조
            int var1 = 0;
            //int var2 = var1;
            int var2 = 3;
            Console.WriteLine("val1 : " + var1);
            Console.WriteLine("val2 : " + var2);
            //reference 참조
            exam1 ref1 = new exam1();
            exam1 ref2 = ref1;
            ref1.value = 123;
            Console.WriteLine(ref1.value);
            Console.WriteLine(ref2.value);

            Console.WriteLine("var1, var2  : {1},{0}",var1,var2);// 문자열 포맷 방식
            Console.WriteLine("ref1.value, ref2.value : {0},{1}",ref1.value,ref2.value);
            int[] arr1 = new int[5];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = i * i;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("arr[{0}] : {1}",i,arr1[i]);
            }

            Console.WriteLine(3.ToString()); 
            Console.WriteLine(3);
            Console.WriteLine("3");

            for (int t = 1; t < 10; t++)
            {
                for (int r = 1; r < 10; r++)
                {
                    int ans, re;
                    divide(t,r,out ans,out re);// 인수의 값이 중요하지 않음
                    Console.WriteLine("{0} / {1}  = {2} r {3}",t,r,ans,re);
                    
                }
            }
            Console.WriteLine("============================================");
            F();
            F(1,2);
            F(1,2,3);
            Stack s= new Stack();

            
        }

        static void divide(int t, int r, out int ans, out int re)
        {
            ans = t / r;
            re = t % r;
        }

        static void F(params int[] args) // 매개변수를 가변으로 지정 : params
        {
            Console.WriteLine("# of arguments : {0}", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("args[{0}]  = {1}",i,args[i]);
            }
        }
        
    }

    class exam1
    {
        public int value = 0;
    }    

    class CSVar
    {
        int globalVar; //method 밖, default value : 0
        const int MAX = 1024;
        readonly int MAX_VALUE = 100; // 상수와 비슷, 읽기 전용 

        public void Method1()
        {
            int localVar; // method 안
            localVar = 100;
            
            Console.WriteLine("globalVar : "+globalVar);
            Console.WriteLine("localVar : "+localVar);
        }
    }

}