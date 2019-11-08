using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
    {
        class Teacher : People
        {
            public Teacher()
            {
                Disciplines = new List<Discipline>();
            }
            public List<Discipline> Disciplines { get; internal set; }

            public string Comments { get; set; }

            internal object Print()
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Teacher:{Name}");
                foreach (var st in Disciplines)
                {
                    sb.AppendLine($"{st.Print()}");
                }

                return sb.ToString();
            }
        }
    }
 
