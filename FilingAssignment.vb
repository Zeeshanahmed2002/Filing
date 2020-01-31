Module Module1

    Sub Main()
        Dim choice As Integer = 0
        Dim answer As String = ""

        Do
            Call displayMenu()
            Console.WriteLine()
            Console.Write("Enter your choice (b/w 1-5) = ") : choice = Console.ReadLine

        Loop Until choice >= 1 And choice <= 5

        Select Case choice
            Case "1"
                Call Entermemberdetail()
            Case "2"
                Call Searchformember()
            Case "3"
                Call Newmebmerdetail()
            Case "4"
                Call additionalinfo()
            Case "5"
                End
        End Select
    End Sub

    Sub displayMenu()
        Console.WriteLine("1. Enter Club member's detail.")
        Console.WriteLine("2. Search for a member.")
        Console.WriteLine("3. Add New members detail.")
        Console.WriteLine("4. Add additonal detail.")
        Console.WriteLine("5. End program")
    End Sub

    Sub Entermemberdetail()

        Console.WriteLine()

        Dim sName As String = ""
        Dim SNo As Integer = 0
        Dim sID As Integer = 0
        Dim more As Char = ""

        FileOpen(1, "D:\Filing\Assignment.txt", OpenMode.Output)
        Do
            Console.WriteLine()
            Console.Write("Enter SNo = ") : SNo = Console.ReadLine()
            Console.Write("Enter name of Member = ") : sName = Console.ReadLine
            Console.Write("Enter ID of the Member = ") : sID = Console.ReadLine

            WriteLine(1, SNo)
            WriteLine(1, sName)
            WriteLine(1, sID)

            Console.Write("Do you want to enter more records (Y/N) = ") : more = Console.ReadLine
        Loop Until UCase(more) = "N"
        FileClose(1)
    End Sub
    Sub Searchformember()

        Console.WriteLine()

        Dim searchname As String = ""
        Dim sName As String = ""
        Dim SNo As Integer = 0
        Dim sID As Integer = 0
        Dim isfound As Boolean = False

        Console.Write("Enter Member's name to search for = ") : searchname = Console.ReadLine
        FileOpen(1, "D:\Filing\Assignment.txt", OpenMode.Input)

        While Not EOF(1)
            SNo = LineInput(1)
            Input(1, sName)
            Input(1, sID)


            If UCase(searchname) = UCase(sName) Then
                isfound = True
                Console.WriteLine()
                Console.WriteLine("Serial Number = " & SNo)
                Console.WriteLine("Name = " & sName)
                Console.WriteLine("Member's ID= " & sID)
            End If
        End While
        FileClose(1)

        If isfound = False Then
            Console.WriteLine("The name couldnot be found.")
        End If
        Console.ReadKey()
    End Sub
    Sub Newmebmerdetail()

        Console.WriteLine()

        Dim sName As String = ""
        Dim SNo As Integer = 0
        Dim sID As Integer = 0
        Dim more As Char = ""

        FileOpen(1, "D:\Filing\Assignment.txt", OpenMode.Append)
        Do
            Console.Write("Enter SNo = ") : SNo = Console.ReadLine()
            Console.Write("Enter name of Member = ") : sName = Console.ReadLine
            Console.Write("Enter ID of the Member = ") : sID = Console.ReadLine

            WriteLine(1, SNo)
            WriteLine(1, sName)
            WriteLine(1, sID)

            Console.WriteLine("Do you want to enter more records (Y/N) = ") : more = Console.ReadLine
        Loop Until UCase(more) = "N"
        FileClose(1)
    End Sub

    Sub additionalinfo()

        Console.WriteLine()

        Dim sName As String = ""
        Dim SNo As Integer = 0
        Dim sID As Integer = 0
        Dim Teleno As Integer = 0
        Dim address As String = ""


        FileOpen(1, "D:\Filing\Assignment.txt", OpenMode.Input)
        FileOpen(2, "D:\Filing\Assignment2.txt", OpenMode.Output)

        While Not EOF(1)
            SNo = LineInput(1)
            Input(1, sName)
            Input(1, sID)

            Console.WriteLine("Serial Number = " & SNo)
            Console.WriteLine("Name = " & sName)
            Console.WriteLine("Member's ID= " & sID)

            Console.Write("Enter telephone number = ") : Teleno = Console.ReadLine
            Console.Write("Enter Address = ") : address = Console.ReadLine

            Console.WriteLine()
            WriteLine(2, SNo)
            WriteLine(2, sName)
            WriteLine(2, sID)
            WriteLine(2, Teleno)
            WriteLine(2, address)

        End While
        FileClose(1)
        FileClose(2)
    End Sub
End Module
