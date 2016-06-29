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
            this.bLoadGame = new System.Windows.Forms.Button();
            this.txtMainWindow = new System.Windows.Forms.TextBox();
            this.bNewGane = new System.Windows.Forms.Button();
            this.pStart = new System.Windows.Forms.Panel();
            this.pMain = new System.Windows.Forms.Panel();
            this.lGold = new System.Windows.Forms.Label();
            this.lGoldtxt = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.tInputName = new System.Windows.Forms.TextBox();
            this.lNameInut = new System.Windows.Forms.Label();
            this.pNameInput = new System.Windows.Forms.Panel();
            this.bOk = new System.Windows.Forms.Button();
            this.lLevelNr = new System.Windows.Forms.Label();
            this.lLevelTxt = new System.Windows.Forms.Label();
            this.lExpTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pStart.SuspendLayout();
            this.pMain.SuspendLayout();
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
            this.txtMainWindow.Size = new System.Drawing.Size(789, 229);
            this.txtMainWindow.TabIndex = 12;
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
            this.pMain.Controls.Add(this.lExpTxt);
            this.pMain.Controls.Add(this.label4);
            this.pMain.Controls.Add(this.lLevelNr);
            this.pMain.Controls.Add(this.lLevelTxt);
            this.pMain.Controls.Add(this.lGold);
            this.pMain.Controls.Add(this.lGoldtxt);
            this.pMain.Controls.Add(this.bExit);
            this.pMain.Controls.Add(this.bLoad);
            this.pMain.Controls.Add(this.bSave);
            this.pMain.Controls.Add(this.button1);
            this.pMain.Controls.Add(this.button2);
            this.pMain.Controls.Add(this.button3);
            this.pMain.Controls.Add(this.button4);
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
            this.pMain.Location = new System.Drawing.Point(228, 48);
            this.pMain.Margin = new System.Windows.Forms.Padding(4);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(816, 540);
            this.pMain.TabIndex = 16;
            // 
            // lGold
            // 
            this.lGold.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lGold.Location = new System.Drawing.Point(652, 292);
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
            this.lGoldtxt.Location = new System.Drawing.Point(544, 294);
            this.lGoldtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGoldtxt.Name = "lGoldtxt";
            this.lGoldtxt.Size = new System.Drawing.Size(40, 18);
            this.lGoldtxt.TabIndex = 37;
            this.lGoldtxt.Text = "Gold";
            // 
            // bExit
            // 
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Location = new System.Drawing.Point(12, 396);
            this.bExit.Margin = new System.Windows.Forms.Padding(4);
            this.bExit.Name = "bExit";
            this.bExit.Padding = new System.Windows.Forms.Padding(4);
            this.bExit.Size = new System.Drawing.Size(61, 45);
            this.bExit.TabIndex = 36;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bLoad
            // 
            this.bLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLoad.Location = new System.Drawing.Point(12, 336);
            this.bLoad.Margin = new System.Windows.Forms.Padding(4);
            this.bLoad.Name = "bLoad";
            this.bLoad.Padding = new System.Windows.Forms.Padding(4);
            this.bLoad.Size = new System.Drawing.Size(61, 45);
            this.bLoad.TabIndex = 35;
            this.bLoad.Text = "Load";
            this.bLoad.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Location = new System.Drawing.Point(12, 278);
            this.bSave.Margin = new System.Windows.Forms.Padding(4);
            this.bSave.Name = "bSave";
            this.bSave.Padding = new System.Windows.Forms.Padding(4);
            this.bSave.Size = new System.Drawing.Size(61, 45);
            this.bSave.TabIndex = 34;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(340, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(4);
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 30;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(340, 336);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(4);
            this.button2.Size = new System.Drawing.Size(132, 45);
            this.button2.TabIndex = 31;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(340, 396);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(4);
            this.button3.Size = new System.Drawing.Size(132, 45);
            this.button3.TabIndex = 32;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(340, 456);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(4);
            this.button4.Size = new System.Drawing.Size(132, 45);
            this.button4.TabIndex = 33;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lChrNr
            // 
            this.lChrNr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lChrNr.Location = new System.Drawing.Point(652, 504);
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
            this.lChrTxt.Location = new System.Drawing.Point(544, 506);
            this.lChrTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lChrTxt.Name = "lChrTxt";
            this.lChrTxt.Size = new System.Drawing.Size(72, 18);
            this.lChrTxt.TabIndex = 27;
            this.lChrTxt.Text = "Charisma";
            // 
            // lDexNr
            // 
            this.lDexNr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lDexNr.Location = new System.Drawing.Point(652, 470);
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
            this.lDexTxt.Location = new System.Drawing.Point(544, 471);
            this.lDexTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDexTxt.Name = "lDexTxt";
            this.lDexTxt.Size = new System.Drawing.Size(80, 18);
            this.lDexTxt.TabIndex = 25;
            this.lDexTxt.Text = "Dexterity";
            // 
            // lIntNr
            // 
            this.lIntNr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lIntNr.Location = new System.Drawing.Point(652, 440);
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
            this.lIntTxt.Location = new System.Drawing.Point(544, 442);
            this.lIntTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lIntTxt.Name = "lIntTxt";
            this.lIntTxt.Size = new System.Drawing.Size(104, 18);
            this.lIntTxt.TabIndex = 23;
            this.lIntTxt.Text = "Intelligence";
            // 
            // lStrNr
            // 
            this.lStrNr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lStrNr.Location = new System.Drawing.Point(652, 408);
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
            this.lStrTxt.Location = new System.Drawing.Point(544, 410);
            this.lStrTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lStrTxt.Name = "lStrTxt";
            this.lStrTxt.Size = new System.Drawing.Size(72, 18);
            this.lStrTxt.TabIndex = 21;
            this.lStrTxt.Text = "Strength";
            // 
            // lHealthNr
            // 
            this.lHealthNr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lHealthNr.Location = new System.Drawing.Point(652, 380);
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
            this.lHealthTxt.Location = new System.Drawing.Point(544, 382);
            this.lHealthTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHealthTxt.Name = "lHealthTxt";
            this.lHealthTxt.Size = new System.Drawing.Size(56, 18);
            this.lHealthTxt.TabIndex = 19;
            this.lHealthTxt.Text = "Health";
            // 
            // lHeroName
            // 
            this.lHeroName.AutoSize = true;
            this.lHeroName.Location = new System.Drawing.Point(649, 256);
            this.lHeroName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHeroName.Name = "lHeroName";
            this.lHeroName.Size = new System.Drawing.Size(40, 18);
            this.lHeroName.TabIndex = 18;
            this.lHeroName.Text = "Name";
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
            // lLevelNr
            // 
            this.lLevelNr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lLevelNr.Location = new System.Drawing.Point(652, 322);
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
            this.lLevelTxt.Location = new System.Drawing.Point(544, 324);
            this.lLevelTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLevelTxt.Name = "lLevelTxt";
            this.lLevelTxt.Size = new System.Drawing.Size(48, 18);
            this.lLevelTxt.TabIndex = 39;
            this.lLevelTxt.Text = "Level";
            // 
            // lExpTxt
            // 
            this.lExpTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lExpTxt.Location = new System.Drawing.Point(652, 350);
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
            this.label4.Location = new System.Drawing.Point(544, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Experience";
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
            this.pNameInput.ResumeLayout(false);
            this.pNameInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bLoadGame;
        private System.Windows.Forms.TextBox txtMainWindow;
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
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Button bSave;
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
    }
}

