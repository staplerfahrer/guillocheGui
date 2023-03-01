using System.Diagnostics;

namespace guillochéGui
{
	public partial class Form1 : Form
	{
		private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
		private DateTime _lastPreview = DateTime.Now;
		private MemoryStream _picture;

		public Form1()
		{
			InitializeComponent();
			_timer.Tick += _timer_Tick;
			_timer.Interval = 250;
			//_timer.Enabled = true;
		}

		private void _timer_Tick(object? sender, EventArgs e)
		{
			var pf = new FileInfo(textBoxOutTif.Text);
			if (!pf.Exists) return;
			if (pf.LastWriteTime == _lastPreview) return;
			//_timer.Enabled = false;
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
			//_timer.Enabled = true;
		}

		private void buttonRun_Click(object sender, EventArgs e)
		{
			var gc = textBoxPath.Text;
			var gci = new FileInfo(gc);
			if (!gci.Exists) return;
			var path = gci.Directory.FullName;
			var args = $"{textBox1.Text} {textBox2.Text} {textBox3.Text} {textBox4.Text} {textBox5.Text} {textBox6.Text} {textBox7.Text} {textBox8.Text} {textBox9.Text} {textBox10.Text}";
			var p = new ProcessStartInfo(gc, args)
			{
				WorkingDirectory = path,
				CreateNoWindow = false,
				//RedirectStandardOutput = true,
			};
			var proc = Process.Start(p);
			//var output = proc.StandardOutput.ReadToEnd();
			proc.WaitForExit();
			textBoxExc.Text = "done";
			_timer_Tick(null, null);
		}
	}
}