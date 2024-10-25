namespace UE2_FlyingPanels
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pan = new System.Windows.Forms.Panel();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.chkRun = new System.Windows.Forms.CheckBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.trkSpeed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.BackColor = System.Drawing.Color.Cyan;
            this.pan.Location = new System.Drawing.Point(362, 193);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(20, 20);
            this.pan.TabIndex = 0;
            // 
            // tmr
            // 
            this.tmr.Interval = 40;
            this.tmr.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkRun
            // 
            this.chkRun.AutoSize = true;
            this.chkRun.Location = new System.Drawing.Point(12, 12);
            this.chkRun.Name = "chkRun";
            this.chkRun.Size = new System.Drawing.Size(56, 24);
            this.chkRun.TabIndex = 1;
            this.chkRun.Text = "Run";
            this.chkRun.UseVisualStyleBackColor = true;
            this.chkRun.CheckedChanged += new System.EventHandler(this.chkRun_CheckedChanged);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(12, 39);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(16, 20);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "?";
            // 
            // trkSpeed
            // 
            this.trkSpeed.Location = new System.Drawing.Point(74, 12);
            this.trkSpeed.Maximum = 30;
            this.trkSpeed.Minimum = 1;
            this.trkSpeed.Name = "trkSpeed";
            this.trkSpeed.Size = new System.Drawing.Size(178, 56);
            this.trkSpeed.TabIndex = 3;
            this.trkSpeed.Value = 1;
            this.trkSpeed.Scroll += new System.EventHandler(this.trkSpeed_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trkSpeed);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.chkRun);
            this.Controls.Add(this.pan);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pan;
        private System.Windows.Forms.Timer tmr;
        private CheckBox chkRun;
        private Label lblPosition;
        private TrackBar trkSpeed;
    }
}