using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BinaryStudio
{
    public partial class Subtask : Form
    {
        public CheckBox[] checkbox;
        public Subtask()
        {
            InitializeComponent();
            panelCheck.AutoSize = true;
        }
        int i = 0;
        Point location = new Point(0, 0);

        private void Subtask_Load(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            txtBoxSubtask.Text = "Create subtask...";
            txtBoxSubtask.ForeColor = Color.Gray;
        }

        private void txtBoxSubtask_Enter(object sender, EventArgs e)
        {
            txtBoxSubtask.Text = "";
            txtBoxSubtask.ForeColor = Color.Black;
        }

        private void txtBoxSubtask_Leave(object sender, EventArgs e)
        {
            if (txtBoxSubtask.Text == "")
            {
                txtBoxSubtask.ForeColor = Color.Gray;
                txtBoxSubtask.Enter += txtBoxSubtask_Enter;
                txtBoxSubtask.Text = "Create subtask...";
            }
            else
            {
                txtBoxSubtask.Enter -= txtBoxSubtask_Enter;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CheckBox checkbox = new CheckBox();
            checkbox.AutoSize = true;
            checkbox.Name = "" + i.ToString();
            checkbox.Text = txtBoxSubtask.Text;
            checkbox.Size = new System.Drawing.Size(51, 51);
            checkbox.Left = location.X;
            checkbox.Top = location.Y;
            checkbox.UseVisualStyleBackColor = true;
            panelCheck.Controls.Add(checkbox);
            i++;
            location = new Point(location.X, location.Y + checkbox.Height);
            foreach (Control text in this.Controls)
            {
                if (text.GetType() == typeof(TextBox))
                    text.Text = string.Empty;
            }
        }

        private void txtBoxSubtask_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSubtask.Text.Length == 0) btnCreate.Enabled = false;
            else btnCreate.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var cb_list = new List<CheckBox>();
            foreach (Control c in panelCheck.Controls)
            {
                if (c is CheckBox)
                    cb_list.Add((CheckBox)c);
            }
            cb_list.ForEach(cb => { if (cb.Checked)panelCheck.Controls.Remove(cb); });

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
