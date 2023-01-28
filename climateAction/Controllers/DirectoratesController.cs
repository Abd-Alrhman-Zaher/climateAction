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
    public class DirectoratesController : ControllerBase
    {
        IGeneric<Directorates> generic;
        public DirectoratesController(IGeneric<Directorates> _generic)
        {
            generic = _generic;
        }
        [HttpPost]
        public void save(Directorates directorates)
        {
            generic.insert(directorates);
        }
        [HttpGet]
        public List<Directorates> load()
        {
            return generic.loadAll();
        }
        [HttpGet]
        [Route("getByid")]
        public Directorates loadByid(int id)
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
        public void update(Directorates d)
        {
            generic.update(d);
        }
    }
}
