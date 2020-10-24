using System;
using System.Collections.Generic;
using System.Text;

namespace IAB330Bloomboard.Models
{
    class TextInfo
    {
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public string Title { get; set; }

        public TextInfo(string Text, DateTime DateTime, string Title)
        {
            this.Text = Text;
            this.DateTime = DateTime;
            this.Title = Title;
        }
    }
}
