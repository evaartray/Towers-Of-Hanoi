using System;

namespace blazorserver02.Data
{
    public class HanoiDisk {
        public int size;
        public string color;

        public HanoiDisk(int size, string color)
        {
            this.size = size;
            this.color = color;
        }
    }
}
    