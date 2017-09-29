using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_einlesen_und_auswerten
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string dateiName = "HH_Alle Pages_NAV71_2017_09_27.txt";
            string pageName = "";
            var pageListe = new List<String>();

            string[] dateiInhalt = File.ReadAllLines(dateiName);

            foreach (var item in dateiInhalt)
            {
                if (item.Contains("OBJECT Page "))
                {
                    int startIndex = item.IndexOf("OBJECT Page ");
                    pageName = item.Substring(startIndex, item.Length- startIndex);
                    pageListe.Add(pageName);
                }
            }
            //foreach (var item in pageListe)
            //{
            //File.WriteAllLines("Pages.txt", item);
            //
            File.WriteAllLines("Pages.txt", pageListe);
            Console.WriteLine("Fertig");
            Console.ReadKey();
            */
            DateiAuslesenSchreiben();
        }

       static public void DateiAuslesenSchreiben()
        {
            string dateiName = "HH_Alle Pages_NAV71_2017_09_27.txt";
            string pageName = "";
            string datei2 = "Pages.txt";
            var pageListe = new List<String>();

            string[] dateiInhalt = File.ReadAllLines(dateiName);
            string[] searchListe = File.ReadAllLines(datei2);
            var search = new List<String>();
            foreach (var item in searchListe)
            {
                search.Add(item);
            }

            foreach (var data in dateiInhalt)
            {
                bool vorhanden = false;
                if (data.Contains("OBJECT Page "))
                {
                    int startIndex = data.IndexOf("OBJECT Page ");
                    pageName = data.Substring(startIndex, data.Length - startIndex);
                }
                foreach (var item in search)
                {
                            
                    if (data.Contains(item))
                    {
                        vorhanden = true;
                    }
                }

                if (vorhanden)
                {
                    pageListe.Add(pageName);
                }
            }

            File.WriteAllLines("Alle Pages.txt", pageListe);
            Console.WriteLine("Fertig");
            Console.ReadKey();
        }
    }
}
