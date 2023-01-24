Module Module1

    Sub Main()
        Dim name As String
        FileOpen(1, My.Application.Info.DirectoryPath & "\BCCPASSTUDENTS.txt", OpenMode.Output)

        For x = 1 To 10
            Console.WriteLine("Enter name: ")
            name = Console.ReadLine()
            WriteLine(1, name)
        Next
        FileClose(1)
    End Sub

End Module
