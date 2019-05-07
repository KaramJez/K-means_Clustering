using Ass1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ass1.Components
{
    public class Parser
    {
        public List<Vector> Parse(char delimiter, string path)
        {
            var entries = new List<Vector>();

            try
            {
                var lines = File.ReadAllLines(path)
                    .Select(l => l.Split(delimiter)).ToList();

                for (int i = 0; i < lines.Count(); i++)
                {
                    var line = lines[i];

                    for (int j = 0; j < line.Length; j++)
                    {
                        if (entries.ElementAtOrDefault(i) == null)
                        {
                            var newVector = new Vector();
                            entries.Insert(i, newVector);
                        }

                        var vector = entries.ElementAtOrDefault(i);
                        vector.Points.Insert(j, float.Parse(line[j]));
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nDe file kan niet worden gelezen.");
                Console.ReadKey();

                Environment.Exit(0);
            }

            return entries;
        }
    }
}
