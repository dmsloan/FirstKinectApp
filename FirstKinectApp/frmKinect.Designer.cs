namespace FirstKinectApp
{
    partial class frmKinect
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
            this.btnStream = new System.Windows.Forms.Button();
            this.lblTextStatus = new System.Windows.Forms.Label();
            this.lblTextConnectionID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblConnectionID = new System.Windows.Forms.Label();
            this.KinectStream = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.KinectStream)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStream
            // 
            this.btnStream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStream.Location = new System.Drawing.Point(573, 578);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(88, 25);
            this.btnStream.TabIndex = 0;
            this.btnStream.Text = "Stream";
            this.btnStream.UseVisualStyleBackColor = true;
            this.btnStream.Click += new System.EventHandler(this.btnStream_Click);
            // 
            // lblTextStatus
            // 
            this.lblTextStatus.AutoSize = true;
            this.lblTextStatus.Location = new System.Drawing.Point(12, 9);
            this.lblTextStatus.Name = "lblTextStatus";
            this.lblTextStatus.Size = new System.Drawing.Size(40, 13);
            this.lblTextStatus.TabIndex = 1;
            this.lblTextStatus.Text = "Status:";
            // 
            // lblTextConnectionID
            // 
            this.lblTextConnectionID.AutoSize = true;
            this.lblTextConnectionID.Location = new System.Drawing.Point(14, 54);
            this.lblTextConnectionID.Name = "lblTextConnectionID";
            this.lblTextConnectionID.Size = new System.Drawing.Size(78, 13);
            this.lblTextConnectionID.TabIndex = 2;
            this.lblTextConnectionID.Text = "Connection ID:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(93, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "-";
            // 
            // lblConnectionID
            // 
            this.lblConnectionID.AutoSize = true;
            this.lblConnectionID.Location = new System.Drawing.Point(93, 54);
            this.lblConnectionID.Name = "lblConnectionID";
            this.lblConnectionID.Size = new System.Drawing.Size(10, 13);
            this.lblConnectionID.TabIndex = 4;
            this.lblConnectionID.Text = "-";
            // 
            // KinectStream
            // 
            this.KinectStream.Location = new System.Drawing.Point(17, 70);
            this.KinectStream.Name = "KinectStream";
            this.KinectStream.Size = new System.Drawing.Size(640, 480);
            this.KinectStream.TabIndex = 5;
            this.KinectStream.TabStop = false;
            // 
            // frmKinect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 615);
            this.Controls.Add(this.KinectStream);
            this.Controls.Add(this.lblConnectionID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTextConnectionID);
            this.Controls.Add(this.lblTextStatus);
            this.Controls.Add(this.btnStream);
            this.Name = "frmKinect";
            this.Text = "Kinect";
            ((System.ComponentModel.ISupportInitialize)(this.KinectStream)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.Label lblTextStatus;
        private System.Windows.Forms.Label lblTextConnectionID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblConnectionID;
        private System.Windows.Forms.PictureBox KinectStream;
    }
}

