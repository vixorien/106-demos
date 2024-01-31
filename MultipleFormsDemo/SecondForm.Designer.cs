namespace MultipleFormsDemo
{
	partial class SecondForm
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.buttonChange = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(46, 76);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(153, 29);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Are you there?";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// buttonChange
			// 
			this.buttonChange.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonChange.Location = new System.Drawing.Point(254, 26);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(339, 393);
			this.buttonChange.TabIndex = 1;
			this.buttonChange.Text = "Change Other Form\'s Color";
			this.buttonChange.UseVisualStyleBackColor = true;
			this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
			// 
			// SecondForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 450);
			this.Controls.Add(this.buttonChange);
			this.Controls.Add(this.checkBox1);
			this.Name = "SecondForm";
			this.Text = "SecondForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecondForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CheckBox checkBox1;
		private Button buttonChange;
	}
}