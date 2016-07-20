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

        private Item testItem;

        private int tmpStr, tmpDex, tmpInt, tmpChar;
        private const int HEALTH_LEVEL = 500;
        private const int POINTS_LEVEL = 3;
        private bool firstTime = true;
        private bool firstTimeCombat = true;
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
        private int Buy1;
        private int Buy2;
        private int Buy3;
        


        public frmBase()
        {
            InitializeComponent();
            pMain.Visible = false;
            pMain.Enabled = false;
            pNameInput.Visible = false;
            pNameInput.Enabled = false;
            pnlLevelUp.Enabled = false;
            pnlLevelUp.Visible = false;
            pnlMainBtn.Visible = false;
            pnlMainBtn.Enabled = false;
            pnlInventory.Enabled = false;
            pnlInventory.Visible = false;
            dgInventory.Visible = false;
            pnlTop.Visible = false;
            firstTime = true;
            firstTimeCombat = true;
            DoQ2 = true;
            CountDays = 0;
            inCombat = false;

            player = new Player(1, 1, 1, 1, 100, "", 0, 1, 1000, 1000,CreatureType.HumanPeaceful, CreatureClass.Player);
            player.Inventory.Add(new InventoryItem(GetItembyID(1), 1));
            player.Inventory.Add(new InventoryItem(GetItembyID(100), 5));
            UpdateWeaponListInUI();
            UpdateConsumableListInUI();
            UpdateInventoryGrid();
        }
                

        private void ResetAfterDead()
        {
            firstTime = true;
            firstTimeCombat = true;
            DoQ2 = true;
            CountDays = 0;
            inCombat = false;
            pnlInventory.Enabled = false;
            pnlInventory.Visible = false;
            dgInventory.Visible = false;
            pnlTop.Visible = false;
            player = new Player(1, 1, 1, 1, 100, "", 1, 1, 1000, 1000, CreatureType.HumanPeaceful, CreatureClass.Player);
            tInputName.Text = "";
            player.Inventory.Clear();
            player.Inventory.Add(new InventoryItem(GetItembyID(1), 1));
            player.Inventory.Add(new InventoryItem(GetItembyID(100), 5));
            UpdateConsumableListInUI();
            UpdateWeaponListInUI();
            UpdateInventoryGrid();
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
           /* bool DolvlUp=false;

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
            */
            if (exp>=(250*Math.Pow(lvl,2)))
            {
                player.Level = (int) Math.Truncate(Math.Pow(exp / 250, 0.5));                           
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

        private void UpdateConsumableListInUI()
        {
            List<Item> usableItems = new List<Item>();

            foreach (InventoryItem inventoryItem in player.Inventory)
            {                
                if (inventoryItem.Details.Type==ItemType.Consumable || inventoryItem.Details.Type == ItemType.Usable)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        usableItems.Add(inventoryItem.Details);
                    }
                }
            }

            

            if (usableItems.Count>0)
            {
                if (cboConsumable.Items.Count > 0)
                {
                    cboConsumable.DataSource = null;
                    cboConsumable.Text = "";
                    cboConsumable.SelectedIndex = -1;
                }
                

                cboConsumable.DataSource = usableItems;
                cboConsumable.DisplayMember = "Name";
                cboConsumable.ValueMember = "ID";
                cboConsumable.SelectedIndex = 0;                                                                  
            }
            else
            {
                cboConsumable.DataSource = null;
                cboConsumable.Text = "";
                cboConsumable.SelectedIndex = -1;
            }            
        }

        private void UpdateInventoryGrid()
        {
            dgInventory.RowHeadersVisible = false;

            dgInventory.ColumnCount = 2;
            dgInventory.Columns[0].Name = "Name";
            dgInventory.Columns[0].Width = 280;
            
            dgInventory.Columns[1].Name = "Quantity";
            dgInventory.Columns[1].Width = 50;

            dgInventory.Rows.Clear();

            foreach (InventoryItem inventoryItem in player.Inventory)
            {
                if (inventoryItem.Quantity > 0)
                {
                    dgInventory.Rows.Add(new[] { inventoryItem.Details.Name, inventoryItem.Quantity.ToString() });
                }
            }
        }

        private void UpdateWeaponListInUI()
        {
            List<Item> weapons = new List<Item>();

            foreach (InventoryItem inventoryItem in player.Inventory)
            {
                if (inventoryItem.Details.Type==ItemType.Weapon)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        weapons.Add(inventoryItem.Details);
                    }
                }
            }

            cboWeapons.DataSource = weapons;
            cboWeapons.DisplayMember = "Name";
            cboWeapons.ValueMember = "ID";
            cboWeapons.SelectedIndex = 0;
            
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
           // Monster QMonster;
           // WorldLocation QLocation;
           
           // IEnumerable<int> ExtractList = MonstersList();
           // QMonster = MonsterByID(ExtractList.ElementAt(RandomElementEnum(ExtractList)));
           // ExtractList = LocationListMonster(QMonster.ID);
            //QLocation = LocationByID(ExtractList.ElementAt(RandomElementEnum(ExtractList)));

            Quest1 = new Quest1Class(QLocation.ID, QLocation.LocationName, CreateGold(), CreatureType.Monster, QMonster.ID, QMonster.Name);
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

        private async void Heal(int amount)
        {
            int healed = player.CurrentHitPoints;
            if (player.CurrentHitPoints<player.MaximumHitPoints)
            {
                player.CurrentHitPoints += amount;
                if (player.CurrentHitPoints>player.MaximumHitPoints)
                {
                    player.CurrentHitPoints = player.MaximumHitPoints;
                }
                txtMainWindow.Text += $"You healed {player.CurrentHitPoints-healed} \r\n";
                txtMainWindow.Text += "\r\n";
                UpdateStats();
                await Task.Delay(1500);
            }
        }

        private void CheckAllMonsterDead()
        {
            if (FoesRemaining == 0 && CurrentPhase!=GamePhase.BossEncounter)
            {
                txtMainWindow.Text += "You have killed all your enemies! \r\n";
                txtMainWindow.Text += $"You have gained {FoesNr * attackMonster.RewardExperiencePoints} experience points!\r\n";
                txtMainWindow.Text += "\r\n";
                ScrollDownText(txtMainWindow);
                player.ExperiecePoints += FoesNr * attackMonster.RewardExperiencePoints;
                UpdateStats();
                CheckLvlUp(player.ExperiecePoints, player.Level);
                inCombat = false;
                firstTimeCombat = true;                        
            }            
            
        }

        private void EnemyTurn(CreatureClass eClass)
        {
            
           
                if (!CheckHit(player.Dexterity, eClass))
                {
                    if (!CheckAvoid(player.Dexterity,eClass))
                    {
                        int MonsterHit = 0;
                        if (CurrentPhase != GamePhase.BossEncounter)
                        {
                            MonsterHit = RollMonsterDamage(attackMonster.MaximumDamage);
                        }
                        else
                        {
                            switch (mChoice)
                            {
                                case InitialMenuChoice.Quest1:
                                    MonsterHit = RollMonsterDamage(MonsterByID(Quest1.MonsterID).MaximumDamage);
                                    break;

                                case InitialMenuChoice.Quest2:
                                    MonsterHit = RollMonsterDamage(MonsterByID(MONSTER_ID_BANDIT).MaximumDamage);
                                    break;
                                case InitialMenuChoice.Quest3:
                                    MonsterHit = RollMonsterDamage(MonsterByID(MONSTER_ID_THIEF).MaximumDamage);
                                    break;

                            }
                        }

                        
                        player.CurrentHitPoints -= MonsterHit;
                        txtMainWindow.Text += $"Your enemy attacks and does {MonsterHit} of damage. \r\n";
                        txtMainWindow.Text += "\r\n";
                        UpdateStats();
                        ScrollDownText(txtMainWindow);
                        CheckPlayerHealth();
                    }
                    else
                    {
                        txtMainWindow.Text += "You dodge the enemy attack. \r\n";
                        txtMainWindow.Text += "\r\n";
                        ScrollDownText(txtMainWindow);
                    }
                }
                else
                {
                    txtMainWindow.Text += "The enemy misses the attack. \r\n";
                    txtMainWindow.Text += "\r\n";
                    ScrollDownText(txtMainWindow);
                }

                
            
        }

        private void MyTurnAttack(int mod)
        {
            if (firstTimeCombat)
                
            {
                if (CurrentPhase != GamePhase.BossEncounter)
                {
                    
                    string text = (FoesNr == 1) ? attackMonster.Name : attackMonster.NamePlural;
                    txtMainWindow.Text = $"You run towards the {text} and start the combat! \r\n";
                }
                else
                {
                    txtMainWindow.Text = "You run towards the enemy and start the combat! \r\n";
                }
                firstTimeCombat = false;
                txtMainWindow.Text += "\r\n";
                ScrollDownText(txtMainWindow);
            }

            
            if (CurrentPhase != GamePhase.BossEncounter)
            {
                if (CheckHit(player.Dexterity, player.Difficulty))
                {
                    
                    Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;
                    int Hit = Damage(player.Strength, player.Level, currentWeapon.MinimumDamage, currentWeapon.MaximumDamage) * mod;
                    attackMonster.CurrentHitPoints -= Hit;
                    lblEnemyHealth.Text= $"{attackMonster.CurrentHitPoints}/{attackMonster.MaximumHitPoints}";
                    txtMainWindow.Text = $"You attack and do {Hit} of damage.\r\n";
                    txtMainWindow.Text += "\r\n";
                    ScrollDownText(txtMainWindow);
                }
                else
                {
                    txtMainWindow.Text = "You miss your attack!\r\n";
                    txtMainWindow.Text += "\r\n";
                    ScrollDownText(txtMainWindow);
                }
            }
            else
            {
                if (CheckHit(player.Dexterity, player.Difficulty))
                {
                    Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;
                    int Hit = Damage(player.Strength, player.Level, currentWeapon.MinimumDamage, currentWeapon.MaximumDamage) * mod;
                    int HP = 0;
                    int HPMax = 0;

                    switch (mChoice)
                    {
                        case InitialMenuChoice.Quest1:
                            HP = MonsterByID(Quest1.MonsterID).CurrentHitPoints;
                            MonsterByID(Quest1.MonsterID).CurrentHitPoints -= Hit;
                            HPMax = MonsterByID(Quest1.MonsterID).MaximumHitPoints;
                            break;
                        case InitialMenuChoice.Quest2:
                            HP = MonsterByID(MONSTER_ID_BANDIT).CurrentHitPoints;
                            MonsterByID(MONSTER_ID_BANDIT).CurrentHitPoints -= Hit;
                            HPMax = MonsterByID(MONSTER_ID_BANDIT).MaximumHitPoints;
                            break;
                        case InitialMenuChoice.Quest3:
                            HP = MonsterByID(MONSTER_ID_THIEF).CurrentHitPoints;
                            MonsterByID(MONSTER_ID_THIEF).CurrentHitPoints -= Hit;
                            HPMax = MonsterByID(MONSTER_ID_THIEF).MaximumHitPoints;
                            break;
                    }
                    HP -= Hit;
                    lblEnemyHealth.Text = $"{HP}/{HPMax}";
                    txtMainWindow.Text = $"You attack and do {Hit} of damage.\r\n";
                    txtMainWindow.Text += "\r\n";
                    ScrollDownText(txtMainWindow);
                }
                else
                {
                    txtMainWindow.Text = "You miss your attack!\r\n";
                    txtMainWindow.Text += "\r\n";
                    ScrollDownText(txtMainWindow);
                }
            }
            
        }

        private bool CheckHit(int dex, CreatureClass enemyClass)
        {
            int myRoll = RollDice( HitTarget(dex));
            int mDex= (dex-2<1)? dex:dex - 2;
            int mRoll;
            if (enemyClass == CreatureClass.Normal)
            {

                mRoll = RollDice( HitTarget(mDex));
            }
            else
            {
                mRoll = RollDice(HitTarget(dex+2));
            }

            return (myRoll >= mRoll);
        }

        private bool CheckAvoid(int dex, CreatureClass enemyClass)
        {
            int myRoll = RollDice(AvoidHit(dex));
            int mDex = (dex - 2 < 1) ? dex : dex - 2;
            int mRoll;
            if (enemyClass == CreatureClass.Normal)
            {

                mRoll = RollDice(AvoidHit(mDex));
            }
            else
            {
                mRoll = RollDice(AvoidHit(dex + 2));
            }

            return (myRoll >= mRoll);
        }

        private bool Ambush(EscAvoid ambushType)
        {
            switch (ambushType)
            {
                case EscAvoid.AvoidAmbush:
                    txtMainWindow.Text += "You try to avoid an ambush. \r\n";                
                    break;
                case EscAvoid.Ambush:
                    txtMainWindow.Text += "You try to ambush your enemy. \r\n";                
                    break;
                case EscAvoid.AvoidCombat:
                    txtMainWindow.Text += "You try to avoid the fight. \r\n";
                    break;
                case EscAvoid.FleeCombat:
                    txtMainWindow.Text += "You try to flee the fight. \r\n";
                    break;
            }
            
            txtMainWindow.Text += "You have to roll a higher number than ";
            ScrollDownText(txtMainWindow);
            
            int mRoll = RollDice(1);
            txtMainWindow.Text += $"{mRoll} \r\n";
            ScrollDownText(txtMainWindow);
            
            int myRoll = RollDice(SpecialAction(player.Intelligence));
            txtMainWindow.Text += $"Your roll is: {myRoll} \r\n";
            ScrollDownText(txtMainWindow);
            
            return (myRoll >= mRoll);
        
        }

        private void CheckMonsterHealth()
        {
            if (CurrentPhase == GamePhase.BossEncounter)
            {
                int HP=0;
                switch (mChoice)
                {
                    case InitialMenuChoice.Quest1:
                        HP = MonsterByID(Quest1.MonsterID).CurrentHitPoints;
                        break;
                    case InitialMenuChoice.Quest2:
                        HP = MonsterByID(MONSTER_ID_BANDIT).CurrentHitPoints;
                        break;
                    case InitialMenuChoice.Quest3:
                        HP = MonsterByID(MONSTER_ID_THIEF).CurrentHitPoints;
                        break;
                }
                if (HP<=0)
                {
                    
                    switch (mChoice)
                    {
                        case InitialMenuChoice.Quest1:
                            
                            txtMainWindow.Text += $"You have killed the {Quest1.MonsterName}! \r\n";
                            txtMainWindow.Text += "\r\n";
                            txtMainWindow.Text += $"You gain {MonsterByID(Quest1.MonsterID).RewardExperiencePoints} experience \r\n";
                            txtMainWindow.Text += "\r\n";
                            player.ExperiecePoints += MonsterByID(Quest1.MonsterID).RewardExperiencePoints;
                            MonsterByID(Quest1.MonsterID).CurrentHitPoints = MonsterByID(Quest1.MonsterID).MaximumHitPoints;
                            break;
                        case InitialMenuChoice.Quest2:
                            txtMainWindow.Text += $"You have killed the Bandit! \r\n";
                            txtMainWindow.Text += "\r\n";
                            txtMainWindow.Text += $"You gain {MonsterByID(MONSTER_ID_BANDIT).RewardExperiencePoints} experience \r\n";
                            txtMainWindow.Text += "\r\n";
                            player.ExperiecePoints += MonsterByID(MONSTER_ID_BANDIT).RewardExperiencePoints;
                            MonsterByID(MONSTER_ID_BANDIT).CurrentHitPoints = MonsterByID(MONSTER_ID_BANDIT).MaximumHitPoints;
                            
                            
                            break;
                        case InitialMenuChoice.Quest3:
                            txtMainWindow.Text += $"You have killed the Thief! \r\n";
                            txtMainWindow.Text += "\r\n";
                            txtMainWindow.Text += $"You gain {MonsterByID(MONSTER_ID_THIEF).RewardExperiencePoints} experience \r\n";
                            txtMainWindow.Text += "\r\n";
                            player.ExperiecePoints += MonsterByID(MONSTER_ID_THIEF).RewardExperiencePoints;
                            MonsterByID(MONSTER_ID_THIEF).CurrentHitPoints= MonsterByID(MONSTER_ID_THIEF).MaximumHitPoints;
                            
                            break;
                    }
                    
                    UpdateStats();
                    lblEnemyHealth.Text = "";
                    lblNrEnemies.Text = "";
                    txtMainWindow.Text += $"Now you head back and claim the reward! \r\n";
                    txtMainWindow.Text += "\r\n";
                    ScrollDownText(txtMainWindow);
                    CurrentPhase = GamePhase.BossEnd;
                    inCombat = false;
                }
            }
            else
            { 
            if (attackMonster.CurrentHitPoints <= 0)
                {
                    FoesRemaining--;
                    lblNrEnemies.Text= $"{FoesRemaining}\r\n";
                    txtMainWindow.Text += $"You have killed 1 enemy! {FoesRemaining} remain \r\n";
                    txtMainWindow.Text += "\r\n";
                    ScrollDownText(txtMainWindow);
                    attackMonster.CurrentHitPoints = attackMonster.MaximumHitPoints;


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
            if (CountDays <= Days)
            {
                //journey still on

                txtMainWindow.Text = $"Youe have {Days} days of travel. Days travelled: {CountDays} \r\n";
                txtMainWindow.Text += "\r\n";

                //generate 3 possible events during the journey
                EventGenerated = GenerateEvent();
                switch (EventGenerated)
                { 
                case EventJourney.Nothing:

                    //Nothing happens
                    
                        txtMainWindow.Text += "Nothing has heppened today \r\n";
                        txtMainWindow.Text += "\r\n";
                        Heal(50);
                    break;
                case EventJourney.Approach:

                        //See x creatrues
                        inCombat = true;
                        FoesRemaining = FoesNr = rnd.Next(1, 4);                        
                        GenerateFoesEncounter();
                        string text = (FoesNr == 1) ? attackMonster.Name : attackMonster.NamePlural;                        
                        txtMainWindow.Text += $"You see {FoesNr} {text} \r\n";
                        txtMainWindow.Text += "\r\n";
                        break;
                case EventJourney.Noise:

                        inCombat = true;
                        FoesRemaining = FoesNr = rnd.Next(1, 4);                        
                        GenerateFoesEncounter();                                                
                        txtMainWindow.Text += "You hear some strange noises. \r\n";
                        txtMainWindow.Text += "\r\n";
                        break;
                }
            }
            else if (CurrentPhase==GamePhase.Journey)
            {
                CurrentPhase = GamePhase.BossEncounter;
                inCombat = true;
                lblNrEnemies.Text = "1";
                switch (mChoice)
                {
                    case InitialMenuChoice.Quest1:
                        txtMainWindow.Text = $"You arrive at the {Quest1.LocationName} and see the {Quest1.MonsterName} in the distance. \r\n";
                        txtMainWindow.Text += "\r\n";
                        break;
                    case InitialMenuChoice.Quest2:
                        txtMainWindow.Text = $"You arrive at the {Quest2.LocationName} and see the {Quest2.WhoQuestName} in chains and the Bandit Leader alone nearby. \r\n";
                        txtMainWindow.Text += "\r\n";
                        break;
                    case InitialMenuChoice.Quest3:
                        txtMainWindow.Text = $"You arrive at the {Quest3.LocationName} and see the Thief sitting at a campfire. \r\n";
                        txtMainWindow.Text += "\r\n";
                        break;
                }
            }
            else
            {
                CurrentPhase = GamePhase.Marrakesh;
                txtMainWindow.Text = "You have reached Marrakesh!";
            }
           
        }
     

        private int RollDice(int min)
        {
            return rnd.Next(min, 101);
        }

        private void UseItem()
        {
            HealingPotion currentItem = (HealingPotion) cboConsumable.SelectedItem;

            if (currentItem is HealingPotion)
            {                
                foreach(InventoryItem ii in player.Inventory)
                {
                    if (ii.Details.ID==currentItem.ID)
                    {
                        if (ii.Quantity > 0)
                        {
                            Heal(currentItem.AmountToHeal);
                            ii.Quantity--;
                            UpdateConsumableListInUI();
                            UpdateInventoryGrid();
                        }
                        break;
                    }
                }
            }

        }


        private int RollMonsterDamage(int maxDmg)
        {
            return rnd.Next(0, maxDmg);
        }

        private void GenerateStoreOptions()
        {
            Buy1 = RandomElement(GeneralStore.Count) - 1;

            do
            {
                Buy2 = RandomElement(GeneralStore.Count) - 1;
            }
            while (Buy1 == Buy2);

            do
            {
                Buy3= RandomElement(GeneralStore.Count) - 1;
            }
            while (Buy3 == Buy2 || Buy3==Buy1);
        }

        private void GeneralStoreShop()
        {
            

            txtMainWindow.Text = $"1- There is a {GeneralStore.ElementAt(Buy1).Details.Name} for {GeneralStore.ElementAt(Buy1).Price} \r\n";
            txtMainWindow.Text += $"2- There is a {GeneralStore.ElementAt(Buy2).Details.Name} for {GeneralStore.ElementAt(Buy2).Price} \r\n";
            txtMainWindow.Text += $"3- There is a {GeneralStore.ElementAt(Buy3).Details.Name} for {GeneralStore.ElementAt(Buy3).Price} \r\n";
        }

        private async void CheckPlayerHealth()
        {
            if (player.CurrentHitPoints<=0)
            {
                await Task.Delay(1500);
                txtMainWindow.Text = "YOU ARE DEAD!! \r\n";
                ScrollDownText(txtMainWindow);
                await Task.Delay(2000);
                pnlMainBtn.Enabled = false;
                pnlMainBtn.Visible = false;
                pMain.Enabled = false;
                pMain.Visible = false;
                pStart.Visible = true;
                pStart.Enabled = true;
                ResetAfterDead();                
            }
           
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

        private bool CheckItemInInventory(int BuyOption)
        {
            for (int i = 0; i < player.Inventory.Count; i++)
            {
                if (player.Inventory.ElementAt(i).Details.ID == GeneralStore.ElementAt(BuyOption).Details.ID)
                {
                    player.Inventory.ElementAt(i).Quantity++;
                    return true;
                    
                }
            }
            return false;
        }
        private void CaravanChoices()
        {
            txtMainWindow.Text += "1- You can buy a seat on the caravan for 10,000 gold\r\n";
            txtMainWindow.Text += "2- ... or you can join as a guard (for free of course!) \r\n";
        }
private async void Actions(ButtonChoice button)
        {
            switch (CurrentPhase)
            {
                case GamePhase.Caravan:
                    
                    switch (button)
                    {
                        case ButtonChoice.Button1:
                            if (player.Gold > 10000)
                            {
                                txtMainWindow.Text += "\r\n";
                                txtMainWindow.Text += "You pay the hefty price and join the caravan as guest... at least the gabe you the front seat!\r\n";
                                await Task.Delay(2000);
                                txtMainWindow.Text += "After an uneventful journey across the desert you reach the fabled city of Marrakesh\r\n";
                                await Task.Delay(1500);
                                CurrentPhase = GamePhase.Marrakesh;
                            }
                            else
                            {
                                txtMainWindow.Text += "\r\n";
                                txtMainWindow.Text += "You cannot afford the price!\r\n";
                            }

                            break;
                        case ButtonChoice.Button2:
                            txtMainWindow.Text += "\r\n";
                            txtMainWindow.Text += "You decide to join as a guard. The jounery will last 6 days and will be full of perils!!\r\n";
                            await Task.Delay(2000);
                            CurrentPhase = GamePhase.JourneyMarrakesh;
                            Days = 6;
                            UpdateBtn();
                            Journey();
                            break;
                        case ButtonChoice.Button3:
                            UseItem();
                            break;
                        case ButtonChoice.Button4:
                            Tavern();
                            break;
                    }
                    break;
                case GamePhase.Tavern:
                    switch (button)
                    {
                        case ButtonChoice.Button1:
                            GenerateDays();
                            mChoice = InitialMenuChoice.Quest1;
                            playerQuest = new PlayerQuest(QuestOption.Quest1);
                            txtMainWindow.Text = $"You start your journey to kill the {Quest1.MonsterName}. \r\n";
                            txtMainWindow.Text += "\r\n";
                            CurrentPhase = GamePhase.Journey;
                            UpdateBtn();
                            Journey();
                            break;
                        case ButtonChoice.Button2:
                            GenerateDays();
                            if (DoQ2)
                            {
                                mChoice = InitialMenuChoice.Quest2;
                                playerQuest = new PlayerQuest(QuestOption.Quest2);
                                txtMainWindow.Text = $"You start your journey to save the {Quest2.GiverQuestName}'s {Quest2.WhoQuestName}. \r\n";
                                txtMainWindow.Text += "\r\n";
                            }
                            else
                            {
                                mChoice = InitialMenuChoice.Quest3;
                                playerQuest = new PlayerQuest(QuestOption.Quest3);
                                txtMainWindow.Text = $"You start your journey to recover the {Quest3.ItemName}. \r\n";
                                txtMainWindow.Text += "\r\n";

                            }

                            CurrentPhase = GamePhase.Journey;
                            UpdateBtn();
                            Journey();
                            break;
                        case ButtonChoice.Button3:
                            CurrentPhase = GamePhase.Caravan;
                            txtMainWindow.Text = "You approach the leader of the caravan and he offers you 2 options \r\n";
                            txtMainWindow.Text += "\r\n";
                            CaravanChoices();
                            UpdateBtn();                                                      
                            break;
                        case ButtonChoice.Button4:
                            GenerateStoreOptions();
                            GeneralStoreShop();
                            CurrentPhase = GamePhase.Shop;
                            UpdateBtn();
                            break;
                    }
                    break;
                case GamePhase.Journey:
                case GamePhase.JourneyMarrakesh:
                    switch (EventGenerated)
                    {
                        case EventJourney.Nothing:
                            switch (button)
                            {
                                case ButtonChoice.Button1:
                                    txtMainWindow.Text += "There is nothing to attack! \r\n";
                                    txtMainWindow.Text += "\r\n";
                                    ScrollDownText(txtMainWindow);
                                    break;
                                case ButtonChoice.Button2:
                                    txtMainWindow.Text += "There is nothing to ambush!\r\n";
                                    txtMainWindow.Text += "\r\n";
                                    ScrollDownText(txtMainWindow);
                                    break;
                                case ButtonChoice.Button3:
                                    UseItem();
                                    break;
                                case ButtonChoice.Button4:
                                    firstTimeCombat = true;
                                    txtMainWindow.Text = "";
                                    lblEnemyHealth.Text = "";
                                    lblNrEnemies.Text = "";
                                    Heal(50);
                                    Journey();                                    
                                    break;
                            }
                            break;
                        case EventJourney.Approach:
                            switch (button)
                            {
                                case ButtonChoice.Button1:
                                    //we See x creatrues and we attack
                                    if (inCombat)
                                    {
                                        if (FoesRemaining > 0)
                                        {
                                            MyTurnAttack(1);
                                            CheckMonsterHealth();
                                            CheckAllMonsterDead();
                                            lblNrEnemies.Text = $"{FoesRemaining}";
                                            if (inCombat) EnemyTurn(attackMonster.Difficulty);
                                        }
                                    }
                                    break;
                                case ButtonChoice.Button2:

                                    
                                        if (firstTimeCombat)
                                        {

                                            if (Ambush(EscAvoid.Ambush))
                                            {

                                                string text = (FoesNr == 1) ? attackMonster.Name : attackMonster.NamePlural;
                                                txtMainWindow.Text += $"You succeed! You successfully ambushed {FoesNr} {text} and killed one of them\r\n";
                                                txtMainWindow.Text += "\r\n";
                                                ScrollDownText(txtMainWindow);
                                                await Task.Delay(1500);
                                                inCombat = true;
                                                firstTimeCombat = false;
                                                FoesRemaining--;
                                                lblNrEnemies.Text = $"{FoesRemaining}";
                                                CheckAllMonsterDead();

                                            }
                                            else
                                            {
                                                string text = (FoesNr == 1) ? attackMonster.Name + " sees" : attackMonster.NamePlural + " see";
                                                txtMainWindow.Text += $"You've failed! {FoesNr} {text} you and attacks you first! \r\n";
                                                txtMainWindow.Text += "\r\n";
                                                lblNrEnemies.Text = $"{FoesRemaining}";
                                                lblEnemyHealth.Text = $"{attackMonster.CurrentHitPoints}/{attackMonster.MaximumHitPoints}";
                                                ScrollDownText(txtMainWindow);
                                                await Task.Delay(1500);
                                                EnemyTurn(attackMonster.Difficulty);
                                                firstTimeCombat = false;
                                            }

                                        }
                                        else
                                        {
                                            txtMainWindow.Text += "You cannot ambush your enemy, you're already in combat! \r\n";
                                            txtMainWindow.Text += "\r\n";
                                            ScrollDownText(txtMainWindow);
                                            await Task.Delay(1500);
                                            EnemyTurn(attackMonster.Difficulty);
                                        }

                                    break;
                                case ButtonChoice.Button3:
                                    UseItem();
                                    break;
                                case ButtonChoice.Button4:
                                    if (inCombat)
                                    {

                                        if (firstTimeCombat)  //----- means I haven't started the fight so I can try to avoid it
                                        {
                                            if (Ambush(EscAvoid.AvoidCombat))
                                            {
                                                txtMainWindow.Text += "You avoid the fight! \r\n";
                                                txtMainWindow.Text += "\r\n";
                                                ScrollDownText(txtMainWindow);
                                                await Task.Delay(1500);
                                                inCombat = false;
                                                firstTimeCombat = true;
                                                txtMainWindow.Text = "";
                                                lblNrEnemies.Text = "";
                                                Heal(50);
                                                Journey();
                                            }
                                            else
                                            {
                                                txtMainWindow.Text += "You've failed to avoid the fight and now you're in combat! \r\n";
                                                txtMainWindow.Text += "\r\n";
                                                lblNrEnemies.Text = $"{FoesRemaining}";
                                                ScrollDownText(txtMainWindow);
                                                firstTimeCombat = false;
                                            }

                                        }
                                        else //--- I'm during the fight but I can try to flee
                                        {
                                            if (Ambush(EscAvoid.FleeCombat))
                                            {
                                                txtMainWindow.Text += "You escaped the fight! \r\n";
                                                txtMainWindow.Text += "\r\n";
                                                ScrollDownText(txtMainWindow);
                                                await Task.Delay(1500);
                                                inCombat = false;
                                                firstTimeCombat = true;
                                                txtMainWindow.Text = "";
                                                lblNrEnemies.Text = "";
                                                Heal(50);
                                                Journey();
                                            }
                                            else
                                            {
                                                txtMainWindow.Text += "You've failed to escape the fight! \r\n";
                                                txtMainWindow.Text += "\r\n";
                                                ScrollDownText(txtMainWindow);
                                                EnemyTurn(attackMonster.Difficulty);
                                            }
                                        }
                                    }
                                    else Journey();
                                    break;
                            }
                            break;
                        case EventJourney.Noise:
                            switch (button)
                            {
                                case ButtonChoice.Button1:
                                case ButtonChoice.Button2:

                                    if (inCombat)
                                    {
                                        if (firstTimeCombat)
                                        {

                                            if (Ambush(EscAvoid.AvoidAmbush))
                                            {
                                                string text = (FoesNr == 1) ? attackMonster.Name + " was" : attackMonster.NamePlural + " were";
                                                txtMainWindow.Text += $"{FoesNr} {text} trying to ambush you! You avoided it and now you're in combat \r\n";
                                                txtMainWindow.Text += "\r\n";
                                                ScrollDownText(txtMainWindow);
                                                lblNrEnemies.Text = $"{FoesRemaining}";
                                                lblEnemyHealth.Text = $"{attackMonster.CurrentHitPoints}/{attackMonster.MaximumHitPoints}";
                                                await Task.Delay(1500);
                                                inCombat = true;
                                                firstTimeCombat = false;
                                                MyTurnAttack(1);
                                                CheckMonsterHealth();
                                                lblNrEnemies.Text = $"{FoesRemaining}";
                                                CheckAllMonsterDead();
                                                if (inCombat) EnemyTurn(attackMonster.Difficulty);

                                            }
                                            else
                                            {
                                                string text = (FoesNr == 1) ? attackMonster.Name + " is" : attackMonster.NamePlural + " are";
                                                txtMainWindow.Text += $"You've failed! You fall into a trap! {FoesNr} {text} attacking you\r\n";
                                                txtMainWindow.Text += "\r\n";
                                                lblNrEnemies.Text = $"{FoesRemaining}";
                                                lblEnemyHealth.Text = $"{attackMonster.CurrentHitPoints}/{attackMonster.MaximumHitPoints}";
                                                ScrollDownText(txtMainWindow);
                                                await Task.Delay(1500);
                                                EnemyTurn(attackMonster.Difficulty);
                                                firstTimeCombat = false;
                                            }

                                        }
                                        else
                                        {


                                            if (FoesRemaining > 0 && button == ButtonChoice.Button1)
                                            {
                                                MyTurnAttack(1);
                                                CheckMonsterHealth();
                                                lblNrEnemies.Text = $"{FoesRemaining}";
                                                CheckAllMonsterDead();
                                                if (inCombat) EnemyTurn(attackMonster.Difficulty);
                                            }

                                            if (FoesRemaining > 0 && button == ButtonChoice.Button2)
                                            {
                                                txtMainWindow.Text += "You are aleady in combat. You cannot ambush!\r\n";
                                                txtMainWindow.Text += "\r\n";
                                                EnemyTurn(attackMonster.Difficulty);
                                            }
                                        }

                                    }
                                    break;                               
                                case ButtonChoice.Button3:
                                    UseItem();
                                    break;
                                case ButtonChoice.Button4:
                                    if (inCombat)
                                    {
                                        if (firstTimeCombat)  //----- means I haven't started the fight so I can try to avoid it
                                        {
                                            if (Ambush(EscAvoid.AvoidCombat))
                                            {
                                                txtMainWindow.Text += "You avoid the fight! \r\n";
                                                txtMainWindow.Text += "\r\n";
                                                ScrollDownText(txtMainWindow);
                                                await Task.Delay(1500);
                                                inCombat = false;
                                                firstTimeCombat = true;
                                                lblNrEnemies.Text = "";
                                                txtMainWindow.Text = "";
                                                Heal(50);
                                                Journey();
                                            }
                                            else
                                            {
                                                txtMainWindow.Text += "You've failed to avoid the fight and now you're in combat! \r\n";
                                                txtMainWindow.Text += "\r\n";
                                                lblNrEnemies.Text = $"{FoesRemaining}";
                                                lblEnemyHealth.Text = $"{attackMonster.CurrentHitPoints}/{attackMonster.MaximumHitPoints}";
                                                ScrollDownText(txtMainWindow);
                                                firstTimeCombat = false;
                                            }

                                        }
                                        else //--- I'm during the fight but I can try to flee
                                        {
                                            if (Ambush(EscAvoid.FleeCombat))
                                            {
                                                txtMainWindow.Text += "You escaped the fight! \r\n";
                                                txtMainWindow.Text += "\r\n";
                                                ScrollDownText(txtMainWindow);
                                                await Task.Delay(1500);
                                                inCombat = false;
                                                firstTimeCombat = true;
                                                txtMainWindow.Text = "";
                                                lblNrEnemies.Text = "";
                                                lblEnemyHealth.Text = "";
                                                Heal(50);
                                                Journey();
                                            }
                                            else
                                            {
                                                txtMainWindow.Text += "You've failed to escape the fight! \r\n";
                                                txtMainWindow.Text += "\r\n";

                                                ScrollDownText(txtMainWindow);
                                                EnemyTurn(attackMonster.Difficulty);
                                            }
                                        }

                                    }
                                    else Journey();
                                    break;
                            }
                            break;
                    }
                    break;
                case GamePhase.Shop:
                    switch (button)
                    {
                        case ButtonChoice.Button1:
                            if (GeneralStore.ElementAt(Buy1).Price>player.Gold)
                            {
                                txtMainWindow.Text = "You do not have enough Gold!\r\n";
                                await Task.Delay(1500);
                                GeneralStoreShop();
                            }
                            else
                            {
                                player.Gold -= GeneralStore.ElementAt(Buy1).Price;

                                if (!CheckItemInInventory(Buy1))
                                {
                                    player.Inventory.Add(new InventoryItem(GeneralStore.ElementAt(Buy1).Details, 1));

                                }
                                UpdateInventoryGrid();
                                UpdateStats();
                                UpdateConsumableListInUI();


                            }
                            break;
                        case ButtonChoice.Button2:
                            if (GeneralStore.ElementAt(Buy2).Price > player.Gold)
                            {
                                txtMainWindow.Text = "You do not have enough Gold!\r\n";
                                await Task.Delay(1500);
                                GeneralStoreShop();
                            }
                            else
                            {
                                player.Gold -= GeneralStore.ElementAt(Buy2).Price;

                                if (!CheckItemInInventory(Buy2))
                                {
                                    player.Inventory.Add(new InventoryItem(GeneralStore.ElementAt(Buy2).Details, 1));

                                }
                                UpdateInventoryGrid();
                                UpdateStats();
                                UpdateConsumableListInUI();
                            }
                                break;
                        case ButtonChoice.Button3:
                            if (GeneralStore.ElementAt(Buy3).Price > player.Gold)
                            {
                                txtMainWindow.Text = "You do not have enough Gold!\r\n";
                                await Task.Delay(1500);
                                GeneralStoreShop();
                            }
                            else
                            {
                                player.Gold -= GeneralStore.ElementAt(Buy3).Price;

                                if (!CheckItemInInventory(Buy3))
                                {
                                    player.Inventory.Add(new InventoryItem(GeneralStore.ElementAt(Buy3).Details, 1));

                                }
                                UpdateInventoryGrid();
                                UpdateStats();
                                UpdateConsumableListInUI();
                            }
                            break;
                        case ButtonChoice.Button4:
                            Tavern();
                            break;
                    }
                    break;
                case GamePhase.BossEnd:
                    switch (button)
                    {
                        case ButtonChoice.Button1:                            
                        case ButtonChoice.Button2:                            
                        case ButtonChoice.Button3:                            
                        case ButtonChoice.Button4:
                            txtMainWindow.Text += $"You return home with your reward: {GetReward(mChoice)} gold! \r\n";
                            txtMainWindow.Text += "\r\n";
                            player.Gold += GetReward(mChoice);
                            UpdateStats();
                            ScrollDownText(txtMainWindow);
                            await Task.Delay(2000);
                            Tavern();
                            break;
                    }
                    break;
                case GamePhase.BossEncounter:
                    switch (button)
                    {
                        case ButtonChoice.Button1:
                            MyTurnAttack(1);
                            CheckMonsterHealth();
                            if (inCombat) EnemyTurn(CreatureClass.Boss);
                            break;
                        case ButtonChoice.Button2:
                            if (firstTimeCombat)
                            {
                                if (Ambush(EscAvoid.Ambush))
                                {

                                    txtMainWindow.Text += $"You succeed! You successfully ambushed the enemy \r\n";
                                    txtMainWindow.Text += "\r\n";
                                    firstTimeCombat = false;
                                    ScrollDownText(txtMainWindow);
                                    await Task.Delay(1500);
                                    MyTurnAttack(2);
                                    CheckMonsterHealth();
                                    EnemyTurn(CreatureClass.Boss);

                                }
                                else
                                {
                                    txtMainWindow.Text += $"You've failed the ambush! The enemy sees you and attacks you first! \r\n";
                                    txtMainWindow.Text += "\r\n";
                                    ScrollDownText(txtMainWindow);
                                    firstTimeCombat = false;
                                    await Task.Delay(1500);
                                    EnemyTurn(CreatureClass.Boss);
                                }
                            }
                            else
                            {
                                txtMainWindow.Text += "You cannot ambush your enemy, you're already in combat! \r\n";
                                txtMainWindow.Text += "\r\n";
                                ScrollDownText(txtMainWindow);
                                await Task.Delay(1500);
                                EnemyTurn(CreatureClass.Boss);
                            }                            
                            break;
                        case ButtonChoice.Button3:
                            UseItem();
                            break;
                        case ButtonChoice.Button4:
                            if (Ambush(EscAvoid.AvoidCombat))
                            {
                                txtMainWindow.Text += "You flee the night fight! \r\n";
                                txtMainWindow.Text += "\r\n";
                                ScrollDownText(txtMainWindow);
                                await Task.Delay(1500);
                                txtMainWindow.Text += "You return home empty handed and fail the mission! \r\n";
                                txtMainWindow.Text += "\r\n";
                                ScrollDownText(txtMainWindow);
                                await Task.Delay(2000);
                                inCombat = false;
                                firstTimeCombat = true;
                                txtMainWindow.Text = "";
                                CountDays = 0;
                                Heal(50 * 3);
                                playerQuest.IsCompleted = false;
                                Tavern();
                            }
                            else
                            {
                                txtMainWindow.Text += "You've failed to flee and now you're in combat! \r\n";
                                txtMainWindow.Text += "\r\n";
                                ScrollDownText(txtMainWindow);
                            }
                            break;
                    }
                    break;
                case GamePhase.Marrakesh:
                    switch (button)
                    {
                        case ButtonChoice.Button1:
                            break;
                        case ButtonChoice.Button2:
                            break;
                        case ButtonChoice.Button3:
                            break;
                        case ButtonChoice.Button4:
                            break;
                    }
                    break;
            }
        }
        
                 
        private int GetReward(InitialMenuChoice mC)
        {
            switch (mC)
            {
                case InitialMenuChoice.Quest1:
                    return Quest1.RewardGold;
                    
                case InitialMenuChoice.Quest2:
                    return Quest2.RewardGold;
                    
                case InitialMenuChoice.Quest3:
                    return Quest3.RewardGold;
                    
            }
            return 0;
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
                case GamePhase.JourneyMarrakesh:
                case GamePhase.BossEncounter:
                case GamePhase.BossEnd:
                    button1.Text = "Attack";
                    button2.Text = "Ambush";
                    button3.Text = "Use Item";
                    button4.Text = "Continue";
                    break;
                case GamePhase.Caravan:
                    button1.Text = "Option 1";
                    button2.Text = "Option 2";
                    button3.Text = "Use Item";
                    button4.Text = "Exit";
                    break;                
                case GamePhase.Marrakesh:
                    break;
                case GamePhase.Shop:
                    button1.Text = "Buy Item 1";
                    button2.Text = "Buy Item 2";
                    button3.Text = "Buy Item 3";
                    button4.Text = "Exit";
                    break;             
            }
            

        }

        private void GenerateDays()
        {
            Days = rnd.Next(2, 5);
        }

        private void Tavern()
        {
            CurrentPhase = GamePhase.Tavern;
            
            pnlMainBtn.Visible = true;
            pnlMainBtn.Enabled = true;
            pnlInventory.Visible = true;
            pnlInventory.Enabled = true;
            dgInventory.Visible = true;
            UpdateBtn();
            CountDays = 0;        
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
            lblEnemyHealth.Text = "";
            lblNrEnemies.Text = "";
            pMain.Enabled = true;
            pMain.Visible = true;
            pnlTop.Visible = true;

            player.Name = tInputName.Text;
            lHeroName.Text = player.Name;
            UpdateStats();

            txtMainWindow.Text = $"So you want to become a hero {player.Name} \r\n";
            txtMainWindow.Text += "\r\n";
            await Task.Delay(2000);
            txtMainWindow.Text += "You start as a weak \"wanna be hero\" barely able to wield a sword and kill a rat \r\n";
            await Task.Delay(1500);
            txtMainWindow.Text += "By accomplishing the missions you can pick up at the local tavern you will slowly become the hero of this forgotten land... or die trying!\r\n";
            await Task.Delay(3000);
            txtMainWindow.Text += "\r\n";
            txtMainWindow.Text += "The Goddes of Mercy has given you 5 attribute points to assign to your stats. Do so and your adventure can begin! \r\n";
            txtMainWindow.Text += "\r\n";
            ScrollDownText(txtMainWindow);            
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

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonChoice button = ButtonChoice.Button1;
            Actions(button);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ButtonChoice button = ButtonChoice.Button2;
            Actions(button);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonChoice button = ButtonChoice.Button3;
            Actions(button);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonChoice button = ButtonChoice.Button4;
            Actions(button);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
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
