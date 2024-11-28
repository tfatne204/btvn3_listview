using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi3winfrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to close the application?","Confirm Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }

        private void ClearTextBoxes()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtPhone.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtLastName.Text);
            item.SubItems.Add(txtFirstName.Text);
            item.SubItems.Add(txtPhone.Text);
            listView1.Items.Add(item);
            ClearTextBoxes();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selectedItem.SubItems[0].Text = txtLastName.Text;
                selectedItem.SubItems[1].Text = txtFirstName.Text;
                selectedItem.SubItems[2].Text = txtPhone.Text;
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }
        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                txtLastName.Text = selectedItem.SubItems[0].Text;
                txtFirstName.Text = selectedItem.SubItems[1].Text;
                txtPhone.Text = selectedItem.SubItems[2].Text;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtLastName.Text);
            item.SubItems.Add(txtFirstName.Text);
            item.SubItems.Add(txtPhone.Text);
            listView1.Items.Add(item);
            ClearTextBoxes();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selectedItem.SubItems[0].Text = txtLastName.Text;
                selectedItem.SubItems[1].Text = txtFirstName.Text;
                selectedItem.SubItems[2].Text = txtPhone.Text;
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Đã lưu thành công", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void detailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            UpdateViewStatus("Details");
        }

        private void UpdateViewStatus(string viewMode)
        {
            lblViewMode.Text = "Current View: " + viewMode;

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
            UpdateViewStatus("List");
        }

        private void smaillIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
            UpdateViewStatus("Small Icons");
        }

        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
            UpdateViewStatus("Large Icons");
        }
    }
}
