using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnR_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection indexCollection = chklbLeft.CheckedItems;
            foreach (var i in indexCollection) 
            {
                chklbRight.Items.Add(i);
            }
            foreach (var i in chklbRight.Items)
            {
                chklbLeft.Items.Remove(i);
            }
        }

        private void chklbLeft_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnRR_Click(object sender, EventArgs e)
        {
            foreach (var i in chklbLeft.Items)
            {
                chklbRight.Items.Add(i);
              
            }
            foreach (var i in chklbRight.Items)
            {
                chklbLeft.Items.Remove(i);
            }
     
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection indexCollection = chklbRight.CheckedIndices;
            foreach (int i in indexCollection)
            {
                chklbLeft.Items.Add(chklbRight.Items[i]);
            }
            foreach (var i in chklbLeft.Items)
            {
                chklbRight.Items.Remove(i);
            }
        }

        private void btnLL_Click(object sender, EventArgs e)
        {
            foreach (var i in chklbRight.Items)
            {
                chklbLeft.Items.Add(i);
            }
            foreach (var i in chklbLeft.Items)
            {
                chklbRight.Items.Remove(i);
            }
        }
    }
}
