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
using System.Reflection;
using System.Windows.Forms;
using EasyBuilder.Classes;

namespace EasyBuilder
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog FolderDialog = new FolderBrowserDialog();

            if (FolderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folderPath = FolderDialog.SelectedPath;
                ProjectDirectory.Text = folderPath;
            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            Copier copier = new Copier();
            copier.Copy(ProjectDirectory.Text, "C:\\Users\\User\\Desktop\\sth");
        }
    }
}
