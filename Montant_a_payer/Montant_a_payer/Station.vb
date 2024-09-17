Public Class Station
    Function CalculerMT(ByVal ve As String, ByVal tv As String) As Integer
        Dim pap As Integer = 0
        If tv.CompareTo("Classe 1") Then
            Select Case ve
                Case "Larache" : pap = 27
                Case "Tanger" : pap = 38
                Case "Rabat" : pap = 13
                Case "Salé" : pap = 10
            End Select
        End If
        If tv.CompareTo("Classe 2") Then
            Select Case ve
                Case "Larache" : pap = 30
                Case "Tanger" : pap = 45
                Case "Rabat" : pap = 17
                Case "Salé" : pap = 15
            End Select
        End If

        Return pap
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label8.Text = ""
    End Sub

    Private Sub Label7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.MouseHover
        Label8.Text = "Ce zone et obligatoire"
    End Sub
    Private Sub Label7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.MouseLeave
        Label8.Text = ""
    End Sub

    Private Sub txt3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt3.SelectedIndexChanged
        If txt2.Text.CompareTo("") <> 0 And txt3.Text.CompareTo("") <> 0 Then
            txt4.Text = CalculerMT(txt2.Text, txt3.Text).ToString + " DH"
        End If

    End Sub

    Private Sub txt2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2.SelectedIndexChanged
        If txt2.Text.CompareTo("") <> 0 And txt3.Text.CompareTo("") <> 0 Then
            txt4.Text = CalculerMT(txt2.Text, txt3.Text).ToString + " DH"
        End If
    End Sub
End Class
