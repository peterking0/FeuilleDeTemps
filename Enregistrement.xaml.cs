using Newtonsoft.Json;
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

namespace FeuilleDeTemps
{
    /// <summary>
    /// Interaction logic for Enregistrement.xaml
    /// </summary>
    public partial class Enregistrement : Window
    {
        public Enregistrement()
        {
            InitializeComponent();


        }

        private void btnEnregistrement_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InitializeComponent();

                
                var Feuille = new

                {
                    numeroEmplyes = Int32.Parse(txtnumero.Text),
                    nomEmplyes = txtnom.Text,

                    Lundi = new[]
                    {
               new  { code1 =  txtcodeLundi.Text, projet1 = txtprojetLundi.Text },

                    },
                    Mardi = new[]
                    {
               new  { code2 = txtcodeMardi.Text, projet2 = txtProjetMardi.Text},

                    },
                    Mercredi = new[]
                    {
               new  { code3 = txtcodeMercredi.Text, projet3 = txtProjetMercredi.Text},

                    },
                    Jeudi = new[]
                    {
               new  { code4 = txtcodejeudi.Text, projet4 =txtProjetJeudi.Text },

                    },
                    Vendredi = new[]
                    {
               new  { code5 = txtcodeVendredi.Text, projet5 = txtProjetvendredi.Text },

                    },
                    Samedi = new[]
                    {
               new  { code6 = txtcodeSamedi.Text, projet6 = txtProjetSamedi.Text },

                    },
                    Dimanche = new[]
                    {
               new  { code7 =txtcodeDimanche.Text, projet7 = txtProjetDimanche.Text },

                    },

                };
                



                string jsonFolder = JsonConvert.SerializeObject(Feuille);
                File.WriteAllText(@"emploi.json", jsonFolder);
                MessageBox.Show("Ficher Enregistre avec succes");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           
           
        }
    }
}
