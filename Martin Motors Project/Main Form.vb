'Name       :    Warren Theatres Wichita Percentage Calculator
'Purpose    :    Computes what percentage of the total profits a theatre location contributes.
'Programmer :    Joshua Pickenpaugh, June 24th, 2014.

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declares the variables:
        Dim dblSalesOne As Double
        Dim dblSalesTwo As Double
        Dim dblSalesThree As Double
        Dim dblSalesFour As Double
        Dim dblSalesOnePercent As Double
        Dim dblSalesTwoPercent As Double
        Dim dblSalesThreePercent As Double
        Dim dblSalesFourPercent As Double
        Dim dblTotalSales As Double

        'Converts:
        Double.TryParse(txtSalesOne.Text, dblSalesOne)
        Double.TryParse(txtSalesTwo.Text, dblSalesTwo)
        Double.TryParse(txtSalesThree.Text, dblSalesThree)
        Double.TryParse(txtSalesFour.Text, dblSalesFour)

        'Calculates:
        dblTotalSales = dblSalesOne + dblSalesTwo + dblSalesThree + dblSalesFour
        dblSalesOnePercent = dblSalesOne / dblTotalSales
        dblSalesTwoPercent = dblSalesTwo / dblTotalSales
        dblSalesThreePercent = dblSalesThree / dblTotalSales
        dblSalesFourPercent = dblSalesFour / dblTotalSales

        'Displays:
        lblTotal.Text = dblTotalSales.ToString("C2")
        lblPercentOne.Text = dblSalesOnePercent.ToString("P0")
        lblPercentTwo.Text = dblSalesTwoPercent.ToString("P0")
        lblPercentThree.Text = dblSalesThreePercent.ToString("P0")
        lblPercentFour.Text = dblSalesFourPercent.ToString("P0")

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the application:
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears the contents of the labels and boxes, sends the focus to the txtSalesOne box:
        txtSalesOne.Clear()
        txtSalesTwo.Clear()
        txtSalesThree.Clear()
        txtSalesFour.Clear()
        lblPercentOne.Text = String.Empty
        lblPercentTwo.Text = String.Empty
        lblPercentThree.Text = String.Empty
        lblPercentFour.Text = String.Empty
        lblTotal.Text = String.Empty
        txtSalesOne.Focus()

    End Sub
End Class
