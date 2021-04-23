Option Strict On
Option Explicit On
Imports System.IO
Public Class StansGroceryForm
    Dim food(255, 2) As String


    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim temp() As String
        Dim temp2() As String

        temp = Split(My.Resources.Grocery, vbNewLine)
        For i = 0 To UBound(temp)
            temp2 = Split(temp(i), ",")
            temp2(0) = Replace(temp2(0), """", "")
            temp2(0) = Replace(temp2(0), "$$ITM", "")
            temp2(1) = Replace(temp2(1), """", "")
            temp2(1) = Replace(temp2(1), "##LOC", "")
            temp2(2) = Replace(temp2(2), """", "")
            temp2(2) = Replace(temp2(2), "%%CAT", "")
            Me.food(i, 0) = temp2(0)
            Me.food(i, 1) = temp2(1)
            Me.food(i, 2) = temp2(2)
            DisplayListBox.Items.Add(Me.food(i, 0))

            Console.WriteLine($"{Me.food(i, 0)} {Me.food(i, 1)} {Me.food(i, 2)} {i}")

        Next


    End Sub

    Sub Program()
        Dim temp As String
        If FilterByAisleRadioButton.Checked = True Then
            FilterComboBox.Items.Clear()

            Try
                For i = 1 To UBound(food)
                    temp = Me.food(i, 1).PadLeft(2)
                    'If Me.food(i - 1, 1) = Me.food(i, 1) Then
                    If FilterComboBox.Items.Contains(temp) Or temp = "  " Then
                    Else
                        Console.WriteLine(Me.food(i, 1))
                        FilterComboBox.Items.Add(temp)
                    End If
                Next
            Catch ex As Exception
            End Try
        ElseIf FilterByCategoryRadioButton.Checked = True Then
            FilterComboBox.Items.Clear()
            FilterComboBox.Items.Add("Show All")

        End If
        FilterComboBox.Sorted = True
        FilterComboBox.Sorted = False
        FilterComboBox.Items.Insert(0, "Show All")
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text = "zzz" Then
            Me.Close()
        End If
    End Sub

    Private Sub FilterByAisleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadioButton.CheckedChanged
        Program()
    End Sub

    Private Sub FilterByCategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByCategoryRadioButton.CheckedChanged
        Program()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        DisplayListBox.Items.Clear()
        For i = 0 To UBound(Me.food)
            Try
                If StrConv(Me.food(i, 0), vbLowerCase).Contains(StrConv(SearchTextBox.Text, vbLowerCase)) Then
                    DisplayListBox.Items.Add(Me.food(i, 0))
                End If
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        Dim index As Integer
        index = DisplayListBox.SelectedIndex
        DisplayLabel.Text = $"{Me.food(index, 0)}, Aisle {Me.food(index, 1)}, {Me.food(index, 2)}"
    End Sub
End Class
