algoritmo "ATIVIDADE 30"
var
   L1, L2, L3: inteiro
inicio
      Escreval("------------------------")
      Escreval(" Calculo dos triangulos")
      Escreval("------------------------")
      Escreva("Digite o primeiro lado: ")
      Leia(L1)
      Escreva("Digite o segundo lado: ")
      Leia(L2)
      Escreva("Digite o terceiro lado: ")
      Leia(L3)
      Escreval("----------------")
      Escreval("CALCULANDO")
      Escreval("----------------")
      se ((L1 <= L2 + L3) e (L3 <= L1 + L2) e (L2 <= L1 + L3))entao
         Escreval("Um triangulo pode ser formado")
      senao
         Escreval("N�o se pode formar um triangulo")
      fimse
      se (L1 = L2) e (L2 = L3)entao
         Escreval("� um triangulo EQUIL�TERO")
         Escreval("Tem todos os lados iguais")
      senao
           se (((L1 <> L2) e (L2 = L3)) ou ((L3 <> L1) e (L1 = L2)) ou ((L3 <> L2) e (L3 = L1))) entao
                   Escreval("� um tri�ngulo IS�SCELES")
                   Escreval("Tem dois lados iguais")
           senao
                Escreval("� um triangulo ESCALENO")
                Escreval("Tem todos os lados diferentes")
           fimse
      fimse

fimalgoritmo