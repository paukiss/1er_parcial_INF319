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
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.num3 = New System.Windows.Forms.TextBox()
        Me.Ordenar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ord1 = New System.Windows.Forms.Label()
        Me.ord2 = New System.Windows.Forms.Label()
        Me.ord3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(26, 27)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(56, 27)
        Me.num1.TabIndex = 0
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(105, 27)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(56, 27)
        Me.num2.TabIndex = 1
        '
        'num3
        '
        Me.num3.Location = New System.Drawing.Point(185, 27)
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(56, 27)
        Me.num3.TabIndex = 2
        '
        'Ordenar
        '
        Me.Ordenar.Location = New System.Drawing.Point(282, 25)
        Me.Ordenar.Name = "Ordenar"
        Me.Ordenar.Size = New System.Drawing.Size(94, 29)
        Me.Ordenar.TabIndex = 3
        Me.Ordenar.Text = "Ordenar"
        Me.Ordenar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(282, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 30)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Reverse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ord1
        '
        Me.ord1.AutoSize = True
        Me.ord1.Location = New System.Drawing.Point(29, 78)
        Me.ord1.Name = "ord1"
        Me.ord1.Size = New System.Drawing.Size(0, 20)
        Me.ord1.TabIndex = 5
        '
        'ord2
        '
        Me.ord2.AutoSize = True
        Me.ord2.Location = New System.Drawing.Point(105, 78)
        Me.ord2.Name = "ord2"
        Me.ord2.Size = New System.Drawing.Size(0, 20)
        Me.ord2.TabIndex = 6
        '
        'ord3
        '
        Me.ord3.AutoSize = True
        Me.ord3.Location = New System.Drawing.Point(188, 78)
        Me.ord3.Name = "ord3"
        Me.ord3.Size = New System.Drawing.Size(0, 20)
        Me.ord3.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 131)
        Me.Controls.Add(Me.ord3)
        Me.Controls.Add(Me.ord2)
        Me.Controls.Add(Me.ord1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Ordenar)
        Me.Controls.Add(Me.num3)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents num1 As TextBox
    Friend WithEvents num2 As TextBox
    Friend WithEvents num3 As TextBox
    Friend WithEvents Ordenar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ord1 As Label
    Friend WithEvents ord2 As Label
    Friend WithEvents ord3 As Label
End Class
