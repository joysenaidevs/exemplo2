namespace exemplo2.classe
{
    public class Pessoa
    {
        private string nome;
        public string Nome{
            get{return nome;}
            set{nome = value;}
        }

        private string sobreNome;
        public string SobreNome{
            get{return sobreNome;}
            set{sobreNome = value;}
        }
        public Pessoa(){

        }
        public Pessoa(string firstName, string lastName){
        this.sobreNome = lastName;
        this.nome = firstName;
        }
        public Pessoa(string firstName){
            nome = firstName;
        }

    }
}