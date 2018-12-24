Option Strict On

Public Class Form1
    '****************************************Load Form*****************************************************
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Financial Calculator"

        'Make Buttons Dissapear and Disabled
        btnCalculateFV.Enabled = False
        btnCalculateFV.Visible = False
        btnCalculatePV.Enabled = False
        btnCalculatePV.Visible = False
        btnCalculateNPer.Enabled = False
        btnCalculateNPer.Visible = False
        btnCalculateRate.Enabled = False
        btnCalculateRate.Visible = False
        btnCalculateSLN.Enabled = False
        btnCalculateSLN.Visible = False

        'Make Labels Dissapear
        lblVariable1.Visible = False
        lblVariable2.Visible = False
        lblVariable3.Visible = False
        lblEnterVariables.Visible = False
        lblResult.Visible = False

        'Make Text Boxes Dissapear and Disabled
        txtVariable1.Visible = False
        txtVariable1.Enabled = False
        txtVariable2.Visible = False
        txtVariable2.Enabled = False
        txtVariable3.Visible = False
        txtVariable3.Enabled = False

        'Show Current Date at bottom of form
        lblDate.Text = Date.Now.ToString

    End Sub
    '**************************************Load the Future Value Mode***************************************
    Private Sub btnFutureValue_Click(sender As Object, e As EventArgs) Handles btnFutureValue.Click
        Me.Text = "Future Value Calculator"

        'Enables and makes visible the labels for all variables and text boxes
        lblVariable1.Visible = True
        lblVariable2.Visible = True
        lblVariable3.Visible = True
        txtVariable1.Visible = True
        txtVariable1.Enabled = True
        txtVariable2.Visible = True
        txtVariable2.Enabled = True
        txtVariable3.Visible = True
        txtVariable3.Enabled = True
        lblEnterVariables.Visible = True

        'Clears all Test Boxes
        txtVariable1.Clear()
        txtVariable2.Clear()
        txtVariable3.Clear()

        'Enables the Calculate button for FV and makes it visible. Also makes the result text visible
        btnCalculateFV.Visible = True
        btnCalculateFV.Enabled = True
        btnCalculatePV.Visible = False
        btnCalculatePV.Enabled = False
        btnCalculateNPer.Visible = False
        btnCalculateNPer.Enabled = False
        btnCalculateRate.Visible = False
        btnCalculateRate.Enabled = False
        btnCalculateSLN.Visible = False
        btnCalculateSLN.Enabled = False
        lblResult.Visible = False

        'Displays all labels with the appropriate text for calculating Future Value
        lblModeDescription.Text = "Returns a number specifying the future value of an annuity based on periodic, fixed payments and a fixed interest rate."
        lblEnterVariables.Text = "Please enter the following variable's in the appropriate text boxes."
        lblVariable1.Text = "Annual Interest Rate (%)"
        lblVariable2.Text = "# of Yearly Payments (Periods)"
        lblVariable3.Text = "Payment Amount"

        'Show Current Date at bottom of form
        lblDate.Text = Date.Now.ToString

    End Sub
    '***************************Calculate the Future Value**************************************************
    Private Sub btnCalculateFV_Click(sender As Object, e As EventArgs) Handles btnCalculateFV.Click
        'Show Current Date at bottom of form
        lblDate.Text = Date.Now.ToString

        'Define Variables used in the Future Value Equation
        'Dim PValue As Double
        Dim AnnualRate As Double
        'Dim RateConvertToDecimal As Double
        Dim Period As Double
        'Dim PeriodMonths As Double
        Dim Payment As Double
        'Dim PayType As DueDate = DueDate.BegOfPeriod
        Dim FVResult As Double


        'Define Variables as a Value from Text Boxes
        'PValue = System.Convert.ToDouble(txtVariable4.Text)
        AnnualRate = System.Convert.ToDouble(txtVariable1.Text)
        Period = System.Convert.ToDouble(txtVariable2.Text)
        Payment = System.Convert.ToDouble(txtVariable3.Text)

        'Calculation is FV=PV*(1+r)^n
        FVResult = FV(AnnualRate / 100, Period, -Payment)
        lblResult.Text = "The Future Value of the investment is " + FVResult.ToString("$#,###,###,##0.00") + "."
        lblResult.Visible = True
    End Sub
    '****************************************Load Present Value Mode**********************************************
    Private Sub btnPresentValue_Click(sender As Object, e As EventArgs) Handles btnPresentValue.Click
        Me.Text = "Present Value Calculator"

        'Enables and makes visible the labels for all variables and text boxes
        lblVariable1.Visible = True
        lblVariable2.Visible = True
        lblVariable3.Visible = True
        txtVariable1.Visible = True
        txtVariable1.Enabled = True
        txtVariable2.Visible = True
        txtVariable2.Enabled = True
        txtVariable3.Visible = True
        txtVariable3.Enabled = True
        lblEnterVariables.Visible = True

        'Clears all Test Boxes
        txtVariable1.Clear()
        txtVariable2.Clear()
        txtVariable3.Clear()

        'Enables the Calculate button for PV and makes it visible. Also makes the result text visible
        btnCalculateFV.Visible = False
        btnCalculateFV.Enabled = False
        btnCalculatePV.Visible = True
        btnCalculatePV.Enabled = True
        btnCalculateNPer.Visible = False
        btnCalculateNPer.Enabled = False
        btnCalculateRate.Visible = False
        btnCalculateRate.Enabled = False
        btnCalculateSLN.Visible = False
        btnCalculateSLN.Enabled = False
        lblResult.Visible = False

        'Displays all labels with the appropriate text for calculating Future Value
        lblModeDescription.Text = "Returns a number specifying the present value of an annuity based on periodic, fixed payments to be paid in the future And a fixed interest rate."
        lblEnterVariables.Text = "Please enter the following variable's in the appropriate text boxes."
        lblVariable1.Text = "Annual Interest Rate (%)"
        lblVariable2.Text = "# of Yearly Payments (Periods)"
        lblVariable3.Text = "Payment Amount"

        'Show Current Date at bottom of form
        lblDate.Text = Date.Now.ToString

    End Sub
    '****************************************Calculate Present Value*****************************************
    Private Sub btnCalculatePV_Click(sender As Object, e As EventArgs) Handles btnCalculatePV.Click
        'Show Current Date at bottom of form
        lblDate.Text = Date.Now.ToString

        'Define Variable Used in the Present Value Equation
        Dim AnnualRate As Double
        Dim TotalPayments As Double
        Dim YrIncome As Double
        'Dim FValue As Double
        Dim PayType As DueDate = DueDate.EndOfPeriod

        'Define Values Entered from the Text Boxes
        AnnualRate = System.Convert.ToDouble(txtVariable1.Text)
        TotalPayments = System.Convert.ToDouble(txtVariable2.Text)
        YrIncome = System.Convert.ToDouble(txtVariable3.Text)
        'FValue = System.Convert.ToDouble(txtVariable4.Text)

        'Calculate using PV Function 
        Dim PValue As Double = PV(AnnualRate / 100, TotalPayments, -YrIncome)
        lblResult.Text = "The Present Value of the Investment is " + PValue.ToString("$#,###,###.##")
        lblResult.Visible = True
    End Sub
    '****************************************Load Number Of Periods Mode************************************
    Private Sub btnNumberOfPeriods_Click(sender As Object, e As EventArgs) Handles btnNumberOfPeriods.Click
        Me.Text = "Number of Periods Calculator"

        'Enables and makes visible the labels for all variables and text boxes
        lblVariable1.Visible = True
        lblVariable2.Visible = True
        lblVariable3.Visible = True
        txtVariable1.Visible = True
        txtVariable1.Enabled = True
        txtVariable2.Visible = True
        txtVariable2.Enabled = True
        txtVariable3.Visible = True
        txtVariable3.Enabled = True
        lblEnterVariables.Visible = True

        'Clears all Test Boxes
        txtVariable1.Clear()
        txtVariable2.Clear()
        txtVariable3.Clear()

        'Enables the Calculate button for PV and makes it visible. Also makes the result text visible
        btnCalculateFV.Visible = False
        btnCalculateFV.Enabled = False
        btnCalculatePV.Visible = False
        btnCalculatePV.Enabled = False
        btnCalculateNPer.Visible = True
        btnCalculateNPer.Enabled = True
        btnCalculateRate.Visible = False
        btnCalculateRate.Enabled = False
        btnCalculateSLN.Visible = False
        btnCalculateSLN.Enabled = False
        lblResult.Visible = False


        'Displays all labels with the appropriate text for calculating Future Value
        lblModeDescription.Text = "Returns a number specifying the number of periods for an annuity based on periodic fixed payments and a fixed interest rate."
        lblEnterVariables.Text = "Please enter the following variable's in the appropriate text boxes."
        lblVariable3.Text = "Annual Interest Rate (%)"
        lblVariable2.Text = "Payment Amount"
        lblVariable1.Text = "Loan Amount"

        'Show Current Date at bottom of form
        lblDate.Text = Date.Now.ToString

    End Sub
    '****************************************Calculate Number of Periods*************************************
    Private Sub btnCalculateNPer_Click(sender As Object, e As EventArgs) Handles btnCalculateNPer.Click
        'Define Variables Used in Number of Payments Equation
        Dim TotalPayments As Double
        Dim LoanAmount As Double
        Dim AnnualRate As Double
        Dim PaymentAmount As Double

        'Define Values for Formula
        AnnualRate = System.Convert.ToDouble(txtVariable3.Text)
        PaymentAmount = System.Convert.ToDouble(txtVariable2.Text)
        LoanAmount = System.Convert.ToDouble(txtVariable1.Text)
        TotalPayments = NPer(AnnualRate / 100, PaymentAmount, LoanAmount) * (-1)
        lblResult.Text = "The Number of Yearly Payments until the loan is paid off is " + TotalPayments.ToString("#,###,###")
        lblResult.Visible = True

        'Show Current Date at bottom of form
        lblDate.Text = Date.Now.ToString

    End Sub
    '****************************************Load Rate Mode***************************************************
    Private Sub btnInterestRate_Click(sender As Object, e As EventArgs) Handles btnInterestRate.Click
        Me.Text = "Interest Rate Calculator"

        'Enables and makes visible the labels for all variables and text boxes
        lblVariable1.Visible = True
        lblVariable2.Visible = True
        lblVariable3.Visible = True
        txtVariable1.Visible = True
        txtVariable1.Enabled = True
        txtVariable2.Visible = True
        txtVariable2.Enabled = True
        txtVariable3.Visible = True
        txtVariable3.Enabled = True
        lblEnterVariables.Visible = True

        'Clears all Test Boxes
        txtVariable1.Clear()
        txtVariable2.Clear()
        txtVariable3.Clear()

        'Enables the Calculate button for PV and makes it visible. Also makes the result text visible
        btnCalculateFV.Visible = False
        btnCalculateFV.Enabled = False
        btnCalculatePV.Visible = False
        btnCalculatePV.Enabled = False
        btnCalculateNPer.Visible = False
        btnCalculateNPer.Enabled = False
        btnCalculateRate.Visible = True
        btnCalculateRate.Enabled = True
        btnCalculateSLN.Visible = False
        btnCalculateSLN.Enabled = False
        lblResult.Visible = False

        'Displays all labels with the appropriate text for calculating Future Value
        lblModeDescription.Text = "Returns a number  specifying the interest rate per period for an annuity."
        lblEnterVariables.Text = "Please enter the following variable's in the appropriate text boxes."
        lblVariable3.Text = "# of Yearly Payments"
        lblVariable2.Text = "Payment Amount"
        lblVariable1.Text = "Loan Amount"

        'Show Current Date at bottom of form
        lblDate.Text = Date.Now.ToString

    End Sub
    '****************************************Calculate Rate***************************************************
    Private Sub btnCalculateRate_Click(sender As Object, e As EventArgs) Handles btnCalculateRate.Click
        'Define variables used in equation
        Dim AnnualRate As Double
        Dim PaymentAmount As Double
        Dim LoanAmount As Double
        Dim TotalPayments As Double

        'Define values of variables in formula
        TotalPayments = System.Convert.ToDouble(txtVariable3.Text)
        PaymentAmount = System.Convert.ToDouble(txtVariable2.Text)
        LoanAmount = System.Convert.ToDouble(txtVariable1.Text)
        AnnualRate = Rate(TotalPayments, -PaymentAmount, LoanAmount) * 100
        lblResult.Text = "The Annual Rate of the Investment is " + AnnualRate.ToString("###.##") + "%"
        lblResult.Visible = True

        'Show Current Date at bottom of form
        lblDate.Text = Date.Now.ToString

    End Sub
    '****************************************Load Straight-Line-Depreciation Mode*****************************
    Private Sub btnStraightLineDepreciation_Click(sender As Object, e As EventArgs) Handles btnStraightLineDepreciation.Click
        Me.Text = "Straight-Line Depreciation Calculator"

        'Enables and makes visible the labels for all variables and text boxes
        lblVariable1.Visible = True
        lblVariable2.Visible = True
        lblVariable3.Visible = True
        txtVariable1.Visible = True
        txtVariable1.Enabled = True
        txtVariable2.Visible = True
        txtVariable2.Enabled = True
        txtVariable3.Visible = True
        txtVariable3.Enabled = True
        lblEnterVariables.Visible = True

        'Clears all Test Boxes
        txtVariable1.Clear()
        txtVariable2.Clear()
        txtVariable3.Clear()

        'Enables the Calculate button for PV and makes it visible. Also makes the result text visible
        btnCalculateFV.Visible = False
        btnCalculateFV.Enabled = False
        btnCalculatePV.Visible = False
        btnCalculatePV.Enabled = False
        btnCalculateNPer.Visible = False
        btnCalculateNPer.Enabled = False
        btnCalculateRate.Visible = False
        btnCalculateRate.Enabled = False
        btnCalculateSLN.Visible = True
        btnCalculateSLN.Enabled = True
        lblResult.Visible = False

        'Displays all labels with the appropriate text for calculating Future Value
        lblModeDescription.Text = "Returns a number specifying the straight-line depreciation of an asset for a single period."
        lblEnterVariables.Text = "Please enter the following variable's in the appropriate text boxes."
        lblVariable1.Text = "Initial Cost"
        lblVariable2.Text = "Salvage Value"
        lblVariable3.Text = "Length of Useful Life"

        'Show Current Date at bottom of form
        lblDate.Text = Date.Now.ToString

    End Sub
    '****************************************Calculate SLN****************************************************
    Private Sub btnCalculateSLN_Click(sender As Object, e As EventArgs) Handles btnCalculateSLN.Click
        'Define variables for equation
        Dim InitialCost As Double
        Dim SalvageValue As Double
        Dim Length As Double

        'Define values of variables
        InitialCost = System.Convert.ToDouble(txtVariable1.Text)
        SalvageValue = System.Convert.ToDouble(txtVariable2.Text)
        Length = System.Convert.ToDouble(txtVariable3.Text)

        'SLN
        Dim SlnDepr As Double = SLN(InitialCost, SalvageValue, Length)
        lblResult.Text = "The asset will depreciate by " + SlnDepr.ToString("$#,###,###.##") + " per Year"
        lblResult.Visible = True

        'Show Current Date at bottom of form
        lblDate.Text = Date.Now.ToString

    End Sub

    Private Sub btnClearMode_Click(sender As Object, e As EventArgs) Handles btnClearMode.Click
        Me.Text = "Financial Calculator"

        'Make Buttons Dissapear and Disabled
        btnCalculateFV.Enabled = False
        btnCalculateFV.Visible = False
        btnCalculatePV.Enabled = False
        btnCalculatePV.Visible = False
        btnCalculateNPer.Enabled = False
        btnCalculateNPer.Visible = False
        btnCalculateRate.Enabled = False
        btnCalculateRate.Visible = False
        btnCalculateSLN.Enabled = False
        btnCalculateSLN.Visible = False

        'Clears all Test Boxes
        txtVariable1.Clear()
        txtVariable2.Clear()
        txtVariable3.Clear()

        'Make Labels Dissapear
        lblVariable1.Visible = False
        lblVariable2.Visible = False
        lblVariable3.Visible = False
        lblEnterVariables.Visible = False
        lblResult.Visible = False
        lblResult.Text = "Result..."

        'Make Text Boxes Dissapear and Disabled
        txtVariable1.Visible = False
        txtVariable1.Enabled = False
        txtVariable2.Visible = False
        txtVariable2.Enabled = False
        txtVariable3.Visible = False
        txtVariable3.Enabled = False

        'Resets the Description Label to Default Text
        lblModeDescription.Text = "Select one of the buttons above to see description..."

        'Show Current Date at bottom of form
        lblDate.Text = Date.Now.ToString

    End Sub
End Class
