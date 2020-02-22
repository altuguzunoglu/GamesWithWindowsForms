namespace GamesWForm
{
    partial class AddNewYearForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewYearForm));
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.bEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbYil = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(29, 29);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(191, 248);
            this.dgvList.TabIndex = 0;
            // 
            // bEkle
            // 
            this.bEkle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEkle.Location = new System.Drawing.Point(29, 381);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(279, 39);
            this.bEkle.TabIndex = 1;
            this.bEkle.Text = "Ekle";
            this.bEkle.UseVisualStyleBackColor = true;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yıl:";
            // 
            // tbYil
            // 
            this.tbYil.Location = new System.Drawing.Point(89, 327);
            this.tbYil.Name = "tbYil";
            this.tbYil.Size = new System.Drawing.Size(219, 22);
            this.tbYil.TabIndex = 3;
            // 
            // AddNewYearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 596);
            this.Controls.Add(this.tbYil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.dgvList);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AddNewYearForm";
            this.Text = "AddNewYearForm";
            this.Load += new System.EventHandler(this.AddNewYearForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button bEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbYil;
    }
}