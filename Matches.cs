using System;
using System.Collections.Generic;
using System.Text;

namespace OWL_Standings
{
    class Matches
    {
        public void Match_Result(Team A, Team B, int w1, int w2,int mat)
        {
            if (mat == 1)
            {
                A.MW1 = A.MW1+ w1;
                A.ML1 = A.ML1 + w2;
                B.MW1 = B.MW1 + w2;
                B.ML1 = B.ML1 + w1;
                if (w1> w2)
                    A.Points1++;
                if (w2 > w1)
                    B.Points1++;
                A.Mat1++;
                B.Mat1++;
            }
            if (mat == 2)
            {
                A.MW2 = A.MW2 + w1;
                A.ML2 = A.ML2 + w2;
                B.MW2 = B.MW2 + w2;
                B.ML2 = B.ML2 + w1;
                A.Mat2++;
                B.Mat2++;
                
                if (w1 > w2)
                    A.Points2++;
                if (w2 > w1)
                    B.Points2++;
            }
            if (mat == 3)
            {
                A.MW3 = A.MW3 + w1;
                A.ML3 = A.ML3 + w2;
                B.MW3 = B.MW3 + w2;
                B.ML3 = B.ML3 + w1;
                A.Mat3++;
                B.Mat3++;
            
                if (w1 > w2)
                    A.Points3++;
                if (w2 > w1)
                    B.Points3++;
            }
            if (mat == 4)
            {
                A.MW4 = A.MW4 + w1;
                A.ML4 = A.ML4 + w2;
                B.MW4 = B.MW4 + w2;
                B.ML4 = B.ML4 + w1;
                A.Mat4++;
                B.Mat4++;

                if (w1 > w2)
                    A.Points4++;
                if (w2 > w1)
                    B.Points4++;
            }
            if (mat == 5)
            {
                A.MW5 = A.MW5 + w1;
                A.ML5 = A.ML5 + w2;
                B.MW5 = B.MW5 + w2;
                B.ML5 = B.ML5 + w1;
                A.Mat5++;
                B.Mat5++;
                if (w1 > w2)
                    A.Points5++;
                if (w2 > w1)
                    B.Points5++;
            }
            A.MW = A.MW + w1;
            A.ML = A.ML + w2;
            B.MW = B.MW + w2;
            B.ML = B.ML + w1;

        }

        public string Match_Menu()
        {
            string ch;
            Console.WriteLine("OVERWATCH & OVERWATCH 2 LEAGUE STATS");
            Console.WriteLine("WHAT DO U WANT?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1 -- SHOW ME RESULTS OF 1st SEASON 2018");
            Console.WriteLine("2 -- SHOW ME RESULTS OF 2nd SEASON 2019");
            Console.WriteLine("3 -- SHOW ME RESULTS OF 3rd SEASON 2020");
            Console.WriteLine("4 -- SHOW ME RESULTS OF 4th SEASON 2021");
            Console.WriteLine("5 -- SHOW ME RESULTS OF 5th SEASON 2022");
            Console.WriteLine("5 -- SHOW ME FINAL RESULTS");
            Console.WriteLine("0 -- EXIT");
            Console.Write("Which case do you want: ");
            ch = Console.ReadLine();
            Console.WriteLine();
            return ch;
        }
    }
}
