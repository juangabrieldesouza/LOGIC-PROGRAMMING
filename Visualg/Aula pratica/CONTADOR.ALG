algoritmo "Contador"

var
   contador, n, m: inteiro
inicio
      contador <- 0
      Escreval("at� quantos voc� quer contar? ")
      Leia(n)
      Escreval("Qual o valor do salto? ")
      Leia(m)
      Enquanto (contador <= n) faca
               Escreval(contador)
               contador <- contador + m
      FimEnquanto
fimalgoritmo