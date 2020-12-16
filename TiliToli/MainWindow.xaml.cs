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

namespace TiliToli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int[] allapot = { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
        int[] vege = { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button ezGomb = sender as Button;
            Button nullaGomb = (Button)FindName("Button0");
            
            var fTav = Math.Abs(ezGomb.Margin.Top - nullaGomb.Margin.Top);
            var vTav = Math.Abs(ezGomb.Margin.Left - nullaGomb.Margin.Left);

            
            int Felirat = int.Parse(ezGomb.Content.ToString());
            int Index = Array.IndexOf(allapot, Felirat);
            int nullaindex = Array.IndexOf(allapot, 0);

            if ((fTav == 100 && vTav == 0) || (vTav == 100 && fTav == 0)) {
                var seged = ezGomb.Margin;
                ezGomb.Margin = nullaGomb.Margin;
                nullaGomb.Margin = seged;

                allapot[nullaindex] = allapot[Felirat];
                allapot[Felirat] = 0;

                
                if (allapot.SequenceEqual(vege))
                {
                    
                }
                
            }
        }
    }
}
