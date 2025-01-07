namespace CSharpEgitimKampi301.EFProject
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rehber Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(186, 192);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(98, 47);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(157, 61);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(178, 22);
            this.textId.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(186, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 54);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(186, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 44);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(186, 455);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(98, 52);
            this.btnGetById.TabIndex = 6;
            this.btnGetById.Text = "Id iGetir";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rehber adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rehber Soyadı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(170, 98);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(178, 22);
            this.textName.TabIndex = 9;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(186, 137);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(178, 22);
            this.textSurname.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 386);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(186, 390);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 44);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 519);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rehber İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
    }
}

