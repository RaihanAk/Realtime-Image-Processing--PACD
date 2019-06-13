namespace RealtimeImageProcessing
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
            this.components = new System.ComponentModel.Container();
            this.imageBox = new Emgu.CV.UI.ImageBox();
            this.btStop = new System.Windows.Forms.Button();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabColorDetect = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.colorResAlter = new Emgu.CV.UI.ImageBox();
            this.colorAlterbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorRes2 = new Emgu.CV.UI.ImageBox();
            this.color2btn = new System.Windows.Forms.Button();
            this.colorRes1 = new Emgu.CV.UI.ImageBox();
            this.color1btn = new System.Windows.Forms.Button();
            this.tabImageProcess = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.binary_trackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.brightness_trackBar = new System.Windows.Forms.TrackBar();
            this.brightnessValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.rbBrightness = new System.Windows.Forms.RadioButton();
            this.rbInvert = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ThresholdValue = new System.Windows.Forms.NumericUpDown();
            this.colorCB = new System.Windows.Forms.ComboBox();
            this.rbBinary = new System.Windows.Forms.RadioButton();
            this.rbGrey = new System.Windows.Forms.RadioButton();
            this.rbColor = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialogAlter = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabColorDetect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorResAlter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRes1)).BeginInit();
            this.tabImageProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binary_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdValue)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(12, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(831, 629);
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStop.Location = new System.Drawing.Point(944, 55);
            this.btStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(82, 38);
            this.btStop.TabIndex = 16;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // cbCamera
            // 
            this.cbCamera.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(1034, 19);
            this.cbCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(285, 31);
            this.cbCamera.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(860, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select Camera";
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(860, 55);
            this.btStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(78, 38);
            this.btStart.TabIndex = 13;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabColorDetect);
            this.tabControl.Controls.Add(this.tabImageProcess);
            this.tabControl.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(860, 111);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(668, 535);
            this.tabControl.TabIndex = 18;
            // 
            // tabColorDetect
            // 
            this.tabColorDetect.Controls.Add(this.label3);
            this.tabColorDetect.Controls.Add(this.colorResAlter);
            this.tabColorDetect.Controls.Add(this.colorAlterbtn);
            this.tabColorDetect.Controls.Add(this.label2);
            this.tabColorDetect.Controls.Add(this.colorRes2);
            this.tabColorDetect.Controls.Add(this.color2btn);
            this.tabColorDetect.Controls.Add(this.colorRes1);
            this.tabColorDetect.Controls.Add(this.color1btn);
            this.tabColorDetect.Location = new System.Drawing.Point(4, 32);
            this.tabColorDetect.Name = "tabColorDetect";
            this.tabColorDetect.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabColorDetect.Size = new System.Drawing.Size(660, 499);
            this.tabColorDetect.TabIndex = 0;
            this.tabColorDetect.Text = "Color Detection";
            this.tabColorDetect.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Then alter it to different color";
            // 
            // colorResAlter
            // 
            this.colorResAlter.BackColor = System.Drawing.Color.Transparent;
            this.colorResAlter.Location = new System.Drawing.Point(27, 191);
            this.colorResAlter.Name = "colorResAlter";
            this.colorResAlter.Size = new System.Drawing.Size(40, 38);
            this.colorResAlter.TabIndex = 7;
            this.colorResAlter.TabStop = false;
            // 
            // colorAlterbtn
            // 
            this.colorAlterbtn.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorAlterbtn.Location = new System.Drawing.Point(73, 191);
            this.colorAlterbtn.Name = "colorAlterbtn";
            this.colorAlterbtn.Size = new System.Drawing.Size(102, 38);
            this.colorAlterbtn.TabIndex = 6;
            this.colorAlterbtn.Text = "Color Alter";
            this.colorAlterbtn.UseVisualStyleBackColor = true;
            this.colorAlterbtn.Click += new System.EventHandler(this.colorAlterbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detect color within range of two defined colors down below";
            // 
            // colorRes2
            // 
            this.colorRes2.BackColor = System.Drawing.Color.Transparent;
            this.colorRes2.Location = new System.Drawing.Point(257, 68);
            this.colorRes2.Name = "colorRes2";
            this.colorRes2.Size = new System.Drawing.Size(40, 38);
            this.colorRes2.TabIndex = 4;
            this.colorRes2.TabStop = false;
            // 
            // color2btn
            // 
            this.color2btn.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color2btn.Location = new System.Drawing.Point(303, 68);
            this.color2btn.Name = "color2btn";
            this.color2btn.Size = new System.Drawing.Size(79, 38);
            this.color2btn.TabIndex = 3;
            this.color2btn.Text = "Color 2";
            this.color2btn.UseVisualStyleBackColor = true;
            this.color2btn.Click += new System.EventHandler(this.color2btn_Click);
            // 
            // colorRes1
            // 
            this.colorRes1.BackColor = System.Drawing.Color.Transparent;
            this.colorRes1.Location = new System.Drawing.Point(27, 68);
            this.colorRes1.Name = "colorRes1";
            this.colorRes1.Size = new System.Drawing.Size(40, 38);
            this.colorRes1.TabIndex = 2;
            this.colorRes1.TabStop = false;
            // 
            // color1btn
            // 
            this.color1btn.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color1btn.Location = new System.Drawing.Point(73, 68);
            this.color1btn.Name = "color1btn";
            this.color1btn.Size = new System.Drawing.Size(79, 38);
            this.color1btn.TabIndex = 0;
            this.color1btn.Text = "Color 1";
            this.color1btn.UseVisualStyleBackColor = true;
            this.color1btn.Click += new System.EventHandler(this.color1btn_Click);
            // 
            // tabImageProcess
            // 
            this.tabImageProcess.Controls.Add(this.label9);
            this.tabImageProcess.Controls.Add(this.label8);
            this.tabImageProcess.Controls.Add(this.binary_trackBar);
            this.tabImageProcess.Controls.Add(this.label7);
            this.tabImageProcess.Controls.Add(this.brightness_trackBar);
            this.tabImageProcess.Controls.Add(this.brightnessValue);
            this.tabImageProcess.Controls.Add(this.label6);
            this.tabImageProcess.Controls.Add(this.rbBrightness);
            this.tabImageProcess.Controls.Add(this.rbInvert);
            this.tabImageProcess.Controls.Add(this.label5);
            this.tabImageProcess.Controls.Add(this.label4);
            this.tabImageProcess.Controls.Add(this.ThresholdValue);
            this.tabImageProcess.Controls.Add(this.colorCB);
            this.tabImageProcess.Controls.Add(this.rbBinary);
            this.tabImageProcess.Controls.Add(this.rbGrey);
            this.tabImageProcess.Controls.Add(this.rbColor);
            this.tabImageProcess.Location = new System.Drawing.Point(4, 32);
            this.tabImageProcess.Name = "tabImageProcess";
            this.tabImageProcess.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabImageProcess.Size = new System.Drawing.Size(660, 499);
            this.tabImageProcess.TabIndex = 1;
            this.tabImageProcess.Text = "Image Processing";
            this.tabImageProcess.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label9.Location = new System.Drawing.Point(614, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "255";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.Location = new System.Drawing.Point(405, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "0";
            // 
            // binary_trackBar
            // 
            this.binary_trackBar.BackColor = System.Drawing.Color.White;
            this.binary_trackBar.Location = new System.Drawing.Point(392, 259);
            this.binary_trackBar.Maximum = 255;
            this.binary_trackBar.Name = "binary_trackBar";
            this.binary_trackBar.Size = new System.Drawing.Size(262, 56);
            this.binary_trackBar.TabIndex = 24;
            this.binary_trackBar.Scroll += new System.EventHandler(this.binary_trackBar_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(178, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "0";
            // 
            // brightness_trackBar
            // 
            this.brightness_trackBar.BackColor = System.Drawing.Color.White;
            this.brightness_trackBar.Location = new System.Drawing.Point(55, 259);
            this.brightness_trackBar.Maximum = 255;
            this.brightness_trackBar.Minimum = -255;
            this.brightness_trackBar.Name = "brightness_trackBar";
            this.brightness_trackBar.Size = new System.Drawing.Size(262, 56);
            this.brightness_trackBar.TabIndex = 22;
            this.brightness_trackBar.Scroll += new System.EventHandler(this.brightness_trackBar_Scroll);
            // 
            // brightnessValue
            // 
            this.brightnessValue.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brightnessValue.Location = new System.Drawing.Point(55, 320);
            this.brightnessValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brightnessValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.brightnessValue.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.brightnessValue.Name = "brightnessValue";
            this.brightnessValue.Size = new System.Drawing.Size(89, 31);
            this.brightnessValue.TabIndex = 21;
            this.brightnessValue.ValueChanged += new System.EventHandler(this.brightnessValue_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Scale";
            // 
            // rbBrightness
            // 
            this.rbBrightness.AutoSize = true;
            this.rbBrightness.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBrightness.Location = new System.Drawing.Point(30, 193);
            this.rbBrightness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbBrightness.Name = "rbBrightness";
            this.rbBrightness.Size = new System.Drawing.Size(107, 27);
            this.rbBrightness.TabIndex = 19;
            this.rbBrightness.Text = "Brighness";
            this.rbBrightness.UseVisualStyleBackColor = true;
            // 
            // rbInvert
            // 
            this.rbInvert.AutoSize = true;
            this.rbInvert.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInvert.Location = new System.Drawing.Point(248, 31);
            this.rbInvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbInvert.Name = "rbInvert";
            this.rbInvert.Size = new System.Drawing.Size(76, 27);
            this.rbInvert.TabIndex = 18;
            this.rbInvert.Text = "Invert";
            this.rbInvert.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Threshold Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Channel";
            // 
            // ThresholdValue
            // 
            this.ThresholdValue.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThresholdValue.Location = new System.Drawing.Point(392, 320);
            this.ThresholdValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThresholdValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ThresholdValue.Name = "ThresholdValue";
            this.ThresholdValue.Size = new System.Drawing.Size(89, 31);
            this.ThresholdValue.TabIndex = 15;
            this.ThresholdValue.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.ThresholdValue.ValueChanged += new System.EventHandler(this.ThresholdValue_ValueChanged);
            // 
            // colorCB
            // 
            this.colorCB.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorCB.FormattingEnabled = true;
            this.colorCB.Items.AddRange(new object[] {
            "RGB",
            "R",
            "G",
            "B"});
            this.colorCB.Location = new System.Drawing.Point(55, 88);
            this.colorCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorCB.Name = "colorCB";
            this.colorCB.Size = new System.Drawing.Size(93, 31);
            this.colorCB.TabIndex = 14;
            // 
            // rbBinary
            // 
            this.rbBinary.AutoSize = true;
            this.rbBinary.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBinary.Location = new System.Drawing.Point(368, 192);
            this.rbBinary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbBinary.Name = "rbBinary";
            this.rbBinary.Size = new System.Drawing.Size(81, 27);
            this.rbBinary.TabIndex = 13;
            this.rbBinary.Text = "Binary";
            this.rbBinary.UseVisualStyleBackColor = true;
            // 
            // rbGrey
            // 
            this.rbGrey.AutoSize = true;
            this.rbGrey.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGrey.Location = new System.Drawing.Point(408, 31);
            this.rbGrey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbGrey.Name = "rbGrey";
            this.rbGrey.Size = new System.Drawing.Size(105, 27);
            this.rbGrey.TabIndex = 12;
            this.rbGrey.Text = "Grayscale";
            this.rbGrey.UseVisualStyleBackColor = true;
            // 
            // rbColor
            // 
            this.rbColor.AutoSize = true;
            this.rbColor.Checked = true;
            this.rbColor.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbColor.Location = new System.Drawing.Point(30, 31);
            this.rbColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbColor.Name = "rbColor";
            this.rbColor.Size = new System.Drawing.Size(71, 27);
            this.rbColor.TabIndex = 11;
            this.rbColor.TabStop = true;
            this.rbColor.Text = "Color";
            this.rbColor.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.LightGreen;
            this.colorDialog1.FullOpen = true;
            // 
            // colorDialog2
            // 
            this.colorDialog2.AnyColor = true;
            this.colorDialog2.Color = System.Drawing.Color.DarkGreen;
            this.colorDialog2.FullOpen = true;
            // 
            // colorDialogAlter
            // 
            this.colorDialogAlter.AnyColor = true;
            this.colorDialogAlter.Color = System.Drawing.Color.SkyBlue;
            this.colorDialogAlter.FullOpen = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 653);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.cbCamera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.imageBox);
            this.Name = "Form1";
            this.Text = "Realtime Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabColorDetect.ResumeLayout(false);
            this.tabColorDetect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorResAlter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRes1)).EndInit();
            this.tabImageProcess.ResumeLayout(false);
            this.tabImageProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binary_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabColorDetect;
        private System.Windows.Forms.TabPage tabImageProcess;
        private System.Windows.Forms.NumericUpDown ThresholdValue;
        private System.Windows.Forms.ComboBox colorCB;
        private System.Windows.Forms.RadioButton rbBinary;
        private System.Windows.Forms.RadioButton rbGrey;
        private System.Windows.Forms.RadioButton rbColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button color1btn;
        private Emgu.CV.UI.ImageBox colorRes1;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox colorResAlter;
        private System.Windows.Forms.Button colorAlterbtn;
        private System.Windows.Forms.Label label2;
        private Emgu.CV.UI.ImageBox colorRes2;
        private System.Windows.Forms.Button color2btn;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialogAlter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbInvert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar brightness_trackBar;
        private System.Windows.Forms.NumericUpDown brightnessValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbBrightness;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar binary_trackBar;
        private System.Windows.Forms.Label label9;
    }
}

