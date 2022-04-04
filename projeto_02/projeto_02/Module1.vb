Module Module1

    Sub Main()
        Dim funcionario As String
        Dim salario, reajuste, novosalario As Double

        Console.WriteLine("Digite o nome do funcionario: ")
        funcionario = Console.ReadLine()

        Console.WriteLine("Digite o salário atual: ")
        salario = Console.ReadLine()

        Console.WriteLine("Digite o percentual de reajuste: ")
        reajuste = Console.ReadLine()

        novosalario = salario + salario * reajuste / 100

        Console.WriteLine("O novo salario do funcionario " & funcionario & " é de " & novosalario)

    End Sub

End Module
