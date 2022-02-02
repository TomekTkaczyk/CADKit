using CADKit.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwSoft.ZwCAD.DatabaseServices;

namespace CADKit.Models
{
    public class EntityComponent : Component, IEntityComponent
    {
        public EntityComponent(string _name, Entity _entity) : base(_name)
        {
            Properties = new Dictionary<string, object>();
            Entity = _entity;
        }

        public Dictionary<string,object> Properties { get; private set; }

        public Entity Entity { get; private set; }
    }
}
