namespace BarcodeScannerV1
{
    partial class Form1
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
            this.textCameraLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChoiceCamera = new System.Windows.Forms.ComboBox();
            this.CameraView = new System.Windows.Forms.PictureBox();
            this.textBarcode = new System.Windows.Forms.TextBox();
            this.StartScanBarCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CameraView)).BeginInit();
            this.SuspendLayout();
            // 
            // textCameraLabel
            // 
            this.textCameraLabel.AutoSize = true;
            this.textCameraLabel.Location = new System.Drawing.Point(24, 12);
            this.textCameraLabel.Name = "textCameraLabel";
            this.textCameraLabel.Size = new System.Drawing.Size(52, 13);
            this.textCameraLabel.TabIndex = 0;
            this.textCameraLabel.Text = "Camera ::";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barcode >";
            // 
            // ChoiceCamera
            // 
            this.ChoiceCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoiceCamera.FormattingEnabled = true;
            this.ChoiceCamera.Location = new System.Drawing.Point(78, 12);
            this.ChoiceCamera.Name = "ChoiceCamera";
            this.ChoiceCamera.Size = new System.Drawing.Size(187, 21);
            this.ChoiceCamera.TabIndex = 2;
            // 
            // CameraView
            // 
            this.CameraView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CameraView.Location = new System.Drawing.Point(78, 49);
            this.CameraView.Name = "CameraView";
            this.CameraView.Size = new System.Drawing.Size(342, 185);
            this.CameraView.TabIndex = 3;
            this.CameraView.TabStop = false;
            // 
            // textBarcode
            // 
            this.textBarcode.Location = new System.Drawing.Point(78, 240);
            this.textBarcode.Name = "textBarcode";
            this.textBarcode.Size = new System.Drawing.Size(261, 20);
            this.textBarcode.TabIndex = 4;
            // 
            // StartScanBarCode
            // 
            this.StartScanBarCode.Location = new System.Drawing.Point(345, 238);
            this.StartScanBarCode.Name = "StartScanBarCode";
            this.StartScanBarCode.Size = new System.Drawing.Size(75, 23);
            this.StartScanBarCode.TabIndex = 5;
            this.StartScanBarCode.Text = "Start";
            this.StartScanBarCode.UseVisualStyleBackColor = true;
            this.StartScanBarCode.Click += new System.EventHandler(this.StartScanBarCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 284);
            this.Controls.Add(this.StartScanBarCode);
            this.Controls.Add(this.textBarcode);
            this.Controls.Add(this.CameraView);
            this.Controls.Add(this.ChoiceCamera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCameraLabel);
            this.Name = "Form1";
            this.Text = "ScannerIndustry Indev Version";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CameraView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textCameraLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ChoiceCamera;
        private System.Windows.Forms.PictureBox CameraView;
        private System.Windows.Forms.TextBox textBarcode;
        private System.Windows.Forms.Button StartScanBarCode;
    }
}

