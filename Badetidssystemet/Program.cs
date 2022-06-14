using System;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Kreds k1 = new Kreds("1", "Hurtig", "Maglevej 4", 4);
                Kreds k2 = new Kreds("2", "Ikke så hurtig", "Maglevej 4", 2);
                Kreds k3 = new Kreds("3", "Langsom", "Maglevej 4", 3);

                Kreds j1 = new Kreds("5", "Hurtig", "Maglevej 4", 4);
                Kreds j2 = new Kreds("6", "Ikke så hurtig", "Maglevej 4", 2);
                Kreds j3 = new Kreds("7", "Langsom", "Maglevej 4", 3);

                //Console.WriteLine(k2);
                //Console.WriteLine(k3);

                BadetidsPeriode b1 = new BadetidsPeriode("Type 1", new DayOfWeek(), new DateTime().AddYears(2021).AddMonths(5).AddDays(13).AddHours(7).AddMinutes(30), new DateTime().AddYears(2021).AddMonths(6).AddDays(14).AddHours(10).AddMinutes(30));

                b1.AdderKreds(k1);
                b1.AdderKreds(k2);
                b1.AdderKreds(k3);

                b1.DeleteKreds(k2);

                Console.WriteLine(b1);

                BadetidsPeriode b2 = new BadetidsPeriode("Type 2", new DayOfWeek(), new DateTime().AddYears(2021).AddMonths(5).AddDays(13).AddHours(7).AddMinutes(30), new DateTime().AddYears(2021).AddMonths(6).AddDays(14).AddHours(10).AddMinutes(30));

                b2.AdderKreds(j1);
                b2.AdderKreds(j2);
                b2.AdderKreds(j3);

                b2.DeleteKreds(k2);

                Console.WriteLine(b2);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                
            }



        }
    }
}
