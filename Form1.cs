// Created by Stuart Campbell 1-JUL-2004
// Based on MkScript2 which ran on the excellent OpenVMS 
// Operating System!
//
// Modification History
// 3-AUG-2004 : SIC - Still hacking

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;

namespace mkscript3
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		// My variables...
		public DataSet myDataSet;
		public DataTable myTable;
		public DataRow myRow;
		public DataView myDataView;
		private double totalevents;
		private DataColumn entryColumn;
		private DataColumn tempstartColumn;
		private DataColumn tempstopColumn;
		private DataColumn tempstepColumn;
		private DataColumn fieldstartColumn;
		private DataColumn fieldstopColumn;
		private DataColumn fieldstepColumn;
		private DataColumn customColumn;
		private DataColumn eventsColumn;
		private System.Windows.Forms.Button btnWrite;
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.GroupBox grpTemp;
		private System.Windows.Forms.TextBox txtTempStart;
		private System.Windows.Forms.TextBox txtTempEnd;
		private System.Windows.Forms.TextBox txtTempStep;
		private System.Windows.Forms.Label lblTempStart;
		private System.Windows.Forms.Label lblTempEnd;
		private System.Windows.Forms.Label lblTempStep;
		private System.Windows.Forms.GroupBox grpField;
		private System.Windows.Forms.TextBox txtFieldStart;
		private System.Windows.Forms.TextBox txtFieldEnd;
		private System.Windows.Forms.TextBox txtFieldStep;
		private System.Windows.Forms.Label lblFieldStart;
		private System.Windows.Forms.Label lblFieldEnd;
		private System.Windows.Forms.Label lblFieldStep;
		private System.Windows.Forms.GroupBox grpCustom;
		private System.Windows.Forms.TextBox txtCustom;
		private System.Windows.Forms.Label lblCustom;
		private System.Windows.Forms.Button btnAddCancel;
		private System.Windows.Forms.Button btnAddOk;
		private System.Windows.Forms.GroupBox grpAdd;
		private System.Windows.Forms.GroupBox grpRun;
		private System.Windows.Forms.TextBox txtEvents;
		private System.Windows.Forms.Label lblEvents;
		private System.Windows.Forms.TextBox txtEntry;
		private System.Windows.Forms.Label lblEntry;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.CheckBox gridReadOnly;
		private System.Windows.Forms.Button btnClearScript;
		private System.Windows.Forms.Button btnDeleteEntry;
		private System.Windows.Forms.GroupBox grpCountRate;
		private System.Windows.Forms.Label lblRunRate;
		private System.Windows.Forms.TextBox txtRunRate;
		private System.Windows.Forms.Label lblRunRateUnits;
		private System.Windows.Forms.Label lblTotalEvents;
		private System.Windows.Forms.Label lblEstimatedScriptTime;
		private System.Windows.Forms.Label lblTotalEventsNo;
		private System.Windows.Forms.Label lblEstimatedScriptTimeNo;
		private System.Drawing.Printing.PrintDocument printDocument1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		
			// First we need to create a dataset
			myDataSet = new DataSet();
			// then add a table to store stuff in
			myTable = new DataTable("mkscript");
			myDataSet.Tables.Add(myTable);
			
			// Now lets add some columns to the table
			entryColumn = new DataColumn("entry");
			entryColumn.Caption = "Entry No.";
			entryColumn.DefaultValue = null;
			entryColumn.AllowDBNull = false;
			//entryColumn.Unique = true;
			entryColumn.DataType = typeof(System.Int32);			
			myDataSet.Tables[0].Columns.Add(entryColumn);

			tempstartColumn  = new DataColumn("tempstart");
			tempstartColumn.Caption = "Start Temp";			
			tempstartColumn.DefaultValue = "";
			//tempstartColumn.DataType = typeof(System.Double);
			//tempstartColumn.ColumnName = "Start Temp [K]";
			myDataSet.Tables[0].Columns.Add(tempstartColumn);
			
			// Temperature Stop Column
			tempstopColumn  = new DataColumn("tempstop");
			tempstopColumn.DefaultValue = "";
			myDataSet.Tables[0].Columns.Add(tempstopColumn);
			// Temperature Step Column
			tempstepColumn  = new DataColumn("tempstep");
			tempstepColumn.DefaultValue = "";
			myDataSet.Tables[0].Columns.Add(tempstepColumn);
			
			fieldstartColumn  = new DataColumn("fieldstart");
			fieldstartColumn.DefaultValue = "";
			myDataSet.Tables[0].Columns.Add(fieldstartColumn);
			fieldstopColumn  = new DataColumn("fieldstop");
			fieldstopColumn.DefaultValue = "";
			myDataSet.Tables[0].Columns.Add(fieldstopColumn);
			fieldstepColumn  = new DataColumn("fieldstep");
			fieldstepColumn.DefaultValue = "";
			myDataSet.Tables[0].Columns.Add(fieldstepColumn);

			customColumn = new DataColumn("custom");
			customColumn.DefaultValue = "";
			myDataSet.Tables[0].Columns.Add(customColumn);
			eventsColumn = new DataColumn("events");
			eventsColumn.DefaultValue = "";
			myDataSet.Tables[0].Columns.Add(eventsColumn);

			myDataView = new DataView(myTable);
			//myDataSet.Tables["mkscript"].PrimaryKey = new System.Data.DataColumn[] {entryColumn};

//			dataGrid1.DataSource = myDataSet.Tables[0];
			dataGrid1.DataSource = myDataView;

			// Make grid readonly by default
			dataGrid1.ReadOnly = gridReadOnly.Checked;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.btnWrite = new System.Windows.Forms.Button();
			this.btnRead = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnClearScript = new System.Windows.Forms.Button();
			this.grpTemp = new System.Windows.Forms.GroupBox();
			this.txtTempStart = new System.Windows.Forms.TextBox();
			this.txtTempEnd = new System.Windows.Forms.TextBox();
			this.txtTempStep = new System.Windows.Forms.TextBox();
			this.lblTempStart = new System.Windows.Forms.Label();
			this.lblTempEnd = new System.Windows.Forms.Label();
			this.lblTempStep = new System.Windows.Forms.Label();
			this.grpField = new System.Windows.Forms.GroupBox();
			this.txtFieldStart = new System.Windows.Forms.TextBox();
			this.txtFieldEnd = new System.Windows.Forms.TextBox();
			this.txtFieldStep = new System.Windows.Forms.TextBox();
			this.lblFieldStart = new System.Windows.Forms.Label();
			this.lblFieldEnd = new System.Windows.Forms.Label();
			this.lblFieldStep = new System.Windows.Forms.Label();
			this.grpCustom = new System.Windows.Forms.GroupBox();
			this.txtCustom = new System.Windows.Forms.TextBox();
			this.lblCustom = new System.Windows.Forms.Label();
			this.btnAddCancel = new System.Windows.Forms.Button();
			this.btnAddOk = new System.Windows.Forms.Button();
			this.grpAdd = new System.Windows.Forms.GroupBox();
			this.btnDeleteEntry = new System.Windows.Forms.Button();
			this.grpRun = new System.Windows.Forms.GroupBox();
			this.txtEvents = new System.Windows.Forms.TextBox();
			this.lblEvents = new System.Windows.Forms.Label();
			this.txtEntry = new System.Windows.Forms.TextBox();
			this.lblEntry = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.gridReadOnly = new System.Windows.Forms.CheckBox();
			this.grpCountRate = new System.Windows.Forms.GroupBox();
			this.lblEstimatedScriptTimeNo = new System.Windows.Forms.Label();
			this.lblTotalEventsNo = new System.Windows.Forms.Label();
			this.lblEstimatedScriptTime = new System.Windows.Forms.Label();
			this.lblTotalEvents = new System.Windows.Forms.Label();
			this.lblRunRateUnits = new System.Windows.Forms.Label();
			this.txtRunRate = new System.Windows.Forms.TextBox();
			this.lblRunRate = new System.Windows.Forms.Label();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.groupBox1.SuspendLayout();
			this.grpTemp.SuspendLayout();
			this.grpField.SuspendLayout();
			this.grpCustom.SuspendLayout();
			this.grpAdd.SuspendLayout();
			this.grpRun.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.grpCountRate.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnWrite
			// 
			this.btnWrite.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnWrite.Location = new System.Drawing.Point(88, 24);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.TabIndex = 13;
			this.btnWrite.Text = "Write";
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// btnRead
			// 
			this.btnRead.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnRead.Location = new System.Drawing.Point(8, 24);
			this.btnRead.Name = "btnRead";
			this.btnRead.TabIndex = 12;
			this.btnRead.Text = "Read";
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnHelp);
			this.groupBox1.Controls.Add(this.btnPrint);
			this.groupBox1.Controls.Add(this.btnRead);
			this.groupBox1.Controls.Add(this.btnWrite);
			this.groupBox1.Controls.Add(this.btnClearScript);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 96);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "MkScript";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// btnHelp
			// 
			this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnHelp.Location = new System.Drawing.Point(88, 56);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.TabIndex = 15;
			this.btnHelp.Text = "Help";
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnPrint.Location = new System.Drawing.Point(8, 56);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.TabIndex = 14;
			this.btnPrint.Text = "Print";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnClearScript
			// 
			this.btnClearScript.Location = new System.Drawing.Point(168, 24);
			this.btnClearScript.Name = "btnClearScript";
			this.btnClearScript.Size = new System.Drawing.Size(75, 24);
			this.btnClearScript.TabIndex = 19;
			this.btnClearScript.Text = "Clear Script";
			this.btnClearScript.Click += new System.EventHandler(this.btnClearScript_Click);
			// 
			// grpTemp
			// 
			this.grpTemp.Controls.Add(this.txtTempStart);
			this.grpTemp.Controls.Add(this.txtTempEnd);
			this.grpTemp.Controls.Add(this.txtTempStep);
			this.grpTemp.Controls.Add(this.lblTempStart);
			this.grpTemp.Controls.Add(this.lblTempEnd);
			this.grpTemp.Controls.Add(this.lblTempStep);
			this.grpTemp.Location = new System.Drawing.Point(8, 88);
			this.grpTemp.Name = "grpTemp";
			this.grpTemp.Size = new System.Drawing.Size(208, 96);
			this.grpTemp.TabIndex = 2002;
			this.grpTemp.TabStop = false;
			this.grpTemp.Text = "Temperature";
			// 
			// txtTempStart
			// 
			this.txtTempStart.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTempStart.Location = new System.Drawing.Point(96, 16);
			this.txtTempStart.Name = "txtTempStart";
			this.txtTempStart.TabIndex = 3;
			this.txtTempStart.Text = "";
			// 
			// txtTempEnd
			// 
			this.txtTempEnd.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTempEnd.Location = new System.Drawing.Point(96, 40);
			this.txtTempEnd.Name = "txtTempEnd";
			this.txtTempEnd.TabIndex = 4;
			this.txtTempEnd.Text = "";
			// 
			// txtTempStep
			// 
			this.txtTempStep.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTempStep.Location = new System.Drawing.Point(96, 64);
			this.txtTempStep.Name = "txtTempStep";
			this.txtTempStep.TabIndex = 5;
			this.txtTempStep.Text = "";
			// 
			// lblTempStart
			// 
			this.lblTempStart.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTempStart.Location = new System.Drawing.Point(16, 18);
			this.lblTempStart.Name = "lblTempStart";
			this.lblTempStart.Size = new System.Drawing.Size(56, 16);
			this.lblTempStart.TabIndex = 2003;
			this.lblTempStart.Text = "Start :";
			this.lblTempStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTempEnd
			// 
			this.lblTempEnd.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTempEnd.Location = new System.Drawing.Point(16, 42);
			this.lblTempEnd.Name = "lblTempEnd";
			this.lblTempEnd.Size = new System.Drawing.Size(56, 16);
			this.lblTempEnd.TabIndex = 2004;
			this.lblTempEnd.Text = "End :";
			this.lblTempEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTempStep
			// 
			this.lblTempStep.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTempStep.Location = new System.Drawing.Point(16, 66);
			this.lblTempStep.Name = "lblTempStep";
			this.lblTempStep.Size = new System.Drawing.Size(56, 16);
			this.lblTempStep.TabIndex = 2005;
			this.lblTempStep.Text = "Step :";
			this.lblTempStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grpField
			// 
			this.grpField.Controls.Add(this.txtFieldStart);
			this.grpField.Controls.Add(this.txtFieldEnd);
			this.grpField.Controls.Add(this.txtFieldStep);
			this.grpField.Controls.Add(this.lblFieldStart);
			this.grpField.Controls.Add(this.lblFieldEnd);
			this.grpField.Controls.Add(this.lblFieldStep);
			this.grpField.Location = new System.Drawing.Point(8, 192);
			this.grpField.Name = "grpField";
			this.grpField.Size = new System.Drawing.Size(208, 96);
			this.grpField.TabIndex = 2006;
			this.grpField.TabStop = false;
			this.grpField.Text = "Field";
			// 
			// txtFieldStart
			// 
			this.txtFieldStart.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtFieldStart.Location = new System.Drawing.Point(96, 16);
			this.txtFieldStart.Name = "txtFieldStart";
			this.txtFieldStart.TabIndex = 6;
			this.txtFieldStart.Text = "";
			// 
			// txtFieldEnd
			// 
			this.txtFieldEnd.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtFieldEnd.Location = new System.Drawing.Point(96, 40);
			this.txtFieldEnd.Name = "txtFieldEnd";
			this.txtFieldEnd.TabIndex = 7;
			this.txtFieldEnd.Text = "";
			// 
			// txtFieldStep
			// 
			this.txtFieldStep.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtFieldStep.Location = new System.Drawing.Point(96, 64);
			this.txtFieldStep.Name = "txtFieldStep";
			this.txtFieldStep.TabIndex = 8;
			this.txtFieldStep.Text = "";
			// 
			// lblFieldStart
			// 
			this.lblFieldStart.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblFieldStart.Location = new System.Drawing.Point(16, 18);
			this.lblFieldStart.Name = "lblFieldStart";
			this.lblFieldStart.Size = new System.Drawing.Size(56, 16);
			this.lblFieldStart.TabIndex = 2007;
			this.lblFieldStart.Text = "Start :";
			this.lblFieldStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblFieldEnd
			// 
			this.lblFieldEnd.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblFieldEnd.Location = new System.Drawing.Point(16, 42);
			this.lblFieldEnd.Name = "lblFieldEnd";
			this.lblFieldEnd.Size = new System.Drawing.Size(56, 16);
			this.lblFieldEnd.TabIndex = 2008;
			this.lblFieldEnd.Text = "End :";
			this.lblFieldEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblFieldStep
			// 
			this.lblFieldStep.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblFieldStep.Location = new System.Drawing.Point(16, 66);
			this.lblFieldStep.Name = "lblFieldStep";
			this.lblFieldStep.Size = new System.Drawing.Size(56, 16);
			this.lblFieldStep.TabIndex = 2009;
			this.lblFieldStep.Text = "Step :";
			this.lblFieldStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grpCustom
			// 
			this.grpCustom.Controls.Add(this.txtCustom);
			this.grpCustom.Controls.Add(this.lblCustom);
			this.grpCustom.Location = new System.Drawing.Point(8, 296);
			this.grpCustom.Name = "grpCustom";
			this.grpCustom.Size = new System.Drawing.Size(208, 56);
			this.grpCustom.TabIndex = 2010;
			this.grpCustom.TabStop = false;
			this.grpCustom.Text = "Custom";
			// 
			// txtCustom
			// 
			this.txtCustom.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCustom.Location = new System.Drawing.Point(96, 24);
			this.txtCustom.Name = "txtCustom";
			this.txtCustom.TabIndex = 9;
			this.txtCustom.Text = "";
			// 
			// lblCustom
			// 
			this.lblCustom.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblCustom.Location = new System.Drawing.Point(8, 24);
			this.lblCustom.Name = "lblCustom";
			this.lblCustom.Size = new System.Drawing.Size(72, 16);
			this.lblCustom.TabIndex = 2011;
			this.lblCustom.Text = "Command :";
			this.lblCustom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAddCancel
			// 
			this.btnAddCancel.Location = new System.Drawing.Point(88, 360);
			this.btnAddCancel.Name = "btnAddCancel";
			this.btnAddCancel.TabIndex = 10;
			this.btnAddCancel.Text = "Clear";
			this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
			// 
			// btnAddOk
			// 
			this.btnAddOk.Location = new System.Drawing.Point(8, 360);
			this.btnAddOk.Name = "btnAddOk";
			this.btnAddOk.TabIndex = 11;
			this.btnAddOk.Text = "Add";
			this.btnAddOk.Click += new System.EventHandler(this.btnAddOk_Click);
			// 
			// grpAdd
			// 
			this.grpAdd.Controls.Add(this.btnDeleteEntry);
			this.grpAdd.Controls.Add(this.grpRun);
			this.grpAdd.Controls.Add(this.grpTemp);
			this.grpAdd.Controls.Add(this.grpField);
			this.grpAdd.Controls.Add(this.grpCustom);
			this.grpAdd.Controls.Add(this.btnAddCancel);
			this.grpAdd.Controls.Add(this.btnAddOk);
			this.grpAdd.Location = new System.Drawing.Point(8, 120);
			this.grpAdd.Name = "grpAdd";
			this.grpAdd.Size = new System.Drawing.Size(256, 400);
			this.grpAdd.TabIndex = 16;
			this.grpAdd.TabStop = false;
			this.grpAdd.Text = "Details";
			// 
			// btnDeleteEntry
			// 
			this.btnDeleteEntry.Location = new System.Drawing.Point(168, 360);
			this.btnDeleteEntry.Name = "btnDeleteEntry";
			this.btnDeleteEntry.TabIndex = 2011;
			this.btnDeleteEntry.Text = "Delete Entry";
			this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
			// 
			// grpRun
			// 
			this.grpRun.Controls.Add(this.txtEvents);
			this.grpRun.Controls.Add(this.lblEvents);
			this.grpRun.Controls.Add(this.txtEntry);
			this.grpRun.Controls.Add(this.lblEntry);
			this.grpRun.Location = new System.Drawing.Point(8, 24);
			this.grpRun.Name = "grpRun";
			this.grpRun.Size = new System.Drawing.Size(208, 56);
			this.grpRun.TabIndex = 11;
			this.grpRun.TabStop = false;
			this.grpRun.Text = "General";
			// 
			// txtEvents
			// 
			this.txtEvents.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtEvents.Location = new System.Drawing.Point(136, 24);
			this.txtEvents.Name = "txtEvents";
			this.txtEvents.Size = new System.Drawing.Size(64, 20);
			this.txtEvents.TabIndex = 2;
			this.txtEvents.Text = "";
			// 
			// lblEvents
			// 
			this.lblEvents.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblEvents.Location = new System.Drawing.Point(88, 16);
			this.lblEvents.Name = "lblEvents";
			this.lblEvents.Size = new System.Drawing.Size(48, 32);
			this.lblEvents.TabIndex = 2001;
			this.lblEvents.Text = "Events [Mev]:";
			// 
			// txtEntry
			// 
			this.txtEntry.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtEntry.Location = new System.Drawing.Point(56, 24);
			this.txtEntry.MaxLength = 2;
			this.txtEntry.Name = "txtEntry";
			this.txtEntry.Size = new System.Drawing.Size(24, 20);
			this.txtEntry.TabIndex = 1;
			this.txtEntry.Text = "1";
			this.txtEntry.WordWrap = false;
			// 
			// lblEntry
			// 
			this.lblEntry.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblEntry.Location = new System.Drawing.Point(8, 23);
			this.lblEntry.Name = "lblEntry";
			this.lblEntry.Size = new System.Drawing.Size(40, 23);
			this.lblEntry.TabIndex = 2000;
			this.lblEntry.Text = "Entry No:";
			this.lblEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dataGrid1
			// 
			this.dataGrid1.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dataGrid1.BackColor = System.Drawing.Color.GhostWhite;
			this.dataGrid1.BackgroundColor = System.Drawing.Color.Lavender;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.RoyalBlue;
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.White;
			this.dataGrid1.CaptionText = "Script Details";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.FlatMode = true;
			this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8F);
			this.dataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dataGrid1.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dataGrid1.LinkColor = System.Drawing.Color.Teal;
			this.dataGrid1.Location = new System.Drawing.Point(280, 24);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Teal;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dataGrid1.Size = new System.Drawing.Size(776, 560);
			this.dataGrid1.TabIndex = 17;
			this.dataGrid1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGrid1_onPaint);
			// 
			// gridReadOnly
			// 
			this.gridReadOnly.Checked = true;
			this.gridReadOnly.CheckState = System.Windows.Forms.CheckState.Checked;
			this.gridReadOnly.Location = new System.Drawing.Point(912, 592);
			this.gridReadOnly.Name = "gridReadOnly";
			this.gridReadOnly.Size = new System.Drawing.Size(144, 24);
			this.gridReadOnly.TabIndex = 18;
			this.gridReadOnly.Text = "Read Only Script Table";
			this.gridReadOnly.CheckedChanged += new System.EventHandler(this.gridReadOnly_CheckedChanged);
			// 
			// grpCountRate
			// 
			this.grpCountRate.Controls.Add(this.lblEstimatedScriptTimeNo);
			this.grpCountRate.Controls.Add(this.lblTotalEventsNo);
			this.grpCountRate.Controls.Add(this.lblEstimatedScriptTime);
			this.grpCountRate.Controls.Add(this.lblTotalEvents);
			this.grpCountRate.Controls.Add(this.lblRunRateUnits);
			this.grpCountRate.Controls.Add(this.txtRunRate);
			this.grpCountRate.Controls.Add(this.lblRunRate);
			this.grpCountRate.Location = new System.Drawing.Point(8, 520);
			this.grpCountRate.Name = "grpCountRate";
			this.grpCountRate.Size = new System.Drawing.Size(256, 88);
			this.grpCountRate.TabIndex = 19;
			this.grpCountRate.TabStop = false;
			this.grpCountRate.Text = "Script Run Time Info";
			// 
			// lblEstimatedScriptTimeNo
			// 
			this.lblEstimatedScriptTimeNo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblEstimatedScriptTimeNo.Location = new System.Drawing.Point(184, 56);
			this.lblEstimatedScriptTimeNo.Name = "lblEstimatedScriptTimeNo";
			this.lblEstimatedScriptTimeNo.Size = new System.Drawing.Size(64, 23);
			this.lblEstimatedScriptTimeNo.TabIndex = 6;
			this.lblEstimatedScriptTimeNo.Text = "??";
			this.lblEstimatedScriptTimeNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTotalEventsNo
			// 
			this.lblTotalEventsNo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTotalEventsNo.Location = new System.Drawing.Point(200, 40);
			this.lblTotalEventsNo.Name = "lblTotalEventsNo";
			this.lblTotalEventsNo.Size = new System.Drawing.Size(48, 16);
			this.lblTotalEventsNo.TabIndex = 5;
			this.lblTotalEventsNo.Text = "??";
			this.lblTotalEventsNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEstimatedScriptTime
			// 
			this.lblEstimatedScriptTime.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblEstimatedScriptTime.Location = new System.Drawing.Point(8, 56);
			this.lblEstimatedScriptTime.Name = "lblEstimatedScriptTime";
			this.lblEstimatedScriptTime.Size = new System.Drawing.Size(176, 23);
			this.lblEstimatedScriptTime.TabIndex = 4;
			this.lblEstimatedScriptTime.Text = "Est. length of script is";
			this.lblEstimatedScriptTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTotalEvents
			// 
			this.lblTotalEvents.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTotalEvents.Location = new System.Drawing.Point(8, 40);
			this.lblTotalEvents.Name = "lblTotalEvents";
			this.lblTotalEvents.Size = new System.Drawing.Size(184, 16);
			this.lblTotalEvents.TabIndex = 3;
			this.lblTotalEvents.Text = "Total Mevents in script is";
			this.lblTotalEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRunRateUnits
			// 
			this.lblRunRateUnits.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblRunRateUnits.Location = new System.Drawing.Point(200, 16);
			this.lblRunRateUnits.Name = "lblRunRateUnits";
			this.lblRunRateUnits.Size = new System.Drawing.Size(48, 23);
			this.lblRunRateUnits.TabIndex = 2;
			this.lblRunRateUnits.Text = "Mev/hr";
			this.lblRunRateUnits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRunRate
			// 
			this.txtRunRate.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtRunRate.Location = new System.Drawing.Point(152, 16);
			this.txtRunRate.Name = "txtRunRate";
			this.txtRunRate.Size = new System.Drawing.Size(40, 20);
			this.txtRunRate.TabIndex = 1;
			this.txtRunRate.Text = "55";
			// 
			// lblRunRate
			// 
			this.lblRunRate.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblRunRate.Location = new System.Drawing.Point(8, 16);
			this.lblRunRate.Name = "lblRunRate";
			this.lblRunRate.Size = new System.Drawing.Size(136, 23);
			this.lblRunRate.TabIndex = 0;
			this.lblRunRate.Text = "Current Count Rate:";
			this.lblRunRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(1064, 618);
			this.Controls.Add(this.grpCountRate);
			this.Controls.Add(this.gridReadOnly);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.grpAdd);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "MkScript3";
			this.groupBox1.ResumeLayout(false);
			this.grpTemp.ResumeLayout(false);
			this.grpField.ResumeLayout(false);
			this.grpCustom.ResumeLayout(false);
			this.grpAdd.ResumeLayout(false);
			this.grpRun.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.grpCountRate.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}
		

		/// <summary>
		/// Quit MkScript.  This button has been deleted!
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnQuit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		/// <summary>
		/// Add a new entry to script. This button has been deleted!
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			//myScript.a = 9.999F;
			// Add a new entry to script
			//AddStep addstep = new AddStep(myScript);
			//addstep.ShowDialog();

			// Make all the 'add step' relevant parts visible
			grpAdd.Visible = true;


		}

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			// Print the script
			printDocument1.Print();
			MessageBox.Show("Sorry! This feature is currently not written!");
		}


		private void btnHelp_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Don't PANIC!...yet!");
			Help.ShowHelp(this,@"c:\mkscript_sic.htm");
		}
		
		/// <summary>
		/// Returns the script command to set the temperature to a value of 'val'.
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		private string printSetTemp(string val)
		{
			return "SETLABEL/T TEMP="+val+";\r\nSETTEMP/WAIT TEMP="+val;
		}

		/// <summary>
		/// Returns the script command to set the field to a value of 'val'.
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		private string printSetField(string val)
		{
			return "SETLABEL/F FIELD="+val+";\r\nSETMAG/WAIT FIELD="+val;
		}

		private string printWaitforEvents(string events)
		{
			totalevents += Convert.ToDouble(events);
			return "WAITFOR events="+events;
		}

		/// <summary>
		/// This routine parses the stored entries and generates a string 
		/// that contains all the GCL code.
		/// </summary>
		/// <returns>String</returns>
		private String generate_gcl()
		{
			// definitions
			String myGCL = "";

			int sicEntry;
			string tempstart;
			string sicEvents, sicCustom;
			string  tempstop, tempstep;
			string fieldstart, fieldstop, fieldstep;
			bool temppresent=false;
			bool fieldpresent=false;

			myGCL += "PROCEDURE runscript;\r\n";

			// Declare GENIE variables
			myGCL += "LOCAL i j myTemp myField;\r\n";
			
			totalevents = 0;

			try
			{

				// Get this row from dataset
				foreach(DataRow myRow in myTable.Select("entry > 0","entry"))
				{
					Debug.WriteLine((string)myRow["tempstart"].ToString());
				
					//sicEntry = ((string)myRow["entry"]).Trim();
					sicEntry = (int)myRow["entry"];
					//tempstart = (double)myRow["tempstart"];
					tempstart = ((string)myRow["tempstart"]).Trim();
					tempstop = ((string)myRow["tempstop"]).Trim();
					tempstep = ((string)myRow["tempstep"]).Trim();
					fieldstart = ((string)myRow["fieldstart"]).Trim();
					fieldstop = ((string)myRow["fieldstop"]).Trim();
					fieldstep = ((string)myRow["fieldstep"]).Trim();

					sicCustom = ((string)myRow["custom"]).Trim();
					sicEvents = ((string)myRow["events"]).Trim();

					//int int_events = Convert.ToInt32(sicEvents);

					// Write a comment field for the current entry.
					myGCL += "#\r\n";
					myGCL += "# MkScript3 entry number "+sicEntry+"\r\n";

					// Write out the GCL code 
				
					// Custom Command...
					// This is printed first within the script because there was some discussion
					// about this being used within another entry as a 'pre-entry' script in 
					// order to set things up.  By putting it first in the script, we can 
					// give this functionality without any modification.
					if (sicCustom.Length>0 && sicCustom != "KEEP")
					{
						myGCL += sicCustom + "\r\n";
					}
				
					// LOOP OVER T
					if (tempstart != "")
					{
						double t_start = Convert.ToDouble(tempstart);
						temppresent = true;
						fieldpresent = false;
						if (tempstop != "" && tempstep != "")
						{
							double t_stop = Convert.ToDouble(tempstop);
							double t_step = Convert.ToDouble(tempstep);
							int t_nsteps = (int)((t_stop - t_start) / t_step);

							// Temperate Range
							myGCL += "LOOP i FROM 1 TO " + (++t_nsteps).ToString() + ";\r\n";
			
							// Set Temp first,
							myGCL += "  myTemp = "+t_start.ToString()+" + (i-1)*"+t_step.ToString()+";\r\n";
							
							//myGCL += "printin myTemp\r\n"; // Debug Statement

							myGCL += "  "+printSetTemp("myTemp")+";\r\n";

							// Now look at FIELD...
							if (fieldstart != "")
							{
								double f_start = Convert.ToDouble(fieldstart);
								fieldpresent = true;
								if (fieldstop != "" && fieldstep != "")
								{
									double f_stop = Convert.ToDouble(fieldstop);
									double f_step = Convert.ToDouble(fieldstep);
									int f_nsteps = (int)((f_stop - f_start) / f_step);

									// Field Range
									myGCL += "  LOOP j FROM 1 TO " + (++f_nsteps).ToString() + ";\r\n";
                                
									myGCL += "    myField = "+f_start.ToString()+" + (j-1)*"+f_step.ToString()+";\r\n";
									myGCL += "    "+printSetField("myField")+";\r\n";
									myGCL += "    BEGIN/QUIET;\r\n";
									myGCL += "    "+printWaitforEvents(sicEvents)+";\r\n";
									myGCL += "    END/QUIET;\r\n";
								
									myGCL += "  ENDLOOP;\r\n";
								} 
								else
								{
									// If not FIELDSTOP define then assume a single temperature
									myGCL += "  "+printSetField(fieldstart)+";\r\n";
									myGCL += "  BEGIN/QUIET;\r\n";
									myGCL += "  "+printWaitforEvents(sicEvents)+";\r\n";
									myGCL += "  END/QUIET;\r\n";
								}
							} 
							if (!fieldpresent)
							{
								myGCL += "  BEGIN/QUIET;\r\n";
								myGCL += "  "+printWaitforEvents(sicEvents)+";\r\n";
								myGCL += "  END/QUIET;\r\n";
							}


							myGCL += "ENDLOOP;\r\n";
						} 
						else
						{
							// If not TEMPSTOP define then assume a single temperature
							myGCL += printSetTemp(tempstart)+";\r\n";

							// LOOP OVER FIELD
							if (fieldstart != "")
							{
								double f_start = Convert.ToDouble(fieldstart);
								fieldpresent = true;
								if (fieldstop != "" && fieldstep != "")
								{
									double f_stop = Convert.ToDouble(fieldstop);
									double f_step = Convert.ToDouble(fieldstep);
									int f_nsteps = (int)((f_stop - f_start) / f_step);

									// Field Range
									myGCL += "LOOP j FROM 1 TO " + (++f_nsteps).ToString() + ";\r\n";
                                
									myGCL += "  myField = "+f_start.ToString()+" + (j-1)*"+f_step.ToString()+";\r\n";
									myGCL += "  "+printSetField("myField")+";\r\n";
									myGCL += "  BEGIN/QUIET;\r\n";
									myGCL += "  "+printWaitforEvents(sicEvents)+";\r\n";
									myGCL += "  END/QUIET;\r\n";
								
									myGCL += "ENDLOOP;\r\n";
								} 
								else
								{
									// If not FIELDSTOP define then assume a single temperature
									myGCL += printSetField(fieldstart)+";\r\n";
									myGCL += "BEGIN/QUIET;\r\n";
									myGCL += printWaitforEvents(sicEvents)+";\r\n";
									myGCL += "END/QUIET;\r\n";
								}
							} 
							if (!fieldpresent)
							{
								myGCL += "BEGIN/QUIET;\r\n";
								myGCL += printWaitforEvents(sicEvents)+";\r\n";
								myGCL += "END/QUIET;\r\n";
							}
						} 	 
					} 
					else
					{
						// No temperature - so we just check for field.
						if (fieldstart != "")
						{
							double f_start = Convert.ToDouble(fieldstart);
							fieldpresent = true;
							if (fieldstop != "" && fieldstep != "")
							{
								double f_stop = Convert.ToDouble(fieldstop);
								double f_step = Convert.ToDouble(fieldstep);
								int f_nsteps = (int)((f_stop - f_start) / f_step);

								// Field Range
								myGCL += "LOOP j FROM 1 TO " + (++f_nsteps).ToString() + ";\r\n";
                                
								myGCL += "  myField = "+f_start.ToString()+" + (j-1)*"+f_step.ToString()+";\r\n";
								myGCL += "  "+printSetField("myField")+";\r\n";
								myGCL += "  BEGIN/QUIET;\r\n";
								myGCL += "  "+printWaitforEvents(sicEvents)+";\r\n";
								myGCL += "  END/QUIET;\r\n";
								
								myGCL += "ENDLOOP;\r\n";
							} 
							else
							{
								// If not FIELDSTOP define then assume a single temperature
								myGCL += printSetField(fieldstart)+";\r\n";
								myGCL += "BEGIN/QUIET;\r\n";
								myGCL += printWaitforEvents(sicEvents)+";\r\n";
								myGCL += "END/QUIET;\r\n";
							}
						} 
					}

					if (!temppresent && !fieldpresent)
					{
						// Only write waitfor events.
						if (sicCustom != "KEEP")
						{
							myGCL += "BEGIN/QUIET;\r\n";
						}
						myGCL += printWaitforEvents(sicEvents)+";\r\n";
						myGCL += "END/QUIET;\r\n";
					}

				}

				myGCL += "ENDPROCEDURE;\r\n";
			
				Debug.WriteLine("Total Events = " + totalevents.ToString());
				
			}
			catch (Exception except)
			{
				/*
				MessageBox.Show("Error Generating Script - Please check your script!"+except.Message,
					"Are you being silly?",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
					*/
			}
			// return the GCL code string
				return(myGCL);
		}

		private string sic_make_mkscriptfile()
		{
			string outText;

			// Write some version info...
			outText = "# " + PrintVersion() + "\r\n";
			outText += "# ** Don't delete this header, MkScript depends on it\r\n";
						
			outText += "#\r\n";	// !  'Logging ON  Scan' comment line

			// A crap way of counting the number of entries! But it works so there!
			int nrows=0;
			foreach(DataRow myRow in myDataSet.Tables["mkscript"].Rows)
			{
				nrows++;
			}

			outText += "# " + nrows.ToString() + " entries\r\n";
			outText += "#\tTEMP1\tTEMP2\t-STEP-\tFIELD1\tFIELD2\t-STEP-\tCUSTOM\tEVENTS\r\n";

			// Write a line for each entry..
			foreach(DataRow myRow in myTable.Select("entry > 0","entry"))
			{
				outText += "#";
				foreach(DataColumn myCol in myTable.Columns)
				{
					outText += "\t"+myRow[myCol].ToString();
				}
				outText += "\r\n";  // add a CR/LF
			}

			// End of header block
			outText += "# ** End of MkScript header\r\n";

			// Now lets go and generate the actual script!
			outText += generate_gcl();
			outText += "\r\n";

			return outText;
		}

		private void btnWrite_Click_broken(object sender, System.EventArgs e)
		{
			GetFileName getfilename = new GetFileName();
			if (getfilename.ShowDialog() == DialogResult.OK)
			{

				Debug.WriteLine("Filename = " + getfilename.FileName);
			}
		}

		/// <summary>
		/// Old procedure that uses the Windows File Open/Save Dialog box
		/// Removed by request of Muon people in favour of a plain text dialog
		/// to enter the filename.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnWrite_Click(object sender, System.EventArgs e)
		{

			Stream myStream;
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			string outText;

			saveFileDialog1.Filter = "GCL script files (*.gcl)|*.gcl";
			saveFileDialog1.InitialDirectory = "u:\\";

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if ((myStream = saveFileDialog1.OpenFile()) != null)
				{
					// Code to write file
					StreamWriter myWriter = new StreamWriter(myStream);
					
					outText = sic_make_mkscriptfile();

					// Write the text to the file...
					myWriter.Write(outText);

					// clean up...
					myWriter.Flush();
					myStream.Flush();
					myWriter.Close();
					myStream.Close();
				}
			}
		}

		public String PrintVersion()
		{
			float version = 7.0F;
			string name = "MKSCRIPT";

			return "'"+name+"', 'vers "+version.ToString()+"'";
		}


		private void btnRead_Click(object sender, System.EventArgs e)
		{
			// read old script from file
/*			try
			{
*/				Stream myStream;
				OpenFileDialog openFileDialog1 = new OpenFileDialog();

				openFileDialog1.Filter = "GCL script files (*.gcl)|*.gcl";

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if ((myStream = openFileDialog1.OpenFile()) != null)
				{
					StreamReader myReader = new StreamReader(myStream);

					// Read contents of file.
					string myString;
					int myLines;

					myDataSet.Tables["mkscript"].Clear();

					myReader.ReadLine(); // MKSCRIPT version line
					myReader.ReadLine(); // "** Don't delete this header etc..." line
					myReader.ReadLine(); // 'Logging ON  Scan'

					myString = myReader.ReadLine();
					myLines = Convert.ToInt16(myString.Split(char.Parse(" "))[1]);
					
					myReader.ReadLine(); // Column headings
					for (int counter = 0; counter < myLines; counter++)
					{
						myString = myReader.ReadLine();
						myString = myString.Remove(0,2);
//						string[] myStringArr = myString.Split(char.Parse("\t"));
						myDataSet.Tables["mkscript"].Rows.Add(myString.Split(char.Parse("\t")));
					}

					myReader.Close();
					myStream.Close();
				}
			}
				

/*
			}
			catch (Exception mye2)
			{
				MessageBox.Show(mye2.Message);
			{
			*/
		}


		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			// delete an entry from script
			//MessageBox.Show();
		}


		private void btnUndo_Click(object sender, System.EventArgs e)
		{
			// undo last change to script
		}


		private void btnT20_Click(object sender, System.EventArgs e)
		{
			// 20G calibration
		}

		private void add1_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnAddCancel_Click(object sender, System.EventArgs e)
		{
			// Clear all fields in add form
			txtEntry.Text = "";
			txtTempStart.Text = "";
			txtTempEnd.Text = "";
			txtTempStep.Text = "";
			txtFieldStart.Text = "";
			txtFieldEnd.Text = "";
			txtFieldStep.Text = "";
			txtCustom.Text = "";
			txtEvents.Text = "";
			

			// make add form invisible
			//grpAdd.Visible = false;
		}

		private void btnAddOk_Click(object sender, System.EventArgs e)
		{
			try
			{
				bool increment = false;	
				foreach(DataRow myRow2 in myDataSet.Tables["mkscript"].Rows)
				{
					if(Convert.ToInt32(txtEntry.Text) == (int)myRow2["entry"])
					{
						increment = true;
					}
				}

				foreach(DataRow myRow2 in myDataSet.Tables["mkscript"].Rows)
				{
					if (increment == true)
					{
						if((int)Convert.ToInt32(txtEntry.Text) <= (int)myRow2["entry"])
						{
							int temp = (int)myRow2["entry"];
							myRow2["entry"] = ++temp;
						}
					}
				}

				// now add this row to the dataset
				// Create a new row for the entry
				myRow = myDataSet.Tables[0].NewRow();

				// populate the row
				myRow[0] = Convert.ToInt32(txtEntry.Text);
				myRow[1] = txtTempStart.Text;
				myRow[2] = txtTempEnd.Text;
				myRow[3] = txtTempStep.Text;
				myRow[4] = txtFieldStart.Text;
				myRow[5] = txtFieldEnd.Text;
				myRow[6] = txtFieldStep.Text;
				myRow[7] = txtCustom.Text;
				myRow[8] = txtEvents.Text;

				myDataSet.Tables[0].Rows.Add(myRow);
				myDataView.Sort = "entry";

				// Calculate the highest entry number and set the default entry number to be
				// one higher.
				int maxEntry=1;
				foreach(DataRow myRow2 in myDataSet.Tables["mkscript"].Rows)
				{

					/*string strEntry = (string)myRow2["entry"];
					if (strEntry != "")
					{
						maxEntry = Math.Max(maxEntry, Convert.ToInt32(strEntry));
					}*/
					maxEntry = Math.Max(maxEntry, (int)myRow2["entry"]);
				}
				maxEntry++;
				txtEntry.Text = maxEntry.ToString();
				txtEntry.Refresh();
				Debug.WriteLine("MaxEntry = " + maxEntry.ToString());

				updateEvents();
			}
			catch(Exception mye)
			{
				MessageBox.Show(mye.Message);
			}
		}

		private void updateEvents()
		{
			string tmp = generate_gcl();
			lblTotalEventsNo.Text = Math.Round(totalevents,3).ToString();
			double time = totalevents / Convert.ToDouble(txtRunRate.Text);
			int hours = (int)Math.Floor(time);
			int minutes = (int)Math.Floor((time-hours)*60);
			lblEstimatedScriptTimeNo.Text = hours.ToString()+"hrs "+minutes.ToString()+"mins";
		}

		private void gridReadOnly_CheckedChanged(object sender, System.EventArgs e)
		{
			if(!gridReadOnly.Checked)
			{
				MessageBox.Show("Warning - Please be careful!");
			}

			dataGrid1.ReadOnly = gridReadOnly.Checked;

		}

		private void btnClearScript_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Are you Sure ?","Are you Sure ?",MessageBoxButtons.YesNo,
				MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{

				myDataSet.Clear();
				txtEntry.Text = "1";
			}
		}

		private void btnDeleteEntry_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Are you Sure ?","Are you Sure ?",MessageBoxButtons.YesNo,
				MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{


					foreach(DataRow myRow2 in myDataSet.Tables["mkscript"].Rows)
					{
						if(Convert.ToInt32(txtEntry.Text) == (int)myRow2["entry"])
						{
							myRow2.Delete();
							break;
						}
					}

				//myDataSet.Tables["mkscript"].Rows.Find(txtEntry.Text);
			}
			updateEvents();
		}

		private void dataGrid1_onPaint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			updateEvents();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString(generate_gcl(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, 10, 10);
		}
	}
}
