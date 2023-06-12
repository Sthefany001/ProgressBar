namespace ProgressBar
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_AtivaProgressBar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(46, 295);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(700, 62);
            this.progressBar1.TabIndex = 0;
            // 
            // button_AtivaProgressBar
            // 
            this.button_AtivaProgressBar.Location = new System.Drawing.Point(328, 248);
            this.button_AtivaProgressBar.Name = "button_AtivaProgressBar";
            this.button_AtivaProgressBar.Size = new System.Drawing.Size(94, 29);
            this.button_AtivaProgressBar.TabIndex = 1;
            this.button_AtivaProgressBar.Text = "Download";
            this.button_AtivaProgressBar.UseVisualStyleBackColor = true;
            this.button_AtivaProgressBar.Click += new System.EventHandler(this.button_AtivaProgressBar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_AtivaProgressBar);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private Button button_AtivaProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}