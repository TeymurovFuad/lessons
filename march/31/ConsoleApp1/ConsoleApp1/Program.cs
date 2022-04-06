using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Homework 1:
            // 5 dənə dəyişəni Implicit Conversion,
            {
                int i1 = 5;
                long i1ToLong = i1;

                short i2 = 12;
                int i2ToInt = i2;

                float i3 = 12.5F;
                double i3ToDouble = i3;


                char i4 = 'a';
                long i4ToLong = i4;

                short i5 = 3254;
                long i5ToLong = i5;

            }
            // 5 dənə dəyişəni Explicit Conversion,
            {
                long i1 = 5;
                int i1ToInt = (int)i1;

                short i1ToShort = (short)i1;

                decimal i3 = 12.5M;
                double i3ToDouble = (double)i3;


                char i4 = 'a';
                long i4ToLong = i4;

                short i5 = 3254;
                long i5ToLong = i5;
            }
            // 5 dənə dəyişəni Helper Class Conversion vasitəsilə convert edin. Dəyişən tiplərini və dəyərlərini özünüz seçin.




            //  Homework 2:
            //  Bir dənə anket proqramı yığacaqsınız.İstifadəçidən onun haqqında məlumatları toplayacaqsınız.Bu məlumatlar ad, soyad, cins, doğum tarixi,
            //yaşadığı ölkə, yaşadığı şəhər, boy, çəki, maaş olacaq.Siz bu məlumatları saxlamaq üçün doğru bir data type seçməlisiniz.
            //  İstifadəçinin daxil edəcəyi məlumatlar belə olacaq:
            //  Ad: Mark
            //  Soyad: Henry
            //  Cins: K və ya Q
            //  Doğum tarixi: 1990 - 10 - 10
            //  Yaşadığı ölkə: Azərbaycan
            //  Yaşadığı şəhər: Bakı
            //  Boy: 1.75
            //  Çəki: 26.50
            //  Maaş: 2500.00

            {
                string name, surname, country, city;
                bool gender;
                DateTime born;
                float height, weight;
                    decimal salary;

                Console.WriteLine("Please enter your name");
                name = Console.ReadLine();

                Console.WriteLine("Please enter your surname");
                surname = Console.ReadLine();

                Console.WriteLine("Please enter your gender (male/female)");
                gender = Console.ReadLine().ToLower() == "female" ? Convert.ToBoolean(0) : Convert.ToBoolean(1);

                Console.WriteLine("Please enter date of birth  ex. year/month/day");
                born = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Please enter country you live");
                country = Console.ReadLine();

                Console.WriteLine("Please enter city you live");
                city = Console.ReadLine();

                Console.WriteLine("Please enter your height");
                height = (float)Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter your weight");
                weight = (float)Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter your salary");
                salary = Convert.ToDecimal(Console.ReadLine());

                Console.ReadLine();
            }



            //Homework 3:
            //İstifadəçidən yaşını, maaşını, boyunu, çəkisini və neçə dostu olduğunu soruşacaqsınız.Daxil etdiyi bütün dəyərləri ilk öncə int tipinə convert
            //edəcəksiniz.Daha sonra int dəyişənini byte tipinə cast edəcəksiniz(explicit conversion).
            //Burada istifadəçi maaşı və yaşı xaricində digər məlumatları byte'ın max dəyərindən çox yazsa heç bir xəta çıxmasın. Maaşını və ya yaşını byte
            //tipinin qəbul edəcəyi maksimum dəyərdən çox yazarsa elə edin ki, proqramda xəta çıxsın.

            int age, salary, height, weight;

            Console.WriteLine("Please insert your");
            Console.WriteLine("Age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Salary");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Height");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Weight");
            weight = Convert.ToInt32(Console.ReadLine());



            //Homework 4:
            //Aşağıdakı dəyərləri düzgün tiplərdə dəyişənlər yaradıb saxlayın:
            //1: "Hava gozeldir." -> string
            //2: '%' -> char
            //3: 9999999999999999 -> long
            //4: true -> bool
            //5: false -> bool
            //6: '0' -> char
            //7: 0 -> byte
            //8: 150 -> byte
            //9: -111111111115615 -> slong
            //10: 15.2M -> decimal
            //11: 15.2 -> double
            //12: 15.2F -> float
            //13: new DateTime(2020, 12, 12) -> DateTime

        }
}
}
