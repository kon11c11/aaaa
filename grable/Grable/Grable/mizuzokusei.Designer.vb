<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mizuzokusei
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mizubutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mizubutton
        '
        Me.mizubutton.Location = New System.Drawing.Point(0, 0)
        Me.mizubutton.Name = "mizubutton"
        Me.mizubutton.Size = New System.Drawing.Size(75, 23)
        Me.mizubutton.TabIndex = 0
        Me.mizubutton.Text = "水"
        Me.mizubutton.UseVisualStyleBackColor = True
        '
        'mizuzokusei
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(85, 32)
        Me.Controls.Add(Me.mizubutton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "mizuzokusei"
        Me.Text = "水属性"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mizubutton As Button
End Class
