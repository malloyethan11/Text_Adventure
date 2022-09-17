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
    public partial class Main : Form
    {
        // ====================================================================================
        // MAIN METHOD
        // ====================================================================================
        public Main()
        {
            // setup UI
            InitializeComponent();
            SqlConnection connection = OpenDatabaseConnection();
            StoryEvent.Text = GetFirstEvent(connection);
            ArmorStats.Items.Add("Armor");
            AttributeStats.Items.Add("Attributes");
            Inventory.Items.Add("Inventory");
            EquippedItems.Items.Add("Equipped Items");
            CurrentHealth.Text = "100";
            MaxHealth.Text = "100";

            // address the player
            MessageBox.Show("Welcome to the game!");

            // Populate choices
            populateChoices("1");

            // 
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

        public void populateChoices(string storySectionId)
        {
            SqlConnection connection = OpenDatabaseConnection();
            string command = $"SELECT ChoiceText FROM choices WHERE StorySectionId = '{storySectionId}'";
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


        // ====================================================================================
        // UI METHODS
        // ====================================================================================      
        private void Choices_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userChoice = Choices.SelectedItem.ToString();
            int choiceIndex = Int32.Parse(Choices.SelectedIndex.ToString());
            AdvanceStory((choiceIndex + 1), userChoice);
        }
        
        void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ====================================================================================
        // GAMEPLAY METHODS
        // ====================================================================================
        public void AdvanceStory(int choiceIndex, string userChoice)
        {
            SqlConnection connection = OpenDatabaseConnection();

        }



    }
}

