using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuestionCards.Domain;

namespace QuestionCards.Models
{
    public class QuestionSetsModel
    {
        public IEnumerable<QuestionSet> QuestionSets { get; set; }

    }
}