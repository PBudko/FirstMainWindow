using FirstMainWindow.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FirstMainWindow.SecondView
{
    /// <summary>
    /// Interaction logic for AddSotrudnicWindow.xaml
    /// </summary>
    public partial class AddSotrudnicWindow : Window
    {
        public AddSotrudnicWindow()
        {
            InitializeComponent();
        }

        public AddSotrudnicWindow(ObservableCollection<FilialClass> Filials, ObservableCollection<Sotrudnick> AllSotrudniki)
        {
            
            InitializeComponent();
            foreach(var filial in Filials)
            {
                second.Filials.Add(filial);
            }
            foreach (var sotr in AllSotrudniki)
            {
                second.AallSotrudniki.Add(sotr);
            }

            //sotrudnikListBox1.SelectedItems
        }


    }
}
