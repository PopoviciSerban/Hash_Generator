using System;
using System.Collections.Generic;
using System.Linq;
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
using System.IO;
using System.Text;
using Microsoft.Win32;
using System.Security.Cryptography;

namespace Hash_Generator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
                TextBox1.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(TextBox1.Text);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                for (int i = 0; i < hashBytes.Length; i++)
                    sb.Append(hashBytes[i].ToString("X2"));
            }

            TextBox2.Text = sb.ToString();
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            using (RIPEMD160 ripedmd160 = RIPEMD160.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(TextBox1.Text);
                byte[] hashBytes = ripedmd160.ComputeHash(inputBytes);

                for (int i = 0; i < hashBytes.Length; i++)
                    sb.Append(hashBytes[i].ToString("X2"));
            }

            TextBox2.Text = sb.ToString();
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(TextBox1.Text);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);

                for (int i = 0; i < hashBytes.Length; i++)
                    sb.Append(hashBytes[i].ToString("X2"));
            }

            TextBox2.Text = sb.ToString();
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(TextBox1.Text);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                for (int i = 0; i < hashBytes.Length; i++)
                    sb.Append(hashBytes[i].ToString("X2"));
            }

            TextBox2.Text = sb.ToString();
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            using (SHA384 sha384 = SHA384.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(TextBox1.Text);
                byte[] hashBytes = sha384.ComputeHash(inputBytes);

                for (int i = 0; i < hashBytes.Length; i++)
                    sb.Append(hashBytes[i].ToString("X2"));
            }

            TextBox2.Text = sb.ToString();
        }

        private void ListBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(TextBox1.Text);
                byte[] hashBytes = sha512.ComputeHash(inputBytes);

                for (int i = 0; i < hashBytes.Length; i++)
                    sb.Append(hashBytes[i].ToString("X2"));
            }

            TextBox2.Text = sb.ToString();
        }
    }
}
