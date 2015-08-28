namespace Weapons_Kit_Switcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ModernWeapon = new System.Windows.Forms.Button();
            this.ModernLauncher = new System.Windows.Forms.Button();
            this.WorldWar1Weapon = new System.Windows.Forms.Button();
            this.WorldWar2Weapon = new System.Windows.Forms.Button();
            this.SciFi = new System.Windows.Forms.Button();
            this.MedievalWeapon = new System.Windows.Forms.Button();
            this.VanillaWeapon = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Weapon = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modern Weapon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "World War 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SciFi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medieval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Modern Launcher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "World War 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vanilla Weapon";
            // 
            // ModernWeapon
            // 
            this.ModernWeapon.Location = new System.Drawing.Point(278, 26);
            this.ModernWeapon.Name = "ModernWeapon";
            this.ModernWeapon.Size = new System.Drawing.Size(75, 23);
            this.ModernWeapon.TabIndex = 7;
            this.ModernWeapon.Text = "button1";
            this.ModernWeapon.UseVisualStyleBackColor = true;
            this.ModernWeapon.Click += new System.EventHandler(this.Switch);
            // 
            // ModernLauncher
            // 
            this.ModernLauncher.Location = new System.Drawing.Point(278, 75);
            this.ModernLauncher.Name = "ModernLauncher";
            this.ModernLauncher.Size = new System.Drawing.Size(75, 23);
            this.ModernLauncher.TabIndex = 8;
            this.ModernLauncher.Text = "button2";
            this.ModernLauncher.UseVisualStyleBackColor = true;
            this.ModernLauncher.Click += new System.EventHandler(this.Switch);
            // 
            // WorldWar1Weapon
            // 
            this.WorldWar1Weapon.Location = new System.Drawing.Point(278, 126);
            this.WorldWar1Weapon.Name = "WorldWar1Weapon";
            this.WorldWar1Weapon.Size = new System.Drawing.Size(75, 23);
            this.WorldWar1Weapon.TabIndex = 9;
            this.WorldWar1Weapon.Text = "button3";
            this.WorldWar1Weapon.UseVisualStyleBackColor = true;
            this.WorldWar1Weapon.Click += new System.EventHandler(this.Switch);
            // 
            // WorldWar2Weapon
            // 
            this.WorldWar2Weapon.Location = new System.Drawing.Point(278, 170);
            this.WorldWar2Weapon.Name = "WorldWar2Weapon";
            this.WorldWar2Weapon.Size = new System.Drawing.Size(75, 23);
            this.WorldWar2Weapon.TabIndex = 10;
            this.WorldWar2Weapon.Text = "button4";
            this.WorldWar2Weapon.UseVisualStyleBackColor = true;
            this.WorldWar2Weapon.Click += new System.EventHandler(this.Switch);
            // 
            // SciFi
            // 
            this.SciFi.Location = new System.Drawing.Point(278, 217);
            this.SciFi.Name = "SciFi";
            this.SciFi.Size = new System.Drawing.Size(75, 23);
            this.SciFi.TabIndex = 11;
            this.SciFi.Text = "button5";
            this.SciFi.UseVisualStyleBackColor = true;
            this.SciFi.Click += new System.EventHandler(this.Switch);
            // 
            // MedievalWeapon
            // 
            this.MedievalWeapon.Location = new System.Drawing.Point(278, 268);
            this.MedievalWeapon.Name = "MedievalWeapon";
            this.MedievalWeapon.Size = new System.Drawing.Size(75, 23);
            this.MedievalWeapon.TabIndex = 12;
            this.MedievalWeapon.Text = "button6";
            this.MedievalWeapon.UseVisualStyleBackColor = true;
            this.MedievalWeapon.Click += new System.EventHandler(this.Switch);
            // 
            // VanillaWeapon
            // 
            this.VanillaWeapon.Location = new System.Drawing.Point(278, 315);
            this.VanillaWeapon.Name = "VanillaWeapon";
            this.VanillaWeapon.Size = new System.Drawing.Size(75, 23);
            this.VanillaWeapon.TabIndex = 13;
            this.VanillaWeapon.Text = "button7";
            this.VanillaWeapon.UseVisualStyleBackColor = true;
            this.VanillaWeapon.Click += new System.EventHandler(this.Switch);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select your RimWorld executable directory";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Select single weapons";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 348);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Weapon});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(394, 348);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
            // 
            // Weapon
            // 
            this.Weapon.Width = 389;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VanillaWeapon);
            this.Controls.Add(this.MedievalWeapon);
            this.Controls.Add(this.SciFi);
            this.Controls.Add(this.WorldWar2Weapon);
            this.Controls.Add(this.WorldWar1Weapon);
            this.Controls.Add(this.ModernLauncher);
            this.Controls.Add(this.ModernWeapon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Weapon Kit Switcher";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ModernWeapon;
        private System.Windows.Forms.Button ModernLauncher;
        private System.Windows.Forms.Button WorldWar1Weapon;
        private System.Windows.Forms.Button WorldWar2Weapon;
        private System.Windows.Forms.Button SciFi;
        private System.Windows.Forms.Button MedievalWeapon;
        private System.Windows.Forms.Button VanillaWeapon;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Weapon;
    }
}

