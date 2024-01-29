namespace WindowsFormsDemo
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
			this.components = new System.ComponentModel.Container();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonSubtract = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.labelCount = new System.Windows.Forms.Label();
			this.textCount = new System.Windows.Forms.TextBox();
			this.timerCount = new System.Windows.Forms.Timer(this.components);
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(12, 12);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(151, 67);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// buttonSubtract
			// 
			this.buttonSubtract.Location = new System.Drawing.Point(169, 12);
			this.buttonSubtract.Name = "buttonSubtract";
			this.buttonSubtract.Size = new System.Drawing.Size(151, 67);
			this.buttonSubtract.TabIndex = 1;
			this.buttonSubtract.Text = "Subtract";
			this.buttonSubtract.UseVisualStyleBackColor = true;
			this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(326, 12);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(151, 67);
			this.buttonReset.TabIndex = 2;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// labelCount
			// 
			this.labelCount.AutoSize = true;
			this.labelCount.Location = new System.Drawing.Point(12, 96);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(64, 25);
			this.labelCount.TabIndex = 3;
			this.labelCount.Text = "Count:";
			// 
			// textCount
			// 
			this.textCount.Location = new System.Drawing.Point(82, 96);
			this.textCount.Name = "textCount";
			this.textCount.ReadOnly = true;
			this.textCount.Size = new System.Drawing.Size(395, 31);
			this.textCount.TabIndex = 4;
			// 
			// timerCount
			// 
			this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 143);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(465, 31);
			this.progressBar1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 186);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.textCount);
			this.Controls.Add(this.labelCount);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.buttonSubtract);
			this.Controls.Add(this.buttonAdd);
			this.Name = "Form1";
			this.Text = "This is the title bar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button buttonAdd;
		private Button buttonSubtract;
		private Button buttonReset;
		private Label labelCount;
		private TextBox textCount;
		private System.Windows.Forms.Timer timerCount;
		private ProgressBar progressBar1;
	}
}