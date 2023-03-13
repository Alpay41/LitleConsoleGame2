namespace LitleConsolGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Değişkenler
            Random rnd = new Random();
            string sen = " ☻ ", zemin = " * ", yem = " ♦ ";
            int senSutun = 1, toplamSutun = 10, senSatir = 1, toplamSatir = 10, puan= 0;
            int yemSatir = rnd.Next(1, toplamSatir + 1), yemSutun = rnd.Next(1, toplamSutun + 1);
            #endregion
            while (true)
            {
                Console.Clear();
                for (int satir = 1; satir <= toplamSatir; satir++)
                {
                    for (int sutun = 1; sutun <= toplamSutun; sutun++)
                    {
                        bool senMi = (satir == senSatir && sutun == senSutun);
                        bool yemKonum = (satir == yemSatir && sutun == yemSutun);
                       
                        if (senMi) Console.Write(sen);
                        else if (yemKonum) Console.Write(yem);
                        else Console.Write(zemin);
                    }
                    Console.WriteLine();
                }
                    Console.WriteLine(" Puan :" + puan);
                    Console.WriteLine(" Yemi \" ♦ \" yemek için 5 e basınız");

                ConsoleKey basilanTus = Console.ReadKey().Key;
                if (senSatir == yemSatir && senSutun == yemSutun && basilanTus == ConsoleKey.NumPad5)
                {
                    yemSatir = rnd.Next(1, toplamSatir + 1);
                    yemSutun = rnd.Next(1, toplamSutun + 1);
                    puan++;
                }
                if ((puan == 2) && (yemSatir > senSatir)) yemSatir--;
                if ((puan == 2) && (yemSatir < senSatir)) yemSatir++;

                if ((puan == 2) && (yemSutun > senSutun)) yemSutun--;
                if ((puan == 2) && (yemSutun < senSutun)) yemSutun++;
                
                if ((puan == 2) || (yemSatir == senSatir) || (yemSutun > senSutun)) Console.WriteLine("GameOver");

                if (basilanTus == ConsoleKey.NumPad1 && senSatir != toplamSatir && senSutun != 1) { senSatir++; senSutun--; }
                if (basilanTus == ConsoleKey.NumPad2 || basilanTus == ConsoleKey.DownArrow && senSatir != toplamSatir) senSatir++;
                if (basilanTus == ConsoleKey.NumPad3 && senSatir != toplamSatir && senSutun != toplamSutun) { senSatir++; senSutun++; }
                if (basilanTus == ConsoleKey.NumPad4 || basilanTus == ConsoleKey.LeftArrow && senSutun != 1) senSutun--;
                //if (basilanTus == ConsoleKey.NumPad5) 
                if (basilanTus == ConsoleKey.NumPad6 || basilanTus == ConsoleKey.RightArrow && senSutun != toplamSutun) senSutun++;
                if (basilanTus == ConsoleKey.NumPad7 && senSatir != 1 && senSutun != 1) { senSatir--; senSutun--; }
                if (basilanTus == ConsoleKey.NumPad8 || basilanTus == ConsoleKey.UpArrow && senSatir != 1) senSatir--;
                if (basilanTus == ConsoleKey.NumPad9 && senSatir != 1 && senSutun != toplamSutun) { senSatir--; senSutun++; }


            }
        }
    }
}