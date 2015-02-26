using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionCards.Domain
{
    public class QuestionSet : AuditEntity
    {
        public String Title { get; set; }
        public List<Question> Questions { get; set; }

    }
}
