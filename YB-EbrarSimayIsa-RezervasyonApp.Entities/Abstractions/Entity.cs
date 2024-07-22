using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB_EbrarSimayIsa_RezervasyonApp.Entities.Abstractions
{
    public abstract class Entity
    {
        public Entity()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAtDate { get; set; }
        public DateTime UpdateAtDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
