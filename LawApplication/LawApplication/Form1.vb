Public Class Form1










    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not TextBox1.Text = "user" Then
            Label3.Visible = True
            Label3.Text = "Invalid username!"
        End If
        If Not TextBox2.Text = "123" Then
            Label4.Visible = True
            Label4.Text = "Invalid password!"
        End If
        If TextBox1.Text = "user" And TextBox2.Text = "123" Then
            Panel1.Visible = False
            Panel2.Visible = True
            Panel2.Dock = DockStyle.Fill

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LawApp._LawApp' table. You can move, or remove it, as needed.
        Me.LawAppTableAdapter.Fill(Me.LawApp._LawApp)
        Panel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Panel2.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Panel2.Visible = False
        Panel1.Visible = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        If Label3.Visible = True Then
            Label3.Visible = False

        End If
        If Label4.Visible = True Then
            Label4.Visible = False

        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.Visible = False
        Panel3.Visible = True
        Panel3.Dock = DockStyle.Fill
        If Label9.Visible = True Then
            Label9.Visible = False

        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub TextBox3_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Public Sub Button5_Click(sender As Object, e As EventArgs)
        If TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" And TextBox6.Text = "" And TextBox7.Text = "" Then
            Label9.Visible = True
            Label9.Text = "Complete all boxes!"
            Label9.ForeColor = Color.Red
        Else


            Label9.Visible = True
            Label9.Text = "Success!"
            Label9.ForeColor = Color.LimeGreen


        End If
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Panel3.Visible = False
        Panel2.Visible = True
        Panel2.Dock = DockStyle.Fill

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Visible = False
        panel4.visible = True
        panel4.dock = DockStyle.Fill
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Panel3.Visible = False
        Panel2.Visible = True
        Panel2.Dock = DockStyle.Fill
    End Sub

    Public Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" And TextBox6.Text = "" And TextBox7.Text = "" Then
            Label9.Visible = True
            Label9.Text = "Complete all boxes!"
            Label9.ForeColor = Color.Red
        Else


            Label9.Visible = True
            Label9.Text = "Success!"
            Label9.ForeColor = Color.LimeGreen


            LawAppBindingSource.EndEdit()
            Me.LawAppTableAdapter.Update(Me.LawApp._LawApp)

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel4.Visible = False
        Panel2.Visible = True
        Panel2.Dock = DockStyle.Fill
    End Sub
End Class
