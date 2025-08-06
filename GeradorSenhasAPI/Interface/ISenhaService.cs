using GeradorSenhasAPI.Model;

namespace GeradorSenhasAPI.Interface;

public interface ISenhaService
{
    char CaracteresEspeciais();
    
    char CaracteresMaiusculas();
    
    char CaracteresMinusculas();
    
    char CaracteresNumeros();
    
    string TransformarEmString(char[] senha);

    string GerarSenha(GerarSenhaRequest senhaRequest);
}