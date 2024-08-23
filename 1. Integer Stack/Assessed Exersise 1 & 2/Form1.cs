using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assessed_Exersise_1___2
{
    public partial class Form1 : Form
    {
        private IntegerStack newStack;

        public Form1()
        {
            // Initialise Stack
            newStack = new IntegerStack();  
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Output()
        {
            // Outputs the Stack contents in order in all textboxes in the Group Box
            string stack = newStack.Convert();
            string[] stackLines = stack.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (Control containerControl in this.Controls)
            {
                if (containerControl is Panel || containerControl is GroupBox) 
                {
                    foreach (Control control in containerControl.Controls)
                    {
                        if (control is System.Windows.Forms.TextBox textBox && textBox.Name.StartsWith("textBox"))
                        {
                            int index = GetTextBoxIndex(textBox.Name);
                            if (index >= 0 && index < stackLines.Length && stackLines[index] != "")
                            {
                                textBox.Text = stackLines[index];
                            }
                            else
                            {
                                textBox.Text = "Empty";
                            }
                        }
                    }
                }
            }
        }

        private int GetTextBoxIndex(string textBoxName)
        {
            // Finds the index of each value in the Stack
            string indexPart = textBoxName.Replace("textBox", "");
            if (int.TryParse(indexPart, out int index))
            {
                return index - 1; 
            }
            return -1; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Checks if the input is a digit and if it is then integer is added to top of stack and is displayed
            if (inputTextBox.Text == "" || !Regex.IsMatch(inputTextBox.Text, @"^\d+$"))
            {
                outputTextBox.Text = "Enter a Integer"; // error message
                
            }
            else
            {
                newStack.push(Convert.ToInt32(inputTextBox.Text));
                newStack.Push(Convert.ToInt32(inputTextBox.Text));
                Output();
                outputTextBox.Text = inputTextBox.Text + " added to stack";
            }
            inputTextBox.Text = "";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Checks if stack is empty, if it isnt then the top value in stack is removed and is displayed
            if (newStack.IsEmpty())
            {
                outputTextBox.Text = "Stack is Empty";  // error message
            }
            else
            {
                newStack.pop();
                int popInt = newStack.Pop();
                Output();
                outputTextBox.Text = popInt + " removed to stack";
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            // Stack is sorted in Ascending order where the top of the stack is the smallest value and going down increases
            newStack.SortAscending(newStack);
            Output();
            outputTextBox.Text = "Sorted stack Ascending";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Stack is sorted in Descending order where the top of the stack is the largest value and going down decreases
            newStack.SortDescending(newStack);
            Output();
            outputTextBox.Text = "Sorted stack Descending";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Stack is sorted in the order in which it was added first going at the bottom
            newStack.SortInOrder(newStack);
            Output();
            outputTextBox.Text = "Sorted stack in Original Order";
        }
    }
}
