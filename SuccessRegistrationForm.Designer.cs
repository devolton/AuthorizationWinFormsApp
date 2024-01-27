namespace RegistrationApp
{
    partial class SuccessRegistrationForm
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
            okButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.BackColor = Color.ForestGreen;
            okButton.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            okButton.ForeColor = Color.White;
            okButton.Location = new Point(48, 115);
            okButton.Name = "okButton";
            okButton.Size = new Size(247, 84);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(298, 71);
            label1.TabIndex = 1;
            label1.Text = "Success!";
            // 
            // SuccessRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(344, 211);
            Controls.Add(label1);
            Controls.Add(okButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Location = new Point(500, 500);
            MaximizeBox = false;
            Name = "SuccessRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuccessForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Label label1;
    }
}