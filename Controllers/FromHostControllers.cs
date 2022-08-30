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
    public class NS_ArticleCreateController : FromController<MessageFromErpDto, MessageFromErpDto>
    {
        public NS_ArticleCreateController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //CreateMaterialMaster
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_OrderCreateController : FromController<MessageFromErpDto, MessageFromErpDto>
    {
        public NS_OrderCreateController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //OutgoingGoods
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_OrderUpdateController : FromController<MessageFromErpDto, MessageFromErpDto>
    {
        public NS_OrderUpdateController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //OrderUpdate
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_OrderCancelController : FromController<MessageFromErpDto, MessageFromErpDto>
    {
        public NS_OrderCancelController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //OrderCancel
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_OrderLineCancelController : FromController<MessageFromErpDto, MessageFromErpDto>
    {
        public NS_OrderLineCancelController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //OrderLineCancel
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class NS_ValidationErrorController : FromController<MessageFromErpDto, MessageFromErpDto>
    {
        public NS_ValidationErrorController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //ValidationErrorFromErp
        }
    }
}
