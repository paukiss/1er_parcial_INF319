import System.IO

main = do
    let suma x y = x + y 
    let resta x y = x - y 
    let multiplicacion x y = x * y 
    let division x y = x / y 
    
    putStrLn "Introduzca un numero"
    num1 <- getLine
    let n1 = read num1 :: Double
    putStrLn "Introduzca un numero"
    num2 <- getLine
    let n2 = read num2 :: Double
    putStrLn "Suma"
    print (suma n1 n2)
    putStrLn "Resta"
    print (resta n1 n2)
    putStrLn "Mutiplicacion"
    print (multiplicacion n1 n2)
    putStrLn "Division"
    print (division n1 n2)

    