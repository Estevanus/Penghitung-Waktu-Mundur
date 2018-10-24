using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Penghitung_Waktu_Mundur
{
	public partial class mainForm : Form
	{

		int globalDetik = 0;
		List<string> daftarPrioritas = new List<string>();
		Dictionary<string, int> prioritasDanKepentingan = new Dictionary<string, int>();

		System.Media.SoundPlayer player = new System.Media.SoundPlayer();

		public mainForm()
		{
			InitializeComponent();

			FormClosing += new FormClosingEventHandler(OnClolsing);
		}

		void CekKepentingan()
		{
			if (prioritasDanKepentingan[jenisBox.Text] == 1)
			{
				MessageBox.Show("Penting ini, cek cek lagi jo");
				MessageBox.Show(deskripsiBox.Text, "Jang sampe ta lupa!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		void OnClolsing(object sender, FormClosingEventArgs e)
		{
			try
			{
				CekKepentingan();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				//nothings is here
			}
		}

		void loadPriority()
		{
			string jFileLok = "prioritas.txt";

			bool ada = true;
			if (System.IO.File.Exists(jFileLok) == false)
			{
				jFileLok = "C:/Program Files/Penghitung Waktu Mundur/prioritas.txt";
				if (System.IO.File.Exists(jFileLok) == false)
				{
					ada = false;
					MessageBox.Show("file db not found");
				}
			}

			if (ada)
			{
				string Text = System.IO.File.ReadAllText(jFileLok);
				string[] terpisah = Text.Split('\n');
				for (int i = 0; i < terpisah.Length; i++)
				{
					string[] tempS = terpisah[i].Split(' ');
					daftarPrioritas.Add(tempS[0]);
					prioritasDanKepentingan.Add(tempS[0], int.Parse(tempS[1]));
					jenisBox.Items.Add(tempS[0]);
				}

				if (jenisBox.Items.Count > 0)
				{
					jenisBox.Text = jenisBox.Items[0].ToString();
				}
			}
			else
			{
				//Close();
			}

		}

		void playSound()
		{
			player.PlayLooping();
		}

		void stopSound()
		{
			player.Stop();
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			int jam = int.Parse(jamTextBox.Text);
			int menit = int.Parse(menitTextBox.Text);
			int detik = int.Parse(detikTextBox.Text);

			globalDetik = jam * 60 * 60 + menit * 60 + detik;

			if (jam > 0 || menit > 0 || detik > 0)
			{
				counter.Enabled = true;
			}
			else
			{
				MessageBox.Show("No Time Left", "Time Warning");
			}
		}

		private void mainForm_Load(object sender, EventArgs e)
		{
			player.SoundLocation = "alaram_ready.wav";
			loadPriority();
		}

		private void counter_Tick(object sender, EventArgs e)
		{
			globalDetik--;
			detikTextBox.Text = (globalDetik % 60).ToString();
			int menit = globalDetik / 60;
			menitTextBox.Text = (menit % 60).ToString();
			int jam = menit / 60;
			jamTextBox.Text = (jam % 60).ToString();

			if (globalDetik <= 0)
			{
				counter.Enabled = false;
				playSound();
				MessageBox.Show(deskripsiBox.Text, "Info");
			}

			Console.WriteLine(globalDetik);
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			CekKepentingan();
			stopSound();
		}

		private void pauseButton_Click(object sender, EventArgs e)
		{
			stopSound();
			CekKepentingan();
			counter.Enabled = false;
		}
	}
}
