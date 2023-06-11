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

namespace Practice_Work_9._5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string ReverseWords(string text)
        {
            string[] words = text.Split(' ');
            Array.Reverse(words);
            string result = String.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                result += words[i] + " ";
            }
            return result;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string sentence = Sentence.Text;
            Words.ItemsSource = sentence.Split(' ');
        }

        private void bReverse(object sender, RoutedEventArgs e)
        {
            string sentence = Sentence.Text;
            Revers.Content = ReverseWords(sentence);
        }
    }
}
