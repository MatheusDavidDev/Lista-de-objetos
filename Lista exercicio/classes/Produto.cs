namespace Lista_exercicio.classes
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }

        //comando clw aparece o console.writelane mais rapido

        public Produto(){

        }
        public Produto(int _codigo, string _nome, float _preco){
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }
    }


}