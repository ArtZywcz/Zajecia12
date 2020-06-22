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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Zajecia12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Model Model { get; set; } = new Model();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)//TODO blokuje wszystkie inne zmiany?
        {
            this.Resources["Brush"] = new SolidColorBrush(Colors.Blue);
            var res = new ResourceDictionary();
            res.Add("abcd", "efg");
            Resources.MergedDictionaries.Add(res);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            string directory = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
            directory += @"\Dictionary3.xaml";
            if (File.Exists(directory))
            {
                using (FileStream fs = new FileStream(directory, FileMode.Open))
                {
                    ResourceDictionary dic = (ResourceDictionary)XamlReader.Load(fs);

                    Resources.MergedDictionaries.Add(dic);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Model.Zoom += 1;
        }
    }
}
