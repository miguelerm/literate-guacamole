using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeTextEditor.Models
{
    public class CursorChangeArgs
    {
        public string ConnectionId { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
    }
}
