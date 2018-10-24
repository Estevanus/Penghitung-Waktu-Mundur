namespace Penghitung_Waktu_Mundur
{
	partial class mainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.resetButton = new System.Windows.Forms.Button();
			this.pauseButton = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.jenisBox = new System.Windows.Forms.ComboBox();
			this.deskripsiBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.counter = new System.Windows.Forms.Timer(this.components);
			this.jamTextBox = new System.Windows.Forms.NumericUpDown();
			this.menitTextBox = new System.Windows.Forms.NumericUpDown();
			this.detikTextBox = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.jamTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.menitTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.detikTextBox)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Jam";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(173, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Menit";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(283, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Detik";
			// 
			// resetButton
			// 
			this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetButton.Location = new System.Drawing.Point(475, 54);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(100, 29);
			this.resetButton.TabIndex = 8;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// pauseButton
			// 
			this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pauseButton.Location = new System.Drawing.Point(475, 89);
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(100, 29);
			this.pauseButton.TabIndex = 9;
			this.pauseButton.Text = "Pause";
			this.pauseButton.UseVisualStyleBackColor = true;
			this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
			// 
			// startButton
			// 
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.Location = new System.Drawing.Point(475, 124);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(100, 29);
			this.startButton.TabIndex = 10;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(64, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "Jenis";
			// 
			// jenisBox
			// 
			this.jenisBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.jenisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jenisBox.FormattingEnabled = true;
			this.jenisBox.Location = new System.Drawing.Point(133, 135);
			this.jenisBox.Name = "jenisBox";
			this.jenisBox.Size = new System.Drawing.Size(254, 28);
			this.jenisBox.TabIndex = 6;
			// 
			// deskripsiBox
			// 
			this.deskripsiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deskripsiBox.Location = new System.Drawing.Point(68, 227);
			this.deskripsiBox.Multiline = true;
			this.deskripsiBox.Name = "deskripsiBox";
			this.deskripsiBox.Size = new System.Drawing.Size(507, 134);
			this.deskripsiBox.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(64, 193);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Deskripsi :";
			// 
			// counter
			// 
			this.counter.Interval = 1000;
			this.counter.Tick += new System.EventHandler(this.counter_Tick);
			// 
			// jamTextBox
			// 
			this.jamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jamTextBox.Location = new System.Drawing.Point(68, 88);
			this.jamTextBox.Name = "jamTextBox";
			this.jamTextBox.Size = new System.Drawing.Size(100, 26);
			this.jamTextBox.TabIndex = 12;
			// 
			// menitTextBox
			// 
			this.menitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menitTextBox.Location = new System.Drawing.Point(177, 88);
			this.menitTextBox.Name = "menitTextBox";
			this.menitTextBox.Size = new System.Drawing.Size(100, 26);
			this.menitTextBox.TabIndex = 13;
			// 
			// detikTextBox
			// 
			this.detikTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.detikTextBox.Location = new System.Drawing.Point(287, 88);
			this.detikTextBox.Name = "detikTextBox";
			this.detikTextBox.Size = new System.Drawing.Size(100, 26);
			this.detikTextBox.TabIndex = 14;
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(642, 364);
			this.Controls.Add(this.detikTextBox);
			this.Controls.Add(this.menitTextBox);
			this.Controls.Add(this.jamTextBox);
			this.Controls.Add(this.deskripsiBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.jenisBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.pauseButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "mainForm";
			this.Text = "Penghitung Waktu Mundur";
			this.Load += new System.EventHandler(this.mainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.jamTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.menitTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.detikTextBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Button pauseButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox jenisBox;
		private System.Windows.Forms.TextBox deskripsiBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Timer counter;
		private System.Windows.Forms.NumericUpDown jamTextBox;
		private System.Windows.Forms.NumericUpDown menitTextBox;
		private System.Windows.Forms.NumericUpDown detikTextBox;
	}
}

