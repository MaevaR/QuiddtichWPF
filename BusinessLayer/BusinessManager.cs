﻿using EntitiesLayer;
using StubDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessManager
    {
        DalManager _d;

        public DalManager D
        {
            get { return _d; }
            set { _d = value; }
        }

        public BusinessManager()
        {
            _d = new DalManager();
        }

        public List<Joueur> ListJoueurs()
        {
           return _d.Joueurs();
        }
        public List<Equipe> ListEquipes()
        {
            return _d.Equipes();
        }
        public List<Match> ListMatchs()
        {
            return _d.Matchs();
        }
        public List<Stade> ListStades()
        {
            return _d.Stades();
        }
        public List<Coupe> ListCoupes()
        {
            return _d.Coupes();
        }



        public Boolean PasswordCheck(String login, String password)
        {
#if DEBUG
            return true;
#endif
            Utilisateur user = _d.GetUtilisateurByLogin(login);
            return (user.Password == password);
        }

        public List<String> AfficheMatchsProgrammés()
        {
            List<String> res = new List<String>();
            List<Match> liste = _d.Matchs();

            IEnumerable<Match> requeteOrdonnee = from i in liste.Distinct()
                                                 orderby i.Date
                                                 select i;
            
           res.Add("Id|  Date    |     Stade    |    Domicile    |   Visiteur   |");
            foreach( Match ligne in requeteOrdonnee)
            {
                res.Add(ligne.Id.ToString() + " " + ligne.Date.ToShortDateString() + " " + ligne.Stade.Nom + " " + ligne.EquipeDomicile.Nom + "     " + ligne.EquipeVisiteur.Nom + " ");
            }
            res.Add(" ");
            return res ;
        }

        public List<String> AfficheStadesProgrammés()
        {
            List<String> res = new List<String>();
            List<Match> liste = _d.Matchs();

            IEnumerable<Stade> requete = from i in liste
                                                 select i.Stade;

            IEnumerable<Stade> requete2 = from i in requete.Distinct()
                                         select i;

            res.Add("   Stade      |    Adresse    |");

            foreach (Stade ligne in requete2)
            {
                res.Add(ligne.Nom + " " + ligne.Adresse + " ");
            }
            res.Add(" ");
            return res;
        }

        public List<String> AfficheAttrapeursADomicile()
        {
            List<String> res = new List<String>();
            List<Match> listeMatch = _d.Matchs();
            List<Joueur> listeJoueur = _d.Joueurs();
            List<Equipe> listeEquipe = _d.Equipes();
            
            IEnumerable<Equipe> requete = from i in listeMatch
                                                 select i.EquipeDomicile;

            IEnumerable<Joueur> requeteFinale =  from j in requete.Distinct()
                                                 from i in j.Joueurs
                                                 where i.Poste == poste.attrapeur
                                                 select i;

            res.Add("  Joueur    |Score|Selections|");
            foreach (Joueur ligne in requeteFinale)
            {
                res.Add(ligne.Nom + " " + ligne.Prenom + "   " + ligne.Score + "     " + ligne.NbSelection + " ");
            }
            res.Add(" ");

            return res;

        }

    }
}
