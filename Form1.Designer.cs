
namespace Ado.Net_Exam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.taxiDBDataSet = new Ado.Net_Exam.TaxiDBDataSet();
            this.taxiDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderSetTableAdapter = new Ado.Net_Exam.TaxiDBDataSetTableAdapters.OrderSetTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(964, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // taxiDBDataSet
            // 
            this.taxiDBDataSet.DataSetName = "TaxiDBDataSet";
            this.taxiDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taxiDBDataSetBindingSource
            // 
            this.taxiDBDataSetBindingSource.DataSource = this.taxiDBDataSet;
            this.taxiDBDataSetBindingSource.Position = 0;
            // 
            // orderSetBindingSource
            // 
            this.orderSetBindingSource.DataMember = "OrderSet";
            this.orderSetBindingSource.DataSource = this.taxiDBDataSetBindingSource;
            // 
            // orderSetTableAdapter
            // 
            this.orderSetTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить заказ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "Посмотреть заказы за день";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(782, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 60);
            this.button4.TabIndex = 4;
            this.button4.Text = "База водителей";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(782, 473);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 60);
            this.button5.TabIndex = 5;
            this.button5.Text = "База клиентов";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(241, 473);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(240, 56);
            this.button6.TabIndex = 6;
            this.button6.Text = "Посмотреть все заказы";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(518, 393);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(229, 59);
            this.button7.TabIndex = 7;
            this.button7.Text = "Добавить водителя";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(518, 474);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(229, 59);
            this.button8.TabIndex = 8;
            this.button8.Text = "Добавить клиента";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(384, 409);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 603);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " База Такси \"In Drive\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource taxiDBDataSetBindingSource;
        private TaxiDBDataSet taxiDBDataSet;
        private System.Windows.Forms.BindingSource orderSetBindingSource;
        private TaxiDBDataSetTableAdapters.OrderSetTableAdapter orderSetTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

