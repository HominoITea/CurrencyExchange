using ClientShared.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientShared.Handlers
{
    public sealed class Mediator : IMediator
    {
        private Dictionary<string, List<Action<object>>> _callbacks;

        public Mediator()
        {
            _callbacks = new Dictionary<string, List<Action<object>>>();
        }


        public void Register(string id, Action<object> action)
        {
            if(!_callbacks.ContainsKey(id))
            {
                _callbacks[id] = new List<Action<object>>();
            }
            _callbacks[id].Add(action);
        }

        public void Unregister(string id, Action<object> action)
        {
            if(_callbacks.ContainsKey(id))
            {
                _callbacks[id].Remove(action);
            }
        }

        public void Clear() 
        {
            _callbacks.Clear();
        }

        public void Send(string id, object message)
        {
            if (!_callbacks.ContainsKey(id))
            {
                throw new NotFoundCallbackException();
            }
            _callbacks[id].ForEach(action => action(message));
        }
    }
}
