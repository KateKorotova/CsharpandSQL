namespace WorkwithDB
{
    partial class frmMain
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
            this.organizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabaseDataSet = new WorkwithDB.MyDatabaseDataSet();
            this.organizationTableAdapter = new WorkwithDB.MyDatabaseDataSetTableAdapters.OrganizationTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataMember = "Organization";
            this.organizationBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // myDatabaseDataSet
            // 
            this.myDatabaseDataSet.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // organizationTableAdapter
            // 
            this.organizationTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.result);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(798, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Original table";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.original_table);
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(891, 387);
            this.dataGrid.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.previous);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(524, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.next_page);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmMain";
            this.Text = "Organizations";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MyDatabaseDataSet myDatabaseDataSet;
        private System.Windows.Forms.BindingSource organizationBindingSource;
        private MyDatabaseDataSetTableAdapters.OrganizationTableAdapter organizationTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

