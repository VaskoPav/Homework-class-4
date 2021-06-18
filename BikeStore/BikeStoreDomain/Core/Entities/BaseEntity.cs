using BikeStoreDomain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreDomain.Core.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get ; set ; }

        public BaseEntity()
        {

        }

        public abstract void PrintInfo();
        
    }
}
