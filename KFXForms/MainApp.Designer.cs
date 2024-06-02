namespace KFXForms
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.DBVievGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LabelLogin = new DevExpress.XtraEditors.LabelControl();
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.labelExpiryDate = new DevExpress.XtraEditors.LabelControl();
            this.labelActivateDeactivate = new DevExpress.XtraEditors.LabelControl();
            this.labelHost = new DevExpress.XtraEditors.LabelControl();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.txtHost = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtExpiryDate = new DevExpress.XtraEditors.DateEdit();
            this.boolActivate = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DBVievGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpiryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpiryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boolActivate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // DBVievGrid
            // 
            this.DBVievGrid.Location = new System.Drawing.Point(21, 199);
            this.DBVievGrid.MainView = this.gridView1;
            this.DBVievGrid.Name = "DBVievGrid";
            this.DBVievGrid.Size = new System.Drawing.Size(1024, 399);
            this.DBVievGrid.TabIndex = 0;
            this.DBVievGrid.UseEmbeddedNavigator = true;
            this.DBVievGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.DBVievGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Login";
            this.gridColumn1.FieldName = "Login";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 177;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Password";
            this.gridColumn2.FieldName = "Password";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 245;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Expiry Date";
            this.gridColumn3.FieldName = "ExpiryDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 154;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Activate";
            this.gridColumn4.FieldName = "Activate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Online";
            this.gridColumn5.FieldName = "Online";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Host";
            this.gridColumn6.FieldName = "Host";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 272;
            // 
            // LabelLogin
            // 
            this.LabelLogin.Location = new System.Drawing.Point(52, 27);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(29, 13);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Login:";
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(31, 60);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(50, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            // 
            // labelExpiryDate
            // 
            this.labelExpiryDate.Location = new System.Drawing.Point(21, 92);
            this.labelExpiryDate.Name = "labelExpiryDate";
            this.labelExpiryDate.Size = new System.Drawing.Size(60, 13);
            this.labelExpiryDate.TabIndex = 3;
            this.labelExpiryDate.Text = "Expiry Date:";
            // 
            // labelActivateDeactivate
            // 
            this.labelActivateDeactivate.Location = new System.Drawing.Point(525, 63);
            this.labelActivateDeactivate.Name = "labelActivateDeactivate";
            this.labelActivateDeactivate.Size = new System.Drawing.Size(102, 13);
            this.labelActivateDeactivate.TabIndex = 4;
            this.labelActivateDeactivate.Text = "Activate / Deactivate";
            // 
            // labelHost
            // 
            this.labelHost.Location = new System.Drawing.Point(601, 27);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(26, 13);
            this.labelHost.TabIndex = 6;
            this.labelHost.Text = "Host:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(100, 24);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(318, 20);
            this.txtLogin.TabIndex = 7;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(646, 24);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(357, 20);
            this.txtHost.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(318, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.EditValue = null;
            this.txtExpiryDate.Location = new System.Drawing.Point(100, 92);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtExpiryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtExpiryDate.Size = new System.Drawing.Size(318, 20);
            this.txtExpiryDate.TabIndex = 12;
            // 
            // boolActivate
            // 
            this.boolActivate.Location = new System.Drawing.Point(646, 61);
            this.boolActivate.Name = "boolActivate";
            this.boolActivate.Properties.OffText = "Off";
            this.boolActivate.Properties.OnText = "On";
            this.boolActivate.Size = new System.Drawing.Size(95, 18);
            this.boolActivate.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(343, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 32);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(181, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(262, 136);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(100, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 620);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.boolActivate);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.labelActivateDeactivate);
            this.Controls.Add(this.labelExpiryDate);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.DBVievGrid);
            this.Name = "MainApp";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KFX Account Menager";
            this.Load += new System.EventHandler(this.MainApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBVievGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpiryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpiryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boolActivate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl DBVievGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl LabelLogin;
        private DevExpress.XtraEditors.LabelControl labelPassword;
        private DevExpress.XtraEditors.LabelControl labelExpiryDate;
        private DevExpress.XtraEditors.LabelControl labelActivateDeactivate;
        private DevExpress.XtraEditors.LabelControl labelHost;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.TextEdit txtHost;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.DateEdit txtExpiryDate;
        private DevExpress.XtraEditors.ToggleSwitch boolActivate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}

