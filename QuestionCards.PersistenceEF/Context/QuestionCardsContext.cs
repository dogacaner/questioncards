using QuestionCards.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionCards.PersistenceEF.Context
{
    public class QuestionCardsContext : DbContext
    {
        public IDbSet<Question> Questions { get; set; }
        public IDbSet<QuestionSet> QuestionSets { get; set; }


        public QuestionCardsContext()
        {
        }

        public QuestionCardsContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
