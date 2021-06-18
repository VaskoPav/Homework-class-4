using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreDomain.Core.Interfaces
{
    public interface IUser
    {
        string Name { get; set; }
        string LastName { get; set; }
    }
}
