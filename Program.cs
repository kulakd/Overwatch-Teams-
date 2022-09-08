using System;


namespace OWL_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            Team AR = new Team("Atlanta Reign         ");
            Team BU = new Team("Boston Uprising       ");
            Team CH = new Team("Chengdu Hunters       ");
            Team DF = new Team("Dallas Fuel           ");
            Team FM = new Team("Florida Mayhem        ");
            Team GC = new Team("Guangzhou Charge      ");
            Team HS = new Team("Hangzhou Spark        ");
            Team HO = new Team("Houston Outlaws       ");
            Team LS = new Team("London Spitfire       ");
            Team LAG = new Team("Los Angeles Gladiator ");
            Team LAV = new Team("Los Angeles Valiant   ");
            Team NYE = new Team("New York Excelsior    ");
            Team PE = new Team("Paris Eternal         ");
            Team PF = new Team("Philadelphia Fusion   ");
            Team SFS = new Team("San Francisco Shock   ");
            Team SD = new Team("Seul Dynasty          ");
            Team SHD = new Team("Shanghai Dragons      ");
            Team TD = new Team("Toronto Defiant       ");
            Team VT = new Team("Vancouver Titans      ");
            Team WJ = new Team("Washington Justice    ");
            Team[] Teams = new Team[20] {AR,BU,CH,DF,FM,GC,HS,HO,LS,LAG,LAV,NYE,PE,PF,SFS,SD,SHD,TD,VT,WJ};



            Console.WriteLine();
            Console.WriteLine("SEASON I STANDINGS 2018");
            Console.WriteLine();
            //Season I
            Console.WriteLine("     TEAM             :  SI  |  TI  | S II | T II | SIII | TIII | S IV | T IV |  PO  | PO T | SCORE");
            AR.S1 = new float[] {0,0,0,0,0,0,0,0,0,0};
            BU.S1 = new float[] {  (float)6 / 12, (float)6 / 12, (float)6 / 12, (float)6 / 12, (float)1 / 12, (float)2 / 12, (float)8 / 12, (float)8 / 12, (float)3 / 12,  (float)4 / 12 };
            CH.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0,0,0};
            DF.S1 = new float[] {  (float)10 / 12,(float)10 / 12,(float)11 / 12,(float)11 / 12,(float)11 / 12,(float)11 / 12,(float)4 / 12, (float)3 / 12, (float)10 / 12, (float)10 / 12 };
            FM.S1 = new float[] {  (float)11 / 12,(float)11 / 12,(float)10 / 12,(float)10 / 12,(float)10 / 12,(float)10 / 12,(float)11 / 12,(float)11 / 12,(float)11 / 12, (float)11 / 12 };
            GC.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0,0,0 };
            HS.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0,0,0 };
            HO.S1 = new float[] {  (float)2 / 12, (float)3 / 12, (float)7 / 12, (float)7 / 12, (float)9 / 12, (float)9 / 12, (float)5 / 12, (float)5 / 12, (float)7 / 12,  (float)7 / 12 };
            LS.S1 = new float[] {  (float)3 / 12, (float)1 / 12, (float)2 / 12, (float)3 / 12, (float)6 / 12, (float)6 / 12, (float)9 / 12, (float)9 / 12, (float)5 / 12,  (float)1 / 12 };
            LAG.S1 = new float[] { (float)8 / 12, (float)8 / 12, (float)5 / 12, (float)5 / 12, (float)4 / 12, (float)3 / 12, (float)1 / 12, (float)3 / 12, (float)4 / 12,  (float)4 / 12 };
            LAV.S1 = new float[] { (float)4 / 12, (float)4 / 12, (float)8 / 12, (float)8 / 12, (float)4 / 12, (float)3 / 12, (float)2 / 12, (float)1 / 12, (float)2 / 12,  (float)3 / 12 };
            NYE.S1 = new float[] { (float)1 / 12, (float)2 / 12, (float)1 / 12, (float)1 / 12, (float)2 / 12, (float)1 / 12, (float)3 / 12, (float)2 / 12, (float)1 / 12,  (float)3 / 12 };
            PE.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0,0,0 };
            PF.S1 = new float[] {  (float)7 / 12, (float)7 / 12, (float)3 / 12, (float)2 / 12, (float)8 / 12, (float)8 / 12, (float)6 / 12, (float)6 / 12, (float)6 / 12,  (float)2 / 12 };
            SFS.S1 = new float[] { (float)9 / 12, (float)9 / 12, (float)9 / 12, (float)9 / 12, (float)5 / 12, (float)5 / 12, (float)7 / 12, (float)7 / 12, (float)9 / 12,  (float)9 / 12 };
            SD.S1 = new float[] {  (float)5 / 12, (float)5 / 12, (float)4 / 12, (float)4 / 12, (float)7 / 12, (float)7 / 12, (float)10 / 12,(float)10 / 12,(float)8 / 12,  (float)8 / 12 };
            SHD.S1 = new float[] { (float)12 / 12,(float)12 / 12,(float)12 / 12,(float)12 / 12,(float)12 / 12,(float)12 / 12,(float)12 / 12,(float)12 / 12,(float)12 / 12, (float)12 / 12 };
            TD.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0,0,0 };
            VT.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0 ,0,0};
            WJ.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0 ,0,0};
            for (int i = 0; i < Teams.GetLength(0); i++)
                Teams[i].Final1();
            Array.Sort(Teams, new TC1());
            for (int i = 0; i < Teams.GetLength(0); i++)
                Teams[i].Show1();



            Console.WriteLine();
            Console.WriteLine("SEASON II STANDINGS 2019");
            Console.WriteLine();
            //Season II
            Console.WriteLine("     TEAM             :  SI  |  TI  | S II | T II | SIII | TIII | S IV |  PO  | PO T | SCORE");
            AR.S2 = new float[] { (float)5 /20,  (float)5 /20,  (float)15 /20, (float)15 / 20,(float)11 / 20, (float)11 / 20,(float)1 /20,  (float)6 /20,  (float)5 /20};
            BU.S2 = new float[] { (float)8 / 20, (float)7 / 20, (float)13 / 20,(float)13 / 20,(float)16 / 20, (float)16 / 20,(float)20 / 20,(float)19 / 20,(float)19 / 20 };
            CH.S2 = new float[] { (float)16 / 20,(float)16 / 20,(float)9 / 20, (float)9 / 20, (float)13 / 20, (float)13 / 20,(float)9 / 20, (float)12 / 20,(float)12 / 20 };
            DF.S2 = new float[] { (float)9 / 20, (float)9 / 20, (float)6 / 20, (float)7 / 20, (float)16 / 20, (float)16 / 20,(float)19 / 20,(float)15 / 20,(float)15 / 20 };
            FM.S2 = new float[] { (float)19 / 20,(float)19 / 20,(float)19 / 20,(float)19 / 20,(float)18 / 20, (float)18 / 20,(float)6 / 20, (float)20 / 20,(float)20 / 20 };
            GC.S2 = new float[] { (float)11 / 20,(float)11 / 20,(float)17 / 20,(float)17 / 20,(float)10 / 20, (float)10 / 20,(float)3 / 20, (float)9 / 20, (float)9 / 20 };
            HS.S2 = new float[] { (float)13 / 20,(float)13 / 20,(float)7 / 20, (float)4 / 20, (float)3 / 20,  (float)5 / 20, (float)7 / 20, (float)4 / 20, (float)4 / 20};
            HO.S2 = new float[] { (float)12 / 20,(float)12 / 20,(float)20 / 20,(float)20 / 20,(float)7 / 20,  (float)8 / 20, (float)16 / 20,(float)16 / 20,(float)16 / 20 };
            LS.S2 = new float[] { (float)13 / 20,(float)13 / 20,(float)3 / 20, (float)5 / 20, (float)14 / 20, (float)14 / 20,(float)9 / 20, (float)7 / 20, (float)8 / 20 };
            LAG.S2 = new float[]{ (float)10 / 20,(float)10 / 20,(float)4 / 20, (float)7 / 20, (float)9 / 20,  (float)9 / 20, (float)8 / 20, (float)5 / 20, (float)5 / 20 };
            LAV.S2 = new float[]{ (float)20 / 20,(float)20 / 20,(float)13 / 20,(float)13 / 20,(float)6 / 20,  (float)4 / 20, (float)11 / 20,(float)13 / 20,(float)13 / 20 };
            NYE.S2 = new float[]{ (float)2 / 20, (float)5 / 20, (float)5 / 20, (float)3 / 20, (float)1 / 20,  (float)7 / 20, (float)15 / 20,(float)3 / 20, (float)3 / 20 };
            PE.S2 = new float[] { (float)16 / 20,(float)16 / 20,(float)16 / 20,(float)16 / 20,(float)12 / 20, (float)12 / 20,(float)14 / 20,(float)14 / 20,(float)14 / 20 };
            PF.S2 = new float[] { (float)3 / 20, (float)4 / 20, (float)11 / 20,(float)11 / 20,(float)11 / 20, (float)11 / 20,(float)12 / 20,(float)10 / 20,(float)10 / 20 };
            SFS.S2 = new float[]{ (float)6 / 20, (float)2 / 20, (float)1 / 20, (float)1 / 20, (float)4 / 20,  (float)2 / 20, (float)2 / 20, (float)2 / 20, (float)1 / 20 };
            SD.S2 = new float[] { (float)6 / 20, (float)3 / 20, (float)10 / 20,(float)10 / 20,(float)5 / 20,  (float)6 / 20, (float)13 / 20,(float)8 / 20, (float)7 / 20 };
            SHD.S2 = new float[]{ (float)13 / 20,(float)13 / 20,(float)8 / 20, (float)5 / 20, (float)8 / 20,  (float)1 / 20, (float)18 / 20,(float)11 / 20,(float)11 / 20 };
            TD.S2 = new float[] { (float)4 / 20, (float)7 / 20, (float)15 / 20,(float)15 / 20,(float)19 / 20, (float)19 / 20,(float)17 / 20,(float)17 / 20,(float)17 / 20 };
            VT.S2 = new float[] { (float)1 / 20, (float)1 / 20, (float)2 / 20, (float)2 / 20,  (float)3 / 20,  (float)5 / 20, (float)1 / 20,(float)2 / 20,  (float)2 / 20 };
            WJ.S2 = new float[] { (float)18 / 20,(float)18 / 20,(float)18 / 20,(float)18 / 20,(float)19 / 20, (float)19 / 20,(float)4 / 20, (float)17 / 20,(float)17 / 20 };
            for (int i = 0; i < Teams.GetLength(0); i++)
                Teams[i].Final2();
            Array.Sort(Teams, new TC2());
            for (int i = 0; i < Teams.GetLength(0); i++)
                Teams[i].Show2();



            Console.WriteLine();
            Console.WriteLine("SEASON III STANDINGS 2020");
            Console.WriteLine();
            //Season III
            Console.WriteLine("     TEAM             :  SI  |  TI  | S II | T II | S IV | T IV |  PO  | PO T | SCORE");
            AR.S3 = new float[] { (float)10 / 20, (float)6 / 13, (float)4 / 20, (float)7 / 13, (float)7 / 20,  (float)6 / 13, (float)5 / 13, (float)12 / 20 };
            BU.S3 = new float[] { (float)15 / 20, (float)9 / 13, (float)18 / 20,(float)13 / 13,(float)20 / 20, (float)13 / 13,(float)10 / 13,(float)20 / 20 };
            CH.S3 = new float[] { (float)16 / 20, (float)5 / 7,  (float)20 / 20,(float)6/ 7,   (float)5 / 20,  (float)4 / 7,  (float)5 / 7,  (float)14 / 20 };
            DF.S3 = new float[] { (float)12 / 20, (float)8 / 13, (float)13 / 20,(float)11 / 13,(float)11 / 20, (float)5 / 13, (float)11 / 13,(float)13 / 20 };
            FM.S3 = new float[] { (float)3 / 20,  (float)2 / 13, (float)9 / 20, (float)12 / 13,(float)6 / 20,  (float)3 / 13, (float)4 / 13, (float)7 / 20 };
            GC.S3 = new float[] { (float)1 / 20,  (float)3 / 7,  (float)2 / 20, (float)1 / 7,  (float)9 / 20,  (float)5 / 7,  (float)4 / 7,  (float)6 / 20 };
            HS.S3 = new float[] { (float)9 / 20,  (float)7 / 7,  (float)17 / 20,(float)7 / 7,  (float)8 / 20,  (float)2 / 7,  (float)6 / 7,  (float)10 / 20 };
            HO.S3 = new float[] { (float)13 / 20, (float)10 / 13,(float)14 / 20,(float)6 / 13, (float)18 / 20, (float)10 / 13,(float)12 / 13,(float)16 / 20 };
            LS.S3 = new float[] { (float)17 / 20, (float)5 / 7,  (float)12 / 20,(float)5 / 7,  (float)16 / 20, (float)7 / 7,  (float)7 / 7,  (float)17 / 20 };
            LAG.S3 = new float[] {(float)11 / 20, (float)6 / 13, (float)8 / 20, (float)9 / 13, (float)14 / 20, (float)8 / 13, (float)7 / 13, (float)11 / 20 };
            LAV.S3 = new float[] {(float)5 / 20,  (float)4 / 13, (float)7 / 20, (float)10 / 13,(float)10 / 20, (float)7 / 13, (float)6 / 13, (float)9 / 20 };
            NYE.S3 = new float[] {(float)8 / 20,  (float)4 / 7,  (float)11 / 20,(float)3 / 7,  (float)13 / 20, (float)3 / 7,  (float)3 / 7,  (float)8 / 20 };
            PE.S3 = new float[] { (float)7 / 20,  (float)5 / 13, (float)10 / 20,(float)1 / 13, (float)2 / 20,  (float)4 / 13, (float)8 / 13, (float)5 / 20 };
            PF.S3 = new float[] { (float)4 / 20,  (float)3 / 13, (float)5 / 20, (float)2 / 13, (float)3 / 20,  (float)2 / 13, (float)2 / 13, (float)4 / 20 };
            SFS.S3 = new float[] {(float)2 / 20,  (float)1 / 13, (float)3 / 20, (float)3 / 13, (float)1 / 20,  (float)1 / 13, (float)1 / 13, (float)1 / 20 };
            SD.S3 = new float[] { (float)18 / 20, (float)2 / 7,  (float)16 / 20,(float)4 / 7,  (float)17 / 20, (float)6 / 7,  (float)2 / 7,  (float)2 / 20 };
            SHD.S3 = new float[] {(float)6 / 20,  (float)1 / 7,  (float)1 / 20, (float)2 / 7,  (float)4 / 20,  (float)1 / 7,  (float)1 / 7,  (float)3 / 20 };
            TD.S3 = new float[] { (float)19 / 20, (float)11 / 13,(float)15 / 20,(float)4 / 13, (float)12 / 20, (float)12 / 13,(float)9 / 13, (float)15 / 20 };
            VT.S3 = new float[] { (float)20 / 20, (float)13 /13, (float)6 / 20, (float)8 / 13, (float)19 / 20, (float)9 / 13, (float)13 / 13,(float)18 / 20 };
            WJ.S3 = new float[] { (float)14 / 20, (float)11 / 13,(float)19 / 20,(float)5 / 13, (float)15 / 20, (float)11 / 13,(float)3 / 13, (float)19 / 20 };
            for (int i = 0; i < Teams.GetLength(0); i++)
                Teams[i].Final3();
            Array.Sort(Teams, new TC3());
            for (int i = 0; i < Teams.GetLength(0); i++)
                Teams[i].Show3();



            Console.WriteLine();
            Console.WriteLine("SEASON IV STANDINGS 2021");
            Console.WriteLine();
            //Season IV
            Console.WriteLine("     TEAM             :  SI  |  TI  | S II | T II | SIII | TIII | S IV | T IV |  PO  | PO T | SCORE");
            AR.S4 = new float[] { (float)12 / 20, (float)12 / 20, (float)4 / 20,  (float)3 / 20,  (float)3 / 20,  (float)4 / 20, (float)2 / 20,  (float)3 / 20,  (float)5 / 20,  (float)2 / 20 };
            BU.S4 = new float[] { (float)16 / 20, (float)16 / 20, (float)9 / 20,  (float)10 / 20, (float)4 / 20,  (float)10 / 20,(float)16 / 20, (float)16 / 20, (float)15 / 20, (float)15 / 20 };
            CH.S4 = new float[] { (float)5 / 20,  (float)4 / 20,  (float)15 / 20, (float)15 / 20, (float)5 / 20,  (float)2 / 20, (float)1 / 20,  (float)2 / 20,  (float)3 / 20,  (float)5 / 20 };
            DF.S4 = new float[] { (float)10 / 20, (float)1 / 20,  (float)6 / 20,  (float)2 / 20,  (float)2 / 20,  (float)3 / 20, (float)9 / 20,  (float)10 / 20, (float)2 / 20,  (float)3 / 20};
            FM.S4 = new float[] { (float)8 / 20,  (float)3 / 20,  (float)14 / 20, (float)14 / 20, (float)17 / 20, (float)17 / 20,(float)14 / 20, (float)14 / 20, (float)16 / 20, (float)16 / 20 };
            GC.S4 = new float[] { (float)15 / 20, (float)15 / 20, (float)17 / 20, (float)17 / 20, (float)16 / 20, (float)16 / 20,(float)11 / 20, (float)11 / 20, (float)17 / 20, (float)17 / 20 };
            HS.S4 = new float[] { (float)13 / 20, (float)13 / 20, (float)1 / 20,  (float)5 / 20,  (float)14 / 20, (float)14 / 20,(float)19 / 20, (float)19 / 20, (float)13 / 20 ,(float)13 / 20 };
            HO.S4 = new float[] { (float)3 / 20,  (float)8 / 20,  (float)5 / 20,  (float)9 / 20,  (float)12 / 20, (float)12 / 20,(float)12 / 20, (float)12 / 20, (float)8 / 20,  (float)8 / 20 };
            LS.S4 = new float[] { (float)19 / 20, (float)19 / 20, (float)18 / 20, (float)18 / 20, (float)18 / 20, (float)18 / 20,(float)17 / 20, (float)17 / 20, (float)18 / 20, (float)18 / 20 };
            LAG.S4 = new float[]{ (float)11 / 20, (float)11 / 20, (float)2 / 20,  (float)7 / 20,  (float)10 / 20, (float)8 / 20, (float)3 / 20,  (float)1 / 20,  (float)4 / 20,  (float)6 / 20 };
            LAV.S4 = new float[]{ (float)20 / 20, (float)20 / 20, (float)19 / 20, (float)19 / 20, (float)20 / 20, (float)20 / 20,(float)20 / 20, (float)20 / 20, (float)20 / 20, (float)20 / 20 };
            NYE.S4 = new float[]{ (float)17 / 20, (float)17 / 20, (float)10 / 20, (float)4 / 20,  (float)9 / 20,  (float)5 / 20, (float)10 / 20, (float)5 / 20,  (float)14 / 20, (float)14 / 20 };
            PE.S4 = new float[] { (float)14 / 20, (float)14 / 20, (float)12 / 20, (float)12 / 20, (float)7 / 20,  (float)9 / 20, (float)8 / 20,  (float)9 / 20,  (float)12 / 20, (float)12 / 20 };
            PF.S4 = new float[] { (float)1 / 20,  (float)5 / 20,  (float)11 / 20, (float)11 / 20, (float)15 / 20, (float)15 / 20,(float)5 / 20,  (float)6 / 20,  (float)9 / 20,  (float)7 / 20 };
            SFS.S4 = new float[]{ (float)6 / 20,  (float)10 /20,  (float)3 / 20,  (float)8 / 20,  (float)11 / 20, (float)11 / 20,(float)4 / 20,  (float)8 / 20,  (float)6 / 20,  (float)4 / 20 };
            SD.S4 = new float[] { (float)4 / 20,  (float)6 / 20,  (float)8 / 20,  (float)6 / 20,  (float)8 / 20,  (float)6 / 20, (float)7 / 20,  (float)4 / 20,  (float)7 / 20,  (float)7 / 20 };
            SHD.S4 = new float[]{ (float)7 / 20,  (float)2 / 20,  (float)7 / 20,  (float)1 / 20,  (float)1 / 20,  (float)1 / 20, (float)13 / 20, (float)13 / 20, (float)1 / 20,  (float)1 / 20 };
            TD.S4 = new float[] { (float)9 / 20,  (float)9 / 20,  (float)16 / 20, (float)16 / 20, (float)13 / 20, (float)13 / 20,(float)6 / 20,  (float)7 / 20,  (float)11 / 20, (float)11 / 20 };
            VT.S4 = new float[] { (float)18 / 20, (float)18 / 20, (float)20 / 20, (float)20 / 20, (float)19 / 20, (float)19 / 20,(float)15 / 20, (float)15 / 20, (float)19 / 20, (float)19 / 20 };
            WJ.S4 = new float[] { (float)2 / 20,  (float)7 / 20,  (float)13 / 20, (float)13 / 20, (float)6 / 20,  (float)7 / 20, (float)18 / 20, (float)18 / 20, (float)10 / 20, (float)8 / 20 };
            for (int i = 0; i < Teams.GetLength(0); i++)
                Teams[i].Final4();
            Array.Sort(Teams, new TC4());
            for (int i = 0; i < Teams.GetLength(0); i++)
                Teams[i].Show4();



            Console.WriteLine();
            Console.WriteLine("SEASON V STANDINGS 2022");
            Console.WriteLine();
            //Season V
            Console.WriteLine("     TEAM             :  SI  |  TI  | S II | T II | SIII | TIII | S IV |  PO  | PO T | SCORE");
            AR.S5 = new float[] { (float)11 / 20, (float)3 / 13,  (float) 9/ 20,  (float)3 / 20, (float) 13/ 20};
            BU.S5 = new float[] { (float)15 / 20, (float)10 / 13, (float) 15/ 20, (float)15 / 20,(float)16 / 20};
            CH.S5 = new float[] { (float)14 / 20, (float)5 / 7,   (float) 14/ 20, (float)14 / 20,(float)15 / 20};
            DF.S5 = new float[] { (float) 2/ 20,  (float)2 / 13,  (float) 5/ 20,  (float)11 / 20,(float) 2/ 20};
            FM.S5 = new float[] { (float) 6/ 20,  (float)5 / 13,  (float) 10/ 20, (float)8 / 20, (float) 11/ 20};
            GC.S5 = new float[] { (float)18 / 20, (float)7 / 7,   (float) 19/ 20, (float)19 / 20,(float)7 / 20 };
            HS.S5 = new float[] { (float) 3/ 20,  (float)4 / 7,   (float) 4/ 20,  (float)6 / 20, (float)19 / 20};
            HO.S5 = new float[] { (float) 8/ 20,  (float)6 / 13,  (float) 6/ 20,  (float)7 / 20, (float) 5/ 20};
            LS.S5 = new float[] { (float)13 / 20, (float)9 / 13,  (float) 8/ 20,  (float)12 / 20,(float) 8/ 20 };
            LAG.S5 = new float[]{ (float) 5/ 20,  (float)1 / 13,  (float) 2/ 20,  (float)1/20,   (float) 12/ 20};
            LAV.S5 = new float[]{ (float)16 / 20, (float)6 / 7,   (float) 16/ 20, (float)16 / 20,(float)18 / 20 };
            NYE.S5 = new float[]{ (float)17 / 20, (float)11 / 13, (float) 17/ 20, (float)17 / 20,(float)17 / 20};
            PE.S5 = new float[] { (float)19 / 20, (float)12 / 13, (float) 18/ 20, (float)18 / 20,(float)20 / 20};
            PF.S5 = new float[] { (float)10 / 20, (float)2 / 7,   (float) 11/ 20, (float)4 / 20, (float)14 / 20};
            SFS.S5 = new float[]{ (float) 1/ 20,  (float)4 / 13,  (float) 1/ 20,  (float)2 / 20, (float) 4/ 20};
            SD.S5 = new float[] { (float) 7/ 20,  (float)1 / 7,   (float) 3/ 20,  (float)9 / 20, (float) 3/ 20};
            SHD.S5 = new float[]{ (float) 4/ 20,  (float)3 / 7,   (float) 7/ 20,  (float)5 / 20, (float) 1/ 20};
            TD.S5 = new float[] { (float) 9/ 20,  (float)8  /  13,(float) 12/ 20, (float)10 /20, (float) 6/ 20};
            VT.S5 = new float[] { (float)20 / 20, (float)13 / 13, (float) 20/ 20, (float)20 / 20,(float) 9/ 20 };
            WJ.S5 = new float[] { (float)12 / 20, (float)7 / 13,  (float) 13/ 20, (float)13 / 20,(float) 10/ 20};
            for (int i = 0; i < Teams.GetLength(0); i++)
                Teams[i].Final5();
            Array.Sort(Teams, new TC5());
            for (int i = 0; i < Teams.GetLength(0); i++)
                Teams[i].Show5();
            for (int i = 0; i < Teams.GetLength(0); i++)
                Teams[i].Add_F();

            Console.WriteLine();
            Console.WriteLine();
            Array.Sort(Teams, new TeamCompare());
            for (int i = 0; i < Teams.GetLength(0); i++)
                Teams[i].Show_Final();
        }
    }
}
