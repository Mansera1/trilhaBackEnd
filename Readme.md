# OQUE É PROGRAMAÇÃO ORIENTADA A OBJETOS (POO) E SEUS PILARES


POO se propõe a projetar e escrever um sistema em que as entidades envolvidas como objetos, caracteristicas e responsabilidades tenham relações entre essas entidades


Os principais pilares da programação orientada a objetos são:
- Classes e Objetos
- Assosiação
- Encapsulamento
- Herança e Polimorfismo


 # Classe e Método Abstratos
 Classes abstratas são classes que não podem ser instanciadas, é uma forma de garantir herança total, somente a subclasses não abstratas podem ser instanciadas, mas nunca a superclasse abstrata
 
 
 Método abstrato é um método declarado abstrato, não contendo corpo e apenas sendo declarado dentro da classe abstrata
 Exemplo:
 
 
 public abstract void forma();
 
 
// indica que o método 'forma()' é abstrato


 
abstract class forma


// indica que a classe 'forma' é abstrata


 # Encapsulamento
 
 
 Encapsulamento se refere ao agrupamento de dados e métodos e uma classe, as ações são realizadas invocando os métodos, e o acesso deve ser controlado através de modificadores de acesso
 
 
 Exemplo:

using System;
  
public class Forma 
      
    
    public String Name
    
          
        get
        
            return formaName;    
        
          
        set 
        
            formaName = value;
        
          
    
      
    
    public int Cor
    
          
        get 
        
            return formaCor;    
        
          
        set 
        
            formaCor = value;
        
          
    
  
      

  
class Forma 
      
    
    static public void Main()
    
          
        
        Forma obj = new Forma();
  
        
        obj.Name = "Quadrado";
          
        
        obj.Cor = "Azul";
  
       
        Console.WriteLine("Forma: " + obj.Forma);
        Console.WriteLine("Cor: " + obj.Cor);
    
