using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClient.Events
{
    public interface IEventHandler
    {
        void Notify(BaseEvent event);
    }
}
