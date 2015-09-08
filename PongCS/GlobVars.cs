using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongCS
{
    /// <summary>
    /// Used so that separate threads can read from the same
    /// instance of a variable.
    /// </summary>
    public static class GlobVars
    {
        public static bool collided = false;    // Used to alert for collision
        public static bool includeAccel = false; // use acceleration
    }
}
