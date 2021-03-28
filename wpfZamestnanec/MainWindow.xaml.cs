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
using System.Text.RegularExpressions;

namespace wpfZamestnanec
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

        private void switchFormButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }

    public class Osoba
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthYear { get; set; }

        public Osoba(string _name, string _surname, int _birthYear)
        {
            Name = _name;
            Surname = _surname;
            BirthYear = _birthYear;
        }
    }

    public class Zamestanec : Osoba
    {
        public string HighestEducation { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        public Zamestanec(string _name, string _surname, int _birthYear, string _highestEducation, string _position, int _salary) : base(_name, _surname, _birthYear)
        {
            HighestEducation = _highestEducation;
            Position = _position;
            Salary = _salary;   
        }
    }
}

