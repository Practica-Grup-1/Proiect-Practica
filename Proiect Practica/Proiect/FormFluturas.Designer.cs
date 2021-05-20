
namespace Proiect
{
    partial class FormFluturas
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
            this.labelImpozit = new System.Windows.Forms.Label();
            this.labelCAS = new System.Windows.Forms.Label();
            this.labelCASS = new System.Windows.Forms.Label();
            this.textBoxCAS = new System.Windows.Forms.TextBox();
            this.textBoxCASS = new System.Windows.Forms.TextBox();
            this.textBoxImpozit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelImpozit
            // 
            this.labelImpozit.AutoSize = true;
            this.labelImpozit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImpozit.Location = new System.Drawing.Point(14, 378);
            this.labelImpozit.Name = "labelImpozit";
            this.labelImpozit.Size = new System.Drawing.Size(89, 26);
            this.labelImpozit.TabIndex = 0;
            this.labelImpozit.Text = "Impozit";
            // 
            // labelCAS
            // 
            this.labelCAS.AutoSize = true;
            this.labelCAS.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCAS.Location = new System.Drawing.Point(12, 38);
            this.labelCAS.Name = "labelCAS";
            this.labelCAS.Size = new System.Drawing.Size(59, 26);
            this.labelCAS.TabIndex = 1;
            this.labelCAS.Text = "CAS";
            // 
            // labelCASS
            // 
            this.labelCASS.AutoSize = true;
            this.labelCASS.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCASS.Location = new System.Drawing.Point(12, 205);
            this.labelCASS.Name = "labelCASS";
            this.labelCASS.Size = new System.Drawing.Size(72, 26);
            this.labelCASS.TabIndex = 2;
            this.labelCASS.Text = "CASS";
            this.labelCASS.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxCAS
            // 
            this.textBoxCAS.Enabled = false;
            this.textBoxCAS.Location = new System.Drawing.Point(189, 25);
            this.textBoxCAS.Multiline = true;
            this.textBoxCAS.Name = "textBoxCAS";
            this.textBoxCAS.Size = new System.Drawing.Size(136, 39);
            this.textBoxCAS.TabIndex = 3;
            // 
            // textBoxCASS
            // 
            this.textBoxCASS.Enabled = false;
            this.textBoxCASS.Location = new System.Drawing.Point(189, 189);
            this.textBoxCASS.Multiline = true;
            this.textBoxCASS.Name = "textBoxCASS";
            this.textBoxCASS.Size = new System.Drawing.Size(136, 38);
            this.textBoxCASS.TabIndex = 4;
            // 
            // textBoxImpozit
            // 
            this.textBoxImpozit.Enabled = false;
            this.textBoxImpozit.Location = new System.Drawing.Point(189, 365);
            this.textBoxImpozit.Multiline = true;
            this.textBoxImpozit.Name = "textBoxImpozit";
            this.textBoxImpozit.Size = new System.Drawing.Size(136, 35);
            this.textBoxImpozit.TabIndex = 5;
            // 
            // FormFluturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.textBoxImpozit);
            this.Controls.Add(this.textBoxCASS);
            this.Controls.Add(this.textBoxCAS);
            this.Controls.Add(this.labelCASS);
            this.Controls.Add(this.labelCAS);
            this.Controls.Add(this.labelImpozit);
            this.Name = "FormFluturas";
            this.Text = "Imprimare Contribuții";
            this.Load += new System.EventHandler(this.FormFluturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImpozit;
        private System.Windows.Forms.Label labelCAS;
        private System.Windows.Forms.Label labelCASS;
        private System.Windows.Forms.TextBox textBoxCAS;
        private System.Windows.Forms.TextBox textBoxCASS;
        private System.Windows.Forms.TextBox textBoxImpozit;
    }
}