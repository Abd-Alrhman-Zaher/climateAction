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
    public class AnswersController : ControllerBase
    {
        IGeneric<Answers> generic;
        public AnswersController(IGeneric<Answers> _generic)
        {
            generic = _generic;
        }
        [HttpPost]
        public void save(Answers answers)
        {
            generic.insert(answers);
        }
        [HttpGet]
        public List<Answers> load()
        {
            return generic.loadAll();
        }
        [HttpGet]
        [Route("getByid")]
        public Answers loadByid(int id)
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
        public void update(Answers c)
        {
            generic.update(c);
        }
    }
}
