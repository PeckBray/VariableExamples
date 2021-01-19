'Brayden Peck
'RCET 0265
'Spring 2021
'Variable Examples


Option Strict On    'No conversions by compiler
Option Explicit On  'Must declare all variables
Module Module1

    Sub Main()
        Dim x As Integer
        Dim y As Integer
        Dim personName As String
        Dim result As Integer
        Dim firstName As String
        Dim lastName As String
        Dim age As Integer

        x = 1
        y = 2
        result = x + y

        firstName = "Joe"
        lastName = "Barnes"
        age = 42

        personName = firstName & " " & lastName
        Console.WriteLine(personName & " is " & CStr(age) & " years old")
        Console.Read()
    End Sub

End Module
