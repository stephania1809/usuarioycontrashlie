<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Algerian", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(319, 285)
        Button1.Name = "Button1"
        Button1.Size = New Size(184, 38)
        Button1.TabIndex = 0
        Button1.Text = "acceso"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(319, 139)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(184, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(319, 217)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(184, 27)
        TextBox2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Shelter_PersonalUseOnly", 72F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label1.Location = New Point(61, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(401, 116)
        Label1.TabIndex = 10
        Label1.Text = "Selecciónes"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("PMingLiU-ExtB", 72F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label2.Location = New Point(468, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(274, 120)
        Label2.TabIndex = 11
        Label2.Text = "2024"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("The Blacklist", 19.7999973F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(192, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 47)
        Label3.TabIndex = 12
        Label3.Text = "Usuario"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("The Blacklist", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(165, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 47)
        Label4.TabIndex = 13
        Label4.Text = "Contraseña"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(567, 139)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(187, 232)
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Algerian", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(319, 342)
        Button2.Name = "Button2"
        Button2.Size = New Size(184, 39)
        Button2.TabIndex = 15
        Button2.Text = "Registrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Green
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        ForeColor = Color.Purple
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "votaciones"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
End Class
