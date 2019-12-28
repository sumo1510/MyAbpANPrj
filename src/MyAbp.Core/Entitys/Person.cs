using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyAbp.Entitys
{
    public class Person : Entity<int>,IFullAudited
    {
        [StringLength(50)]
        public virtual string Name { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public bool IsDeleted { get ; set ; }
        public long? CreatorUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long? LastModifierUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? LastModificationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long? DeleterUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DeletionTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Person()
        {
            CreationTime = DateTime.Now;
        }
    }
}
