using CollaborativeTextEditor.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeTextEditor.Hubs
{
    public class EditorHub : Hub
    {
        public void CursorChange(CursorChangeArgs cursor)
        {
            cursor.ConnectionId = this.Context.ConnectionId;
            Clients.Others.CursorChange(cursor);
        }
    }
}
