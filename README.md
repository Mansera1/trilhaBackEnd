# OQUE É TRATAMENTO DE EXCEÇÕES?


Tratamento de excções são mecanismos para comunicar condições de erros, se o programa não provê um código para tratar uma exceção, o sistema irá parar o programa


# BENEFICIOS
- Trata de forma organizada exceçoes de tipos diferentes
- A exceção pode carregar dados quaisquer
- Permite que erros sejam tratados de forma consistente e flexível, usando boas práticas


# DESVANTAGENS DE NÃO TRATAMENTO DE EXCEÇÕES
- Uso abusivo de IF e Else
- Programa confuso com a quantidade de informação 


# BLOCO FINALLY


Bloco que contém código a ser executado independentemente de ter ocorrigo ou não uma exceção, garante que o código definido no bloco smepre será executado mesmo ocorrendo uma exceção 


# ESTRUTURA TRY-CATCH


. Bloco try
- Contém o código que representa a execução normal do trecho de códgio que pode acarretar em uma exceção 


. Bloco catch
- Contém o códgio a ser executado caso uma exceção ocorra
- Deve ser especificado o tipo da exceção a ser tratada 


Exemplo


try{


}


catch (ExceptionType e) {


}


catch(ExceptionType e) {


}


catch (ExceptionType e) {


}
