using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SignalR_WillSantisteban.Hubs
{
    [HubName("chat")]
    public class Chat : Hub
    {
        public void EnviarMensaje(Models.ApplicationUser user)
        {
            Clients.Group(user.Grupo).DisplayText(user.UserName, user.Mensaje);
        }

        public Task Join(string NombreGrupo)
        {
            return Groups.Add(Context.ConnectionId, NombreGrupo);
        }
        public Task Leave(string NombreGrupo)
        {
            return Groups.Remove(Context.ConnectionId, NombreGrupo);
        }
    }

    //public class ChatSecond : Hub
    //{
    //    public void SendMensaje(string text)
    //    {
    //        Clients.Others.DisplayText(text);
    //    }
    //}
}