namespace VeterinarskaRadnja
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.File = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiDodajLjubimca = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.lblName = new System.Windows.Forms.ToolStripLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtImeKorisnika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivRadnje = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dataGridViewPodaci = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.aboutToolStripMenuButton,
            this.lblName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(652, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // File
            // 
            this.File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDodajLjubimca,
            this.quitToolStripMenuItem});
            this.File.Image = ((System.Drawing.Image)(resources.GetObject("File.Image")));
            this.File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(38, 22);
            this.File.Text = "File";
            this.File.ToolTipText = "File";
            // 
            // tsmiDodajLjubimca
            // 
            this.tsmiDodajLjubimca.Enabled = false;
            this.tsmiDodajLjubimca.Name = "tsmiDodajLjubimca";
            this.tsmiDodajLjubimca.Size = new System.Drawing.Size(154, 22);
            this.tsmiDodajLjubimca.Text = "Dodaj ljubimca";
            this.tsmiDodajLjubimca.Click += new System.EventHandler(this.tsmiDodajLjubimca_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.quitToolStripMenuItem.Text = "Izlaz";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuButton
            // 
            this.aboutToolStripMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuButton.Image")));
            this.aboutToolStripMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStripMenuButton.Name = "aboutToolStripMenuButton";
            this.aboutToolStripMenuButton.Size = new System.Drawing.Size(53, 22);
            this.aboutToolStripMenuButton.Text = "About";
            this.aboutToolStripMenuButton.Click += new System.EventHandler(this.aboutToolStripMenuButton_Click);
            // 
            // lblName
            // 
            this.lblName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 22);
            this.lblName.Text = "lblName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ime Korisnika";
            // 
            // txtImeKorisnika
            // 
            this.txtImeKorisnika.Enabled = false;
            this.txtImeKorisnika.Location = new System.Drawing.Point(503, 138);
            this.txtImeKorisnika.Name = "txtImeKorisnika";
            this.txtImeKorisnika.Size = new System.Drawing.Size(127, 20);
            this.txtImeKorisnika.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Naziv veterinarske radnje";
            // 
            // txtNazivRadnje
            // 
            this.txtNazivRadnje.Enabled = false;
            this.txtNazivRadnje.Location = new System.Drawing.Point(503, 87);
            this.txtNazivRadnje.Name = "txtNazivRadnje";
            this.txtNazivRadnje.Size = new System.Drawing.Size(127, 20);
            this.txtNazivRadnje.TabIndex = 17;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Enabled = false;
            this.btnPretrazi.Location = new System.Drawing.Point(555, 188);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 16;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dataGridViewPodaci
            // 
            this.dataGridViewPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPodaci.Location = new System.Drawing.Point(25, 69);
            this.dataGridViewPodaci.Name = "dataGridViewPodaci";
            this.dataGridViewPodaci.Size = new System.Drawing.Size(440, 282);
            this.dataGridViewPodaci.TabIndex = 15;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 397);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImeKorisnika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazivRadnje);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dataGridViewPodaci);
            this.Name = "AppForm";
            this.Text = "Veterinarska Radnja";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton File;
        private System.Windows.Forms.ToolStripMenuItem tsmiDodajLjubimca;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton aboutToolStripMenuButton;
        private System.Windows.Forms.ToolStripLabel lblName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImeKorisnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivRadnje;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dataGridViewPodaci;
    }
}