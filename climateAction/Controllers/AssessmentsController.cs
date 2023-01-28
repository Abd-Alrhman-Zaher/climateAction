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
    public class AssessmentsController : ControllerBase
    {
        IGeneric<Assessments> generic;
        public AssessmentsController(IGeneric<Assessments> _generic)
        {
            generic = _generic;
        }
        [HttpPost]
        public void save(Assessments assessmentss)
        {
            generic.insert(assessmentss);
        }
        [HttpGet]
        public List<Assessments> load()
        {
            return generic.loadAll();
        }
        [HttpGet]
        [Route("getByid")]
        public Assessments loadByid(int id)
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
        public void update(Assessments s)
        {
            generic.update(s);
        }
    }
}
