using Interface.Interfaces;


namespace Interface.Classes
{
    public class Arte : IArte
    {
        public Arte()
        {
            this.Nome = "";
            this.Descricao = "";
        }

        public Arte(string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        private string nome;
        public string Nome
        {
            get { return this.nome; }

            set { this.nome = value.ToUpper(); }
        }

        private string descricao;
        public string Descricao
        {
            get { return this.descricao; }

            set { this.descricao = value.ToUpper(); }
        }
        public void ExibiDados()
        {
            Console.WriteLine("Arte: {0} - Descricao: {1}", this.Nome, this.Descricao);
        }
    }
}
