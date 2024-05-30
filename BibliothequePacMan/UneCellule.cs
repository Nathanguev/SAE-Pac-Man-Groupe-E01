using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque_PacMan
{
    public class UneCellule // Classe UneCellule
    {
        private int x; // Position en x
        private int y; // Position en y
        private List<UneCellule> voisins; // Liste des voisins
        private List<UneCellule> liens; // Liste des liens (liens = porte)
        private bool isVisit; // Booléen indiquant si la cellule a déjà été visitée ou non

        public UneCellule(int x, int y) // Constructeur de la classe UneCellule
        {
            this.x = x;
            this.y = y;
            voisins = new List<UneCellule>();
            liens = new List<UneCellule>();
            isVisit = false;
        }

        public void setVisit(bool rep) // Fonction (setter) permettant de changer la valeur de l'attribut isVisited (booléen)
        {
            isVisit = rep;
        }

        public List<UneCellule> getVoisins() // Fonction (getter) permettant d'obtenir la liste des voisins d'une cellule
        {
            return voisins;
        }

        public List<UneCellule> getLiens() // Fonction (getter) permettant d'obtenir la liste des liens d'une cellule (lien = porte)
        {
            return liens;
        }

        public bool getVisit() // Fonction (getter) permettant d'obtenir la valeur de l'attribut isVisited (booléen)
        {
            return isVisit;
        }

        public void addVoisin(UneCellule c) // Fonction permettant d'ajouter une cellule à la liste des voisins de cette cellule
        {
            voisins.Add(c);
            c.voisins.Add(this);
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public bool isVoisin(UneCellule c) // Fonction booléenne qui retourne vrai ou faux selon que la cellule est voisine de celle-ci ou non
        {
            if (voisins.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void addLien(UneCellule c) // Fonction permettant d'ajouter une cellule à la liste des liens de cette cellule (lien = porte)
        {
            liens.Add(c);
            c.liens.Add(this);
            isVisit = true;
        }

        public bool isLien(UneCellule c) // Fonction booléenne qui retourne vrai ou faux selon que la cellule est liée à celle-ci ou non
        {
            if (liens.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void randomVoisin(Random rand) // Fonction qui mélange de façon aléatoire la liste des voisins de cette cellule
        {
            int comptVoisins = voisins.Count; // Nombre de voisins non triés

            while (comptVoisins > 1)
            {
                comptVoisins--;
                int voisinAleatoire = rand.Next(comptVoisins + 1);
                UneCellule value = voisins[voisinAleatoire];
                voisins[voisinAleatoire] = voisins[comptVoisins];
                voisins[comptVoisins] = value;
            }
        }

        public string affiche() // Fonction d'affichage de la position de cette cellule (x, y)
        {
            return x + "," + y;
        }
    }
}
