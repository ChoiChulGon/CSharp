using System;

namespace ConsoleApplication1 
{
    public class Array
    {
        //선언
        string[] players = new string[10];
        private string[] Regions = {"서울", "경기", "부산"}; // 초기화

        private string[,] Depts = {{"김과장","경리부"}, {"이과장","총무부" }}; //초기화

        private string[,,] Cubes; //선언
        
        private int[][] jaggedArray = new int[][] //new int[][] 생략 가능 
        {
            new int[] {1, 3, 5, 7, 9},
            new int[] {0, 2, 4, 6},
            new int[] {11, 22}
        };

        private int[][,] jaggedArray2 = new int[3][,]
        {
            new int[,] {{1,3},{5,7}},
            new int[,]{{0,2},{4,6},{8,10}},
            new int[,]{{11,22}, { 99,88}, {0,9}}
        };

        public void method1()
        {
            
            Console.WriteLine("{0}",jaggedArray2[0][1,0]); // using System 해놈.
        }
    }
}