namespace GamesWForm
{
    partial class AddNewGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewGameForm));
            this.dgvAddGame = new System.Windows.Forms.DataGridView();
            this.bList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMaaliyet = new System.Windows.Forms.TextBox();
            this.tbKazanc = new System.Windows.Forms.TextBox();
            this.cbYil = new System.Windows.Forms.ComboBox();
            this.clbTur = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddGame)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddGame
            // 
            this.dgvAddGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddGame.Location = new System.Drawing.Point(87, 34);
            this.dgvAddGame.Name = "dgvAddGame";
            this.dgvAddGame.RowHeadersWidth = 51;
            this.dgvAddGame.RowTemplate.Height = 24;
            this.dgvAddGame.Size = new System.Drawing.Size(615, 231);
            this.dgvAddGame.TabIndex = 0;
            // 
            // bList
            // 
            this.bList.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bList.Location = new System.Drawing.Point(303, 283);
            this.bList.Name = "bList";
            this.bList.Size = new System.Drawing.Size(179, 27);
            this.bList.TabIndex = 1;
            this.bList.Text = "Refresh List";
            this.bList.UseVisualStyleBackColor = true;
            this.bList.Click += new System.EventHandler(this.bList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oyun Adı:";
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bAdd.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(27, 526);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(738, 54);
            this.bAdd.TabIndex = 7;
            this.bAdd.Text = "Oyun Ekle";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(205, 331);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(256, 22);
            this.tbName.TabIndex = 8;
            // 
            // tbMaaliyet
            // 
            this.tbMaaliyet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbMaaliyet.Location = new System.Drawing.Point(205, 381);
            this.tbMaaliyet.Name = "tbMaaliyet";
            this.tbMaaliyet.Size = new System.Drawing.Size(256, 22);
            this.tbMaaliyet.TabIndex = 9;
            // 
            // tbKazanc
            // 
            this.tbKazanc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbKazanc.Location = new System.Drawing.Point(205, 425);
            this.tbKazanc.Name = "tbKazanc";
            this.tbKazanc.Size = new System.Drawing.Size(256, 22);
            this.tbKazanc.TabIndex = 10;
            // 
            // cbYil
            // 
            this.cbYil.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbYil.FormattingEnabled = true;
            this.cbYil.Location = new System.Drawing.Point(205, 473);
            this.cbYil.Name = "cbYil";
            this.cbYil.Size = new System.Drawing.Size(256, 24);
            this.cbYil.TabIndex = 11;
            // 
            // clbTur
            // 
            this.clbTur.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.clbTur.CheckOnClick = true;
            this.clbTur.FormattingEnabled = true;
            this.clbTur.Location = new System.Drawing.Point(577, 349);
            this.clbTur.Name = "clbTur";
            this.clbTur.Size = new System.Drawing.Size(188, 123);
            this.clbTur.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Maaliyeti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(54, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kazancı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Yapım Yılı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(477, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Türü:";
            // 
            // AddNewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbTur);
            this.Controls.Add(this.cbYil);
            this.Controls.Add(this.tbKazanc);
            this.Controls.Add(this.tbMaaliyet);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bList);
            this.Controls.Add(this.dgvAddGame);
            this.Name = "AddNewGameForm";
            this.Text = "AddNewGameForm";
            this.Load += new System.EventHandler(this.AddNewGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddGame;
        private System.Windows.Forms.Button bList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMaaliyet;
        private System.Windows.Forms.TextBox tbKazanc;
        private System.Windows.Forms.ComboBox cbYil;
        private System.Windows.Forms.CheckedListBox clbTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}