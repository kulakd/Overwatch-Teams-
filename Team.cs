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

        public Team(string N)
        {
            this.Name = N;

        }
        public void Show1()
        {
            Console.Write(Name + ": ");
            for (int i = 0; i < S1.GetLength(0); i++)
                Console.Write(String.Format("{0:0.000}", S1[i]) + "| ");
            Console.Write("Finals: " + String.Format("{0:0.000}", F1));
            Console.WriteLine();
        }
        public float Final1()
        {
            F1 = Add(S1) / S1.Length;
            return F1;
        }
        public void Show2()
        {
            Console.Write(Name + ": ");
            for (int i = 0; i <S2.GetLength(0); i++)
                Console.Write(String.Format("{0:0.000}", S2[i]) + "| ");
            Console.Write("Finals: " + String.Format("{0:0.000}", F2));
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
            for (int i = 0; i < S3.GetLength(0); i++)
                Console.Write(String.Format("{0:0.000}", S3[i]) + "| ");
            Console.Write("Finals: " + String.Format("{0:0.000}", F3));
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
            for (int i = 0; i < S4.GetLength(0); i++)
                Console.Write(String.Format("{0:0.000}", S4[i]) + "| ");
            Console.Write("Finals: " + String.Format("{0:0.000}", F4));
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
            for (int i = 0; i < S5.GetLength(0); i++)
                Console.Write(String.Format("{0:0.000}", S5[i]) + "| ");
            Console.Write("Finals: " + String.Format("{0:0.000}", F5));
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
            Console.Write(Name + ": ");
            Console.Write(" " + String.Format("{0:0.000}", FINAL) + " ");
            Console.WriteLine();

        }

        
        public void Add_F()
        {
            if (F1 == 0)
                FINAL = (F2 + F3 + F4 + F5) / 4;
            else
                FINAL = (F1 + F2 + F3 + F4 +F5) / 5;
        }
    }
}
