
namespace MCD_WindowsFormElemanInceleme
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
            this.btnResimSec = new System.Windows.Forms.Button();
            this.chkEkGaranti = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(129, 158);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(98, 44);
            this.btnResimSec.TabIndex = 0;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            // 
            // chkEkGaranti
            // 
            this.chkEkGaranti.AutoSize = true;
            this.chkEkGaranti.Location = new System.Drawing.Point(321, 171);
            this.chkEkGaranti.Name = "chkEkGaranti";
            this.chkEkGaranti.Size = new System.Drawing.Size(125, 21);
            this.chkEkGaranti.TabIndex = 1;
            this.chkEkGaranti.Text = "Ek garanti 2 Yıl";
            this.chkEkGaranti.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(596, 130);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 781);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chkEkGaranti);
            this.Controls.Add(this.btnResimSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.CheckBox chkEkGaranti;
        private System.Windows.Forms.ListView listView1;
    }
}

