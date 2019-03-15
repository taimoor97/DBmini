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

namespace DB_lab_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public const string con = "Data Source=DESKTOP-L3A7K55;Initial Catalog=ProjectB;Integrated Security=True"; // connection to database
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet.Rubric);
            // TODO: This line of code loads data into the 'projectBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet.Student);
            // TODO: This line of code loads data into the 'projectBDataSet.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet.Clo);

        }

        
        private void btn_std_reg_Click(object sender, EventArgs e)
        {
            pnl_std_reg.Visible = true;
            pnl_clo_rubric.Visible = false;
            pnl_std_info.Visible = false;
        }           // button for showing std reg form

        private void btn_CLO_Click(object sender, EventArgs e)                  // button for showing CLO form
        {
            pnl_clo_rubric.Visible = true;
            pnl_std_reg.Visible = true;
            pnl_std_info.Visible = false;
        }               

        private void btn_std_info_Click(object sender, EventArgs e)             // button for showing student information form
        {
            pnl_std_info.Visible = true;
            pnl_clo_rubric.Visible = false;
            pnl_std_reg.Visible = true;
        }

        private void btn_show_Click(object sender, EventArgs e)                 //button for showing reports
        {
            pnl_std_info.Visible = true;
            pnl_clo_rubric.Visible = false;
            pnl_std_reg.Visible = true;
        }

        private void btn_addclo_Click(object sender, EventArgs e)               // insert CLO in database
        {
            SqlConnection cnn = new SqlConnection(con);
            string query = "INSERT into Clo(Name,DateCreated,DateUpdated) VALUES(@name,@created,@updated)";
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand(query, cnn))
            {
                cmd.Parameters.AddWithValue("@name", txt_clo.Text);
                cmd.Parameters.AddWithValue("@created", DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));
                cmd.Parameters.AddWithValue("@updated", DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Clo Added Successfully");
                this.cloTableAdapter.Fill(this.projectBDataSet.Clo);
            }
            txt_clo.Text = " ";
            cnn.Close();
        }

        private void btn_register_Click_1(object sender, EventArgs e)           // insert Student info in database
        {
            SqlConnection cnn = new SqlConnection(con);
            string query = "INSERT into Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) VALUES(@first,@last,@contact,@email,@regno,5)";
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand(query, cnn))
            {
                cmd.Parameters.AddWithValue("@first", txt_firstname.Text);
                cmd.Parameters.AddWithValue("@last", txt_lastname.Text);
                cmd.Parameters.AddWithValue("@contact", txt_contact.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@regno", txt_reg_no.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Added Successfully");
            }

        }

        private void btn_add_rubric_Click(object sender, EventArgs e)           // insert Rubric in database
        {

            if (btn_add_rubric.Text == "Edit Rubric")
            {   
                SqlConnection cnn = new SqlConnection(con);
                string q = "UPDATE Rubric set Details=@details ,CloId=@cloIDs where Id ='"+s+"'";
                SqlConnection sqlConnection = new SqlConnection(con);
                sqlConnection.Open();
                using (SqlCommand aa = new SqlCommand(q, sqlConnection)) 
                {
                    aa.Parameters.AddWithValue("@details", txt_rubric_detail.Text);
                    aa.Parameters.AddWithValue("@cloIDs", s);
                    aa.ExecuteNonQuery();

                }
                
                sqlConnection.Close();
                btn_add_rubric.Text = "Add Rubric";
                this.rubricTableAdapter.Fill(this.projectBDataSet.Rubric);
            }
            else
            {
                int id = -1;
                SqlConnection cnn = new SqlConnection(con);
                // query for inserting data
                string CLO = cmb_clo_select.Text;
                string query_1 = "Select Id from Clo where Name = '" + CLO + "'";     // query for getting CLO id
                cnn.Open();
                SqlCommand sqlcommand = new SqlCommand(query_1, cnn);
                SqlDataReader read = sqlcommand.ExecuteReader();                    // storing CLO id 
                while (read.Read())
                {
                    id = Convert.ToInt32(read["Id"]);
                }
                cnn.Close();
                cnn.Open();
                string query = "INSERT into Rubric(Details,CloId) VALUES(@detail,@cloID)";          // query for inserting rubric
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@detail", txt_rubric_detail.Text);     //storing rubric details
                    cmd.Parameters.AddWithValue("@cloID", id);                          //storing clo id in bd
                    cmd.ExecuteNonQuery();
                    this.rubricTableAdapter.Fill(this.projectBDataSet.Rubric);
                    MessageBox.Show("Rubric Added Successfully");
                }
                cnn.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)               // deleting student 
        {
            if(this.dGv_student_data.SelectedRows.Count>0)
            {
                int index = Convert.ToInt32(this.dGv_student_data.SelectedRows[0].Cells[0].Value);            //getting row index
                SqlConnection cnn = new SqlConnection(con);
                if (MessageBox.Show("Do you want to delete ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cnn.Open();
                    string query = "DELETE FROM Student WHERE Id  = '" + index + "'";
                    SqlCommand command = new SqlCommand(query, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    this.studentTableAdapter.Fill(this.projectBDataSet.Student);
                }
             
            }
            else
            {
                MessageBox.Show("Select a row to delete.!");
            }
            
        }

        private void btn_edit_Click(object sender, EventArgs e)                 //Update student
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                studentBindingSource.EndEdit();
                studentTableAdapter.Update(this.projectBDataSet.Student);
                MessageBox.Show("Data has been succesfully updated","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btn_clo_update_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cloBindingSource2.EndEdit();
                cloTableAdapter.Update(this.projectBDataSet.Clo);
                MessageBox.Show("Data has been succesfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;

            
        }

        private void btn_clo_delete_Click(object sender, EventArgs e)
        {
            if (this.dGv_Clo.SelectedRows.Count > 0)
            {
                int index = Int32.Parse(this.dGv_Clo.SelectedRows[0].Cells[0].Value.ToString());            //getting row index
                SqlConnection cnn = new SqlConnection(con);
                if (MessageBox.Show("Do you want to delete ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cnn.Open();
                    string qu_del = "DELETE FROM Rubric WHERE CloId='" + index + "'";
                    SqlCommand command = new SqlCommand(qu_del, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    cnn.Open();
                    string query = "DELETE FROM Clo WHERE Id='" + index + "'";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    this.rubricTableAdapter.Fill(this.projectBDataSet.Rubric);
                    this.cloTableAdapter.Fill(this.projectBDataSet.Clo);
                }

            }
            else
            {
                MessageBox.Show("Select a row to delete.!");
            }
        }

        private void btn_rub_del_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(this.dataGridView3.SelectedRows[0].Cells[0].Value.ToString());
            SqlConnection cnn = new SqlConnection(con);
            if (MessageBox.Show("Do you want to delete ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cnn.Open();
                string qu_del = "DELETE FROM Rubric WHERE Id='" + index + "'";
                SqlCommand command = new SqlCommand(qu_del, cnn);
                command.ExecuteNonQuery();
                cnn.Close();
                this.rubricTableAdapter.Fill(this.projectBDataSet.Rubric);
            }
        }
        int s;
        private void btn_rub_Update_Click(object sender, EventArgs e)
        {
            btn_add_rubric.Text = "Edit Rubric";
            txt_rubric_detail.Text=this.dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
            s  = Convert.ToInt32(this.dataGridView3.SelectedRows[0].Cells[1].Value.ToString());
            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            string qu_del = "SELECT * FROM Rubric WHERE Id='" + s + "'";
            SqlCommand command = new SqlCommand(qu_del, cnn);
            SqlDataReader reader= command.ExecuteReader();
            while (reader.Read())
            {

                cmb_clo_select.Text = reader["Name"].ToString();
            }
            cnn.Close();
        }
    }
}
