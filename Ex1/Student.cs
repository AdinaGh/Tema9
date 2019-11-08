
﻿using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class School
    {
        public School()
        {
            Classes = new List<InHouseClass>();
        }
        public string Name { get; set; }
        public List<InHouseClass> Classes { get; set; }

        internal string Print()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"School: {Name}");
            foreach (var cl in Classes)
            {
                sb.AppendLine($"{cl.Print()}");
            }

            return sb.ToString();
        }
    }
}
