using System.Collections.Generic;
using QuestionCards.Domain;

namespace QuestionCards.PersistenceEF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuestionCards.PersistenceEF.Context.QuestionCardsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(QuestionCards.PersistenceEF.Context.QuestionCardsContext context)
        {
            //var question = new Question
            //{
            //    Text = "Mercidabık savaşı kaç senesinde yapılmıştır?",
            //    CreatedDate = DateTime.Now,
            //    Answer = new Answer()
            //    {
            //        Type = AnswerType.Text,
            //        Text = "1516"
            //    }
            //};

            //var question2 = new Question
            //{
            //    Text = "Mercidabık savaşı 1516 senesinde yapılmıştır.",
            //    CreatedDate = DateTime.Now,
            //    Answer = new Answer()
            //    {
            //        Type = AnswerType.TrueFalse,
            //        IsTrue = true
            //    }
            //};

            //var choices = new List<Choice>();

            //var choice1 = new Choice();
            //choice1.IsTrue = false;
            //choice1.Text = "1256";

            //var choice2 = new Choice();
            //choice2.IsTrue = false;
            //choice2.Text = "1985";

            //var choice3 = new Choice();
            //choice3.IsTrue = true;
            //choice3.Text = "1516";

            //choices.Add(choice1);
            //choices.Add(choice2);
            //choices.Add(choice3);

            //var question3 = new Question
            //{
            //    Text = "Mercidabık savaşı hangi yıl yapılmıştır?",
            //    CreatedDate = DateTime.Now,
            //    Answer = new Answer()
            //    {
            //        Type = AnswerType.MultipleChoice,
            //        Choices = choices
            //    }
            //};

            //var questionSet = new QuestionSet();
            //questionSet.CreatedDate = DateTime.Now;
            //var questionList = new List<Question>();
            //questionList.Add(question);
            //questionList.Add(question2);
            //questionList.Add(question3);
            //questionSet.Questions = questionList;

            //context.Questions.AddOrUpdate(question);
            //context.Questions.AddOrUpdate(question2);
            //context.Questions.AddOrUpdate(question3);
            //context.QuestionSets.AddOrUpdate(questionSet);

            //context.SaveChanges();
        }
    }
}
