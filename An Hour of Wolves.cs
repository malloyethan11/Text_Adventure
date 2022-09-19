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
using System.Windows.Forms.VisualStyles;

namespace Text_Adventure
{
    public partial class Main : Form
    {
        Story story = new Story();

        // ====================================================================================
        // MAIN METHOD
        // ====================================================================================
        public Main()
        {
            // setup UI
            InitializeComponent();
            SqlConnection connection = OpenDatabaseConnection();

            ArmorStats.Items.Add("Armor");
            AttributeStats.Items.Add("Attributes");
            Inventory.Items.Add("Inventory");
            EquippedItems.Items.Add("Equipped Items");
            CurrentHealth.Text = "100";
            MaxHealth.Text = "100";
            int storySections = GetStoryEventCount();
            story.CurrentStoryEvent = 1;

            StoryEvent.Text = GetFirstEvent(connection);
            populateInitialChoices();
        }

        // ====================================================================================
        // DATABASE METHODS
        // ====================================================================================
        public SqlConnection OpenDatabaseConnection()
        {
            var connectionString = "Server = ETHAN-DESKTOP\\SQLEXPRESS; Database = text_adventure; Trusted_Connection = True;";
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            
            return connection;
        }

        public void CloseDatabaseConnection(SqlConnection connection)
        {
            connection.Close();
        }

        public string GetFirstEvent(SqlConnection connection)
        {
            string command = "SELECT StoryText FROM StoryEvents WHERE id = 1";
            SqlCommand selectFirstStory = new SqlCommand(command, connection);
            string row = string.Empty;

            using (SqlDataReader result = selectFirstStory.ExecuteReader())
            {
                while (result.Read())
                {
                    row = result[0].ToString();
                }
            }

            return row;
        }

        public int GetStoryEventCount()
        {
            string commandText = "SELECT COUNT (DISTINCT StorySection) AS Ids FROM Choices";
            SqlConnection connection = OpenDatabaseConnection();
            SqlCommand command = new SqlCommand(commandText, connection);

            Int32 result = (int)command.ExecuteScalar();
            CloseDatabaseConnection(connection);

            return result;
        }

        public void populateInitialChoices()
        {
            SqlConnection connection = OpenDatabaseConnection();
            string command = $"SELECT ChoiceText FROM Choices WHERE StorySectionWithChoiceId = '1a' OR StorySectionWithChoiceId = '1b' OR StorySectionWithChoiceId = '1c'";
            SqlCommand populateChoicesDict = new SqlCommand(command, connection);
            string row = string.Empty;

            using (SqlDataReader result = populateChoicesDict.ExecuteReader())
            {
                while (result.Read())
                {
                    row = result[0].ToString();
                    Choices.Items.Add(row);
                }
            }
            CloseDatabaseConnection(connection);
        }

        public void populateChoices(string choiceId)
        {
            if (choiceId == "1a" || choiceId == "1b" || choiceId == "1c")
            {
                switch (choiceId)
                {
                    case "1a":
                        choiceId = "2a";
                        break;
                    case "1b":
                        choiceId = "2b";
                        break;
                    case "1c":
                        choiceId = "2c";
                        break;
                }
            }

            SqlConnection connection = OpenDatabaseConnection();
            string command = $"SELECT ChoiceText FROM Choices WHERE StorySectionWithChoiceId = '{choiceId}'";
            SqlCommand populateChoiceOptions = new SqlCommand(command, connection);
            string row = string.Empty;

            using (SqlDataReader result = populateChoiceOptions.ExecuteReader())
            {
                while (result.Read())
                {
                    row = result[0].ToString();
                    Choices.Items.Add(row);
                }
            }
            CloseDatabaseConnection(connection);
        }   
        
        public void populateStoryText(string storyId)
        {
            //if (storySectionId == "1a" || storySectionId == "1b" || storySectionId == "1c")
            //{
            //    switch (storySectionId)
            //    {
            //        case "1a":
            //            storySectionId = "2a";
            //            break;
            //        case "1b":
            //            storySectionId = "2b";
            //            break;
            //        case "1c":
            //            storySectionId = "2c";
            //            break;
            //    }
            //}

            SqlConnection connection = OpenDatabaseConnection();
            string command = $"SELECT StoryText FROM StoryEvents WHERE StoryId = '{storyId}'";
            SqlCommand getStoryText = new SqlCommand(command, connection);
            string row = string.Empty;

            using (SqlDataReader result = getStoryText.ExecuteReader())
            {
                while (result.Read())
                {
                    row = result[0].ToString();
                }
            }

            StoryEvent.Text = row + "\n" + story.CurrentStoryEvent;

            CloseDatabaseConnection(connection);
        }


        // ====================================================================================
        // UI METHODS
        // ====================================================================================      
        private void Choices_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = OpenDatabaseConnection();
            //SqlCommand command = "SELECT StorySectionWithChoiceId, "
            string userChoiceText = Choices.SelectedItem.ToString();
            int selectedIndex = Choices.SelectedIndex;
            selectedIndex += 1;
            string choiceId = selectedIndex.ToString();
            string storyNum = story.CurrentStoryEvent.ToString();
            story.NextStoryId = (story.CurrentStoryEvent + 1).ToString();
            int nextStoryEvent = Int32.Parse(storyNum);

            if (Choices.Items.Count > 0)
            {
                Choices.Items.Clear();
            }

            // choiceId == selectedIndex
            switch (choiceId)
            {
                case "1":
                    choiceId = storyNum + "a";
                    story.NextStoryId += "a";
                    break;
                case "2":
                    choiceId = storyNum + "b";
                    story.NextStoryId += "b";
                    break;
                case "3":
                    choiceId = storyNum + "c";
                    story.NextStoryId += "c";
                    break;
            }

            SetChoice(choiceId);
            AdvanceStory(choiceId, nextStoryEvent);
        }
        
        void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ====================================================================================
        // GAMEPLAY METHODS
        // ====================================================================================
        public void AdvanceStory(string choiceId, int nextStoryEvent)
        {
            story.CurrentStoryEvent = nextStoryEvent + 1;
            populateStoryText(story.NextStoryId);
            populateChoices(choiceId);
        }

        public void SetChoice(string ChoiceId)
        {
            story.UsersChoice = ChoiceId;
        }



    }
}

