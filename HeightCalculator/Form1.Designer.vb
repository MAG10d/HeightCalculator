<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHeightCalculator
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.btnCalculet = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblResultText = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("新細明體", 24.0!)
        Me.lblHeight.Location = New System.Drawing.Point(21, 21)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(239, 32)
        Me.lblHeight.TabIndex = 0
        Me.lblHeight.Text = "輸入你的身高："
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("新細明體", 24.0!)
        Me.txtHeight.Location = New System.Drawing.Point(266, 12)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 46)
        Me.txtHeight.TabIndex = 1
        '
        'btnCalculet
        '
        Me.btnCalculet.Location = New System.Drawing.Point(85, 85)
        Me.btnCalculet.Name = "btnCalculet"
        Me.btnCalculet.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculet.TabIndex = 2
        Me.btnCalculet.Text = "計算"
        Me.btnCalculet.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(225, 85)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "重置"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblResultText
        '
        Me.lblResultText.AutoSize = True
        Me.lblResultText.Location = New System.Drawing.Point(12, 123)
        Me.lblResultText.Name = "lblResultText"
        Me.lblResultText.Size = New System.Drawing.Size(365, 12)
        Me.lblResultText.TabIndex = 4
        Me.lblResultText.Text = "---------------------------------------計算結果--------------------------------------" &
    "-"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.lblResult.Location = New System.Drawing.Point(24, 161)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 16)
        Me.lblResult.TabIndex = 5
        '
        'frmHeightCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 217)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblResultText)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculet)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Name = "frmHeightCalculator"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeight As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents btnCalculet As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblResultText As Label
    Friend WithEvents lblResult As Label
End Class
