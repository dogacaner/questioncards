using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionCards.Domain
{
    public class Choice : AuditEntity
    {
        public string Text { get; set; }
        public bool IsTrue { get; set; }
    }
}
