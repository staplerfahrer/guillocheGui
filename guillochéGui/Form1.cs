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
			_timer.Tick += _timer_Tick;
			_timer.Interval = 250;
			_timer.Enabled = true;

			startGc();
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
			var p = new ProcessStartInfo(gc, "x")
			{
				WorkingDirectory = path ?? ".",
				CreateNoWindow = false,
				RedirectStandardInput = true,
			};
			_gc = Process.Start(p);
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
			}
			catch (Exception ex)
			{
				textBoxExc.Text = ex.ToString();
			}
		}

		private void buttonRun_Click(object sender, EventArgs e)
		{
			if (_gc == null || _gc.HasExited) startGc();
			var args = $"x {textBox1.Text} {textBox2.Text} {textBox3.Text} {textBox4.Text} {textBox5.Text} {textBox6.Text} {textBox7.Text} {textBox8.Text} {textBox9.Text} {textBox10.Text} {comboBoxResolution.Text}";
			_gc.StandardInput.WriteLine(args);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			_gc.Kill();
		}
	}
}