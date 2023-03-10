using System;
using System.Collections.Generic;
using System.Data;
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

namespace _10_03_2023_Entity_Framework_forum
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void book_Click(object sender, RoutedEventArgs e)
        {
            Gr.ItemsSource = null;
            using (BiblioEntities db = new BiblioEntities())
            {
                var data =db.Book.ToList();
                Gr.ItemsSource = data;
            }
           
        }

        private void author_Click(object sender, RoutedEventArgs e)
        {
            Gr.ItemsSource = null;
            using (BiblioEntities db = new BiblioEntities())
            {
                var data = db.Author.ToList();
                Gr.ItemsSource = data;
            }
        }

        private void publisher_Click(object sender, RoutedEventArgs e)
        {
            Gr.ItemsSource = null;
            using (BiblioEntities db = new BiblioEntities())
            {
                var data = db.Publisher.ToList();
                Gr.ItemsSource = data;
            }

        }

        private void all_Click(object sender, RoutedEventArgs e)
        {
            DataTable Author = new DataTable("Author");
            DataColumn Author_id = new DataColumn("Id", Type.GetType("System.Int32"));
            DataColumn Author_FName = new DataColumn("FirstName", Type.GetType("System.String"));
            DataColumn Author_LName = new DataColumn("LastName", Type.GetType("System.String"));



        } 
    }
}
