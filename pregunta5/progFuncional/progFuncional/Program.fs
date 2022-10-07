
open System 
let suma a b = a + b
let resta a b = a - b
let multi a b = a * b
let division a b = a / b

[<EntryPoint>]
let main argv = 
    
    Console.Write("Intro num1: ")
    let num1=Convert.ToDouble(Console.ReadLine())
    Console.Write("Intro num2: ")
    let num2=Convert.ToDouble(Console.ReadLine())

    Console.Write("Suma: ")
    Console.WriteLine(suma num1 num2)
    Console.Write("Resta: ")
    Console.WriteLine(resta num1 num2)
    Console.Write("Multiplicacion: ")
    Console.WriteLine(multi num1 num2)
    Console.Write("Division: ")
    Console.WriteLine(division num1 num2)
    let tecla=Console.ReadKey()
    0
    