
﻿using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class InHouseClass
    {
        public InHouseClass()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public string Comments { get; set; }
        public string UniqueNo { get; internal set; }

        internal string Print()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Class: {UniqueNo}");
            foreach (var st in Students)
            {
                sb.AppendLine($"{st.Print()}");
            }
            foreach (var tc in Teachers)
            {
                sb.AppendLine($"{tc.Print()}");
            }

            return sb.ToString();
        }
    }
}