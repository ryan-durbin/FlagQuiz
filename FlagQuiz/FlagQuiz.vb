Public Class FlagQuiz

    Dim countries As String() = {"Russia", "China", "Australia", "United States", "Italy", "South Africa", "Brazil", "Spain"}

    'Boolean array tracks displayed flags
    Dim used As Boolean() = New Boolean(0 To countries.GetUpperBound(0)) {}

    Dim count As Integer = 1 'number of flags shown
    Dim country As String 'current flag's country

    'Load event
    Private Sub FlagQuizForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Array.Sort(countries) 'alphabetize country names

        'display country names
        countriesComboBox.DataSource = countries

        DisplayFlag() 'displays flag
    End Sub

    'full path name of image file as a String
    Function BuildPathName() As String

        Return String.Format("images\{0}.png", country.Replace(" ", String.Empty))

    End Function 'Build Path

    'return an unused random number
    Function GetUniqueRandomNumber() As Integer

        Dim randomObject As New Random()
        Dim randomNumber As Integer

        Do 'generate random numbers until unused flag is found
            randomNumber = randomObject.Next(0, used.Length)
        Loop Until used(randomNumber) = False

        used(randomNumber) = True
        Return randomNumber

    End Function

    'display random flag in PictureBox
    Sub DisplayFlag()

        'unique index ensures that a flag is used no more than once
        Dim randomNumber As Integer = GetUniqueRandomNumber()

        'retrieve country name from array options
        country = countries(randomNumber)


        Dim path As String = BuildPathName()
        flagPicture.Image = Image.FromFile(path)

    End Sub ' DisplayFlag

    'handles Submit Button's Click event
    Private Sub submitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitButton.Click

        Dim response As String = countriesComboBox.Text

        If response = country Then
            feedBackLabel.Text = "Correct!"
        Else
            feedBackLabel.Text = "Sorry, incorrect."
        End If

        If count >= 5 Then 'quiz is over
            feedBackLabel.Text &= "  Done!"
            nextButton.Enabled = False
            countriesComboBox.Enabled = False
        Else 'quiz is not over
            nextButton.Enabled = True
        End If

        submitButton.Enabled = False

    End Sub

    'handles Next Flag Button's Click event
    Private Sub nextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextButton.Click

        DisplayFlag() 'display next flag
        feedBackLabel.Text = String.Empty 'clear output

        'change selected country to first in ComboBox
        countriesComboBox.SelectedIndex = 0

        count += 1 'update number of flags shown

        submitButton.Enabled = True
        nextButton.Enabled = False

    End Sub
End Class

' **************************************************************************
' * (C) Copyright 1992-2013 by Deitel & Associates, Inc. and               *
' * Pearson Education, Inc. All Rights Reserved.                           *
' *                                                                        *
' * DISCLAIMER: The authors and publisher of this book have used their     *
' * best efforts in preparing the book. These efforts include the          *
' * development, research, and testing of the theories and programs        *
' * to determine their effectiveness. The authors and publisher make       *
' * no warranty of any kind, expressed or implied, with regard to these    *
' * programs or to the documentation contained in these books. The authors *
' * and publisher shall not be liable in any event for incidental or       *
' * consequential damages in connection with, or arising out of, the       *
' * furnishing, performance, or use of these programs.                     *
' **************************************************************************