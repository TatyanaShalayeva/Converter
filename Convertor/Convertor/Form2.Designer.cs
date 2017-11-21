namespace Convertor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMp3 = new System.Windows.Forms.RadioButton();
            this.rbFlac = new System.Windows.Forms.RadioButton();
            this.rbWaw = new System.Windows.Forms.RadioButton();
            this.rbWma = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(149, 375);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(137, 50);
            this.bApply.TabIndex = 4;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(99, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose file format";
            // 
            // rbMp3
            // 
            this.rbMp3.AutoSize = true;
            this.rbMp3.Location = new System.Drawing.Point(172, 116);
            this.rbMp3.Name = "rbMp3";
            this.rbMp3.Size = new System.Drawing.Size(84, 29);
            this.rbMp3.TabIndex = 0;
            this.rbMp3.Text = "mp3";
            this.rbMp3.UseVisualStyleBackColor = true;
            // 
            // rbFlac
            // 
            this.rbFlac.AutoSize = true;
            this.rbFlac.Location = new System.Drawing.Point(172, 176);
            this.rbFlac.Name = "rbFlac";
            this.rbFlac.Size = new System.Drawing.Size(77, 29);
            this.rbFlac.TabIndex = 1;
            this.rbFlac.Text = "flac";
            this.rbFlac.UseVisualStyleBackColor = true;
            // 
            // rbWaw
            // 
            this.rbWaw.AutoSize = true;
            this.rbWaw.Location = new System.Drawing.Point(172, 236);
            this.rbWaw.Name = "rbWaw";
            this.rbWaw.Size = new System.Drawing.Size(81, 29);
            this.rbWaw.TabIndex = 2;
            this.rbWaw.Text = "wav";
            this.rbWaw.UseVisualStyleBackColor = true;
            // 
            // rbWma
            // 
            this.rbWma.AutoSize = true;
            this.rbWma.Location = new System.Drawing.Point(172, 296);
            this.rbWma.Name = "rbWma";
            this.rbWma.Size = new System.Drawing.Size(87, 29);
            this.rbWma.TabIndex = 3;
            this.rbWma.Text = "wma";
            this.rbWma.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 429);
            this.Controls.Add(this.rbWma);
            this.Controls.Add(this.rbWaw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbFlac);
            this.Controls.Add(this.rbMp3);
            this.Controls.Add(this.bApply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Format";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bApply;
        private System.Windows.Forms.RadioButton rbMp3;
        private System.Windows.Forms.RadioButton rbFlac;
        private System.Windows.Forms.RadioButton rbWaw;
        private System.Windows.Forms.RadioButton rbWma;
    }
}