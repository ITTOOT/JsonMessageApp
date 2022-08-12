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
    [Route("[controller]")]
    [ApiController]
    public class NS_ArticleCreateController : BaseController<MessageDto, MessageDto>
    {
        public NS_ArticleCreateController(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_OrderCreateController : BaseController<MessageDto, MessageDto>
    {
        public NS_OrderCreateController(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_OrderUpdateController : BaseController<MessageDto, MessageDto>
    {
        public NS_OrderUpdateController(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_OrderCancelController : BaseController<MessageDto, MessageDto>
    {
        public NS_OrderCancelController(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_OrderLineCancelController : BaseController<MessageDto, MessageDto>
    {
        public NS_OrderLineCancelController(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_ValidationErrorController : BaseController<MessageDto, MessageDto>
    {
        public NS_ValidationErrorController(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
