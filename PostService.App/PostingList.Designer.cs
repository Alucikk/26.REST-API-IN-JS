namespace PostService.App
{
    partial class PostingList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridPostings = new DataGridView();
            ClId = new DataGridViewTextBoxColumn();
            ClFrom = new DataGridViewTextBoxColumn();
            ClTo = new DataGridViewTextBoxColumn();
            clCont = new DataGridViewTextBoxColumn();
            clDelTyp = new DataGridViewTextBoxColumn();
            clWeigh = new DataGridViewTextBoxColumn();
            clWid = new DataGridViewTextBoxColumn();
            clHeig = new DataGridViewTextBoxColumn();
            clDep = new DataGridViewTextBoxColumn();
            clVal = new DataGridViewTextBoxColumn();
            clPr = new DataGridViewTextBoxColumn();
            clCrtAt = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)gridPostings).BeginInit();
            SuspendLayout();
            // 
            // gridPostings
            // 
            gridPostings.AllowUserToAddRows = false;
            gridPostings.AllowUserToDeleteRows = false;
            gridPostings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridPostings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPostings.Columns.AddRange(new DataGridViewColumn[] { ClId, ClFrom, ClTo, clCont, clDelTyp, clWeigh, clWid, clHeig, clDep, clVal, clPr, clCrtAt });
            gridPostings.Location = new Point(12, 85);
            gridPostings.MultiSelect = false;
            gridPostings.Name = "gridPostings";
            gridPostings.ReadOnly = true;
            gridPostings.RowHeadersWidth = 62;
            gridPostings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPostings.Size = new Size(1564, 353);
            gridPostings.TabIndex = 0;
            // 
            // ClId
            // 
            ClId.DataPropertyName = "Id";
            ClId.HeaderText = "ID";
            ClId.MinimumWidth = 8;
            ClId.Name = "ClId";
            ClId.ReadOnly = true;
            ClId.Visible = false;
            ClId.Width = 150;
            // 
            // ClFrom
            // 
            ClFrom.DataPropertyName = "From";
            ClFrom.HeaderText = "Відправник";
            ClFrom.MinimumWidth = 8;
            ClFrom.Name = "ClFrom";
            ClFrom.ReadOnly = true;
            ClFrom.Width = 150;
            // 
            // ClTo
            // 
            ClTo.DataPropertyName = "To";
            ClTo.HeaderText = "Отримувач";
            ClTo.MinimumWidth = 8;
            ClTo.Name = "ClTo";
            ClTo.ReadOnly = true;
            ClTo.Width = 150;
            // 
            // clCont
            // 
            clCont.DataPropertyName = "Content";
            clCont.HeaderText = "Вміст";
            clCont.MinimumWidth = 8;
            clCont.Name = "clCont";
            clCont.ReadOnly = true;
            clCont.Width = 150;
            // 
            // clDelTyp
            // 
            clDelTyp.DataPropertyName = "DeliveryType";
            clDelTyp.HeaderText = "Тип доставки";
            clDelTyp.MinimumWidth = 8;
            clDelTyp.Name = "clDelTyp";
            clDelTyp.ReadOnly = true;
            clDelTyp.Width = 150;
            // 
            // clWeigh
            // 
            clWeigh.DataPropertyName = "Weight";
            clWeigh.HeaderText = "Вага";
            clWeigh.MinimumWidth = 8;
            clWeigh.Name = "clWeigh";
            clWeigh.ReadOnly = true;
            clWeigh.Width = 150;
            // 
            // clWid
            // 
            clWid.DataPropertyName = "Width";
            clWid.HeaderText = "Ширина";
            clWid.MinimumWidth = 8;
            clWid.Name = "clWid";
            clWid.ReadOnly = true;
            clWid.Width = 150;
            // 
            // clHeig
            // 
            clHeig.DataPropertyName = "Height";
            clHeig.HeaderText = "Висота";
            clHeig.MinimumWidth = 8;
            clHeig.Name = "clHeig";
            clHeig.ReadOnly = true;
            clHeig.Width = 150;
            // 
            // clDep
            // 
            clDep.DataPropertyName = "Depth";
            clDep.HeaderText = "Глибина";
            clDep.MinimumWidth = 8;
            clDep.Name = "clDep";
            clDep.ReadOnly = true;
            clDep.Width = 150;
            // 
            // clVal
            // 
            clVal.DataPropertyName = "Value";
            clVal.HeaderText = "Значення";
            clVal.MinimumWidth = 8;
            clVal.Name = "clVal";
            clVal.ReadOnly = true;
            clVal.Width = 150;
            // 
            // clPr
            // 
            clPr.DataPropertyName = "Price";
            clPr.HeaderText = "Ціна";
            clPr.MinimumWidth = 8;
            clPr.Name = "clPr";
            clPr.ReadOnly = true;
            clPr.Width = 150;
            // 
            // clCrtAt
            // 
            clCrtAt.DataPropertyName = "CreatedAt";
            clCrtAt.HeaderText = "Створення";
            clCrtAt.MinimumWidth = 8;
            clCrtAt.Name = "clCrtAt";
            clCrtAt.ReadOnly = true;
            clCrtAt.Visible = false;
            clCrtAt.Width = 150;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.MediumOrchid;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic);
            btnDelete.Location = new Point(13, 24);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 37);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.BackColor = Color.MediumOrchid;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic);
            btnRefresh.Location = new Point(1436, 24);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 37);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Оновити";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // PostingList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1588, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(gridPostings);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PostingList";
            Text = "PostingList";
            Load += PostingList_Load;
            ((System.ComponentModel.ISupportInitialize)gridPostings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridPostings;
        private Button btnDelete;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn ClId;
        private DataGridViewTextBoxColumn ClFrom;
        private DataGridViewTextBoxColumn ClTo;
        private DataGridViewTextBoxColumn clCont;
        private DataGridViewTextBoxColumn clDelTyp;
        private DataGridViewTextBoxColumn clWeigh;
        private DataGridViewTextBoxColumn clWid;
        private DataGridViewTextBoxColumn clHeig;
        private DataGridViewTextBoxColumn clDep;
        private DataGridViewTextBoxColumn clVal;
        private DataGridViewTextBoxColumn clPr;
        private DataGridViewTextBoxColumn clCrtAt;
    }
}
