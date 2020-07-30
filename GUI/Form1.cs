using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
       
            //this.kolMechanik
            //this.kolMechanikP
            //this.kolDiagnostyka
            //this.kolBlach

        public Form1()
        {
            InitializeComponent();
            
        }

        private delegate void SafeCallDelegate(string text);

        public void dodMech1(String nazwa) {
            if (mech1.InvokeRequired)
            {
                var d = new SafeCallDelegate(dodMech1);
                mech1.Invoke(d, new object[] { nazwa });
            }
            else
            {
                mech1.Items.Add(nazwa);
            }
             
        }
        public void dodMech2(String nazwa)
        {
            if (mech2.InvokeRequired)
            {
                var d = new SafeCallDelegate(dodMech2);
                mech2.Invoke(d, new object[] { nazwa });
            }
            else
            {
                mech2.Items.Add(nazwa);
            }
        }

        public void usuMech1(String nazwa)
        {
            if (mech1.InvokeRequired)
            {
                var d = new SafeCallDelegate(usuMech1);
                mech1.Invoke(d, new object[] { nazwa });
            }
            else
            {
                mech1.Items.Remove(nazwa);
            }
        }

        public void usuMech2(String nazwa)
        {
            if (mech2.InvokeRequired)
            {
                var d = new SafeCallDelegate(usuMech2);
                mech2.Invoke(d, new object[] { nazwa });
            }
            else
            {
                mech2.Items.Remove(nazwa);
            }
        }

        public void dodDiagnostyka(String nazwa)
        {
            if (diagnostyka.InvokeRequired)
            {
                var d = new SafeCallDelegate(dodDiagnostyka);
                diagnostyka.Invoke(d, new object[] { nazwa });
            }
            else
            {
                diagnostyka.Items.Add(nazwa);
            }
        }
        public void dodBlacharstwo(String nazwa)
        {
            if (blacharstwo.InvokeRequired)
            {
                var d = new SafeCallDelegate(dodBlacharstwo);
                blacharstwo.Invoke(d, new object[] { nazwa });
            }
            else
            {
                blacharstwo.Items.Add(nazwa);
            }
        }

        
        public void usuDiagnostyka(String nazwa)
        {
            if (diagnostyka.InvokeRequired)
            {
                var d = new SafeCallDelegate(usuDiagnostyka);
                diagnostyka.Invoke(d, new object[] { nazwa });
            }
            else
            {
                diagnostyka.Items.Remove(nazwa);
            }
        }

        public void usuBlacharstwo(String nazwa)
        {
            if (blacharstwo.InvokeRequired)
            {
                var d = new SafeCallDelegate(usuBlacharstwo);
                blacharstwo.Invoke(d, new object[] { nazwa });
            }
            else
            {
                blacharstwo.Items.Remove(nazwa);
            }
        }

        public void dodajDokolejkiMech(String nazwa) {
            kolMechanik.Items.Add(nazwa);
        }

        public void usunZkolejkiMech(String nazwa) {

            if (kolMechanikP.InvokeRequired)
            {
                var d = new SafeCallDelegate(usunZkolejkiMech);
                kolMechanik.Invoke(d, new object[] { nazwa });
            }
            else
            {
                 kolMechanik.Items.Remove(nazwa);
            }
        }

        public void dodajDokolejkiMechP(String nazwa)
        {

            if (kolMechanikP.InvokeRequired)
            {
                var d = new SafeCallDelegate(dodajDokolejkiMechP);
                kolMechanikP.Invoke(d, new object[] { nazwa });
            }
            else
            {
                kolMechanikP.Items.Add(nazwa);
            }

        }

        public void usunZkolejkiMechP(String nazwa)
        {
              if (kolMechanikP.InvokeRequired)
            {
                var d = new SafeCallDelegate(usunZkolejkiMechP);
                kolMechanikP.Invoke(d, new object[] { nazwa });
            }
            else
            {
                 kolMechanikP.Items.Remove(nazwa);
            }
        }

        public void dodajDokolejkiDia(String nazwa)
        {
            kolDiagnostyka.Items.Add(nazwa);
        }

        public void usunZkolejkiDia(String nazwa)
        {
            if (kolDiagnostyka.InvokeRequired)
            {
                var d = new SafeCallDelegate(usunZkolejkiDia);
                kolDiagnostyka.Invoke(d, new object[] { nazwa });
            }
            else
            {
                kolDiagnostyka.Items.Remove(nazwa);
            }
        }

        public void dodajDokolejkiBla(String nazwa)
        {
            if (kolBlach.InvokeRequired)
            {
                var d = new SafeCallDelegate(dodajDokolejkiBla);
                kolBlach.Invoke(d, new object[] { nazwa });
            }
            else
            {
                kolBlach.Items.Add(nazwa);
            }
           
        }

        public void usunZkolejkiBla(String nazwa)
        {
            if (kolBlach.InvokeRequired)
            {
                var d = new SafeCallDelegate(usunZkolejkiBla);
                kolBlach.Invoke(d, new object[] { nazwa });
            }
            else
            {
                kolBlach.Items.Remove(nazwa);
            }
        }

        public void dodajDokolejki(String nazwa, ListBox kolejka)
        {
            kolejka.Items.Add(nazwa);
        }

        public void usunZkolejki(String nazwa, ListBox kolejka)
        {
            kolejka.Items.Remove(nazwa);
        }




        private void Form1_Load(object sender, EventArgs e)
        {

            MechanikSamochodowy mechanik1 = new MechanikSamochodowy("Mechanik1");
            MechanikSamochodowy mechanik2 = new MechanikSamochodowy("Mechanik2");
            StacjaDiagnostyczna stacjaDiagnostyczna = new StacjaDiagnostyczna("Stacja diagnostyczna1");
            StacjaLakierniczoBlacharska stacjaLakierniczoBlacharska = new StacjaLakierniczoBlacharska("Stacja Lakierniczo Blacharska1");

            Thread t = new Thread(new ThreadStart(mechanik1.obsluga));
            Thread t1 = new Thread(new ThreadStart(mechanik2.obsluga));
            Thread t2 = new Thread(new ThreadStart(stacjaDiagnostyczna.obsluga));
            Thread t3 = new Thread(new ThreadStart(stacjaLakierniczoBlacharska.obsluga));

            t.Start();
            t1.Start();
            t2.Start();
            t3.Start();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Samochod.setForm(this);
        Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                
                Samochod samochod = new Samochod("Samochod." + i);
                Console.WriteLine("Samochod {0} UTWORZONY", samochod.nazwa);
                int r = random.Next(0, 6)%3;
                //Thread.Sleep(100);
                if (r == 1)
                {
                    StacjaDiagnostyczna.kolejkaDoStacjiDiagnostycznej.Enqueue(samochod);
                    dodajDokolejki(samochod.nazwa, kolDiagnostyka);
                }
                else if (r == 2)
                {
                    StacjaLakierniczoBlacharska.kolejkaDoBlacha.Enqueue(samochod);
                    dodajDokolejki(samochod.nazwa, kolBlach);
                }
                else
                {
                    MechanikSamochodowy.dodajDoKolejki(samochod);
                    dodajDokolejki(samochod.nazwa, kolMechanik);
                }
            }


        }
    }



    class MechanikSamochodowy
    {
            String nazwa { get; set; }
            Random rand = new Random();
            Samochod samochod;

            public static Queue<Samochod> kolejkaDoMechanika= new Queue<Samochod>();
            public static Queue<Samochod> kolejkaDoMechanikaUprzywilejowana = new Queue<Samochod>();

            public MechanikSamochodowy(String nazwa)
            {
                this.nazwa = nazwa;
            }

            public void naprawa(Samochod samochod)
            {

            if (nazwa.Equals("Mechanik1"))
                {
                    Samochod.form.dodMech1(samochod.nazwa);
                }
            else
                {
                    Samochod.form.dodMech2(samochod.nazwa);
                }
            if (samochod.uprzywilejowany == 0)
            {
                Samochod.form.usunZkolejkiMech(samochod.nazwa);
            }
            else {
                Samochod.form.usunZkolejkiMechP(samochod.nazwa);

            }

            Thread.Sleep(2000);

            Console.WriteLine("Samochod {0} wjedza do mechanika, uprzywilejowany = {1}", samochod.nazwa, samochod.uprzywilejowany);
                if (rand.Next(0, 3) == 1 && samochod.czesci == 0)
                {
                    Console.WriteLine("    Samochod {0} Potrzebuje czesci", samochod.nazwa);
                   
                    samochod.czesci = 0;
                }
                else
                {
                    Console.WriteLine("    Samochod {0} Naprawiony", samochod.nazwa);
                    samochod.czesci = 1;
                }

                if (samochod.czesci == 0)
                {
                    Console.WriteLine("    Samochod {0} dodany do kolejki uprzywilejowanej", samochod.nazwa);
                    Samochod.form.dodajDokolejkiMechP(samochod.nazwa);
                    

                    samochod.czesci = 1;
                    samochod.uprzywilejowany = 1;
                    dodajDoKolejki(samochod);
                }

            if (nazwa.Equals("Mechanik1"))
            {
                Samochod.form.usuMech1(samochod.nazwa);
            }
            else
            {
                Samochod.form.usuMech2(samochod.nazwa);
            }


        }

            public void obsluga()
            {

                while (true)
                {
                    samochod = null;
                    lock (kolejkaDoMechanikaUprzywilejowana)
                    {
                        lock (kolejkaDoMechanika)
                        {
                            if (kolejkaDoMechanikaUprzywilejowana.Count > 0)
                            {
                                samochod = kolejkaDoMechanikaUprzywilejowana.Dequeue();
                                Console.WriteLine("Samochod {0} pobrany do mechanika={1} z listy uprzywilejowany", samochod.nazwa, nazwa);
                                
                                
                            }
                            else if (kolejkaDoMechanika.Count > 0)
                            {
                                samochod = kolejkaDoMechanika.Dequeue();
                                Console.WriteLine("Samochod {0} pobrany do mechanika={1} z listy zwyklej", samochod.nazwa, nazwa);
                             
                                
                            }
                        }
                    }
                    if (samochod != null)
                    {
                        this.naprawa(samochod);
                    }

                }
            }

            public static void dodajDoKolejki(Samochod samochod)
            {
                lock (kolejkaDoMechanikaUprzywilejowana)
                {
                    if (samochod.uprzywilejowany == 1)
                    {
                        Console.WriteLine("Samochod {0} dodany do kolejki uprzywilejowany", samochod.nazwa);
                        kolejkaDoMechanikaUprzywilejowana.Enqueue(samochod);
                    }
                }
                lock (kolejkaDoMechanika)
                {
                    if (samochod.uprzywilejowany == 0)
                    {
                        Console.WriteLine("Samochod {0} dodany do kolejki zwyklej", samochod.nazwa);
                        kolejkaDoMechanika.Enqueue(samochod);
                    }
                }
            }
    }

        class StacjaDiagnostyczna
        {
            public String nazwa { get; set; }
            public static Queue<Samochod> kolejkaDoStacjiDiagnostycznej= new Queue<Samochod>();

            public StacjaDiagnostyczna(String nazwa)
            {
                this.nazwa = nazwa;
            }

            public void dodajDoKolejki(Samochod samochod)
            {
                kolejkaDoStacjiDiagnostycznej.Enqueue(samochod);
            }

            public void obsluga()
            {
                Samochod samDoObslugi;
                Random rand = new Random();
                while (true)
                {
                    if (kolejkaDoStacjiDiagnostycznej.Count != 0)
                    {

                        
                        samDoObslugi = kolejkaDoStacjiDiagnostycznej.Dequeue();
                        Samochod.form.usunZkolejkiDia(samDoObslugi.nazwa);
                        Samochod.form.dodDiagnostyka(samDoObslugi.nazwa);
                        Thread.Sleep(2200);
                        Console.WriteLine("Samochod {0} pobrany do stacji diagnostycznej={1}", samDoObslugi.nazwa, nazwa);
                     
                        if (rand.Next(0, 3) == 1)
                        {
                            samDoObslugi.uprzywilejowany = 1;
                            Console.WriteLine("Samochod {0} ze stacji diagnostycznej={1} do kolejki uprzywilejowanej", samDoObslugi.nazwa, nazwa);
                            Samochod.form.dodajDokolejkiMechP(samDoObslugi.nazwa);
                            MechanikSamochodowy.dodajDoKolejki(samDoObslugi);
                        }
                        else
                        {
                            Console.WriteLine("Samochod {0} sprawdzony w stacji diagnostycznej={1} WSZYSTKO OK", samDoObslugi.nazwa, nazwa);
                            
                        }
                        Samochod.form.usuDiagnostyka(samDoObslugi.nazwa);

                }
                }



            }

        }

        class StacjaLakierniczoBlacharska
        {
            public String nazwa { get; set; }
            public static Queue<Samochod> kolejkaDoBlacha=new Queue<Samochod>();

            public StacjaLakierniczoBlacharska(String nazwa)
            {
                this.nazwa = nazwa;
            }

            public void dodajDoKolejki(Samochod samochod)
            {
                kolejkaDoBlacha.Enqueue(samochod);
            }

            public void obsluga()
            {
                Samochod samDoObslugi;
                while (true)
                {
                    if (kolejkaDoBlacha.Count != 0)
                    {
                   
                        samDoObslugi = kolejkaDoBlacha.Dequeue();
                        Samochod.form.usunZkolejkiBla(samDoObslugi.nazwa);
                        Samochod.form.dodBlacharstwo(samDoObslugi.nazwa);

                        Console.WriteLine("Samochod {0} pobrany do stacji Stacja Lakierniczo Blacharska={1}", samDoObslugi.nazwa, nazwa);
                        Thread.Sleep(700);

                        {
                            Console.WriteLine("Samochod {0} naprawiony Stacja Lakierniczo Blacharska={1} ", samDoObslugi.nazwa, nazwa);
                           
                        }

                    Samochod.form.usuBlacharstwo(samDoObslugi.nazwa);

                }
                }



            }

        }

        class Samochod
        {
           public static Form1 form;

        public String nazwa { get; set; }
            public int uprzywilejowany { get; set; } // jezeli 1 to znaczy ze ma pojsc jako pierwszy do kolejki
            public int czesci { get; set; } // jezeli 1 to znaczy ze sa czesci jezeli 0 to znaczy ze nie ma czesci na magazynie

            public Samochod(String nazwa)
            {
                this.nazwa = nazwa;
                czesci = 0;
                uprzywilejowany = 0;
                
            }

        public static void setForm(Form1 fo) {
            form = fo;
        }
       
               
    }

        //class Program
        //{
        //    public static Random random = new Random();
        //    static void Main(string[] args)
        //    {
        //        MechanikSamochodowy mechanik1 = new MechanikSamochodowy("Mechanik1");
        //        MechanikSamochodowy mechanik2 = new MechanikSamochodowy("Mechanik2");
        //        StacjaDiagnostyczna stacjaDiagnostyczna = new StacjaDiagnostyczna("Stacja diagnostyczna1");
        //        StacjaLakierniczoBlacharska stacjaLakierniczoBlacharska = new StacjaLakierniczoBlacharska("Stacja Lakierniczo Blacharska1");

        //        Console.WriteLine("SWERWIS");
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Samochod samochod = new Samochod("Samochod." + i);
        //            Console.WriteLine("Samochod {0} UTWORZONY", samochod.nazwa);
        //            int r = random.Next(0, 3);
        //            if (r == 1)
        //            {
        //                stacjaDiagnostyczna.dodajDoKolejki(samochod);
        //            }
        //            else if (r == 2)
        //            {
        //                stacjaLakierniczoBlacharska.dodajDoKolejki(samochod);
        //            }
        //            else
        //            {
        //                MechanikSamochodowy.dodajDoKolejki(samochod);
        //            }
        //        }

        //        Thread t = new Thread(new ThreadStart(mechanik1.obsluga));
        //        Thread t1 = new Thread(new ThreadStart(mechanik2.obsluga));
        //        Thread t2 = new Thread(new ThreadStart(stacjaDiagnostyczna.obsluga));
        //        Thread t3 = new Thread(new ThreadStart(stacjaLakierniczoBlacharska.obsluga));

        //        t.Start();
        //        t1.Start();
        //        t2.Start();
        //        t3.Start();

        //    }
        //}
    

}
