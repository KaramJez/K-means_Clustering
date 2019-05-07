using System.Collections.Generic;

namespace Ass1.Models
{
    public class Vector
    {
        public List<float> Points { get; set; }
        public int Centroid { get; set; }
        public double? Distance { get; set; }

        #region Constructors

        public Vector()
        {
            this.Points = new List<float>();
        }

        public Vector(List<float> points)
        {
            this.Points = points;
        }

        public Vector(int size)
        {
            this.Points = new List<float>();
            for (int i = 0; i < size; i++)
            {
                this.Points.Add(0);
            }
        }

        #endregion
    }
}
