namespace ProgressBar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonEX2 = new System.Windows.Forms.Button();
            this.buttonEX3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(44, 267);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(695, 47);
            this.progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonEX2
            // 
            this.buttonEX2.Location = new System.Drawing.Point(64, 82);
            this.buttonEX2.Name = "buttonEX2";
            this.buttonEX2.Size = new System.Drawing.Size(94, 29);
            this.buttonEX2.TabIndex = 1;
            this.buttonEX2.Text = "EXEMPLO 2";
            this.buttonEX2.UseVisualStyleBackColor = true;
            this.buttonEX2.Click += new System.EventHandler(this.buttonEX2_Click);
            // 
            // buttonEX3
            // 
            this.buttonEX3.Location = new System.Drawing.Point(64, 127);
            this.buttonEX3.Name = "buttonEX3";
            this.buttonEX3.Size = new System.Drawing.Size(94, 29);
            this.buttonEX3.TabIndex = 2;
            this.buttonEX3.Text = "EXEMPLO3";
            this.buttonEX3.UseVisualStyleBackColor = true;
            this.buttonEX3.Click += new System.EventHandler(this.buttonEX3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEX3);
            this.Controls.Add(this.buttonEX2);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Button buttonEX2;
        private Button buttonEX3;
    }
}