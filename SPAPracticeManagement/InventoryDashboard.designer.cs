namespace SPAPracticeManagement
{
    partial class InventoryDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryDashboard));
            this.lblLoginName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMyCalender = new System.Windows.Forms.Button();
            this.btnClientList = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnHomeIcon = new System.Windows.Forms.Button();
            this.varticalMenu1 = new SPAPracticeManagement.CustomControls.VarticalMenu();
            this.inventoryMenu1 = new SPAPracticeManagement.CustomControls.InventoryMenu();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginName
            // 
            this.lblLoginName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginName.ForeColor = System.Drawing.Color.White;
            this.lblLoginName.Location = new System.Drawing.Point(1645, 26);
            this.lblLoginName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(0, 23);
            this.lblLoginName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1552, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.inventoryMenu1);
            this.panel1.Controls.Add(this.lblLoginName);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1768, 101);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnMyCalender);
            this.panel3.Controls.Add(this.btnClientList);
            this.panel3.Controls.Add(this.btnClient);
            this.panel3.Controls.Add(this.btnHomeIcon);
            this.panel3.Location = new System.Drawing.Point(204, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1564, 62);
            this.panel3.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(94)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(1649, 59);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 32);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnMyCalender
            // 
            this.btnMyCalender.BackColor = System.Drawing.Color.Transparent;
            this.btnMyCalender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyCalender.FlatAppearance.BorderSize = 0;
            this.btnMyCalender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMyCalender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMyCalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyCalender.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyCalender.ForeColor = System.Drawing.Color.White;
            this.btnMyCalender.Image = ((System.Drawing.Image)(resources.GetObject("btnMyCalender.Image")));
            this.btnMyCalender.Location = new System.Drawing.Point(435, 7);
            this.btnMyCalender.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyCalender.Name = "btnMyCalender";
            this.btnMyCalender.Size = new System.Drawing.Size(71, 46);
            this.btnMyCalender.TabIndex = 24;
            this.btnMyCalender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyCalender.UseVisualStyleBackColor = false;
            // 
            // btnClientList
            // 
            this.btnClientList.BackColor = System.Drawing.Color.Transparent;
            this.btnClientList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientList.FlatAppearance.BorderSize = 0;
            this.btnClientList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClientList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClientList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientList.ForeColor = System.Drawing.Color.White;
            this.btnClientList.Image = ((System.Drawing.Image)(resources.GetObject("btnClientList.Image")));
            this.btnClientList.Location = new System.Drawing.Point(287, 2);
            this.btnClientList.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientList.Name = "btnClientList";
            this.btnClientList.Size = new System.Drawing.Size(85, 55);
            this.btnClientList.TabIndex = 23;
            this.btnClientList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientList.UseVisualStyleBackColor = false;
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Transparent;
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Image = ((System.Drawing.Image)(resources.GetObject("btnClient.Image")));
            this.btnClient.Location = new System.Drawing.Point(148, 5);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(83, 50);
            this.btnClient.TabIndex = 22;
            this.btnClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.UseVisualStyleBackColor = false;
            // 
            // btnHomeIcon
            // 
            this.btnHomeIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomeIcon.FlatAppearance.BorderSize = 0;
            this.btnHomeIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHomeIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHomeIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeIcon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeIcon.ForeColor = System.Drawing.Color.White;
            this.btnHomeIcon.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeIcon.Image")));
            this.btnHomeIcon.Location = new System.Drawing.Point(12, 2);
            this.btnHomeIcon.Margin = new System.Windows.Forms.Padding(4);
            this.btnHomeIcon.Name = "btnHomeIcon";
            this.btnHomeIcon.Size = new System.Drawing.Size(80, 53);
            this.btnHomeIcon.TabIndex = 21;
            this.btnHomeIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeIcon.UseVisualStyleBackColor = false;
            this.btnHomeIcon.Click += new System.EventHandler(this.btnHomeIcon_Click);
            // 
            // varticalMenu1
            // 
            this.varticalMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(94)))));
            this.varticalMenu1.Location = new System.Drawing.Point(0, 100);
            this.varticalMenu1.Name = "varticalMenu1";
            this.varticalMenu1.Size = new System.Drawing.Size(204, 825);
            this.varticalMenu1.TabIndex = 9;
            this.varticalMenu1.Load += new System.EventHandler(this.varticalMenu1_Load);
            // 
            // inventoryMenu1
            // 
            this.inventoryMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(94)))));
            this.inventoryMenu1.Location = new System.Drawing.Point(209, 47);
            this.inventoryMenu1.Name = "inventoryMenu1";
            this.inventoryMenu1.Size = new System.Drawing.Size(953, 49);
            this.inventoryMenu1.TabIndex = 22;
            // 
            // InventoryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 743);
            this.Controls.Add(this.varticalMenu1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "InventoryDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InventoryDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnMyCalender;
        private System.Windows.Forms.Button btnClientList;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnHomeIcon;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.InventoryMenu inventoryMenu1;
        private CustomControls.VarticalMenu varticalMenu1;
    }
}