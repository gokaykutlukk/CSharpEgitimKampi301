namespace CSharpEgitimKampi301.EFProject
{
    partial class FrmLocation
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textCountry = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textDayNight = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.cmbGuide = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(272, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 44);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 386);
            this.dataGridView1.TabIndex = 23;
            // 
            // textCountry
            // 
            this.textCountry.Location = new System.Drawing.Point(117, 105);
            this.textCountry.Name = "textCountry";
            this.textCountry.Size = new System.Drawing.Size(178, 22);
            this.textCountry.TabIndex = 22;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(117, 63);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(178, 22);
            this.textCity.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ülke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Şehir";
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(197, 471);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(98, 52);
            this.btnGetById.TabIndex = 18;
            this.btnGetById.Text = "Id iGetir";
            this.btnGetById.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(272, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 44);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(117, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 54);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(117, 23);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(178, 22);
            this.textId.TabIndex = 15;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(117, 400);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(98, 47);
            this.btnList.TabIndex = 14;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lokasyon Id";
            // 
            // textDayNight
            // 
            this.textDayNight.Location = new System.Drawing.Point(117, 230);
            this.textDayNight.Name = "textDayNight";
            this.textDayNight.Size = new System.Drawing.Size(178, 22);
            this.textDayNight.TabIndex = 30;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(117, 188);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(178, 22);
            this.textPrice.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Gün Gece";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Kapasite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Rehber";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(117, 154);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(171, 22);
            this.nudCapacity.TabIndex = 33;
            // 
            // cmbGuide
            // 
            this.cmbGuide.FormattingEnabled = true;
            this.cmbGuide.Location = new System.Drawing.Point(117, 279);
            this.cmbGuide.Name = "cmbGuide";
            this.cmbGuide.Size = new System.Drawing.Size(178, 24);
            this.cmbGuide.TabIndex = 34;
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 544);
            this.Controls.Add(this.cmbGuide);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textDayNight);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textCountry);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label1);
            this.Name = "FrmLocation";
            this.Text = "FrmLocation";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textCountry;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDayNight;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.ComboBox cmbGuide;
    }
}