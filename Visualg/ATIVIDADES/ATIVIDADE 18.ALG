algoritmo "ATIVIDADE 18"
var
   n: inteiro
inicio
      Escreval("--------------------------------")
      Escreval(" VERIFICA��O DE IDADE PARA VOTO ")
      Escreval("--------------------------------")
      Escreva("Digite seu ano de nascimento: ")
      Leia(n)
      Escreval("------------------------------")
      Escreval("     CALCULANDO RESULTADO     ")
      Escreval("------------------------------")
      n <- 2023 - n
      se (n >= 18) entao
         Escreva("Voc� tem idade o suficiente para votar")
      senao
         Escreva("Voc� ainda n�o pode votar")
      Fimse

      
fimalgoritmo