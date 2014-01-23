using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Utilisateur : EntityObject
    {
        private String _nom;
        private String _prenom;
        private String _login;
        private String _password;

        public Utilisateur(int id, String nom, String prenom, String login, String password) : base(id)
        {
            _nom = nom;
            _prenom = prenom;
            _login = login;
            _password = password;

        }

        public string Nom
        {
            set
            {
                _nom = value;
            }

            get
            {
                return _nom;
            }
        }

        public string Prenom
        {
            set
            {
                _prenom = value;
            }

            get
            {
                return _prenom;
            }
        }

        public string Login
        {
            set
            {
                _login = value;
            }

            get
            {
                return _login;
            }
        }

        public string Password
        {
            set
            {
                _password = value;
            }

            get
            {
                return _password;
            }
        }
        
    }
}
