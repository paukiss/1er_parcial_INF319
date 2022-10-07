# Primer Parcial - INF319
## Univ. Sergio Alejandro Paucara Saca

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://github.com/paukiss)

Primer examen parcial de la materia INF319 - Programacion Funcional en la Universidad Mayor de San Andres a cargo del docente Moises Martin Silva Choque.
Gestion II / 2022.

- ⭐Mediante uso de GOTO en Visual Basic, realice el ordenamiento de 3 números.💻
- ⭐El c# con orientación a objetos realiza un aplicativo similar a la calculadora de Windows💻
- ⭐Python realice un programa lógico de relación abuelos, nietos y primos (usando librerías de Prolog).💻
- ⭐En R obtenga un grafica similar de iris usando solamente plot💻
- ⭐Realice un programa que mediante funciones las operaciones de suma, resta, multiplicación y división de números, la misma en f#💻
- ⭐Realice un programa que mediante funciones las operaciones de suma, resta, multiplicación y división de números, la misma en haskell💻
- ⭐Realice un programa que mediante funciones las operaciones de suma, resta, multiplicación y división de números, la misma en python🎮
## Caracteristicas
Este proyecto fue generado en:
- Visual Basic, F#, C# en .Net 6.0
- Python 3.9.7
- The Glorious Glasgow Haskell Compilation System, version 9.4.2
- R version 4.2.1 (2022-06-23 ucrt)
    Platform: x86_64-w64-mingw32/x64 (64-bit)
    Running under: Windows 10 x64 (build 19044)

## Instalacion
### _Instalar Visual Studio_ 
- Descargar [Visual Studio](https://visualstudio.microsoft.com/es/downloads/)
- Instale el instalador de Visual Studio.
### _Instalar Python y Prolog_ 
- Descargar y ejecutar [Python](https://www.python.org/downloads/)
- Descargar y ejecutar [SWI-Prolog](https://www.swi-prolog.org/download/stable)
    Instalar PySwip permite consultar SWI-Prolog en sus programas de Python.
    ```sh
    pip install pyswip
    ```
### _Instalar Python y Prolog_ 
- Descargar y ejecutar [R para Windows](https://cran.r-project.org/bin/windows/base/)

## Desarrollo

### _First Start_

Se desarrollo un script en ***Windows Forms app Visual Basic*** para el ordenamiento de 3 numeros, la ejecucion del programa se puede observar en la siguiente imagen. Solo utilizando instruccion de condicionales y la funcion **GoTo**
### _Second Start_
Utilizando POO (Programacion Orientada de Objetos) se desarrollo una calculadora standar con instruciones de suma, resta, multiplicacion, division y potencia.
### _Third Start_
En base al predicado X es padre de Y o **padreDe(X,Y)**, se realizo un programa logico de relacion de abuelos, nietos y primos en Python.
Ejemplo de *Árbol genealógico*:

Resultado:

### _Forth Start_
Se genero una grafica a partir del dataFrame ***Iris*** que viene en R. Donde se manda los siguiente atributos a la funcion **plot**:
- iris[1:4] = Fue para graficar solo las columnas de Sepal.Length, Sepal.Width, Petal.Length y Petal.Width
- pch = 21: Para los simbolos de los graficos usados cuando se muestran puntos de datos. 
- col: Para darle colores a los bordes de los puntos de datos.
```
plot(iris[1:4], pch = 21, col = c("red", "green", "blue")[iris$Species])
```

### _Fifth Start_
Se realizo un script en F#, utilizando programacion funcional para las operaciones de suma, resta, multiplicacion y division de numeros.

### _Sixth Start_
Se realizo un script en Haskell, utilizando programacion funcional para las operaciones de suma, resta, multiplicacion y division de numeros.

### _Seventh Start_
Se realizo un script en Python, utilizando programacion funcional para las operaciones de suma, resta, multiplicacion y division de numeros.


