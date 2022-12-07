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
    /// Interaction logic for SectionEmployes.xaml
    /// </summary>
    public partial class SectionEmployes : Window
    {
        public SectionEmployes()
        {
            InitializeComponent();
        }

        private void Remplir_Click(object sender, RoutedEventArgs e)
        {
            Enregistrement enregistrement = new Enregistrement();
             enregistrement.ShowDialog();
        }
    }
}
