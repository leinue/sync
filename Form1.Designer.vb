<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Codebox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TestBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Codebox
        '
        Me.Codebox.Location = New System.Drawing.Point(12, 12)
        Me.Codebox.Multiline = True
        Me.Codebox.Name = "Codebox"
        Me.Codebox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Codebox.Size = New System.Drawing.Size(319, 240)
        Me.Codebox.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Compel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TestBox
        '
        Me.TestBox.Location = New System.Drawing.Point(338, 12)
        Me.TestBox.Multiline = True
        Me.TestBox.Name = "TestBox"
        Me.TestBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TestBox.Size = New System.Drawing.Size(224, 369)
        Me.TestBox.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 308)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(316, 73)
        Me.TextBox1.TabIndex = 3
        '
        'ResultBox
        '
        Me.ResultBox.Location = New System.Drawing.Point(18, 387)
        Me.ResultBox.Multiline = True
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ResultBox.Size = New System.Drawing.Size(544, 83)
        Me.ResultBox.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(618, 214)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(572, 12)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(162, 196)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(572, 248)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(162, 222)
        Me.TextBox3.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 473)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TestBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Codebox)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "NewProlog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Codebox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TestBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ResultBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
