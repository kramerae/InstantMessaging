namespace FinalProject
{
    partial class AddContactForm
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
            this.AddLabel = new System.Windows.Forms.Label();
            this.uxAddTextBox = new System.Windows.Forms.TextBox();
            this.uxAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLabel.Location = new System.Drawing.Point(12, 47);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(202, 20);
            this.AddLabel.TabIndex = 0;
            this.AddLabel.Text = "Contact Username to Add: ";
            // 
            // uxAddTextBox
            // 
            this.uxAddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddTextBox.Location = new System.Drawing.Point(220, 47);
            this.uxAddTextBox.Name = "uxAddTextBox";
            this.uxAddTextBox.Size = new System.Drawing.Size(156, 22);
            this.uxAddTextBox.TabIndex = 1;
            // 
            // uxAddButton
            // 
            this.uxAddButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.uxAddButton.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uxAddButton.Location = new System.Drawing.Point(146, 89);
            this.uxAddButton.Name = "uxAddButton";
            this.uxAddButton.Size = new System.Drawing.Size(123, 42);
            this.uxAddButton.TabIndex = 2;
            this.uxAddButton.Text = "Add Contact";
            this.uxAddButton.UseVisualStyleBackColor = false;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 143);
            this.Controls.Add(this.uxAddButton);
            this.Controls.Add(this.uxAddTextBox);
            this.Controls.Add(this.AddLabel);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.TextBox uxAddTextBox;
        private System.Windows.Forms.Button uxAddButton;
    }
}