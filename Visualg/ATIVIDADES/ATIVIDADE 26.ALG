algoritmo "ATIVIDADE 26"
var
   N1, N2: real
inicio
      Escreva("Digite um n�mero: ")
      Leia(N1)
      Escreva("Digite outro n�mero: ")
      Leia(N2)
      se(N1 < N2) entao
            Escreval("O n�mero ", N2, " � maior")
      senao
           se(N1 > N2)entao
                 Escreval("O n�mero ", N1, " � maior")
           senao
                 Escreval("N�o tem um n�mero maior, os dois s�o iguais")
           fimse
      fimse

fimalgoritmo