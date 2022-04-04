Module Module1

    Sub Main()
        Dim nota1, nota2, media As Double
        Dim aluno As String

        Console.WriteLine("Digite o nome do aluno: ")
        aluno = Console.ReadLine()

        Console.WriteLine("Digite a primeira nota: ")
        nota1 = Console.ReadLine()

        Console.WriteLine("Digite a segunda nota: ")
        nota2 = Console.ReadLine()

        media = (nota1 + nota2) / 2

        Console.WriteLine("A media do aluno " & aluno & " é igual a " & media)


    End Sub

End Module
