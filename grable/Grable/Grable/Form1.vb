Public Class Form1
    Dim a00 As New hizokuzei
    Dim a01 As New mizuzokusei
    Dim a02 As New tutizokusei
    Dim a03 As New kazezokusei
    Dim a04 As New hikarizokusi
    Dim a05 As New yamizokusei

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Answer As MsgBoxResult
        Answer = MsgBox("終了しますか？", MsgBoxStyle.YesNo)
        If Answer = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        '全部武器クリア
        mainbuki.Items.Clear()
        buki1.Items.Clear()
        buki2.Items.Clear()
        buki3.Items.Clear()
        buki4.Items.Clear()
        buki5.Items.Clear()
        buki6.Items.Clear()
        buki7.Items.Clear()
        buki8.Items.Clear()
        buki9.Items.Clear()
        'radiobuttonクリア
        hi.Checked = False
        hi.Enabled = True
        mizu.Checked = False
        mizu.Enabled = True
        tuchi.Checked = False
        tutic.Enabled = True
        kaze.Checked = False
        kaze.Enabled = True
        hikari.Checked = False
        hikari.Enabled = True
        yami.Checked = False
        yami.Enabled = True


        'HP/ATK クリア
        ATK.Clear()
        HP.Clear()
        ATK2.Clear()



        MessageBox.Show("全てクリアしました。",
               "報告",
               MessageBoxButtons.OK,
               MessageBoxIcon.Asterisk)
    End Sub
    Private Sub bukinous_Click(sender As Object, e As EventArgs) Handles bukinous.Click
        Dim de As New DictionaryEntry
        Dim cb1 As New Integer
        Dim cb2 As New Integer
        Dim cb3 As New Integer
        Dim cb4 As New Integer
        Dim cb5 As New Integer
        Dim cb6 As New Integer
        Dim cb7 As New Integer
        Dim cb8 As New Integer
        Dim cb9 As New Integer

        de = CType(mainbuki.SelectedItem, DictionaryEntry)
        cb1 = de.Value
        de = CType(buki1.SelectedItem, DictionaryEntry)
        cb2 = de.Value
        de = CType(buki2.SelectedItem, DictionaryEntry)
        cb3 = de.Value
        de = CType(buki3.SelectedItem, DictionaryEntry)
        cb4 = de.Value
        de = CType(buki4.SelectedItem, DictionaryEntry)
        cb5 = de.Value
        de = CType(buki5.SelectedItem, DictionaryEntry)
        cb6 = de.Value
        de = CType(buki6.SelectedItem, DictionaryEntry)
        cb7 = de.Value
        de = CType(buki7.SelectedItem, DictionaryEntry)
        cb8 = de.Value
        de = CType(buki8.SelectedItem, DictionaryEntry)
        cb9 = de.Value
        de = CType(buki9.SelectedItem, DictionaryEntry)

        ATK2.Text = (cb1 + cb2 + cb3 + cb4 + cb5 + cb6 + cb6 + cb7 + cb8 + cb9).ToString()
    End Sub

    Private Sub Hizokubox_Click(sender As Object, e As EventArgs) Handles hizokubox.Click
        a00.ShowDialog()

    End Sub

    Private Sub mizubox_Click(sender As Object, e As EventArgs) Handles mizubox.Click
        a01.ShowDialog()

    End Sub

    Private Sub tutib_Click(sender As Object, e As EventArgs) Handles tutib.Click
        a02.ShowDialog()

    End Sub
End Class
