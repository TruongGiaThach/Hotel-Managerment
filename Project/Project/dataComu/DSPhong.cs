using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.dataComu
{
    class DSPhong
    {
        private static DSPhong instance;

        public static DSPhong Instance
        {
            get { if (instance == null) instance = new DSPhong(); return DSPhong.instance; }
            private set => instance = value;
        }
        private DSPhong() { }
    }
}
