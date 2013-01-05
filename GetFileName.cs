using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace mkscript3
{
	/// <summary>
	/// Summary description for GetFileName.
	/// </summary>
	public class GetFileName : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtFilename;
		private System.Windows.Forms.Label lblFilename;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private string filename;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GetFileName()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtFilename = new System.Windows.Forms.TextBox();
			this.lblFilename = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtFilename
			// 
			this.txtFilename.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtFilename.Location = new System.Drawing.Point(144, 16);
			this.txtFilename.Name = "txtFilename";
			this.txtFilename.Size = new System.Drawing.Size(184, 20);
			this.txtFilename.TabIndex = 4;
			this.txtFilename.Text = "";
			// 
			// lblFilename
			// 
			this.lblFilename.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblFilename.Location = new System.Drawing.Point(16, 16);
			this.lblFilename.Name = "lblFilename";
			this.lblFilename.Size = new System.Drawing.Size(120, 16);
			this.lblFilename.TabIndex = 2013;
			this.lblFilename.Text = "Name of Script :";
			this.lblFilename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(256, 48);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 2014;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(168, 48);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 2015;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// GetFileName
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(344, 82);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblFilename);
			this.Controls.Add(this.txtFilename);
			this.Name = "GetFileName";
			this.Text = "Save Script";
			this.Load += new System.EventHandler(this.GetFileName_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			((Button)sender).DialogResult = DialogResult.OK;
			Debug.WriteLine("OK:"+txtFilename.Text);
			this.FileName = txtFilename.Text;
			this.Visible = false;
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			((Button)sender).DialogResult = DialogResult.Cancel;
			Debug.WriteLine("CANCEL");
			this.Visible = false;
		}

		private void GetFileName_Load(object sender, System.EventArgs e)
		{
			txtFilename.Focus();
		}

		public string FileName
		{
			get
			{
				return filename;
			}
			set
			{
				filename = value;
			}
		}
	}
}
