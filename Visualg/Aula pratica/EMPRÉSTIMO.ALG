algoritmo "EMPR�STIMO"
var
   Empres, dinheiro: real
   Parcel: inteiro
inicio
      Escreva("Quantos de empr�stimo voc� quer pegar? R$")
      Leia(dinheiro)
      Escreval("Quantas parcelas?")
      Leia(Parcel)
      Empres <- ((((dinheiro*20)/100)+dinheiro)/Parcel)
      Escreva("Ent�o ser� R$", Empres, " por m�s, em ", Parcel, " Vezes" )
      
fimalgoritmo