<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class hizokuzei
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.hibatton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'hibatton
        '
        Me.hibatton.Location = New System.Drawing.Point(2, 8)
        Me.hibatton.Name = "hibatton"
        Me.hibatton.Size = New System.Drawing.Size(75, 23)
        Me.hibatton.TabIndex = 0
        Me.hibatton.Text = "火属性"
        Me.hibatton.UseVisualStyleBackColor = True
        '
        'hizokuzei
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(81, 50)
        Me.Controls.Add(Me.hibatton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "hizokuzei"
        Me.Text = "火属性"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents hibatton As Button
    Friend WithEvents Button1 As Button
End Class
