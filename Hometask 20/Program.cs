using System;



//  Dependency Inversion
//  Dependency Injection         


namespace App
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---- Dependency Inversion Principle ----");

            ISavePlace place1 = new DataSaver(new Folder(@"C:\Users\dmitrii.romanenco\Downloads\Hometask 20"));
            ISavePlace place2 = new DataSaver(new TxtFile(@"~\file.txt"));
            ISavePlace place3 = new DataSaver(new Repository(@"https:\\github.com\Dimitris-Kidis\Hometask 20"));

            place1.GetPlace();
            Console.WriteLine("------------------------------");
            place2.GetPlace();
            Console.WriteLine("------------------------------");
            place3.GetPlace();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---- Dependency Injection ----");

            Automobile carOne = new Automobile(new SmallEngine());
            Automobile carTwo = new Automobile(new BigEngine());
            carOne.TurnOn();
            carTwo.TurnOn();

        }
    }
}