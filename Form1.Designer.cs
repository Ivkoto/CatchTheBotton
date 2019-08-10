namespace CatchTheButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCatchMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCatchMe
            // 
            this.btnCatchMe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCatchMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCatchMe.Location = new System.Drawing.Point(82, 73);
            this.btnCatchMe.Name = "btnCatchMe";
            this.btnCatchMe.Size = new System.Drawing.Size(150, 60);
            this.btnCatchMe.TabIndex = 0;
            this.btnCatchMe.Text = "’‚‡ÌË ÏÂ, ‡ÍÓ ˇ ËÒÍ‡¯!";
            this.btnCatchMe.UseVisualStyleBackColor = true;
            this.btnCatchMe.Click += new System.EventHandler(this.btnCatchMe_Click);
            this.btnCatchMe.MouseEnter += new System.EventHandler(this.btnCatchMe_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 361);
            this.Controls.Add(this.btnCatchMe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "»— ¿“≈ À» «¿œÀ¿“¿ ƒÕ≈—?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCatchMe;
    }
}