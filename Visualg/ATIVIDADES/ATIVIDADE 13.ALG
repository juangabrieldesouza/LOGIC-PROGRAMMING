algoritmo "ATIVIDADE 13"
var
   S, NS: REAL
   N: caractere
inicio
      Escreva("Digite o nome do funcionario: ")
      Leia(N)
      Escreva("Digite o sal�rio atual do funcionario: ")
      Leia(S)
      NS <- S + ((S*15)/100)
      Escreval("----------------------------")
      Escreval("Nome: ", N)
      Escreval("Novo Sal�rio: ", NS)
fimalgoritmo