using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HeroLogic.World;

using HeroLogic;

namespace HerosTale
{
    public partial class frmBase : Form
    {
        private Player player;
        private Monster Q1Monster;        
        private CreatureLocations Q1Location;
        private Quest1Class Quest1;
        private int tmpStr, tmpDex, tmpInt, tmpChar;
        private const int HEALTH_LEVEL = 500;
        private const int POINTS_LEVEL = 3;
        private bool firstTime = true;
        
        

        public frmBase()
        {
            InitializeComponent();
            pMain.Visible = false;
            pMain.Enabled = false;
            pNameInput.Visible = false;
            pNameInput.Enabled = false;
            pnlLevelUp.Enabled = false;
            pnlLevelUp.Visible = false;
            player = new Player(1, 1, 1, 1, 100, "", 1, 1, 1000, 1000,CreatureType.HumanPeaceful, CreatureClass.Player);
            
            
        }
                
        private void bNewGane_Click(object sender, EventArgs e)
        {
            pNameInput.Visible = true;
            pNameInput.Enabled = true;
            tInputName.Focus();
        }

        private void LevelUp(int points)
        {
            tmpStr = player.Strength;
            tmpDex = player.Dexterity;
            tmpInt = player.Intelligence;
            tmpChar = player.Charisma;

            pnlLevelUp.Enabled = true;
            pnlLevelUp.Visible = true;
            lblLvlPoints.Text = Convert.ToString(points);


        }



        private void CheckLvlUp(int exp, int lvl)
        {
            if (lvl < 20 && exp >= 70000)
            {
                player.Level = 20;

            }
            else if (lvl < 19 && exp >= 62000)
            {
                player.Level = 19;

            }
            else if (lvl < 18 && exp >= 55000)
            {
                player.Level = 18;

            }
            else if (lvl < 17 && exp >= 48000)
            {
                player.Level = 17;

            }
            else if (lvl < 16 && exp >= 43000)
            {
                player.Level = 16;

            }
            else if (lvl < 15 && exp >= 38000)
            {
                player.Level = 15;

            }
            else if (lvl < 14 && exp >= 33000)
            {
                player.Level = 14;

            }
            else if (lvl < 13 && exp >= 28000)
            {
                player.Level = 13;

            }
            else if (lvl < 12 && exp >= 23000)
            {
                player.Level = 12;

            }
            else if (lvl < 11 && exp >= 18000)
            {
                player.Level = 11;

            }
            else if (lvl < 10 && exp >= 13000)
            {
                player.Level = 10;

            }
            else if (lvl < 9 && exp >= 11000)
            {
                player.Level = 9;

            }
            else if (lvl < 8 && exp >= 9000)
            {
                player.Level = 8;

            }
            else if (lvl < 7 && exp >= 7000)
            {
                player.Level = 7;

            }
            else if (lvl < 6 && exp >= 5000)
            {
                player.Level = 6;

            }
            else if (lvl < 5 && exp >= 3000)
            {
                player.Level = 5;

            }
            else if (lvl < 4 && exp >= 2000)
            {
                player.Level = 4;

            }
            else if (lvl < 3 && exp >= 1000)
            {
                player.Level = 3;

            }
            else if (lvl < 2 && exp >= 500)
            {
                player.Level = 2;

            }

            txtMainWindow.Text += $"Congratrulations you are now level {player.Level}!! \r\n";
            ScrollDownText(txtMainWindow);
            player.MaximumHitPoints += (player.Level - lvl) * HEALTH_LEVEL;
            player.CurrentHitPoints = player.MaximumHitPoints;
            txtMainWindow.Text += $"You have gained {(player.Level - lvl) * POINTS_LEVEL} stats point to assign and {(player.Level - lvl) * HEALTH_LEVEL} health. \r\n";
            ScrollDownText(txtMainWindow);
            LevelUp((player.Level - lvl) * POINTS_LEVEL);
            UpdateStats();

        }

        private void UpdateStats()
        {

            lHealthNr.Text = $"{player.CurrentHitPoints}/{player.MaximumHitPoints}";
            lStrNr.Text = Convert.ToString(player.Strength);
            lIntNr.Text = Convert.ToString(player.Intelligence);
            lDexNr.Text = Convert.ToString(player.Dexterity);
            lChrNr.Text = Convert.ToString(player.Charisma);
            lGold.Text = Convert.ToString(player.Gold);
            lLevelNr.Text = Convert.ToString(player.Level);
            lExpTxt.Text = $"{player.ExperiecePoints}";

        }

       
       

        private void  generateQuest1()
        {

            IEnumerable<int> ExtractList = MonstersList();
            Q1Monster = MonsterByID(ExtractList.ElementAt(new Random().Next(0, ExtractList.Count() + 1)));
            Q1Location = LocationByMonsterID(Q1Monster.ID);                        
            Quest1 = new Quest1Class(1, QuestType.Kill, Q1Location.LocationName,CreateGold(), CreatureType.Monster,Q1Monster.ID);
            
        }

        private void Tavern()
        {
            generateQuest1();



            txtMainWindow.Text = "These missions are available: \r\n";
            txtMainWindow.Text += $"1- There is a dangerous {Q1Monster.Name} lurking in the nearby {Q1Location.AreaName}. {Quest1.RewardGold} gold is offered to whoever kills it. \r\n";
            txtMainWindow.Text += $"2- \r\n";
            txtMainWindow.Text += $"3- \r\n";
            txtMainWindow.Text += "4- A caravan is leaving for Marrakesh the most prosperous and wealthy city of this land \r\n";
            int rnd = new Random().Next(0, 7);
            switch (rnd)
            {
                case 0:
                    txtMainWindow.Text += $"{Who.Sister}";
                    break;
                case 1:
                    txtMainWindow.Text += $"{Who.Mother}";
                    break;
                case 2:
                    txtMainWindow.Text += $"{Who.Brother}";
                    break;
                case 3:
                    txtMainWindow.Text += $"{Who.Father}";
                    break;
                case 4:
                    txtMainWindow.Text += $"{Who.Uncle}";
                    break;
                case 5:
                    txtMainWindow.Text += $"{Who.Aunt}";
                    break;

            }


        }

        private async void bOk_Click(object sender, EventArgs e)
        {
            pNameInput.Enabled = false;
            pNameInput.Visible = false;
            pStart.Enabled = false;
            pStart.Visible = false;
            pMain.Enabled = true;
            pMain.Visible = true;

            player.Name = tInputName.Text;
            lHeroName.Text = player.Name;
            UpdateStats();

            txtMainWindow.Text = $"This is the moment to become a hero {player.Name} \r\n";
            txtMainWindow.Text += "\r\n";
            await Task.Delay(2000);
            txtMainWindow.Text += "You start as a puny \"wanna be hero\" barely able to wield a sword and kill a rat \r\n";
            await Task.Delay(2000);
            txtMainWindow.Text += "By accomplishing the missions you can pick up at the local tavern you will slowly become the hero of this God forgotten land... or die trying!\r\n";
            await Task.Delay(3000);
            txtMainWindow.Text += "\r\n";
            txtMainWindow.Text += "First thing first. Lady Luck has given you 5 attribute points to assign to your stats. Do so and your adventure can begin! \r\n";
            txtMainWindow.Text += "\r\n";
            ScrollDownText(txtMainWindow);
            await Task.Delay(2000);

            LevelUp(5);


        }

        private void AddAttribute(int tmp, int points, Label lblAttribute, Label lblPoints )
        {            
            if (++tmp > 20)
            {
                tmp = 20;
            }
            else
            {
                if (--points < 0)
                {
                    ++points;
                    --tmp;

                }
            }

            lblAttribute.Text = Convert.ToString(tmp);
            lblPoints.Text = Convert.ToString(points);


        }

        private void SubAttribute(int tmp, int points, int minPoints, Label lblAttribute, Label lblPoints)
        {            
            if (--tmp < minPoints)
            {
                tmp = minPoints;
            }
            else
            {
                ++points;

            }


            lblAttribute.Text = Convert.ToString(tmp);
            lblPoints.Text = Convert.ToString(points);
        }

        private void btPlusStr_Click(object sender, EventArgs e)
        {

            AddAttribute(tmpStr, Convert.ToInt32(lblLvlPoints.Text), lStrNr, lblLvlPoints);
            tmpStr = Convert.ToInt32(lStrNr.Text);
         

        }

        private void btLessStr_Click(object sender, EventArgs e)
        {
            SubAttribute(tmpStr, Convert.ToInt32(lblLvlPoints.Text),player.Strength, lStrNr, lblLvlPoints);
            tmpStr = Convert.ToInt32(lStrNr.Text);
        }

        private void btPlusInt_Click(object sender, EventArgs e)
        {
            AddAttribute(tmpInt, Convert.ToInt32(lblLvlPoints.Text), lIntNr, lblLvlPoints);
            tmpInt = Convert.ToInt32(lIntNr.Text);
        }

        private void btLessInt_Click(object sender, EventArgs e)
        {
            SubAttribute(tmpInt, Convert.ToInt32(lblLvlPoints.Text), player.Intelligence, lIntNr, lblLvlPoints);
            tmpInt = Convert.ToInt32(lIntNr.Text);
        }

        private void btPlusDex_Click(object sender, EventArgs e)
        {
            AddAttribute(tmpDex, Convert.ToInt32(lblLvlPoints.Text), lDexNr, lblLvlPoints);
            tmpDex = Convert.ToInt32(lDexNr.Text);
        }

        private void btLessDex_Click(object sender, EventArgs e)
        {
            SubAttribute(tmpDex, Convert.ToInt32(lblLvlPoints.Text), player.Dexterity, lDexNr, lblLvlPoints);
            tmpDex = Convert.ToInt32(lDexNr.Text);
        }

        private void btPlusChar_Click(object sender, EventArgs e)
        {
            AddAttribute(tmpChar, Convert.ToInt32(lblLvlPoints.Text),lChrNr, lblLvlPoints);
            tmpChar = Convert.ToInt32(lChrNr.Text);
        }

        private void btLessChar_Click(object sender, EventArgs e)
        {
            SubAttribute(tmpChar, Convert.ToInt32(lblLvlPoints.Text), player.Charisma, lChrNr, lblLvlPoints);
            tmpChar = Convert.ToInt32(lChrNr.Text);
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tInputName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                bOk.PerformClick();
            }
        }

        private void ScrollDownText(TextBox txtb)
        {
            txtb.SelectionStart = txtb.Text.Length;
            txtb.ScrollToCaret();
        }

        private async void btLvlUpOk_Click(object sender, EventArgs e)
        {
            if (lblLvlPoints.Text=="0")
            {
                pnlLevelUp.Enabled = false;
                pnlLevelUp.Visible = false;

                player.Strength = tmpStr;
                player.Dexterity = tmpDex;
                player.Intelligence = tmpInt;
                player.Charisma = tmpChar;

                txtMainWindow.Text += $"Strenght is now {player.Strength} \r\n";
                txtMainWindow.Text += $"Dexterity is now {player.Dexterity} \r\n";
                txtMainWindow.Text += $"Intelligence is now {player.Intelligence} \r\n";
                txtMainWindow.Text += $"Charisma is now {player.Charisma} \r\n";

                ScrollDownText(txtMainWindow);
                await Task.Delay(1000);

                if (firstTime)
                {
                    txtMainWindow.Text += "\r\n";
                    txtMainWindow.Text += "You head to the local tavern to pick up some contracts \r\n";
                    ScrollDownText(txtMainWindow);
                    await Task.Delay(3000);
                    firstTime = false;
                    Tavern();

                }
                
            }
            else
            {
                txtMainWindow.Text += "You have points to assign! \r\n";
                ScrollDownText(txtMainWindow);
            }



        }
    }




}
