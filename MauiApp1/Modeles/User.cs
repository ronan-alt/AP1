using AP1.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1.Modeles
{  
    public class User
    {
        #region propriete
        private int _id;
        private string _nom;
        private string _prenom;
        private string _password;
        private string _email;
        private string _statut;
        private Equipe _leEleve;
        private Equipe _laEquipe;
        private Apis _apis;

        #endregion
        #region constructeur
        public User(int id, string nom, string mdp, string email)
        {
            Id = id;
            Nom = nom;
            Password = mdp;
            Email = email;
            _leEleve = new Equipe();
            _laEquipe = new Equipe();
            _apis = new Apis();

        }
        public User(int id, string email, string password, string nom, string prenom)
        {
            _id = id;
            _email = email;
            _password = password;
            _nom = nom;
            _prenom = prenom;
        }
        #endregion
        #region getter/setter

        public int Id { get => _id; set => _id = value; }
        public string Statut { get => _statut; set => _statut = value; }
        public Equipe LeEleve { get => _leEleve; set => _leEleve = value; }
        public Equipe LaEquipe { get => _laEquipe; set => _laEquipe = value; }

        public Apis Apis { get => _apis; set => _apis = value; }

        [JsonProperty("Email")]
        public string Email { get => _email; set => _email = value; }
        [JsonProperty("Password")]
        public string Password { get => _password; set => _password = value; }
        [JsonProperty("Nom")]
        public string Nom { get => _nom; set => _nom = value; }
        [JsonProperty("Prenom")]
        public string Prenom { get => _prenom; set => _prenom = value; }
        #endregion
        #region methode
        #endregion
    }
}
