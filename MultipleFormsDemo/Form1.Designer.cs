namespace MultipleFormsDemo
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
			this.buttonMessageBox = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.buttonSecondForm = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonMessageBox
			// 
			this.buttonMessageBox.Location = new System.Drawing.Point(29, 36);
			this.buttonMessageBox.Name = "buttonMessageBox";
			this.buttonMessageBox.Size = new System.Drawing.Size(213, 169);
			this.buttonMessageBox.TabIndex = 0;
			this.buttonMessageBox.Text = "Show a Message Box";
			this.buttonMessageBox.UseVisualStyleBackColor = true;
			this.buttonMessageBox.Click += new System.EventHandler(this.buttonMessageBox_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(260, 36);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(217, 169);
			this.buttonSave.TabIndex = 1;
			this.buttonSave.Text = "Save...";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonSecondForm
			// 
			this.buttonSecondForm.Location = new System.Drawing.Point(493, 36);
			this.buttonSecondForm.Name = "buttonSecondForm";
			this.buttonSecondForm.Size = new System.Drawing.Size(219, 169);
			this.buttonSecondForm.TabIndex = 2;
			this.buttonSecondForm.Text = "Open Second Form";
			this.buttonSecondForm.UseVisualStyleBackColor = true;
			this.buttonSecondForm.Click += new System.EventHandler(this.buttonSecondForm_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(746, 242);
			this.Controls.Add(this.buttonSecondForm);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonMessageBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private Button buttonMessageBox;
		private Button buttonSave;
		private SaveFileDialog saveFileDialog1;
		private Button buttonSecondForm;
	}
}