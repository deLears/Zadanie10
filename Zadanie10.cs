using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Zadanie10
    {
        /*
        Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
        Реализовать класс, в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных.
        Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы.
        Создать объект на основе разработанного класса. Осуществить использование объекта в программе.
        */
        static void Main(string[] args)
        {
            Angle angle = new Angle();
            angle.ToRadians();

            
        }
    }

    public class Angle
    {
        private double angleRad;
        private double grad;
        private double min;
        private double sec;

        public double Grad
        {
            set
            {
                if (Math.Abs(value) >= 0 || Math.Abs(value) <= 360)
                { grad = value; }
                else
                {
                    Console.WriteLine("Некорректный ввод данных");
                }
            }
            get
            {
                return grad;
            }
        }
        public double Min
        {
            set
            {
                if (Math.Abs(value) >= 0 || Math.Abs(value) <= 60)
                { min = value; }
                else
                {
                    Console.WriteLine("Некорректный ввод данных");
                }
            }
            get
            {
                return min;
            }

        }
        public double Sec
        {
            set
            {
                if (Math.Abs(value) >= 0 || Math.Abs(value) <= 60)
                { sec = value; }
                else
                {
                    Console.WriteLine("Некорректный ввод данных");
                }
            }
            get
            {
                return sec;
            }

        }


        public Angle(double grad=0, double min=0, double sec=0, string basis="Новый")
        {
            this.grad = grad;
            this.min = min;
            this.sec = sec;
        
        }


        public void ToRadians()
        {
            Console.WriteLine("Введите значение угла в градусах");
            grad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение угла в минутах");
            min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение угла в секундах");
            min = Convert.ToDouble(Console.ReadLine());
            angleRad = Math.Abs((grad + min / 60 + sec / 360) * (Math.PI) / 180);

            Console.WriteLine("Значение угла в радианах:{0}",angleRad);

            Console.ReadKey();
        }
    }

}
