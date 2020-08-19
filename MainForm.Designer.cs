/*
 * Created by SharpDevelop.
 * User: casper
 * Date: 4.08.2020
 * Time: 23:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tridiModellerThingy
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.glControl1 = new OpenTK.GLControl();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button4 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.inputdialog = new System.Windows.Forms.Panel();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.button12 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.button11 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.button13 = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.button14 = new System.Windows.Forms.Button();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.button15 = new System.Windows.Forms.Button();
			this.inputdialog.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// glControl1
			// 
			this.glControl1.BackColor = System.Drawing.Color.Black;
			this.glControl1.Location = new System.Drawing.Point(28, 43);
			this.glControl1.Name = "glControl1";
			this.glControl1.Size = new System.Drawing.Size(773, 518);
			this.glControl1.TabIndex = 0;
			this.glControl1.VSync = false;
			this.glControl1.Load += new System.EventHandler(this.GlControl1Load);
			this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.GlControl1Paint);
			this.glControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GlControl1KeyDown);
			this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GlControl1MouseDown);
			this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GlControl1MouseMove);
			this.glControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GlControl1MouseUp);
			this.glControl1.Resize += new System.EventHandler(this.GlControl1Resize);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(913, 282);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(81, 27);
			this.button1.TabIndex = 1;
			this.button1.Text = "Settings";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
			this.textBox1.Location = new System.Drawing.Point(807, 75);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(187, 200);
			this.textBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(807, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(251, 27);
			this.label1.TabIndex = 3;
			this.label1.Text = "Model Code:";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(807, 282);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 27);
			this.button2.TabIndex = 4;
			this.button2.Text = "Render Map";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 40;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(28, 644);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 27);
			this.button4.TabIndex = 6;
			this.button4.Text = "Box";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
			this.textBox2.Location = new System.Drawing.Point(28, 586);
			this.textBox2.MaxLength = 40;
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(1049, 22);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "Execute work speeder commands";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(28, 625);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "Add:";
			// 
			// inputdialog
			// 
			this.inputdialog.Controls.Add(this.textBox10);
			this.inputdialog.Controls.Add(this.button12);
			this.inputdialog.Controls.Add(this.button5);
			this.inputdialog.Controls.Add(this.textBox6);
			this.inputdialog.Controls.Add(this.textBox7);
			this.inputdialog.Controls.Add(this.label10);
			this.inputdialog.Controls.Add(this.label11);
			this.inputdialog.Controls.Add(this.textBox8);
			this.inputdialog.Controls.Add(this.textBox5);
			this.inputdialog.Controls.Add(this.label7);
			this.inputdialog.Controls.Add(this.textBox4);
			this.inputdialog.Controls.Add(this.label6);
			this.inputdialog.Controls.Add(this.label5);
			this.inputdialog.Controls.Add(this.label4);
			this.inputdialog.Controls.Add(this.textBox3);
			this.inputdialog.Controls.Add(this.button3);
			this.inputdialog.Controls.Add(this.panel1);
			this.inputdialog.Location = new System.Drawing.Point(123, 137);
			this.inputdialog.Name = "inputdialog";
			this.inputdialog.Size = new System.Drawing.Size(286, 115);
			this.inputdialog.TabIndex = 10;
			this.inputdialog.Visible = false;
			// 
			// textBox10
			// 
			this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox10.Location = new System.Drawing.Point(88, 42);
			this.textBox10.Multiline = true;
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(111, 29);
			this.textBox10.TabIndex = 17;
			// 
			// button12
			// 
			this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button12.Location = new System.Drawing.Point(88, 48);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(111, 23);
			this.button12.TabIndex = 16;
			this.button12.Text = "Pick Color";
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Visible = false;
			this.button12.Click += new System.EventHandler(this.Button12Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(2)))), ((int)(((byte)(98)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new System.Drawing.Point(250, 0);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(36, 45);
			this.button5.TabIndex = 1;
			this.button5.Text = "X";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox6.Location = new System.Drawing.Point(239, 52);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(12, 29);
			this.textBox6.TabIndex = 15;
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox7.Location = new System.Drawing.Point(223, 52);
			this.textBox7.Multiline = true;
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(12, 29);
			this.textBox7.TabIndex = 13;
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.SystemColors.Control;
			this.label10.Location = new System.Drawing.Point(208, 84);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(43, 27);
			this.label10.TabIndex = 11;
			this.label10.Text = "X   Y   Z";
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.SystemColors.Control;
			this.label11.Location = new System.Drawing.Point(205, 35);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 16);
			this.label11.TabIndex = 10;
			this.label11.Text = "Size:";
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox8.Location = new System.Drawing.Point(208, 52);
			this.textBox8.Multiline = true;
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(12, 29);
			this.textBox8.TabIndex = 9;
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox5.Location = new System.Drawing.Point(38, 52);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(12, 29);
			this.textBox5.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.Control;
			this.label7.Location = new System.Drawing.Point(38, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(10, 27);
			this.label7.TabIndex = 7;
			this.label7.Text = "Z";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Location = new System.Drawing.Point(22, 52);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(12, 29);
			this.textBox4.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.Control;
			this.label6.Location = new System.Drawing.Point(22, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(22, 27);
			this.label6.TabIndex = 5;
			this.label6.Text = "Y";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(7, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(22, 27);
			this.label5.TabIndex = 4;
			this.label5.Text = "X";
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(4, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Coordinates:";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Location = new System.Drawing.Point(7, 52);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(12, 29);
			this.textBox3.TabIndex = 2;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.Location = new System.Drawing.Point(88, 85);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 27);
			this.button3.TabIndex = 1;
			this.button3.Text = "Add Object";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(279, 30);
			this.panel1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Open Sans Light", 8.25F);
			this.label3.Location = new System.Drawing.Point(3, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(214, 27);
			this.label3.TabIndex = 0;
			this.label3.Text = "Enter values for adding object \"Box\"";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(133)))), ((int)(((byte)(129)))));
			this.panel2.Controls.Add(this.button6);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Location = new System.Drawing.Point(1, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1089, 36);
			this.panel2.TabIndex = 11;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Open Sans Light", 20F);
			this.button6.ForeColor = System.Drawing.SystemColors.Control;
			this.button6.Location = new System.Drawing.Point(176, 0);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(39, 36);
			this.button6.TabIndex = 1;
			this.button6.Text = "+";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
			this.panel3.Controls.Add(this.label12);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(183, 36);
			this.panel3.TabIndex = 0;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Open Sans Light", 20F);
			this.label12.ForeColor = System.Drawing.SystemColors.Control;
			this.label12.Location = new System.Drawing.Point(3, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(169, 31);
			this.label12.TabIndex = 0;
			this.label12.Text = "Untitled*";
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button7.Location = new System.Drawing.Point(1000, 75);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(81, 27);
			this.button7.TabIndex = 12;
			this.button7.Text = "Publish";
			this.button7.UseCompatibleTextRendering = true;
			this.button7.UseVisualStyleBackColor = false;
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Location = new System.Drawing.Point(1000, 108);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(81, 27);
			this.button8.TabIndex = 13;
			this.button8.Text = "Save";
			this.button8.UseVisualStyleBackColor = false;
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button9.Location = new System.Drawing.Point(807, 534);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(274, 27);
			this.button9.TabIndex = 14;
			this.button9.Text = "Edit Scripts!!!";
			this.button9.UseVisualStyleBackColor = false;
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.Location = new System.Drawing.Point(1000, 142);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(81, 27);
			this.button10.TabIndex = 15;
			this.button10.Text = "DevChat";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.SystemColors.Control;
			this.label8.Location = new System.Drawing.Point(807, 332);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 23);
			this.label8.TabIndex = 16;
			this.label8.Text = "Lighting:";
			// 
			// textBox9
			// 
			this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox9.ForeColor = System.Drawing.SystemColors.Control;
			this.textBox9.Location = new System.Drawing.Point(807, 359);
			this.textBox9.Multiline = true;
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(100, 23);
			this.textBox9.TabIndex = 17;
			this.textBox9.Text = "Enter Url of skybox";
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button11.Location = new System.Drawing.Point(913, 359);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(81, 23);
			this.button11.TabIndex = 18;
			this.button11.Text = "Load";
			this.button11.UseVisualStyleBackColor = false;
			// 
			// checkBox1
			// 
			this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
			this.checkBox1.Location = new System.Drawing.Point(807, 389);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 19;
			this.checkBox1.Text = "Smooth Objects";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckStateChanged += new System.EventHandler(this.CheckBox1CheckStateChanged);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.button13);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Location = new System.Drawing.Point(448, 75);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(203, 225);
			this.panel4.TabIndex = 20;
			this.panel4.Visible = false;
			// 
			// panel6
			// 
			this.panel6.Location = new System.Drawing.Point(27, 51);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(142, 100);
			this.panel6.TabIndex = 18;
			this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel6Paint);
			// 
			// button13
			// 
			this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(2)))), ((int)(((byte)(98)))));
			this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button13.Location = new System.Drawing.Point(167, 0);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(36, 45);
			this.button13.TabIndex = 17;
			this.button13.Text = "X";
			this.button13.UseVisualStyleBackColor = false;
			this.button13.Click += new System.EventHandler(this.Button13Click);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
			this.panel5.Controls.Add(this.label9);
			this.panel5.Location = new System.Drawing.Point(0, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(203, 30);
			this.panel5.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Open Sans Light", 8.25F);
			this.label9.Location = new System.Drawing.Point(0, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(214, 27);
			this.label9.TabIndex = 0;
			this.label9.Text = "Color Pick";
			// 
			// textBox11
			// 
			this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox11.Location = new System.Drawing.Point(807, 420);
			this.textBox11.Multiline = true;
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(100, 22);
			this.textBox11.TabIndex = 21;
			// 
			// button14
			// 
			this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
			this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button14.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button14.Location = new System.Drawing.Point(1000, 175);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(81, 27);
			this.button14.TabIndex = 22;
			this.button14.Text = "Free Models";
			this.button14.UseVisualStyleBackColor = false;
			// 
			// textBox12
			// 
			this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
			this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox12.Location = new System.Drawing.Point(913, 420);
			this.textBox12.Multiline = true;
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(81, 22);
			this.textBox12.TabIndex = 23;
			this.textBox12.Text = "2000";
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.SystemColors.Control;
			this.label13.Location = new System.Drawing.Point(913, 394);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 24;
			this.label13.Text = "FogEnd";
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
			this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button15.Location = new System.Drawing.Point(913, 449);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(81, 23);
			this.button15.TabIndex = 25;
			this.button15.Text = "Save";
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += new System.EventHandler(this.Button15Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
			this.ClientSize = new System.Drawing.Size(1089, 683);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.textBox12);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.inputdialog);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.glControl1);
			this.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "tridiModellerThingy";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(133)))), ((int)(((byte)(129)))));
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.inputdialog.ResumeLayout(false);
			this.inputdialog.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel inputdialog;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private OpenTK.GLControl glControl1;
	}
}
