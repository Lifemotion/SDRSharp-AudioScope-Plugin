namespace SDRSharp.AudioScope
{
    partial class ControlPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enableCheckBox = new System.Windows.Forms.CheckBox();
            this.rollCheckbox = new System.Windows.Forms.CheckBox();
            this.speed = new System.Windows.Forms.TrackBar();
            this.amplitude = new System.Windows.Forms.TrackBar();
            this.cbRun = new System.Windows.Forms.CheckBox();
            this.cbLog = new System.Windows.Forms.CheckBox();
            this.cbUnsigned = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitude)).BeginInit();
            this.SuspendLayout();
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.Checked = true;
            this.enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCheckBox.Location = new System.Drawing.Point(3, 8);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.Size = new System.Drawing.Size(59, 17);
            this.enableCheckBox.TabIndex = 1;
            this.enableCheckBox.Text = "Enable";
            this.enableCheckBox.UseVisualStyleBackColor = true;
            this.enableCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxesChanged);
            // 
            // rollCheckbox
            // 
            this.rollCheckbox.Location = new System.Drawing.Point(141, 8);
            this.rollCheckbox.Name = "rollCheckbox";
            this.rollCheckbox.Size = new System.Drawing.Size(59, 17);
            this.rollCheckbox.TabIndex = 2;
            this.rollCheckbox.Text = "Roll";
            this.rollCheckbox.UseVisualStyleBackColor = true;
            this.rollCheckbox.CheckedChanged += new System.EventHandler(this.checkBoxesChanged);
            // 
            // speed
            // 
            this.speed.LargeChange = 100;
            this.speed.Location = new System.Drawing.Point(0, 62);
            this.speed.Maximum = 2000;
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(201, 45);
            this.speed.SmallChange = 50;
            this.speed.TabIndex = 3;
            this.speed.TickFrequency = 100;
            this.speed.Value = 500;
            this.speed.ValueChanged += new System.EventHandler(this.checkBoxesChanged);
            // 
            // amplitude
            // 
            this.amplitude.LargeChange = 100;
            this.amplitude.Location = new System.Drawing.Point(3, 99);
            this.amplitude.Maximum = 100;
            this.amplitude.Minimum = 1;
            this.amplitude.Name = "amplitude";
            this.amplitude.Size = new System.Drawing.Size(201, 45);
            this.amplitude.SmallChange = 50;
            this.amplitude.TabIndex = 4;
            this.amplitude.TickFrequency = 100;
            this.amplitude.Value = 5;
            this.amplitude.ValueChanged += new System.EventHandler(this.checkBoxesChanged);
            // 
            // cbRun
            // 
            this.cbRun.Location = new System.Drawing.Point(72, 8);
            this.cbRun.Name = "cbRun";
            this.cbRun.Size = new System.Drawing.Size(59, 17);
            this.cbRun.TabIndex = 5;
            this.cbRun.Text = "Run";
            this.cbRun.UseVisualStyleBackColor = true;
            this.cbRun.CheckedChanged += new System.EventHandler(this.checkBoxesChanged);
            // 
            // cbLog
            // 
            this.cbLog.Location = new System.Drawing.Point(3, 31);
            this.cbLog.Name = "cbLog";
            this.cbLog.Size = new System.Drawing.Size(59, 17);
            this.cbLog.TabIndex = 6;
            this.cbLog.Text = "Log";
            this.cbLog.UseVisualStyleBackColor = true;
            this.cbLog.CheckedChanged += new System.EventHandler(this.checkBoxesChanged);
            // 
            // cbUnsigned
            // 
            this.cbUnsigned.Checked = true;
            this.cbUnsigned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUnsigned.Location = new System.Drawing.Point(72, 31);
            this.cbUnsigned.Name = "cbUnsigned";
            this.cbUnsigned.Size = new System.Drawing.Size(87, 17);
            this.cbUnsigned.TabIndex = 7;
            this.cbUnsigned.Text = "Unsigned";
            this.cbUnsigned.UseVisualStyleBackColor = true;
            this.cbUnsigned.CheckedChanged += new System.EventHandler(this.checkBoxesChanged);
            // 
            // ControlPanel
            // 
            this.Controls.Add(this.cbUnsigned);
            this.Controls.Add(this.cbLog);
            this.Controls.Add(this.cbRun);
            this.Controls.Add(this.amplitude);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.rollCheckbox);
            this.Controls.Add(this.enableCheckBox);
            this.Name = "ControlPanel";
            this.Size = new System.Drawing.Size(204, 157);
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox enableCheckBox;
        private System.Windows.Forms.CheckBox rollCheckbox;
        private System.Windows.Forms.TrackBar speed;
        private System.Windows.Forms.TrackBar amplitude;
        private System.Windows.Forms.CheckBox cbRun;
        private System.Windows.Forms.CheckBox cbLog;
        private System.Windows.Forms.CheckBox cbUnsigned;




    }
}
