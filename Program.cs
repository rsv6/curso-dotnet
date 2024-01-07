using System;
using System.Text;
using TopicsDotNet.Topics;

namespace TopicsDotNet;

class Program
{
    static void Main(string[] args)
    {
        // GerandoIDGuidID();
        // ComparandoString();
        // manipulandoString();
        ManipularDatas.ExecutarDatas();
    }

    static void manipulandoString()
    {
        var texto = new StringBuilder();
        // var texto = "Este texto é um teste";
        // Console.WriteLine(texto.IndexOf("é"));
        // Console.WriteLine(texto.LastIndexOf("s"));
        // Console.WriteLine(texto.Insert(5, "AQUI "));
        // Console.WriteLine(texto.Remove(5, 5));

        texto.Append("adiciona texto dinamicamente\n");
        texto.Append("Adicionando mais linhas\n");
        texto.Append("Adicionando mais conteudo dinamicamente\n");

        texto.ToString();

        Console.WriteLine(texto);


    }

    static void ComparandoString()
    {
        // var texto = "Testando";
        var texto2 = "Este texto é um Teste";

        // Console.WriteLine(texto.CompareTo("Testando")); // 0 = igual
        // Console.WriteLine(texto.CompareTo("testando")); // 1 = igual

        // Console.WriteLine(texto2.Contains('é')); // True/False
        // Console.WriteLine(texto2.Contains("teste", StringComparison.OrdinalIgnoreCase));
  
        // Console.WriteLine(texto2.StartsWith("Este"));
        // Console.WriteLine(texto2.StartsWith("este"));

        // Console.WriteLine(texto2.EndsWith("Teste"));
        // Console.WriteLine(texto2.EndsWith("teste"));

        // Equal tambem compara TYPE:

        Console.WriteLine(texto2.Equals("Este"));
        Console.WriteLine(texto2.Equals("este"));
        Console.WriteLine(texto2.Equals("teste", StringComparison.OrdinalIgnoreCase));
    }

    static void GerandoIDGuidID() 
    {
        Guid id = Guid.NewGuid();
        id.ToString();

        id = new Guid(Guid.NewGuid().ToString());

        Console.WriteLine(id.ToString().Replace("-","").ToUpper());
    }
}