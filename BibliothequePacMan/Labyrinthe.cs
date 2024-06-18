using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque_PacMan
{
    public class Labyrinthe // Classe Labyrinthe
    {
        private List<UneCellule> cellules; // Liste des cellules du labyrinthe (la classe UneCellule est détaillé sur une autre page)
        private List<UneCellule> chemin; // Liste de cellules qui représente le chemin emprunté par l'algorithme de parcours en profondeur
        private int hauteur; // Hauteur du labyrinthe (dimension vertical)
        private int largeur; // Largeur du labyrinthe (dimension horizontal)
        private int seed; // Graine de la génération aléatoire

        public Labyrinthe(int hauteur, int largeur) // Constructeur de la classe Labyrinthe prenant en paramètres deux dimensions (hauteur et largeur)
        {
            this.hauteur = hauteur;
            this.largeur = largeur;

            cellules = new List<UneCellule>();
            chemin = new List<UneCellule>();

            init();
            initSeed();
        }

        public Labyrinthe(int taille) // Constructeur de la classe Labyrinthe prenant en paramètre une dimension (hauteur = largeur)
        {
            hauteur = taille;
            largeur = taille;

            cellules = new List<UneCellule>();
            chemin = new List<UneCellule>();

            init();
            initSeed();
        }

        private void init() // Fonction d'initialisation des cellules (cases du labyrinthe)
        {
            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    cellules.Add(new UneCellule(i, j));
                }
            }
        }

        private void initSeed()
        {
            Random rand = new Random();
            seed = rand.Next();
        }

        private void addAllVoisins() // Fonction permettant d'ajouter une liste de voisins à chaque cellule
        {
            int index = 0;

            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    if (j < largeur - 1)
                    {
                        cellules[index].addVoisin(cellules[i * largeur + j + 1]);
                    }

                    if (i < hauteur - 1)
                    {
                        cellules[index].addVoisin(cellules[(i + 1) * largeur + j]);
                    }
                    index++;
                }
            }
        }

        public List<UneCellule> getCellules()
        {
            return cellules;
        }

        public void setSeed(int seed) // Fonction permettant de saisir une seed (graine de la génération aléatoire) pour notre labyrinthe
        {
            this.seed = seed;
        }

        public int getSeed() // Fonction (getter) permettant d'obtenir la valeur de la seed en dehors de cette classe
        {
            return seed;
        }

        public void algoParcoursProfondeur() // Fonction algoParcoursProfondeur qui construit de manière aléatoire le labyrinthe en utilisant un algorithme de parcours en profondeur
        {
            Random rand = new Random(seed); // Une vaiable aléatoire initialisée avec notre seed (graine de la génération aléatoire)
            UneCellule currentCellule = cellules[0]; // Une cellule qui représente la cellule actuelle
            UneCellule nextCellule = currentCellule; // Une cellule qui représente la cellule suivante

            addAllVoisins(); // Appel de la méthode addAllVoisins décrite précédemment
            chemin.Add(currentCellule); // Ajout de la case de départ au chemin

            for (int i = 0; i < cellules.Count; i++) // On parcours toute les cellules du labyrinthe
            {
                cellules[i].randomVoisin(rand); // On mélange aléatoirement les voisins de chaque cellule
            }

            while (!cellules.All(cellule => cellule.getVisit() == true)) // Boucle principale (tant que toutes les cellules ne sont pas visitées)
            {
                if (currentCellule.getVoisins().All(voisin => voisin.getVisit() == true))  // Si tous les voisins de la cellule actuelle sont déjà visités alors ...
                {
                    currentCellule.setVisit(true); // On affecte l'état "visitée" à la cellule actuelle

                    while (currentCellule.getVoisins().All(voisin => voisin.getVisit() == true)) // Tant que touts les voisin de la cellule actuelle sont déjà visitées
                    {
                        if (chemin.Count == 0) // Si la liste du chemin est vide
                        {
                            break; // Alors on arrète la boucle
                        }
                        currentCellule = chemin.Last(); // On assigne à la cellule actuelle la dernière cellule du chemin
                        chemin.RemoveAt(chemin.Count - 1); // Puis, on supprime cette cellule de la liste du chemin
                    }
                    nextCellule = currentCellule; // On assigne la nouvelle cellule comme cellule actuelle
                }
                else // Sinon ...
                {
                    nextCellule = currentCellule.getVoisins().First(cellule => cellule.getVisit() == false); // On prend comme nouvelle cellule la première cellule (non visitée) dans la liste des voisins de la cellule actuelle
                    currentCellule.addLien(nextCellule); // On ouvre une porte entre la cellule actuelle et la nouvelle cellule
                }

                chemin.Add(nextCellule); // On ajoute la nouvelle cellule à la liste du chemin
                currentCellule = nextCellule; // On assigne la nouvelle cellule comme cellule actuelle
            }
            verif();
        }

        public void verif() // Fonction de vérification qui assure que le labyrinthe ne comporte aucune impasse
        {
            for (int i = 0; i < cellules.Count; i++)
            {
                while (cellules[i].getLiens().Count < 2)
                {
                    cellules[i].addLien(cellules[i].getVoisins().First(cellule => cellule.isLien(cellules[i]) == false));
                }
            }
        }
    }
}
