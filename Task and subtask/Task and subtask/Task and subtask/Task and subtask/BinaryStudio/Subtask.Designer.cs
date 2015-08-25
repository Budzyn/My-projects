namespace BinaryStudio
{
    partial class Subtask
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
            this.panelCheck = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBoxSubtask = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelCheck
            // 
            this.panelCheck.Location = new System.Drawing.Point(12, 89);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Size = new System.Drawing.Size(180, 264);
            this.panelCheck.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 48);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(180, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create subtask";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtBoxSubtask
            // 
            this.txtBoxSubtask.Location = new System.Drawing.Point(12, 12);
            this.txtBoxSubtask.Name = "txtBoxSubtask";
            this.txtBoxSubtask.Size = new System.Drawing.Size(180, 20);
            this.txtBoxSubtask.TabIndex = 2;
            this.txtBoxSubtask.TextChanged += new System.EventHandler(this.txtBoxSubtask_TextChanged);
            this.txtBoxSubtask.Enter += new System.EventHandler(this.txtBoxSubtask_Enter);
            this.txtBoxSubtask.Leave += new System.EventHandler(this.txtBoxSubtask_Leave);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(208, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(152, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove made subtasks";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(285, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Subtask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 365);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtBoxSubtask);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panelCheck);
            this.Name = "Subtask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subtask";
            this.Load += new System.EventHandler(this.Subtask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCheck;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtBoxSubtask;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnExit;
    }
}