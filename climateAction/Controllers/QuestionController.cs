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
    public class QuestionController : ControllerBase
    {
        IGeneric<Question> generic;
        public QuestionController(IGeneric<Question> _generic)
        {
            generic = _generic;
        }
        [HttpPost]
        public void save(Question question)
        {
            generic.insert(question);
        }
        [HttpGet]
        public List<Question> load()
        {
            return generic.loadAll();
        }
        [HttpGet]
        [Route("getByid")]
        public Question loadByid(int id)
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
        public void update(Question q)
        {
            generic.update(q);
        }
    }
}
