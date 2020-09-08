namespace sampleframe.cs
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserS = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPwS = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnlogSt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogo.Image = global::sampleframe.cs.Properties.Resources.download;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 28);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(235, 106);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 66;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Image = global::sampleframe.cs.Properties.Resources.download__2_;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(12, 140);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(235, 159);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 65;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(626, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 46);
            this.lblTitle.TabIndex = 45;
            this.lblTitle.Text = "Login";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.Transparent;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUserType.Location = new System.Drawing.Point(372, 119);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(149, 31);
            this.lblUserType.TabIndex = 46;
            this.lblUserType.Text = "User Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(410, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(410, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Password";
            // 
            // txtUserS
            // 
            this.txtUserS.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtUserS.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtUserS.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtUserS.BorderThickness = 3;
            this.txtUserS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserS.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserS.isPassword = false;
            this.txtUserS.Location = new System.Drawing.Point(514, 177);
            this.txtUserS.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserS.Name = "txtUserS";
            this.txtUserS.Size = new System.Drawing.Size(370, 44);
            this.txtUserS.TabIndex = 59;
            this.txtUserS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPwS
            // 
            this.txtPwS.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtPwS.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtPwS.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtPwS.BorderThickness = 3;
            this.txtPwS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPwS.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPwS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPwS.isPassword = true;
            this.txtPwS.Location = new System.Drawing.Point(514, 251);
            this.txtPwS.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwS.Name = "txtPwS";
            this.txtPwS.Size = new System.Drawing.Size(370, 44);
            this.txtPwS.TabIndex = 60;
            this.txtPwS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnlogSt
            // 
            this.btnlogSt.ActiveBorderThickness = 1;
            this.btnlogSt.ActiveCornerRadius = 20;
            this.btnlogSt.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnlogSt.ActiveForecolor = System.Drawing.Color.White;
            this.btnlogSt.ActiveLineColor = System.Drawing.Color.FloralWhite;
            this.btnlogSt.BackColor = System.Drawing.SystemColors.Control;
            this.btnlogSt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogSt.BackgroundImage")));
            this.btnlogSt.ButtonText = "Login";
            this.btnlogSt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogSt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogSt.ForeColor = System.Drawing.Color.Navy;
            this.btnlogSt.IdleBorderThickness = 1;
            this.btnlogSt.IdleCornerRadius = 20;
            this.btnlogSt.IdleFillColor = System.Drawing.Color.White;
            this.btnlogSt.IdleForecolor = System.Drawing.Color.Navy;
            this.btnlogSt.IdleLineColor = System.Drawing.Color.Navy;
            this.btnlogSt.Location = new System.Drawing.Point(601, 304);
            this.btnlogSt.Margin = new System.Windows.Forms.Padding(5);
            this.btnlogSt.Name = "btnlogSt";
            this.btnlogSt.Size = new System.Drawing.Size(181, 41);
            this.btnlogSt.TabIndex = 61;
            this.btnlogSt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlogSt.Click += new System.EventHandler(this.btnlogSt_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Firebrick;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.ErrorImage = null;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.InitialImage = null;
            this.BtnClose.Location = new System.Drawing.Point(948, 13);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(29, 27);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 67;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 15;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 454);
            this.ControlBox = false;
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.btnlogSt);
            this.Controls.Add(this.txtPwS);
            this.Controls.Add(this.txtUserS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUserS;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPwS;
        private Bunifu.Framework.UI.BunifuThinButton2 btnlogSt;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        
        
    }
}