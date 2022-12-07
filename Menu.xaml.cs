using System;
using System.Collections.Generic;
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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void AddMed_Click(object sender, RoutedEventArgs e)
        {
            SectionEmployes add = new SectionEmployes();
            add.ShowDialog();
        }



        private void AjoutNouP_Click(object sender, RoutedEventArgs e)
        {
            SectionPatron ajoutNou = new SectionPatron();
            ajoutNou.ShowDialog();
        }

        private void rechercheP_Click(object sender, RoutedEventArgs e)
        {
            SectionEmployes recherchePatient = new SectionEmployes();
            recherchePatient.ShowDialog();
        }

       


        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtusername.Text == "" && txtpassword.Text == "")
            {
                SectionEmployes prepo = new SectionEmployes();
                prepo.ShowDialog();
            }
            else if (txtusername.Text == "1" && txtpassword.Text == "1")
            {
                SectionPatron med = new SectionPatron();
                med.ShowDialog();
            }
            else
            {
                MessageBox.Show("Entrer un mot passe correct");
            }

        }
    }
}

