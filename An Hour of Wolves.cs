using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Text_Adventure
{
    public partial class main : Form
    {
        private Story _story = new Story();
        private Player _player = new Player();

        public main()
        {
            // setup UI
            // TODO: refactor component names to match C# conventions
            InitializeComponent();
            //story_event.Text = StoryEvents();
            armor_stats.Items.Add("Armor");
            attribute_stats.Items.Add("Attributes");
            inventory.Items.Add("Inventory");
            equipped_items.Items.Add("Equipped Items");
            current_health.Text = "100";
            max_health.Text = "100";

            // Load choices
            //LoadChoices();

        }

        // =============================================================================
        // UI METHODS
        // =============================================================================
        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void choices_SelectedIndexChanged(object sender, EventArgs e)
        {
            _story.UsersChoice = choices.SelectedItem?.ToString();
        }

        private void submit_choice_Click(object sender, EventArgs e)
        {
            AdvanceTheStory(_story.UsersChoice);
            _story.UsersChoice = string.Empty;
        }

        // =============================================================================
        // GAMEPLAY METHODS
        // =============================================================================
        private void AdvanceTheStory(string UsersChoice)
        {

        }





    }
}

