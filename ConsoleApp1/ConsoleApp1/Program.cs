using System;

namespace Lab_3_OOP
{
    class Prog
    {
        static void Main(string[] args)
        {
            Kerosene Kerosene = new Kerosene(100, 50, "Керосин ТС-1");
            Kerosene.Dencity();
            Petrol Petrol = new Petrol(100, 75, "Автомобильный бензин АИ-95");
            Petrol.Dencity();
            DieselFluel DieselFluel = new DieselFluel(100, 85, "Дизельное топливо ДТ62");
            DieselFluel.Dencity();



            Console.ReadLine();
        }
    }
}
