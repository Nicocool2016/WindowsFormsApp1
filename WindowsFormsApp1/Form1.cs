using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;

            SqlConnection cnn;

            connectionString = @"Data Source=LAPTOP-2P15SG05\MSSQLSERVER02; Initial Catalog=TrainingDatabase; Integrated Security=True";

            cnn = new SqlConnection(connectionString);  

            cnn.Open();

            //MessageBox.Show("Connection Open");

            //SqlCommand command;
            //SqlDataReader dataReader;
            //String sqlQuery, Output = "";

            //sqlQuery = "Select * from Hotel_Facilities";

            //command = new SqlCommand(sqlQuery, cnn);

            //dataReader = command.ExecuteReader();

            //while (dataReader.Read())
            //{
            //    Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            //}

            //MessageBox.Show(Output);

            //dataReader.Close();



            //SqlCommand command;
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //String sqlQuery = "";

            //sqlQuery = "INSERT INTO dbo.Hotel_Facilities (Hotel_No, Facility,) VALUES (9, 'Bordtennis',)";

            //command = new SqlCommand(sqlQuery,cnn);

            //adapter.InsertCommand = new SqlCommand(sqlQuery, cnn);
            //adapter.InsertCommand.ExecuteNonQuery();



            //Update
            //SqlCommand command;
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //String sqlQuery = "";

            //sqlQuery = "Update dbo.Hotel_Facilities set Name= '"+" testing 123"+"' where Hotel_No=8)";

            //command = new SqlCommand(sqlQuery, cnn);

            //adapter.UpdateCommand = new SqlCommand(sqlQuery, cnn);
            //adapter.UpdateCommand.ExecuteNonQuery();

            //delete
            //SqlCommand command;
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //String sqlQuery = "";

            //sqlQuery = "Delete dbo.Hotel_Facilities where Hotel_No=8)";

            //command = new SqlCommand(sqlQuery, cnn);

            //adapter.DeleteCommand = new SqlCommand(sqlQuery, cnn);
            //adapter.DeleteCommand.ExecuteNonQuery()



            cnn.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingdatabaseDataSet.DemoHotel' table. You can move, or remove it, as needed.
            this.demoHotelTableAdapter.Fill(this.trainingdatabaseDataSet.DemoHotel);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
