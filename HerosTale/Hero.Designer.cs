namespace HerosTale
{
    partial class frmBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bLoadGame = new System.Windows.Forms.Button();
            this.bNewGane = new System.Windows.Forms.Button();
            this.pStart = new System.Windows.Forms.Panel();
            this.pMain = new System.Windows.Forms.Panel();
            this.dgInventory = new System.Windows.Forms.DataGridView();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboConsumable = new System.Windows.Forms.ComboBox();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.pnlMainBtn = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlLevelUp = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btLvlUpOk = new System.Windows.Forms.Button();
            this.lblLvlPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btLessChar = new System.Windows.Forms.Button();
            this.btPlusChar = new System.Windows.Forms.Button();
            this.btLessDex = new System.Windows.Forms.Button();
            this.btPlusDex = new System.Windows.Forms.Button();
            this.btLessInt = new System.Windows.Forms.Button();
            this.btLessStr = new System.Windows.Forms.Button();
            this.btPlusStr = new System.Windows.Forms.Button();
            this.btPlusInt = new System.Windows.Forms.Button();
            this.lExpTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lLevelNr = new System.Windows.Forms.Label();
            this.lLevelTxt = new System.Windows.Forms.Label();
            this.lGold = new System.Windows.Forms.Label();
            this.lGoldtxt = new System.Windows.Forms.Label();
            this.lChrNr = new System.Windows.Forms.Label();
            this.lChrTxt = new System.Windows.Forms.Label();
            this.lDexNr = new System.Windows.Forms.Label();
            this.lDexTxt = new System.Windows.Forms.Label();
            this.lIntNr = new System.Windows.Forms.Label();
            this.lIntTxt = new System.Windows.Forms.Label();
            this.lStrNr = new System.Windows.Forms.Label();
            this.lStrTxt = new System.Windows.Forms.Label();
            this.lHealthNr = new System.Windows.Forms.Label();
            this.lHealthTxt = new System.Windows.Forms.Label();
            this.lHeroName = new System.Windows.Forms.Label();
            this.txtMainWindow = new System.Windows.Forms.TextBox();
            this.tInputName = new System.Windows.Forms.TextBox();
            this.lNameInut = new System.Windows.Forms.Label();
            this.pNameInput = new System.Windows.Forms.Panel();
            this.bOk = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pStart.SuspendLayout();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            this.pnlInventory.SuspendLayout();
            this.pnlMainBtn.SuspendLayout();
            this.pnlLevelUp.SuspendLayout();
            this.pNameInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // bLoadGame
            // 
            this.bLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLoadGame.Location = new System.Drawing.Point(4, 58);
            this.bLoadGame.Margin = new System.Windows.Forms.Padding(4);
            this.bLoadGame.Name = "bLoadGame";
            this.bLoadGame.Padding = new System.Windows.Forms.Padding(4);
            this.bLoadGame.Size = new System.Drawing.Size(108, 46);
            this.bLoadGame.TabIndex = 1;
            this.bLoadGame.Text = "Load Game";
            this.bLoadGame.UseVisualStyleBackColor = true;
            // 
            // bNewGane
            // 
            this.bNewGane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNewGane.Location = new System.Drawing.Point(4, 4);
            this.bNewGane.Margin = new System.Windows.Forms.Padding(4);
            this.bNewGane.Name = "bNewGane";
            this.bNewGane.Padding = new System.Windows.Forms.Padding(4);
            this.bNewGane.Size = new System.Drawing.Size(108, 46);
            this.bNewGane.TabIndex = 2;
            this.bNewGane.Text = "New Game";
            this.bNewGane.UseVisualStyleBackColor = true;
            this.bNewGane.Click += new System.EventHandler(this.bNewGane_Click);
            // 
            // pStart
            // 
            this.pStart.Controls.Add(this.bLoadGame);
            this.pStart.Controls.Add(this.bNewGane);
            this.pStart.Location = new System.Drawing.Point(12, 13);
            this.pStart.Margin = new System.Windows.Forms.Padding(4);
            this.pStart.Name = "pStart";
            this.pStart.Size = new System.Drawing.Size(121, 116);
            this.pStart.TabIndex = 7;
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.dgInventory);
            this.pMain.Controls.Add(this.pnlInventory);
            this.pMain.Controls.Add(this.pnlMainBtn);
            this.pMain.Controls.Add(this.pnlLevelUp);
            this.pMain.Controls.Add(this.lExpTxt);
            this.pMain.Controls.Add(this.label4);
            this.pMain.Controls.Add(this.lLevelNr);
            this.pMain.Controls.Add(this.lLevelTxt);
            this.pMain.Controls.Add(this.lGold);
            this.pMain.Controls.Add(this.lGoldtxt);
            this.pMain.Controls.Add(this.lChrNr);
            this.pMain.Controls.Add(this.lChrTxt);
            this.pMain.Controls.Add(this.lDexNr);
            this.pMain.Controls.Add(this.lDexTxt);
            this.pMain.Controls.Add(this.lIntNr);
            this.pMain.Controls.Add(this.lIntTxt);
            this.pMain.Controls.Add(this.lStrNr);
            this.pMain.Controls.Add(this.lStrTxt);
            this.pMain.Controls.Add(this.lHealthNr);
            this.pMain.Controls.Add(this.lHealthTxt);
            this.pMain.Controls.Add(this.lHeroName);
            this.pMain.Controls.Add(this.txtMainWindow);
            this.pMain.Location = new System.Drawing.Point(239, 13);
            this.pMain.Margin = new System.Windows.Forms.Padding(4);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(816, 603);
            this.pMain.TabIndex = 16;
            // 
            // dgInventory
            // 
            this.dgInventory.AllowUserToAddRows = false;
            this.dgInventory.AllowUserToDeleteRows = false;
            this.dgInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgInventory.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventory.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInventory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgInventory.Enabled = false;
            this.dgInventory.EnableHeadersVisualStyles = false;
            this.dgInventory.GridColor = System.Drawing.Color.Lime;
            this.dgInventory.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgInventory.Location = new System.Drawing.Point(12, 483);
            this.dgInventory.Name = "dgInventory";
            this.dgInventory.ReadOnly = true;
            this.dgInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgInventory.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventory.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgInventory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgInventory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventory.Size = new System.Drawing.Size(355, 110);
            this.dgInventory.TabIndex = 61;
            // 
            // pnlInventory
            // 
            this.pnlInventory.Controls.Add(this.label5);
            this.pnlInventory.Controls.Add(this.label3);
            this.pnlInventory.Controls.Add(this.cboConsumable);
            this.pnlInventory.Controls.Add(this.cboWeapons);
            this.pnlInventory.Location = new System.Drawing.Point(202, 248);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(342, 83);
            this.pnlInventory.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "Item";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 58;
            this.label3.Text = "Weapon";
            // 
            // cboConsumable
            // 
            this.cboConsumable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsumable.FormattingEnabled = true;
            this.cboConsumable.Location = new System.Drawing.Point(95, 45);
            this.cboConsumable.Name = "cboConsumable";
            this.cboConsumable.Size = new System.Drawing.Size(238, 26);
            this.cboConsumable.TabIndex = 57;
            // 
            // cboWeapons
            // 
            this.cboWeapons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(95, 12);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(238, 26);
            this.cboWeapons.TabIndex = 56;
            // 
            // pnlMainBtn
            // 
            this.pnlMainBtn.Controls.Add(this.button1);
            this.pnlMainBtn.Controls.Add(this.button2);
            this.pnlMainBtn.Controls.Add(this.button3);
            this.pnlMainBtn.Controls.Add(this.button4);
            this.pnlMainBtn.Location = new System.Drawing.Point(26, 256);
            this.pnlMainBtn.Name = "pnlMainBtn";
            this.pnlMainBtn.Size = new System.Drawing.Size(160, 221);
            this.pnlMainBtn.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(20, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(4);
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 30;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(20, 61);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(4);
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 31;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(20, 110);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(4);
            this.button3.Size = new System.Drawing.Size(120, 40);
            this.button3.TabIndex = 32;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(20, 160);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(4);
            this.button4.Size = new System.Drawing.Size(120, 40);
            this.button4.TabIndex = 33;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlLevelUp
            // 
            this.pnlLevelUp.Controls.Add(this.label2);
            this.pnlLevelUp.Controls.Add(this.btLvlUpOk);
            this.pnlLevelUp.Controls.Add(this.lblLvlPoints);
            this.pnlLevelUp.Controls.Add(this.label1);
            this.pnlLevelUp.Controls.Add(this.btLessChar);
            this.pnlLevelUp.Controls.Add(this.btPlusChar);
            this.pnlLevelUp.Controls.Add(this.btLessDex);
            this.pnlLevelUp.Controls.Add(this.btPlusDex);
            this.pnlLevelUp.Controls.Add(this.btLessInt);
            this.pnlLevelUp.Controls.Add(this.btLessStr);
            this.pnlLevelUp.Controls.Add(this.btPlusStr);
            this.pnlLevelUp.Controls.Add(this.btPlusInt);
            this.pnlLevelUp.Location = new System.Drawing.Point(373, 385);
            this.pnlLevelUp.Name = "pnlLevelUp";
            this.pnlLevelUp.Size = new System.Drawing.Size(171, 201);
            this.pnlLevelUp.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Assign Stats Points";
            // 
            // btLvlUpOk
            // 
            this.btLvlUpOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLvlUpOk.Location = new System.Drawing.Point(35, 141);
            this.btLvlUpOk.Margin = new System.Windows.Forms.Padding(4);
            this.btLvlUpOk.Name = "btLvlUpOk";
            this.btLvlUpOk.Padding = new System.Windows.Forms.Padding(4);
            this.btLvlUpOk.Size = new System.Drawing.Size(45, 34);
            this.btLvlUpOk.TabIndex = 53;
            this.btLvlUpOk.Text = "OK";
            this.btLvlUpOk.UseVisualStyleBackColor = true;
            this.btLvlUpOk.Click += new System.EventHandler(this.btLvlUpOk_Click);
            // 
            // lblLvlPoints
            // 
            this.lblLvlPoints.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvlPoints.Location = new System.Drawing.Point(35, 87);
            this.lblLvlPoints.Name = "lblLvlPoints";
            this.lblLvlPoints.Size = new System.Drawing.Size(45, 22);
            this.lblLvlPoints.TabIndex = 52;
            this.lblLvlPoints.Text = "0";
            this.lblLvlPoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Points";
            // 
            // btLessChar
            // 
            this.btLessChar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btLessChar.AutoSize = true;
            this.btLessChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLessChar.Location = new System.Drawing.Point(136, 145);
            this.btLessChar.Margin = new System.Windows.Forms.Padding(0);
            this.btLessChar.Name = "btLessChar";
            this.btLessChar.Size = new System.Drawing.Size(32, 34);
            this.btLessChar.TabIndex = 50;
            this.btLessChar.Text = "-";
            this.btLessChar.UseVisualStyleBackColor = true;
            this.btLessChar.Click += new System.EventHandler(this.btLessChar_Click);
            // 
            // btPlusChar
            // 
            this.btPlusChar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btPlusChar.AutoSize = true;
            this.btPlusChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlusChar.Location = new System.Drawing.Point(108, 145);
            this.btPlusChar.Margin = new System.Windows.Forms.Padding(0);
            this.btPlusChar.Name = "btPlusChar";
            this.btPlusChar.Size = new System.Drawing.Size(32, 34);
            this.btPlusChar.TabIndex = 49;
            this.btPlusChar.Text = "+";
            this.btPlusChar.UseVisualStyleBackColor = true;
            this.btPlusChar.Click += new System.EventHandler(this.btPlusChar_Click);
            // 
            // btLessDex
            // 
            this.btLessDex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btLessDex.AutoSize = true;
            this.btLessDex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLessDex.Location = new System.Drawing.Point(136, 81);
            this.btLessDex.Margin = new System.Windows.Forms.Padding(0);
            this.btLessDex.Name = "btLessDex";
            this.btLessDex.Size = new System.Drawing.Size(32, 34);
            this.btLessDex.TabIndex = 48;
            this.btLessDex.Text = "-";
            this.btLessDex.UseVisualStyleBackColor = true;
            this.btLessDex.Click += new System.EventHandler(this.btLessDex_Click);
            // 
            // btPlusDex
            // 
            this.btPlusDex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btPlusDex.AutoSize = true;
            this.btPlusDex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlusDex.Location = new System.Drawing.Point(108, 81);
            this.btPlusDex.Margin = new System.Windows.Forms.Padding(0);
            this.btPlusDex.Name = "btPlusDex";
            this.btPlusDex.Size = new System.Drawing.Size(32, 34);
            this.btPlusDex.TabIndex = 47;
            this.btPlusDex.Text = "+";
            this.btPlusDex.UseVisualStyleBackColor = true;
            this.btPlusDex.Click += new System.EventHandler(this.btPlusDex_Click);
            // 
            // btLessInt
            // 
            this.btLessInt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btLessInt.AutoSize = true;
            this.btLessInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLessInt.Location = new System.Drawing.Point(136, 112);
            this.btLessInt.Margin = new System.Windows.Forms.Padding(0);
            this.btLessInt.Name = "btLessInt";
            this.btLessInt.Size = new System.Drawing.Size(32, 34);
            this.btLessInt.TabIndex = 46;
            this.btLessInt.Text = "-";
            this.btLessInt.UseVisualStyleBackColor = true;
            this.btLessInt.Click += new System.EventHandler(this.btLessInt_Click);
            // 
            // btLessStr
            // 
            this.btLessStr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btLessStr.AutoSize = true;
            this.btLessStr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLessStr.Location = new System.Drawing.Point(136, 45);
            this.btLessStr.Margin = new System.Windows.Forms.Padding(0);
            this.btLessStr.Name = "btLessStr";
            this.btLessStr.Size = new System.Drawing.Size(32, 34);
            this.btLessStr.TabIndex = 44;
            this.btLessStr.Text = "-";
            this.btLessStr.UseVisualStyleBackColor = true;
            this.btLessStr.Click += new System.EventHandler(this.btLessStr_Click);
            // 
            // btPlusStr
            // 
            this.btPlusStr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btPlusStr.AutoSize = true;
            this.btPlusStr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlusStr.Location = new System.Drawing.Point(108, 45);
            this.btPlusStr.Margin = new System.Windows.Forms.Padding(0);
            this.btPlusStr.Name = "btPlusStr";
            this.btPlusStr.Size = new System.Drawing.Size(32, 34);
            this.btPlusStr.TabIndex = 43;
            this.btPlusStr.Text = "+";
            this.btPlusStr.UseVisualStyleBackColor = true;
            this.btPlusStr.Click += new System.EventHandler(this.btPlusStr_Click);
            // 
            // btPlusInt
            // 
            this.btPlusInt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btPlusInt.AutoSize = true;
            this.btPlusInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlusInt.Location = new System.Drawing.Point(108, 112);
            this.btPlusInt.Margin = new System.Windows.Forms.Padding(0);
            this.btPlusInt.Name = "btPlusInt";
            this.btPlusInt.Size = new System.Drawing.Size(32, 34);
            this.btPlusInt.TabIndex = 45;
            this.btPlusInt.Text = "+";
            this.btPlusInt.UseVisualStyleBackColor = true;
            this.btPlusInt.Click += new System.EventHandler(this.btPlusInt_Click);
            // 
            // lExpTxt
            // 
            this.lExpTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lExpTxt.Location = new System.Drawing.Point(652, 374);
            this.lExpTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lExpTxt.Name = "lExpTxt";
            this.lExpTxt.Size = new System.Drawing.Size(100, 20);
            this.lExpTxt.TabIndex = 42;
            this.lExpTxt.Text = "0";
            this.lExpTxt.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 376);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Experience";
            // 
            // lLevelNr
            // 
            this.lLevelNr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lLevelNr.Location = new System.Drawing.Point(652, 346);
            this.lLevelNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLevelNr.Name = "lLevelNr";
            this.lLevelNr.Size = new System.Drawing.Size(100, 20);
            this.lLevelNr.TabIndex = 40;
            this.lLevelNr.Text = "0";
            this.lLevelNr.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lLevelTxt
            // 
            this.lLevelTxt.AutoSize = true;
            this.lLevelTxt.Location = new System.Drawing.Point(550, 348);
            this.lLevelTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLevelTxt.Name = "lLevelTxt";
            this.lLevelTxt.Size = new System.Drawing.Size(48, 18);
            this.lLevelTxt.TabIndex = 39;
            this.lLevelTxt.Text = "Level";
            // 
            // lGold
            // 
            this.lGold.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lGold.Location = new System.Drawing.Point(652, 316);
            this.lGold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGold.Name = "lGold";
            this.lGold.Size = new System.Drawing.Size(100, 20);
            this.lGold.TabIndex = 38;
            this.lGold.Text = "0";
            this.lGold.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lGoldtxt
            // 
            this.lGoldtxt.AutoSize = true;
            this.lGoldtxt.Location = new System.Drawing.Point(550, 318);
            this.lGoldtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGoldtxt.Name = "lGoldtxt";
            this.lGoldtxt.Size = new System.Drawing.Size(40, 18);
            this.lGoldtxt.TabIndex = 37;
            this.lGoldtxt.Text = "Gold";
            // 
            // lChrNr
            // 
            this.lChrNr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lChrNr.Location = new System.Drawing.Point(652, 535);
            this.lChrNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lChrNr.Name = "lChrNr";
            this.lChrNr.Size = new System.Drawing.Size(100, 20);
            this.lChrNr.TabIndex = 28;
            this.lChrNr.Text = "0";
            this.lChrNr.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lChrTxt
            // 
            this.lChrTxt.AutoSize = true;
            this.lChrTxt.Location = new System.Drawing.Point(550, 537);
            this.lChrTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lChrTxt.Name = "lChrTxt";
            this.lChrTxt.Size = new System.Drawing.Size(72, 18);
            this.lChrTxt.TabIndex = 27;
            this.lChrTxt.Text = "Charisma";
            // 
            // lDexNr
            // 
            this.lDexNr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lDexNr.Location = new System.Drawing.Point(652, 471);
            this.lDexNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDexNr.Name = "lDexNr";
            this.lDexNr.Size = new System.Drawing.Size(100, 20);
            this.lDexNr.TabIndex = 26;
            this.lDexNr.Text = "0";
            this.lDexNr.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lDexTxt
            // 
            this.lDexTxt.AutoSize = true;
            this.lDexTxt.Location = new System.Drawing.Point(550, 472);
            this.lDexTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDexTxt.Name = "lDexTxt";
            this.lDexTxt.Size = new System.Drawing.Size(80, 18);
            this.lDexTxt.TabIndex = 25;
            this.lDexTxt.Text = "Dexterity";
            // 
            // lIntNr
            // 
            this.lIntNr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lIntNr.Location = new System.Drawing.Point(652, 502);
            this.lIntNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lIntNr.Name = "lIntNr";
            this.lIntNr.Size = new System.Drawing.Size(100, 20);
            this.lIntNr.TabIndex = 24;
            this.lIntNr.Text = "0";
            this.lIntNr.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lIntTxt
            // 
            this.lIntTxt.AutoSize = true;
            this.lIntTxt.Location = new System.Drawing.Point(550, 504);
            this.lIntTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lIntTxt.Name = "lIntTxt";
            this.lIntTxt.Size = new System.Drawing.Size(104, 18);
            this.lIntTxt.TabIndex = 23;
            this.lIntTxt.Text = "Intelligence";
            // 
            // lStrNr
            // 
            this.lStrNr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lStrNr.Location = new System.Drawing.Point(652, 436);
            this.lStrNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lStrNr.Name = "lStrNr";
            this.lStrNr.Size = new System.Drawing.Size(100, 20);
            this.lStrNr.TabIndex = 22;
            this.lStrNr.Text = "0";
            this.lStrNr.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lStrTxt
            // 
            this.lStrTxt.AutoSize = true;
            this.lStrTxt.Location = new System.Drawing.Point(550, 437);
            this.lStrTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lStrTxt.Name = "lStrTxt";
            this.lStrTxt.Size = new System.Drawing.Size(72, 18);
            this.lStrTxt.TabIndex = 21;
            this.lStrTxt.Text = "Strength";
            // 
            // lHealthNr
            // 
            this.lHealthNr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lHealthNr.Location = new System.Drawing.Point(652, 404);
            this.lHealthNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHealthNr.Name = "lHealthNr";
            this.lHealthNr.Size = new System.Drawing.Size(100, 20);
            this.lHealthNr.TabIndex = 20;
            this.lHealthNr.Text = "1000/1000";
            this.lHealthNr.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lHealthTxt
            // 
            this.lHealthTxt.AutoSize = true;
            this.lHealthTxt.Location = new System.Drawing.Point(550, 406);
            this.lHealthTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHealthTxt.Name = "lHealthTxt";
            this.lHealthTxt.Size = new System.Drawing.Size(56, 18);
            this.lHealthTxt.TabIndex = 19;
            this.lHealthTxt.Text = "Health";
            // 
            // lHeroName
            // 
            this.lHeroName.AutoSize = true;
            this.lHeroName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeroName.Location = new System.Drawing.Point(632, 280);
            this.lHeroName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHeroName.Name = "lHeroName";
            this.lHeroName.Size = new System.Drawing.Size(50, 22);
            this.lHeroName.TabIndex = 18;
            this.lHeroName.Text = "Name";
            // 
            // txtMainWindow
            // 
            this.txtMainWindow.BackColor = System.Drawing.Color.Black;
            this.txtMainWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMainWindow.ForeColor = System.Drawing.Color.Lime;
            this.txtMainWindow.Location = new System.Drawing.Point(12, 12);
            this.txtMainWindow.Margin = new System.Windows.Forms.Padding(4);
            this.txtMainWindow.Multiline = true;
            this.txtMainWindow.Name = "txtMainWindow";
            this.txtMainWindow.ReadOnly = true;
            this.txtMainWindow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMainWindow.Size = new System.Drawing.Size(789, 229);
            this.txtMainWindow.TabIndex = 12;
            this.txtMainWindow.TabStop = false;
            // 
            // tInputName
            // 
            this.tInputName.AcceptsReturn = true;
            this.tInputName.AcceptsTab = true;
            this.tInputName.BackColor = System.Drawing.Color.Black;
            this.tInputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tInputName.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.tInputName.ForeColor = System.Drawing.Color.Lime;
            this.tInputName.Location = new System.Drawing.Point(7, 48);
            this.tInputName.MaxLength = 20;
            this.tInputName.Name = "tInputName";
            this.tInputName.Size = new System.Drawing.Size(194, 25);
            this.tInputName.TabIndex = 17;
            this.tInputName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tInputName_KeyPress);
            // 
            // lNameInut
            // 
            this.lNameInut.AutoSize = true;
            this.lNameInut.Location = new System.Drawing.Point(9, 14);
            this.lNameInut.Name = "lNameInut";
            this.lNameInut.Size = new System.Drawing.Size(192, 18);
            this.lNameInut.TabIndex = 18;
            this.lNameInut.Text = "What\'s you Hero\'s Name?";
            // 
            // pNameInput
            // 
            this.pNameInput.Controls.Add(this.bOk);
            this.pNameInput.Controls.Add(this.lNameInut);
            this.pNameInput.Controls.Add(this.tInputName);
            this.pNameInput.Location = new System.Drawing.Point(10, 197);
            this.pNameInput.Name = "pNameInput";
            this.pNameInput.Size = new System.Drawing.Size(211, 125);
            this.pNameInput.TabIndex = 19;
            // 
            // bOk
            // 
            this.bOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOk.Location = new System.Drawing.Point(78, 80);
            this.bOk.Margin = new System.Windows.Forms.Padding(4);
            this.bOk.Name = "bOk";
            this.bOk.Padding = new System.Windows.Forms.Padding(4);
            this.bOk.Size = new System.Drawing.Size(45, 34);
            this.bOk.TabIndex = 35;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1068, 618);
            this.Controls.Add(this.pNameInput);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pStart);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmBase";
            this.ShowIcon = false;
            this.Text = "Hero\'s Tale";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.pStart.ResumeLayout(false);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            this.pnlInventory.ResumeLayout(false);
            this.pnlInventory.PerformLayout();
            this.pnlMainBtn.ResumeLayout(false);
            this.pnlLevelUp.ResumeLayout(false);
            this.pnlLevelUp.PerformLayout();
            this.pNameInput.ResumeLayout(false);
            this.pNameInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bLoadGame;
        private System.Windows.Forms.Button bNewGane;
        private System.Windows.Forms.Panel pStart;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lChrNr;
        private System.Windows.Forms.Label lChrTxt;
        private System.Windows.Forms.Label lDexNr;
        private System.Windows.Forms.Label lDexTxt;
        private System.Windows.Forms.Label lIntNr;
        private System.Windows.Forms.Label lIntTxt;
        private System.Windows.Forms.Label lStrNr;
        private System.Windows.Forms.Label lStrTxt;
        private System.Windows.Forms.Label lHealthNr;
        private System.Windows.Forms.Label lHealthTxt;
        private System.Windows.Forms.Label lHeroName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tInputName;
        private System.Windows.Forms.Label lNameInut;
        private System.Windows.Forms.Panel pNameInput;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label lGold;
        private System.Windows.Forms.Label lGoldtxt;
        private System.Windows.Forms.Label lExpTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lLevelNr;
        private System.Windows.Forms.Label lLevelTxt;
        private System.Windows.Forms.Button btLessChar;
        private System.Windows.Forms.Button btPlusChar;
        private System.Windows.Forms.Button btLessDex;
        private System.Windows.Forms.Button btPlusDex;
        private System.Windows.Forms.Button btLessInt;
        private System.Windows.Forms.Button btPlusInt;
        private System.Windows.Forms.Button btLessStr;
        private System.Windows.Forms.Button btPlusStr;
        private System.Windows.Forms.Panel pnlLevelUp;
        private System.Windows.Forms.Button btLvlUpOk;
        private System.Windows.Forms.Label lblLvlPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMainBtn;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboConsumable;
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.DataGridView dgInventory;
        private System.Windows.Forms.TextBox txtMainWindow;
    }
}

