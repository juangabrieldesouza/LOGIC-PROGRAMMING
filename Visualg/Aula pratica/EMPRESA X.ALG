algoritmo "EMPRESA X"
var
   N: Caractere
   S, G: REAL
   D: inteiro
inicio
      Escreva("Qual o nome do funcion�rio? ")
      Leia(N)
      Escreva("Qual o Sal�rio do Funcion�rio? ")
      Leia(S)
      Escreva("Qual � a quantidade de dependentes? ")
      Leia(D)
      Escolha D
              Caso 0
                   G <- S + (S*5/100)
              Caso 1, 2, 3
                   G <- S + (S*10/100)
              Caso 4,5,6
                   G <- S + (S*15/100)
              OutroCaso
                   G <- S + (S*18/100)
      FimEscolha
      Escreval("O novo salario de ", N, " Ser� de R$", G:5:2)
fimalgoritmo