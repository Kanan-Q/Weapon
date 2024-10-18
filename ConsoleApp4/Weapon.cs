using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Weapon
    {
        private double _bulletCapacity;
        private double _bulletCount;

        public double BulletCapacity //gulle tutumu
        {
            get
            {
                return _bulletCapacity;
            }
            set
            {
                if (value >0 && value < 31)
                {
                    _bulletCapacity = value;
                    Console.WriteLine($"Darag bos deyil:{value} gulle var");
                }
                else
                {
                    Console.WriteLine("O qeder gulle goturmur");
                }
            }
        }
        public double BulletCount //daragdaki gulle sayi
        {
            get
            {
                return _bulletCount;
            }
            set
            {
                if (value > 0)
                {
                    _bulletCount = value;
                    Console.WriteLine("en azi bir denede olsa gulle var");
                }
            }
        }
        public bool ShootMood { get; set; } //atis modu
        public Weapon(double bulletCapacity, double bulletCount, bool shootMood)
        {
            BulletCapacity = bulletCapacity;
            BulletCount = bulletCount;
            ShootMood = shootMood;
        }

        public double Shoot()
        {

            if (BulletCount >=0&& ShootMood==true)
            {
                if (BulletCount == 0)
                {
                    Console.WriteLine("Gulle yoxdu");
                }
                BulletCount--;
                Console.WriteLine($"Maqazinde qalan gullenin sayi {BulletCount}");
            }
            else
            {
                Console.WriteLine($"Tekli mod oldugu ucun avtomatik bir defe 1 gulle atir,qalan gulle sayi:{BulletCount} olur ve proses dayanir.");
            }

            return BulletCount;
        }
        public void GetRemainBulletCount()
        {
            double Minus = BulletCapacity - BulletCount;
            if (Minus <= 31)
            {
                Console.WriteLine($"{Minus} dene gulle doldurmalisan");

            }
            else
            {
                Console.WriteLine("Cox gulle doldurursan olmaz!!!");
            }
        }

        public void Reload()
        {
            if (BulletCapacity < 30)

            {
                Console.WriteLine("Gulle 30 dan azdi maqazini deyis zarejat ele atis-a hazir veziyyete getir!");
            }

            else
            {
                Console.WriteLine("Tam doludu atisma baslasin");
            }
        }


        public void ChangeFireMood()
        {
            if (ShootMood == true)
            {
                Console.WriteLine("Avtomatik atis modundadi amaki luleyi eriye biler fasileli atis et!");
            }
            else
            {
                Console.WriteLine("Tekli atis modundadir avtomatin esmesi az olacag yaxsidi.");
            }
        }

        public void ShowAllInfo()
        {
            Console.WriteLine($"Max gulle Tutumu:{BulletCapacity},Maqazindeki gulle sayi{BulletCount},atis Modu:{ShootMood}");
        }

    }
}
