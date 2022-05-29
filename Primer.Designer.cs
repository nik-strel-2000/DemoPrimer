
namespace APITestForm
{
    partial class Primer
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
            this.Download = new System.Windows.Forms.Button();
            this.Postbt = new System.Windows.Forms.Button();
            this.UpdateBT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.MiddleNameText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.TextBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.SourseText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(58, 399);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(94, 29);
            this.Download.TabIndex = 0;
            this.Download.Text = "загрузить";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Postbt
            // 
            this.Postbt.Location = new System.Drawing.Point(241, 399);
            this.Postbt.Name = "Postbt";
            this.Postbt.Size = new System.Drawing.Size(94, 29);
            this.Postbt.TabIndex = 1;
            this.Postbt.Text = "Отправить";
            this.Postbt.UseVisualStyleBackColor = true;
            this.Postbt.Click += new System.EventHandler(this.Postbt_Click);
            // 
            // UpdateBT
            // 
            this.UpdateBT.Location = new System.Drawing.Point(440, 399);
            this.UpdateBT.Name = "UpdateBT";
            this.UpdateBT.Size = new System.Drawing.Size(94, 29);
            this.UpdateBT.TabIndex = 2;
            this.UpdateBT.Text = "Обновить";
            this.UpdateBT.UseVisualStyleBackColor = true;
            this.UpdateBT.Click += new System.EventHandler(this.UpdateBT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(612, 269);
            this.dataGridView1.TabIndex = 3;
            // 
            // IdText
            // 
            this.IdText.Location = new System.Drawing.Point(49, 315);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(125, 27);
            this.IdText.TabIndex = 4;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(420, 315);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(125, 27);
            this.FirstNameText.TabIndex = 5;
            // 
            // MiddleNameText
            // 
            this.MiddleNameText.Location = new System.Drawing.Point(621, 315);
            this.MiddleNameText.Name = "MiddleNameText";
            this.MiddleNameText.Size = new System.Drawing.Size(125, 27);
            this.MiddleNameText.TabIndex = 6;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(223, 315);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(125, 27);
            this.NameText.TabIndex = 7;
            // 
            // DeleteBt
            // 
            this.DeleteBt.Location = new System.Drawing.Point(639, 399);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(94, 29);
            this.DeleteBt.TabIndex = 8;
            this.DeleteBt.Text = "Удалить";
            this.DeleteBt.UseVisualStyleBackColor = true;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(354, 399);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(67, 27);
            this.Code.TabIndex = 9;
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(639, 12);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(151, 28);
            this.comboBoxName.TabIndex = 10;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // SourseText
            // 
            this.SourseText.Location = new System.Drawing.Point(639, 88);
            this.SourseText.Name = "SourseText";
            this.SourseText.Size = new System.Drawing.Size(151, 27);
            this.SourseText.TabIndex = 11;
            this.SourseText.TextChanged += new System.EventHandler(this.SourseText_TextChanged);
            // 
            // Primer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Primer";
            this.Text = "WorkedApiRequst";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button Postbt;
        private System.Windows.Forms.Button UpdateBT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox MiddleNameText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.TextBox SourseText;
    }
}