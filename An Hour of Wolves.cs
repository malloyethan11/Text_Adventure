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
        public main()
        {
            // setup UI
            // TODO: refactor component names to match C# conventions

            InitializeComponent();

            // address the player
            MessageBox.Show("Welcome to the game!");

            SqlConnection connection = OpenDatabaseConnection();
            story_event.Text = GetFirstEvent(connection);
            armor_stats.Items.Add("Armor");
            attribute_stats.Items.Add("Attributes");
            inventory.Items.Add("Inventory");
            equipped_items.Items.Add("Equipped Items");
            current_health.Text = "100";
            max_health.Text = "100";

            // 
        }

        // database methods
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
            string command = "SELECT story_text FROM story_events WHERE id = 1";
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


        // UI interactions
        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

