using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace mkscript3
{
	/// <summary>
	/// Summary description for add.
	/// </summary>
	public class add : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label lblTempStart;
		private System.Windows.Forms.Label lblTempEnd;
		private System.Windows.Forms.Label lblTempStep;
		private System.Windows.Forms.TextBox txtTempStart;
		private System.Windows.Forms.TextBox txtTempEnd;
		private System.Windows.Forms.TextBox txtTempStep;
		private System.Windows.Forms.GroupBox grpTemp;
		private System.Windows.Forms.GroupBox grpField;
		private System.Windows.Forms.TextBox txtFieldStart;
		private System.Windows.Forms.TextBox txtFieldEnd;
		private System.Windows.Forms.TextBox txtFieldStep;
		private System.Windows.Forms.Label lblFieldStart;
		private System.Windows.Forms.Label lblFieldEnd;
		private System.Windows.Forms.Label lblFieldStep;
		private System.Windows.Forms.GroupBox grpRun;
		private System.Windows.Forms.Label lblEntry;
		private System.Windows.Forms.TextBox txtEntry;
		private System.Windows.Forms.Label lblEvents;
		private System.Windows.Forms.TextBox txtEvents;
		private System.Windows.Forms.GroupBox grpCustom;
		private System.Windows.Forms.Label lblCustom;
		private System.Windows.Forms.TextBox txtCustom;
		private System.Windows.Forms.Button btnAddOk;
		private System.Windows.Forms.Button btnAddCancel;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public add()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTempStart = new System.Windows.Forms.Label();
			this.lblTempEnd = new System.Windows.Forms.Label();
			this.lblTempStep = new System.Windows.Forms.Label();
			this.txtTempStart = new System.Windows.Forms.TextBox();
			this.txtTempEnd = new System.Windows.Forms.TextBox();
			this.txtTempStep = new System.Windows.Forms.TextBox();
			this.grpTemp = new System.Windows.Forms.GroupBox();
			this.grpField = new System.Windows.Forms.GroupBox();
			this.txtFieldStart = new System.Windows.Forms.TextBox();
			this.txtFieldEnd = new System.Windows.Forms.TextBox();
			this.txtFieldStep = new System.Windows.Forms.TextBox();
			this.lblFieldStart = new System.Windows.Forms.Label();
			this.lblFieldEnd = new System.Windows.Forms.Label();
			this.lblFieldStep = new System.Windows.Forms.Label();
			this.grpRun = new System.Windows.Forms.GroupBox();
			this.txtEvents = new System.Windows.Forms.TextBox();
			this.lblEvents = new System.Windows.Forms.Label();
			this.txtEntry = new System.Windows.Forms.TextBox();
			this.lblEntry = new System.Windows.Forms.Label();
			this.grpCustom = new System.Windows.Forms.GroupBox();
			this.lblCustom = new System.Windows.Forms.Label();
			this.txtCustom = new System.Windows.Forms.TextBox();
			this.btnAddOk = new System.Windows.Forms.Button();
			this.btnAddCancel = new System.Windows.Forms.Button();
			this.grpTemp.SuspendLayout();
			this.grpField.SuspendLayout();
			this.grpRun.SuspendLayout();
			this.grpCustom.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTempStart
			// 
			this.lblTempStart.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTempStart.Location = new System.Drawing.Point(16, 18);
			this.lblTempStart.Name = "lblTempStart";
			this.lblTempStart.Size = new System.Drawing.Size(56, 16);
			this.lblTempStart.TabIndex = 2;
			this.lblTempStart.Text = "Start :";
			this.lblTempStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTempEnd
			// 
			this.lblTempEnd.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTempEnd.Location = new System.Drawing.Point(16, 42);
			this.lblTempEnd.Name = "lblTempEnd";
			this.lblTempEnd.Size = new System.Drawing.Size(56, 16);
			this.lblTempEnd.TabIndex = 3;
			this.lblTempEnd.Text = "End :";
			this.lblTempEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTempStep
			// 
			this.lblTempStep.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTempStep.Location = new System.Drawing.Point(16, 66);
			this.lblTempStep.Name = "lblTempStep";
			this.lblTempStep.Size = new System.Drawing.Size(56, 16);
			this.lblTempStep.TabIndex = 4;
			this.lblTempStep.Text = "Step :";
			this.lblTempStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTempStart
			// 
			this.txtTempStart.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTempStart.Location = new System.Drawing.Point(96, 16);
			this.txtTempStart.Name = "txtTempStart";
			this.txtTempStart.TabIndex = 5;
			this.txtTempStart.Text = "";
			// 
			// txtTempEnd
			// 
			this.txtTempEnd.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTempEnd.Location = new System.Drawing.Point(96, 40);
			this.txtTempEnd.Name = "txtTempEnd";
			this.txtTempEnd.TabIndex = 6;
			this.txtTempEnd.Text = "";
			// 
			// txtTempStep
			// 
			this.txtTempStep.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTempStep.Location = new System.Drawing.Point(96, 64);
			this.txtTempStep.Name = "txtTempStep";
			this.txtTempStep.TabIndex = 7;
			this.txtTempStep.Text = "";
			// 
			// grpTemp
			// 
			this.grpTemp.Controls.Add(this.txtTempStart);
			this.grpTemp.Controls.Add(this.txtTempEnd);
			this.grpTemp.Controls.Add(this.txtTempStep);
			this.grpTemp.Controls.Add(this.lblTempStart);
			this.grpTemp.Controls.Add(this.lblTempEnd);
			this.grpTemp.Controls.Add(this.lblTempStep);
			this.grpTemp.Location = new System.Drawing.Point(8, 64);
			this.grpTemp.Name = "grpTemp";
			this.grpTemp.Size = new System.Drawing.Size(208, 96);
			this.grpTemp.TabIndex = 8;
			this.grpTemp.TabStop = false;
			this.grpTemp.Text = "Temperature";
			// 
			// grpField
			// 
			this.grpField.Controls.Add(this.txtFieldStart);
			this.grpField.Controls.Add(this.txtFieldEnd);
			this.grpField.Controls.Add(this.txtFieldStep);
			this.grpField.Controls.Add(this.lblFieldStart);
			this.grpField.Controls.Add(this.lblFieldEnd);
			this.grpField.Controls.Add(this.lblFieldStep);
			this.grpField.Location = new System.Drawing.Point(8, 160);
			this.grpField.Name = "grpField";
			this.grpField.Size = new System.Drawing.Size(208, 96);
			this.grpField.TabIndex = 9;
			this.grpField.TabStop = false;
			this.grpField.Text = "Field";
			// 
			// txtFieldStart
			// 
			this.txtFieldStart.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtFieldStart.Location = new System.Drawing.Point(96, 16);
			this.txtFieldStart.Name = "txtFieldStart";
			this.txtFieldStart.TabIndex = 8;
			this.txtFieldStart.Text = "";
			// 
			// txtFieldEnd
			// 
			this.txtFieldEnd.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtFieldEnd.Location = new System.Drawing.Point(96, 40);
			this.txtFieldEnd.Name = "txtFieldEnd";
			this.txtFieldEnd.TabIndex = 9;
			this.txtFieldEnd.Text = "";
			// 
			// txtFieldStep
			// 
			this.txtFieldStep.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtFieldStep.Location = new System.Drawing.Point(96, 64);
			this.txtFieldStep.Name = "txtFieldStep";
			this.txtFieldStep.TabIndex = 10;
			this.txtFieldStep.Text = "";
			// 
			// lblFieldStart
			// 
			this.lblFieldStart.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblFieldStart.Location = new System.Drawing.Point(16, 18);
			this.lblFieldStart.Name = "lblFieldStart";
			this.lblFieldStart.Size = new System.Drawing.Size(56, 16);
			this.lblFieldStart.TabIndex = 2;
			this.lblFieldStart.Text = "Start :";
			this.lblFieldStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblFieldEnd
			// 
			this.lblFieldEnd.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblFieldEnd.Location = new System.Drawing.Point(16, 42);
			this.lblFieldEnd.Name = "lblFieldEnd";
			this.lblFieldEnd.Size = new System.Drawing.Size(56, 16);
			this.lblFieldEnd.TabIndex = 3;
			this.lblFieldEnd.Text = "End :";
			this.lblFieldEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblFieldStep
			// 
			this.lblFieldStep.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblFieldStep.Location = new System.Drawing.Point(16, 66);
			this.lblFieldStep.Name = "lblFieldStep";
			this.lblFieldStep.Size = new System.Drawing.Size(56, 16);
			this.lblFieldStep.TabIndex = 4;
			this.lblFieldStep.Text = "Step :";
			this.lblFieldStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grpRun
			// 
			this.grpRun.Controls.Add(this.txtEvents);
			this.grpRun.Controls.Add(this.lblEvents);
			this.grpRun.Controls.Add(this.txtEntry);
			this.grpRun.Controls.Add(this.lblEntry);
			this.grpRun.Location = new System.Drawing.Point(8, 8);
			this.grpRun.Name = "grpRun";
			this.grpRun.Size = new System.Drawing.Size(208, 56);
			this.grpRun.TabIndex = 10;
			this.grpRun.TabStop = false;
			this.grpRun.Text = "General";
			// 
			// txtEvents
			// 
			this.txtEvents.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtEvents.Location = new System.Drawing.Point(136, 24);
			this.txtEvents.Name = "txtEvents";
			this.txtEvents.Size = new System.Drawing.Size(64, 20);
			this.txtEvents.TabIndex = 3;
			this.txtEvents.Text = "";
			// 
			// lblEvents
			// 
			this.lblEvents.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblEvents.Location = new System.Drawing.Point(88, 16);
			this.lblEvents.Name = "lblEvents";
			this.lblEvents.Size = new System.Drawing.Size(48, 32);
			this.lblEvents.TabIndex = 2;
			this.lblEvents.Text = "Events [Mev]:";
			// 
			// txtEntry
			// 
			this.txtEntry.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtEntry.Location = new System.Drawing.Point(56, 24);
			this.txtEntry.Name = "txtEntry";
			this.txtEntry.Size = new System.Drawing.Size(24, 20);
			this.txtEntry.TabIndex = 1;
			this.txtEntry.Text = "XX";
			// 
			// lblEntry
			// 
			this.lblEntry.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblEntry.Location = new System.Drawing.Point(8, 23);
			this.lblEntry.Name = "lblEntry";
			this.lblEntry.Size = new System.Drawing.Size(40, 23);
			this.lblEntry.TabIndex = 0;
			this.lblEntry.Text = "Entry No:";
			this.lblEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grpCustom
			// 
			this.grpCustom.Controls.Add(this.txtCustom);
			this.grpCustom.Controls.Add(this.lblCustom);
			this.grpCustom.Location = new System.Drawing.Point(8, 264);
			this.grpCustom.Name = "grpCustom";
			this.grpCustom.Size = new System.Drawing.Size(208, 56);
			this.grpCustom.TabIndex = 11;
			this.grpCustom.TabStop = false;
			this.grpCustom.Text = "Custom";
			// 
			// lblCustom
			// 
			this.lblCustom.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblCustom.Location = new System.Drawing.Point(8, 24);
			this.lblCustom.Name = "lblCustom";
			this.lblCustom.Size = new System.Drawing.Size(72, 16);
			this.lblCustom.TabIndex = 3;
			this.lblCustom.Text = "Command :";
			this.lblCustom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCustom
			// 
			this.txtCustom.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCustom.Location = new System.Drawing.Point(96, 24);
			this.txtCustom.Name = "txtCustom";
			this.txtCustom.TabIndex = 11;
			this.txtCustom.Text = "";
			// 
			// btnAddOk
			// 
			this.btnAddOk.Location = new System.Drawing.Point(136, 328);
			this.btnAddOk.Name = "btnAddOk";
			this.btnAddOk.TabIndex = 12;
			this.btnAddOk.Text = "OK";
			this.btnAddOk.Click += new System.EventHandler(this.btnAddOk_Click);
			// 
			// btnAddCancel
			// 
			this.btnAddCancel.Location = new System.Drawing.Point(56, 328);
			this.btnAddCancel.Name = "btnAddCancel";
			this.btnAddCancel.TabIndex = 13;
			this.btnAddCancel.Text = "Cancel";
			this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
			// 
			// add
			// 
			this.Controls.Add(this.btnAddCancel);
			this.Controls.Add(this.btnAddOk);
			this.Controls.Add(this.grpCustom);
			this.Controls.Add(this.grpRun);
			this.Controls.Add(this.grpTemp);
			this.Controls.Add(this.grpField);
			this.Name = "add";
			this.Size = new System.Drawing.Size(224, 360);
			this.Load += new System.EventHandler(this.add_Load);
			this.grpTemp.ResumeLayout(false);
			this.grpField.ResumeLayout(false);
			this.grpRun.ResumeLayout(false);
			this.grpCustom.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAddCancel_Click(object sender, System.EventArgs e)
		{
			this.Visible = false;
		}

		private void add_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnAddOk_Click(object sender, System.EventArgs e)
		{

		}
	}
}
