using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.ComponentModel;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Printing;

namespace MVMM
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
    }

    class Store
    {
        public string Name { get; set; }
        public string Prefecture { get; set; }
        public int FavoriteCount { get; set; }
    }


    class MainViewModel
    {
        public MainViewModel()
        {
            this.Mall = Enumerable.Range(1 ,20).Select(x => new Store()
            {
                Name = "お店" +x,
                Prefecture = "岩手県",
                FavoriteCount = x * 10,

            }).ToList();
        }

        public List<Store> Mall { get; set; }

        public override string ToString()
        {
            return "やあ。";
        }
    }
}