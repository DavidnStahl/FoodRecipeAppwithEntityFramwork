namespace inlam1.entityFramwork_gorom
{
    partial class MainForm
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
            this.btnCreateNewRecipe = new System.Windows.Forms.Button();
            this.btnUpdateRecipe = new System.Windows.Forms.Button();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.tBoxTitle = new System.Windows.Forms.TextBox();
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.richTextIngrediens = new System.Windows.Forms.RichTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstBoxRecipe = new System.Windows.Forms.ListBox();
            this.tBoxSearchField = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cBoxCategorys = new System.Windows.Forms.ComboBox();
            this.cBoxCategoriesNewAddDelete = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateNewRecipe
            // 
            this.btnCreateNewRecipe.Location = new System.Drawing.Point(452, 379);
            this.btnCreateNewRecipe.Name = "btnCreateNewRecipe";
            this.btnCreateNewRecipe.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNewRecipe.TabIndex = 0;
            this.btnCreateNewRecipe.Text = "New";
            this.btnCreateNewRecipe.UseVisualStyleBackColor = true;
            this.btnCreateNewRecipe.Click += new System.EventHandler(this.btnCreateNewRecipe_Click);
            // 
            // btnUpdateRecipe
            // 
            this.btnUpdateRecipe.Location = new System.Drawing.Point(558, 379);
            this.btnUpdateRecipe.Name = "btnUpdateRecipe";
            this.btnUpdateRecipe.Size = new System.Drawing.Size(93, 23);
            this.btnUpdateRecipe.TabIndex = 1;
            this.btnUpdateRecipe.Text = "Update";
            this.btnUpdateRecipe.UseVisualStyleBackColor = true;
            this.btnUpdateRecipe.Click += new System.EventHandler(this.btnUpdateRecipe_Click);
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Location = new System.Drawing.Point(678, 379);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRecipe.TabIndex = 2;
            this.btnDeleteRecipe.Text = "Delete";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // tBoxTitle
            // 
            this.tBoxTitle.Location = new System.Drawing.Point(452, 28);
            this.tBoxTitle.MaxLength = 50;
            this.tBoxTitle.Name = "tBoxTitle";
            this.tBoxTitle.Size = new System.Drawing.Size(301, 22);
            this.tBoxTitle.TabIndex = 3;
            // 
            // richTextDescription
            // 
            this.richTextDescription.Location = new System.Drawing.Point(452, 80);
            this.richTextDescription.MaxLength = 1000;
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.Size = new System.Drawing.Size(301, 96);
            this.richTextDescription.TabIndex = 4;
            this.richTextDescription.Text = "";
            // 
            // richTextIngrediens
            // 
            this.richTextIngrediens.Location = new System.Drawing.Point(452, 204);
            this.richTextIngrediens.MaxLength = 1000;
            this.richTextIngrediens.Name = "richTextIngrediens";
            this.richTextIngrediens.Size = new System.Drawing.Size(301, 96);
            this.richTextIngrediens.TabIndex = 5;
            this.richTextIngrediens.Text = "";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(452, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 17);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrediens";
            // 
            // lstBoxRecipe
            // 
            this.lstBoxRecipe.FormattingEnabled = true;
            this.lstBoxRecipe.ItemHeight = 16;
            this.lstBoxRecipe.Location = new System.Drawing.Point(39, 80);
            this.lstBoxRecipe.Name = "lstBoxRecipe";
            this.lstBoxRecipe.Size = new System.Drawing.Size(335, 228);
            this.lstBoxRecipe.TabIndex = 9;
            this.lstBoxRecipe.SelectedIndexChanged += new System.EventHandler(this.lstBoxRecipe_SelectedIndexChanged);
            // 
            // tBoxSearchField
            // 
            this.tBoxSearchField.Location = new System.Drawing.Point(172, 42);
            this.tBoxSearchField.Name = "tBoxSearchField";
            this.tBoxSearchField.Size = new System.Drawing.Size(106, 22);
            this.tBoxSearchField.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(299, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cBoxCategorys
            // 
            this.cBoxCategorys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCategorys.FormattingEnabled = true;
            this.cBoxCategorys.Location = new System.Drawing.Point(39, 42);
            this.cBoxCategorys.Name = "cBoxCategorys";
            this.cBoxCategorys.Size = new System.Drawing.Size(115, 24);
            this.cBoxCategorys.TabIndex = 12;
            // 
            // cBoxCategoriesNewAddDelete
            // 
            this.cBoxCategoriesNewAddDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCategoriesNewAddDelete.FormattingEnabled = true;
            this.cBoxCategoriesNewAddDelete.Location = new System.Drawing.Point(452, 328);
            this.cBoxCategoriesNewAddDelete.Name = "cBoxCategoriesNewAddDelete";
            this.cBoxCategoriesNewAddDelete.Size = new System.Drawing.Size(301, 24);
            this.cBoxCategoriesNewAddDelete.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kategori";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxCategoriesNewAddDelete);
            this.Controls.Add(this.cBoxCategorys);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tBoxSearchField);
            this.Controls.Add(this.lstBoxRecipe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.richTextIngrediens);
            this.Controls.Add(this.richTextDescription);
            this.Controls.Add(this.tBoxTitle);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.btnUpdateRecipe);
            this.Controls.Add(this.btnCreateNewRecipe);
            this.Name = "MainForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewRecipe;
        private System.Windows.Forms.Button btnUpdateRecipe;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.TextBox tBoxTitle;
        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.RichTextBox richTextIngrediens;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBoxRecipe;
        private System.Windows.Forms.TextBox tBoxSearchField;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cBoxCategorys;
        private System.Windows.Forms.ComboBox cBoxCategoriesNewAddDelete;
        private System.Windows.Forms.Label label1;
    }
}

