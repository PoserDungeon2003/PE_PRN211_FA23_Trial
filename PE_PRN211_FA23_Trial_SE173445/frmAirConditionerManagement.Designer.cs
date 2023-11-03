namespace PE_PRN211_FA23_Trial_SE173445
{
    partial class frmAirConditionerManagement
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
            labelAirCnID = new Label();
            labelAirCNName = new Label();
            labelWarranty = new Label();
            labelSPL = new Label();
            labelFeatureFunction = new Label();
            labelQuantity = new Label();
            labelDolarPrice = new Label();
            labelSupplierID = new Label();
            txtAirConditionerName = new TextBox();
            txtWarranty = new TextBox();
            txtSoundPressureLevel = new TextBox();
            txtFeatureFunction = new TextBox();
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtAirConditionerID = new TextBox();
            txtDolarPrice = new TextBox();
            txtQuantity = new TextBox();
            groupBox1 = new GroupBox();
            cbSupplierID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelAirCnID
            // 
            labelAirCnID.AutoSize = true;
            labelAirCnID.Location = new Point(58, 76);
            labelAirCnID.Name = "labelAirCnID";
            labelAirCnID.Size = new Size(129, 20);
            labelAirCnID.TabIndex = 0;
            labelAirCnID.Text = "Air Conditioner ID";
            // 
            // labelAirCNName
            // 
            labelAirCNName.AutoSize = true;
            labelAirCNName.Location = new Point(58, 116);
            labelAirCNName.Name = "labelAirCNName";
            labelAirCNName.Size = new Size(154, 20);
            labelAirCNName.TabIndex = 1;
            labelAirCNName.Text = "Air Conditioner Name";
            // 
            // labelWarranty
            // 
            labelWarranty.AutoSize = true;
            labelWarranty.Location = new Point(58, 200);
            labelWarranty.Name = "labelWarranty";
            labelWarranty.Size = new Size(68, 20);
            labelWarranty.TabIndex = 2;
            labelWarranty.Text = "Warranty";
            // 
            // labelSPL
            // 
            labelSPL.AutoSize = true;
            labelSPL.Location = new Point(787, 69);
            labelSPL.Name = "labelSPL";
            labelSPL.Size = new Size(147, 20);
            labelSPL.TabIndex = 3;
            labelSPL.Text = "Sound Pressure Level";
            // 
            // labelFeatureFunction
            // 
            labelFeatureFunction.AutoSize = true;
            labelFeatureFunction.Location = new Point(787, 146);
            labelFeatureFunction.Name = "labelFeatureFunction";
            labelFeatureFunction.Size = new Size(118, 20);
            labelFeatureFunction.TabIndex = 4;
            labelFeatureFunction.Text = "Feature Function";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(61, 155);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(65, 20);
            labelQuantity.TabIndex = 5;
            labelQuantity.Text = "Quantity";
            // 
            // labelDolarPrice
            // 
            labelDolarPrice.AutoSize = true;
            labelDolarPrice.Location = new Point(787, 109);
            labelDolarPrice.Name = "labelDolarPrice";
            labelDolarPrice.Size = new Size(82, 20);
            labelDolarPrice.TabIndex = 6;
            labelDolarPrice.Text = "Dolar Price";
            // 
            // labelSupplierID
            // 
            labelSupplierID.AutoSize = true;
            labelSupplierID.Location = new Point(786, 193);
            labelSupplierID.Name = "labelSupplierID";
            labelSupplierID.Size = new Size(108, 20);
            labelSupplierID.TabIndex = 7;
            labelSupplierID.Text = "Supplier Name";
            // 
            // txtAirConditionerName
            // 
            txtAirConditionerName.Location = new Point(219, 109);
            txtAirConditionerName.Name = "txtAirConditionerName";
            txtAirConditionerName.Size = new Size(303, 27);
            txtAirConditionerName.TabIndex = 8;
            // 
            // txtWarranty
            // 
            txtWarranty.Location = new Point(219, 193);
            txtWarranty.Name = "txtWarranty";
            txtWarranty.Size = new Size(303, 27);
            txtWarranty.TabIndex = 8;
            // 
            // txtSoundPressureLevel
            // 
            txtSoundPressureLevel.Location = new Point(949, 62);
            txtSoundPressureLevel.Name = "txtSoundPressureLevel";
            txtSoundPressureLevel.Size = new Size(303, 27);
            txtSoundPressureLevel.TabIndex = 8;
            // 
            // txtFeatureFunction
            // 
            txtFeatureFunction.Location = new Point(949, 143);
            txtFeatureFunction.Name = "txtFeatureFunction";
            txtFeatureFunction.Size = new Size(303, 27);
            txtFeatureFunction.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(58, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1194, 235);
            dataGridView1.TabIndex = 9;
            dataGridView1.SelectionChanged += ViewProduct;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(188, 26);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(370, 26);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(567, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(736, 26);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(58, 239);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(308, 27);
            txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(382, 239);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtAirConditionerID
            // 
            txtAirConditionerID.Location = new Point(219, 69);
            txtAirConditionerID.Name = "txtAirConditionerID";
            txtAirConditionerID.Size = new Size(303, 27);
            txtAirConditionerID.TabIndex = 8;
            // 
            // txtDolarPrice
            // 
            txtDolarPrice.Location = new Point(949, 102);
            txtDolarPrice.Name = "txtDolarPrice";
            txtDolarPrice.Size = new Size(303, 27);
            txtDolarPrice.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(219, 148);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(303, 27);
            txtQuantity.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Location = new Point(138, 513);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1088, 125);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // cbSupplierID
            // 
            cbSupplierID.FormattingEnabled = true;
            cbSupplierID.Location = new Point(949, 192);
            cbSupplierID.Name = "cbSupplierID";
            cbSupplierID.Size = new Size(303, 28);
            cbSupplierID.TabIndex = 19;
            // 
            // frmAirConditionerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 727);
            Controls.Add(cbSupplierID);
            Controls.Add(groupBox1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(txtDolarPrice);
            Controls.Add(txtSoundPressureLevel);
            Controls.Add(txtFeatureFunction);
            Controls.Add(txtWarranty);
            Controls.Add(txtAirConditionerID);
            Controls.Add(txtQuantity);
            Controls.Add(txtAirConditionerName);
            Controls.Add(labelSupplierID);
            Controls.Add(labelDolarPrice);
            Controls.Add(labelQuantity);
            Controls.Add(labelFeatureFunction);
            Controls.Add(labelSPL);
            Controls.Add(labelWarranty);
            Controls.Add(labelAirCNName);
            Controls.Add(labelAirCnID);
            Name = "frmAirConditionerManagement";
            Text = "frmAirConditionerManagement";
            Load += frmAirConditionerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAirCnID;
        private Label labelAirCNName;
        private Label labelWarranty;
        private Label labelSPL;
        private Label labelFeatureFunction;
        private Label labelQuantity;
        private Label labelDolarPrice;
        private Label labelSupplierID;
        private TextBox txtAirConditionerName;
        private TextBox txtWarranty;
        private TextBox txtSoundPressureLevel;
        private TextBox txtFeatureFunction;
        private DataGridView dataGridView1;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtAirConditionerID;
        private TextBox txtDolarPrice;
        private TextBox txtQuantity;
        private GroupBox groupBox1;
        private ComboBox cbSupplierID;
    }
}