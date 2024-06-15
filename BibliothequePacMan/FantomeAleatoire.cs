using BibliothequePacMan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bibliotheque_PacMan
{
    public class FantomeAleatoire : Character
    {
        private int _speed = 400;
        private bool _isRunning = false;

        public FantomeAleatoire(Image image, UneCellule uneCellule) : base(image, uneCellule)
        {

        }

        public async void LoopStart(bool isVictory, bool isDefeat)
        {
            if (!_isRunning && ! isVictory && !isDefeat)
            {
                _isRunning = true;
                await RunLoopAsync();
            }
        }

        private async Task RunLoopAsync()
        {
            Random random = new();
            UneCellule lastCellule = CurrentCellule;
            List<UneCellule> cellulesVisited = [lastCellule];

            while (_isRunning)
            {
                UneCellule nextCellule = CurrentCellule.getVoisins().First(cellule => cellule.isLien(CurrentCellule) && cellule != cellulesVisited.Last());
                Point point = new(nextCellule.getY() * 50 + 2, nextCellule.getX() * 50 + 2);
                Position = point;
                lastCellule = CurrentCellule;
                cellulesVisited.Add(CurrentCellule);
                CurrentCellule = nextCellule;

                if (cellulesVisited.Contains(CurrentCellule))
                {
                    for (int i = 0; i < cellulesVisited.Count; i++)
                    {
                        cellulesVisited[i].randomVoisin(random);
                    }
                    cellulesVisited.Clear();
                    cellulesVisited = [CurrentCellule, lastCellule];
                }

                await Task.Delay(_speed);
            }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public bool IsRunning
        {
            get { return _isRunning; }
            set { _isRunning = value; }
        }
    }
}
