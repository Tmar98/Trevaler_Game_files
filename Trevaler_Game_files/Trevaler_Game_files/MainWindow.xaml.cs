using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.IO;
using System.Xml.Serialization;
using Trevaler_Game_files.Person_child;
using Trevaler_Game_files.Terretory_Files;



namespace Trevaler_Game_files
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Hero hero;
        private Monster monster;
        //private string FileName = @"Monsters.xml";
        public MainWindow()
        {
            InitializeComponent();

            hero = new Hero("Герой 1",5,30);
            monster = new Monster("Монстр 1",2,16);
            
            
            
            #region тест територии 
            List<Monster> monsters2 = new List<Monster>();
            monsters2.Add(monster);
            monster = new Monster("Монстр 2", 2, 16);
            monsters2.Add(monster);
            Terretory terretory = new Terretory("болото",monsters2);
            #endregion

            List<Monster> monsters = new List<Monster>();
            monsters.Add(monster);

            #region рандомное появление монстра
            //monster = new Monster("Монстр 2", 2, 16);
            //monsters.Add(monster);

            //var rand = new Random();
            //var randmonster = rand.Next(0, monsters.Count);
            //Monster_Name.Text = monsters[randmonster].Name;
            #endregion

            Hero_Name.Text = hero.Name;
            Monster_Name.Text = monster.Name;


            #region сериализатор
            //List<Monster> monsters = new List<Monster>();
            //monsters.Add(monster);

            //var serializer = new XmlSerializer(typeof(List<Monster>));

            //using (var fs = new FileStream(FileName, FileMode.OpenOrCreate))
            //{
            //    serializer.Serialize(fs, monsters);
            //}
            //MessageBox.Show("ok");
            #endregion

        }

        private void Hero_Atack_Click(object sender, RoutedEventArgs e)
        {
            if (monster.Stats.HP != 0)
            {
                monster.Stats.HP = hero.Decrease_HP(monster.Stats.HP, hero.Stats.Strenght);
                Hero_Atack.IsEnabled = false;
                Monster_Atack.IsEnabled = true;
                if(monster.Stats.HP==0)
                {
                    var g= MessageBox.Show("Ты убил его","",MessageBoxButton.OK);
                    if (g == MessageBoxResult.OK)
                    Close();
                }
            }
        }

        private void Monster_Atack_Click(object sender, RoutedEventArgs e)
        {
            hero.Stats.HP = monster.Decrease_HP(hero.Stats.HP, monster.Stats.Strenght);
            Hero_Atack.IsEnabled = true;
            Monster_Atack.IsEnabled = false;
        }
    }
}
