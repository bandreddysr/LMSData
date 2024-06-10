using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSAusDataApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LMSQuestionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private static readonly string[] Subjects = new[]
        {
            "Science", "Maths", "Social", "English", "Arts", "Languages","Hindi"
        };

        private readonly ILogger<LMSQuestionsController> _logger;

        public LMSQuestionsController(ILogger<LMSQuestionsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<LMSQuestions> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new LMSQuestions
            {
                Date = DateTime.Now.AddDays(index),
                SubjectId = rng.Next(-20, 55),
                SubjectSummary = Subjects[rng.Next(Subjects.Length)]
            })
            .ToArray();
        }
    }
}
