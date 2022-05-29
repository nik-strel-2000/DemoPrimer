
namespace APITestForm
{
    partial class WorkedDataBase
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
            this.SourseText = new System.Windows.Forms.TextBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.MiddleNameText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.IdText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdateBT = new System.Windows.Forms.Button();
            this.Postbt = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SourseText
            // 
            this.SourseText.Location = new System.Drawing.Point(676, 111);
            this.SourseText.Name = "SourseText";
            this.SourseText.Size = new System.Drawing.Size(151, 27);
            this.SourseText.TabIndex = 23;
            this.SourseText.TextChanged += new System.EventHandler(this.SourseText_TextChanged);
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(676, 35);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(151, 28);
            this.comboBoxName.TabIndex = 22;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(391, 422);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(67, 27);
            this.Code.TabIndex = 21;
            // 
            // DeleteBt
            // 
            this.DeleteBt.Location = new System.Drawing.Point(676, 422);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(94, 29);
            this.DeleteBt.TabIndex = 20;
            this.DeleteBt.Text = "Удалить";
            this.DeleteBt.UseVisualStyleBackColor = true;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(260, 338);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(125, 27);
            this.NameText.TabIndex = 19;
            // 
            // MiddleNameText
            // 
            this.MiddleNameText.Location = new System.Drawing.Point(658, 338);
            this.MiddleNameText.Name = "MiddleNameText";
            this.MiddleNameText.Size = new System.Drawing.Size(125, 27);
            this.MiddleNameText.TabIndex = 18;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(457, 338);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(125, 27);
            this.FirstNameText.TabIndex = 17;
            // 
            // IdText
            // 
            this.IdText.Location = new System.Drawing.Point(86, 338);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(125, 27);
            this.IdText.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(612, 269);
            this.dataGridView1.TabIndex = 15;
            // 
            // UpdateBT
            // 
            this.UpdateBT.Location = new System.Drawing.Point(477, 422);
            this.UpdateBT.Name = "UpdateBT";
            this.UpdateBT.Size = new System.Drawing.Size(94, 29);
            this.UpdateBT.TabIndex = 14;
            this.UpdateBT.Text = "Обновить";
            this.UpdateBT.UseVisualStyleBackColor = true;
            this.UpdateBT.Click += new System.EventHandler(this.UpdateBT_Click);
            // 
            // Postbt
            // 
            this.Postbt.Location = new System.Drawing.Point(278, 422);
            this.Postbt.Name = "Postbt";
            this.Postbt.Size = new System.Drawing.Size(94, 29);
            this.Postbt.TabIndex = 13;
            this.Postbt.Text = "Отправить";
            this.Postbt.UseVisualStyleBackColor = true;
            this.Postbt.Click += new System.EventHandler(this.Postbt_Click);
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(95, 422);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(94, 29);
            this.Download.TabIndex = 12;
            this.Download.Text = "загрузить";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // WorkedDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 487);
            this.Controls.Add(this.SourseText);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.MiddleNameText);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdateBT);
            this.Controls.Add(this.Postbt);
            this.Controls.Add(this.Download);
            this.Name = "WorkedDataBase";
            this.Text = "WorkedDataBase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourseText;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox MiddleNameText;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateBT;
        private System.Windows.Forms.Button Postbt;
        private System.Windows.Forms.Button Download;
    }
}