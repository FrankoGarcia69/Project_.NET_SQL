﻿Imports System.Data.SqlClient

Public Class Form1
    

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

    End Sub
    
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class
