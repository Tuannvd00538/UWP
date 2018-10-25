using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_ASM.Entity
{
    class FileSave
    {
        private string name;
        private string content;

        public string Name { get => name; set => name = value; }
        public string Content { get => content; set => content = value; }

        public FileSave()
        {
        }

        public FileSave(string name, string content)
        {
            this.name = name;
            this.content = content;
        }
    }
}
