namespace Lib_database
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Books_DG = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.lIB_DBDataSet = new Lib_database.LIB_DBDataSet();
            this.newTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newTableTableAdapter = new Lib_database.LIB_DBDataSetTableAdapters.NewTableTableAdapter();
            this.Name_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Books_DG)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Books_DG);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books";
            // 
            // Books_DG
            // 
            this.Books_DG.AllowUserToAddRows = false;
            this.Books_DG.AllowUserToDeleteRows = false;
            this.Books_DG.AutoGenerateColumns = false;
            this.Books_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Books_DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_C,
            this.ID_C,
            this.Author_C,
            this.Publisher_C,
            this.Genre_C,
            this.Year_C,
            this.Quantity_C});
            this.Books_DG.DataSource = this.newTableBindingSource;
            this.Books_DG.EnableHeadersVisualStyles = false;
            this.Books_DG.Location = new System.Drawing.Point(6, 21);
            this.Books_DG.MultiSelect = false;
            this.Books_DG.Name = "Books_DG";
            this.Books_DG.RowHeadersVisible = false;
            this.Books_DG.RowHeadersWidth = 51;
            this.Books_DG.RowTemplate.Height = 24;
            this.Books_DG.Size = new System.Drawing.Size(735, 398);
            this.Books_DG.TabIndex = 0;
            this.Books_DG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Books_DG_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete_button);
            this.groupBox2.Controls.Add(this.Search_Button);
            this.groupBox2.Controls.Add(this.Edit_button);
            this.groupBox2.Controls.Add(this.Add_button);
            this.groupBox2.Location = new System.Drawing.Point(747, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 398);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(7, 22);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(181, 37);
            this.Add_button.TabIndex = 0;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(7, 78);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(181, 35);
            this.Edit_button.TabIndex = 1;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(7, 357);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(181, 35);
            this.Search_Button.TabIndex = 2;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(6, 130);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(181, 35);
            this.Delete_button.TabIndex = 3;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // lIB_DBDataSet
            // 
            this.lIB_DBDataSet.DataSetName = "LIB_DBDataSet";
            this.lIB_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newTableBindingSource
            // 
            this.newTableBindingSource.DataMember = "NewTable";
            this.newTableBindingSource.DataSource = this.lIB_DBDataSet;
            // 
            // newTableTableAdapter
            // 
            this.newTableTableAdapter.ClearBeforeFill = true;
            // 
            // Name_C
            // 
            this.Name_C.DataPropertyName = "Name";
            this.Name_C.Frozen = true;
            this.Name_C.HeaderText = "Name";
            this.Name_C.MinimumWidth = 6;
            this.Name_C.Name = "Name_C";
            // 
            // ID_C
            // 
            this.ID_C.DataPropertyName = "ID";
            this.ID_C.HeaderText = "ID";
            this.ID_C.MinimumWidth = 6;
            this.ID_C.Name = "ID_C";
            this.ID_C.ReadOnly = true;
            this.ID_C.Visible = false;
            this.ID_C.Width = 125;
            // 
            // Author_C
            // 
            this.Author_C.DataPropertyName = "Author";
            this.Author_C.HeaderText = "Author";
            this.Author_C.MinimumWidth = 6;
            this.Author_C.Name = "Author_C";
            // 
            // Publisher_C
            // 
            this.Publisher_C.DataPropertyName = "Publisher";
            this.Publisher_C.HeaderText = "Publisher";
            this.Publisher_C.MinimumWidth = 6;
            this.Publisher_C.Name = "Publisher_C";
            // 
            // Genre_C
            // 
            this.Genre_C.DataPropertyName = "Genre";
            this.Genre_C.HeaderText = "Genre";
            this.Genre_C.MinimumWidth = 6;
            this.Genre_C.Name = "Genre_C";
            // 
            // Year_C
            // 
            this.Year_C.DataPropertyName = "Year";
            this.Year_C.HeaderText = "Year";
            this.Year_C.MinimumWidth = 6;
            this.Year_C.Name = "Year_C";
            this.Year_C.Width = 50;
            // 
            // Quantity_C
            // 
            this.Quantity_C.DataPropertyName = "Quantity";
            this.Quantity_C.HeaderText = "Quantity";
            this.Quantity_C.MinimumWidth = 6;
            this.Quantity_C.Name = "Quantity_C";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "LIBRARY";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Books_DG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lIB_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.DataGridView Books_DG;
        private LIB_DBDataSet lIB_DBDataSet;
        private System.Windows.Forms.BindingSource newTableBindingSource;
        private LIB_DBDataSetTableAdapters.NewTableTableAdapter newTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_C;
    }
}

