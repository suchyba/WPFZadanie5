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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFZadanie5
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Collection<User> Users { get; } = new ObservableCollection<User>();
        private List<string> regions;
        public MainWindow()
        {
            InitializeComponent();
            regions = new List<string>{
                "Białystok", "Warszawa", "Kraków", "Opole", "Wrocław", "Małopolska", "Ślónsk"
            };
            RegionComboBox.ItemsSource = regions;
            UsersListView.ItemsSource = Users;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsersListView.SelectedItems != null)
                Users.RemoveAt(UsersListView.SelectedIndex);
        }

        private void UsersListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Users.Add(new User { Name = "brak", Surname = "brak" });
            UsersListView.SelectedIndex = Users.Count - 1;
            NameTextBox.SelectAll();
            NameTextBox.Focus();
        }
    }
}
