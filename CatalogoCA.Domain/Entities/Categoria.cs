using CatalogoCA.Domain.Validation;

namespace CatalogoCA.Domain.Entities
{
    public sealed class Categoria : Entity
    {
        public Categoria(string nome, string imagemUrl)
        {
            ValidateDomain(nome, imagemUrl);   
        }

        public Categoria(int id, string nome, string imagemUrl) 
        {
            DomainExceptionValidation.When(id < 0, "valor de Id inválido");
            Id = id;
            ValidateDomain(nome, imagemUrl);
        }

        public string Nome { get; private set; }
        public string ImagemUrl { get; private set; }
        public ICollection<Produto> Produtos { get; set; }

        private void ValidateDomain(string nome, string imagemUrl)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(nome), "Nome inválido. O nome é obrigatório");

            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(imagemUrl), "Nome imagem inválido. O nome é obrigatório");

            DomainExceptionValidation.When(nome.Length < 3, "O nome deve ter no mínimo 3 caracteres");

            DomainExceptionValidation.When(nome.Length < 5, "O nome da imagem ter no mínimo 5 caracteres");

            Nome = nome;
            ImagemUrl = imagemUrl;
        }
    }
}
