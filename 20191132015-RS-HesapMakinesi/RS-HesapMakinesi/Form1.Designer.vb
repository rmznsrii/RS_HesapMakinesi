<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.toplamabtn = New System.Windows.Forms.Button()
        Me.cikarmabtn = New System.Windows.Forms.Button()
        Me.carpmabtn = New System.Windows.Forms.Button()
        Me.bolmebtn = New System.Windows.Forms.Button()
        Me.üsbtn = New System.Windows.Forms.Button()
        Me.modbtn = New System.Windows.Forms.Button()
        Me.temizlebtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1.Sayı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2.Sayı"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sonuç"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 27)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Sayı giriniz..."
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(81, 208)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(114, 27)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "Sayı giriniz..."
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(81, 335)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(114, 27)
        Me.TextBox3.TabIndex = 5
        '
        'toplamabtn
        '
        Me.toplamabtn.Location = New System.Drawing.Point(225, 76)
        Me.toplamabtn.Name = "toplamabtn"
        Me.toplamabtn.Size = New System.Drawing.Size(110, 40)
        Me.toplamabtn.TabIndex = 6
        Me.toplamabtn.Text = "Toplama"
        Me.toplamabtn.UseVisualStyleBackColor = True
        '
        'cikarmabtn
        '
        Me.cikarmabtn.Location = New System.Drawing.Point(358, 76)
        Me.cikarmabtn.Name = "cikarmabtn"
        Me.cikarmabtn.Size = New System.Drawing.Size(110, 40)
        Me.cikarmabtn.TabIndex = 7
        Me.cikarmabtn.Text = "Çıkarma"
        Me.cikarmabtn.UseVisualStyleBackColor = True
        '
        'carpmabtn
        '
        Me.carpmabtn.Location = New System.Drawing.Point(225, 201)
        Me.carpmabtn.Name = "carpmabtn"
        Me.carpmabtn.Size = New System.Drawing.Size(110, 40)
        Me.carpmabtn.TabIndex = 8
        Me.carpmabtn.Text = "Çapma"
        Me.carpmabtn.UseVisualStyleBackColor = True
        '
        'bolmebtn
        '
        Me.bolmebtn.Location = New System.Drawing.Point(358, 201)
        Me.bolmebtn.Name = "bolmebtn"
        Me.bolmebtn.Size = New System.Drawing.Size(110, 40)
        Me.bolmebtn.TabIndex = 9
        Me.bolmebtn.Text = "Bölme"
        Me.bolmebtn.UseVisualStyleBackColor = True
        '
        'üsbtn
        '
        Me.üsbtn.Location = New System.Drawing.Point(225, 328)
        Me.üsbtn.Name = "üsbtn"
        Me.üsbtn.Size = New System.Drawing.Size(110, 40)
        Me.üsbtn.TabIndex = 10
        Me.üsbtn.Text = "Üs Al"
        Me.üsbtn.UseVisualStyleBackColor = True
        '
        'modbtn
        '
        Me.modbtn.Location = New System.Drawing.Point(358, 325)
        Me.modbtn.Name = "modbtn"
        Me.modbtn.Size = New System.Drawing.Size(110, 40)
        Me.modbtn.TabIndex = 11
        Me.modbtn.Text = "Mod Al"
        Me.modbtn.UseVisualStyleBackColor = True
        '
        'temizlebtn
        '
        Me.temizlebtn.Location = New System.Drawing.Point(127, 399)
        Me.temizlebtn.Name = "temizlebtn"
        Me.temizlebtn.Size = New System.Drawing.Size(247, 39)
        Me.temizlebtn.TabIndex = 12
        Me.temizlebtn.Text = "Temizle"
        Me.temizlebtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(493, 450)
        Me.Controls.Add(Me.temizlebtn)
        Me.Controls.Add(Me.modbtn)
        Me.Controls.Add(Me.üsbtn)
        Me.Controls.Add(Me.bolmebtn)
        Me.Controls.Add(Me.carpmabtn)
        Me.Controls.Add(Me.cikarmabtn)
        Me.Controls.Add(Me.toplamabtn)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "RS Hesap Makinesi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents toplamabtn As Button
    Friend WithEvents cikarmabtn As Button
    Friend WithEvents carpmabtn As Button
    Friend WithEvents bolmebtn As Button
    Friend WithEvents üsbtn As Button
    Friend WithEvents modbtn As Button
    Friend WithEvents temizlebtn As Button
End Class
