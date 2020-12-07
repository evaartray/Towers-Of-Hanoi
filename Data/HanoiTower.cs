using System;
using System.Linq;
using System.Collections.Generic;

namespace blazorserver02.Data
{
    public class HanoiTower {
        private HanoiGame parent;
        protected bool selected;
        public int currentDiskCounter = 0;
        public List<HanoiDisk> Disks = new List<HanoiDisk>();

        public HanoiTower(HanoiGame parent)
        {
            this.parent = parent;
        }
        public bool pushDisk(HanoiDisk disk)
        {
            Disks.Add(disk);
            startDiskCounter();
            return true;
        }
        public HanoiDisk popDisk()
        {
            var disk = getNextDisk();
            if(disk !=null){
                Disks.Remove(disk);
            }
            startDiskCounter();
            return disk;
        }
        private void startDiskCounter()
        {
            this.currentDiskCounter = Disks.Count();
        }
        public HanoiDisk getNextDisk()
        {
            var disk = Disks.FirstOrDefault();
            return disk;
        }
        public bool isSelected()
        {
            return this.selected;
        }
        public void selection(bool trueForSelected)
        {
            this.selected = trueForSelected;
        }

    }
}
    