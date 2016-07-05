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
        private PlayerQuest playerQuest;

        private Quest1Class Quest1;
        private Quest2Class Quest2;
        private Quest3Class Quest3;
       
        private int tmpStr, tmpDex, tmpInt, tmpChar;
        private const int HEALTH_LEVEL = 500;
        private const int POINTS_LEVEL = 3;
        private bool firstTime = true;
        private bool inCombat = false;
        private InitialMenuChoice mChoice;
        private bool DoQ2 = true;
        private GamePhase CurrentPhase;
        private EventJourney EventGenerated;
        private int Days;
        private int CountDays = 0;
        private int FoesNr;
        private int FoesRemaining;
        private Monster attackMonster;


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
            bool DolvlUp=false;

            if (lvl < 20 && exp >= 70000)
            {
                player.Level = 20;
                DolvlUp = true;

            }
            else if (lvl < 19 && exp >= 62000)
            {
                player.Level = 19;
                DolvlUp = true;

            }
            else if (lvl < 18 && exp >= 55000)
            {
                player.Level = 18;
                DolvlUp = true;

            }
            else if (lvl < 17 && exp >= 48000)
            {
                player.Level = 17;
                DolvlUp = true;

            }
            else if (lvl < 16 && exp >= 43000)
            {
                player.Level = 16;
                DolvlUp = true;

            }
            else if (lvl < 15 && exp >= 38000)
            {
                player.Level = 15;
                DolvlUp = true;

            }
            else if (lvl < 14 && exp >= 33000)
            {
                player.Level = 14;
                DolvlUp = true;

            }
            else if (lvl < 13 && exp >= 28000)
            {
                player.Level = 13;
                DolvlUp = true;

            }
            else if (lvl < 12 && exp >= 23000)
            {
                player.Level = 12;
                DolvlUp = true;

            }
            else if (lvl < 11 && exp >= 18000)
            {
                player.Level = 11;
                DolvlUp = true;

            }
            else if (lvl < 10 && exp >= 13000)
            {
                player.Level = 10;
                DolvlUp = true;

            }
            else if (lvl < 9 && exp >= 11000)
            {
                player.Level = 9;
                DolvlUp = true;

            }
            else if (lvl < 8 && exp >= 9000)
            {
                player.Level = 8;
                DolvlUp = true;

            }
            else if (lvl < 7 && exp >= 7000)
            {
                player.Level = 7;
                DolvlUp = true;

            }
            else if (lvl < 6 && exp >= 5000)
            {
                player.Level = 6;
                DolvlUp = true;

            }
            else if (lvl < 5 && exp >= 3000)
            {
                player.Level = 5;
                DolvlUp = true;

            }
            else if (lvl < 4 && exp >= 2000)
            {
                player.Level = 4;
                DolvlUp = true;

            }
            else if (lvl < 3 && exp >= 1000)
            {
                player.Level = 3;
                DolvlUp = true;

            }
            else if (lvl < 2 && exp >= 500)
            {
                player.Level = 2;
                DolvlUp = true;

            }

            if (DolvlUp)
            {
                txtMainWindow.Text += $"Congratrulations you are now level {player.Level}!! \r\n";
                ScrollDownText(txtMainWindow);
                player.MaximumHitPoints += (player.Level - lvl) * HEALTH_LEVEL;
                player.CurrentHitPoints = player.MaximumHitPoints;
                txtMainWindow.Text += $"You have gained {(player.Level - lvl) * POINTS_LEVEL} stats point to assign and {(player.Level - lvl) * HEALTH_LEVEL} health. \r\n";
                ScrollDownText(txtMainWindow);
                LevelUp((player.Level - lvl) * POINTS_LEVEL);
                UpdateStats();
            }

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

       private int RandomElementEnum(IEnumerable<int> listOfElements)
        {
            
            int rndnumber;

            do
            {

                rndnumber = rnd.Next(0, listOfElements.Count());
            }
            while (rndnumber > listOfElements.Count());

            return rndnumber;
        }
        
        private int RandomElement(int maxNr)
        {
           
            int rndnumber;

            do
            {
                rndnumber = rnd.Next(1, maxNr + 1);
            }
            while (rndnumber > maxNr);

            return rndnumber;
        }

        private void generateQuest1()
        {
            Monster QMonster;
            WorldLocation QLocation;
           
            IEnumerable<int> ExtractList = MonstersList();
            QMonster = MonsterByID(ExtractList.ElementAt(RandomElementEnum(ExtractList)));
            ExtractList = LocationListMonster(QMonster.ID);
            QLocation = LocationByID(ExtractList.ElementAt(RandomElementEnum(ExtractList)));

            Quest1 = new Quest1Class(QuestOption.Quest1, QuestType.Kill, QLocation.ID, QLocation.LocationName, CreateGold(), CreatureType.Monster, QMonster.ID, QMonster.Name);
        }

        private void generateQuest2()
        {
            QuestGiver QGiver;
            QuestWho QWho;
            WorldLocation QLocation;
            do
            {
                QLocation = LocationByID(RandomElement(WorldLocations.Count));
            }
            while (QLocation.ID == LOC_DESERT);

            QGiver = GiverByID(RandomElement(QuestGivers.Count()));
            QWho = WhoByID(RandomElement(QuestWhois.Count()));

            Quest2 = new Quest2Class(QuestOption.Quest2, QuestType.SaveKidnap, QLocation.ID, QLocation.LocationName, CreateGold(), QWho.NameWho, QGiver.NameGiver); 
        }

        private void generateQuest3()
        {
            QuestGiver QGiver;            
            WorldLocation QLocation;
            Item QItem;
            do
            {
                QLocation = LocationByID(RandomElement(WorldLocations.Count));
            }
            while (QLocation.ID == LOC_DESERT);

            QGiver = GiverByID(RandomElement(QuestGivers.Count()));

            IEnumerable<int> ExtractList = StolenItems();
            QItem = ItemByID(ExtractList.ElementAt(RandomElementEnum(ExtractList)));

            Quest3 = new Quest3Class(QuestOption.Quest3, QuestType.Retrive, QLocation.ID, QLocation.LocationName, CreateGold(), QGiver.NameGiver,QItem.ID,QItem.Name);

        }

        private void Heal()
        {
            if (player.CurrentHitPoints<player.MaximumHitPoints)
            {
                player.CurrentHitPoints += player.Level * 50;
                if (player.CurrentHitPoints>player.MaximumHitPoints)
                {
                    player.CurrentHitPoints = player.MaximumHitPoints;
                }
            }
        }

        private void CheckMonsterHealth()
        {
            if (attackMonster.CurrentHitPoints <= 0)
            {
                FoesRemaining--;
                txtMainWindow.Text += $"You have killed 1 enemy! {FoesRemaining} remain \r\n";
                ScrollDownText(txtMainWindow);
                attackMonster.CurrentHitPoints = attackMonster.MaximumHitPoints;

                if (FoesRemaining==0)
                {
                    txtMainWindow.Text += $"You have killed all your enemies! \r\n";
                    txtMainWindow.Text += $"You have gained {FoesNr * attackMonster.RewardExperiencePoints} experience points!\r\n";
                    ScrollDownText(txtMainWindow);
                    player.ExperiecePoints += FoesNr * attackMonster.RewardExperiencePoints;
                    UpdateStats();
                    CheckLvlUp(player.ExperiecePoints, player.Level);
                    inCombat = false;
                }
            }
        }

        private void GenerateFoesEncounter()
        {
            
            WorldLocation JLocation;
            do
            {
                JLocation = LocationByID(RandomElement(WorldLocations.Count));
            }
            while (JLocation.ID == LOC_DESERT);

            IEnumerable<int> ExtractList = MonstersByLocID(JLocation.ID);
            do
            {
                attackMonster = MonsterByID(ExtractList.ElementAt(RandomElementEnum(ExtractList)));
            }
            while (attackMonster.Type == CreatureType.Monster);

        }

        private void Journey()
        {
            ++CountDays;
            if (CountDays < Days)
            {
                //journey still on

                txtMainWindow.Text += $"Youe have {Days} days of travel. Days travelled: {CountDays} \r\n";

                //generate 3 possible events during the journey
                EventGenerated = GenerateEvent();
                switch (EventGenerated)
                { 
                case EventJourney.Nothing:

                    //Nothing happens
                    txtMainWindow.Text += "\r\n";
                    txtMainWindow.Text += "Nothing has heppened today \r\n";
                    Heal();
                    break;
                case EventJourney.Approach:

                    //See x creatrues
                    FoesRemaining = FoesNr = rnd.Next(1, 4);
                    GenerateFoesEncounter();
                    string text = (FoesNr == 1) ? attackMonster.Name : attackMonster.NamePlural;
                    txtMainWindow.Text += "\r\n";
                    txtMainWindow.Text += $"You see {FoesNr} {text} approaching\r\n";
                    break;
                case EventJourney.Noise:
                        FoesRemaining = FoesNr = rnd.Next(1, 4);
                        GenerateFoesEncounter();
                        
                        txtMainWindow.Text += "\r\n";
                        txtMainWindow.Text += $"You hear some strange noises. \r\n";                        
                        break;
                }
            }
            else
            {
                //Arrived
            }
           
        }

        private void UpdateBtn()
        {
            switch (CurrentPhase)
            {
                case GamePhase.Tavern:

                    button1.Text = "Contract 1";
                    button2.Text = "Contract 2";
                    button3.Text = "Caravan";
                    button4.Text = "Shop";
                    break;
                case GamePhase.Journey:
                    button1.Text = "Attack";
                    button2.Text = "Ambush";
                    button3.Text = "Use Item";
                    button4.Text = "Continue";
                    break;
                case GamePhase.Caravan:
                    break;
                case GamePhase.BossEncounter:
                    break;
                case GamePhase.Marrakesh:
                    break;
                case GamePhase.Shop:
                    break;
            }
            

        }

        private void Tavern()
        {
            CurrentPhase = GamePhase.Tavern;
            UpdateBtn();
            generateQuest1();
            generateQuest2();
            generateQuest3();
            
            txtMainWindow.Text = "These missions are available: \r\n";
            txtMainWindow.Text += $"1- There is a dangerous {Quest1.MonsterName} lurking in the nearby {Quest1.LocationName}. {Quest1.RewardGold} gold is offered to whoever kills it. \r\n";

            if (RandomElement(10) <= 5)
            {
                txtMainWindow.Text += $"2- The {Quest2.WhoQuestName} of a {Quest2.GiverQuestName} has been kidnapped by a bandit. It's rumored that he is hiding with his gang in the {Quest2.LocationName} nearby. {Quest2.RewardGold} gold is offered to whoever is going to free the kidnapped and kill the criminal and his followers. \r\n";
            }

            else
            {
                txtMainWindow.Text += $"2- A thief has stolen a precious {Quest3.ItemName} from the house of a {Quest3.GiverQuestName}. He was last seen heading towards the {Quest3.LocationName}. {Quest3.RewardGold} gold is offered to whoever will retrive the precious heirloom. \r\n";
                DoQ2 = false;
            }


            txtMainWindow.Text += "3- A caravan is leaving for Marrakesh, the most prosperous and wealthy city of this land. There might still be a place available, if not you can join as a guard. \r\n";
            txtMainWindow.Text += "4- ... the jobs avaiable are boring. Maybe you would like to visit the local General Store?\r\n";
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
            await Task.Delay(1000);
            txtMainWindow.Text += "By accomplishing the missions you can pick up at the local tavern you will slowly become the hero of this God forgotten land... or die trying!\r\n";
            await Task.Delay(3000);
            txtMainWindow.Text += "\r\n";
            txtMainWindow.Text += "First thing first. The Goddes of Mercy has given you 5 attribute points to assign to your stats. Do so and your adventure can begin! \r\n";
            txtMainWindow.Text += "\r\n";
            ScrollDownText(txtMainWindow);
            await Task.Delay(1500);

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

        private void GenerateMessage()
        {

        }

        private EventJourney GenerateEvent()
        {
            int EventProb = rnd.Next(1, 101);

            if (EventProb <= 35)
            {
                return EventJourney.Nothing;
            }
            else if (EventProb <= 70)
            {
                return EventJourney.Approach;
            }
            else
            {
                return EventJourney.Noise;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (CurrentPhase)
            {
                case GamePhase.Tavern:
                    // selected Quest 1 type
                    Days = rnd.Next(2, 5);
                    mChoice = InitialMenuChoice.Quest1;
                    playerQuest = new PlayerQuest(QuestOption.Quest1);
                    txtMainWindow.Text = $"You start your journey to kill the {Quest1.MonsterName}. \r\n";
                    txtMainWindow.Text += "\r\n";
                    CurrentPhase = GamePhase.Journey;                    
                    UpdateBtn();
                    Journey();
                    break;
                case GamePhase.Journey:

                    switch (EventGenerated)
                    {
                        case EventJourney.Nothing:
                            //Nothing happens & we attack
                            txtMainWindow.Text += "\r\n";
                            txtMainWindow.Text += "There is nothing to attack!";
                            break;
                        case EventJourney.Approach:

                            //we See x creatrues and we attack
                            if (FoesRemaining > 0)
                            {
                                 if (firstTime)
                                {
                                    firstTime = false;
                                    inCombat = true;
                                    string text = (FoesNr == 1) ? attackMonster.Name : attackMonster.NamePlural;
                                    txtMainWindow.Text += $"You run towards the {text} and start the combat! \r\n";
                                    txtMainWindow.Text += "\r\n";
                                    ScrollDownText(txtMainWindow);
                                }
                                
                                // need to manage inventory and current weapon to get min/max dmg!!!
                                int Hit = Damage(player.Strength, player.Level, 10, 20);
                                attackMonster.CurrentHitPoints -= Hit;
                                txtMainWindow.Text += $"You attack and do {Hit} of damage. Enemy health {attackMonster.CurrentHitPoints}/{attackMonster.MaximumHitPoints}\r\n";
                                ScrollDownText(txtMainWindow);
                                CheckMonsterHealth();
                                if (!inCombat)
                                {
                                    button4.PerformClick();
                                }
                            }
                            break;
                        case EventJourney.Noise:

                            //we hear noises nearby and we attack
                            break;
                    }                  
                    break;

                case GamePhase.Caravan:
                    // if we are on the caravan this is option 1 of that scenario
                    break;
                case GamePhase.Shop:
                    // before joining the caravan we have this option
                    break;
                case GamePhase.Marrakesh:
                    // when we are in Marrakesh this option taked use to the Weapon Shop
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch(CurrentPhase)
            {
                case GamePhase.Tavern:
                    if (DoQ2)
                    {
                        playerQuest = new PlayerQuest(QuestOption.Quest2);
                        mChoice = InitialMenuChoice.Quest2;
                        txtMainWindow.Text = $"You start your journey to free the kidnapped {Quest2.WhoQuestName}. \r\n";
                    } else
                    {
                        playerQuest = new PlayerQuest(QuestOption.Quest3);
                        mChoice = InitialMenuChoice.Quest3;
                        txtMainWindow.Text = $"You start your journey to recover the stolen {Quest3.ItemName}. \r\n";
                    }
                    
                    txtMainWindow.Text += "\r\n";
                    Days = rnd.Next(2, 5);
                    CurrentPhase = GamePhase.Journey;
                    UpdateBtn();
                    Journey();
                    break;
                case GamePhase.Journey:                   
                    break;
                case GamePhase.Caravan:
                    break;
                case GamePhase.Shop:
                    break;
                case GamePhase.Marrakesh:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (EventGenerated)
            {
                case EventJourney.Nothing:
                    //Nothing happens & we continue
                    txtMainWindow.Text += "\r\n";
                    txtMainWindow.Text += "You journer on";
                    Heal();
                    Journey();
                    break;
            }
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
 
                ScrollDownText(txtMainWindow);
               
                
                if (firstTime)
                {
                    
                    txtMainWindow.Text += "You head to the local tavern to pick up some contracts \r\n";
                    ScrollDownText(txtMainWindow);
                    await Task.Delay(1500);
                    firstTime = false;
                    Tavern();

                }
                
            }
            else
            {
                txtMainWindow.Text += "You still have points to assign! \r\n";
                ScrollDownText(txtMainWindow);
            }



        }
    }




}
