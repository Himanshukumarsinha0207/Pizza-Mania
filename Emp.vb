Imports System.Data.OleDb
Public Class Emp
    Dim connectionstr As String
    Dim cmn As OleDbConnection

    Private Sub GunaLabel4_Click(sender As Object, e As EventArgs) Handles GunaLabel4.Click

    End Sub

    Private Sub GunaTextBox7_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox7.TextChanged

    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton4_Click_1(sender As Object, e As EventArgs) Handles GunaButton4.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        GunaTextBox1.Clear()
        GunaTextBox2.Clear()
        GunaTextBox3.Clear()
        GunaTextBox4.Clear()
        GunaTextBox5.Clear()
        GunaTextBox6.Clear()
        GunaTextBox7.Clear()

    End Sub

    Private Sub Emp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Pizza Mania new\Employee.accdb"
        cmn = New OleDbConnection
        cmn.ConnectionString = connectionstr
        cmn.Open()
        'cmn.Close()


    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox1.TextChanged
        'Dim oledbd As OleDbDataAdapter
        'Dim sqlstrn As String
        ' Dim dst As New DataSet
        ' Dim cnd As OleDbCommand
        ''Dim intvalue As String
        ' If GunaTextBox1 .
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click

        Try
            ' Dim empId As Integer = Integer.Parse(GunaTextBox1.Text)

            Dim query As String = "SELECT E_name, Doj, address, salary, job, email, mob_no FROM employee WHERE empid = @empid"
            Dim cnd As OleDbCommand = New OleDbCommand(query, cmn)
            cnd.Parameters.AddWithValue("@empid", Integer.Parse(GunaTextBox1.Text))
            'cmn.Open()
            If cmn.State = ConnectionState.Closed Then
                cmn.Open()
            End If
            Dim reader As OleDbDataReader = cnd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                GunaTextBox2.Text = reader("E_name").ToString()
                ' GunaDateTimePicker1.Value = DateTime.Parse(reader("Doj").ToString())
                GunaTextBox3.Text = reader("address").ToString()
                GunaTextBox4.Text = reader("salary").ToString()
                GunaTextBox5.Text = reader("job").ToString()
                GunaTextBox6.Text = reader("email").ToString()
                GunaTextBox7.Text = reader("mob_no").ToString()
            Else
                MessageBox.Show("No employee found with the provided ID.")
            End If
            'cmn.Close()
            'cmn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmn.Close()
        End Try


    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click

        Dim eid As String = GunaTextBox1.Text
        Dim empName As String = GunaTextBox2.Text
        Dim Doj As Date = GunaDateTimePicker1.Value
        Dim address As String = GunaTextBox3.Text
        Dim salary As Decimal = Decimal.Parse(GunaTextBox4.Text)
        Dim job As String = GunaTextBox5.Text
        Dim email As String = GunaTextBox6.Text
        Dim mobno As String = GunaTextBox7.Text

        Dim query As String = "INSERT INTO Employee (emp_id,e_name,DOJ, address, salary, job, email, mob_no) VALUES (@eid,@empname, @DOJ, @address, @salary, @job, @email, @mobno)"
        Dim cmd As OleDbCommand = New OleDbCommand(query, cmn)
        If cmn.State = ConnectionState.Closed Then
            cmn.Open()
        End If
        cmd.Parameters.AddWithValue("@eid", eid)
        cmd.Parameters.AddWithValue("@empname", empName)
        cmd.Parameters.AddWithValue("@DOJ", Doj.Date)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@salary", salary.ToString)
        cmd.Parameters.AddWithValue("@job", job)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@mobno", mobno)


        cmd.ExecuteNonQuery()
        MsgBox("Employee details added successfully")

        'If rowsAffected > 0 Then
        ' MessageBox.Show("Employee details added successfully.")
        'Else
        'MessageBox.Show("Unable to add employee details.")
        'End If
        cmn.Close()

    End Sub
End Class