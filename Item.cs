using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RLTrading
{
    public class Item
    {
        #region Property
        public bool Blueprint { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Color color;

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        private Certification certification;

        public Certification Certification
        {
            get { return certification; }
            set { certification = value; }
        }

        private Quality quality;

        public Quality Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        #endregion

        #region Ctor
        public Item()
        {

        }

        public Item(string name, Color color, Certification certification, Quality quality, bool blueprint = false)
        {
            Name = name;
            Color = color;
            Certification = certification;
            Quality = quality;
            Blueprint = blueprint;
        }

        #endregion
    }
}
