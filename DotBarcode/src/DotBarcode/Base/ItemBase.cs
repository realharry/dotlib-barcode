using DotCore.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotBarcode.Base
{
    public abstract class ItemBase : IdentifiedBase
    {
        // name is the PK.
        private string name;
        private string description;
        private long created;
        private long updated;
        private long deleted;

        public ItemBase(uint id)
            : this(id, null, null)
        {
        }
        public ItemBase(uint id, string name, string description)
            : this(id, name, description, 0L, 0L, 0L)
        {
        }
        public ItemBase(uint id, string name, string description, long created, long updated, long deleted)
            : base(id)
        {
            this.name = name;
            this.description = description;
            this.created = created;
            this.updated = updated;
            this.deleted = deleted;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public long Created
        {
            get
            {
                return created;
            }
            set
            {
                created = value;
            }
        }
        public long Updated
        {
            get
            {
                return updated;
            }
            set
            {
                updated = value;
            }
        }
        public long Deleted
        {
            get
            {
                return deleted;
            }
            set
            {
                deleted = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Name:").Append(Name).Append("; ");
            sb.Append("Description:").Append(Description).Append("; ");
            sb.Append("Created:").Append(Created).Append("; ");
            sb.Append("Updated:").Append(Updated).Append("; ");
            sb.Append("Deleted:").Append(Deleted);
            return sb.ToString();
        }
    }


}
