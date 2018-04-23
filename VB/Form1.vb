Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace SkinBorderColor
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private label1 As System.Windows.Forms.Label
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents panel1 As System.Windows.Forms.Panel
		Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
		Private label2 As System.Windows.Forms.Label
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.label1 = New System.Windows.Forms.Label()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			Me.label2 = New System.Windows.Forms.Label()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(12, 11)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(72, 16)
			Me.label1.TabIndex = 9
			Me.label1.Text = "Active Skin:"
			' 
			' groupControl1
			' 
			Me.groupControl1.Location = New System.Drawing.Point(168, 56)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(150, 96)
			Me.groupControl1.TabIndex = 8
			Me.groupControl1.Text = "groupControl1"
			' 
			' comboBoxEdit1
			' 
			Me.comboBoxEdit1.EditValue = "comboBoxEdit1"
			Me.comboBoxEdit1.Location = New System.Drawing.Point(96, 8)
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEdit1.Size = New System.Drawing.Size(222, 20)
			Me.comboBoxEdit1.TabIndex = 7
'			Me.comboBoxEdit1.SelectedValueChanged += New System.EventHandler(Me.comboBoxEdit1_SelectedValueChanged);
			' 
			' panel1
			' 
			Me.panel1.Location = New System.Drawing.Point(15, 120)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(136, 32)
			Me.panel1.TabIndex = 6
'			Me.panel1.Paint += New System.Windows.Forms.PaintEventHandler(Me.panel1_Paint);
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.EditValue = "buttonEdit1"
			Me.buttonEdit1.Location = New System.Drawing.Point(12, 53)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit1.Size = New System.Drawing.Size(136, 20)
			Me.buttonEdit1.TabIndex = 5
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(12, 101)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(100, 16)
			Me.label2.TabIndex = 10
			Me.label2.Text = "Border Color:"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(330, 170)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.groupControl1)
			Me.Controls.Add(Me.comboBoxEdit1)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.buttonEdit1)
			Me.Name = "Form1"
			Me.Text = "Get editor's border color from the active skin"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			comboBoxEdit1.EditValue = defaultLookAndFeel1.LookAndFeel.SkinName
			For Each cnt As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
				comboBoxEdit1.Properties.Items.Add(cnt.SkinName)
			Next cnt
		End Sub
		Private Sub comboBoxEdit1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxEdit1.SelectedValueChanged
			defaultLookAndFeel1.LookAndFeel.SkinName = comboBoxEdit1.Text
			panel1.Refresh()
		End Sub

		Public Function GetBorderColor() As Color
			Dim currentSkin As DevExpress.Skins.Skin
			Dim element As DevExpress.Skins.SkinElement
			Dim elementName As String

			currentSkin = DevExpress.Skins.CommonSkins.GetSkin(defaultLookAndFeel1.LookAndFeel)
			elementName = DevExpress.Skins.CommonSkins.SkinTextBorder
			element = currentSkin(elementName)

			Dim skinBorderColor As Color = element.Border.All
			Return skinBorderColor
		End Function
		Private Sub panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panel1.Paint
			Dim skinBorderColor As Color = GetBorderColor()
			Dim brush As Brush = New SolidBrush(skinBorderColor)
			Try
				e.Graphics.FillRectangle(brush, panel1.ClientRectangle)
			Finally
				brush.Dispose()
			End Try
		End Sub
	End Class
End Namespace
