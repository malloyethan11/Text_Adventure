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
        private StoryEvents _storyEvent = new StoryEvents();
        private Choices _choice = new Choices();

        public main()
        {

            string myString = string.Empty;
            // setup UI
            // TODO: refactor component names to match C# conventions
            InitializeComponent();
            story_event.Text = StoryEvents.storyEvents["1"];
            armor_stats.Items.Add("Armor");
            attribute_stats.Items.Add("Attributes");
            inventory.Items.Add("Inventory");
            equipped_items.Items.Add("Equipped Items");
            current_health.Text = "100";
            max_health.Text = "100";

            // Load choices
            string storySectionId = "1.a";
            populateChoices(storySectionId);

        }

        // =============================================================================
        // UI METHODS
        // =============================================================================
        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        public void populateChoices(story_section_id)
        {
            SqlConnection connection = OpenDatabaseConnection();
            string command = $"SELECT choice_text FROM choices WHERE story_section_id = {story_section_id}";
            SqlCommand populateChoicesDict = new SqlCommand(command, connection);
            string row = string.Empty;

            using (SqlDataReader result = loadChoices.ExecuteReader())
            {
                while (result.Read())
                {
                    row = result[0].ToString();
                    choices.Items.Add(row);
                }
            }
            CloseDatabaseConnection(connection);
        }

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

