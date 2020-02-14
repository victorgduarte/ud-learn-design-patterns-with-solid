namespace aprenda_design_patterns_com_solid
{

    /*

    1- Essa classe possui mais de uma responsabilidade, não tratando exclusivamente 
    apenas do cadastro de usuario. Tudo relacionado a email deveria estar em uma 
    classe email, para assim obedecer o primeiro princípio do S que é: uma classe
     deve ter somente uma responsabilidade.

    */
        public class CadastrarUsuario
        {
            public int id;
            public string nome;
            public string email;

        //Construtor
        public CadastrarUsuario(int id, string nome, string email)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;

        }

        public bool ValidarEmail(string email)
        {
            var address = new System.Net.Mail.MailAddress(email);
            return address.Address == email;
        }
        public void EnviarEmail(string email, string mensagem)
        {
            //string con = netManager.GetCon();
            //netManager.Send(email);

        } 

    }
}

