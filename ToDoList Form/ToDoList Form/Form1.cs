using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList_Form
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            


        }


        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            if (index >= 0)
            {
                checkedListBox1.Items.RemoveAt(index);
            }
        }

        private void Değiştir_Click(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            if (index >= 0)
            {
                checkedListBox1.Items.RemoveAt(index);
                checkedListBox1.Items.Insert(index, textBox2.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int selectedIndex = e.Index;

            
            if (e.NewValue == CheckState.Checked)
            {
                checkedListBox1.Font = new Font(checkedListBox1.Font, FontStyle.Strikeout);
            }
            
            else if (e.NewValue == CheckState.Unchecked)
            {
                checkedListBox1.Font = new Font(checkedListBox1.Font, FontStyle.Regular);
            }





        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void CheckedListBox1_Paint(object sender, PaintEventArgs e)
        {
           
                
            

        }

    }
}

