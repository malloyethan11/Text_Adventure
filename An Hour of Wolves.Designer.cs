
namespace Text_Adventure
{
    partial class Main
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
            this.ArmorStats = new System.Windows.Forms.ListBox();
            this.AttributeStats = new System.Windows.Forms.ListBox();
            this.Inventory = new System.Windows.Forms.ListBox();
            this.Food = new System.Windows.Forms.RadioButton();
            this.Weapons = new System.Windows.Forms.RadioButton();
            this.Armor = new System.Windows.Forms.RadioButton();
            this.Potions = new System.Windows.Forms.RadioButton();
            this.Choices = new System.Windows.Forms.ListBox();
            this.EquippedItems = new System.Windows.Forms.ListBox();
            this.quit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.update_inventory = new System.Windows.Forms.Button();
            this.upgrade_stats = new System.Windows.Forms.Button();
            this.use_potion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.slash = new System.Windows.Forms.Label();
            this.CurrentHealth = new System.Windows.Forms.Label();
            this.MaxHealth = new System.Windows.Forms.Label();
            this.submit_choice = new System.Windows.Forms.Button();
            this.StoryEvent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArmorStats
            // 
            this.ArmorStats.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmorStats.FormattingEnabled = true;
            this.ArmorStats.ItemHeight = 22;
            this.ArmorStats.Location = new System.Drawing.Point(12, 12);
            this.ArmorStats.Name = "ArmorStats";
            this.ArmorStats.Size = new System.Drawing.Size(282, 334);
            this.ArmorStats.TabIndex = 0;
            // 
            // AttributeStats
            // 
            this.AttributeStats.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttributeStats.FormattingEnabled = true;
            this.AttributeStats.ItemHeight = 22;
            this.AttributeStats.Location = new System.Drawing.Point(12, 354);
            this.AttributeStats.Name = "AttributeStats";
            this.AttributeStats.Size = new System.Drawing.Size(282, 378);
            this.AttributeStats.TabIndex = 1;
            // 
            // Inventory
            // 
            this.Inventory.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.FormattingEnabled = true;
            this.Inventory.ItemHeight = 22;
            this.Inventory.Location = new System.Drawing.Point(1136, 12);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(282, 334);
            this.Inventory.TabIndex = 3;
            // 
            // Food
            // 
            this.Food.AutoSize = true;
            this.Food.Location = new System.Drawing.Point(1136, 355);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(49, 17);
            this.Food.TabIndex = 4;
            this.Food.TabStop = true;
            this.Food.Text = "Food";
            this.Food.UseVisualStyleBackColor = true;
            // 
            // Weapons
            // 
            this.Weapons.AutoSize = true;
            this.Weapons.Location = new System.Drawing.Point(1198, 355);
            this.Weapons.Name = "Weapons";
            this.Weapons.Size = new System.Drawing.Size(71, 17);
            this.Weapons.TabIndex = 5;
            this.Weapons.TabStop = true;
            this.Weapons.Text = "Weapons";
            this.Weapons.UseVisualStyleBackColor = true;
            // 
            // Armor
            // 
            this.Armor.AutoSize = true;
            this.Armor.Location = new System.Drawing.Point(1284, 355);
            this.Armor.Name = "Armor";
            this.Armor.Size = new System.Drawing.Size(52, 17);
            this.Armor.TabIndex = 6;
            this.Armor.TabStop = true;
            this.Armor.Text = "Armor";
            this.Armor.UseVisualStyleBackColor = true;
            // 
            // Potions
            // 
            this.Potions.AutoSize = true;
            this.Potions.Location = new System.Drawing.Point(1355, 355);
            this.Potions.Name = "Potions";
            this.Potions.Size = new System.Drawing.Size(60, 17);
            this.Potions.TabIndex = 7;
            this.Potions.TabStop = true;
            this.Potions.Text = "Potions";
            this.Potions.UseVisualStyleBackColor = true;
            // 
            // Choices
            // 
            this.Choices.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choices.FormattingEnabled = true;
            this.Choices.ItemHeight = 22;
            this.Choices.Location = new System.Drawing.Point(300, 355);
            this.Choices.Name = "Choices";
            this.Choices.Size = new System.Drawing.Size(830, 334);
            this.Choices.TabIndex = 8;
            this.Choices.SelectedIndexChanged += new System.EventHandler(this.Choices_SelectedIndexChanged);
            // 
            // EquippedItems
            // 
            this.EquippedItems.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquippedItems.FormattingEnabled = true;
            this.EquippedItems.ItemHeight = 22;
            this.EquippedItems.Location = new System.Drawing.Point(1136, 399);
            this.EquippedItems.Name = "EquippedItems";
            this.EquippedItems.Size = new System.Drawing.Size(282, 290);
            this.EquippedItems.TabIndex = 9;
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(1305, 696);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(110, 40);
            this.quit.TabIndex = 10;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(1172, 696);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(110, 40);
            this.save.TabIndex = 11;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // update_inventory
            // 
            this.update_inventory.Location = new System.Drawing.Point(1041, 696);
            this.update_inventory.Name = "update_inventory";
            this.update_inventory.Size = new System.Drawing.Size(110, 40);
            this.update_inventory.TabIndex = 12;
            this.update_inventory.Text = "Update Inventory";
            this.update_inventory.UseVisualStyleBackColor = true;
            // 
            // upgrade_stats
            // 
            this.upgrade_stats.Location = new System.Drawing.Point(912, 696);
            this.upgrade_stats.Name = "upgrade_stats";
            this.upgrade_stats.Size = new System.Drawing.Size(110, 40);
            this.upgrade_stats.TabIndex = 13;
            this.upgrade_stats.Text = "Upgrade Stats";
            this.upgrade_stats.UseVisualStyleBackColor = true;
            // 
            // use_potion
            // 
            this.use_potion.Location = new System.Drawing.Point(781, 696);
            this.use_potion.Name = "use_potion";
            this.use_potion.Size = new System.Drawing.Size(110, 40);
            this.use_potion.TabIndex = 14;
            this.use_potion.Text = "Use Potion";
            this.use_potion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 703);
            this.label1.MinimumSize = new System.Drawing.Size(100, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "Health:";
            // 
            // slash
            // 
            this.slash.AutoSize = true;
            this.slash.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slash.Location = new System.Drawing.Point(511, 703);
            this.slash.MinimumSize = new System.Drawing.Size(5, 34);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(23, 34);
            this.slash.TabIndex = 16;
            this.slash.Text = "/";
            // 
            // CurrentHealth
            // 
            this.CurrentHealth.AutoSize = true;
            this.CurrentHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentHealth.Location = new System.Drawing.Point(408, 703);
            this.CurrentHealth.MinimumSize = new System.Drawing.Size(100, 34);
            this.CurrentHealth.Name = "CurrentHealth";
            this.CurrentHealth.Size = new System.Drawing.Size(100, 34);
            this.CurrentHealth.TabIndex = 17;
            // 
            // MaxHealth
            // 
            this.MaxHealth.AutoSize = true;
            this.MaxHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxHealth.Location = new System.Drawing.Point(531, 703);
            this.MaxHealth.MinimumSize = new System.Drawing.Size(100, 34);
            this.MaxHealth.Name = "MaxHealth";
            this.MaxHealth.Size = new System.Drawing.Size(100, 34);
            this.MaxHealth.TabIndex = 18;
            // 
            // submit_choice
            // 
            this.submit_choice.Location = new System.Drawing.Point(650, 696);
            this.submit_choice.Name = "submit_choice";
            this.submit_choice.Size = new System.Drawing.Size(110, 40);
            this.submit_choice.TabIndex = 19;
            this.submit_choice.Text = "Submit Choice";
            this.submit_choice.UseVisualStyleBackColor = true;
            // 
            // StoryEvent
            // 
            this.StoryEvent.AutoSize = true;
            this.StoryEvent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StoryEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoryEvent.Location = new System.Drawing.Point(307, 12);
            this.StoryEvent.MinimumSize = new System.Drawing.Size(820, 334);
            this.StoryEvent.Name = "StoryEvent";
            this.StoryEvent.Size = new System.Drawing.Size(820, 334);
            this.StoryEvent.TabIndex = 20;
            this.StoryEvent.Text = "label2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 748);
            this.Controls.Add(this.StoryEvent);
            this.Controls.Add(this.submit_choice);
            this.Controls.Add(this.MaxHealth);
            this.Controls.Add(this.CurrentHealth);
            this.Controls.Add(this.slash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.use_potion);
            this.Controls.Add(this.upgrade_stats);
            this.Controls.Add(this.update_inventory);
            this.Controls.Add(this.save);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.EquippedItems);
            this.Controls.Add(this.Choices);
            this.Controls.Add(this.Potions);
            this.Controls.Add(this.Armor);
            this.Controls.Add(this.Weapons);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.AttributeStats);
            this.Controls.Add(this.ArmorStats);
            this.Name = "Main";
            this.Text = "An Hour of Wolves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ArmorStats;
        private System.Windows.Forms.ListBox AttributeStats;
        private System.Windows.Forms.ListBox Inventory;
        private System.Windows.Forms.RadioButton Food;
        private System.Windows.Forms.RadioButton Weapons;
        private System.Windows.Forms.RadioButton Armor;
        private System.Windows.Forms.RadioButton Potions;
        private System.Windows.Forms.ListBox Choices;
        private System.Windows.Forms.ListBox EquippedItems;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button update_inventory;
        private System.Windows.Forms.Button upgrade_stats;
        private System.Windows.Forms.Button use_potion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label slash;
        private System.Windows.Forms.Label CurrentHealth;
        private System.Windows.Forms.Label MaxHealth;
        private System.Windows.Forms.Button submit_choice;
        private System.Windows.Forms.Label StoryEvent;
    }
}

