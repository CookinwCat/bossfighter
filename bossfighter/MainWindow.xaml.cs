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
using bossfighter;

namespace bossfighter
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void continue_Click(object sender, RoutedEventArgs e)
        {
            string user = user1.Text.ToString();
            if (user == "")
            {
                user = "Player1";
            }
            Dungeon dungeon = new Dungeon();
            dungeon.Show();
            dungeon.jmeno.Text = user;
            this.Close();
        }

        private void Label_KeyDown(object sender, KeyEventArgs e) { if(e.Key == Key.Enter) { continue_Click(sender, e); } }
    }
}
