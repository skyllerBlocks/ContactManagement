namespace ContactManagement.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
//Um contato é uma entidade com 4 campos: ID, Nome, Contato e endereço de e-mail. O nome deve ser uma string de qualquer tamanho maior que 5, o contato deve ter 9 dígitos e o e-mail deve ser um e-mail válido.