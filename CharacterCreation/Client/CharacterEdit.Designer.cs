namespace Client
{
    partial class CharacterEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.hitTextBox = new System.Windows.Forms.TextBox();
            this.staminaTextBox = new System.Windows.Forms.TextBox();
            this.critTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.raceLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.classIcon = new System.Windows.Forms.PictureBox();
            this.raceIcon = new System.Windows.Forms.PictureBox();
            this.defenceLabel = new System.Windows.Forms.Label();
            this.defenceTextBox = new System.Windows.Forms.TextBox();
            this.raceDropdown = new System.Windows.Forms.ComboBox();
            this.classDropdown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.classIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stamina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Crit:";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(60, 12);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(134, 20);
            this.nameTextbox.TabIndex = 4;
            // 
            // hitTextBox
            // 
            this.hitTextBox.Location = new System.Drawing.Point(60, 93);
            this.hitTextBox.Name = "hitTextBox";
            this.hitTextBox.Size = new System.Drawing.Size(64, 20);
            this.hitTextBox.TabIndex = 5;
            // 
            // staminaTextBox
            // 
            this.staminaTextBox.Location = new System.Drawing.Point(60, 119);
            this.staminaTextBox.Name = "staminaTextBox";
            this.staminaTextBox.Size = new System.Drawing.Size(64, 20);
            this.staminaTextBox.TabIndex = 6;
            // 
            // critTextBox
            // 
            this.critTextBox.Location = new System.Drawing.Point(60, 146);
            this.critTextBox.Name = "critTextBox";
            this.critTextBox.Size = new System.Drawing.Size(64, 20);
            this.critTextBox.TabIndex = 7;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(130, 268);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(64, 23);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(130, 297);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(64, 23);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(18, 41);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(36, 13);
            this.raceLabel.TabIndex = 10;
            this.raceLabel.Text = "Race:";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(21, 67);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(35, 13);
            this.classLabel.TabIndex = 12;
            this.classLabel.Text = "Class:";
            // 
            // classIcon
            // 
            this.classIcon.Location = new System.Drawing.Point(129, 198);
            this.classIcon.Name = "classIcon";
            this.classIcon.Size = new System.Drawing.Size(64, 64);
            this.classIcon.TabIndex = 14;
            this.classIcon.TabStop = false;
            // 
            // raceIcon
            // 
            this.raceIcon.Location = new System.Drawing.Point(60, 198);
            this.raceIcon.Name = "raceIcon";
            this.raceIcon.Size = new System.Drawing.Size(64, 64);
            this.raceIcon.TabIndex = 15;
            this.raceIcon.TabStop = false;
            // 
            // defenceLabel
            // 
            this.defenceLabel.AutoSize = true;
            this.defenceLabel.Location = new System.Drawing.Point(6, 175);
            this.defenceLabel.Name = "defenceLabel";
            this.defenceLabel.Size = new System.Drawing.Size(51, 13);
            this.defenceLabel.TabIndex = 16;
            this.defenceLabel.Text = "Defence:";
            // 
            // defenceTextBox
            // 
            this.defenceTextBox.Location = new System.Drawing.Point(60, 172);
            this.defenceTextBox.Name = "defenceTextBox";
            this.defenceTextBox.Size = new System.Drawing.Size(64, 20);
            this.defenceTextBox.TabIndex = 17;
            // 
            // raceDropdown
            // 
            this.raceDropdown.FormattingEnabled = true;
            this.raceDropdown.Items.AddRange(new object[] {
            "Blood Elf",
            "Draenei",
            "Gnome",
            "Human",
            "Night Elf",
            "Orc",
            "Troll",
            "Worgen"});
            this.raceDropdown.Location = new System.Drawing.Point(60, 38);
            this.raceDropdown.Name = "raceDropdown";
            this.raceDropdown.Size = new System.Drawing.Size(133, 21);
            this.raceDropdown.TabIndex = 18;
            this.raceDropdown.SelectedIndexChanged += new System.EventHandler(this.raceDropdown_SelectedIndexChanged);
            // 
            // classDropdown
            // 
            this.classDropdown.FormattingEnabled = true;
            this.classDropdown.Items.AddRange(new object[] {
            "Death Knight",
            "Druid",
            "Hunter",
            "Mage",
            "Monk",
            "Paladin",
            "Priest",
            "Rogue",
            "Shaman",
            "Warlock",
            "Warrior"});
            this.classDropdown.Location = new System.Drawing.Point(60, 66);
            this.classDropdown.Name = "classDropdown";
            this.classDropdown.Size = new System.Drawing.Size(133, 21);
            this.classDropdown.TabIndex = 19;
            this.classDropdown.SelectedIndexChanged += new System.EventHandler(this.classDropdown_SelectedIndexChanged);
            // 
            // CharacterEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 333);
            this.Controls.Add(this.classDropdown);
            this.Controls.Add(this.raceDropdown);
            this.Controls.Add(this.defenceTextBox);
            this.Controls.Add(this.defenceLabel);
            this.Controls.Add(this.raceIcon);
            this.Controls.Add(this.classIcon);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.critTextBox);
            this.Controls.Add(this.staminaTextBox);
            this.Controls.Add(this.hitTextBox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterEdit";
            this.ShowIcon = false;
            this.Text = "Character Edit";
            this.Load += new System.EventHandler(this.CharacterEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox hitTextBox;
        private System.Windows.Forms.TextBox staminaTextBox;
        private System.Windows.Forms.TextBox critTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.PictureBox classIcon;
        private System.Windows.Forms.PictureBox raceIcon;
        private System.Windows.Forms.Label defenceLabel;
        private System.Windows.Forms.TextBox defenceTextBox;
        private System.Windows.Forms.ComboBox raceDropdown;
        private System.Windows.Forms.ComboBox classDropdown;
    }
}