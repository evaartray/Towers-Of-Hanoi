using System;

namespace blazorserver02.Data
{
    public class Tower {
        protected string color;
        public bool isClicked;
        public Tower() {
            this.isClicked = true;
            this.color = "#000080";
        }
        public string myColor() => this.color;
}
    }
    