'Brayden Peck
'RCET 0265
'Spring 2021
'Variable Examples


Option Strict On    'No conversions by compiler
Option Explicit On  'Must declare all variables
Module Module1 'PascalCase

    Sub Main()
        Dim x As Integer
        Dim y As Integer
        Dim result As Integer

        Dim personName As String    'camelCase
        Dim firstName As String
        Dim lastName As String
        Dim age As Integer

        x = 1
        y = 2
        result = x + CInt(y)    'Force to convert to integer

        firstName = "Joe"
        lastName = "Barnes"
        age = 42

        personName = firstName & " " & lastName
        Console.WriteLine(personName _
                            & " is " _
                         & CStr(age) _
                     & " years old") 'Wrap long lines with Space and "_"
        Console.Read()
    End Sub

End Module
