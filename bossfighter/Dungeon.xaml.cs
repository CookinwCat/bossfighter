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
using System.Windows.Shapes;
using bossfighter;

namespace bossfighter
{
    public partial class Dungeon : Window
    {
        public string user;
        public bool chlast = false;
        public Dungeon()
        {
            InitializeComponent();
        }

        private void continue_Click(object sender, RoutedEventArgs e)
        {

        }

        private void inflace_Click(object sender, RoutedEventArgs e)
        {
            chlast = true;
            Random dmg = new Random();
            int damage = dmg.Next(10, 20);
            allyHealth.Value = allyHealth.Value - damage;
            if (allyHealth.Value < 1)
            {
                MessageBox.Show("YOU LOSE :C");
            }
            allyHP.Content = allyHealth.Value;
            enemyHP.Content = enemyHealth.Value;
        }

        private void mafie_Click(object sender, RoutedEventArgs e)
        {
            Random dmg = new Random();
            int damage = dmg.Next(10, 20);
            if(chlast == true)
            {
                enemyHealth.Value = enemyHealth.Value - 2 * damage;
            }
            else
            {
                enemyHealth.Value = enemyHealth.Value - damage;
            }
            chlast = false;
            if (enemyHealth.Value < 1)
            {
                MessageBox.Show("YOU WIN :3");
            }
            Random dmg2 = new Random();
            int damage2 = dmg.Next(10, 20);
            allyHealth.Value = allyHealth.Value - damage2;
            if (allyHealth.Value < 1)
            {
                MessageBox.Show("YOU LOSE :C");
            }
            allyHP.Content = allyHealth.Value;
            enemyHP.Content = enemyHealth.Value;

        }

        private void alkohol_Click(object sender, RoutedEventArgs e)
        {
            Random HP = new Random();
            int heal = HP.Next(12, 18);
            allyHealth.Value = allyHealth.Value + heal;

            Random dmg = new Random();
            int damage = dmg.Next(10, 20);
            allyHealth.Value = allyHealth.Value - damage;
            if (allyHealth.Value < 1)
            {
                MessageBox.Show("YOU LOSE :C");
            }
            allyHP.Content = allyHealth.Value;
            enemyHP.Content = enemyHealth.Value;
        }
    }
}
