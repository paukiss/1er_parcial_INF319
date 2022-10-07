# Pregunta 3 - En Python realice un programa lógico de relación abuelos, nietos y primos (usando librerías de Prolog).
from pyswip import Prolog

prolog = Prolog()

prolog.assertz("padrede('Marco', 'Daniela')")
prolog.assertz("padrede('Pedro', 'Marco')")
prolog.assertz("padrede('Pedro', 'Marcela')")
prolog.assertz("padrede('Pedro', 'Carlos')")
prolog.assertz("padrede('Marcela', 'Jose')")

prolog.assertz("hijode(A,B) :- padrede(B,A)")

prolog.assertz("abuelode(A,B) :- padrede(A,C), padrede(C,B)")

prolog.assertz("hermanode(A,B) :- padrede(C,A),padrede(C,B),A\==B")

prolog.assertz("primode(A,B) :- padrede(Z,A),padrede(W,B),hermanode(Z,W)")

prolog.assertz("nietode(A,B) :- padrede(B,C),padrede(C,A)")

prolog.assertz("familiarde(A,B) :- padrede(A,B)")
prolog.assertz("familiarde(A,B) :- hijode(A,B)")
prolog.assertz("familiarde(A,B) :- abuelode(A,B)")
prolog.assertz("familiarde(A,B) :- hermanode(A,B)")
prolog.assertz("familiarde(A,B) :- primode(A,B)")

print("\nAbuelos de:")
for elem in prolog.query("abuelode(A,B)"):
    print(elem)

print("\nNietos de:")
for elem in prolog.query("nietode(A,B)"):
    print(elem)

print("\nPrimo de:")
for elem in prolog.query("primode(A,B)"):
    print(elem)

# for elemento in prolog.query("familiarde(X,Y)"):
#     print(elemento["X"],"es el familiar de",elemento["Y"])
