namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {   
        public override void Apresentar()  
        {
                System.Console.WriteLine($"Olá, meu nome é {Nome} e ganho RS{Salario}");
        }
    }
}