<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tutizokusei
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
        Me.tutibutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tutibutton
        '
        Me.tutibutton.Location = New System.Drawing.Point(0, 0)
        Me.tutibutton.Name = "tutibutton"
        Me.tutibutton.Size = New System.Drawing.Size(75, 23)
        Me.tutibutton.TabIndex = 0
        Me.tutibutton.Text = "土選択"
        Me.tutibutton.UseVisualStyleBackColor = True
        '
        'tutizokusei
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(79, 33)
        Me.Controls.Add(Me.tutibutton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "tutizokusei"
        Me.Text = "土属性"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tutibutton As Button
End Class
