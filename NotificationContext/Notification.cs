using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.NotificationContext
{
    public sealed class Notification
    {

        public Notification() { }
        public Notification(string property, string mensage)
        {
            Property = property;
            Mensage = mensage;
        }

        public string Property { get; set; }
        public string Mensage { get; set; }
    }
}
