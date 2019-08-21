using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Enari_Classe_Usuario
{
    class Usuario
    {
        //Atributos
        private string nome, sobrenome, login, senha, email;


        public string Getnome()
        {
            return nome;
        }

        public string Getsobrenome()
        {
            return sobrenome;
        }

        public string Getlogin()
        {
            return login;
        }

        public string Getsenha()
        {
            return senha;
        }

        public string Getemail()
        {
            return email;
        }

        public void Setnome(string x)
        {
            nome = x;
        }

        public void Setsobrenome(string x)
        {
            sobrenome = x;
        }

        public void Setlogin(string x)
        {
            login = x;
        }

        public void Setsenha(string x)
        {
            senha = x;
        }

        public void Setemail(string x)
        {
            email = x;
        }

    }
     
}


