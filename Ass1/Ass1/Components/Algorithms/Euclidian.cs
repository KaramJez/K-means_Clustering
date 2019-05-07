using System;
using System.Collections.Generic;
using System.Text;
using Ass1.Models;

namespace Ass1.Components.Algorithms
{
    public class Euclidian
    {
        public double Calculate(Vector vector, Vector centroid)
        {
            double similarity = 0;
            for (int i = 0; i < vector.Points.Count; i++)
            {
                similarity += Math.Pow(vector.Points[i] - centroid.Points[i], 2);
            }

            return Math.Sqrt(similarity);
        }
    }
}
