using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Project_Warehouse
{
    public partial class ManageSettings : Form
    {
        public ManageSettings()
        {
            InitializeComponent();
        }

        //Database declaration
        string myDatasource = "datasource=localhost;port=3306;username=root;password=impactidris";
        MySqlDataReader myReader;

        //Refresh DGVSupervisor
        void refreshDGVSupervisor() 
        {
            string selectQuery = "select Supervisor from project_warehousedb.supervisortbl";
            MySqlConnection myConn = new MySqlConnection(myDatasource);
            try
            {
                myConn.Open();
                MySqlCommand cmdLoaddgv = new MySqlCommand(selectQuery, myConn);
                MySqlDataAdapter mySqldata = new MySqlDataAdapter();
                mySqldata.SelectCommand = cmdLoaddgv;
                DataTable dt = new DataTable();
                mySqldata.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                dgvSupervisor.DataSource = bSource;
                mySqldata.Update(dt);
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
           

        private void btnAddSupervisor_Click(object sender, EventArgs e)
        {
            string insertQuery = "insert into project_warehousedb.supervisortbl(Supervisor) values('" + txtSupervisor.Text.Replace("'", "''") + "') ;";
            MySqlConnection myConn = new MySqlConnection(myDatasource);
            if (txtSupervisor.Text != "")
            {
                try
                {
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, myConn);
                    myConn.Open();
                    myReader = insertCommand.ExecuteReader();
                    txtSupervisor.Text = "";
                    refreshDGVSupervisor();
                    MessageBox.Show("New Supervisor is added!", "Save Message");
                    while (myReader.Read())
                    {

                    }
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //MessageBox.Show("Blank Supervisor's name can not be added", "Error Message");
                DialogResult = MessageBox.Show("Blank Supervisor's name can not be added", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnDelSupervisor_Click(object sender, EventArgs e)
        {
            try
            {
                string selected_supervisor = dgvSupervisor.CurrentRow.Cells["Supervisor"].Value.ToString();
                string delQuery = "delete from project_warehousedb.supervisortbl where Supervisor='" + selected_supervisor + "';";
                MySqlConnection myconn = new MySqlConnection(myDatasource);
                MySqlCommand mycmd = new MySqlCommand(delQuery, myconn);

                DialogResult dialog = MessageBox.Show("You want to remove this Supervisor?", "Remove Message", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    myconn.Open();
                    myReader = mycmd.ExecuteReader();
                    refreshDGVSupervisor();
                    MessageBox.Show("Supervisor is removed", "Remove Message");
                    while (myReader.Read())
                    {

                    }
                    myconn.Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageSettings_Shown(object sender, EventArgs e)
        {
            refreshDGVSupervisor();
            refreshDGVTopic();
            dgvProjectTopic.Columns[0].Visible = false;
            refreshDGVDepartment();
        }

        //Refresh DGVTopic
        void refreshDGVTopic()
        {
            string selectQuery = "select * from project_warehousedb.topictbl ;";
            MySqlConnection myConn = new MySqlConnection(myDatasource);
            try
            {
                myConn.Open();
                MySqlCommand cmdLoaddgv = new MySqlCommand(selectQuery, myConn);
                MySqlDataAdapter mySqldata = new MySqlDataAdapter();
                mySqldata.SelectCommand = cmdLoaddgv;
                DataTable dt = new DataTable();
                mySqldata.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                dgvProjectTopic.DataSource = bSource;
                mySqldata.Update(dt);
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
           
        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            string insertQuery = "insert into project_warehousedb.topictbl(Topic) values('" + txtTopic.Text.Replace(@"\", @"\\").Replace("'", "''") + "') ;";
            MySqlConnection myConn = new MySqlConnection(myDatasource);
                if (txtTopic.Text != "")
                {
                    try
                    {
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, myConn);
                        myConn.Open();
                        myReader = insertCommand.ExecuteReader();
                        txtTopic.Text = "";
                        refreshDGVTopic();
                        MessageBox.Show("New Topic is added!", "Save Message");
                        while (myReader.Read())
                        {

                        }
                        myConn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                  //  MessageBox.Show("Blank Topic can not be added", "Error Message");
                    DialogResult = MessageBox.Show("Blank Topic can not be added", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void btnDelTopic_Click(object sender, EventArgs e)
        {
            try
            {
                string selected_Topic = dgvProjectTopic.CurrentRow.Cells["id_topic"].Value.ToString();

                string delQuery = "delete from project_warehousedb.topictbl where id_topic='" + selected_Topic + "' ;";
                MySqlConnection myconn = new MySqlConnection(myDatasource);
                MySqlCommand mycmd = new MySqlCommand(delQuery, myconn);
                MySqlDataReader myReader;
                DialogResult dialog = MessageBox.Show("You want to remove this Topic?", "Remove Message", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    myconn.Open();
                    myReader = mycmd.ExecuteReader();
                    refreshDGVTopic();
                    MessageBox.Show("Topic is successfully removed", "Remove Message");
                    while (myReader.Read())
                    {

                    }
                    myconn.Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        void refreshDGVDepartment()
        {
            string selectQuery = "select Department from project_warehousedb.departmenttbl ;";
            MySqlConnection myConn = new MySqlConnection(myDatasource);
            try
            {
                myConn.Open();
                MySqlCommand cmdLoaddgv = new MySqlCommand(selectQuery, myConn);
                MySqlDataAdapter mySqldata = new MySqlDataAdapter();
                mySqldata.SelectCommand = cmdLoaddgv;
                DataTable dt = new DataTable();
                mySqldata.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                dgvDepartment.DataSource = bSource;
                mySqldata.Update(dt);
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            string insertQuery = "insert into project_warehousedb.departmenttbl(Department) values('" + txtDepartment.Text.Replace("'", "''") + "') ;";
            MySqlConnection myConn = new MySqlConnection(myDatasource);
            if (txtDepartment.Text != "")
            {
                try
                {
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, myConn);
                    myConn.Open();
                    myReader = insertCommand.ExecuteReader();
                    txtDepartment.Text = "";
                    refreshDGVDepartment();
                    MessageBox.Show("New Department is added!", "Save Message");
                    while (myReader.Read())
                    {

                    }
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                DialogResult = MessageBox.Show("Blank Department name can not be added", "Error Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }

        private void btn_MsHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//End Braces
    }
}
