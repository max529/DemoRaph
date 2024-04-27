using AventusSharp.Data.Manager;
using AventusSharp.WebSocket;
using AventusSharp.WebSocket.Attributes;
using Core.Websocket;
using DemoRaph.Data;
using DemoRaph.Logic.DM;

namespace DemoRaph.Websocket.Routes {

    [EndPoint<MainEndPoint>("Todo")]
    public class TodoRoute : StorableWsRoute<Todo>
    {
        protected override IGenericDM<Todo>? GetDM()
        {
            return TodoDM.GetInstance();
        }
    }
}