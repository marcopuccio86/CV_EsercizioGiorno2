using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CV mioCV = new CV();
            //Informazioni Personali
            InformazioniPersonali infoPersonali = new InformazioniPersonali()
            {
                cognome = "Puccio",
                nome = "Marco",
                telefono = "+393288317446",
                email = "info@marcopuccio.com"
            };

            //Studi effettuati
            List<Studi> ListaStudi = new List<Studi>();
            Studi StudiEffettuati = new Studi
            {
                istituto = "UniPa",
                dal = new DateTime(2016, 9, 12),
                al = new DateTime(2019, 7, 22),
            };
            Studi StudiEffettuati1 = new Studi
            {
                istituto = "Microsoft Center Milan",
                dal = new DateTime(2016, 9, 12),
                al = new DateTime(2019, 7, 22),
                tipo = "Specializzazione sviluppo software"
            };
            ListaStudi.Add(StudiEffettuati);
            ListaStudi.Add(StudiEffettuati1);

            //Impieghi
            List<Impiego> ListaImpieghi = new List<Impiego>();
            Impiego impiego = new Impiego
            {
                esperienza = new Esperienza
                {
                    dal = new DateTime(2016, 9, 12),
                    al = new DateTime(2016, 9, 12),
                    compiti = "Sviluppatore software",
                    azienda = "Libero Professionista",
                    job_title = "IT Manager"
                }
            };
            Impiego impiego1 = new Impiego
            {
                esperienza = new Esperienza
                {
                    dal = new DateTime(2016, 9, 12),
                    al = new DateTime(2016, 9, 12),
                    compiti = "Docente e Formatore",
                    azienda = "Libero Professionista",
                    job_title = "Docenza e Formazione"
                }
            };
            ListaImpieghi.Add(impiego);
            ListaImpieghi.Add(impiego1);

            //Associo le variabili alle proprietà di CV
            mioCV.InfoPersonali = infoPersonali;
            mioCV.StudiEffettuati = ListaStudi;
            mioCV.Impieghi = ListaImpieghi;
            StampaDettagliCVSuSchermo(mioCV);
        }

        static void StampaDettagliCVSuSchermo(CV cv)
        {
            Console.WriteLine($"CV di {cv.InfoPersonali.cognome} {cv.InfoPersonali.nome}");

            Console.WriteLine("");
            Console.WriteLine("++++ INIZIO Informazioni Personali: ++++");
            Console.WriteLine($"Nome: {cv.InfoPersonali.nome}");
            Console.WriteLine($"Cognome: {cv.InfoPersonali.cognome}");
            Console.WriteLine($"Email: {cv.InfoPersonali.email}");
            Console.WriteLine($"Telefono: {cv.InfoPersonali.telefono}");
            Console.WriteLine("++++ FINE Informazioni Personali: ++++");
            Console.WriteLine("");

            Console.WriteLine("++++ INIZIO Studi e Formazione: ++++");
            foreach (Studi studio in cv.StudiEffettuati)
            {
                Console.WriteLine($"Istituto: {studio.istituto}");
                Console.WriteLine($"Qualifica: {studio.qualifica}");
                Console.WriteLine($"Tipo: {studio.tipo}");
                Console.WriteLine($"Dal {studio.dal} al {studio.al}");
                Console.WriteLine("");
            }
            Console.WriteLine("++++ FINE Studi e Formazione: ++++");
            Console.WriteLine("");

            Console.WriteLine("++++ INIZIO Esperienze professionali: ++++");
            foreach (Impiego impiego in cv.Impieghi)
            {
                Console.WriteLine($"Presso: {impiego.esperienza.azienda}");
                Console.WriteLine($"Tipo di lavoro: {impiego.esperienza.job_title}");
                Console.WriteLine($"Compito: {impiego.esperienza.compiti}");
                Console.WriteLine($"Dal: {impiego.esperienza.dal} al {impiego.esperienza.al}");
                Console.WriteLine("");
            }
            Console.WriteLine("++++ FINE Esperienze professionali: ++++");
            Console.WriteLine("");



            Console.ReadLine();
        }



        public class CV
        {
            public InformazioniPersonali InfoPersonali { get; set; }
            public List<Studi> StudiEffettuati { get; set; }
            public List<Impiego> Impieghi { get; set; }
        }

        public class InformazioniPersonali
        {
            public string nome { get; set; }
            public string cognome { get; set; }
            public string telefono { get; set; }
            public string email { get; set; }
        }

        public class Studi
        {
            public string qualifica { get; set; }
            public string istituto { get; set; }
            public string tipo { get; set; }
            public DateTime dal { get; set; }
            public DateTime al { get; set; }
        }

        public class Impiego
        {
            public Esperienza esperienza;
        }

        public class Esperienza
        {
            public string azienda { get; set; }
            public string job_title { get; set; }
            public DateTime dal { get; set; }
            public DateTime al { get; set; }
            public string descrizione { get; set; }
            public string compiti { get; set; }
        }
    }
}

