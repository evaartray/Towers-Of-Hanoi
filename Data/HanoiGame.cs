using System;
using System.Linq;
using System.Collections.Generic;

namespace blazorserver02.Data
{
    public class HanoiGame {
        protected int svgHeight;
        protected int svgWidth;
        private List<HanoiTower> Towers = new List<HanoiTower>();
        public HanoiGame()
        {
        }
        public HanoiTower addTower(HanoiTower t)
        {
            if (t != null) {
                Towers.Add(t);
            }
            return t;
        }
        public HanoiTower getTower(int towerID)
        {
            return Towers.ElementAt(towerID);
        }
        public void toConsole()
        {
            var towerCounter = 0;
            foreach (var t in Towers)
            {
                System.Console.WriteLine($"Tower {towerCounter} - {t.currentDiskCounter} disks");
                towerCounter ++;

                if (!(t.Disks?.Any() ?? false))
                    continue;

                var discCounter = 0;
                foreach (var disk in t.Disks)
                {
                    System.Console.WriteLine($"Disk {discCounter} {disk.size} {disk.color}");
                    discCounter ++;
                }
            }

        }
        
        public int totalOfTower()
        {
            return Towers.Count();
        }
    }
}