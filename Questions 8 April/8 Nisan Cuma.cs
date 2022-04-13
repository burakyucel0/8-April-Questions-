using System;
using System.Globalization;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Questions_8_April
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1) 2010 ile 2022 arasında mesai saatleri içerisinde(09:00 - 18:00) 1000 adet RANDOM TARİH oluştur ve bir tarih listesine ata

            Random rnd = new Random();
            List<DateTime> DateList1 = new List<DateTime>();

            DateTime start = new DateTime(2010, 01, 01);
            DateTime end = new DateTime(2022, 01, 01);
            TimeSpan timeSpan = end - start;


            while (DateList1.Count < 1000)
            {

                DateList1.Add(start.AddDays(rnd.Next(Convert.ToInt32(timeSpan.TotalDays))).AddHours(rnd.Next(9, 18)).AddMinutes(rnd.Next(0, 59)));      //Aradaki tarih farkı bulunarak totaldays olarak eklendi

            }

            //foreach (var item in DateList1) Console.WriteLine(item);



            #region Soru 2
            //// 2) Bu listede cumartesi ve pazar olmasın!

            //Haftasonu mu?
            //static bool IsWeekend(DateTime dateTime)
            //{
            //    if (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday)
            //        return true;
            //    else
            //        return false;
            //}

            //while (DateList1.Count < 1000)
            //{

            //    DateTime newDate = start.AddDays(rnd.Next(Convert.ToInt32(timeSpan.TotalDays))).AddHours(rnd.Next(9, 18)).AddMinutes(rnd.Next(0, 59));

            //    if (!IsWeekend(newDate)){

            //       DateList1.Add(newDate);
            //    }

            //}

            //foreach (var item in DateList1) Console.WriteLine(item);
            #endregion

            #region Soru 3
            //3) Bu listenin içerisinde tarihlerin kaçı şubat ayı içerisindedir?

            Console.WriteLine(DateList1.Where(x => x.Month == 02).Count());

            #endregion

            #region Soru 4
            ////4) Bu listenin içerisindeki tarihlerin kaçı 12:00(öğlen) den öncedir


            Console.WriteLine(DateList1.Where(x => x.Hour < 12).Count());

            #endregion

            #region Soru 5
            ////5) Bu listede kaç tane pazartesi var?
            Console.WriteLine(DateList1.Where(x => x.DayOfWeek == DayOfWeek.Monday).Count());

            #endregion

            #region Soru 6
            ////6) Saat aralığı 17:00 - 18:00 arasında olan tüm tarihleri ekrana yaz.


            //List<DateTime> Listfilter6 = (DateList1.Where(x => x.Hour >= 17).ToList());
            //foreach (var item in Listfilter6) Console.WriteLine(item);

            #endregion

            #region Soru7
            //7) Kullanıcı ekrandan bir yıl girsin ve o yıla ait tüm tarihleri ekrana yaz

            //Console.WriteLine("Lütfen bir yıl giriniz.");
            //int year = Convert.ToInt32(Console.ReadLine());

            //List<DateTime> Listfilter7 = (DateList1.Where(x => x.Year == year).ToList());

            //foreach (var item in Listfilter7) Console.WriteLine(item);

            #endregion

            #region Soru 8
            //8) Kullanıcı ekrandan önce yıl sonra ay girsin ve bu ay ve yıla ait tüm tarihler sıralansın.

            //Console.WriteLine("Lütfen bir yıl giriniz.");
            //int useryear = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Lütfen bir ay giriniz.");
            //int usermonth = Convert.ToInt32(Console.ReadLine());


            //List<DateTime> Listfilter7 = (DateList1.Where(x => x.Year == useryear && x.Month == usermonth).ToList());
            //Listfilter7 = Listfilter7.OrderBy(x => x).ToList();
            //foreach (var item in Listfilter7) Console.WriteLine(item);

            #endregion

            #region Soru 9
            //9) 2010 SONRASI tarihleri ekrana yazdır.

            //List<DateTime> Listfilter9 = (DateList1.Where(x => x.Year > 2010).ToList());

            //Listfilter9 = Listfilter9.OrderBy(x => x).ToList();

            //foreach (var item in Listfilter9) Console.WriteLine(item);
            #endregion

            #region Soru 10
            //10) 2010 - 2015 arasında SADECE OCAK ayında geçen tarihleri ekrana yazdır.

            //List<DateTime> Listfilter10 = (DateList1.Where(x => x.Year > 2010 && x.Year < 2015 && x.Month == 01).ToList());

            //Listfilter10 = Listfilter10.OrderBy(x => x).ToList();

            //foreach (var item in Listfilter10) Console.WriteLine(item);

            #endregion


            Console.ReadLine();
        }
    }
}
