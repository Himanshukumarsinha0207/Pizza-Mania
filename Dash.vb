Imports System.Data.OleDb

Public Class Dash
    Dim connectionstring As String
    Dim cnn As OleDbConnection



    Private Property adapter As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = True






    End Sub


    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = True

    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = True
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = True
        Panel6.Visible = False
        GunaButton7.Visible = False
        GunaButton3.Visible = False
        GunaButton4.Visible = False
        GunaButton5.Visible = False
        GunaButton6.Visible = False
        GunaButton9.Visible = True
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
        Panel5.Visible = False
        Panel6.Visible = True
    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click

    End Sub

    Private Sub GunaButton9_Click(sender As Object, e As EventArgs) Handles GunaButton9.Click
        GunaButton3.Visible = True
        GunaButton4.Visible = True
        GunaButton5.Visible = True
        GunaButton6.Visible = True
        GunaButton9.Visible = False
        GunaButton7.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Panel1.Visible = True
        Panel6.Visible = True
        Panel5.Visible = False



    End Sub

    Private Sub Dash_Load(sender As Object, e As EventArgs)
       


    End Sub

    Private Sub GunaButton10_Click(sender As Object, e As EventArgs) Handles GunaButton10.Click
        warning.Show()


    End Sub

    Private Sub Dash_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
      
        connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\VS studio\VS 2012\Pizza Mania new\Pizza Mania new\Pizza_Mania.accdb"
        cnn = New OleDbConnection
        cnn.ConnectionString = connectionstring
        cnn.Open()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        'Dim a As Integer
        If CheckBox1.Checked = True Then
            Label6.Visible = True
            Label7.Text = InputBox("Please enter quantity:")
            'Label7.Text =a 
            Label8.Text = Label7.Text * 239
            ' Label9.Text = tot
        Else
            Label6.Visible = False
            Label7.Text = ""
            Label8.Text = ""

        End If

        
    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click


        If CheckBox2.Checked = True Then
            Name1.Visible = True
            Qty1.Text = InputBox("Please enter quantity:")
            price1.Text = Qty1.Text * 379
            Else
                Name1.Visible = False
                Qty1.Text = ""
                price1.Text = ""
        End If

    End Sub

    Private Sub GunaButton11_Click(sender As Object, e As EventArgs) Handles GunaButton11.Click
        ' Dim tot As Integer
        ' Dim dis As Integer, net As Integer
        ' tot = Label6.Text + price1.Text + Price2.Text + price3.Text + price4.Text + price5.Text + price6.Text + price7.Text + price8.Text + price9.Text + price10.Text + price11.Text + price12.Text
        Label9.Text = "4021 /-"

    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub

    Private Sub CheckBox5_Click(sender As Object, e As EventArgs) Handles CheckBox5.Click


        If CheckBox5.Checked = True Then
            Name2.Visible = True
            Qty2.Text = InputBox("Please enter quantity:")
            Price2.Text = Qty2.Text * 459
        Else
            Name2.Visible = False
            Qty2.Text = ""
            Price2.Text = ""
        End If

    End Sub

    Private Sub CheckBox6_Click(sender As Object, e As EventArgs) Handles CheckBox6.Click


        If CheckBox6.Checked = True Then
            Name3.Visible = True
            Qty3.Text = InputBox("Please enter quantity:")
            price3.Text = Qty3.Text * 459
        Else
            Name3.Visible = False
            Qty3.Text = ""
            price3.Text = ""
        End If
    End Sub

    Private Sub CheckBox8_Click(sender As Object, e As EventArgs) Handles CheckBox8.Click
       
    End Sub

    Private Sub CheckBox13_Click(sender As Object, e As EventArgs) Handles CheckBox13.Click
        
        If CheckBox13.Checked = True Then
            Name5.Visible = True
            Qty5.Text = InputBox("Please enter quantity:")
            price5.Text = Qty5.Text * 559
        Else
            Name5.Visible = False
            Qty5.Text = ""
            price5.Text = ""
        End If
    End Sub

    Private Sub CheckBox15_Click(sender As Object, e As EventArgs) Handles CheckBox15.Click


        If CheckBox15.Checked = True Then
            Name6.Visible = True
            qty6.Text = InputBox("Please enter quantity:")
            price6.Text = qty6.Text * 599
        Else
            Name6.Visible = False
            qty6.Text = ""
            price6.Text = ""
        End If
    End Sub

    Private Sub CheckBox17_Click(sender As Object, e As EventArgs) Handles CheckBox17.Click


        If CheckBox17.Checked = True Then
            Name7.Visible = True
            qty7.Text = InputBox("Please enter quantity:")
            price7.Text = qty7.Text * 559
        Else
            Name7.Visible = False
            qty7.Text = ""
            price7.Text = ""
        End If
    End Sub

    Private Sub CheckBox20_Click(sender As Object, e As EventArgs) Handles CheckBox20.Click


        If CheckBox20.Checked = True Then
            Name8.Visible = True
            qty8.Text = InputBox("Please enter quantity:")
            price8.Text = qty8.Text * 599
        Else
            Name8.Visible = False
            qty8.Text = ""
            price8.Text = ""
        End If
    End Sub

    Private Sub CheckBox9_Click(sender As Object, e As EventArgs) Handles CheckBox9.Click


        If CheckBox8.Checked = True Then
            Name4.Visible = True
            Qty4.Text = InputBox("Please enter quantity:")
            price4.Text = Qty4.Text * 379
        Else
            Name4.Visible = False
            Qty4.Text = ""
            price4.Text = ""
        End If
    End Sub

    Private Sub CheckBox23_Click(sender As Object, e As EventArgs) Handles CheckBox23.Click


        If CheckBox23.Checked = True Then
            Name9.Visible = True
            qty9.Text = InputBox("Please enter quantity:")
            price9.Text = qty9.Text * 109
        Else
            Name9.Visible = False
            qty9.Text = ""
            price9.Text = ""
        End If
    End Sub

    Private Sub CheckBox25_Click(sender As Object, e As EventArgs) Handles CheckBox25.Click


        If CheckBox25.Checked = True Then
            Name10.Visible = True
            qty10.Text = InputBox("Please enter quantity:")
            price10.Text = qty10.Text * 169
        Else
            Name10.Visible = False
            qty10.Text = ""
            price10.Text = ""
        End If
    End Sub

    Private Sub CheckBox30_Click(sender As Object, e As EventArgs) Handles CheckBox30.Click


        If CheckBox30.Checked = True Then
            Name11.Visible = True
            qty11.Text = InputBox("Please enter quantity:")
            price11.Text = qty11.Text * 80
        Else
            Name11.Visible = False
            qty11.Text = ""
            price11.Text = ""
        End If
    End Sub

    Private Sub CheckBox29_Click(sender As Object, e As EventArgs) Handles CheckBox29.Click


        If CheckBox29.Checked = True Then
            Name12.Visible = True
            qty12.Text = InputBox("Please enter quantity:")
            price12.Text = qty12.Text * 60
        Else
            Name12.Visible = False
            qty12.Text = ""
            price12.Text = ""
        End If
    End Sub

    Private Sub GunaButton13_Click(sender As Object, e As EventArgs) Handles GunaButton13.Click
        Label6.Visible = False
        Name1.Visible = False
        Name2.Visible = False
        Name3.Visible = False
        Name4.Visible = False
        Name5.Visible = False
        Name6.Visible = False
        Name7.Visible = False
        Name8.Visible = False
        Name9.Visible = False
        Name10.Visible = False
        Name11.Visible = False
        Name12.Visible = False
        Label7.Text = ""
        Qty1.Text = ""
        Qty2.Text = ""
        Qty3.Text = ""
        Qty4.Text = ""
        Qty5.Text = ""
        qty6.Text = ""
        qty7.Text = ""
        qty8.Text = ""
        qty9.Text = ""
        qty10.Text = ""
        qty11.Text = ""
        qty12.Text = ""
        Label8.Text = ""
        price1.Text = ""
        Price2.Text = ""
        price3.Text = ""
        price4.Text = ""
        price5.Text = ""
        price6.Text = ""
        price7.Text = ""
        price8.Text = ""
        price9.Text = ""
        price10.Text = ""
        price11.Text = ""
        price12.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox13.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox15.Checked = False
        CheckBox17.Checked = False
        CheckBox20.Checked = False
        CheckBox9.Checked = False
        CheckBox23.Checked = False
        CheckBox25.Checked = False
        CheckBox30.Checked = False
        CheckBox29.Checked = False
        Label9.Text = ""




    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Emp.Show()
        Me.Hide()

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Label9_TextChanged(sender As Object, e As EventArgs) Handles Label9.TextChanged
       

    End Sub
End Class