using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SkinBorderColor
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components;

		public Form1()
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
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Active Skin:";
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(168, 56);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(150, 96);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "groupControl1";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "comboBoxEdit1";
            this.comboBoxEdit1.Location = new System.Drawing.Point(96, 8);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(222, 20);
            this.comboBoxEdit1.TabIndex = 7;
            this.comboBoxEdit1.SelectedValueChanged += new System.EventHandler(this.comboBoxEdit1_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(15, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 32);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.EditValue = "buttonEdit1";
            this.buttonEdit1.Location = new System.Drawing.Point(12, 53);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(136, 20);
            this.buttonEdit1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Border Color:";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(330, 170);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEdit1);
            this.Name = "Form1";
            this.Text = "Get editor\'s border color from the active skin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
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
		private void Form1_Load(object sender, System.EventArgs e) {
			comboBoxEdit1.EditValue = defaultLookAndFeel1.LookAndFeel.SkinName;
			foreach(DevExpress.Skins.SkinContainer cnt in DevExpress.Skins.SkinManager.Default.Skins) {
				comboBoxEdit1.Properties.Items.Add(cnt.SkinName);
			}
		}
		private void comboBoxEdit1_SelectedValueChanged(object sender, System.EventArgs e) {
			defaultLookAndFeel1.LookAndFeel.SkinName = comboBoxEdit1.Text;
			panel1.Refresh();
		}

		public Color GetBorderColor() {
			DevExpress.Skins.Skin currentSkin;
			DevExpress.Skins.SkinElement element;
			string elementName;

			currentSkin = DevExpress.Skins.CommonSkins.GetSkin(defaultLookAndFeel1.LookAndFeel);
			elementName = DevExpress.Skins.CommonSkins.SkinTextBorder;
			element = currentSkin[elementName];

			Color skinBorderColor = element.Border.All;
			return skinBorderColor;
		}
		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
			Color skinBorderColor = GetBorderColor();
			Brush brush = new SolidBrush(skinBorderColor);
			try {
				e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
			}
			finally {
				brush.Dispose();
			}
		}
	}
}
