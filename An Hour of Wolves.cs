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
            story_event.Text = OpenDatabaseConnection().ToString();
            armor_stats.Items.Add("Armor");
            attribute_stats.Items.Add("Attributes");
            inventory.Items.Add("Inventory");
            equipped_items.Items.Add("Equipped Items");
            current_health.Text = "100";
            max_health.Text = "100";

            // 
        }

        // database methods
        public string OpenDatabaseConnection()
        {
            var connectionString = "Server = ETHAN-DESKTOP\\SQLEXPRESS; Database = text_adventure; Trusted_Connection = True;";
            var command = "SELECT story_text FROM story_events WHERE id = 1";
            string row = "";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand selectFirstStory = new SqlCommand(command, connection);

            using (SqlDataReader result = selectFirstStory.ExecuteReader())
            {
                while (result.Read())
                {
                    row = result[0].ToString();
                }
            }

            return row;
        }

        //public void CloseDatabaseConnection(SqlConnection connection)
        //{
        //    connection.Close();
        //}

        //public static string GetFirstEvent(string connectionString)
        //{
        //    return null;
        //}


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

