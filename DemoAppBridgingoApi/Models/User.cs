using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAppBridgingoApi.Models
{
    public class User : BaseEntity
    {
        public virtual String Name { get; set; }
        public virtual String EmailAddress { get; set; }
        public virtual String PhoneNumber { get; set; }
    }
}
