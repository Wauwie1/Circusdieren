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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Circusdieren
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Dier> dieren = new List<Dier>();
        Trein trein;
        public MainWindow()
        {
            InitializeComponent();
            trein = new Trein();
            AddDieren();
            trein.CreateTrein(dieren);
        }

        private void AddDieren()
        {
            Dier panda = new Dier(5, false);
            Dier tijger = new Dier(5, true);
            Dier tijger2 = new Dier(5, true); 
            Dier tijger3 = new Dier(5, true);
            Dier egel = new Dier(1, false);
            Dier varken = new Dier(3, false);
            Dier kat = new Dier(1, true);
            Dier hond = new Dier(3, true);

            dieren.Add(panda);
            dieren.Add(tijger);
            dieren.Add(tijger2);
            dieren.Add(tijger3);
            dieren.Add(egel);
            dieren.Add(varken);
            dieren.Add(kat);
            dieren.Add(hond);
        }
    }
}
