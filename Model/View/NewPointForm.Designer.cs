
namespace View
{
    partial class NewPointForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OcillatoryGroupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ParametrNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CenterYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CenterXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AcceleratedGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AccelerationYNumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.AccelerationXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LinearGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SpeedYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpeedXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.XNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.OcillatoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParametrNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterXNumericUpDown)).BeginInit();
            this.AcceleratedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationYNumericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationXNumericUpDown)).BeginInit();
            this.LinearGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OcillatoryGroupBox);
            this.groupBox1.Controls.Add(this.AcceleratedGroupBox);
            this.groupBox1.Controls.Add(this.LinearGroupBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.YNumericUpDown);
            this.groupBox1.Controls.Add(this.XNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Numders to Set Point Coord";
            // 
            // OcillatoryGroupBox
            // 
            this.OcillatoryGroupBox.Controls.Add(this.label10);
            this.OcillatoryGroupBox.Controls.Add(this.ParametrNumericUpDown);
            this.OcillatoryGroupBox.Controls.Add(this.label8);
            this.OcillatoryGroupBox.Controls.Add(this.label9);
            this.OcillatoryGroupBox.Controls.Add(this.CenterYNumericUpDown);
            this.OcillatoryGroupBox.Controls.Add(this.CenterXNumericUpDown);
            this.OcillatoryGroupBox.Location = new System.Drawing.Point(14, 301);
            this.OcillatoryGroupBox.Name = "OcillatoryGroupBox";
            this.OcillatoryGroupBox.Size = new System.Drawing.Size(330, 89);
            this.OcillatoryGroupBox.TabIndex = 7;
            this.OcillatoryGroupBox.TabStop = false;
            this.OcillatoryGroupBox.Text = "Input Ocillatory Center and Parametr";
            this.OcillatoryGroupBox.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Parameter";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ParametrNumericUpDown
            // 
            this.ParametrNumericUpDown.Location = new System.Drawing.Point(100, 51);
            this.ParametrNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ParametrNumericUpDown.Name = "ParametrNumericUpDown";
            this.ParametrNumericUpDown.Size = new System.Drawing.Size(89, 23);
            this.ParametrNumericUpDown.TabIndex = 16;
            this.ParametrNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ParametrNumericUpDown.ValueChanged += new System.EventHandler(this.XNumericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "X";
            // 
            // CenterYNumericUpDown
            // 
            this.CenterYNumericUpDown.Location = new System.Drawing.Point(186, 22);
            this.CenterYNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CenterYNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.CenterYNumericUpDown.Name = "CenterYNumericUpDown";
            this.CenterYNumericUpDown.Size = new System.Drawing.Size(85, 23);
            this.CenterYNumericUpDown.TabIndex = 13;
            this.CenterYNumericUpDown.ValueChanged += new System.EventHandler(this.XNumericUpDown_ValueChanged);
            // 
            // CenterXNumericUpDown
            // 
            this.CenterXNumericUpDown.Location = new System.Drawing.Point(37, 22);
            this.CenterXNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CenterXNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.CenterXNumericUpDown.Name = "CenterXNumericUpDown";
            this.CenterXNumericUpDown.Size = new System.Drawing.Size(89, 23);
            this.CenterXNumericUpDown.TabIndex = 12;
            this.CenterXNumericUpDown.ValueChanged += new System.EventHandler(this.XNumericUpDown_ValueChanged);
            // 
            // AcceleratedGroupBox
            // 
            this.AcceleratedGroupBox.Controls.Add(this.label6);
            this.AcceleratedGroupBox.Controls.Add(this.label7);
            this.AcceleratedGroupBox.Controls.Add(this.AccelerationYNumericUpDown3);
            this.AcceleratedGroupBox.Controls.Add(this.AccelerationXNumericUpDown);
            this.AcceleratedGroupBox.Location = new System.Drawing.Point(14, 207);
            this.AcceleratedGroupBox.Name = "AcceleratedGroupBox";
            this.AcceleratedGroupBox.Size = new System.Drawing.Size(330, 89);
            this.AcceleratedGroupBox.TabIndex = 7;
            this.AcceleratedGroupBox.TabStop = false;
            this.AcceleratedGroupBox.Text = "Input Acceleration";
            this.AcceleratedGroupBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "X";
            // 
            // AccelerationYNumericUpDown3
            // 
            this.AccelerationYNumericUpDown3.Location = new System.Drawing.Point(186, 22);
            this.AccelerationYNumericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AccelerationYNumericUpDown3.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.AccelerationYNumericUpDown3.Name = "AccelerationYNumericUpDown3";
            this.AccelerationYNumericUpDown3.Size = new System.Drawing.Size(85, 23);
            this.AccelerationYNumericUpDown3.TabIndex = 9;
            this.AccelerationYNumericUpDown3.ValueChanged += new System.EventHandler(this.XNumericUpDown_ValueChanged);
            // 
            // AccelerationXNumericUpDown
            // 
            this.AccelerationXNumericUpDown.Location = new System.Drawing.Point(37, 22);
            this.AccelerationXNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AccelerationXNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.AccelerationXNumericUpDown.Name = "AccelerationXNumericUpDown";
            this.AccelerationXNumericUpDown.Size = new System.Drawing.Size(89, 23);
            this.AccelerationXNumericUpDown.TabIndex = 8;
            this.AccelerationXNumericUpDown.ValueChanged += new System.EventHandler(this.XNumericUpDown_ValueChanged);
            // 
            // LinearGroupBox
            // 
            this.LinearGroupBox.Controls.Add(this.label4);
            this.LinearGroupBox.Controls.Add(this.label5);
            this.LinearGroupBox.Controls.Add(this.SpeedYNumericUpDown);
            this.LinearGroupBox.Controls.Add(this.SpeedXNumericUpDown);
            this.LinearGroupBox.Location = new System.Drawing.Point(14, 112);
            this.LinearGroupBox.Name = "LinearGroupBox";
            this.LinearGroupBox.Size = new System.Drawing.Size(330, 89);
            this.LinearGroupBox.TabIndex = 6;
            this.LinearGroupBox.TabStop = false;
            this.LinearGroupBox.Text = "Input Speed for Point";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "X";
            // 
            // SpeedYNumericUpDown
            // 
            this.SpeedYNumericUpDown.Location = new System.Drawing.Point(186, 22);
            this.SpeedYNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SpeedYNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SpeedYNumericUpDown.Name = "SpeedYNumericUpDown";
            this.SpeedYNumericUpDown.Size = new System.Drawing.Size(85, 23);
            this.SpeedYNumericUpDown.TabIndex = 5;
            this.SpeedYNumericUpDown.ValueChanged += new System.EventHandler(this.XNumericUpDown_ValueChanged);
            // 
            // SpeedXNumericUpDown
            // 
            this.SpeedXNumericUpDown.Location = new System.Drawing.Point(37, 22);
            this.SpeedXNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SpeedXNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SpeedXNumericUpDown.Name = "SpeedXNumericUpDown";
            this.SpeedXNumericUpDown.Size = new System.Drawing.Size(89, 23);
            this.SpeedXNumericUpDown.TabIndex = 4;
            this.SpeedXNumericUpDown.ValueChanged += new System.EventHandler(this.XNumericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Moving Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Linear",
            "Accelerated",
            "Oscillatory"});
            this.comboBox1.Location = new System.Drawing.Point(103, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Linear";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // YNumericUpDown
            // 
            this.YNumericUpDown.Location = new System.Drawing.Point(183, 20);
            this.YNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.YNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.YNumericUpDown.Name = "YNumericUpDown";
            this.YNumericUpDown.Size = new System.Drawing.Size(85, 23);
            this.YNumericUpDown.TabIndex = 1;
            this.YNumericUpDown.ValueChanged += new System.EventHandler(this.XNumericUpDown_ValueChanged);
            // 
            // XNumericUpDown
            // 
            this.XNumericUpDown.Location = new System.Drawing.Point(34, 20);
            this.XNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.XNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.XNumericUpDown.Name = "XNumericUpDown";
            this.XNumericUpDown.Size = new System.Drawing.Size(89, 23);
            this.XNumericUpDown.TabIndex = 0;
            this.XNumericUpDown.ValueChanged += new System.EventHandler(this.XNumericUpDown_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(353, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 450);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Click to Set Point Coord";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 428);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Location = new System.Drawing.Point(12, 415);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Point";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(103, 415);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(144, 23);
            this.RandomButton.TabIndex = 4;
            this.RandomButton.Text = "Random Data";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(269, 415);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewPointForm";
            this.Text = "NewPointForm";
            this.Load += new System.EventHandler(this.NewPointForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.OcillatoryGroupBox.ResumeLayout(false);
            this.OcillatoryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParametrNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterXNumericUpDown)).EndInit();
            this.AcceleratedGroupBox.ResumeLayout(false);
            this.AcceleratedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationYNumericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationXNumericUpDown)).EndInit();
            this.LinearGroupBox.ResumeLayout(false);
            this.LinearGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown YNumericUpDown;
        private System.Windows.Forms.NumericUpDown XNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.GroupBox OcillatoryGroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown ParametrNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown CenterYNumericUpDown;
        private System.Windows.Forms.NumericUpDown CenterXNumericUpDown;
        private System.Windows.Forms.GroupBox AcceleratedGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown AccelerationYNumericUpDown3;
        private System.Windows.Forms.NumericUpDown AccelerationXNumericUpDown;
        private System.Windows.Forms.GroupBox LinearGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown SpeedYNumericUpDown;
        private System.Windows.Forms.NumericUpDown SpeedXNumericUpDown;
        private System.Windows.Forms.Button CancelButton;
    }
}