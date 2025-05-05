using System;
using System.Windows.Forms;

public class RegistrationForm : Form
{
    TextBox nameTextBox = new TextBox();
    TextBox ageTextBox = new TextBox();
    TextBox classTextBox = new TextBox();
    Button submitButton = new Button();

    public RegistrationForm()
    {
        this.Text = "Registration Form";

        nameTextBox.SetBounds(10, 10, 200, 20);
        ageTextBox.SetBounds(10, 40, 200, 20);
        classTextBox.SetBounds(10, 70, 200, 20);
        submitButton.SetBounds(10, 100, 200, 30);
        submitButton.Text = "Submit";

        submitButton.Click += SubmitButton_Click;

        this.Controls.Add(nameTextBox);
        this.Controls.Add(ageTextBox);
        this.Controls.Add(classTextBox);
        this.Controls.Add(submitButton);
    }

    private void SubmitButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Name: {nameTextBox.Text}, Age: {ageTextBox.Text}, Class: {classTextBox.Text}");
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new RegistrationForm());
    }
}
