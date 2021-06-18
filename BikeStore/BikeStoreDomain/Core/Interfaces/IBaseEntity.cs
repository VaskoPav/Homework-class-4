using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreDomain.Core.Interfaces
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        void PrintInfo();
    }
}
