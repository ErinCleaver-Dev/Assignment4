Public Class Form1

    Dim dbNumberList As Decimal()
    Private Sub bntAddNumber_Click(sender As Object, e As EventArgs) Handles bntAddNumber.Click
        Try
            Dim dbNumber As Decimal = Decimal.Parse(
            txtNumber.Text)
            If NumberList.Items.Count < 20 Then
                NumberList.Items.Add(dbNumber)
            Else
                MessageBox.Show("You can only enter 20 numbers. Please clear the list if you would like to start over.")
            End If
        Catch ex As FormatException
            MessageBox.Show("Format Exception: " & ex.Message)
        End Try

        Try
            dbNumberList = NumberList.Items.OfType(Of Decimal).ToArray()
            Array.Sort(dbNumberList)


        Catch
            MessageBox.Show("Failed to convert the number item to a list")
        End Try
    End Sub

    Private Sub bntMean_Click(sender As Object, e As EventArgs) Handles bntMean.Click
        Try
            Dim dbSum As Decimal = 0
            For Each number In dbNumberList
                dbSum += number
            Next
            Dim dbMean As Decimal = dbSum / dbNumberList.Length

            lblMean.Text = dbMean


        Catch ex As DivideByZeroException
            MessageBox.Show("Divided By Zero Exception: " & ex.Message)
        End Try
    End Sub

    Private Sub bntMedian_Click(sender As Object, e As EventArgs) Handles bntMedian.Click
        Try
            Dim dbMedian As Decimal = 0
            If dbNumberList.Length Mod 2 = 0 Then
                Dim index As Integer = Math.Ceiling(Double.Parse(dbNumberList.Length) / 2) - 1
                dbMedian = (dbNumberList(index) + dbMedian = dbNumberList(index + 1)) / 2
            Else
                Dim index As Integer = Math.Ceiling(Double.Parse(dbNumberList.Length) / 2) - 1
                dbMedian = dbNumberList(index)
            End If
            lblMedian.Text = dbMedian
        Catch ex As DivideByZeroException
            MessageBox.Show("Divided By Zero Exception: " & ex.Message)
        Catch ex As FormatException
            MessageBox.Show("Format Exception: " & ex.Message)
        End Try

    End Sub

    Private Sub bntMode_Click(sender As Object, e As EventArgs) Handles bntMode.Click
        Dim dbMode As Decimal
        Dim dbTemp2 As Decimal
        Dim dbCount As Integer = 0
        Dim dbCount2 As Integer = 0
        Try
            For i As Integer = 0 To dbNumberList.Length - 1
                If i = 0 Then
                    dbMode = dbNumberList(i)
                    dbCount += 1
                ElseIf dbNumberList(i) = dbMode Then
                    dbCount += 1
                ElseIf dbNumberList(i) <> dbMode Then

                    If dbCount2 = 0 Then
                        Debug.WriteLine("Checking if db count is equal to 0")
                        dbTemp2 = dbNumberList(i)
                        dbCount2 += 1
                    ElseIf dbCount2 > dbCount Then
                        dbMode = dbTemp2
                        dbCount = dbCount2
                        dbCount2 = 0
                    ElseIf dbTemp2 = dbNumberList(i) Then
                        dbCount2 += 1
                    Else
                        dbCount2 = 1
                        dbTemp2 = dbNumberList(i)
                    End If
                End If
            Next
            lblMode.Text = dbMode

        Catch ex As IndexOutOfRangeException
            MessageBox.Show("Index Out of Range Exception: " & ex.Message)
        Catch ex As NullReferenceException
            MessageBox.Show("NullReferenceException: " & ex.Message)
        End Try
    End Sub

    Private Sub bntClearList_Click(sender As Object, e As EventArgs) Handles bntClearList.Click
        NumberList.Items.Clear()
    End Sub
End Class
