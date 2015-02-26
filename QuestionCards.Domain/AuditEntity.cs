using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionCards.Domain
{
    public class AuditEntity
    {
        public int Id { get; set; }
        public virtual int? CreatedBy { get; set; }
        public virtual int? LastModifiedBy { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? LastModifiedDate { get; set; }
    }
}
