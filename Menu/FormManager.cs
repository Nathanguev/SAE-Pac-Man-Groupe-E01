using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_PacMan
{
    public static class FormManager
    {
        public static event Action FormClosing;
        public static event Action FormOptionsClosing;

        public static void OnFormClosing()
        {
            FormClosing?.Invoke();
        }

        public static void OnFormOptionsClosing()
        {
            FormOptionsClosing?.Invoke();
        }
    }
}
