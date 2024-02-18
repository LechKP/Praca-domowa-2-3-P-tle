using System;

namespace PracaDomowaPetle
{
    public class Program
    {
        
        static void Main()
        {
            // zadanie nr. 1 Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.
            Console.WriteLine("zadanie nr. 1 Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.");
            int g = 0; int f = 0;
            for (int c1 = 2; c1 <= 100; c1++)
            {

                f = 0;
                for (int c2 = 2; c2 <= c1; c2++)

                {
                    g = c1 / c2;

                    if (c1 % c2 == 0)
                    {

                        f++;
                    }


                }
                if (f == 1)
                {
                    Console.WriteLine(c1);
                }
            }

            // zadanie nr. 2 Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.
            Console.WriteLine("zadanie nr. 2 Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.");
            int Liczba = 1;
            do
            {
                if (Liczba % 2 == 0)
                {
                    Console.WriteLine($"{Liczba}");
                }
                Liczba++;
            }
            while (Liczba <= 1000);

            // zadanie nr. 3 Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
            Console.WriteLine("zadanie nr. 3 Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.");
            int LiczbaA = 1;
            int LiczbaB = 0;
            int LiczbaC = 0;
            while (LiczbaA < 100000000)
            {
                LiczbaC = LiczbaA + LiczbaB;
                Console.WriteLine($"{LiczbaC}");
                LiczbaA = LiczbaB; LiczbaB = LiczbaC;
            }
            // zadanie nr. 4 Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:
            //1
            //2 3
            //4 5 6
            //7 8 9 10
            Console.WriteLine(" zadanie nr. 4 Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:");
            Console.WriteLine("1");
            Console.WriteLine("2 3");
            Console.WriteLine("4 5 6");



            int CyfraA = 1; int CyfraB = 1;
            Console.WriteLine("Podaj cyfre ktora ma zakonczyc ciag piramidy");
            int.TryParse(Console.ReadLine(), out int MaxCiag);

            while (CyfraA <= MaxCiag)
            {
                int Pomocnicza = 1;
                while (Pomocnicza <= CyfraA)
                {
                    Console.Write(CyfraB + " ");
                    Pomocnicza++;
                    CyfraB++;
                    if (CyfraB > MaxCiag) break;
                }

                Console.WriteLine();
                if (CyfraB > MaxCiag) break;
                CyfraA++;
            }
            // zadanie nr. 5 Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
            Console.WriteLine("zadanie nr. 5 Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.");
            for (int i = 1; i <= 20; i++)
                {

                    Console.WriteLine(i * i * i);
                }

            // zadanie nr. 6 Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru: 1 + ½ +1 / 3 + ¼ itd.
            Console.WriteLine(" zadanie nr. 6 Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru: 1 + ½ +1 / 3 + ¼ itd.");
                float BB = 1; float DD = 0; float EE = 0;
                for (float AA = 1; BB <= 20; BB++)
                {
                    float CC = AA / BB;

                    EE = CC + DD;
                    DD = EE;

                }
                Console.WriteLine(EE);
            // zadanie nr. 7 Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków
            Console.WriteLine("zadanie nr. 7 Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków");
                string ciag; string ciagRevers = "";
                Console.WriteLine("Podaj ciag do odwrocenia");
                ciag = Console.ReadLine();

                for (int ii = ciag.Length - 1; ii >= 0; ii--)
                {
                    ciagRevers = ciagRevers + ciag[ii];
                }
                ciagRevers = ciagRevers.Substring(0, 1).ToUpper() + ciagRevers.Substring(1).ToLower();


                Console.WriteLine(ciagRevers);

                //zadanie nr. 8 Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:

                //  *
                // ***
                //  *
                Console.WriteLine("zadanie nr. 8 Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:");
            Console.WriteLine("*");
            Console.WriteLine("***");
            Console.WriteLine("*");


            Console.WriteLine("Podaj nieparzysta cyfre, ktora bedzie pozioma przekatna rombu");
                int star = int.Parse(Console.ReadLine());

                for (int i = 1, space = star / 2; i <= star; i = i + 2, space--)
                {

                    Console.WriteLine(new string(' ', space) + new string('*', i));

                }
                for (int i = star - 2, space = 1; i >= 0; i = i - 2, space++)
                {
                    Console.WriteLine(new string(' ', space) + new string('*', i));
                }
            // zadanie nr. 9 Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
            Console.WriteLine("zadanie nr. 9 Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.");
            Console.WriteLine("Podaj liczbe, ktora program skonwertuje na liczbe binarna");
                int.TryParse(Console.ReadLine(), out int dzies);
                string ciag2 = "";
                for (int t = 0; dzies > 0; dzies /= 2)
                {
                    int binar = dzies % 2;
                    ciag2 = ciag2 + binar;

                }
                string ciagRevers2 = "";
                for (int tt = ciag2.Length - 1; tt >= 0; tt--)
                {
                    ciagRevers2 = ciagRevers2 + ciag2[tt];
                }
                Console.WriteLine(ciagRevers2);

            // zadanie nr. 10 Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
            Console.WriteLine("zadanie nr. 10 Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.");
            Console.WriteLine("Podaj 2 cyfry oddzielone spacja w celu znaleznienia najmniejszej wspolnej wielokrotnosci");
                string[] cyfry = Console.ReadLine().Split(' ');
                int.TryParse(cyfry[0], out int cyfra1);
                int.TryParse(cyfry[1], out int cyfra2);
                int NWW;
                for (NWW = 2; NWW % cyfra1 != 0 || NWW % cyfra2 != 0; NWW++)
                {

                }
                Console.WriteLine(NWW);
            

        }


    }

}

