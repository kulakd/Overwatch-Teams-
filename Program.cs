using System;


namespace OWL_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Deklaracje
            string choice;
            Matches OWL = new Matches();
            Team AR = new Team("Atlanta Reign         ");
            Team BU = new Team("Boston Uprising       ");
            Team CH = new Team("Chengdu Hunters       ");
            Team DF = new Team("Dallas Fuel           ");
            Team FM = new Team("Florida Mayhem        ");
            Team GC = new Team("Guangzhou Charge      ");
            Team HS = new Team("Hangzhou Spark        ");
            Team HO = new Team("Houston Outlaws       ");
            Team LS = new Team("London Spitfire       ");
            Team LAG =new Team("Los Angeles Gladiator ");
            Team LAV =new Team("Los Angeles Valiant   ");
            Team NYE =new Team("New York Excelsior    ");
            Team PE = new Team("Paris Eternal         ");
            Team PF = new Team("Philadelphia Fusion   ");
            Team SFS =new Team("San Francisco Shock   ");
            Team SD = new Team("Seul Dynasty          ");
            Team SHD =new Team("Shanghai Dragons      ");
            Team TD = new Team("Toronto Defiant       ");
            Team VT = new Team("Vancouver Titans      ");
            Team WJ = new Team("Washington Justice    ");
            Team[] Teams = new Team[20] { AR, BU, CH, DF, FM, GC, HS, HO, LS, LAG, LAV, NYE, PE, PF, SFS, SD, SHD, TD, VT, WJ };
            Console.WriteLine();
            #endregion

            do
            {
                choice=OWL.Match_Menu();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        #region SEASON 1
                        Console.WriteLine("SEASON I STANDINGS 2018");
                        Console.WriteLine();
                        //Season I
                        Console.WriteLine("     TEAM             :  WIN  |  LOSS  | DIFF  |SCORE|WINRATE| GAMES |  SI  |  TI  | S II | T II | SIII | TIII | S IV | T IV |  PO  | PO T |");
                        AR.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        BU.S1 = new float[] { (float)6 / 12, (float)6 / 12, (float)6 / 12, (float)6 / 12, (float)1 / 12, (float)2 / 12, (float)8 / 12, (float)8 / 12, (float)3 / 12, (float)4 / 12 };
                        CH.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        DF.S1 = new float[] { (float)10 / 12, (float)10 / 12, (float)11 / 12, (float)11 / 12, (float)11 / 12, (float)11 / 12, (float)4 / 12, (float)3 / 12, (float)10 / 12, (float)10 / 12 };
                        FM.S1 = new float[] { (float)11 / 12, (float)11 / 12, (float)10 / 12, (float)10 / 12, (float)10 / 12, (float)10 / 12, (float)11 / 12, (float)11 / 12, (float)11 / 12, (float)11 / 12 };
                        GC.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        HS.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        HO.S1 = new float[] { (float)2 / 12, (float)3 / 12, (float)7 / 12, (float)7 / 12, (float)9 / 12, (float)9 / 12, (float)5 / 12, (float)5 / 12, (float)7 / 12, (float)7 / 12 };
                        LS.S1 = new float[] { (float)3 / 12, (float)1 / 12, (float)2 / 12, (float)3 / 12, (float)6 / 12, (float)6 / 12, (float)9 / 12, (float)9 / 12, (float)5 / 12, (float)1 / 12 };
                        LAG.S1 = new float[] { (float)8 / 12, (float)8 / 12, (float)5 / 12, (float)5 / 12, (float)4 / 12, (float)3 / 12, (float)1 / 12, (float)3 / 12, (float)4 / 12, (float)4 / 12 };
                        LAV.S1 = new float[] { (float)4 / 12, (float)4 / 12, (float)8 / 12, (float)8 / 12, (float)4 / 12, (float)3 / 12, (float)2 / 12, (float)1 / 12, (float)2 / 12, (float)3 / 12 };
                        NYE.S1 = new float[] { (float)1 / 12, (float)2 / 12, (float)1 / 12, (float)1 / 12, (float)2 / 12, (float)1 / 12, (float)3 / 12, (float)2 / 12, (float)1 / 12, (float)3 / 12 };
                        PE.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        PF.S1 = new float[] { (float)7 / 12, (float)7 / 12, (float)3 / 12, (float)2 / 12, (float)8 / 12, (float)8 / 12, (float)6 / 12, (float)6 / 12, (float)6 / 12, (float)2 / 12 };
                        SFS.S1 = new float[] { (float)9 / 12, (float)9 / 12, (float)9 / 12, (float)9 / 12, (float)5 / 12, (float)5 / 12, (float)7 / 12, (float)7 / 12, (float)9 / 12, (float)9 / 12 };
                        SD.S1 = new float[] { (float)5 / 12, (float)5 / 12, (float)4 / 12, (float)4 / 12, (float)7 / 12, (float)7 / 12, (float)10 / 12, (float)10 / 12, (float)8 / 12, (float)8 / 12 };
                        SHD.S1 = new float[] { (float)12 / 12, (float)12 / 12, (float)12 / 12, (float)12 / 12, (float)12 / 12, (float)12 / 12, (float)12 / 12, (float)12 / 12, (float)12 / 12, (float)12 / 12 };
                        TD.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        VT.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        WJ.S1 = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                        #region Season I matches
                        #region Stage 1
                        OWL.Match_Result(SFS, LAV, 0, 4, 1);
                        OWL.Match_Result(SHD, LAG, 0, 4, 1);
                        OWL.Match_Result(DF, SD, 1, 2, 1);
                        OWL.Match_Result(LS, FM, 3, 1, 1);
                        OWL.Match_Result(PF, HO, 3, 2, 1);
                        OWL.Match_Result(BU, NYE, 1, 3, 1);
                        OWL.Match_Result(LAV, DF, 3, 0, 1);
                        OWL.Match_Result(FM, BU, 0, 4, 1);
                        OWL.Match_Result(SFS, SHD, 3, 1, 1);
                        OWL.Match_Result(LS, PF, 4, 0, 1);
                        OWL.Match_Result(NYE, HO, 3, 1, 1);
                        OWL.Match_Result(SD, LAG, 4, 0, 1);

                        OWL.Match_Result(SFS, PF, 1, 2, 1);
                        OWL.Match_Result(FM, SD, 0, 4, 1);
                        OWL.Match_Result(HO, SHD, 4, 0, 1);
                        OWL.Match_Result(DF, HO, 0, 4, 1);
                        OWL.Match_Result(NYE, LAV, 3, 0, 1);
                        OWL.Match_Result(PF, LAG, 2, 3, 1);
                        OWL.Match_Result(SD, BU, 4, 0, 1);
                        OWL.Match_Result(SHD, FM, 0, 4, 1);
                        OWL.Match_Result(LS, DF, 3, 1, 1);
                        OWL.Match_Result(LAV, LS, 2, 3, 1);
                        OWL.Match_Result(LAG, NYE, 0, 4, 1);
                        OWL.Match_Result(BU, SFS, 2, 3, 1);

                        OWL.Match_Result(SFS, LS, 1, 3, 1);
                        OWL.Match_Result(SHD, SD, 1, 3, 1);
                        OWL.Match_Result(LAG, LAV, 2, 3, 1);
                        OWL.Match_Result(BU, LS, 3, 2, 1);
                        OWL.Match_Result(PF, NYE, 3, 2, 1);
                        OWL.Match_Result(HO, FM, 4, 0, 1);
                        OWL.Match_Result(SD, NYE, 2, 3, 1);
                        OWL.Match_Result(SHD, PF, 2, 3, 1);
                        OWL.Match_Result(DF, SFS, 3, 0, 1);
                        OWL.Match_Result(DF, BU, 2, 3, 1);
                        OWL.Match_Result(LAV, FM, 3, 1, 1);
                        OWL.Match_Result(LAG, HO, 0, 4, 1);

                        OWL.Match_Result(PF, LAV, 0, 4, 1);
                        OWL.Match_Result(FM, LAG, 1, 3, 1);
                        OWL.Match_Result(HO, SFS, 3, 1, 1);
                        OWL.Match_Result(PF, DF, 4, 0, 1);
                        OWL.Match_Result(NYE, SHD, 4, 0, 1);
                        OWL.Match_Result(LS, SD, 4, 0, 1);
                        OWL.Match_Result(SFS, FM, 4, 0, 1);
                        OWL.Match_Result(SD, HO, 3, 2, 1);
                        OWL.Match_Result(LAG, BU, 0, 4, 1);
                        OWL.Match_Result(SHD, LS, 0, 4, 1);
                        OWL.Match_Result(DF, NYE, 1, 3, 1);
                        OWL.Match_Result(LAV, BU, 0, 4, 1);

                        OWL.Match_Result(SHD, DF, 2, 3, 1);
                        OWL.Match_Result(SFS, LAG, 1, 3, 1);
                        OWL.Match_Result(SD, LAV, 0, 3, 1);
                        OWL.Match_Result(PF, BU, 0, 4, 1);
                        OWL.Match_Result(FM, NYE, 0, 3, 1);
                        OWL.Match_Result(LS, HO, 1, 3, 1);
                        OWL.Match_Result(LAG, DF, 1, 3, 1);
                        OWL.Match_Result(SD, SFS, 3, 2, 1);
                        OWL.Match_Result(LAV, SHD, 4, 0, 1);
                        OWL.Match_Result(NYE, LS, 3, 2, 1);
                        OWL.Match_Result(HO, BU, 3, 2, 1);
                        OWL.Match_Result(FM, PF, 2, 3, 1);

                        OWL.Match_Result(HO, LS, 1, 3, 1);
                        OWL.Match_Result(NYE, LS, 2, 3, 1);
                        #endregion
                        #region Stage 2
                        OWL.Match_Result(SFS, LAV, 3, 1, 1);
                        OWL.Match_Result(SD, LAV, 4, 0, 1);
                        OWL.Match_Result(DF, SHD, 3, 1, 1);
                        OWL.Match_Result(LAG, SFS, 4, 0, 1);
                        OWL.Match_Result(HO, LS, 3, 2, 1);
                        OWL.Match_Result(FM, NYE, 1, 3, 1);
                        OWL.Match_Result(BU, PF, 0, 4, 1);
                        OWL.Match_Result(LS, NYE, 3, 2, 1);
                        OWL.Match_Result(DF, LAG, 3, 1, 1);
                        OWL.Match_Result(SFS, SD, 1, 3, 1);
                        OWL.Match_Result(PF, FM, 4, 0, 1);
                        OWL.Match_Result(BU, HO, 0, 4, 1);
                        OWL.Match_Result(SHD, LAV, 0, 3, 1);

                        OWL.Match_Result(SD, DF, 3, 1, 1);
                        OWL.Match_Result(LAV, SFS, 3, 1, 1);
                        OWL.Match_Result(LAG, SHD, 4, 0, 1);
                        OWL.Match_Result(FM, LS, 1, 3, 1);
                        OWL.Match_Result(HO, PF, 2, 3, 1);
                        OWL.Match_Result(NYE, BU, 4, 0, 1);
                        OWL.Match_Result(FM, BU, 0, 4, 1);
                        OWL.Match_Result(LAG, SD, 1, 3, 1);
                        OWL.Match_Result(DF, LAV, 1, 3, 1);
                        OWL.Match_Result(PF, LS, 0, 4, 1);
                        OWL.Match_Result(HO, NYE, 0, 4, 1);
                        OWL.Match_Result(SHD, SFS, 0, 4, 1);

                        OWL.Match_Result(SD, SHD, 3, 1, 1);
                        OWL.Match_Result(SFS, DF, 3, 0, 1);
                        OWL.Match_Result(LAG, LAV, 4, 0, 1);
                        OWL.Match_Result(PF, SD, 1, 3, 1);
                        OWL.Match_Result(HO, LAV, 0, 4, 1);
                        OWL.Match_Result(BU, SHD, 4, 0, 1);
                        OWL.Match_Result(LS, BU, 4, 0, 1);
                        OWL.Match_Result(NYE, PF, 3, 1, 1);
                        OWL.Match_Result(FM, HO, 2, 3, 1);
                        OWL.Match_Result(LS, LAG, 1, 3, 1);
                        OWL.Match_Result(NYE, SFS, 4, 0, 1);
                        OWL.Match_Result(FM, DF, 3, 2, 1);

                        OWL.Match_Result(BU, DF, 4, 0, 1);
                        OWL.Match_Result(NYE, SD, 3, 2, 1);
                        OWL.Match_Result(PF, SHD, 4, 0, 1);
                        OWL.Match_Result(FM, LAV, 3, 1, 1);
                        OWL.Match_Result(NYE, SHD, 4, 0, 1);
                        OWL.Match_Result(HO, LAG, 2, 3, 1);
                        OWL.Match_Result(LAG, FM, 2, 1, 1);
                        OWL.Match_Result(LS, SFS, 3, 1, 1);
                        OWL.Match_Result(LAV, BU, 2, 3, 1);
                        OWL.Match_Result(SD, LS, 0, 4, 1);
                        OWL.Match_Result(SFS, HO, 3, 1, 1);
                        OWL.Match_Result(DF, PF, 0, 4, 1);

                        OWL.Match_Result(LAG, PF, 1, 3, 1);
                        OWL.Match_Result(SFS, FM, 2, 3, 1);
                        OWL.Match_Result(HO, SHD, 4, 0, 1);
                        OWL.Match_Result(HO, SD, 3, 1, 1);
                        OWL.Match_Result(DF, NYE, 2, 3, 1);
                        OWL.Match_Result(SFS, BU, 2, 3, 1);
                        OWL.Match_Result(SD, FM, 3, 1, 1);
                        OWL.Match_Result(PF, LAV, 3, 2, 1);
                        OWL.Match_Result(LS, SHD, 4, 0, 1);
                        OWL.Match_Result(NYE, LAV, 4, 0, 1);
                        OWL.Match_Result(DF, LS, 1, 3, 1);
                        OWL.Match_Result(BU, LAG, 2, 3, 1);

                        OWL.Match_Result(PF, LS, 3, 2, 1);
                        OWL.Match_Result(NYE, PF, 3, 2, 1);
                        #endregion
                        #region Stage 3
                        OWL.Match_Result(SHD, DF, 1, 3, 1);
                        OWL.Match_Result(SD, LAV, 0, 4, 1);
                        OWL.Match_Result(LAG, SFS, 3, 1, 1);
                        OWL.Match_Result(HO, LS, 3, 2, 1);
                        OWL.Match_Result(FM, NYE, 0, 4, 1);
                        OWL.Match_Result(BU, PF, 3, 2, 1);
                        OWL.Match_Result(LS, NYE, 0, 4, 1);
                        OWL.Match_Result(DF, LAG, 1, 3, 1);
                        OWL.Match_Result(SFS, SD, 0, 4, 1);
                        OWL.Match_Result(PF, FM, 3, 1, 1);
                        OWL.Match_Result(BU, HO, 4, 0, 1);
                        OWL.Match_Result(SHD, LAV, 0, 4, 1);

                        OWL.Match_Result(SD, DF, 3, 2, 1);
                        OWL.Match_Result(LAV, SFS, 4, 0, 1);
                        OWL.Match_Result(LAG, SHD, 4, 0, 1);
                        OWL.Match_Result(FM, LS, 0, 3, 1);
                        OWL.Match_Result(HO, PF, 2, 3, 1);
                        OWL.Match_Result(NYE, BU, 2, 3, 1);
                        OWL.Match_Result(FM, BU, 2, 3, 1);
                        OWL.Match_Result(LAG, SD, 3, 2, 1);
                        OWL.Match_Result(DF, LAV, 1, 2, 1);
                        OWL.Match_Result(PF, LS, 3, 2, 1);
                        OWL.Match_Result(HO, NYE, 2, 3, 1);
                        OWL.Match_Result(SHD, SFS, 3, 1, 1);

                        OWL.Match_Result(SD, SHD, 3, 1, 1);
                        OWL.Match_Result(SFS, DF, 4, 0, 1);
                        OWL.Match_Result(LAG, LAV, 2, 3, 1);
                        OWL.Match_Result(PF, SFS, 1, 3, 1);
                        OWL.Match_Result(FM, SHD, 3, 1, 1);
                        OWL.Match_Result(BU, SD, 2, 1, 1);
                        OWL.Match_Result(LS, BU, 2, 3, 1);
                        OWL.Match_Result(NYE, PF, 3, 2, 1);
                        OWL.Match_Result(FM, HO, 1, 3, 1);
                        OWL.Match_Result(LS, LAV, 3, 2, 1);
                        OWL.Match_Result(NYE, LAG, 3, 2, 1);
                        OWL.Match_Result(HO, DF, 3, 0, 1);

                        OWL.Match_Result(BU, SHD, 3, 1, 1);
                        OWL.Match_Result(HO, LAV, 3, 1, 1);
                        OWL.Match_Result(DF, FM, 1, 3, 1);
                        OWL.Match_Result(LS, LAG, 2, 3, 1);
                        OWL.Match_Result(NYE, SFS, 3, 1, 1);
                        OWL.Match_Result(SD, PF, 3, 2, 1);
                        OWL.Match_Result(BU, DF, 4, 0, 1);
                        OWL.Match_Result(HO, LAG, 2, 3, 1);
                        OWL.Match_Result(LAV, FM, 3, 1, 1);
                        OWL.Match_Result(LS, SFS, 4, 0, 1);
                        OWL.Match_Result(NYE, SD, 4, 0, 1);
                        OWL.Match_Result(SHD, PF, 2, 3, 1);

                        OWL.Match_Result(DF, PF, 1, 3, 1);
                        OWL.Match_Result(FM, LAG, 0, 3, 1);
                        OWL.Match_Result(HO, SFS, 2, 3, 1);
                        OWL.Match_Result(SFS, FM, 4, 0, 1);
                        OWL.Match_Result(BU, LAV, 3, 2, 1);
                        OWL.Match_Result(NYE, DF, 4, 0, 1);
                        OWL.Match_Result(BU, LAG, 3, 1, 1);
                        OWL.Match_Result(SHD, NYE, 1, 3, 1);
                        OWL.Match_Result(LS, SD, 3, 2, 1);
                        OWL.Match_Result(LS, SHD, 3, 1, 1);
                        OWL.Match_Result(SD, HO, 4, 0, 1);
                        OWL.Match_Result(PF, LAV, 2, 3, 1);

                        OWL.Match_Result(BU, LAG, 3, 0, 1);
                        OWL.Match_Result(NYE, LAV, 3, 0, 1);
                        OWL.Match_Result(NYE, BU, 3, 0, 1);
                        #endregion
                        #region Stage 4
                        OWL.Match_Result(SD, LAV, 2, 3, 1);
                        OWL.Match_Result(DF, SHD, 3, 1, 1);
                        OWL.Match_Result(LAG, SFS, 3, 1, 1);
                        OWL.Match_Result(HO, LS, 4, 0, 1);
                        OWL.Match_Result(FM, NYE, 0, 3, 1);
                        OWL.Match_Result(BU, PF, 1, 3, 1);
                        OWL.Match_Result(LS, NYE, 1, 3, 1);
                        OWL.Match_Result(DF, LAG, 0, 4, 1);
                        OWL.Match_Result(SFS, SD, 3, 1, 1);
                        OWL.Match_Result(PF, FM, 4, 0, 1);
                        OWL.Match_Result(BU, HO, 1, 3, 1);
                        OWL.Match_Result(SHD, LAV, 1, 3, 1);

                        OWL.Match_Result(BU, DF, 0, 3, 1);
                        OWL.Match_Result(LAV, FM, 3, 1, 1);
                        OWL.Match_Result(LAG, HO, 3, 1, 1);
                        OWL.Match_Result(SFS, LS, 2, 3, 1);
                        OWL.Match_Result(LAG, FM, 4, 0, 1);
                        OWL.Match_Result(SHD, PF, 0, 4, 1);
                        OWL.Match_Result(LAV, BU, 3, 2, 1);
                        OWL.Match_Result(NYE, SD, 4, 0, 1);
                        OWL.Match_Result(SFS, HO, 4, 0, 1);
                        OWL.Match_Result(SD, LS, 2, 3, 1);
                        OWL.Match_Result(SHD, NYE, 0, 4, 1);
                        OWL.Match_Result(PF, DF, 1, 3, 1);

                        OWL.Match_Result(SD, SHD, 4, 0, 1);
                        OWL.Match_Result(SFS, DF, 3, 1, 1);
                        OWL.Match_Result(LAG, LAV, 0, 3, 1);
                        OWL.Match_Result(PF, LAG, 1, 3, 1);
                        OWL.Match_Result(HO, SHD, 3, 0, 1);
                        OWL.Match_Result(FM, SD, 2, 3, 1);
                        OWL.Match_Result(LS, BU, 2, 1, 1);
                        OWL.Match_Result(NYE, PF, 4, 0, 1);
                        OWL.Match_Result(FM, HO, 1, 3, 1);
                        OWL.Match_Result(BU, SFS, 1, 3, 1);
                        OWL.Match_Result(LS, DF, 1, 3, 1);
                        OWL.Match_Result(NYE, LAV, 2, 3, 1);

                        OWL.Match_Result(SD, BU, 1, 3, 1);
                        OWL.Match_Result(SHD, FM, 2, 3, 1);
                        OWL.Match_Result(DF, HO, 1, 3, 1);
                        OWL.Match_Result(LS, LAV, 1, 2, 1);
                        OWL.Match_Result(NYE, LAG, 2, 3, 1);
                        OWL.Match_Result(SFS, PF, 1, 2, 1);
                        OWL.Match_Result(SHD, BU, 0, 4, 1);
                        OWL.Match_Result(FM, DF, 0, 4, 1);
                        OWL.Match_Result(PF, SD, 3, 2, 1);
                        OWL.Match_Result(LAG, LS, 3, 2, 1);
                        OWL.Match_Result(NYE, SFS, 2, 1, 1);
                        OWL.Match_Result(LAV, HO, 4, 0, 1);

                        OWL.Match_Result(LAG, SHD, 4, 0, 1);
                        OWL.Match_Result(SFS, LAV, 1, 3, 1);
                        OWL.Match_Result(SD, DF, 3, 1, 1);
                        OWL.Match_Result(HO, PF, 3, 1, 1);
                        OWL.Match_Result(FM, LS, 0, 4, 1);
                        OWL.Match_Result(NYE, BU, 1, 3, 1);
                        OWL.Match_Result(HO, NYE, 2, 3, 1);
                        OWL.Match_Result(SD, LAG, 1, 3, 1);
                        OWL.Match_Result(DF, LAV, 3, 1, 1);
                        OWL.Match_Result(PF, LS, 3, 1, 1);
                        OWL.Match_Result(SHD, SFS, 0, 4, 1);
                        OWL.Match_Result(BU, FM, 4, 0, 1);

                        OWL.Match_Result(LAV, LAG, 3, 2, 1);
                        OWL.Match_Result(NYE, DF, 3, 2, 1);
                        OWL.Match_Result(NYE, LAV, 1, 3, 1);
                        #endregion
                        #region Playoffs
                        OWL.Match_Result(BU, PF, 1, 2, 1);
                        OWL.Match_Result(LAG, LS, 1, 2, 1);
                        OWL.Match_Result(LAV, LS, 0, 2, 1);
                        OWL.Match_Result(NYE, PF, 0, 2, 1);
                        OWL.Match_Result(LS, PF, 2, 0, 1);

                        #endregion
                        #endregion
                        #region Show Results
                        for (int i = 0; i < Teams.GetLength(0); i++)
                        {
                            Teams[i].Final1();
                            Teams[i].Maps_Diff(1);
                            Teams[i].Win_Per(1);
                        }
                        Array.Sort(Teams, new TC1());
                        for (int i = 0; i < Teams.GetLength(0); i++)
                            Teams[i].Show1();
                        #endregion


                        Console.WriteLine();
                        #endregion
                        break;
                    case "2":
                        #region SEASON 2
                        Console.WriteLine("SEASON II STANDINGS 2019");
                        Console.WriteLine();
                        //Season II
                        Console.WriteLine("     TEAM             :  WIN |  LOSS  | DIFF  |SCORE|WINRATE| GAMES |  SI  |  TI  | S II | T II | SIII | TIII | S IV |  PO  | PO T |");
                        AR.S2 = new float[] { (float)5 / 20, (float)5 / 20, (float)15 / 20, (float)15 / 20, (float)11 / 20, (float)11 / 20, (float)1 / 20, (float)6 / 20, (float)5 / 20 };
                        BU.S2 = new float[] { (float)8 / 20, (float)7 / 20, (float)13 / 20, (float)13 / 20, (float)16 / 20, (float)16 / 20, (float)20 / 20, (float)19 / 20, (float)19 / 20 };
                        CH.S2 = new float[] { (float)16 / 20, (float)16 / 20, (float)9 / 20, (float)9 / 20, (float)13 / 20, (float)13 / 20, (float)9 / 20, (float)12 / 20, (float)12 / 20 };
                        DF.S2 = new float[] { (float)9 / 20, (float)9 / 20, (float)6 / 20, (float)7 / 20, (float)16 / 20, (float)16 / 20, (float)19 / 20, (float)15 / 20, (float)15 / 20 };
                        FM.S2 = new float[] { (float)19 / 20, (float)19 / 20, (float)19 / 20, (float)19 / 20, (float)18 / 20, (float)18 / 20, (float)6 / 20, (float)20 / 20, (float)20 / 20 };
                        GC.S2 = new float[] { (float)11 / 20, (float)11 / 20, (float)17 / 20, (float)17 / 20, (float)10 / 20, (float)10 / 20, (float)3 / 20, (float)9 / 20, (float)9 / 20 };
                        HS.S2 = new float[] { (float)13 / 20, (float)13 / 20, (float)7 / 20, (float)4 / 20, (float)3 / 20, (float)5 / 20, (float)7 / 20, (float)4 / 20, (float)4 / 20 };
                        HO.S2 = new float[] { (float)12 / 20, (float)12 / 20, (float)20 / 20, (float)20 / 20, (float)7 / 20, (float)8 / 20, (float)16 / 20, (float)16 / 20, (float)16 / 20 };
                        LS.S2 = new float[] { (float)13 / 20, (float)13 / 20, (float)3 / 20, (float)5 / 20, (float)14 / 20, (float)14 / 20, (float)9 / 20, (float)7 / 20, (float)8 / 20 };
                        LAG.S2 = new float[] { (float)10 / 20, (float)10 / 20, (float)4 / 20, (float)7 / 20, (float)9 / 20, (float)9 / 20, (float)8 / 20, (float)5 / 20, (float)5 / 20 };
                        LAV.S2 = new float[] { (float)20 / 20, (float)20 / 20, (float)13 / 20, (float)13 / 20, (float)6 / 20, (float)4 / 20, (float)11 / 20, (float)13 / 20, (float)13 / 20 };
                        NYE.S2 = new float[] { (float)2 / 20, (float)5 / 20, (float)5 / 20, (float)3 / 20, (float)1 / 20, (float)7 / 20, (float)15 / 20, (float)3 / 20, (float)3 / 20 };
                        PE.S2 = new float[] { (float)16 / 20, (float)16 / 20, (float)16 / 20, (float)16 / 20, (float)12 / 20, (float)12 / 20, (float)14 / 20, (float)14 / 20, (float)14 / 20 };
                        PF.S2 = new float[] { (float)3 / 20, (float)4 / 20, (float)11 / 20, (float)11 / 20, (float)11 / 20, (float)11 / 20, (float)12 / 20, (float)10 / 20, (float)10 / 20 };
                        SFS.S2 = new float[] { (float)6 / 20, (float)2 / 20, (float)1 / 20, (float)1 / 20, (float)4 / 20, (float)2 / 20, (float)2 / 20, (float)2 / 20, (float)1 / 20 };
                        SD.S2 = new float[] { (float)6 / 20, (float)3 / 20, (float)10 / 20, (float)10 / 20, (float)5 / 20, (float)6 / 20, (float)13 / 20, (float)8 / 20, (float)7 / 20 };
                        SHD.S2 = new float[] { (float)13 / 20, (float)13 / 20, (float)8 / 20, (float)5 / 20, (float)8 / 20, (float)1 / 20, (float)18 / 20, (float)11 / 20, (float)11 / 20 };
                        TD.S2 = new float[] { (float)4 / 20, (float)7 / 20, (float)15 / 20, (float)15 / 20, (float)19 / 20, (float)19 / 20, (float)17 / 20, (float)17 / 20, (float)17 / 20 };
                        VT.S2 = new float[] { (float)1 / 20, (float)1 / 20, (float)2 / 20, (float)2 / 20, (float)3 / 20, (float)5 / 20, (float)1 / 20, (float)2 / 20, (float)2 / 20 };
                        WJ.S2 = new float[] { (float)18 / 20, (float)18 / 20, (float)18 / 20, (float)18 / 20, (float)19 / 20, (float)19 / 20, (float)4 / 20, (float)17 / 20, (float)17 / 20 };

                        #region Season II Matches
                        #region Stage 1
                        OWL.Match_Result(PF, LS, 3, 1, 2);
                        OWL.Match_Result(NYE, BU, 2, 1, 2);
                        OWL.Match_Result(SD, LAG, 3, 1, 2);
                        OWL.Match_Result(SHD, HS, 1, 3, 2);
                        OWL.Match_Result(TD, HO, 3, 2, 2);
                        OWL.Match_Result(AR, FM, 4, 0, 2);
                        OWL.Match_Result(DF, SFS, 0, 4, 2);
                        OWL.Match_Result(CH, GC, 3, 2, 2);
                        OWL.Match_Result(PE, LS, 3, 1, 2);
                        OWL.Match_Result(WJ, NYE, 1, 3, 2);
                        OWL.Match_Result(LAV, HS, 2, 3, 2);
                        OWL.Match_Result(VT, SHD, 4, 0, 2);
                        OWL.Match_Result(HO, BU, 2, 3, 2);
                        OWL.Match_Result(PF, AR, 3, 2, 2);
                        OWL.Match_Result(SFS, LAG, 2, 3, 2);
                        OWL.Match_Result(SD, DF, 1, 3, 2);

                        OWL.Match_Result(WJ, LS, 2, 3, 2);
                        OWL.Match_Result(PF, FM, 1, 2, 2);
                        OWL.Match_Result(GC, DF, 4, 0, 2);
                        OWL.Match_Result(SD, CH, 4, 0, 2);
                        OWL.Match_Result(AR, TD, 3, 1, 2);
                        OWL.Match_Result(NYE, LAV, 3, 2, 2);
                        OWL.Match_Result(SHD, BU, 3, 1, 2);
                        OWL.Match_Result(HO, HS, 3, 1, 2);
                        OWL.Match_Result(LAG, PE, 1, 2, 2);
                        OWL.Match_Result(PF, DF, 1, 3, 2);
                        OWL.Match_Result(VT, GC, 3, 2, 2);
                        OWL.Match_Result(CH, FM, 3, 2, 2);
                        OWL.Match_Result(HS, LS, 1, 3, 2);
                        OWL.Match_Result(NYE, HO, 4, 0, 2);
                        OWL.Match_Result(TD, LAV, 2, 1, 2);
                        OWL.Match_Result(VT, SFS, 3, 1, 2);

                        OWL.Match_Result(WJ, PF, 1, 3, 2);
                        OWL.Match_Result(SD, BU, 1, 3, 2);
                        OWL.Match_Result(FM, GC, 2, 3, 2);
                        OWL.Match_Result(SFS, HS, 3, 1, 2);
                        OWL.Match_Result(LAG, LS, 1, 2, 2);
                        OWL.Match_Result(TD, NYE, 1, 3, 2);
                        OWL.Match_Result(VT, LAV, 3, 1, 2);
                        OWL.Match_Result(SHD, CH, 4, 0, 2);
                        OWL.Match_Result(PE, AR, 0, 4, 2);
                        OWL.Match_Result(FM, HO, 1, 3, 2);
                        OWL.Match_Result(SFS, WJ, 4, 0, 2);
                        OWL.Match_Result(SHD, DF, 2, 3, 2);
                        OWL.Match_Result(BU, TD, 1, 3, 2);
                        OWL.Match_Result(HS, LAG, 3, 1, 2);
                        OWL.Match_Result(LAV, GC, 1, 3, 2);
                        OWL.Match_Result(NYE, SD, 3, 1, 2);

                        OWL.Match_Result(AR, LAG, 0, 4, 2);
                        OWL.Match_Result(LAV, PF, 2, 3, 2);
                        OWL.Match_Result(TD, CH, 3, 1, 2);
                        OWL.Match_Result(PE, VT, 0, 4, 2);
                        OWL.Match_Result(NYE, SFS, 4, 0, 2);
                        OWL.Match_Result(DF, SHD, 4, 0, 2);
                        OWL.Match_Result(LAV, HO, 1, 2, 2);
                        OWL.Match_Result(SD, WJ, 3, 1, 2);
                        OWL.Match_Result(GC, LAG, 1, 3, 2);
                        OWL.Match_Result(HS, TD, 0, 3, 2);
                        OWL.Match_Result(PE, SFS, 1, 3, 2);
                        OWL.Match_Result(LS, SHD, 2, 3, 2);
                        OWL.Match_Result(FM, BU, 0, 4, 2);
                        OWL.Match_Result(VT, CH, 3, 2, 2);


                        OWL.Match_Result(WJ, PE, 1, 2, 2);
                        OWL.Match_Result(LS, SD, 0, 3, 2);
                        OWL.Match_Result(BU, DF, 3, 2, 2);
                        OWL.Match_Result(AR, CH, 2, 3, 2);
                        OWL.Match_Result(PF, PE, 3, 1, 2);
                        OWL.Match_Result(WJ, FM, 3, 2, 2);
                        OWL.Match_Result(HO, AR, 1, 3, 2);
                        OWL.Match_Result(GC, VT, 3, 1, 2);

                        OWL.Match_Result(SFS, SD, 3, 0, 2);
                        OWL.Match_Result(SD, NYE, 3, 1, 2);
                        OWL.Match_Result(BU, VT, 0, 3, 2);
                        OWL.Match_Result(AR, PF, 1, 3, 2);
                        OWL.Match_Result(TD, SFS, 0, 3, 2);
                        OWL.Match_Result(SD, VT, 0, 4, 2);
                        OWL.Match_Result(SFS, PF, 4, 0, 2);
                        OWL.Match_Result(VT, SFS, 4, 3, 2);

                        #endregion
                        #region Stage 2
                        OWL.Match_Result(PF, NYE, 0, 4, 2);
                        OWL.Match_Result(AR, BU, 2, 3, 2);
                        OWL.Match_Result(SHD, LAG, 1, 3, 2);
                        OWL.Match_Result(GC, PE, 0, 4, 2);
                        OWL.Match_Result(LS, FM, 2, 1, 2);
                        OWL.Match_Result(WJ, TD, 1, 3, 2);
                        OWL.Match_Result(LAV, SFS, 0, 4, 2);
                        OWL.Match_Result(LAG, SD, 3, 2, 2);
                        OWL.Match_Result(FM, PF, 1, 3, 2);
                        OWL.Match_Result(TD, BU, 2, 3, 2);
                        OWL.Match_Result(NYE, SHD, 3, 0, 2);
                        OWL.Match_Result(CH, PE, 4, 0, 2);
                        OWL.Match_Result(SFS, GC, 4, 0, 2);
                        OWL.Match_Result(LS, AR, 0, 4, 2);
                        OWL.Match_Result(VT, HS, 4, 0, 2);
                        OWL.Match_Result(WJ, CH, 1, 3, 2);

                        OWL.Match_Result(PE, FM, 3, 1, 2);
                        OWL.Match_Result(NYE, WJ, 4, 0, 2);
                        OWL.Match_Result(VT, SD, 3, 1, 2);
                        OWL.Match_Result(TD, PF, 1, 3, 2);
                        OWL.Match_Result(LAV, AR, 3, 2, 2);
                        OWL.Match_Result(BU, HS, 2, 3, 2);
                        OWL.Match_Result(GC, SFS, 0, 4, 2);
                        OWL.Match_Result(CH, SHD, 1, 3, 2);
                        OWL.Match_Result(LS, PF, 2, 1, 2);
                        OWL.Match_Result(VT, HO, 3, 1, 2);
                        OWL.Match_Result(DF, TD, 4, 0, 2);
                        OWL.Match_Result(LAG, GC, 4, 0, 2);
                        OWL.Match_Result(DF, PE, 2, 1, 2);
                        OWL.Match_Result(AR, WJ, 3, 1, 2);
                        OWL.Match_Result(NYE, FM, 4, 0, 2);
                        OWL.Match_Result(LAV, LAG, 1, 2, 2);

                        OWL.Match_Result(NYE, PF, 3, 1, 2);
                        OWL.Match_Result(SFS, TD, 4, 0, 2);
                        OWL.Match_Result(FM, LAG, 1, 3, 2);
                        OWL.Match_Result(VT, DF, 4, 0, 2);
                        OWL.Match_Result(NYE, AR, 1, 3, 2);
                        OWL.Match_Result(PF, HO, 4, 0, 2);
                        OWL.Match_Result(LAV, WJ, 3, 1, 2);
                        OWL.Match_Result(HS, GC, 3, 2, 2);
                        OWL.Match_Result(LS, BU, 4, 0, 2);
                        OWL.Match_Result(SHD, FM, 3, 1, 2);
                        OWL.Match_Result(DF, SD, 0, 4, 2);
                        OWL.Match_Result(LAG, CH, 3, 1, 2);
                        OWL.Match_Result(VT, BU, 4, 0, 2);
                        OWL.Match_Result(HO, SHD, 0, 3, 2);
                        OWL.Match_Result(HS, SFS, 0, 4, 2);
                        OWL.Match_Result(AR, GC, 1, 3, 2);

                        OWL.Match_Result(DF, FM, 3, 1, 2);
                        OWL.Match_Result(SFS, PF, 4, 0, 2);
                        OWL.Match_Result(GC, HO, 3, 2, 2);
                        OWL.Match_Result(BU, LAG, 3, 1, 2);
                        OWL.Match_Result(TD, VT, 1, 3, 2);
                        OWL.Match_Result(SHD, WJ, 3, 1, 2);
                        OWL.Match_Result(LS, HO, 4, 0, 2);
                        OWL.Match_Result(AR, NYE, 3, 2, 2);
                        OWL.Match_Result(SD, VT, 0, 4, 2);
                        OWL.Match_Result(CH, LAV, 2, 3, 2);
                        OWL.Match_Result(TD, PE, 4, 0, 2);
                        OWL.Match_Result(WJ, BU, 3, 2, 2);
                        OWL.Match_Result(SHD, SFS, 0, 4, 2);
                        OWL.Match_Result(SD, HS, 1, 3, 2);


                        OWL.Match_Result(LS, PE, 4, 0, 2);
                        OWL.Match_Result(HS, CH, 3, 1, 2);
                        OWL.Match_Result(HO, SD, 0, 4, 2);
                        OWL.Match_Result(LAV, DF, 0, 4, 2);
                        OWL.Match_Result(HS, PE, 3, 2, 2);
                        OWL.Match_Result(CH, LS, 3, 1, 2);
                        OWL.Match_Result(SD, LAV, 3, 2, 2);
                        OWL.Match_Result(HO, DF, 1, 3, 2);

                        OWL.Match_Result(SFS, SHD, 1, 3, 2);
                        OWL.Match_Result(HS, LS, 3, 1, 2);
                        OWL.Match_Result(LAG, NYE, 0, 3, 2);
                        OWL.Match_Result(DF, VT, 0, 3, 2);
                        OWL.Match_Result(HS, SFS, 0, 4, 2);
                        OWL.Match_Result(NYE, VT, 1, 4, 2);
                        OWL.Match_Result(SFS, VT, 4, 2, 2);


                        #endregion
                        #region Stage 3
                        OWL.Match_Result(SFS, AR, 3, 2, 2);
                        OWL.Match_Result(FM, SD, 0, 4, 2);
                        OWL.Match_Result(GC, CH, 3, 1, 2);
                        OWL.Match_Result(LAV, SHD, 1, 3, 2);
                        OWL.Match_Result(PE, TD, 3, 1, 2);
                        OWL.Match_Result(BU, LS, 0, 4, 2);
                        OWL.Match_Result(HO, NYE, 2, 3, 2);
                        OWL.Match_Result(LAG, DF, 4, 0, 2);
                        OWL.Match_Result(HS, PF, 4, 0, 2);
                        OWL.Match_Result(VT, AR, 3, 1, 2);
                        OWL.Match_Result(SD, GC, 4, 0, 2);
                        OWL.Match_Result(LAV, CH, 4, 0, 2);
                        OWL.Match_Result(NYE, LS, 4, 0, 2);
                        OWL.Match_Result(PE, BU, 3, 1, 2);
                        OWL.Match_Result(WJ, DF, 0, 3, 2);
                        OWL.Match_Result(VT, LAG, 3, 1, 2);

                        OWL.Match_Result(HO, SFS, 3, 2, 2);
                        OWL.Match_Result(SHD, AR, 3, 2, 2);
                        OWL.Match_Result(DF, CH, 1, 3, 2);
                        OWL.Match_Result(HS, VT, 1, 3, 2);
                        OWL.Match_Result(PE, NYE, 1, 3, 2);
                        OWL.Match_Result(TD, LS, 1, 3, 2);
                        OWL.Match_Result(BU, HO, 0, 4, 2);
                        OWL.Match_Result(LAG, PF, 3, 1, 2);
                        OWL.Match_Result(WJ, HS, 0, 3, 2);
                        OWL.Match_Result(SD, AR, 4, 0, 2);
                        OWL.Match_Result(DF, VT, 0, 4, 2);
                        OWL.Match_Result(LAV, GC, 3, 1, 2);
                        OWL.Match_Result(SFS, SD, 4, 0, 2);
                        OWL.Match_Result(FM, PE, 1, 3, 2);
                        OWL.Match_Result(PF, BU, 2, 1, 2);
                        OWL.Match_Result(WJ, LAG, 0, 4, 2);

                        OWL.Match_Result(SFS, BU, 4, 0, 2);
                        OWL.Match_Result(PE, HO, 1, 3, 2);
                        OWL.Match_Result(HS, DF, 3, 0, 2);
                        OWL.Match_Result(SHD, LAV, 1, 3, 2);
                        OWL.Match_Result(LS, NYE, 2, 3, 2);
                        OWL.Match_Result(SFS, FM, 4, 0, 2);
                        OWL.Match_Result(LAG, SHD, 1, 3, 2);
                        OWL.Match_Result(CH, VT, 1, 3, 2);
                        OWL.Match_Result(LS, WJ, 2, 1, 2);
                        OWL.Match_Result(AR, PF, 2, 3, 2);
                        OWL.Match_Result(TD, GC, 0, 4, 2);
                        OWL.Match_Result(HS, SD, 3, 2, 2);
                        OWL.Match_Result(CH, DF, 4, 0, 2);
                        OWL.Match_Result(BU, PE, 3, 2, 2);
                        OWL.Match_Result(HO, FM, 1, 3, 2);
                        OWL.Match_Result(LAV, VT, 3, 1, 2);

                        OWL.Match_Result(HS, LAV, 3, 2, 2);
                        OWL.Match_Result(PE, SD, 1, 3, 2);
                        OWL.Match_Result(SFS, CH, 2, 3, 2);
                        OWL.Match_Result(LS, LAV, 0, 4, 2);
                        OWL.Match_Result(TD, LAG, 0, 4, 2);
                        OWL.Match_Result(HO, WJ, 3, 0, 2);
                        OWL.Match_Result(DF, NYE, 2, 3, 2);
                        OWL.Match_Result(BU, PF, 2, 3, 2);
                        OWL.Match_Result(FM, HS, 0, 4, 2);
                        OWL.Match_Result(SHD, GC, 3, 1, 2);
                        OWL.Match_Result(LAG, VT, 0, 4, 2);
                        OWL.Match_Result(LS, SFS, 0, 4, 2);
                        OWL.Match_Result(HO, TD, 3, 1, 2);
                        OWL.Match_Result(CH, SD, 0, 3, 2);


                        OWL.Match_Result(FM, NYE, 0, 3, 2);
                        OWL.Match_Result(PF, WJ, 3, 1, 2);
                        OWL.Match_Result(TD, AR, 1, 3, 2);
                        OWL.Match_Result(GC, SHD, 3, 1, 2);
                        OWL.Match_Result(PF, SHD, 1, 3, 2);
                        OWL.Match_Result(WJ, GC, 0, 4, 2);
                        OWL.Match_Result(FM, AR, 0, 4, 2);
                        OWL.Match_Result(NYE, TD, 4, 0, 2);

                        OWL.Match_Result(HO, VT, 0, 3, 2);
                        OWL.Match_Result(SHD, NYE, 3, 1, 2);
                        OWL.Match_Result(SD, SFS, 1, 3, 2);
                        OWL.Match_Result(LAV, HS, 3, 2, 2);
                        OWL.Match_Result(SHD, VT, 4, 1, 2);
                        OWL.Match_Result(LAV, SFS, 0, 4, 2);
                        OWL.Match_Result(SHD, SFS, 4, 3, 2);


                        #endregion
                        #region Stage 4
                        OWL.Match_Result(HO, PE, 1, 3, 2);
                        OWL.Match_Result(LAG, NYE, 3, 1, 2);
                        OWL.Match_Result(GC, PF, 3, 2, 2);
                        OWL.Match_Result(VT, SHD, 3, 1, 2);
                        OWL.Match_Result(WJ, TD, 3, 1, 2);
                        OWL.Match_Result(DF, LS, 1, 3, 2);
                        OWL.Match_Result(SD, SFS, 1, 3, 2);
                        OWL.Match_Result(PF, CH, 2, 3, 2);
                        OWL.Match_Result(LAV, PE, 3, 2, 2);
                        OWL.Match_Result(BU, GC, 0, 4, 2);
                        OWL.Match_Result(LAG, HO, 1, 3, 2);
                        OWL.Match_Result(AR, HS, 3, 1, 2);
                        OWL.Match_Result(SHD, SD, 3, 1, 2);
                        OWL.Match_Result(LS, TD, 3, 1, 2);
                        OWL.Match_Result(VT, FM, 4, 0, 2);
                        OWL.Match_Result(BU, CH, 2, 3, 2);

                        OWL.Match_Result(GC, LS, 1, 3, 2);
                        OWL.Match_Result(FM, WJ, 2, 3, 2);
                        OWL.Match_Result(SHD, TD, 1, 2, 2);
                        OWL.Match_Result(LAV, SD, 2, 3, 2);
                        OWL.Match_Result(PE, NYE, 1, 3, 2);
                        OWL.Match_Result(HO, PF, 1, 3, 2);
                        OWL.Match_Result(CH, LAG, 2, 3, 2);
                        OWL.Match_Result(GC, HS, 3, 0, 2);
                        OWL.Match_Result(AR, PE, 4, 0, 2);
                        OWL.Match_Result(FM, LS, 3, 0, 2);
                        OWL.Match_Result(DF, LAV, 1, 3, 2);
                        OWL.Match_Result(LAG, SFS, 2, 3, 2);
                        OWL.Match_Result(AR, HO, 3, 1, 2);
                        OWL.Match_Result(PF, TD, 3, 2, 2);
                        OWL.Match_Result(VT, WJ, 0, 4, 2);
                        OWL.Match_Result(CH, NYE, 4, 0, 2);

                        OWL.Match_Result(LS, VT, 2, 3, 2);
                        OWL.Match_Result(PE, PF, 3, 2, 2);
                        OWL.Match_Result(TD, FM, 1, 3, 2);
                        OWL.Match_Result(GC, SD, 3, 2, 2);
                        OWL.Match_Result(BU, WJ, 1, 3, 2);
                        OWL.Match_Result(DF, LAG, 2, 3, 2);
                        OWL.Match_Result(SFS, SHD, 3, 1, 2);
                        OWL.Match_Result(HS, NYE, 2, 3, 2);
                        OWL.Match_Result(HO, LS, 1, 3, 2);
                        OWL.Match_Result(SD, TD, 2, 1, 2);
                        OWL.Match_Result(FM, LAV, 1, 2, 2);
                        OWL.Match_Result(CH, HS, 1, 3, 2);
                        OWL.Match_Result(PF, VT, 0, 4, 2);
                        OWL.Match_Result(WJ, HO, 3, 2, 2);
                        OWL.Match_Result(SFS, DF, 4, 0, 2);
                        OWL.Match_Result(GC, NYE, 4, 0, 2);

                        OWL.Match_Result(BU, FM, 0, 4, 2);
                        OWL.Match_Result(DF, HS, 1, 3, 2);
                        OWL.Match_Result(SD, SHD, 3, 1, 2);
                        OWL.Match_Result(WJ, AR, 1, 2, 2);
                        OWL.Match_Result(CH, SFS, 0, 4, 2);
                        OWL.Match_Result(LAG, HS, 2, 3, 2);
                        OWL.Match_Result(PE, SHD, 3, 1, 2);
                        OWL.Match_Result(LAV, BU, 3, 1, 2);
                        OWL.Match_Result(SD, PF, 1, 3, 2);
                        OWL.Match_Result(CH, HO, 3, 2, 2);
                        OWL.Match_Result(LS, AR, 0, 4, 2);
                        OWL.Match_Result(PE, WJ, 1, 3, 2);
                        OWL.Match_Result(FM, TD, 4, 0, 2);
                        OWL.Match_Result(DF, GC, 0, 4, 2);


                        OWL.Match_Result(AR, DF, 3, 1, 2);
                        OWL.Match_Result(BU, NYE, 1, 3, 2);
                        OWL.Match_Result(SFS, VT, 3, 2, 2);
                        OWL.Match_Result(LAG, LAV, 3, 1, 2);
                        OWL.Match_Result(HS, SHD, 4, 0, 2);
                        OWL.Match_Result(AR, BU, 4, 0, 2);
                        OWL.Match_Result(NYE, VT, 2, 3, 2);
                        OWL.Match_Result(SFS, LAV, 4, 0, 2);

                        OWL.Match_Result(HO, VT, 0, 3, 2);
                        OWL.Match_Result(SHD, NYE, 3, 1, 2);
                        OWL.Match_Result(SD, SFS, 1, 3, 2);
                        OWL.Match_Result(LAV, HS, 3, 2, 2);
                        OWL.Match_Result(SHD, VT, 4, 1, 2);
                        OWL.Match_Result(LAV, SFS, 0, 4, 2);
                        OWL.Match_Result(SHD, SFS, 4, 3, 2);


                        #endregion
                        #region PlayOffs
                        OWL.Match_Result(GC, CH, 4, 1, 2);
                        OWL.Match_Result(PF, SHD, 2, 4, 2);
                        OWL.Match_Result(LS, SHD, 4, 3, 2);
                        OWL.Match_Result(VT, SD, 4, 2, 2);
                        OWL.Match_Result(HS, LAG, 3, 4, 2);
                        OWL.Match_Result(NYE, LS, 4, 1, 2);
                        OWL.Match_Result(SFS, AR, 3, 4, 2);
                        OWL.Match_Result(SD, HS, 1, 4, 2);
                        OWL.Match_Result(LS, SFS, 0, 4, 2);
                        OWL.Match_Result(VT, LAG, 4, 2, 2);
                        OWL.Match_Result(NYE, AR, 4, 2, 2);
                        OWL.Match_Result(AR, HS, 0, 4, 2);
                        OWL.Match_Result(LAG, SFS, 0, 4, 2);
                        OWL.Match_Result(HS, SFS, 0, 4, 2);
                        OWL.Match_Result(NYE, SFS, 0, 4, 2);
                        OWL.Match_Result(NYE, VT, 3, 4, 2);
                        OWL.Match_Result(VT, SFS, 0, 4, 2);
                        #endregion
                        #endregion

                        #region Show results
                        for (int i = 0; i < Teams.GetLength(0); i++)
                        {
                            Teams[i].Final2();
                            Teams[i].Maps_Diff(2);
                            Teams[i].Win_Per(2);
                        }
                        Array.Sort(Teams, new TC2());
                        for (int i = 0; i < Teams.GetLength(0); i++)
                            Teams[i].Show2();
                        #endregion
                        #endregion
                        break;
                    case "3":
                        #region SEASON 3
                        Console.WriteLine();
                        Console.WriteLine("SEASON III STANDINGS 2020");
                        Console.WriteLine();
                        //Season III
                        Console.WriteLine("     TEAM             :  WIN |  LOSS  | DIFF  |SCORE|WINRATE| GAMES |  SI  |  TI  | S II | T II | SIII | TIII | S IV |  PO  |");
                        AR.S3 = new float[] { (float)10 / 20, (float)6 / 13, (float)4 / 20, (float)7 / 13, (float)7 / 20, (float)6 / 13, (float)5 / 13, (float)12 / 20 };
                        BU.S3 = new float[] { (float)15 / 20, (float)9 / 13, (float)18 / 20, (float)13 / 13, (float)20 / 20, (float)13 / 13, (float)10 / 13, (float)20 / 20 };
                        CH.S3 = new float[] { (float)16 / 20, (float)5 / 7, (float)20 / 20, (float)6 / 7, (float)5 / 20, (float)4 / 7, (float)5 / 7, (float)14 / 20 };
                        DF.S3 = new float[] { (float)12 / 20, (float)8 / 13, (float)13 / 20, (float)11 / 13, (float)11 / 20, (float)5 / 13, (float)11 / 13, (float)13 / 20 };
                        FM.S3 = new float[] { (float)3 / 20, (float)2 / 13, (float)9 / 20, (float)12 / 13, (float)6 / 20, (float)3 / 13, (float)4 / 13, (float)7 / 20 };
                        GC.S3 = new float[] { (float)1 / 20, (float)3 / 7, (float)2 / 20, (float)1 / 7, (float)9 / 20, (float)5 / 7, (float)4 / 7, (float)6 / 20 };
                        HS.S3 = new float[] { (float)9 / 20, (float)7 / 7, (float)17 / 20, (float)7 / 7, (float)8 / 20, (float)2 / 7, (float)6 / 7, (float)10 / 20 };
                        HO.S3 = new float[] { (float)13 / 20, (float)10 / 13, (float)14 / 20, (float)6 / 13, (float)18 / 20, (float)10 / 13, (float)12 / 13, (float)16 / 20 };
                        LS.S3 = new float[] { (float)17 / 20, (float)5 / 7, (float)12 / 20, (float)5 / 7, (float)16 / 20, (float)7 / 7, (float)7 / 7, (float)17 / 20 };
                        LAG.S3 = new float[] { (float)11 / 20, (float)6 / 13, (float)8 / 20, (float)9 / 13, (float)14 / 20, (float)8 / 13, (float)7 / 13, (float)11 / 20 };
                        LAV.S3 = new float[] { (float)5 / 20, (float)4 / 13, (float)7 / 20, (float)10 / 13, (float)10 / 20, (float)7 / 13, (float)6 / 13, (float)9 / 20 };
                        NYE.S3 = new float[] { (float)8 / 20, (float)4 / 7, (float)11 / 20, (float)3 / 7, (float)13 / 20, (float)3 / 7, (float)3 / 7, (float)8 / 20 };
                        PE.S3 = new float[] { (float)7 / 20, (float)5 / 13, (float)10 / 20, (float)1 / 13, (float)2 / 20, (float)4 / 13, (float)8 / 13, (float)5 / 20 };
                        PF.S3 = new float[] { (float)4 / 20, (float)3 / 13, (float)5 / 20, (float)2 / 13, (float)3 / 20, (float)2 / 13, (float)2 / 13, (float)4 / 20 };
                        SFS.S3 = new float[] { (float)2 / 20, (float)1 / 13, (float)3 / 20, (float)3 / 13, (float)1 / 20, (float)1 / 13, (float)1 / 13, (float)1 / 20 };
                        SD.S3 = new float[] { (float)18 / 20, (float)2 / 7, (float)16 / 20, (float)4 / 7, (float)17 / 20, (float)6 / 7, (float)2 / 7, (float)2 / 20 };
                        SHD.S3 = new float[] { (float)6 / 20, (float)1 / 7, (float)1 / 20, (float)2 / 7, (float)4 / 20, (float)1 / 7, (float)1 / 7, (float)3 / 20 };
                        TD.S3 = new float[] { (float)19 / 20, (float)11 / 13, (float)15 / 20, (float)4 / 13, (float)12 / 20, (float)12 / 13, (float)9 / 13, (float)15 / 20 };
                        VT.S3 = new float[] { (float)20 / 20, (float)13 / 13, (float)6 / 20, (float)8 / 13, (float)19 / 20, (float)9 / 13, (float)13 / 13, (float)18 / 20 };
                        WJ.S3 = new float[] { (float)14 / 20, (float)11 / 13, (float)19 / 20, (float)5 / 13, (float)15 / 20, (float)11 / 13, (float)3 / 13, (float)19 / 20 };
                        #region Season III matches
                        #region FEB-APR
                        OWL.Match_Result(TD, PE, 3, 1, 3);
                        OWL.Match_Result(LS, NYE, 1, 3, 3);
                        OWL.Match_Result(LS, PE, 0, 3, 3);
                        OWL.Match_Result(BU, NYE, 0, 3, 3);
                        OWL.Match_Result(LAG, VT, 2, 3, 3);
                        OWL.Match_Result(LAV, DF, 3, 1, 3);
                        OWL.Match_Result(LAV, VT, 0, 3, 3);
                        OWL.Match_Result(SFS, DF, 3, 1, 3);
                        OWL.Match_Result(FM, HO, 3, 0, 3);
                        OWL.Match_Result(WJ, PF, 1, 3, 3);
                        OWL.Match_Result(WJ, HO, 3, 0, 3);
                        OWL.Match_Result(FM, PF, 0, 3, 3);
                        OWL.Match_Result(NYE, PF, 1, 3, 3);
                        OWL.Match_Result(BU, HO, 3, 2, 3);
                        OWL.Match_Result(PE, WJ, 3, 1, 3);
                        OWL.Match_Result(NYE, HO, 3, 0, 3);
                        OWL.Match_Result(TD, PF, 2, 3, 3);
                        OWL.Match_Result(LS, WJ, 3, 2, 3);
                        OWL.Match_Result(NYE, FM, 3, 0, 3);
                        OWL.Match_Result(TD, AR, 0, 3, 3);
                        OWL.Match_Result(LS, HO, 3, 2, 3);
                        OWL.Match_Result(BU, PF, 0, 3, 3);
                        OWL.Match_Result(PE, AR, 3, 1, 3);
                        OWL.Match_Result(LS, FM, 3, 2, 3);
                        OWL.Match_Result(TD, HO, 1, 3, 3);


                        OWL.Match_Result(TD, FM, 1, 3, 3);
                        OWL.Match_Result(PE, HO, 0, 3, 3);
                        OWL.Match_Result(BU, WJ, 1, 3, 3);
                        OWL.Match_Result(PE, PF, 3, 2, 3);
                        OWL.Match_Result(WJ, NYE, 1, 3, 3);
                        OWL.Match_Result(BU, AR, 0, 3, 3);
                        OWL.Match_Result(GC, SHD, 0, 3, 3);
                        OWL.Match_Result(CH, HS, 2, 3, 3);
                        OWL.Match_Result(TD, BU, 3, 1, 3);
                        OWL.Match_Result(LAV, SD, 0, 3, 3);
                        OWL.Match_Result(SFS, LAG, 1, 3, 3);
                        OWL.Match_Result(CH, SHD, 3, 0, 3);
                        OWL.Match_Result(HS, GC, 2, 3, 3);
                        OWL.Match_Result(FM, AR, 0, 3, 3);
                        OWL.Match_Result(SD, LAG, 3, 0, 3);
                        OWL.Match_Result(LAV, SFS, 3, 1, 3);

                        OWL.Match_Result(TD, WJ, 3, 1, 3);
                        OWL.Match_Result(LAG, DF, 3, 0, 3);
                        OWL.Match_Result(LAV, SFS, 1, 3, 3);
                        OWL.Match_Result(SHD, HS, 3, 0, 3);
                        OWL.Match_Result(CH, GC, 2, 3, 3);
                        OWL.Match_Result(HO, PE, 1, 3, 3);
                        OWL.Match_Result(PF, WJ, 3, 0, 3);
                        OWL.Match_Result(DF, LAV, 3, 2, 3);
                        OWL.Match_Result(CH, SHD, 1, 3, 3);
                        OWL.Match_Result(GC, HS, 2, 3, 3);
                        OWL.Match_Result(HS, CH, 3, 0, 3);
                        OWL.Match_Result(VT, GC, 0, 3, 3);
                        OWL.Match_Result(PF, PE, 3, 2, 3);
                        OWL.Match_Result(HO, BU, 3, 1, 3);
                        OWL.Match_Result(CH, VT, 3, 1, 3);
                        OWL.Match_Result(SHD, GC, 3, 0, 3);
                        OWL.Match_Result(HO, TD, 3, 2, 3);
                        OWL.Match_Result(PF, AR, 3, 2, 3);
                        OWL.Match_Result(SFS, LAG, 3, 0, 3);
                        OWL.Match_Result(WJ, AR, 0, 3, 3);
                        OWL.Match_Result(LAG, LAV, 3, 0, 3);
                        OWL.Match_Result(FM, PE, 3, 0, 3);
                        OWL.Match_Result(BU, TD, 1, 3, 3);
                        OWL.Match_Result(DF, SFS, 2, 3, 3);
                        OWL.Match_Result(CH, GC, 3, 0, 3);
                        OWL.Match_Result(SHD, HS, 3, 0, 3);
                        OWL.Match_Result(GC, HS, 3, 1, 3);
                        OWL.Match_Result(CH, SHD, 0, 3, 3);
                        OWL.Match_Result(SD, HS, 3, 0, 3);
                        OWL.Match_Result(GC, SHD, 0, 3, 3);
                        OWL.Match_Result(NYE, CH, 3, 0, 3);
                        OWL.Match_Result(AR, PF, 0, 3, 3);
                        OWL.Match_Result(SFS, LAV, 3, 0, 3);
                        OWL.Match_Result(HS, CH, 3, 1, 3);
                        OWL.Match_Result(SHD, SD, 3, 0, 3);
                        OWL.Match_Result(GC, NYE, 0, 3, 3);
                        OWL.Match_Result(FM, BU, 3, 0, 3);
                        OWL.Match_Result(HO, DF, 2, 3, 3);
                        #endregion
                        #region Stage 1
                        OWL.Match_Result(GC, SD, 3, 0, 3);
                        OWL.Match_Result(NYE, SHD, 2, 3, 3);
                        OWL.Match_Result(DF, WJ, 3, 0, 3);
                        OWL.Match_Result(LAV, AR, 3, 2, 3);
                        OWL.Match_Result(HO, SFS, 0, 3, 3);
                        OWL.Match_Result(SD, HS, 0, 3, 3);
                        OWL.Match_Result(CH, NYE, 1, 3, 3);
                        OWL.Match_Result(PF, PE, 3, 2, 3);
                        OWL.Match_Result(FM, BU, 3, 0, 3);
                        OWL.Match_Result(TD, LAG, 1, 3, 3);

                        OWL.Match_Result(SHD, SD, 2, 3, 3);
                        OWL.Match_Result(CH, LS, 0, 3, 3);
                        OWL.Match_Result(GC, NYE, 3, 1, 3);
                        OWL.Match_Result(PE, LAG, 3, 1, 3);
                        OWL.Match_Result(WJ, VT, 3, 1, 3);
                        OWL.Match_Result(HO, AR, 0, 3, 3);
                        OWL.Match_Result(LAV, BU, 3, 0, 3);
                        OWL.Match_Result(HS, SHD, 0, 3, 3);
                        OWL.Match_Result(LS, GC, 1, 3, 3);
                        OWL.Match_Result(DF, PF, 1, 3, 3);
                        OWL.Match_Result(TD, SFS, 1, 3, 3);
                        OWL.Match_Result(FM, VT, 3, 0, 3);

                        OWL.Match_Result(SD, CH, 0, 3, 3);
                        OWL.Match_Result(LS, SHD, 0, 3, 3);
                        OWL.Match_Result(NYE, HS, 3, 1, 3);
                        OWL.Match_Result(VT, HO, 0, 3, 3);
                        OWL.Match_Result(FM, WJ, 3, 1, 3);
                        OWL.Match_Result(LAG, BU, 2, 3, 3);
                        OWL.Match_Result(SFS, AR, 3, 0, 3);
                        OWL.Match_Result(GC, CH, 3, 2, 3);
                        OWL.Match_Result(HS, LS, 3, 0, 3);
                        OWL.Match_Result(DF, PE, 0, 3, 3);
                        OWL.Match_Result(PF, VT, 3, 0, 3);
                        OWL.Match_Result(TD, LAV, 2, 3, 3);

                        OWL.Match_Result(VT, TD, 2, 3, 3);
                        OWL.Match_Result(DF, HO, 3, 1, 3);
                        OWL.Match_Result(LAG, WJ, 3, 0, 3);
                        OWL.Match_Result(AR, TD, 3, 0, 3);
                        OWL.Match_Result(PE, BU, 3, 2, 3);
                        OWL.Match_Result(SFS, DF, 3, 1, 3);
                        OWL.Match_Result(LAV, PE, 3, 2, 3);
                        OWL.Match_Result(PF, LAG, 3, 1, 3);
                        OWL.Match_Result(FM, AR, 3, 1, 3);
                        OWL.Match_Result(SFS, LAV, 3, 0, 3);
                        OWL.Match_Result(PF, FM, 1, 3, 3);
                        OWL.Match_Result(SFS, FM, 4, 2, 3);

                        OWL.Match_Result(HS, SD, 0, 3, 3);
                        OWL.Match_Result(NYE, CH, 3, 2, 3);
                        OWL.Match_Result(SHD, LS, 3, 2, 3);
                        OWL.Match_Result(GC, SD, 2, 3, 3);
                        OWL.Match_Result(NYE, SHD, 0, 3, 3);
                        OWL.Match_Result(SD, SHD, 3, 4, 3);
                        #endregion
                        #region Stage 2
                        OWL.Match_Result(LS, SHD, 0, 3, 3);
                        OWL.Match_Result(NYE, SD, 3, 0, 3);
                        OWL.Match_Result(PE, BU, 3, 2, 3);
                        OWL.Match_Result(FM, DF, 3, 1, 3);
                        OWL.Match_Result(AR, LAG, 1, 3, 3);
                        OWL.Match_Result(PF, HO, 3, 0, 3);
                        OWL.Match_Result(VT, TD, 0, 3, 3);
                        OWL.Match_Result(LAV, WJ, 3, 0, 3);


                        OWL.Match_Result(SD, GC, 2, 3, 3);
                        OWL.Match_Result(LS, CH, 3, 0, 3);
                        OWL.Match_Result(HS, NYE, 3, 2, 3);
                        OWL.Match_Result(SFS, PE, 3, 0, 3);
                        OWL.Match_Result(AR, TD, 3, 0, 3);
                        OWL.Match_Result(LAG, HO, 1, 3, 3);
                        OWL.Match_Result(DF, VT, 0, 3, 3);
                        OWL.Match_Result(GC, HS, 3, 2, 3);
                        OWL.Match_Result(CH, SHD, 2, 3, 3);
                        OWL.Match_Result(NYE, LS, 3, 1, 3);
                        OWL.Match_Result(BU, PF, 0, 3, 3);
                        OWL.Match_Result(LAV, FM, 3, 1, 3);
                        OWL.Match_Result(WJ, SFS, 0, 3, 3);

                        OWL.Match_Result(CH, GC, 1, 3, 3);
                        OWL.Match_Result(SD, SHD, 1, 3, 3);
                        OWL.Match_Result(HS, LS, 0, 3, 3);
                        OWL.Match_Result(FM, HO, 3, 2, 3);
                        OWL.Match_Result(DF, TD, 3, 0, 3);
                        OWL.Match_Result(VT, BU, 3, 0, 3);
                        OWL.Match_Result(WJ, LAG, 1, 3, 3);
                        OWL.Match_Result(SHD, HS, 3, 0, 3);
                        OWL.Match_Result(CH, SD, 0, 3, 3);
                        OWL.Match_Result(NYE, GC, 2, 3, 3);
                        OWL.Match_Result(LAV, PE, 1, 3, 3);
                        OWL.Match_Result(AR, VT, 3, 0, 3);
                        OWL.Match_Result(PF, SFS, 0, 3, 3);

                        OWL.Match_Result(WJ, BU, 3, 1, 3);
                        OWL.Match_Result(LAV, TD, 1, 3, 3);
                        OWL.Match_Result(LAG, WJ, 1, 3, 3);
                        OWL.Match_Result(FM, HO, 1, 3, 3);
                        OWL.Match_Result(PE, DF, 3, 1, 3);
                        OWL.Match_Result(SFS, WJ, 3, 0, 3);
                        OWL.Match_Result(VT, PE, 1, 3, 3);
                        OWL.Match_Result(PF, HO, 3, 0, 3);
                        OWL.Match_Result(AR, TD, 2, 3, 3);
                        OWL.Match_Result(SFS, PE, 2, 3, 3);
                        OWL.Match_Result(PF, TD, 3, 0, 3);
                        OWL.Match_Result(PE, PF, 4, 3, 3);

                        OWL.Match_Result(LS, SD, 1, 3, 3);
                        OWL.Match_Result(GC, CH, 3, 0, 3);
                        OWL.Match_Result(NYE, HS, 3, 0, 3);
                        OWL.Match_Result(SHD, SD, 3, 0, 3);
                        OWL.Match_Result(GC, NYE, 3, 0, 3);
                        OWL.Match_Result(GC, SHD, 4, 2, 3);
                        #endregion
                        #region Stage 3
                        OWL.Match_Result(VT, PE, 0, 3, 3);
                        OWL.Match_Result(HO, DF, 2, 3, 3);
                        OWL.Match_Result(HS, SD, 3, 0, 3);
                        OWL.Match_Result(GC, LS, 3, 1, 3);
                        OWL.Match_Result(CH, NYE, 3, 2, 3);
                        OWL.Match_Result(VT, LAG, 0, 3, 3);
                        OWL.Match_Result(WJ, TD, 0, 3, 3);
                        OWL.Match_Result(SFS, BU, 3, 0, 3);
                        OWL.Match_Result(LAV, AR, 0, 3, 3);
                        OWL.Match_Result(PE, TD, 3, 0, 3);
                        OWL.Match_Result(AR, FM, 1, 3, 3);
                        OWL.Match_Result(BU, LAV, 0, 3, 3);

                        OWL.Match_Result(AR, BU, 3, 1, 3);
                        OWL.Match_Result(FM, SFS, 1, 3, 3);
                        OWL.Match_Result(SD, CH, 2, 3, 3);
                        OWL.Match_Result(SHD, LS, 3, 2, 3);
                        OWL.Match_Result(NYE, GC, 3, 0, 3);
                        OWL.Match_Result(SFS, VT, 3, 0, 3);
                        OWL.Match_Result(FM, WJ, 3, 0, 3);
                        OWL.Match_Result(BU, DF, 1, 3, 3);
                        OWL.Match_Result(PF, LAG, 3, 2, 3);
                        OWL.Match_Result(CH, HS, 3, 0, 3);
                        OWL.Match_Result(SHD, SD, 3, 0, 3);
                        OWL.Match_Result(LAG, PE, 0, 3, 3);
                        OWL.Match_Result(TD, PF, 0, 3, 3);
                        OWL.Match_Result(WJ, HO, 3, 1, 3);

                        OWL.Match_Result(DF, PF, 0, 3, 3);
                        OWL.Match_Result(LAV, HO, 3, 2, 3);
                        OWL.Match_Result(SD, GC, 1, 3, 3);
                        OWL.Match_Result(LS, HS, 0, 3, 3);
                        OWL.Match_Result(NYE, SHD, 1, 3, 3);
                        OWL.Match_Result(PE, WJ, 3, 1, 3);
                        OWL.Match_Result(TD, VT, 3, 2, 3);
                        OWL.Match_Result(HO, SFS, 0, 3, 3);
                        OWL.Match_Result(DF, AR, 1, 3, 3);
                        OWL.Match_Result(LAG, FM, 1, 3, 3);
                        OWL.Match_Result(PF, LAV, 3, 0, 3);

                        OWL.Match_Result(BU, VT, 0, 3, 3);
                        OWL.Match_Result(AR, VT, 3, 0, 3);
                        OWL.Match_Result(LAV, HO, 3, 0, 3);
                        OWL.Match_Result(DF, WJ, 3, 2, 3);
                        OWL.Match_Result(TD, LAG, 2, 3, 3);
                        OWL.Match_Result(SFS, DF, 3, 0, 3);
                        OWL.Match_Result(FM, AR, 3, 0, 3);
                        OWL.Match_Result(PE, LAV, 3, 1, 3);
                        OWL.Match_Result(PF, LAG, 3, 0, 3);
                        OWL.Match_Result(SFS, FM, 3, 1, 3);
                        OWL.Match_Result(PF, PE, 1, 3, 3);
                        OWL.Match_Result(SFS, PF, 4, 2, 3);

                        OWL.Match_Result(NYE, GC, 2, 3, 3);
                        OWL.Match_Result(HS, SD, 3, 2, 3);
                        OWL.Match_Result(CH, LS, 3, 0, 3);
                        OWL.Match_Result(SHD, NYE, 3, 0, 3);
                        OWL.Match_Result(HS, CH, 3, 1, 3);
                        OWL.Match_Result(SHD, HS, 4, 0, 3);

                        #endregion
                        #region Stage 4
                        OWL.Match_Result(LS, SD, 0, 3, 3);
                        OWL.Match_Result(FM, VT, 3, 1, 3);
                        OWL.Match_Result(LAG, DF, 3, 0, 3);
                        OWL.Match_Result(NYE, SD, 0, 3, 3);
                        OWL.Match_Result(SHD, LS, 3, 0, 3);
                        OWL.Match_Result(AR, PE, 2, 3, 3);
                        OWL.Match_Result(VT, DF, 0, 3, 3);
                        OWL.Match_Result(BU, LAG, 0, 3, 3);
                        OWL.Match_Result(SFS, PF, 0, 3, 3);
                        OWL.Match_Result(SD, LS, 3, 0, 3);
                        OWL.Match_Result(SFS, TD, 3, 0, 3);
                        OWL.Match_Result(FM, LAV, 2, 3, 3);
                        OWL.Match_Result(VT, AR, 3, 1, 3);

                        OWL.Match_Result(VT, BU, 3, 0, 3);
                        OWL.Match_Result(LAG, FM, 1, 3, 3);
                        OWL.Match_Result(HS, SD, 3, 0, 3);
                        OWL.Match_Result(LS, NYE, 1, 3, 3);
                        OWL.Match_Result(WJ, SFS, 0, 3, 3);
                        OWL.Match_Result(DF, TD, 3, 1, 3);
                        OWL.Match_Result(LAG, AR, 3, 1, 3);
                        OWL.Match_Result(LAV, VT, 3, 0, 3);
                        OWL.Match_Result(SD, LS, 3, 2, 3);
                        OWL.Match_Result(DF, PE, 1, 3, 3);
                        OWL.Match_Result(SFS, AR, 3, 2, 3);
                        OWL.Match_Result(LAV, LAG, 2, 3, 3);

                        #endregion
                        #region Playoffs
                        OWL.Match_Result(HO, BU, 1, 3, 3);
                        OWL.Match_Result(VT, WJ, 0, 3, 3);
                        OWL.Match_Result(LAG, TD, 3, 2, 3);
                        OWL.Match_Result(AR, BU, 3, 1, 3);
                        OWL.Match_Result(DF, WJ, 0, 3, 3);

                        OWL.Match_Result(PF, LAG, 3, 0, 3);
                        OWL.Match_Result(FM, LAV, 2, 3, 3);
                        OWL.Match_Result(SFS, WJ, 3, 2, 3);
                        OWL.Match_Result(PE, AR, 2, 3, 3);
                        OWL.Match_Result(LAG, FM, 0, 3, 3);
                        OWL.Match_Result(WJ, PE, 3, 0, 3);
                        OWL.Match_Result(PF, LAV, 3, 0, 3);
                        OWL.Match_Result(SFS, AR, 3, 1, 3);
                        OWL.Match_Result(AR, FM, 0, 3, 3);
                        OWL.Match_Result(LAV, WJ, 1, 3, 3);
                        OWL.Match_Result(SFS, PF, 3, 1, 3);
                        OWL.Match_Result(WJ, FM, 3, 0, 3);
                        OWL.Match_Result(PF, WJ, 3, 0, 3);

                        OWL.Match_Result(CH, LS, 3, 1, 3);
                        OWL.Match_Result(NYE, CH, 3, 2, 3);
                        OWL.Match_Result(HS, SD, 0, 3, 3);

                        OWL.Match_Result(SHD, NYE, 3, 1, 3);
                        OWL.Match_Result(GC, SD, 0, 3, 3);
                        OWL.Match_Result(NYE, GC, 3, 0, 3);
                        OWL.Match_Result(SHD, SD, 3, 2, 3);
                        OWL.Match_Result(SD, NYE, 3, 0, 3);

                        OWL.Match_Result(SFS, SD, 3, 2, 3);
                        OWL.Match_Result(SHD, PF, 3, 0, 3);
                        OWL.Match_Result(SD, PF, 3, 0, 3);
                        OWL.Match_Result(SFS, SHD, 3, 2, 3);
                        OWL.Match_Result(SHD, SD, 2, 3, 3);
                        OWL.Match_Result(SFS, SD, 4, 2, 3);
                        #endregion
                        #endregion
                        #region Show Results
                        for (int i = 0; i < Teams.GetLength(0); i++)
                        {
                            Teams[i].Final3();
                            Teams[i].Maps_Diff(3);
                            Teams[i].Win_Per(3);
                        }
                        Array.Sort(Teams, new TC3());
                        for (int i = 0; i < Teams.GetLength(0); i++)
                            Teams[i].Show3();
                        #endregion
                        #endregion
                        break;
                    case "4":
                        #region SEASON 4
                        #region WYNIKI
                        Console.WriteLine();
                        Console.WriteLine("SEASON IV STANDINGS 2021");
                        Console.WriteLine();
                        //Season IV
                        Console.WriteLine("     TEAM             :  WIN |  LOSS  | DIFF  |SCORE|WINRATE| GAMES |  SI  |  TI  | S II | T II | SIII | TIII | S IV |  TIV |  PO  | PO T |");
                        AR.S4 = new float[] { (float)12 / 20, (float)12 / 20, (float)4 / 20, (float)3 / 20, (float)3 / 20, (float)4 / 20, (float)2 / 20, (float)3 / 20, (float)5 / 20, (float)2 / 20 };
                        BU.S4 = new float[] { (float)16 / 20, (float)16 / 20, (float)9 / 20, (float)10 / 20, (float)4 / 20, (float)10 / 20, (float)16 / 20, (float)16 / 20, (float)15 / 20, (float)15 / 20 };
                        CH.S4 = new float[] { (float)5 / 20, (float)4 / 20, (float)15 / 20, (float)15 / 20, (float)5 / 20, (float)2 / 20, (float)1 / 20, (float)2 / 20, (float)3 / 20, (float)5 / 20 };
                        DF.S4 = new float[] { (float)10 / 20, (float)1 / 20, (float)6 / 20, (float)2 / 20, (float)2 / 20, (float)3 / 20, (float)9 / 20, (float)10 / 20, (float)2 / 20, (float)3 / 20 };
                        FM.S4 = new float[] { (float)8 / 20, (float)3 / 20, (float)14 / 20, (float)14 / 20, (float)17 / 20, (float)17 / 20, (float)14 / 20, (float)14 / 20, (float)16 / 20, (float)16 / 20 };
                        GC.S4 = new float[] { (float)15 / 20, (float)15 / 20, (float)17 / 20, (float)17 / 20, (float)16 / 20, (float)16 / 20, (float)11 / 20, (float)11 / 20, (float)17 / 20, (float)17 / 20 };
                        HS.S4 = new float[] { (float)13 / 20, (float)13 / 20, (float)1 / 20, (float)5 / 20, (float)14 / 20, (float)14 / 20, (float)19 / 20, (float)19 / 20, (float)13 / 20, (float)13 / 20 };
                        HO.S4 = new float[] { (float)3 / 20, (float)8 / 20, (float)5 / 20, (float)9 / 20, (float)12 / 20, (float)12 / 20, (float)12 / 20, (float)12 / 20, (float)8 / 20, (float)8 / 20 };
                        LS.S4 = new float[] { (float)19 / 20, (float)19 / 20, (float)18 / 20, (float)18 / 20, (float)18 / 20, (float)18 / 20, (float)17 / 20, (float)17 / 20, (float)18 / 20, (float)18 / 20 };
                        LAG.S4 = new float[] { (float)11 / 20, (float)11 / 20, (float)2 / 20, (float)7 / 20, (float)10 / 20, (float)8 / 20, (float)3 / 20, (float)1 / 20, (float)4 / 20, (float)6 / 20 };
                        LAV.S4 = new float[] { (float)20 / 20, (float)20 / 20, (float)19 / 20, (float)19 / 20, (float)20 / 20, (float)20 / 20, (float)20 / 20, (float)20 / 20, (float)20 / 20, (float)20 / 20 };
                        NYE.S4 = new float[] { (float)17 / 20, (float)17 / 20, (float)10 / 20, (float)4 / 20, (float)9 / 20, (float)5 / 20, (float)10 / 20, (float)5 / 20, (float)14 / 20, (float)14 / 20 };
                        PE.S4 = new float[] { (float)14 / 20, (float)14 / 20, (float)12 / 20, (float)12 / 20, (float)7 / 20, (float)9 / 20, (float)8 / 20, (float)9 / 20, (float)12 / 20, (float)12 / 20 };
                        PF.S4 = new float[] { (float)1 / 20, (float)5 / 20, (float)11 / 20, (float)11 / 20, (float)15 / 20, (float)15 / 20, (float)5 / 20, (float)6 / 20, (float)9 / 20, (float)7 / 20 };
                        SFS.S4 = new float[] { (float)6 / 20, (float)10 / 20, (float)3 / 20, (float)8 / 20, (float)11 / 20, (float)11 / 20, (float)4 / 20, (float)8 / 20, (float)6 / 20, (float)4 / 20 };
                        SD.S4 = new float[] { (float)4 / 20, (float)6 / 20, (float)8 / 20, (float)6 / 20, (float)8 / 20, (float)6 / 20, (float)7 / 20, (float)4 / 20, (float)7 / 20, (float)7 / 20 };
                        SHD.S4 = new float[] { (float)7 / 20, (float)2 / 20, (float)7 / 20, (float)1 / 20, (float)1 / 20, (float)1 / 20, (float)13 / 20, (float)13 / 20, (float)1 / 20, (float)1 / 20 };
                        TD.S4 = new float[] { (float)9 / 20, (float)9 / 20, (float)16 / 20, (float)16 / 20, (float)13 / 20, (float)13 / 20, (float)6 / 20, (float)7 / 20, (float)11 / 20, (float)11 / 20 };
                        VT.S4 = new float[] { (float)18 / 20, (float)18 / 20, (float)20 / 20, (float)20 / 20, (float)19 / 20, (float)19 / 20, (float)15 / 20, (float)15 / 20, (float)19 / 20, (float)19 / 20 };
                        WJ.S4 = new float[] { (float)2 / 20, (float)7 / 20, (float)13 / 20, (float)13 / 20, (float)6 / 20, (float)7 / 20, (float)18 / 20, (float)18 / 20, (float)10 / 20, (float)8 / 20 };
                        #endregion
                        #region Season IV Matches
                        #region Stage 1
                        OWL.Match_Result(HO, DF, 3, 2, 4);
                        OWL.Match_Result(LAG, SFS, 1, 3, 4);
                        OWL.Match_Result(GC, SHD, 0, 3, 4);
                        OWL.Match_Result(LAV, CH, 1, 3, 4);
                        OWL.Match_Result(PF, SD, 3, 1, 4);
                        OWL.Match_Result(TD, VT, 3, 1, 4);
                        OWL.Match_Result(AR, FM, 1, 3, 4);
                        OWL.Match_Result(DF, LAG, 3, 1, 4);
                        OWL.Match_Result(GC, SD, 0, 3, 4);
                        OWL.Match_Result(CH, SHD, 3, 0, 4);
                        OWL.Match_Result(PF, LAV, 3, 0, 4);
                        OWL.Match_Result(HO, SFS, 3, 2, 4);
                        OWL.Match_Result(FM, VT, 3, 1, 4);
                        OWL.Match_Result(TD, AR, 3, 2, 4);


                        OWL.Match_Result(PE, VT, 3, 1, 4);
                        OWL.Match_Result(LAG, LS, 3, 0, 4);
                        OWL.Match_Result(CH, NYE, 3, 0, 4);
                        OWL.Match_Result(PF, HS, 3, 1, 4);
                        OWL.Match_Result(HO, PE, 3, 1, 4);
                        OWL.Match_Result(BU, LAG, 0, 3, 4);
                        OWL.Match_Result(WJ, DF, 3, 1, 4);
                        OWL.Match_Result(HS, NYE, 1, 3, 4);
                        OWL.Match_Result(CH, PF, 1, 3, 4);
                        OWL.Match_Result(HO, LS, 3, 0, 4);
                        OWL.Match_Result(BU, DF, 0, 3, 4);
                        OWL.Match_Result(VT, WJ, 1, 3, 4);

                        OWL.Match_Result(PE, AR, 0, 3, 4);
                        OWL.Match_Result(WJ, BU, 3, 1, 4);
                        OWL.Match_Result(LAV, GC, 0, 3, 4);
                        OWL.Match_Result(SD, NYE, 3, 0, 4);
                        OWL.Match_Result(SHD, HS, 3, 2, 4);
                        OWL.Match_Result(BU, LS, 3, 2, 4);
                        OWL.Match_Result(SFS, FM, 3, 0, 4);
                        OWL.Match_Result(TD, WJ, 0, 3, 4);
                        OWL.Match_Result(SD, LAV, 3, 0, 4);
                        OWL.Match_Result(GC, HS, 0, 3, 4);
                        OWL.Match_Result(SHD, NYE, 3, 0, 4);
                        OWL.Match_Result(FM, PE, 3, 1, 4);
                        OWL.Match_Result(LS, TD, 1, 3, 4);
                        OWL.Match_Result(SFS, AR, 3, 2, 4);

                        OWL.Match_Result(TD, FM, 0, 3, 4);
                        OWL.Match_Result(DF, SFS, 3, 0, 4);
                        OWL.Match_Result(WJ, FM, 1, 3, 4);
                        OWL.Match_Result(HO, DF, 0, 3, 4);
                        OWL.Match_Result(SHD, PF, 3, 2, 4);
                        OWL.Match_Result(CH, SD, 3, 1, 4);
                        OWL.Match_Result(SHD, FM, 3, 2, 4);
                        OWL.Match_Result(DF, CH, 3, 1, 4);
                        OWL.Match_Result(FM, CH, 3, 1, 4);
                        OWL.Match_Result(SHD, DF, 2, 3, 4);
                        OWL.Match_Result(SHD, FM, 3, 0, 4);
                        OWL.Match_Result(DF, SHD, 4, 2, 4);

                        #endregion
                        #region Stage 2
                        OWL.Match_Result(PE, TD, 1, 3, 4);
                        OWL.Match_Result(LS, FM, 1, 3, 4);
                        OWL.Match_Result(GC, HS, 1, 3, 4);
                        OWL.Match_Result(SHD, CH, 3, 0, 4);
                        OWL.Match_Result(NYE, PF, 3, 1, 4);
                        OWL.Match_Result(PE, WJ, 3, 0, 4);
                        OWL.Match_Result(HO, AR, 1, 3, 4);
                        OWL.Match_Result(TD, BU, 0, 3, 4);
                        OWL.Match_Result(SHD, HS, 0, 3, 4);
                        OWL.Match_Result(NYE, GC, 1, 3, 4);
                        OWL.Match_Result(PF, CH, 1, 3, 4);
                        OWL.Match_Result(AR, LS, 3, 0, 4);
                        OWL.Match_Result(WJ, BU, 0, 3, 4);
                        OWL.Match_Result(FM, HO, 1, 3, 4);


                        OWL.Match_Result(LS, DF, 0, 3, 4);
                        OWL.Match_Result(LAG, VT, 3, 0, 4);
                        OWL.Match_Result(SHD, LAV, 3, 0, 4);
                        OWL.Match_Result(NYE, SD, 1, 3, 4);
                        OWL.Match_Result(HO, LS, 3, 0, 4);
                        OWL.Match_Result(SFS, TD, 3, 1, 4);
                        OWL.Match_Result(AR, LAG, 1, 3, 4);
                        OWL.Match_Result(NYE, LAV, 3, 0, 4);
                        OWL.Match_Result(SD, SHD, 1, 3, 4);
                        OWL.Match_Result(TD, HO, 1, 3, 4);
                        OWL.Match_Result(VT, AR, 0, 3, 4);
                        OWL.Match_Result(DF, SFS, 1, 3, 4);

                        OWL.Match_Result(BU, PE, 2, 3, 4);
                        OWL.Match_Result(DF, FM, 3, 2, 4);
                        OWL.Match_Result(BU, LAG, 1, 3, 4);
                        OWL.Match_Result(SFS, VT, 3, 0, 4);
                        OWL.Match_Result(FM, WJ, 0, 3, 4);
                        OWL.Match_Result(PE, LAG, 1, 3, 4);
                        OWL.Match_Result(VT, DF, 0, 3, 4);
                        OWL.Match_Result(SFS, WJ, 3, 2, 4);
                        OWL.Match_Result(GC, PF, 0, 3, 4);
                        OWL.Match_Result(CH, SD, 2, 3, 4);
                        OWL.Match_Result(LAV, HS, 0, 0, 4);
                        OWL.Match_Result(LAV, PF, 1, 3, 4);
                        OWL.Match_Result(GC, SD, 0, 3, 4);
                        OWL.Match_Result(CH, HS, 1, 3, 4);

                        OWL.Match_Result(DF, HO, 3, 0, 4);
                        OWL.Match_Result(BU, AR, 0, 3, 4);
                        OWL.Match_Result(LAG, DF, 1, 3, 4);
                        OWL.Match_Result(SFS, AR, 0, 3, 4);
                        OWL.Match_Result(NYE, HS, 3, 1, 4);
                        OWL.Match_Result(SD, SHD, 0, 3, 4);
                        OWL.Match_Result(NYE, AR, 0, 3, 4);
                        OWL.Match_Result(DF, SHD, 3, 0, 4);
                        OWL.Match_Result(NYE, SHD, 0, 3, 4);
                        OWL.Match_Result(AR, DF, 1, 3, 4);
                        OWL.Match_Result(AR, SHD, 0, 3, 4);
                        OWL.Match_Result(DF, SHD, 3, 4, 4);

                        #endregion
                        #region Stage 3
                        OWL.Match_Result(LS, PE, 1, 3, 4);
                        OWL.Match_Result(LAG, SFS, 3, 2, 4);
                        OWL.Match_Result(HS, LAV, 3, 0, 4);
                        OWL.Match_Result(SD, CH, 3, 1, 4);
                        OWL.Match_Result(GC, NYE, 3, 2, 4);
                        OWL.Match_Result(LS, SFS, 2, 3, 4);
                        OWL.Match_Result(FM, TD, 2, 3, 4);
                        OWL.Match_Result(VT, BU, 1, 3, 4);
                        OWL.Match_Result(HS, SD, 0, 3, 4);
                        OWL.Match_Result(CH, GC, 3, 0, 4);
                        OWL.Match_Result(NYE, LAV, 3, 0, 4);
                        OWL.Match_Result(LAG, PE, 2, 3, 4);
                        OWL.Match_Result(BU, FM, 3, 0, 4);
                        OWL.Match_Result(TD, VT, 3, 0, 4);


                        OWL.Match_Result(PE, SFS, 1, 3, 4);
                        OWL.Match_Result(WJ, AR, 0, 3, 4);
                        OWL.Match_Result(PF, GC, 3, 0, 4);
                        OWL.Match_Result(SD, SHD, 0, 3, 4);
                        OWL.Match_Result(PE, VT, 3, 0, 4);
                        OWL.Match_Result(DF, FM, 3, 2, 4);
                        OWL.Match_Result(HO, SFS, 3, 1, 4);
                        OWL.Match_Result(SD, GC, 3, 2, 4);
                        OWL.Match_Result(PF, SHD, 0, 3, 4);
                        OWL.Match_Result(AR, DF, 2, 3, 4);
                        OWL.Match_Result(VT, HO, 0, 3, 4);
                        OWL.Match_Result(WJ, FM, 3, 0, 4);

                        OWL.Match_Result(AR, LS, 3, 0, 4);
                        OWL.Match_Result(BU, HO, 3, 0, 4);
                        OWL.Match_Result(WJ, LS, 3, 0, 4);
                        OWL.Match_Result(LAG, TD, 3, 0, 4);
                        OWL.Match_Result(AR, BU, 3, 0, 4);
                        OWL.Match_Result(TD, DF, 1, 3, 4);
                        OWL.Match_Result(WJ, LAG, 3, 2, 4);
                        OWL.Match_Result(DF, HO, 3, 0, 4);
                        OWL.Match_Result(HS, NYE, 3, 2, 4);
                        OWL.Match_Result(CH, PF, 3, 2, 4);
                        OWL.Match_Result(SHD, LAV, 3, 0, 4);
                        OWL.Match_Result(NYE, PF, 3, 1, 4);
                        OWL.Match_Result(LAV, CH, 0, 3, 4);
                        OWL.Match_Result(HS, SHD, 1, 3, 4);

                        OWL.Match_Result(WJ, PE, 3, 2, 4);
                        OWL.Match_Result(BU, LAG, 0, 3, 4);
                        OWL.Match_Result(WJ, DF, 2, 3, 4);
                        OWL.Match_Result(LAG, AR, 2, 3, 4);
                        OWL.Match_Result(NYE, SHD, 0, 3, 4);
                        OWL.Match_Result(SD, CH, 2, 3, 4);
                        OWL.Match_Result(CH, DF, 3, 1, 4);
                        OWL.Match_Result(AR, SHD, 0, 3, 4);
                        OWL.Match_Result(DF, AR, 3, 2, 4);
                        OWL.Match_Result(CH, SHD, 2, 3, 4);
                        OWL.Match_Result(CH, DF, 3, 0, 4);
                        OWL.Match_Result(SHD, CH, 4, 1, 4);

                        #endregion
                        #region Stage 4
                        OWL.Match_Result(DF, PE, 2, 3, 4);
                        OWL.Match_Result(HO, WJ, 3, 0, 4);
                        OWL.Match_Result(HS, SD, 2, 3, 4);
                        OWL.Match_Result(NYE, LAV, 3, 0, 4);
                        OWL.Match_Result(PF, SHD, 3, 0, 4);
                        OWL.Match_Result(BU, PE, 3, 1, 4);
                        OWL.Match_Result(AR, LAG, 3, 2, 4);
                        OWL.Match_Result(DF, SFS, 3, 2, 4);
                        OWL.Match_Result(SD, LAV, 3, 0, 4);
                        OWL.Match_Result(SHD, NYE, 2, 3, 4);
                        OWL.Match_Result(HS, PF, 1, 3, 4);
                        OWL.Match_Result(AR, HO, 3, 0, 4);
                        OWL.Match_Result(SFS, BU, 3, 1, 4);
                        OWL.Match_Result(LAG, WJ, 3, 0, 4);


                        OWL.Match_Result(LS, PF, 1, 3, 4);
                        OWL.Match_Result(VT, BU, 3, 0, 4);
                        OWL.Match_Result(NYE, PF, 1, 3, 4);
                        OWL.Match_Result(SD, SHD, 2, 3, 4);
                        OWL.Match_Result(CH, GC, 3, 1, 4);
                        OWL.Match_Result(DF, LS, 3, 1, 4);
                        OWL.Match_Result(FM, AR, 2, 3, 4);
                        OWL.Match_Result(TD, WJ, 3, 0, 4);
                        OWL.Match_Result(PF, SD, 2, 3, 4);
                        OWL.Match_Result(CH, NYE, 3, 1, 4);
                        OWL.Match_Result(SHD, GC, 3, 1, 4);
                        OWL.Match_Result(BU, FM, 1, 3, 4);
                        OWL.Match_Result(AR, DF, 3, 1, 4);
                        OWL.Match_Result(VT, WJ, 0, 3, 4);

                        OWL.Match_Result(PE, TD, 2, 3, 4);
                        OWL.Match_Result(FM, HO, 1, 3, 4);
                        OWL.Match_Result(HS, CH, 1, 3, 4);
                        OWL.Match_Result(LAV, GC, 0, 3, 4);
                        OWL.Match_Result(LS, PE, 0, 3, 4);
                        OWL.Match_Result(SFS, VT, 3, 0, 4);
                        OWL.Match_Result(FM, LAG, 1, 3, 4);
                        OWL.Match_Result(LAV, CH, 0, 3, 4);
                        OWL.Match_Result(GC, HS, 3, 2, 4);
                        OWL.Match_Result(LS, VT, 3, 2, 4);
                        OWL.Match_Result(LAG, HO, 3, 0, 4);
                        OWL.Match_Result(SFS, TD, 3, 1, 4);


                        OWL.Match_Result(TD, PE, 3, 2, 4);
                        OWL.Match_Result(SFS, DF, 3, 0, 4);
                        OWL.Match_Result(AR, TD, 3, 1, 4);
                        OWL.Match_Result(LAG, SFS, 3, 2, 4);
                        OWL.Match_Result(NYE, CH, 1, 3, 4);
                        OWL.Match_Result(SD, PF, 3, 1, 4);
                        OWL.Match_Result(SD, AR, 1, 3, 4);
                        OWL.Match_Result(LAG, CH, 3, 2, 4);
                        OWL.Match_Result(SD, CH, 0, 3, 4);
                        OWL.Match_Result(AR, LAG, 0, 3, 4);
                        OWL.Match_Result(AR, CH, 0, 3, 4);
                        OWL.Match_Result(LAG, CH, 4, 3, 4);
                        #endregion
                        #region PlayOffs
                        OWL.Match_Result(PE, WJ, 0, 3, 4);
                        OWL.Match_Result(BU, TD, 0, 3, 4);
                        OWL.Match_Result(SFS, TD, 3, 0, 4);
                        OWL.Match_Result(HO, WJ, 2, 3, 4);
                        OWL.Match_Result(PF, HS, 3, 1, 4);
                        OWL.Match_Result(SD, PF, 1, 3, 4);

                        OWL.Match_Result(SFS, SHD, 0, 3, 4);
                        OWL.Match_Result(LAG, PF, 3, 1, 4);
                        OWL.Match_Result(DF, WJ, 3, 1, 4);
                        OWL.Match_Result(CH, AR, 3, 2, 4);
                        OWL.Match_Result(SFS, PF, 3, 2, 4);
                        OWL.Match_Result(WJ, AR, 0, 3, 4);
                        OWL.Match_Result(SHD, LAG, 3, 1, 4);
                        OWL.Match_Result(DF, CH, 3, 0, 4);
                        OWL.Match_Result(CH, SFS, 2, 3, 4);
                        OWL.Match_Result(LAG, AR, 2, 3, 4);
                        OWL.Match_Result(SFS, AR, 1, 3, 4);
                        OWL.Match_Result(SHD, DF, 3, 1, 4);
                        OWL.Match_Result(DF, AR, 1, 3, 4);
                        OWL.Match_Result(SHD, AR, 4, 0, 4);
                        #endregion
                        #endregion

                        #region Show Results
                        for (int i = 0; i < Teams.GetLength(0); i++)
                        {
                            Teams[i].Final4();
                            Teams[i].Maps_Diff(4);
                            Teams[i].Win_Per(4);
                        }
                        Array.Sort(Teams, new TC4());
                        for (int i = 0; i < Teams.GetLength(0); i++)
                            Teams[i].Show4();
                        #endregion
                        #endregion
                        break;
                    case "5":
                        #region SEASON 5
                        #region Wyniki
                        Console.WriteLine();
                        Console.WriteLine("SEASON V STANDINGS 2022");
                        Console.WriteLine();
                        //Season V
                        Console.WriteLine("     TEAM             :   WIN |  LOSS  | DIFF  |SCORE|WINRATE| GAMES |  SI  |  TI  | S II | T II | SIII | TIII | S IV |  PO  | PO T |");
                        AR.S5 = new float[] { (float)11 / 20, (float)3 / 13, (float)9 / 20, (float)3 / 20, (float)13 / 20, (float)10 / 13, (float)4 / 13, (float)8 / 20, (float)10 / 20 };
                        BU.S5 = new float[] { (float)15 / 20, (float)10 / 13, (float)15 / 20, (float)15 / 20, (float)16 / 20, (float)11 / 13, (float)3 / 13, (float)14 / 20, (float)14 / 20 };
                        CH.S5 = new float[] { (float)14 / 20, (float)5 / 7, (float)14 / 20, (float)14 / 20, (float)15 / 20, (float)5 / 7, (float)6 / 7, (float)16 / 20, (float)16 / 20 };
                        DF.S5 = new float[] { (float)2 / 20, (float)2 / 13, (float)5 / 20, (float)11 / 20, (float)2 / 20, (float)1 / 13, (float)2 / 13, (float)2 / 20, (float)1 / 20 };
                        FM.S5 = new float[] { (float)6 / 20, (float)5 / 13, (float)10 / 20, (float)8 / 20, (float)11 / 20, (float)4 / 13, (float)6 / 13, (float)9 / 20, (float)7 / 20 };
                        GC.S5 = new float[] { (float)18 / 20, (float)7 / 7, (float)19 / 20, (float)19 / 20, (float)7 / 20, (float)4 / 7, (float)2 / 7, (float)15 / 20, (float)15 / 20 };
                        HS.S5 = new float[] { (float)3 / 20, (float)4 / 7, (float)4 / 20, (float)6 / 20, (float)19 / 20, (float)7 / 7, (float)7 / 7, (float)12 / 20, (float)4 / 20 };
                        HO.S5 = new float[] { (float)8 / 20, (float)6 / 13, (float)6 / 20, (float)7 / 20, (float)5 / 20, (float)5 / 13, (float)5 / 13, (float)6 / 20, (float)3 / 20 };
                        LS.S5 = new float[] { (float)13 / 20, (float)9 / 13, (float)8 / 20, (float)12 / 20, (float)8 / 20, (float)6 / 13, (float)6 / 13, (float)7 / 20, (float)6 / 20 };
                        LAG.S5 = new float[] { (float)5 / 20, (float)1 / 13, (float)2 / 20, (float)1 / 20, (float)12 / 20, (float)9 / 13, (float)1 / 13, (float)3 / 20, (float)8 / 20 };
                        LAV.S5 = new float[] { (float)16 / 20, (float)6 / 7, (float)16 / 20, (float)16 / 20, (float)18 / 20, (float)6 / 7, (float)5 / 7, (float)17 / 20, (float)17 / 20 };
                        NYE.S5 = new float[] { (float)17 / 20, (float)11 / 13, (float)17 / 20, (float)17 / 20, (float)17 / 20, (float)12 / 13, (float)12 / 13, (float)19 / 20, (float)19 / 20 };
                        PE.S5 = new float[] { (float)19 / 20, (float)12 / 13, (float)18 / 20, (float)18 / 20, (float)20 / 20, (float)13 / 13, (float)13 / 13, (float)20 / 20, (float)20 / 20 };
                        PF.S5 = new float[] { (float)10 / 20, (float)2 / 7, (float)11 / 20, (float)4 / 20, (float)14 / 20, (float)3 / 7, (float)3 / 7, (float)11 / 20, (float)12 / 20 };
                        SFS.S5 = new float[] { (float)1 / 20, (float)4 / 13, (float)1 / 20, (float)2 / 20, (float)4 / 20, (float)2 / 13, (float)6 / 13, (float)1 / 20, (float)2 / 20 };
                        SD.S5 = new float[] { (float)7 / 20, (float)1 / 7, (float)3 / 20, (float)9 / 20, (float)3 / 20, (float)2 / 7, (float)1 / 7, (float)4 / 20, (float)5 / 20 };
                        SHD.S5 = new float[] { (float)4 / 20, (float)3 / 7, (float)7 / 20, (float)5 / 20, (float)1 / 20, (float)1 / 7, (float)4 / 7, (float)5 / 20, (float)11 / 20 };
                        TD.S5 = new float[] { (float)9 / 20, (float)8 / 13, (float)12 / 20, (float)10 / 20, (float)6 / 20, (float)3 / 13, (float)10 / 13, (float)10 / 20, (float)9 / 20 };
                        VT.S5 = new float[] { (float)20 / 20, (float)13 / 13, (float)20 / 20, (float)20 / 20, (float)9 / 20, (float)8 / 13, (float)11 / 13, (float)18 / 20, (float)18 / 20 };
                        WJ.S5 = new float[] { (float)12 / 20, (float)7 / 13, (float)13 / 20, (float)13 / 20, (float)10 / 20, (float)7 / 13, (float)19 / 13, (float)13 / 20, (float)13 / 20 };
                        #endregion
                        #region SEASON V matches
                        #region Stage 1
                        OWL.Match_Result(NYE, LAG, 1, 3, 5);
                        OWL.Match_Result(SFS, PE, 3, 0, 5);
                        OWL.Match_Result(FM, AR, 1, 3, 5);
                        OWL.Match_Result(LS, SFS, 0, 3, 5);
                        OWL.Match_Result(BU, VT, 3, 2, 5);
                        OWL.Match_Result(TD, WJ, 1, 3, 5);
                        OWL.Match_Result(AR, NYE, 3, 0, 5);
                        OWL.Match_Result(BU, LAG, 1, 3, 5);
                        OWL.Match_Result(LS, VT, 3, 0, 5);
                        OWL.Match_Result(PE, FM, 1, 3, 5);
                        OWL.Match_Result(WJ, DF, 0, 3, 5);
                        OWL.Match_Result(TD, HO, 3, 2, 5);
                        OWL.Match_Result(DF, HO, 0, 3, 5);

                        OWL.Match_Result(FM, VT, 3, 0, 5);
                        OWL.Match_Result(SFS, HO, 3, 1, 5);
                        OWL.Match_Result(AR, WJ, 0, 3, 5);
                        OWL.Match_Result(LS, BU, 3, 1, 5);
                        OWL.Match_Result(DF, LAG, 3, 2, 5);
                        OWL.Match_Result(VT, NYE, 1, 3, 5);
                        OWL.Match_Result(HO, FM, 3, 2, 5);
                        OWL.Match_Result(SFS, NYE, 3, 1, 5);
                        OWL.Match_Result(PE, TD, 0, 3, 5);

                        OWL.Match_Result(PF, SHD, 3, 0, 5);
                        OWL.Match_Result(GC, LAV, 3, 1, 5);
                        OWL.Match_Result(SD, HS, 1, 3, 5);
                        OWL.Match_Result(WJ, PE, 3, 1, 5);
                        OWL.Match_Result(NYE, FM, 0, 3, 5);
                        OWL.Match_Result(DF, TD, 3, 0, 5);
                        OWL.Match_Result(GC, CH, 0, 3, 5);
                        OWL.Match_Result(HS, SHD, 2, 3, 5);
                        OWL.Match_Result(SD, LAV, 3, 0, 5);
                        OWL.Match_Result(LAV, SD, 2, 3, 5);
                        OWL.Match_Result(HO, LS, 3, 0, 5);
                        OWL.Match_Result(LAG, SFS, 2, 3, 5);
                        OWL.Match_Result(TD, BU, 3, 1, 5);
                        OWL.Match_Result(GC, PF, 0, 3, 5);
                        OWL.Match_Result(CH, SD, 0, 3, 5);
                        OWL.Match_Result(HS, LAV, 3, 2, 5);
                        OWL.Match_Result(VT, AR, 0, 3, 5);
                        OWL.Match_Result(DF, PE, 3, 0, 5);
                        OWL.Match_Result(WJ, BU, 1, 3, 5);

                        OWL.Match_Result(PF, SD, 0, 3, 5);
                        OWL.Match_Result(CH, HS, 1, 3, 5);
                        OWL.Match_Result(SHD, GC, 3, 2, 5);
                        OWL.Match_Result(CH, PF, 3, 1, 5);
                        OWL.Match_Result(GC, SD, 0, 3, 5);
                        OWL.Match_Result(SHD, LAV, 3, 2, 5);
                        OWL.Match_Result(LAG, LS, 3, 1, 5);
                        OWL.Match_Result(NYE, TD, 1, 3, 5);
                        OWL.Match_Result(VT, SFS, 1, 3, 5);
                        OWL.Match_Result(HS, GC, 3, 0, 5);
                        OWL.Match_Result(SHD, CH, 3, 1, 5);
                        OWL.Match_Result(LAV, PF, 1, 3, 5);
                        OWL.Match_Result(AR, LS, 2, 3, 5);
                        OWL.Match_Result(PE, HO, 2, 3, 5);
                        OWL.Match_Result(FM, WJ, 3, 1, 5);
                        OWL.Match_Result(SD, SHD, 1, 3, 5);
                        OWL.Match_Result(CH, LAV, 1, 3, 5);
                        OWL.Match_Result(PF, HS, 2, 3, 5);
                        OWL.Match_Result(DF, BU, 3, 0, 5);
                        OWL.Match_Result(LAG, AR, 3, 0, 5);


                        OWL.Match_Result(SFS, WJ, 3, 2, 5);
                        OWL.Match_Result(FM, AR, 1, 3, 5);
                        OWL.Match_Result(DF, TD, 3, 0, 5);
                        OWL.Match_Result(LAG, HO, 3, 0, 5);
                        OWL.Match_Result(WJ, FM, 1, 3, 5);
                        OWL.Match_Result(TD, HO, 1, 3, 5);
                        OWL.Match_Result(SFS, AR, 1, 3, 5);
                        OWL.Match_Result(DF, LAG, 1, 3, 5);
                        OWL.Match_Result(DF, FM, 3, 1, 5);
                        OWL.Match_Result(SFS, HO, 3, 1, 5);
                        OWL.Match_Result(DF, SFS, 3, 0, 5);
                        OWL.Match_Result(AR, LAG, 0, 3, 5);
                        OWL.Match_Result(AR, DF, 1, 3, 5);
                        OWL.Match_Result(LAG, DF, 4, 0, 5);
                        OWL.Match_Result(HS, PF, 1, 3, 5);
                        OWL.Match_Result(SHD, SD, 3, 2, 5);
                        OWL.Match_Result(HS, SD, 0, 3, 5);
                        OWL.Match_Result(PF, SHD, 3, 0, 5);
                        OWL.Match_Result(SHD, SD, 2, 3, 5);
                        OWL.Match_Result(PF, SD, 0, 4, 5);
                        #endregion
                        #region Stage 2
                        OWL.Match_Result(FM, LS, 2, 3, 5);
                        OWL.Match_Result(DF, SFS, 0, 3, 5);
                        OWL.Match_Result(NYE, WJ, 1, 3, 5);
                        OWL.Match_Result(TD, LS, 1, 3, 5);
                        OWL.Match_Result(AR, BU, 3, 2, 5);
                        OWL.Match_Result(VT, LAG, 0, 3, 5);
                        OWL.Match_Result(HO, WJ, 3, 2, 5);
                        OWL.Match_Result(PE, LAG, 1, 3, 5);
                        OWL.Match_Result(DF, AR, 0, 3, 5);
                        OWL.Match_Result(TD, FM, 1, 3, 5);
                        OWL.Match_Result(BU, SFS, 0, 3, 5);
                        OWL.Match_Result(NYE, PE, 2, 3, 5);
                        OWL.Match_Result(VT, HO, 0, 3, 5);

                        OWL.Match_Result(PF, LAV, 2, 3, 5);
                        OWL.Match_Result(CH, SD, 2, 3, 5);
                        OWL.Match_Result(LS, NYE, 3, 0, 5);
                        OWL.Match_Result(FM, DF, 0, 3, 5);
                        OWL.Match_Result(AR, VT, 3, 1, 5);
                        OWL.Match_Result(GC, HS, 0, 3, 5);
                        OWL.Match_Result(SHD, SD, 0, 3, 5);
                        OWL.Match_Result(PF, CH, 1, 3, 5);
                        OWL.Match_Result(WJ, TD, 1, 3, 5);
                        OWL.Match_Result(AR, SFS, 1, 3, 5);
                        OWL.Match_Result(VT, DF, 0, 3, 5);
                        OWL.Match_Result(GC, LAV, 1, 3, 5);
                        OWL.Match_Result(SHD, HS, 0, 3, 5);
                        OWL.Match_Result(SFS, FM, 3, 1, 5);
                        OWL.Match_Result(HO, LAG, 0, 3, 5);
                        OWL.Match_Result(PE, BU, 0, 3, 5);

                        OWL.Match_Result(HS, PF, 2, 3, 5);
                        OWL.Match_Result(CH, GC, 3, 1, 5);
                        OWL.Match_Result(LS, PE, 3, 0, 5);
                        OWL.Match_Result(HO, AR, 3, 2, 5);
                        OWL.Match_Result(LAG, TD, 3, 1, 5);
                        OWL.Match_Result(SD, GC, 3, 0, 5);
                        OWL.Match_Result(LAV, CH, 0, 3, 5);
                        OWL.Match_Result(PF, SHD, 0, 3, 5);
                        OWL.Match_Result(SFS, VT, 3, 0, 5);
                        OWL.Match_Result(LAG, WJ, 3, 1, 5);
                        OWL.Match_Result(TD, PE, 3, 2, 5);
                        OWL.Match_Result(HS, SD, 0, 3, 5);
                        OWL.Match_Result(LAV, SHD, 0, 3, 5);
                        OWL.Match_Result(WJ, LS, 2, 3, 5);
                        OWL.Match_Result(DF, NYE, 3, 2, 5);
                        OWL.Match_Result(BU, FM, 2, 3, 5);

                        OWL.Match_Result(PF, GC, 3, 1, 5);
                        OWL.Match_Result(CH, SHD, 1, 3, 5);
                        OWL.Match_Result(NYE, HO, 2, 3, 5);
                        OWL.Match_Result(SFS, TD, 3, 1, 5);
                        OWL.Match_Result(PE, AR, 0, 3, 5);
                        OWL.Match_Result(SD, LAV, 3, 0, 5);
                        OWL.Match_Result(HS, CH, 3, 0, 5);
                        OWL.Match_Result(GC, SHD, 0, 3, 5);
                        OWL.Match_Result(WJ, VT, 3, 2, 5);
                        OWL.Match_Result(BU, HO, 2, 3, 5);
                        OWL.Match_Result(LAG, FM, 3, 0, 5);
                        OWL.Match_Result(SD, PF, 1, 3, 5);
                        OWL.Match_Result(LAV, HS, 1, 3, 5);
                        OWL.Match_Result(LS, DF, 1, 3, 5);
                        OWL.Match_Result(BU, NYE, 3, 1, 5);

                        OWL.Match_Result(LS, AR, 1, 3, 5);
                        OWL.Match_Result(SHD, TD, 3, 0, 5);
                        OWL.Match_Result(HS, PF, 3, 1, 5);
                        OWL.Match_Result(HO, FM, 3, 0, 5);
                        OWL.Match_Result(SD, AR, 2, 3, 5);
                        OWL.Match_Result(HO, TD, 3, 2, 5);
                        OWL.Match_Result(DF, PF, 1, 3, 5);
                        OWL.Match_Result(LS, FM, 2, 3, 5);
                        OWL.Match_Result(SFS, LS, 3, 1, 5);
                        OWL.Match_Result(DF, SHD, 0, 3, 5);
                        OWL.Match_Result(LAG, HO, 3, 0, 5);
                        OWL.Match_Result(SD, HS, 0, 3, 5);
                        OWL.Match_Result(AR, HO, 3, 1, 5);
                        OWL.Match_Result(PF, FM, 3, 2, 5);
                        OWL.Match_Result(SFS, SHD, 3, 0, 5);
                        OWL.Match_Result(LAG, HS, 3, 2, 5);
                        OWL.Match_Result(SHD, AR, 1, 3, 5);
                        OWL.Match_Result(HS, PF, 2, 3, 5);
                        OWL.Match_Result(AR, PF, 3, 1, 5);
                        OWL.Match_Result(SFS, LAG, 3, 2, 5);
                        OWL.Match_Result(LAG, AR, 3, 1, 5);
                        OWL.Match_Result(SFS, LAG, 2, 4, 5);
                        #endregion
                        #region Stage 3
                        OWL.Match_Result(FM, LS, 3, 1, 5);
                        OWL.Match_Result(HO, NYE, 2, 3, 5);
                        OWL.Match_Result(LAG, DF, 2, 3, 5);
                        OWL.Match_Result(BU, AR, 3, 1, 5);
                        OWL.Match_Result(WJ, SFS, 2, 3, 5);
                        OWL.Match_Result(VT, TD, 2, 3, 5);
                        OWL.Match_Result(BU, LS, 0, 3, 5);
                        OWL.Match_Result(PE, WJ, 0, 3, 5);
                        OWL.Match_Result(LAG, HO, 2, 3, 5);
                        OWL.Match_Result(VT, PE, 3, 0, 5);
                        OWL.Match_Result(FM, SFS, 0, 3, 5);
                        OWL.Match_Result(NYE, DF, 1, 3, 5);
                        OWL.Match_Result(TD, AR, 3, 1, 5);

                        OWL.Match_Result(SHD, GC, 3, 0, 5);
                        OWL.Match_Result(HS, SD, 0, 3, 5);
                        OWL.Match_Result(VT, NYE, 3, 0, 5);
                        OWL.Match_Result(SFS, BU, 3, 0, 5);
                        OWL.Match_Result(TD, DF, 1, 3, 5);
                        OWL.Match_Result(SD, CH, 3, 0, 5);
                        OWL.Match_Result(SHD, HS, 3, 0, 5);
                        OWL.Match_Result(LAV, PF, 2, 3, 5);
                        OWL.Match_Result(LS, HO, 3, 0, 5);
                        OWL.Match_Result(LAG, SFS, 1, 3, 5);
                        OWL.Match_Result(WJ, FM, 3, 0, 5);
                        OWL.Match_Result(LAV, GC, 2, 3, 5);
                        OWL.Match_Result(CH, PF, 3, 0, 5);
                        OWL.Match_Result(DF, BU, 3, 1, 5);
                        OWL.Match_Result(AR, PE, 3, 0, 5);
                        OWL.Match_Result(TD, LAG, 3, 1, 5);

                        OWL.Match_Result(CH, HS, 3, 1, 5);
                        OWL.Match_Result(LAV, SD, 0, 3, 5);
                        OWL.Match_Result(LS, AR, 1, 3, 5);
                        OWL.Match_Result(NYE, SFS, 0, 3, 5);
                        OWL.Match_Result(VT, WJ, 3, 2, 5);
                        OWL.Match_Result(SD, GC, 3, 0, 5);
                        OWL.Match_Result(LAV, HS, 1, 3, 5);
                        OWL.Match_Result(PF, SHD, 0, 3, 5);
                        OWL.Match_Result(BU, TD, 0, 3, 5);
                        OWL.Match_Result(LAG, PE, 3, 0, 5);
                        OWL.Match_Result(HO, VT, 3, 0, 5);
                        OWL.Match_Result(GC, PF, 3, 2, 5);
                        OWL.Match_Result(CH, SHD, 0, 3, 5);
                        OWL.Match_Result(WJ, LS, 3, 2, 5);
                        OWL.Match_Result(AR, HO, 2, 3, 5);
                        OWL.Match_Result(DF, FM, 3, 1, 5);

                        OWL.Match_Result(CH, GC, 0, 3, 5);
                        OWL.Match_Result(LAV, SHD, 0, 3, 5);
                        OWL.Match_Result(AR, LAG, 0, 3, 5);
                        OWL.Match_Result(PE, NYE, 1, 3, 5);
                        OWL.Match_Result(SFS, DF, 1, 3, 5);
                        OWL.Match_Result(HS, GC, 1, 3, 5);
                        OWL.Match_Result(CH, LAV, 2, 3, 5);
                        OWL.Match_Result(PF, SD, 2, 3, 5);
                        OWL.Match_Result(FM, PE, 3, 0, 5);
                        OWL.Match_Result(WJ, HO, 0, 3, 5);
                        OWL.Match_Result(VT, BU, 2, 3, 5);
                        OWL.Match_Result(PF, HS, 3, 1, 5);
                        OWL.Match_Result(SD, SHD, 0, 3, 5);
                        OWL.Match_Result(LS, TD, 3, 1, 5);
                        OWL.Match_Result(FM, NYE, 3, 0, 5);

                        OWL.Match_Result(SHD, GC, 3, 0, 5);
                        OWL.Match_Result(SD, PF, 3, 2, 5);
                        OWL.Match_Result(GC, PF, 0, 3, 5);
                        OWL.Match_Result(SHD, SD, 3, 0, 5);
                        OWL.Match_Result(SD, PF, 3, 1, 5);
                        OWL.Match_Result(SHD, SD, 4, 2, 5);
                        OWL.Match_Result(DF, WJ, 3, 2, 5);
                        OWL.Match_Result(TD, LS, 1, 3, 5);
                        OWL.Match_Result(SFS, VT, 3, 1, 5);
                        OWL.Match_Result(HO, FM, 3, 0, 5);
                        OWL.Match_Result(WJ, TD, 1, 3, 5);
                        OWL.Match_Result(VT, FM, 0, 3, 5);
                        OWL.Match_Result(DF, LS, 3, 1, 5);
                        OWL.Match_Result(SFS, HO, 3, 1, 5);
                        OWL.Match_Result(HO, TD, 0, 3, 5);
                        OWL.Match_Result(LS, FM, 2, 3, 5);
                        OWL.Match_Result(TD, FM, 3, 2, 5);
                        OWL.Match_Result(DF, SFS, 3, 0, 5);
                        OWL.Match_Result(SFS, TD, 3, 1, 5);
                        OWL.Match_Result(DF, SFS, 4, 0, 5);

                        #endregion
                        #region Stage 4
                        OWL.Match_Result(HO, BU, 1, 3, 5);
                        OWL.Match_Result(DF, WJ, 3, 1, 5);
                        OWL.Match_Result(AR, TD, 3, 2, 5);
                        OWL.Match_Result(HS, CH, 1, 3, 5);
                        OWL.Match_Result(SD, LAV, 3, 0, 5);
                        OWL.Match_Result(PE, LS, 1, 3, 5);
                        OWL.Match_Result(FM, LAG, 1, 3, 5);
                        OWL.Match_Result(TD, NYE, 2, 3, 5);
                        OWL.Match_Result(SHD, SD, 0, 3, 5);
                        OWL.Match_Result(CH, GC, 3, 2, 5);
                        OWL.Match_Result(PF, LAV, 2, 3, 5);
                        OWL.Match_Result(VT, LS, 1, 3, 5);
                        OWL.Match_Result(SFS, WJ, 2, 3, 5);
                        OWL.Match_Result(FM, BU, 0, 3, 5);
                        OWL.Match_Result(GC, SHD, 3, 2, 5);
                        OWL.Match_Result(HS, PF, 1, 3, 5);
                        OWL.Match_Result(NYE, AR, 0, 3, 5);
                        OWL.Match_Result(PE, DF, 0, 3, 5);
                        OWL.Match_Result(HO, SFS, 3, 1, 5);
                        OWL.Match_Result(LAG, VT, 3, 0, 5);

                        OWL.Match_Result(CH, SD, 1, 3, 5);
                        OWL.Match_Result(SHD, PF, 1, 3, 5);
                        OWL.Match_Result(LS, LAG, 0, 3, 5);
                        OWL.Match_Result(DF, VT, 3, 0, 5);
                        OWL.Match_Result(TD, SFS, 3, 1, 5);
                        OWL.Match_Result(SHD, HS, 3, 2, 5);
                        OWL.Match_Result(LAV, CH, 3, 2, 5);
                        OWL.Match_Result(SD, GC, 3, 0, 5);
                        OWL.Match_Result(DF, LS, 3, 0, 5);
                        OWL.Match_Result(WJ, NYE, 3, 1, 5);
                        OWL.Match_Result(SFS, AR, 3, 2, 5);
                        OWL.Match_Result(PF, GC, 2, 3, 5);
                        OWL.Match_Result(LAV, HS, 3, 2, 5);
                        OWL.Match_Result(LAG, NYE, 3, 2, 5);
                        OWL.Match_Result(WJ, AR, 0, 3, 5);
                        OWL.Match_Result(TD, VT, 1, 3, 5);

                        OWL.Match_Result(HS, SD, 3, 2, 5);
                        OWL.Match_Result(GC, LAV, 3, 1, 5);
                        OWL.Match_Result(HO, PE, 3, 0, 5);
                        OWL.Match_Result(BU, WJ, 2, 3, 5);
                        OWL.Match_Result(VT, FM, 2, 3, 5);
                        OWL.Match_Result(GC, HS, 3, 0, 5);
                        OWL.Match_Result(LAV, SHD, 0, 3, 5);
                        OWL.Match_Result(PF, CH, 3, 1, 5);
                        OWL.Match_Result(AR, FM, 3, 2, 5);
                        OWL.Match_Result(WJ, LAG, 1, 3, 5);
                        OWL.Match_Result(CH, SHD, 0, 3, 5);
                        OWL.Match_Result(PE, VT, 2, 3, 5);
                        OWL.Match_Result(AR, DF, 1, 3, 5);
                        OWL.Match_Result(LAG, BU, 3, 1, 5);
                        OWL.Match_Result(HO, DF, 3, 1, 5);
                        OWL.Match_Result(SD, PF, 3, 2, 5);

                        OWL.Match_Result(NYE, LS, 0, 3, 5);
                        OWL.Match_Result(PE, SFS, 0, 3, 5);
                        OWL.Match_Result(FM, TD, 3, 0, 5);
                        OWL.Match_Result(SFS, LS, 3, 2, 5);
                        OWL.Match_Result(NYE, BU, 1, 3, 5);
                        OWL.Match_Result(FM, HO, 3, 1, 5);
                        OWL.Match_Result(BU, PE, 3, 1, 5);
                        OWL.Match_Result(HO, TD, 1, 3, 5);

                        OWL.Match_Result(FM, BU, 3, 0, 5);
                        OWL.Match_Result(TD, WJ, 3, 0, 5);
                        OWL.Match_Result(BU, WJ, 3, 0, 5);
                        OWL.Match_Result(FM, TD, 3, 1, 5);
                        OWL.Match_Result(TD, BU, 3, 0, 5);
                        OWL.Match_Result(GC, CH, 2, 3, 5);
                        OWL.Match_Result(HS, CH, 3, 0, 5);

                        #endregion
                        #region Playoffs
                        OWL.Match_Result(PF, LS, 0, 3, 5);
                        OWL.Match_Result(HS, SHD, 3, 0, 5);
                        OWL.Match_Result(FM, AR, 3, 0, 5);
                        OWL.Match_Result(TD, HO, 0, 3, 5);
                        OWL.Match_Result(HS, DF, 1, 3, 5);
                        OWL.Match_Result(FM, SD, 0, 3, 5);
                        OWL.Match_Result(HO, SFS, 3, 2, 5);
                        OWL.Match_Result(LS, LAG, 3, 1, 5);
                        OWL.Match_Result(PF, LAG, 1, 3, 5);
                        OWL.Match_Result(SHD, SFS, 1, 3, 5);
                        OWL.Match_Result(AR, FM, 1, 3, 5);
                        OWL.Match_Result(TD, HS, 2, 3, 5);
                        OWL.Match_Result(HS, FM, 3, 1, 5);
                        OWL.Match_Result(SHD, SFS, 1, 3, 5);
                        OWL.Match_Result(SD, DF, 0, 3, 5);
                        OWL.Match_Result(LS, HO, 0, 3, 5);
                        OWL.Match_Result(SD, SFS, 0, 3, 5);
                        OWL.Match_Result(LS, HS, 1, 3, 5);
                        OWL.Match_Result(SFS, HS, 3, 1, 5);
                        OWL.Match_Result(HO, DF, 1, 3, 5);
                        OWL.Match_Result(SFS, HO, 3, 0, 5);
                        OWL.Match_Result(SFS, DF, 3, 4, 5);
                        #endregion
                        #endregion
                        #region SHOW RESULTS
                        for (int i = 0; i < Teams.GetLength(0); i++)
                        {
                            Teams[i].Final5();
                            Teams[i].Maps_Diff(5);
                            Teams[i].Win_Per(5);
                        }
                        Array.Sort(Teams, new TC5());
                        for (int i = 0; i < Teams.GetLength(0); i++)
                            Teams[i].Show5();
                        #endregion
                        #endregion
                        break;
                    case "6":
                        #region Final
                        for (int i = 0; i < Teams.GetLength(0); i++)
                            Teams[i].Add_F();

                        Console.WriteLine();
                        Console.WriteLine();
                        Array.Sort(Teams, new TeamCompare());
                        Console.WriteLine("     TEAM             :Maps Won|Maps Lost|Maps Diff|SCORE|Matches|Winrate|Final");
                        for (int i = 0; i < Teams.GetLength(0); i++)
                        {
                            Teams[i].Maps_Diff(0);
                            Teams[i].Win_Per(0);
                            Teams[i].Matches();
                            Teams[i].Show_Final();
                        }
                        #endregion
                        break;
                    case "0":
                        break;
                }
            } while (choice != "0");
        }
    }
}
