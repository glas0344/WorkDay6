Option Strict On

Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Ast, Bst, Cst, Dst As String
        Dim A, B, C, D As Double

        ' Read the input from the user
        Ast = txtA.Text
        Bst = txtB.Text
        Cst = txtC.Text
        Dst = txtD.Text

        ' All input must be numbers
        If Not (IsNumeric(Ast) And IsNumeric(Bst) And IsNumeric(Cst) _
                And IsNumeric(Dst)) Then
            MessageBox.Show("Please enter valid numbers", "Error!")
            Return
        End If

        ' Convert to double
        A = CDbl(Ast)
        B = CDbl(Bst)
        C = CDbl(Cst)
        D = CDbl(Dst)

        ' Please write your code here...

        txtResult.Text = FindIntersection(A, B, C, D)
    End Sub

    Function FindIntersection(A As Double,
                              B As Double,
                              C As Double,
                              D As Double) As String
        Dim Intersect As Boolean
        Dim Result As String
        Dim begpoint As String = CStr(Math.Max(A, C))
        Dim endpoint As String = CStr(Math.Min(B, D))
        Select Case Intersect
            Case (B >= C)
                Result = "False"
            Case (D >= A)
                Result = "False"
            Case Else
                Result = "The intersect is from " & begpoint & " to " & endpoint & "."
        End Select
        Return Result
    End Function


End Class
