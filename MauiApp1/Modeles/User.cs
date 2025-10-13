using AP1.Services;
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
        private string _mdp;
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
            Mdp = mdp;
            Email = email;
            _leEleve = new Equipe();
            _laEquipe = new Equipe();
            _apis = new Apis();

        }
        #endregion
        #region getter/setter
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Mdp { get => _mdp; set => _mdp = value; }
        public string Statut { get => _statut; set => _statut = value; }
        public Equipe LeEleve { get => _leEleve; set => _leEleve = value; }
        public Equipe LaEquipe { get => _laEquipe; set => _laEquipe = value; }

        public Apis Apis { get => _apis; set => _apis = value; }
        public string Email { get => _email; set => _email = value; }
        #endregion
        #region methode
        #endregion
    }
}
