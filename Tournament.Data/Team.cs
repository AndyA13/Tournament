using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tournament.Data
{
    public partial class Team
    {
        public override string ToString()
        {
            return String.Format("{0} ({1})", this.Name, this.Player);
        }
    }
}
