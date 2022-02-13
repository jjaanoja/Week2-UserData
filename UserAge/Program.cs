using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis;
            //"oled sündinud aastal {yearOfBirth}"
            Console.WriteLine("Palun, sisesta oma vanus");
            int vanus = Convert.ToInt32(Console.ReadLine());
            int sünniaasta = 2022 - vanus;
            Console.WriteLine("Oled " + sünniaasta + " aastal sündinud.");
        }
    }
}
