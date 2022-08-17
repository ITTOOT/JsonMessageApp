using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using AutoMapper;

using JsonMessageApi.Context;
using JsonMessageApi.Models;

using JsonMessageApp.Config;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JsonMessageApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NS_ArticleCreateController : FromController<MessageDto, MessageDto>
    {
        public NS_ArticleCreateController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_OrderCreateController : FromController<MessageDto, MessageDto>
    {
        public NS_OrderCreateController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {

            //IncomingGoodsPosition
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_OrderUpdateController : FromController<MessageDto, MessageDto>
    {
        public NS_OrderUpdateController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_OrderCancelController : FromController<MessageDto, MessageDto>
    {
        public NS_OrderCancelController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_OrderLineCancelController : FromController<MessageDto, MessageDto>
    {
        public NS_OrderLineCancelController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_ValidationErrorController : FromController<MessageDto, MessageDto>
    {
        public NS_ValidationErrorController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }
}
