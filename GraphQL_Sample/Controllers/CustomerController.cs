using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;

namespace GraphQL_Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _executer;

        public CustomerController(ISchema schema, IDocumentExecuter executer)
        {
            _schema = schema;
            _executer = executer;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("This is CustomerApi.");
        }

        [HttpPost]
        public async Task<IActionResult> Post(CustomerQueryDto query)
        {
            var result = await _executer.ExecuteAsync(_ =>
            {
                _.Schema = _schema;
                _.Query = query.Query;
            }).ConfigureAwait(false);

            return Ok(result.Data);
        }
    }
}
