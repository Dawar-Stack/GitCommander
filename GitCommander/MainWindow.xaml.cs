using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace GitCommander
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

        private void kingsLogoClicked(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Process.Start("http://kings.technology/");
            }
            catch
            {
                MessageBox.Show("Something went wrong.", "Git Commander",
MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }
        private void GitLogoClicked(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Process.Start("https://github.com/");
            }
            catch
            {
                MessageBox.Show("Something went wrong.", "Git Commander",
    MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }
        private void initializationClicked(object sender, MouseButtonEventArgs e)
        {
            togglePanle(this.intializationPanel);
        }
        private void cloneClicked(object sender, MouseButtonEventArgs e)
        {
            togglePanle(this.clonePanel);
        }
        private void repoClicked(object sender, MouseButtonEventArgs e)
        {
            togglePanle(this.RepositryPanel);
        }
        private void pullClicked(object sender, MouseButtonEventArgs e)
        {
            togglePanle(this.pullPanel);
        }
        private void pushClicked(object sender, MouseButtonEventArgs e)
        {
            togglePanle(this.pushPanel);
        }
        private void branchClicked(object sender, MouseButtonEventArgs e)
        {
            togglePanle(this.branchPanel);
        }
        void hideAllPanels()
        {
            this.intializationPanel.Visibility = Visibility.Hidden;
            this.pullPanel.Visibility = Visibility.Hidden;
            this.pushPanel.Visibility = Visibility.Hidden;
            this.RepositryPanel.Visibility = Visibility.Hidden;
            this.branchPanel.Visibility = Visibility.Hidden;
            this.clonePanel.Visibility = Visibility.Hidden;
        }
        void togglePanle(Grid panel)
        {
            this.hideAllPanels();
            if (panel==this.intializationPanel)
            {
                this.intializationPanel.Visibility = Visibility.Visible;
            }else if(this.pushPanel==panel)
            {
                this.pushPanel.Visibility = Visibility.Visible;
            }else if(this.pullPanel==panel)
            {
                this.pullPanel.Visibility = Visibility.Visible;
            }else if(this.RepositryPanel==panel)
            {
                this.RepositryPanel.Visibility = Visibility.Visible;
            }else if(this.branchPanel==panel)
            {
                this.branchPanel.Visibility = Visibility.Visible;
            }else if(this.clonePanel==panel)
            {
                this.clonePanel.Visibility = Visibility.Visible;
            }
            
        }
    }
}
