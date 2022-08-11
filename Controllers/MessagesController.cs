using System.Threading.Tasks;

using AutoMapper;

using JsonMessageApi.Context;
using JsonMessageApi.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JsonMessageApi.Controllers
{
    //[Route("[controller]")]
    [Route("NS_ArticleCreate")]
    [Route("Messages")]
    [ApiController]
    public class MessagesController : BaseController<MessageDto, MessageDto>
    {
        public MessagesController(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
