namespace if_else_kullanımı_2
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
            this.cbKirmizi = new System.Windows.Forms.CheckBox();
            this.cbMavi = new System.Windows.Forms.CheckBox();
            this.cbMor = new System.Windows.Forms.CheckBox();
            this.cbYesil = new System.Windows.Forms.CheckBox();
            this.cbSari = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbKirmizi
            // 
            this.cbKirmizi.AutoSize = true;
            this.cbKirmizi.Location = new System.Drawing.Point(12, 24);
            this.cbKirmizi.Name = "cbKirmizi";
            this.cbKirmizi.Size = new System.Drawing.Size(55, 17);
            this.cbKirmizi.TabIndex = 0;
            this.cbKirmizi.Text = "Kırmızı";
            this.cbKirmizi.UseVisualStyleBackColor = true;
            this.cbKirmizi.CheckedChanged += new System.EventHandler(this.cbKirmizi_CheckedChanged);
            // 
            // cbMavi
            // 
            this.cbMavi.AutoSize = true;
            this.cbMavi.Location = new System.Drawing.Point(12, 47);
            this.cbMavi.Name = "cbMavi";
            this.cbMavi.Size = new System.Drawing.Size(49, 17);
            this.cbMavi.TabIndex = 1;
            this.cbMavi.Text = "Mavi";
            this.cbMavi.UseVisualStyleBackColor = true;
            this.cbMavi.CheckedChanged += new System.EventHandler(this.cbMavi_CheckedChanged);
            // 
            // cbMor
            // 
            this.cbMor.AutoSize = true;
            this.cbMor.Location = new System.Drawing.Point(12, 70);
            this.cbMor.Name = "cbMor";
            this.cbMor.Size = new System.Drawing.Size(44, 17);
            this.cbMor.TabIndex = 2;
            this.cbMor.Text = "Mor";
            this.cbMor.UseVisualStyleBackColor = true;
            this.cbMor.CheckedChanged += new System.EventHandler(this.cbSiyah_CheckedChanged);
            // 
            // cbYesil
            // 
            this.cbYesil.AutoSize = true;
            this.cbYesil.Location = new System.Drawing.Point(12, 93);
            this.cbYesil.Name = "cbYesil";
            this.cbYesil.Size = new System.Drawing.Size(48, 17);
            this.cbYesil.TabIndex = 3;
            this.cbYesil.Text = "Yeşil";
            this.cbYesil.UseVisualStyleBackColor = true;
            this.cbYesil.CheckedChanged += new System.EventHandler(this.cbYesil_CheckedChanged);
            // 
            // cbSari
            // 
            this.cbSari.AutoSize = true;
            this.cbSari.Location = new System.Drawing.Point(12, 116);
            this.cbSari.Name = "cbSari";
            this.cbSari.Size = new System.Drawing.Size(44, 17);
            this.cbSari.TabIndex = 4;
            this.cbSari.Text = "Sarı";
            this.cbSari.UseVisualStyleBackColor = true;
            this.cbSari.CheckedChanged += new System.EventHandler(this.cbSari_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 189);
            this.Controls.Add(this.cbSari);
            this.Controls.Add(this.cbYesil);
            this.Controls.Add(this.cbMor);
            this.Controls.Add(this.cbMavi);
            this.Controls.Add(this.cbKirmizi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbKirmizi;
        private System.Windows.Forms.CheckBox cbMavi;
        private System.Windows.Forms.CheckBox cbMor;
        private System.Windows.Forms.CheckBox cbYesil;
        private System.Windows.Forms.CheckBox cbSari;
    }
}

