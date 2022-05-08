using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        //public string Name;
        //public string Surname;
        //private string email;

        //public string Email
        //{
        //    get
        //    {
        //        return this.email;
        //    }
        //    set
        //    {
        //        if (value.Length > 15)
        //            this.email = value;
        //        else
        //            this.email = "";
        //    }
        //}

        //int id;
        //public int Id
        //{
        //    get
        //    {
        //        return this.id;
        //    }
        //    private set
        //    {
        //        this.id = value;
        //    }
        //}

        //public Student()
        //{
        //    this.id = GenerateId();
        //}

        //private int GenerateId()
        //{
        //    Random rand = new Random();
        //    return rand.Next(1000000, 9999999);
        //}

        private string documentSerial;
        public string DocumentSerial
        {
            get
            {
                return this.documentSerial;
            }
            set
            {
                if(value.Length != 2)
                {
                    Console.WriteLine("Length can not be greater that 2 letters");
                }
                else
                {
                    foreach(char l in value)
                    {
                        if (!Char.IsLetter(l))
                        {
                            Console.WriteLine("Serial must consist of only letters");
                        }
                        else
                        {
                            this.documentSerial = value;
                        }
                    }
                }
            }
        }
          
        private string documentNumber;
        private int showNumbers = 3;
        public string DocumentNumber
        {
            get
            {
                string tmp = "";
                for (int i = showNumbers; i < this.documentNumber.Length; i++)
                {
                    tmp += "*";
                }
                this.documentNumber = this.documentNumber.Substring(0, showNumbers) + tmp;
                return this.documentNumber;
            }
            set
            {
                if (value.Length != 8)
                {
                    Console.WriteLine("Length can not be greater that 8 letters");
                }
                else
                {
                    foreach (char d in value)
                    {
                        if (!Char.IsDigit(d))
                        {
                            Console.WriteLine("Number must consist of only letters");
                        }
                        else
                        {
                            this.documentNumber = value;
                        }
                    }
                }
            }
        }
    }
}


/*
        Vəsiqənin seriyası və vəsiqənin nömrəsi adlı iki xananız olacaq. DocumentSerial və DocumentNumber olaraq adlandıra bilərsiniz.
        Hər biri üçün, getter və setteri olan bir property'si və private bir field'ı olacaq.
        Validation və xəta mesajları:
        Vəsiqənin seriyasını set edən zaman yoxlamalıdır ki, uzunluğu 2 hərfdir mi?
        Deyilsə: "Vesiqenin seriyasinin uzunlugu 2 herf olmalidir!" xətası çıxmalıdır.
        Eyni zamanda yoxlamalıdır ki, sadəcə hərflərdən mi ibarətdir?
        Deyilsə: "Vesiqenin seriyasi sadece herflerden ibaret olmalidir!" xətası çıxmalıdır.
        Eyni zamanda da, vəsiqənin nömrəsi set olunan zaman baxmalıdır ki, uzunluğu 8 ə bərabərdir mi?
        From Orkhan Farajov to Everyone 08:51 PM
        Deyilsə: "Vesiqenin nomresinin uzunlugu 8 olmalidir!" xətası çıxmalıdır.
        Birdə nömrənin rəqəmlərdən ibarət olub-olmaması yoxlanmalıdır.
        Deyilsə: "Vesiqenin nomresi sadece reqemlerden ibaret olmalidir!" xətası çıxacaq.
        Bu validation'lara əlavə olaraq vəsiqənin nömrəsi get olan zaman ancaq ilk 3 rəqəm user'ə göstəriləcək. Digər rəqəmlər ulduz
        simvolu olaraq çıxacaq. Orda elə etmək lazımdır ki, 3 və ulduz sayı dinamik olsun. Yəni mən 3 rəqəmini 4 edən zaman avtomatik
        4 simvol görsənsin və geri qalan 4 simvol ulduz çıxsın. Əgər 3 rəqəmini 6 etsəm o zaman ilk 6 rəqəm görsənsin və 2 simvol ulduz
        olaraq çıxsın.
        Vaxt: 15 dəqiqə
 
*/
