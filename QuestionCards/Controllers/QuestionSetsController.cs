using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuestionCards.Domain;
using QuestionCards.Models;
using QuestionCards.PersistenceEF.Context;

namespace QuestionCards.Controllers
{
    public class QuestionSetsController : Controller
    {
        //
        // GET: /QuestionSets/
        public ActionResult Index()
        {
            using (var context = new QuestionCardsContext())
            {
                var questionSets = context.QuestionSets.ToList();

                var model = new QuestionSetsModel();
                model.QuestionSets = questionSets;

                return View(model);
            }
        }
    }
}