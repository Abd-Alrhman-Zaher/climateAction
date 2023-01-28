using climateAction.data;
using climateAction.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionCategoryController : ControllerBase
    {
        IGeneric<QuestionCategory> generic;
        public QuestionCategoryController(IGeneric<QuestionCategory> _generic)
        {
            generic = _generic;
        }
        [HttpPost]
        public void save(QuestionCategory question)
        {
            generic.insert(question);
        }
        [HttpGet]
        public List<QuestionCategory> load()
        {
            return generic.loadAll();
        }
        [HttpGet]
        [Route("getByid")]
        public QuestionCategory loadByid(int id)
        {
            return generic.loadId(id);
        }
        [HttpGet]
        [Route("delete")]
        public void delete(int id)
        {
            generic.Delete(id);
        }
        [HttpPost]
        [Route("update")]
        public void update(QuestionCategory q)
        {
            generic.update(q);
        }
    }
}
