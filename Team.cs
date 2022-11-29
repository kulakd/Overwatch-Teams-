using System;
using System.Collections.Generic;
using System.Text;

namespace OWL_Standings
{
    class Team
    {
        public string Name;
        public float[] S1,S2,S3,S4,S5;
        public float F1,F2,F3,F4,F5;
        public float FINAL;
        public int MW1, MW2, MW3, MW4, MW5, MW;
        public int ML1, ML2, ML3, ML4, ML5, ML;
        public int Mat1, Mat2, Mat3, Mat4, Mat5, Mat;
        public int MD1, MD2, MD3, MD4, MD5, MD;
        public double WP1, WP2, WP3, WP4, WP5, WP;
        public int Points1 =0, Points2=0, Points3=0, Points4=0, Points5=0, Points=0;

        public Team(string N)
        {
            this.Name = N;
        }
        public void Show1()
        {
            if (Mat1 != 0)
            {
                Console.Write(Name + ": ");
                if (MW1 > 100)
                    Console.Write(String.Format("{0:0}", MW1) + "   |");
                else
                    Console.Write(String.Format("{0:0}", MW1) + "    |");

                if (ML1 > 100)
                    Console.Write(String.Format("{0:0}", ML1) + "     |");
                else
                    Console.Write(String.Format("{0:0}", ML1) + "      |");

                if (MD1 >= 100)
                    Console.Write(String.Format("{0:0}", MD1) + "   |");
                if (0 >= MD1 && MD1 > -100)
                    Console.Write(String.Format("{0:0}", MD1) + "    |");
                if (MD1 <= -100)
                    Console.Write(String.Format("{0:0}", MD1) + "   |");
                if (100 > MD1 && MD1 > 0)
                    Console.Write(String.Format("{0:0}", MD1) + "     |");
                if (Points1 > 10)
                    Console.Write(String.Format("{0:0}", Points1) + "   |");
                else
                    Console.Write(String.Format("{0:0}", Points1) + "    |");
                if (WP1 > 10)
                    Console.Write(String.Format("{0:0.0}", WP1) + "  |");
                else
                    Console.Write(String.Format("{0:0.0}", WP1) + "   |");

                Console.Write(String.Format("{0:0}", Mat1) + "     |");
                for (int i = 0; i < S1.GetLength(0); i++)
                    Console.Write(String.Format("{0:0.00}", S1[i]) + " |");
                Console.Write("Finals: " + String.Format("{0:0.00}", F1));
                Console.WriteLine();
            }
        }
        public float Final1()
        {
            F1 = Add(S1) / S1.Length;
            return F1;
        }
        public void Show2()
        {
            Console.Write(Name + ": ");
            if (MW2 > 100)
                Console.Write(String.Format("{0:0}", MW2) + "  |");
            else
                Console.Write(String.Format("{0:0}", MW2) + "   |");

            if (ML2 > 100)
                Console.Write(String.Format("{0:0}", ML2) + "     |");
            else
                Console.Write(String.Format("{0:0}", ML2) + "      |");

            if (MD2 >= 100)
                Console.Write(String.Format("{0:0}", MD2) + "    |");
            if (0 > MD2 && MD2 > -10)
                Console.Write(String.Format("{0:0}", MD2) + "     |");
            if (-10>= MD2 && MD2 > -100)
                Console.Write(String.Format("{0:0}", MD2) + "    |");
            if (10>MD2 && MD2>=0)
                Console.Write(String.Format("{0:0}", MD2) + "      |");
            if (MD2 <= -100)
                Console.Write(String.Format("{0:0}", MD2) + "   |");
            if (100 > MD2 && MD2 >= 10)
                Console.Write(String.Format("{0:0}", MD2) + "     |");
            if (Points2 >= 10)
                Console.Write(String.Format("{0:0}", Points2) + "   |");
            else
                Console.Write(String.Format("{0:0}", Points2) + "    |");
            if (WP2 > 10)
                Console.Write(String.Format("{0:0.0}", WP2) + "  |");
            else
                Console.Write(String.Format("{0:0.0}", WP2) + "   |");

            Console.Write(String.Format("{0:0}", Mat2) + "     |");
            for (int i = 0; i < S2.GetLength(0); i++)
                Console.Write(String.Format("{0:0.00}", S2[i]) + " |");
            Console.Write("Finals: " + String.Format("{0:0.00}", F2));
            Console.WriteLine();
        }
        public float Final2()
        {
            F2 = Add(S2) / S2.Length;
            return F2;
        }
        public void Show3()
        {
            Console.Write(Name + ": ");
            if (MW3 >= 100)
                Console.Write(String.Format("{0:0}", MW3) + "  |");
            else
                Console.Write(String.Format("{0:0}", MW3) + "   |");

            if (ML3 > 100)
                Console.Write(String.Format("{0:0}", ML3) + "     |");
            else
                Console.Write(String.Format("{0:0}", ML3) + "      |");

            if (MD3 >= 100)
                Console.Write(String.Format("{0:0}", MD3) + "    |");
            if (0 > MD3 && MD3 > -10)
                Console.Write(String.Format("{0:0}", MD3) + "     |");
            if (-10 >= MD3 && MD3 > -100)
                Console.Write(String.Format("{0:0}", MD3) + "    |");
            if (10 > MD3 && MD3 >= 0)
                Console.Write(String.Format("{0:0}", MD3) + "      |");
            if (MD3 <= -100)
                Console.Write(String.Format("{0:0}", MD3) + "   |");
            if (100 > MD3 && MD3 >= 10)
                Console.Write(String.Format("{0:0}", MD3) + "     |");
            if (Points3 >= 10)
                Console.Write(String.Format("{0:0}", Points3) + "   |");
            else
                Console.Write(String.Format("{0:0}", Points3) + "    |");

            if (WP3 > 10)
                Console.Write(String.Format("{0:0.0}", WP3) + "  |");
            else
                Console.Write(String.Format("{0:0.0}", WP3) + "   |");

            Console.Write(String.Format("{0:0}", Mat3) + "     |");
            for (int i = 0; i < S3.GetLength(0); i++)
                Console.Write(String.Format("{0:0.00}", S3[i]) + " |");
            Console.Write("Finals: " + String.Format("{0:0.00}", F3));
            Console.WriteLine();
        }
        public float Final3()
        {
            F3 = Add(S3) / S3.Length;
            return F3;
        }
        public void Show4()
        {
            Console.Write(Name + ": ");
            if (MW4 >= 100)
                Console.Write(String.Format("{0:0}", MW4) + "  |");
            if (10 > MW4)
                Console.Write(String.Format("{0:0}", MW4) + "    |");
            else
                Console.Write(String.Format("{0:0}", MW4) + "   |");

            if (ML4 > 100)
                Console.Write(String.Format("{0:0}", ML4) + "     |");
            else
                Console.Write(String.Format("{0:0}", ML4) + "      |");

            if (MD4 >= 100)
                Console.Write(String.Format("{0:0}", MD4) + "    |");
            if (0 > MD4 && MD4 > -10)
                Console.Write(String.Format("{0:0}", MD4) + "     |");
            if (-10 >= MD4 && MD4 > -100)
                Console.Write(String.Format("{0:0}", MD4) + "    |");
            if (10 > MD4 && MD4 >= 0)
                Console.Write(String.Format("{0:0}", MD4) + "      |");
            if (MD4 <= -100)
                Console.Write(String.Format("{0:0}", MD4) + "   |");
            if (100 > MD4 && MD4 >= 10)
                Console.Write(String.Format("{0:0}", MD4) + "     |");
            if (Points4 >= 10)
                Console.Write(String.Format("{0:0}", Points4) + "   |");
            else
                Console.Write(String.Format("{0:0}", Points4) + "    |");
            if (WP4 > 10)
                Console.Write(String.Format("{0:0.0}", WP4) + "  |");
            else
                Console.Write(String.Format("{0:0.0}", WP4) + "   |");

            Console.Write(String.Format("{0:0}", Mat4) + "     |");
            for (int i = 0; i < S4.GetLength(0); i++)
                Console.Write(String.Format("{0:0.00}", S4[i]) + " |");
            Console.Write("Finals: " + String.Format("{0:0.00}", F4));
            Console.WriteLine();
        }
        public float Final4()
        {
            F4 = Add(S4) / S4.Length;
            return F4;
        }
        public void Show5()
        {
            Console.Write(Name + ": ");
            if (MW5 == 100)
                Console.Write(String.Format("{0:0}", MW5) + "  |");
            if (100 > MW5 && MW5>=10 )
                Console.Write(String.Format("{0:0}", MW5) + "    |");
            else
                Console.Write(String.Format("{0:0}", MW5) + "   |");

            if (ML5 > 100)
                Console.Write(String.Format("{0:0}", ML5) + "     |");
            else
                Console.Write(String.Format("{0:0}", ML5) + "      |");

            if (MD5 >= 100)
                Console.Write(String.Format("{0:0}", MD5) + "    |");
            if (0 > MD5 && MD5 > -10)
                Console.Write(String.Format("{0:0}", MD5) + "     |");
            if (-10 >= MD5 && MD5 > -100)
                Console.Write(String.Format("{0:0}", MD5) + "    |");
            if (10 > MD5 && MD5 >= 0)
                Console.Write(String.Format("{0:0}", MD5) + "      |");
            if (MD5 <= -100)
                Console.Write(String.Format("{0:0}", MD5) + "   |");
            if (100 > MD5 && MD5 >= 10)
                Console.Write(String.Format("{0:0}", MD5) + "     |");
            if (Points5 >= 10)
                Console.Write(String.Format("{0:0}", Points5) + "   |");
            else
                Console.Write(String.Format("{0:0}", Points5) + "    |");
            if (WP5 > 10)
                Console.Write(String.Format("{0:0.0}", WP5) + "  |");
            else
                Console.Write(String.Format("{0:0.0}", WP5) + "   |");

            Console.Write(String.Format("{0:0}", Mat5) + "     |");
            for (int i = 0; i < S5.GetLength(0); i++)
                Console.Write(String.Format("{0:0.00}", S5[i]) + " |");
            Console.Write("Finals: " + String.Format("{0:0.00}", F5));
            Console.WriteLine();
        }
        public float Final5()
        {
            F5 = Add(S5) / S5.Length;
            return F5;
        }
        private float Add(float[] arr)
        {
            float equ=0;
            for (int i = 0; i < arr.GetLength(0); i++)
                equ = equ + arr[i];
            return equ;
        }
        public void Show_Final()
        {
            Console.Write(Name + ":");
            Console.Write("   " + String.Format("{0:0}", MW) + "  |");
            Console.Write("   " + String.Format("{0:0}", ML) + "   |");
            if(MD>=100 || MD >-100 && -10 >=MD)
                Console.Write("   " + String.Format("{0:0}", MD) + "   |");
            if (100 > MD && MD>=10 || MD > -10 && 0>MD)
                Console.Write("   " + String.Format("{0:0}", MD) + "    |");
            if (10 > MD && MD >= 0)
                Console.Write("    " + String.Format("{0:0}", MD) + "    |");
            if (-100 >= MD)
                Console.Write("   " + String.Format("{0:0}", MD) + "  |");
            if(Points>=100)
                Console.Write(" " + String.Format("{0:0}", Points) + " |");
            else
                Console.Write(" " + String.Format("{0:0}", Points) + "  |");
            Console.Write("  " + String.Format("{0:0}", Mat) + "  |");
            Console.Write(" " + String.Format("{0:0.00}", WP) + " ");
            Console.Write("|"+String.Format("{0:0.000}", FINAL) + "|");
            Console.WriteLine();
        } 
        public void Add_F()
        {
            if (F1 == 0)
                FINAL = (F2 + F3 + F4 + F5) / 4;
            else
                FINAL = (F1 + F2 + F3 + F4 +F5) / 5;
        }
        public void Maps_Diff(int mat)
        {
            if (mat == 1)
                MD1 = MW1 - ML1;
            if (mat == 2)
                MD2 = MW2 - ML2;
            if (mat == 3)
                MD3 = MW3 - ML3;
            if (mat == 4)
                MD4 = MW4 - ML4;
            if (mat == 5)
                MD5 = MW5 - ML5;
            else
                MD = MW - ML;
        }
        public void Win_Per(int mat)
        {
            if (mat == 1)
                WP1 = ((double)Points1/Mat1)*100;
            if (mat == 2)
                WP2 = ((double)Points2 / Mat2) * 100;
            if (mat == 3)
                WP3 = ((double)Points3 / Mat3 )* 100;
            if (mat == 4)
                WP4 = ((double)Points4 / Mat4 )* 100;
            if (mat == 5)
                WP5 = ((double)Points5 / Mat5 )* 100;
        }
        public void Matches()
        {
            Points = Points1 + Points2 + Points3 + Points4 + Points5;
            Mat = Mat1 + Mat2 + Mat3 + Mat4 + Mat5;
            WP = ((double)Points / Mat) * 100;
        }
    }
}
