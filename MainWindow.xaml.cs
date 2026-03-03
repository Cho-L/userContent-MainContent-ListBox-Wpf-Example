using LoginWpfDemo.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginWpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        {
            new Person{ Name = "아무개", Age = 23},
            new Person{ Name = "홍길동", Age = 33},
            new Person{ Name = "김용혁", Age = 13},
            new Person{ Name = "조자룡", Age = 24},
            new Person{ Name = "제갈량", Age = 28}
        };

        public MainWindow()
        {
            InitializeComponent();
            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;
            foreach (var item in selectedItems)
            {
                Person person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }

}
