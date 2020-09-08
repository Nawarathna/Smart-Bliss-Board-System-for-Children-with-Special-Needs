namespace sampleframe.cs
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStudent = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTutor = new Bunifu.Framework.UI.BunifuTileButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(490, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 46);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Are you a?";
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.Navy;
            this.btnStudent.color = System.Drawing.Color.Navy;
            this.btnStudent.colorActive = System.Drawing.Color.CornflowerBlue;
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.ImagePosition = 20;
            this.btnStudent.ImageZoom = 50;
            this.btnStudent.LabelPosition = 41;
            this.btnStudent.LabelText = "Student";
            this.btnStudent.Location = new System.Drawing.Point(350, 134);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(6);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(128, 129);
            this.btnStudent.TabIndex = 41;
            this.btnStudent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnTutor
            // 
            this.btnTutor.BackColor = System.Drawing.Color.Navy;
            this.btnTutor.color = System.Drawing.Color.Navy;
            this.btnTutor.colorActive = System.Drawing.Color.CornflowerBlue;
            this.btnTutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTutor.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnTutor.ForeColor = System.Drawing.Color.White;
            this.btnTutor.Image = ((System.Drawing.Image)(resources.GetObject("btnTutor.Image")));
            this.btnTutor.ImagePosition = 20;
            this.btnTutor.ImageZoom = 50;
            this.btnTutor.LabelPosition = 41;
            this.btnTutor.LabelText = "Tutor";
            this.btnTutor.Location = new System.Drawing.Point(704, 134);
            this.btnTutor.Margin = new System.Windows.Forms.Padding(6);
            this.btnTutor.Name = "btnTutor";
            this.btnTutor.Size = new System.Drawing.Size(128, 129);
            this.btnTutor.TabIndex = 42;
            this.btnTutor.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogo.Image = global::sampleframe.cs.Properties.Resources.download;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 22);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(235, 126);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 27;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Image = global::sampleframe.cs.Properties.Resources.download__2_;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(12, 166);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(235, 248);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 26;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 454);
            this.ControlBox = false;
            this.Controls.Add(this.btnTutor);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FirstForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bliss Smart Login";
            this.Load += new System.EventHandler(this.app1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuTileButton btnStudent;
        private Bunifu.Framework.UI.BunifuTileButton btnTutor;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;

    }
}

