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
    public partial class Task : Form
    {
        public Task()
        {
            InitializeComponent();
        }

        private void Task_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txtBoxTask = (TextBox)c;
                    SetEmptyStyle(txtBoxTask);
                    txtBoxTask.Tag = true;
                    txtBoxTask.Enter += txtBoxTask_Enter;
                    txtBoxTask.Leave += txtBoxTask_Leave;
                }
            }
            foreach (Control c in this.Controls)
            {
                if (c is RichTextBox)
                {
                    RichTextBox richTextBoxDiscription = (RichTextBox)c;
                    SetEmptyStyle(richTextBoxDiscription);
                    richTextBoxDiscription.Tag = true;
                    richTextBoxDiscription.Enter += richTextBoxDiscription_Enter;
                    richTextBoxDiscription.Leave += richTextBoxDiscription_Leave;
                }
            }
            txtBoxDate.Text = DateTime.Now.ToString("dd/MM/yy"); 
        }


        private void SetNormalStyle(TextBox txtBoxTask)
        {
            richTextBoxDiscription.ForeColor = Color.Black;
            richTextBoxDiscription.Text = string.Empty;
        }
        private void SetNormalStyle(RichTextBox richTextBoxDiscription)
        {
            richTextBoxDiscription.ForeColor = Color.Black;
            richTextBoxDiscription.Text = string.Empty;
        }
        private void SetEmptyStyle(TextBox txtBoxTask)
        {
            txtBoxTask.ForeColor = Color.Gray;
            txtBoxTask.Text = "Create task...";
        }
        private void SetEmptyStyle(RichTextBox richTextBoxDiscription)
        {
            richTextBoxDiscription.ForeColor = Color.Gray;
            richTextBoxDiscription.Text = "Description of the problem...";
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            Subtask ob = new Subtask();
            ob.Show();
        }

        private void txtBoxTask_Enter(object sender, EventArgs e)
        {
            TextBox txtBoxTask = sender as TextBox;
            if ((bool)txtBoxTask.Tag)
                SetNormalStyle(txtBoxTask);
        }

        private void txtBoxTask_Leave(object sender, EventArgs e)
        {
            TextBox txtBoxTask = sender as TextBox;
            bool is_empty = string.IsNullOrEmpty(txtBoxTask.Text);
            if (is_empty)
                SetEmptyStyle(txtBoxTask);
            txtBoxTask.Tag = is_empty;
        }

        private void richTextBoxDiscription_Enter(object sender, EventArgs e)
        {
            RichTextBox richTextBoxDiscription = sender as RichTextBox;
            if ((bool)richTextBoxDiscription.Tag)
                SetNormalStyle(richTextBoxDiscription);
        }

        private void richTextBoxDiscription_Leave(object sender, EventArgs e)
        {
            RichTextBox richTextBoxDiscription = sender as RichTextBox;
            bool is_empty = string.IsNullOrEmpty(richTextBoxDiscription.Text);
            if (is_empty)
                SetEmptyStyle(richTextBoxDiscription);
            richTextBoxDiscription.Tag = is_empty;
        }
        
    }
}
