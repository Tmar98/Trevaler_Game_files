using System;
using System.Collections.Generic;
using System.Linq;
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


namespace Trevaler_Game_files
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Hero hero;
        private Monster monster;
        public MainWindow()
        {
            InitializeComponent();

            hero = new Hero("Герой 1",5,30);
            monster = new Monster("Монстр 1",2,16);

            Hero_Name.Text = hero.Name;
            Monster_Name.Text = monster.Name;

        }

        private void Hero_Atack_Click(object sender, RoutedEventArgs e)
        {
            if (monster.HP != 0)
            {
                monster.HP = hero.Decrease_HP(monster.HP, hero.Strenght);
                Hero_Atack.IsEnabled = false;
                Monster_Atack.IsEnabled = true;
                if(monster.HP==0)
                {
                    var g= MessageBox.Show("Ты убил его","",MessageBoxButton.OK);
                    if (g == MessageBoxResult.OK)
                    Close();
                }
            }
        }

        private void Monster_Atack_Click(object sender, RoutedEventArgs e)
        {
            hero.HP = monster.Decrease_HP(hero.HP, monster.Strenght);
            Hero_Atack.IsEnabled = true;
            Monster_Atack.IsEnabled = false;
        }
    }
}
