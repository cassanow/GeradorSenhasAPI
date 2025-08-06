using System.Text;
using GeradorSenhasAPI.Interface;
using GeradorSenhasAPI.Model;

namespace GeradorSenhasAPI.Service;

public class SenhaService : ISenhaService
{
   public string GerarSenha(GerarSenhaRequest senhaRequest)
   {
      Random random = new Random();
      var tamanhoSenha = random.Next(10, 20);
      char[] senha = new char[tamanhoSenha];
      
      while (senhaRequest.Tamanho != tamanhoSenha)
      {
            senhaRequest.Tamanho++;
            var sorteio = random.Next(1,4);
            var indice = 0;

            if (sorteio == 1)
            {
               senha[indice] = CaracteresEspeciais();
            }
            
            else if (sorteio == 2)
            {
               senha[indice] = CaracteresNumeros();
            }
            
            else if (sorteio == 3)
            {
               senha[indice] = CaracteresMaiusculas();
            }
            
            else if (sorteio == 4)
            {
               senha[indice] = CaracteresMinusculas();
            }
      }

      return TransformarEmString(senha);
   }

   public char CaracteresEspeciais()
   {
      Random random = new Random();
      var caracteresEspeciais = new List<char> { '!', '@', '#', '$', '%', '^', '&', '*', ' ' };

      int indice = random.Next(caracteresEspeciais.Count);

      char caractereEscolhido = caracteresEspeciais[indice];

      return caractereEscolhido;
   }

   public char CaracteresMaiusculas()
   {
      Random random = new Random();
      var letrasMaiusculas = new List<char>
      {
         'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
         'W', 'X', 'Y', 'Z'
      };

      int indice = random.Next(letrasMaiusculas.Count);

      char letraEscolhida = letrasMaiusculas[indice];

      return letraEscolhida;
   }

   public char CaracteresMinusculas()
   {
      Random random = new Random();

      var letrasMinusculas = new List<char>
      {
         'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
         'w', 'x', 'y', 'z'
      };
      
      int indice = random.Next(letrasMinusculas.Count);
      
      char letraEscolhida = letrasMinusculas[indice];
      
      return letraEscolhida;
   }

   public char CaracteresNumeros()
   {
      Random random = new Random();
      
      var numeros = new List<char> {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
      
      int indice = random.Next(numeros.Count);
      
      char numero = numeros[indice];
      
      return numero;
   }

   public string TransformarEmString(char[] senha)
   {
      StringBuilder resultado = new StringBuilder();

      foreach (var letra in senha)
      {
         resultado.Append(letra);   
      }
      
      var senhaFinal = resultado.ToString();

      return senhaFinal;
   }
}