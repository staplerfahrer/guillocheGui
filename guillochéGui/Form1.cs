using System;
using System.Diagnostics;
using System.IO;

namespace guillochéGui
{
	public partial class Form1 : Form
	{
		private DateTime _lastPreview = DateTime.Now;
		private MemoryStream _picture = new();
		private System.Windows.Forms.Timer _timer = new();
		private Process? _gc;

		public Form1()
		{
			InitializeComponent();
			comboBoxResolution.SelectedIndex = 0;
			comboBoxAlgorithm.SelectedIndex = 0;

			_timer.Tick += _timer_Tick;
			_timer.Interval = 250;
			_timer.Enabled = true;

			startGc();
			this.Focus();
		}

		private void _timer_Tick(object? sender, EventArgs e)
		{
			updatePicture();
		}

		private void startGc()
		{
			var gc = textBoxPath.Text;
			var gci = new FileInfo(gc);
			if (!gci.Exists) return;
			var path = gci.Directory?.FullName;
			var p = new ProcessStartInfo(gc)
			{
				WorkingDirectory = path ?? ".",
				CreateNoWindow = false,
				RedirectStandardInput = true,
				WindowStyle = ProcessWindowStyle.Minimized,
			};
			_gc = Process.Start(p);
			if (_gc != null)
			{
				_gc.PriorityClass = ProcessPriorityClass.Idle;
			}
		}

		private void updatePicture()
		{
			var pf = new FileInfo(textBoxOutTif.Text);
			if (!pf.Exists) return;
			if (pf.LastWriteTime == _lastPreview) return;
			_lastPreview = pf.LastWriteTime;
			try
			{
				_picture?.Dispose();
				_picture = new MemoryStream(File.ReadAllBytes(pf.FullName));
				previewBox.Image?.Dispose();
				previewBox.Image = Image.FromStream(_picture);
				previewBox.BackColor = SystemColors.ControlDark;
				previewBox.Update();
			}
			catch (Exception ex)
			{
				textBoxExc.Text = ex.ToString();
			}
		}

		private void buttonRun_Click(object sender, EventArgs e)
		{
			previewBox.BackColor = Color.Black;
			previewBox.Update();
			Thread.Sleep(100);
			if (_gc == null || _gc.HasExited) startGc();
			var args = $"{textBox1.Text} {textBox2.Text} {textBox3.Text} {textBox4.Text} {textBox5.Text} {textBox6.Text} {textBox7.Text} {textBox8.Text} {textBox9.Text} {textBox10.Text} {comboBoxResolution.Text} {comboBoxAlgorithm.Text}";
			_gc?.StandardInput.WriteLine(args);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			_gc?.StandardInput.WriteLine("");
		}

		private void previewBox_Click(object sender, EventArgs e)
		{
			previewBox.SizeMode = previewBox.SizeMode == PictureBoxSizeMode.Zoom
				? PictureBoxSizeMode.CenterImage
				: PictureBoxSizeMode.Zoom;
		}

		private void buttonPhotoshop_Click(object sender, EventArgs e)
		{
			Process.Start(textBoxPhotoshop.Text, textBoxOutTif.Text);
		}
	}
}