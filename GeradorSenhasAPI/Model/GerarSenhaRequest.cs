namespace GeradorSenhasAPI.Model;

public class GerarSenhaRequest
{
    public int Tamanho { get; set; }

    public char CaracteresEspeciais { get; set; }
    
    public char CaracteresMaiusculas { get; set; }
    
    public char CaracteresMinusculas { get; set; }
    
    public char CaracteresNumeros { get; set; }
    
    
}