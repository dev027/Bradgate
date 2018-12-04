namespace Bradgate.Seed
{
    partial class Form1
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
            this.btnSeed70Club = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeed70Club
            // 
            this.btnSeed70Club.Location = new System.Drawing.Point(19, 19);
            this.btnSeed70Club.Name = "btnSeed70Club";
            this.btnSeed70Club.Size = new System.Drawing.Size(150, 32);
            this.btnSeed70Club.TabIndex = 0;
            this.btnSeed70Club.Text = "Seed 70% Club";
            this.btnSeed70Club.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSeed70Club);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeed70Club;
    }
}

