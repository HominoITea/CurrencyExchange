using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientShared.Handlers
{
    public interface IMediator
    {
        void Register(string id, Action<object> action);
        void Unregister(string id, Action<object> action);
        void Clear();
        void Send(string id, object message);
    }
}
