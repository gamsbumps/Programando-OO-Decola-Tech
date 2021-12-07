using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\Users\\guilh\\Documents\\TrabalhandoComArquivos";
            var caminhoPatchCombine = Path.Combine(caminho, "Pasta Teste 3");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho,"Pasta Teste 2", "arquivo-teste-stream.txt");

            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};
            FileHelper helper = new FileHelper();

            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarDiretorio(caminhoPatchCombine);
            //helper.ApagarDiretorio(caminhoPatchCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "olá! teste de escrita de arquivo");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivo(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);
            

            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10, 20));


            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());


            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();


            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma" + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da segunda soma" + calc.Somar(10, 10, 10));    


            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Documento = "123123";
            // p1.Nota = 10;
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Bob";
            // p2.Idade = 20;
            // p2.Documento = "123123";
            // p2.Salario = 2300;
            // p2.Apresentar();
           
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}m2");

            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}m2");
           
           
           
           
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
}