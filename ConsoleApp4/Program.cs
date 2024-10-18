namespace ConsoleApp4;
using static System.Console;
internal class Program
{
    static void Main(string[] args)
    {
        Weapon weapon = null;

        int capacity, currentBullets;
        bool Auto;
        while (true)
        {
            WriteLine("Maksimum gulle sayı 30 ola biler 30 u kecme");
            string Read = ReadLine();
            if (int.TryParse(Read, out capacity) && capacity <= 30 && capacity >= 1)
            {
                break;
            }
            else
            {
                WriteLine("1 den boyuk ve 30-dan kicik ede daxil ele.");
            }
        }

        while (true)
        {
            WriteLine("Maqazinde olan gulle sayi: ");
            string Read = ReadLine();
            if (int.TryParse(Read, out currentBullets) && currentBullets < capacity)
            {
                break;
            }
            else
            {
                WriteLine("30 dan cox gulle ola bilmez.");
            }
        }

        while (true)
        {
            WriteLine("Modu seçin:(avtomatikdise (true) yaz tekli olsa (false) yaz)");

            string Read = ReadLine();
            if (Read.ToLower() == "true")
            {
                Auto = true;
                break;
            }
            else if (Read.ToLower() == "false")
            {
                Auto = false;
                break;
            }
            else
            {
                WriteLine("(True) ve (False) yazmag lazimdi.");
            }

        }


        Weapon weapon1 = new Weapon(capacity, currentBullets, Auto);
        WriteLine("Atisa hazirdi");


        do
        {
            WriteLine("0. informasiya ucun:");
            WriteLine("1. Shoot metodu");
            WriteLine("2. BulletCount");
            WriteLine("3. Reload");
            WriteLine("4. FireMood");
            WriteLine("5. Exit");
            int choice = int.Parse(ReadLine());
            switch (choice)
            {
                case 0:
                    WriteLine("Butun data");
                    weapon1.ShowAllInfo();
                    break;
                case 1:
                    WriteLine("shoot metodunu ucun");
                    weapon1.Shoot();
                    break;
                case 2:
                    WriteLine("gulle sayi");
                    weapon1.GetRemainBulletCount();
                    break;
                case 3:
                    weapon1.Reload();
                    break;
                case 4:
                    WriteLine("Modu true=avtomatik false=tekli");
                    weapon1.ChangeFireMood();
                    break;
                case 5:
                    WriteLine("program dayansin");
                    break;
                case 6:

                    bool edit = true;
                    do
                    {
                        WriteLine("7. Tutumu deyis");
                        WriteLine("8. Gulle sayini deyis");
                        WriteLine("9. Geri qayit");
                        int num = int.Parse(ReadLine());

                        switch (num)
                        {
                            case 7:
                                int newCapacity;
                                WriteLine("Yeni max gulle sayini daxil et");
                                if (int.TryParse(ReadLine(), out newCapacity))
                                {
                                    weapon1.BulletCapacity = newCapacity;
                                    WriteLine($"Gulle sayi {newCapacity} olaraq deyisdirildi.");
                                }
                                else
                                {
                                    WriteLine("Duzgun daxil et.");
                                }
                                break;
                            case 8:
                                int newBulletCount;
                                WriteLine("Yeni gulle sayını daxil et:");
                                if (int.TryParse(ReadLine(), out newBulletCount) && newBulletCount >= 0)
                                {
                                    weapon1.BulletCount = newBulletCount;
                                    WriteLine($"Gulle sayı {newBulletCount} olaraq dəyişdirildi.");
                                }
                                else
                                {
                                    WriteLine("Duzgun daxil et.");
                                }
                                break;
                            case 9:
                                edit = false;
                                break;
                            default:
                                WriteLine("Duzgun secim et.");
                                break;
                        }

                    } while (edit);
                    break;
            }

        } while (true);
    }


}
