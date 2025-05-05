using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionFilms.Modeles
{
    public class Personne
    {
        private int _id;
        private string nom;
        private string _sexe;


        public int Id { get { return _id; } set { _id = value; } }
        public string Nom {  get { return nom; }  set { nom = value; } }

        public string Sexe { get { return _sexe; } set { _sexe = value; } }
    }
}
