algoritmo "ATIVIDADE 21"
var
   ano: inteiro
inicio
      Escreva("Digite qual ano para saber se � bissexto ou n�o: ")
      Leia(ano)
      se (ano%4=0) e ((ano%400=0) ou (ano%100<>0))entao
         Escreval("� um ano bissexto")
      senao
         Escreval("N�o � um ano bissexto")
      fimse
fimalgoritmo