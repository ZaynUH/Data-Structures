using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessed_Exercise_4_Task_A_B_C
{
    public partial class Form1 : Form
    {
        Graph<string> newGraph = new Graph<String>();
        public Form1()
        {
            InitializeComponent();
            
            UpdateInfo();
        }

        public void UpdateInfo()
        {
            // Updates all the info/dropboxes on the form
            UpdateGraphInfo();
            UpdateNodeInfo();
            UpdateDropBoxes();
        }

        public void UpdateDropBoxes()
        { 
            // Updates the drop boxes with all the users currently in the graph
            SelectUserComboBox.Items.Clear();
            userOneDropDown.Items.Clear();
            userTwoDropDown.Items.Clear();
            DeleteDropDown.Items.Clear();

            

            string[] users = newGraph.PrintID();

            for(int i = 0 ; i < users.Length - 1; i++)
            {
                SelectUserComboBox.Items.Add(users[i]);
                userOneDropDown.Items.Add(users[i]);
                userTwoDropDown.Items.Add(users[i]);
                DeleteDropDown.Items.Add(users[i]);
            }
        }

        public void UpdateGraphInfo()
        {
            // Updates all the info on the graph in the Group Box
            TotalNodesTextBox.Clear();
            TotalConTextBox.Clear();
            AvgWeightsTextBox.Clear();
            AvgConTextBox.Clear();
            MostConTextBox.Clear();
            MostAvgComTextBox.Clear();

            

            TotalNodesTextBox.Text = Convert.ToString(newGraph.NumNodes());
            TotalConTextBox.Text = Convert.ToString(newGraph.NumEdges());
            AvgWeightsTextBox.Text = Convert.ToString(newGraph.AVGWeights());
            AvgConTextBox.Text = Convert.ToString(newGraph.AVGConnectivity());
            MostConTextBox.Text = newGraph.MostConnections();
            MostAvgComTextBox.Text = newGraph.DegreeCentralities();

        }

        public void UpdateNodeInfo()
        {
            // Updates the info on the curretn node selected in the group Box
            string userSelected = SelectUserComboBox.Text;
            if (userSelected != "")
            {
                NodeAdjCountTextBox.Clear();
                ConnectionList.Items.Clear();
                UserBFSList.Items.Clear();

                GraphNode<string> user = newGraph.GetNodeByID(userSelected);
                LinkedList<string> connections = user.GetAdjList();

                if(connections.Count.ToString() == null)
                {
                    NodeAdjCountTextBox.Text = "0";
                }
                else NodeAdjCountTextBox.Text = connections.Count.ToString();

                LinkedList<int> weights = user.GetWeights();

                for (int i = 0; i < connections.Count; i++)
                {
                    ConnectionList.Items.Add(connections.ElementAt(i).ToString() + " | (" + weights.ElementAt(i) + ")");
                }

                List<string> BFSConnectedUsers = new List<string>();

                newGraph.BFSAllConnectedUsers(userSelected, ref BFSConnectedUsers);

                for (int i = 0; i < BFSConnectedUsers.Count(); i++)
                {
                    UserBFSList.Items.Add(BFSConnectedUsers[i]);
                }
            }
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string userID = userIDTextBox.Text;
            if (userID != "")
            {
                if(newGraph.GetNodeByID(userID) == null)
                {
                    newGraph.AddNode(userID);
                    OutputTextBox.Text = userID + " Added";
                    UpdateInfo();
                    userIDTextBox.Text = "";
                }
                else OutputTextBox.Text = "User ID exists in network. Choose another ID";

            }
            else OutputTextBox.Text = "Enter a userID to add to Network";
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string userID = DeleteDropDown.Text;
            if (newGraph.GetNodeByID(userID) != null)
            {

                newGraph.RemoveNode(userID);
                UpdateInfo();
                OutputTextBox.Text = "User " + userID + " Removed from Network";
            }
            else OutputTextBox.Text = "User does not exist in Network";
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string user1 = userOneDropDown.Text;
            string user2 = userTwoDropDown.Text;
            string weight = weightTextBox.Text;

            if (user1 != "" || user2 != "" || weight != "")
            {
                if(Regex.IsMatch(weight, @"^\d+$"))
                {
                    if (user1 != user2)
                    {
                        LinkedList<string> list = newGraph.GetNodeByID(user1).GetAdjList();

                        if(list.Contains(user2))
                        {
                            OutputTextBox.Text = "Users are connected already";
                        }
                        else
                        {
                            newGraph.AddEdge(user1, user2, Convert.ToInt32(weight));
                            OutputTextBox.Text = user1 + " and " + user2 + " connected with a weight of " + weight;
                            UpdateDropBoxes();
                            userOneDropDown.Text = "";
                            userTwoDropDown.Text = "";
                            weightTextBox.Text = "";
                        }
                        
                    }
                    else OutputTextBox.Text = "Cannot connect to the same user";
                }
                else OutputTextBox.Text = "Weight needs to be an Integer Value";

            }
            else OutputTextBox.Text = "Enter All fields to Connect users";

            UpdateInfo();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e) 
        {   
            UpdateNodeInfo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
