namespace guillochéGui
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
			splitContainer1 = new SplitContainer();
			buttonPhotoshop = new Button();
			textBoxPhotoshop = new TextBox();
			comboBoxAlgorithm = new ComboBox();
			comboBoxTool = new ComboBox();
			comboBoxResolution = new ComboBox();
			textBoxExc = new TextBox();
			textBoxOutTif = new TextBox();
			label10 = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			textBox10 = new TextBox();
			textBox9 = new TextBox();
			textBox8 = new TextBox();
			textBox7 = new TextBox();
			textBox6 = new TextBox();
			textBox5 = new TextBox();
			textBox4 = new TextBox();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			buttonRun = new Button();
			textBoxPath = new TextBox();
			previewBox = new PictureBox();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)previewBox).BeginInit();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(buttonPhotoshop);
			splitContainer1.Panel1.Controls.Add(textBoxPhotoshop);
			splitContainer1.Panel1.Controls.Add(comboBoxAlgorithm);
			splitContainer1.Panel1.Controls.Add(comboBoxTool);
			splitContainer1.Panel1.Controls.Add(comboBoxResolution);
			splitContainer1.Panel1.Controls.Add(textBoxExc);
			splitContainer1.Panel1.Controls.Add(textBoxOutTif);
			splitContainer1.Panel1.Controls.Add(label10);
			splitContainer1.Panel1.Controls.Add(label9);
			splitContainer1.Panel1.Controls.Add(label8);
			splitContainer1.Panel1.Controls.Add(label7);
			splitContainer1.Panel1.Controls.Add(label6);
			splitContainer1.Panel1.Controls.Add(label5);
			splitContainer1.Panel1.Controls.Add(label4);
			splitContainer1.Panel1.Controls.Add(label3);
			splitContainer1.Panel1.Controls.Add(label2);
			splitContainer1.Panel1.Controls.Add(label1);
			splitContainer1.Panel1.Controls.Add(textBox10);
			splitContainer1.Panel1.Controls.Add(textBox9);
			splitContainer1.Panel1.Controls.Add(textBox8);
			splitContainer1.Panel1.Controls.Add(textBox7);
			splitContainer1.Panel1.Controls.Add(textBox6);
			splitContainer1.Panel1.Controls.Add(textBox5);
			splitContainer1.Panel1.Controls.Add(textBox4);
			splitContainer1.Panel1.Controls.Add(textBox3);
			splitContainer1.Panel1.Controls.Add(textBox2);
			splitContainer1.Panel1.Controls.Add(textBox1);
			splitContainer1.Panel1.Controls.Add(buttonRun);
			splitContainer1.Panel1.Controls.Add(textBoxPath);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(previewBox);
			splitContainer1.Size = new Size(800, 697);
			splitContainer1.SplitterDistance = 266;
			splitContainer1.TabIndex = 0;
			// 
			// buttonPhotoshop
			// 
			buttonPhotoshop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			buttonPhotoshop.Location = new Point(12, 541);
			buttonPhotoshop.Name = "buttonPhotoshop";
			buttonPhotoshop.Size = new Size(232, 23);
			buttonPhotoshop.TabIndex = 14;
			buttonPhotoshop.Text = "Open Photoshop";
			buttonPhotoshop.UseVisualStyleBackColor = true;
			buttonPhotoshop.Click += buttonPhotoshop_Click;
			// 
			// textBoxPhotoshop
			// 
			textBoxPhotoshop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBoxPhotoshop.Location = new Point(12, 41);
			textBoxPhotoshop.Name = "textBoxPhotoshop";
			textBoxPhotoshop.Size = new Size(232, 23);
			textBoxPhotoshop.TabIndex = 17;
			textBoxPhotoshop.Text = "C:\\Program Files (x86)\\Adobe\\Adobe Photoshop CS2\\Photoshop.exe";
			// 
			// comboBoxAlgorithm
			// 
			comboBoxAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxAlgorithm.FormattingEnabled = true;
			comboBoxAlgorithm.Items.AddRange(new object[] { "customParameterDrawing", "sunburstAndCircles" });
			comboBoxAlgorithm.Location = new Point(12, 458);
			comboBoxAlgorithm.Name = "comboBoxAlgorithm";
			comboBoxAlgorithm.Size = new Size(232, 23);
			comboBoxAlgorithm.TabIndex = 12;
			// 
			// comboBoxTool
			// 
			comboBoxTool.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxTool.FormattingEnabled = true;
			comboBoxTool.Items.AddRange(new object[] { "cone63", "cone255", "cone1023" });
			comboBoxTool.Location = new Point(12, 429);
			comboBoxTool.Name = "comboBoxTool";
			comboBoxTool.Size = new Size(232, 23);
			comboBoxTool.TabIndex = 11;
			// 
			// comboBoxResolution
			// 
			comboBoxResolution.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxResolution.FormattingEnabled = true;
			comboBoxResolution.Items.AddRange(new object[] { "1k", "4k", "downsampled_4k" });
			comboBoxResolution.Location = new Point(12, 400);
			comboBoxResolution.Name = "comboBoxResolution";
			comboBoxResolution.Size = new Size(232, 23);
			comboBoxResolution.TabIndex = 10;
			// 
			// textBoxExc
			// 
			textBoxExc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBoxExc.Location = new Point(12, 570);
			textBoxExc.Multiline = true;
			textBoxExc.Name = "textBoxExc";
			textBoxExc.Size = new Size(232, 115);
			textBoxExc.TabIndex = 15;
			textBoxExc.Text = "0";
			// 
			// textBoxOutTif
			// 
			textBoxOutTif.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBoxOutTif.Location = new Point(12, 70);
			textBoxOutTif.Name = "textBoxOutTif";
			textBoxOutTif.Size = new Size(232, 23);
			textBoxOutTif.TabIndex = 18;
			textBoxOutTif.Text = "C:\\Temp\\out.tif";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(12, 371);
			label10.Name = "label10";
			label10.Size = new Size(95, 15);
			label10.TabIndex = 21;
			label10.Text = "teethCountFixed";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(12, 342);
			label9.Name = "label9";
			label9.Size = new Size(114, 15);
			label9.TabIndex = 20;
			label9.Text = "teethDensityRelative";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(12, 313);
			label8.Name = "label8";
			label8.Size = new Size(71, 15);
			label8.TabIndex = 19;
			label8.Text = "wheelCount";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(12, 284);
			label7.Name = "label7";
			label7.Size = new Size(105, 15);
			label7.TabIndex = 18;
			label7.Text = "wheelCenterOffset";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(12, 255);
			label6.Name = "label6";
			label6.Size = new Size(71, 15);
			label6.TabIndex = 17;
			label6.Text = "wheel1SizeB";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 226);
			label5.Name = "label5";
			label5.Size = new Size(72, 15);
			label5.TabIndex = 16;
			label5.Text = "wheel1SizeA";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 197);
			label4.Name = "label4";
			label4.Size = new Size(45, 15);
			label4.TabIndex = 15;
			label4.Text = "depthB";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 168);
			label3.Name = "label3";
			label3.Size = new Size(46, 15);
			label3.TabIndex = 14;
			label3.Text = "depthA";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 139);
			label2.Name = "label2";
			label2.Size = new Size(35, 15);
			label2.TabIndex = 13;
			label2.Text = "spiral";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 110);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
			label1.TabIndex = 12;
			label1.Text = "waves";
			// 
			// textBox10
			// 
			textBox10.Location = new Point(144, 368);
			textBox10.Name = "textBox10";
			textBox10.Size = new Size(100, 23);
			textBox10.TabIndex = 9;
			textBox10.Text = "0";
			// 
			// textBox9
			// 
			textBox9.Location = new Point(144, 339);
			textBox9.Name = "textBox9";
			textBox9.Size = new Size(100, 23);
			textBox9.TabIndex = 8;
			textBox9.Text = "0.1";
			// 
			// textBox8
			// 
			textBox8.Location = new Point(144, 310);
			textBox8.Name = "textBox8";
			textBox8.Size = new Size(100, 23);
			textBox8.TabIndex = 7;
			textBox8.Text = "72";
			// 
			// textBox7
			// 
			textBox7.Location = new Point(144, 281);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(100, 23);
			textBox7.TabIndex = 6;
			textBox7.Text = "0";
			// 
			// textBox6
			// 
			textBox6.Location = new Point(144, 252);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(100, 23);
			textBox6.TabIndex = 5;
			textBox6.Text = "0";
			// 
			// textBox5
			// 
			textBox5.Location = new Point(144, 223);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(100, 23);
			textBox5.TabIndex = 4;
			textBox5.Text = "0.99";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(144, 194);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(100, 23);
			textBox4.TabIndex = 3;
			textBox4.Text = "1";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(144, 165);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 23);
			textBox3.TabIndex = 2;
			textBox3.Text = "1";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(144, 136);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 1;
			textBox2.Text = "0";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(144, 107);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 0;
			textBox1.Text = "0";
			// 
			// buttonRun
			// 
			buttonRun.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			buttonRun.Location = new Point(12, 512);
			buttonRun.Name = "buttonRun";
			buttonRun.Size = new Size(232, 23);
			buttonRun.TabIndex = 13;
			buttonRun.Text = "Run";
			buttonRun.UseVisualStyleBackColor = true;
			buttonRun.Click += buttonRun_Click;
			// 
			// textBoxPath
			// 
			textBoxPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBoxPath.Location = new Point(12, 12);
			textBoxPath.Name = "textBoxPath";
			textBoxPath.Size = new Size(232, 23);
			textBoxPath.TabIndex = 16;
			textBoxPath.Text = "Z:\\_document\\Programming\\cpp\\guilloché\\a.exe";
			// 
			// previewBox
			// 
			previewBox.BackColor = SystemColors.ControlDark;
			previewBox.Dock = DockStyle.Fill;
			previewBox.Location = new Point(0, 0);
			previewBox.Name = "previewBox";
			previewBox.Size = new Size(530, 697);
			previewBox.SizeMode = PictureBoxSizeMode.Zoom;
			previewBox.TabIndex = 0;
			previewBox.TabStop = false;
			previewBox.Click += previewBox_Click;
			// 
			// Form1
			// 
			AcceptButton = buttonRun;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 697);
			Controls.Add(splitContainer1);
			Name = "Form1";
			Text = "Form1";
			WindowState = FormWindowState.Maximized;
			FormClosing += Form1_FormClosing;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)previewBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private PictureBox previewBox;
		private TextBox textBoxPath;
		private Button buttonRun;
		private Label label10;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox textBox10;
		private TextBox textBox9;
		private TextBox textBox8;
		private TextBox textBox7;
		private TextBox textBox6;
		private TextBox textBox5;
		private TextBox textBox4;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private TextBox textBoxOutTif;
		private TextBox textBoxExc;
		private ComboBox comboBoxResolution;
		private ComboBox comboBoxTool;
		private ComboBox comboBoxAlgorithm;
		private Button buttonPhotoshop;
		private TextBox textBoxPhotoshop;
	}
}