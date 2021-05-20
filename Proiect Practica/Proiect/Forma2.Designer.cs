
namespace Proiect
{
    partial class Forma2
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
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelCNP = new System.Windows.Forms.Label();
            this.labelPozitie = new System.Windows.Forms.Label();
            this.labelSalariuBrut = new System.Windows.Forms.Label();
            this.labelScutireImpozit = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.textBoxPozitie = new System.Windows.Forms.TextBox();
            this.textBoxSalariuBrut = new System.Windows.Forms.TextBox();
            this.textBoxScutireImpozit = new System.Windows.Forms.TextBox();
            this.buttonActualizare = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCNP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCNP)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.Location = new System.Drawing.Point(13, 30);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(52, 17);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenume.Location = new System.Drawing.Point(12, 92);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(85, 17);
            this.labelPrenume.TabIndex = 1;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCNP.Location = new System.Drawing.Point(13, 154);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(41, 17);
            this.labelCNP.TabIndex = 2;
            this.labelCNP.Text = "CNP";
            // 
            // labelPozitie
            // 
            this.labelPozitie.AutoSize = true;
            this.labelPozitie.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPozitie.Location = new System.Drawing.Point(13, 217);
            this.labelPozitie.Name = "labelPozitie";
            this.labelPozitie.Size = new System.Drawing.Size(85, 17);
            this.labelPozitie.TabIndex = 3;
            this.labelPozitie.Text = "Poziție";
            // 
            // labelSalariuBrut
            // 
            this.labelSalariuBrut.AutoSize = true;
            this.labelSalariuBrut.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalariuBrut.Location = new System.Drawing.Point(12, 278);
            this.labelSalariuBrut.Name = "labelSalariuBrut";
            this.labelSalariuBrut.Size = new System.Drawing.Size(151, 17);
            this.labelSalariuBrut.TabIndex = 4;
            this.labelSalariuBrut.Text = "Salariul Brut";
            // 
            // labelScutireImpozit
            // 
            this.labelScutireImpozit.AutoSize = true;
            this.labelScutireImpozit.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScutireImpozit.Location = new System.Drawing.Point(12, 340);
            this.labelScutireImpozit.Name = "labelScutireImpozit";
            this.labelScutireImpozit.Size = new System.Drawing.Size(173, 17);
            this.labelScutireImpozit.TabIndex = 5;
            this.labelScutireImpozit.Text = "Scutire Impozit";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(221, 12);
            this.textBoxNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(100, 22);
            this.textBoxNume.TabIndex = 6;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            this.textBoxNume.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNume_Validating);
            this.textBoxNume.Validated += new System.EventHandler(this.textBoxNume_Validated);
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(221, 87);
            this.textBoxPrenume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrenume.TabIndex = 7;
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(221, 149);
            this.textBoxCNP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(100, 22);
            this.textBoxCNP.TabIndex = 8;
            // 
            // textBoxPozitie
            // 
            this.textBoxPozitie.Location = new System.Drawing.Point(221, 210);
            this.textBoxPozitie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPozitie.Name = "textBoxPozitie";
            this.textBoxPozitie.Size = new System.Drawing.Size(100, 22);
            this.textBoxPozitie.TabIndex = 9;
            // 
            // textBoxSalariuBrut
            // 
            this.textBoxSalariuBrut.Location = new System.Drawing.Point(221, 273);
            this.textBoxSalariuBrut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSalariuBrut.Name = "textBoxSalariuBrut";
            this.textBoxSalariuBrut.Size = new System.Drawing.Size(100, 22);
            this.textBoxSalariuBrut.TabIndex = 10;
            // 
            // textBoxScutireImpozit
            // 
            this.textBoxScutireImpozit.Location = new System.Drawing.Point(221, 335);
            this.textBoxScutireImpozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxScutireImpozit.Name = "textBoxScutireImpozit";
            this.textBoxScutireImpozit.Size = new System.Drawing.Size(100, 22);
            this.textBoxScutireImpozit.TabIndex = 11;
            // 
            // buttonActualizare
            // 
            this.buttonActualizare.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizare.Location = new System.Drawing.Point(95, 379);
            this.buttonActualizare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonActualizare.Name = "buttonActualizare";
            this.buttonActualizare.Size = new System.Drawing.Size(169, 59);
            this.buttonActualizare.TabIndex = 12;
            this.buttonActualizare.Text = "Actualizează";
            this.buttonActualizare.UseVisualStyleBackColor = true;
            this.buttonActualizare.Click += new System.EventHandler(this.buttonActualizare_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProviderCNP
            // 
            this.errorProviderCNP.ContainerControl = this;
            // 
            // Forma2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.buttonActualizare);
            this.Controls.Add(this.textBoxScutireImpozit);
            this.Controls.Add(this.textBoxSalariuBrut);
            this.Controls.Add(this.textBoxPozitie);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelScutireImpozit);
            this.Controls.Add(this.labelSalariuBrut);
            this.Controls.Add(this.labelPozitie);
            this.Controls.Add(this.labelCNP);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Forma2";
            this.Text = "FormaAngajat";
            this.Load += new System.EventHandler(this.Forma2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCNP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.Label labelPozitie;
        private System.Windows.Forms.Label labelSalariuBrut;
        private System.Windows.Forms.Label labelScutireImpozit;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.TextBox textBoxPozitie;
        private System.Windows.Forms.TextBox textBoxSalariuBrut;
        private System.Windows.Forms.TextBox textBoxScutireImpozit;
        public System.Windows.Forms.Button buttonActualizare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProviderCNP;
    }
}