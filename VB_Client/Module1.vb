
Module Module1

    Sub Main()
        Dim wService = New SOAPSERVICES.AbcBolinhasPortTypeClient()
        Dim opcao = "a"

        While opcao <> "S"

            Console.Clear()

            Console.WriteLine("Digite 1 para verificar o CPF")
            Console.WriteLine("Digite 2 para verificar se o número é ímpar ou par")
            Console.WriteLine("Digite 3 para realizar uma operação matemática")
            Console.WriteLine("Digite S para Sair")
            opcao = Console.ReadLine().ToUpper()

            Console.Clear()

            If opcao = "S" Then
                Environment.Exit(0)

            ElseIf opcao = "1" Then

                Console.WriteLine("Digite um cpf para verificar se é válido")
                Dim cpf = Console.ReadLine()

                Dim resultadoCPF = wService.valida_CPF(cpf)
                Console.WriteLine(resultadoCPF)
                Console.ReadLine()

            ElseIf opcao = "2" Then

                Console.WriteLine("Digite um número para verificar se é par")
                Dim numero = Convert.ToInt32(Console.ReadLine())

                Dim resultadoPar = wService.verifica_NumeroPar(numero)
                Console.WriteLine(resultadoPar)
                Console.ReadLine()

            ElseIf opcao = "3" Then

                Console.WriteLine("Digite o operador do calculo")
                Dim operador = Console.ReadLine()

                Console.WriteLine("Digite o primeiro número do calculo")
                Dim num1 = Console.ReadLine()

                Console.WriteLine("Digite o segundo número do calculo")
                Dim num2 = Console.ReadLine()

                If operador = "/" And num2 = 0 Then
                    Console.WriteLine("Nenhum número pode ser dividido por 0(zero), tente novamente!!")
                    Console.ReadLine()
                    Continue While

                End If

                Dim resultadoMath = wService.math_operation(operador, num1, num2)
                Console.WriteLine(num1 + " " + operador + " " + num2 + " = " + resultadoMath)
                Console.ReadLine()

            End If

        End While

    End Sub

End Module
