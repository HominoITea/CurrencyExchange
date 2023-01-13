using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientShared.Entities
{
    public class DataRow
    {
        private readonly Dictionary<DateTime, object> _data;

        public DataRow()
        {
            _data = new Dictionary<DateTime, object>();
        }
    }
}
