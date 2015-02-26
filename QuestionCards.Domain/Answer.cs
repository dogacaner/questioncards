using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionCards.Domain
{
    public enum AnswerType
    {
        MultipleChoice,
        Text,
        TrueFalse
    }
    public class Answer : AuditEntity
    {
        public AnswerType Type { get; set; }
        public string Text { get; set; }
        public bool IsTrue { get; set; }
        public virtual List<Choice> Choices { get; set; }
    }
}
