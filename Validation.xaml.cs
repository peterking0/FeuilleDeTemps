using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Windows.Forms.AxHost;

namespace FeuilleDeTemps
{
    /// <summary>
    /// Interaction logic for Validation.xaml
    /// </summary>
    public partial class Validation : Window
    { string dept = "PRODUCTION";
      string depta = "ADMINISTRATION";
      string depts = "EXPLOITATION";
      string dapts = "INTROUVABLE";
      string Teletravail = "TeleTravail";
        string Message = "Il n'est pas possible de charger plus ou moins de 420 minutes car le congé doit s'appliquer pour une journée entière" ;
        string maladie ="999";
        string conge ="998";
        int heuresTotale = 0;
        int codeProjet1 = 0;
        int codeProjet2 = 0;
        int codeProjet3 = 0;
        int codeProjet4 = 0;
        int codeProjet5 = 0;
        int codeProjet6 = 0;
        int codeProjet7 = 0;
        int heureProjet1 = 0;
        int heureProjet2 = 0;
        int heureProjet3 = 0;
        int heureProjet4 = 0;
        int heureProjet5 = 0;
        int heureProjet6 = 0;
        int heureProjet7 = 0;
        string nom = "";
        int nume = 0;
        bool a = false;
        public Validation()
        {
            InitializeComponent();
            try
            {

                string Jsonfile = File.ReadAllText(@"emploi.json");
                Rootobject de = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(Jsonfile);
                nom = de.nomEmplyes;
                nume = de.numeroEmplyes;
               
            }
            catch (Exception)
            {

                MessageBox.Show("Numero projet et heure minimale requis");
            }
           
        }

        
       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                string Jsonfile = File.ReadAllText(@"emploi.json");

                Rootobject de = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(Jsonfile);
                Console.WriteLine(de);




                Console.WriteLine("Nom = " + de.nomEmplyes + " Numero =  " + de.numeroEmplyes);



                heuresTotale = 0;

                foreach (Lundi state in de.Lundi)
            {
                // The `state` variable takes on the value of an element in `states` and updates every iteration.
                Console.WriteLine("code1= "+state.code1 + " projet1 = " +state.projet1);
                heuresTotale += state.projet1;
                 codeProjet1=state.code1;
                    if (state.projet1 > 24) { MessageBox.Show("On peut pas depasser 24h par jours"); }

                }

            foreach (Mardi state in de.Mardi)
            {
                // The `state` variable takes on the value of an element in `states` and updates every iteration.
                Console.WriteLine("code2= " + state.code2 + " projet2 = " + state.projet2);
                heuresTotale += state.projet2;
                codeProjet2=state.code2;
              if (state.projet2 > 24) { MessageBox.Show("On peut pas depasser 24h par jours"); }
            }
            foreach (Mercredi state in de.Mercredi)
            {
                // The `state` variable takes on the value of an element in `states` and updates every iteration.
                Console.WriteLine("code3= " + state.code3 + " projet3 = " + state.projet3);
                heuresTotale += state.projet3;
                codeProjet3=state.code3;    
                    if (state.projet3 > 24) { MessageBox.Show("On peut pas depasser 24h par jours"); }
            }
            foreach (Jeudi state in de.Jeudi)
            {
                // The `state` variable takes on the value of an element in `states` and updates every iteration.
                Console.WriteLine("code4= " + state.code4 + " projet4 = " + state.projet4);
                heuresTotale += state.projet4;
                codeProjet4=state.code4;    
               if (state.projet4 > 24) { MessageBox.Show("On peut pas depasser 24h par jours"); }
            }
            foreach (Vendredi state in de.Vendredi)
            {
                // The `state` variable takes on the value of an element in `states` and updates every iteration.
                Console.WriteLine("code5= " + state.code5 + " projet5 = " + state.projet5);
                heuresTotale += state.projet5;
                codeProjet5=state.code5;    
                    if (state.projet5 > 24) { MessageBox.Show("On peut pas depasser 24h par jours"); }
            }
            foreach (Samedi state in de.Samedi)
            {
                // The `state` variable takes on the value of an element in `states` and updates every iteration.
                Console.WriteLine("code6= " + state.code6 + " projet6 = " + state.projet6);
                heuresTotale += state.projet6;
                codeProjet6=state.code6;

                    if (state.projet6 > 24) { MessageBox.Show("On peut pas depasser 24h par jours"); }
            }
            foreach (Dimanche state in de.Dimanche)
            {
                // The `state` variable takes on the value of an element in `states` and updates every iteration.
                Console.WriteLine("code7= " + state.code7 + " projet7 = " + state.projet7);
                heuresTotale += state.projet7;
                 codeProjet7=state.code7;
                    if (state.projet7 > 24) { MessageBox.Show("On peut pas depasser 24h par jours"); }
            }
              if (de.numeroEmplyes >= 1000 && de.numeroEmplyes < 2000)
                {
                    txtlistsDept.DataContext = dept.ToString();
                }
               else if (de.numeroEmplyes >= 2000)
                {
                    txtlistsDept.DataContext = depts.ToString();
                }
                else if (de.numeroEmplyes < 1000)
                {
                    txtlistsDept.DataContext = depta.ToString();
                }
                else
                {
                    txtlistsDept.DataContext = dapts.ToString();
                }

                Console.WriteLine(heuresTotale);
                txtlistCongemaladie.DataContext = maladie.ToString();
                txtlistCongeFerier.DataContext = conge.ToString();

                if (heuresTotale > 7 | heuresTotale < 7)
                {
                    a = true;
                    Console.WriteLine(Message);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("le fichier na pa ete trouver");
                Console.WriteLine("le fichier na pa ete trouver");
                Console.Read();
            }
           

            
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtlists.DataContext = nume.ToString();
            txtlist1.DataContext =nom.ToString();
            txtlist2.DataContext = heuresTotale.ToString();
        }



        private void uploadFichierJson_Click_1(object sender, RoutedEventArgs e)
        {
            string Jsonfile = File.ReadAllText(@"emploi.json");
            Rootobject de = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(Jsonfile);

           
            check2.IsChecked = true;
            check3.IsChecked = true;
           
            if (de.numeroEmplyes >= 2000)
            {
               
                if (heuresTotale < 38)
                {
                    check1.IsChecked = false;
                    MessageBox.Show("Un employer d'exploitation doit travailler minimale 38h semaine");
                }
                else { check1.IsChecked = true; }

            } else if (de.numeroEmplyes < 1000)
            {
                if (heuresTotale < 36)
                {
                    check1.IsChecked = false;
                    MessageBox.Show("Un employer Administration doit travailler minimum 36h semaine");
                }
                else { check1.IsChecked = true; }
            }
           
            MessageBox.Show("L'employe " + nom + " a ete valider avec succes");
            
        }

        private void btnConger_Click(object sender, RoutedEventArgs e)
        {
           
            if (codeProjet1 == 999)
            {
                  if (a == false)
                {
                    if (codeProjet6 == 0 && codeProjet7 == 0)
                    {
                        if (codeProjet2 == 0 && codeProjet3 == 0 && codeProjet4 == 0 && codeProjet5 == 0)
                        {
                            checkM.IsChecked = true;
                            MessageBox.Show("Conger Maladie Accepter");

                        }
                        else { MessageBox.Show("il nest pas permis de travailler sur dautre projet la semaine"); }

                    }
                    else { MessageBox.Show("Il n'est pas permis d'utiliser les congés de maladie la fin de semaine"); }

                }
                else { MessageBox.Show(Message); }


            }




            else if (codeProjet1 == 998)
            {
                if (codeProjet7 == 0 && codeProjet6 == 0)
                {
                    if (heureProjet1 == 7)
                    {

                    }
                    checkF.IsChecked = true;
                    MessageBox.Show("Conger Ferie Accepter");
                    MessageBox.Show("il est permis de faire du télétravail en plus durant la journée");
                    txtlistsDept.DataContext = Teletravail.ToString();

                }
                else { MessageBox.Show("Il n'est pas permis d'utiliser les congés fériés la fin de semaine"); }


            }

            if (codeProjet2 == 999)
            {
                if (a == false)
                {
                    if (codeProjet6 == 0 && codeProjet7 == 0)
                    {
                        if (codeProjet1 == 0 && codeProjet3 == 0 && codeProjet4 == 0 && codeProjet5 == 0)
                        {
                            checkM.IsChecked = true;
                            MessageBox.Show("Conger Maladie Accepter");

                        }
                        else { MessageBox.Show("il nest pas permis de travailler sur dautre projet la semaine"); }

                    }
                    else { MessageBox.Show("Il n'est pas permis d'utiliser les congés de maladie la fin de semaine"); }

                }
                else { MessageBox.Show(Message); }


            }




            else if (codeProjet2 == 998)
            {
                if (codeProjet7 == 0 && codeProjet6 == 0)
                {
                    if (heureProjet2 == 7)
                    {

                    }
                    checkF.IsChecked = true;
                    MessageBox.Show("Conger Ferie Accepter");
                    MessageBox.Show("il est permis de faire du télétravail en plus durant la journée");
                    txtlistsDept.DataContext = Teletravail.ToString();

                }
                else { MessageBox.Show("Il n'est pas permis d'utiliser les congés fériés la fin de semaine"); }


            }

            if (codeProjet3 == 999)
            {
                if (a == false)
                {
                    if (codeProjet6 == 0 && codeProjet7 == 0)
                    {
                        if (codeProjet2 == 0 && codeProjet1 == 0 && codeProjet4 == 0 && codeProjet5 == 0)
                        {
                            checkM.IsChecked = true;
                            MessageBox.Show("Conger Maladie Accepter");

                        }
                        else { MessageBox.Show("il nest pas permis de travailler sur dautre projet la semaine"); }

                    }
                    else { MessageBox.Show("Il n'est pas permis d'utiliser les congés de maladie la fin de semaine"); }

                }
                else { MessageBox.Show(Message); }


            }




            else if (codeProjet3 == 998)
            {
                if (codeProjet7 == 0 && codeProjet6 == 0)
                {
                    if (heureProjet3 == 7)
                    {

                    }
                    checkF.IsChecked = true;
                    MessageBox.Show("Conger Ferie Accepter");
                    MessageBox.Show("il est permis de faire du télétravail en plus durant la journée");
                    txtlistsDept.DataContext = Teletravail.ToString();

                }
                else { MessageBox.Show("Il n'est pas permis d'utiliser les congés fériés la fin de semaine"); }


            }





            if (codeProjet4 == 999)
            {
                if (a == false)
                {
                    if (codeProjet6 == 0 && codeProjet7 == 0)
                    {
                        if (codeProjet2 == 0 && codeProjet3 == 0 && codeProjet1 == 0 && codeProjet5 == 0)
                        {
                            checkM.IsChecked = true;
                            MessageBox.Show("Conger Maladie Accepter");

                        }
                        else { MessageBox.Show("il nest pas permis de travailler sur dautre projet la semaine"); }

                    }
                    else { MessageBox.Show("Il n'est pas permis d'utiliser les congés de maladie la fin de semaine"); }

                }
                else { MessageBox.Show(Message); }


            }




            else if (codeProjet4 == 998)
            {
                if (codeProjet7 == 0 && codeProjet6 == 0)
                {
                    if (heureProjet4 == 7)
                    {

                    }
                    checkF.IsChecked = true;
                    MessageBox.Show("Conger Ferie Accepter");
                    MessageBox.Show("il est permis de faire du télétravail en plus durant la journée");
                    txtlistsDept.DataContext = Teletravail.ToString();

                }
                else { MessageBox.Show("Il n'est pas permis d'utiliser les congés fériés la fin de semaine"); }
           }




            if (codeProjet5== 999)
            {
                if (a == false)
                {
                    if (codeProjet6 == 0 && codeProjet7 == 0)
                    {
                        if (codeProjet2 == 0 && codeProjet3 == 0 && codeProjet4 == 0 && codeProjet1 == 0)
                        {
                            checkM.IsChecked = true;
                            MessageBox.Show("Conger Maladie Accepter");

                        }
                        else { MessageBox.Show("il nest pas permis de travailler sur dautre projet la semaine"); }

                    }
                    else { MessageBox.Show("Il n'est pas permis d'utiliser les congés de maladie la fin de semaine"); }

                }
                else { MessageBox.Show(Message); }


            }




            else if (codeProjet5 == 998)
            {
                if (codeProjet7 == 0 && codeProjet6 == 0)
                {
                    if (heureProjet5 == 7)
                    {

                    }
                    checkF.IsChecked = true;
                    MessageBox.Show("Conger Ferie Accepter");
                    MessageBox.Show("il est permis de faire du télétravail en plus durant la journée");
                    txtlistsDept.DataContext = Teletravail.ToString();

                }
                else { MessageBox.Show("Il n'est pas permis d'utiliser les congés fériés la fin de semaine"); }


            }
        }

    }



}
