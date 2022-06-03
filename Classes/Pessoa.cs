using CadastroPessoas.Interfaces;

namespace CadastroPessoas.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? Name { get; set; }

        public float Rendimento { get; set; }

        public Endereco? Endereco { get; set; }

        public abstract float PagarImposto(float rendimento);
        
    }
}