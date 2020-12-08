using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymme
{
    class CharacterList
    {
        protected string CharacterName = "";

        public CharacterList(string CN)
        {
            CharacterName = CN;
        }
        public override string ToString()
        {
            return CharacterName;
        }
    }
}
