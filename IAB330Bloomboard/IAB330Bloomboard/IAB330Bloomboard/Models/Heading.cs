using System;
using System.Collections.Generic;
using System.Text;

namespace IAB330Bloomboard.Models
{
    class Heading
    {
        public string Title { get; set; }
        public string Colour { get; set; }

        public Heading(string Title, string Colour)
        {
            this.Title = Title;
            this.Colour = Colour;
        }

    }
}
