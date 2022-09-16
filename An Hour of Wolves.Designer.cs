
namespace Text_Adventure
{
    partial class main
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
            this.armor_stats = new System.Windows.Forms.ListBox();
            this.attribute_stats = new System.Windows.Forms.ListBox();
            this.inventory = new System.Windows.Forms.ListBox();
            this.food = new System.Windows.Forms.RadioButton();
            this.weapons = new System.Windows.Forms.RadioButton();
            this.armor = new System.Windows.Forms.RadioButton();
            this.potions = new System.Windows.Forms.RadioButton();
            this.choices = new System.Windows.Forms.ListBox();
            this.equipped_items = new System.Windows.Forms.ListBox();
            this.quit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.update_inventory = new System.Windows.Forms.Button();
            this.upgrade_stats = new System.Windows.Forms.Button();
            this.use_potion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.slash = new System.Windows.Forms.Label();
            this.current_health = new System.Windows.Forms.Label();
            this.max_health = new System.Windows.Forms.Label();
            this.submit_choice = new System.Windows.Forms.Button();
            this.story_event = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // armor_stats
            // 
            this.armor_stats.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armor_stats.FormattingEnabled = true;
            this.armor_stats.ItemHeight = 22;
            this.armor_stats.Location = new System.Drawing.Point(12, 12);
            this.armor_stats.Name = "armor_stats";
            this.armor_stats.Size = new System.Drawing.Size(282, 334);
            this.armor_stats.TabIndex = 0;
            // 
            // attribute_stats
            // 
            this.attribute_stats.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attribute_stats.FormattingEnabled = true;
            this.attribute_stats.ItemHeight = 22;
            this.attribute_stats.Location = new System.Drawing.Point(12, 354);
            this.attribute_stats.Name = "attribute_stats";
            this.attribute_stats.Size = new System.Drawing.Size(282, 378);
            this.attribute_stats.TabIndex = 1;
            // 
            // inventory
            // 
            this.inventory.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.FormattingEnabled = true;
            this.inventory.ItemHeight = 22;
            this.inventory.Location = new System.Drawing.Point(1136, 12);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(282, 334);
            this.inventory.TabIndex = 3;
            // 
            // food
            // 
            this.food.AutoSize = true;
            this.food.Location = new System.Drawing.Point(1136, 355);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(49, 17);
            this.food.TabIndex = 4;
            this.food.TabStop = true;
            this.food.Text = "Food";
            this.food.UseVisualStyleBackColor = true;
            // 
            // weapons
            // 
            this.weapons.AutoSize = true;
            this.weapons.Location = new System.Drawing.Point(1198, 355);
            this.weapons.Name = "weapons";
            this.weapons.Size = new System.Drawing.Size(71, 17);
            this.weapons.TabIndex = 5;
            this.weapons.TabStop = true;
            this.weapons.Text = "Weapons";
            this.weapons.UseVisualStyleBackColor = true;
            // 
            // armor
            // 
            this.armor.AutoSize = true;
            this.armor.Location = new System.Drawing.Point(1284, 355);
            this.armor.Name = "armor";
            this.armor.Size = new System.Drawing.Size(52, 17);
            this.armor.TabIndex = 6;
            this.armor.TabStop = true;
            this.armor.Text = "Armor";
            this.armor.UseVisualStyleBackColor = true;
            // 
            // potions
            // 
            this.potions.AutoSize = true;
            this.potions.Location = new System.Drawing.Point(1355, 355);
            this.potions.Name = "potions";
            this.potions.Size = new System.Drawing.Size(60, 17);
            this.potions.TabIndex = 7;
            this.potions.TabStop = true;
            this.potions.Text = "Potions";
            this.potions.UseVisualStyleBackColor = true;
            // 
            // choices
            // 
            this.choices.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choices.FormattingEnabled = true;
            this.choices.ItemHeight = 22;
            this.choices.Location = new System.Drawing.Point(300, 355);
            this.choices.Name = "choices";
            this.choices.Size = new System.Drawing.Size(830, 334);
            this.choices.TabIndex = 8;
            this.choices.SelectedIndexChanged += new System.EventHandler(this.choices_SelectedIndexChanged);
            // 
            // equipped_items
            // 
            this.equipped_items.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipped_items.FormattingEnabled = true;
            this.equipped_items.ItemHeight = 22;
            this.equipped_items.Location = new System.Drawing.Point(1136, 399);
            this.equipped_items.Name = "equipped_items";
            this.equipped_items.Size = new System.Drawing.Size(282, 290);
            this.equipped_items.TabIndex = 9;
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
            // current_health
            // 
            this.current_health.AutoSize = true;
            this.current_health.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_health.Location = new System.Drawing.Point(408, 703);
            this.current_health.MinimumSize = new System.Drawing.Size(100, 34);
            this.current_health.Name = "current_health";
            this.current_health.Size = new System.Drawing.Size(100, 34);
            this.current_health.TabIndex = 17;
            // 
            // max_health
            // 
            this.max_health.AutoSize = true;
            this.max_health.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_health.Location = new System.Drawing.Point(531, 703);
            this.max_health.MinimumSize = new System.Drawing.Size(100, 34);
            this.max_health.Name = "max_health";
            this.max_health.Size = new System.Drawing.Size(100, 34);
            this.max_health.TabIndex = 18;
            // 
            // submit_choice
            // 
            this.submit_choice.Location = new System.Drawing.Point(650, 696);
            this.submit_choice.Name = "submit_choice";
            this.submit_choice.Size = new System.Drawing.Size(110, 40);
            this.submit_choice.TabIndex = 19;
            this.submit_choice.Text = "Submit Choice";
            this.submit_choice.UseVisualStyleBackColor = true;
            this.submit_choice.Click += new System.EventHandler(this.submit_choice_Click);
            // 
            // story_event
            // 
            this.story_event.AutoSize = true;
            this.story_event.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.story_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.story_event.Location = new System.Drawing.Point(307, 12);
            this.story_event.MinimumSize = new System.Drawing.Size(820, 334);
            this.story_event.Name = "story_event";
            this.story_event.Size = new System.Drawing.Size(820, 334);
            this.story_event.TabIndex = 20;
            this.story_event.Text = "label2";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 748);
            this.Controls.Add(this.story_event);
            this.Controls.Add(this.submit_choice);
            this.Controls.Add(this.max_health);
            this.Controls.Add(this.current_health);
            this.Controls.Add(this.slash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.use_potion);
            this.Controls.Add(this.upgrade_stats);
            this.Controls.Add(this.update_inventory);
            this.Controls.Add(this.save);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.equipped_items);
            this.Controls.Add(this.choices);
            this.Controls.Add(this.potions);
            this.Controls.Add(this.armor);
            this.Controls.Add(this.weapons);
            this.Controls.Add(this.food);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.attribute_stats);
            this.Controls.Add(this.armor_stats);
            this.Name = "main";
            this.Text = "An Hour of Wolves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox armor_stats;
        private System.Windows.Forms.ListBox attribute_stats;
        private System.Windows.Forms.ListBox inventory;
        private System.Windows.Forms.RadioButton food;
        private System.Windows.Forms.RadioButton weapons;
        private System.Windows.Forms.RadioButton armor;
        private System.Windows.Forms.RadioButton potions;
        private System.Windows.Forms.ListBox choices;
        private System.Windows.Forms.ListBox equipped_items;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button update_inventory;
        private System.Windows.Forms.Button upgrade_stats;
        private System.Windows.Forms.Button use_potion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label slash;
        private System.Windows.Forms.Label current_health;
        private System.Windows.Forms.Label max_health;
        private System.Windows.Forms.Button submit_choice;
        private System.Windows.Forms.Label story_event;
    }
}

