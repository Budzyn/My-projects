namespace BinaryStudio
{
    partial class Task
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxTask = new System.Windows.Forms.TextBox();
            this.richTextBoxDiscription = new System.Windows.Forms.RichTextBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.btnStep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxTask
            // 
            this.txtBoxTask.Location = new System.Drawing.Point(12, 12);
            this.txtBoxTask.Name = "txtBoxTask";
            this.txtBoxTask.Size = new System.Drawing.Size(162, 20);
            this.txtBoxTask.TabIndex = 0;
 

            
            // 
            // richTextBoxDiscription
            // 
            this.richTextBoxDiscription.Location = new System.Drawing.Point(12, 38);
            this.richTextBoxDiscription.Name = "richTextBoxDiscription";
            this.richTextBoxDiscription.Size = new System.Drawing.Size(162, 96);
            this.richTextBoxDiscription.TabIndex = 1;
            this.richTextBoxDiscription.Text = "";
            this.richTextBoxDiscription.Enter += new System.EventHandler(this.richTextBoxDiscription_Enter);
            this.richTextBoxDiscription.Leave += new System.EventHandler(this.richTextBoxDiscription_Leave);
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(13, 141);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(161, 20);
            this.txtBoxDate.TabIndex = 2;
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(12, 185);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(162, 23);
            this.btnStep.TabIndex = 3;
            this.btnStep.Text = "Next step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 231);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.richTextBoxDiscription);
            this.Controls.Add(this.txtBoxTask);
            this.Name = "Task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTask;
        private System.Windows.Forms.RichTextBox richTextBoxDiscription;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Button btnStep;
    }
}

