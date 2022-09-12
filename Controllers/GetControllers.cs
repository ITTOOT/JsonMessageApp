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
    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class NS_ArticleCreateController : FromController<CreateMaterialMaster, MessageFromErpDto>
    {
        public NS_ArticleCreateController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //CreateMaterialMaster
        }
    }

    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class NS_OrderCreateController : FromController<OutgoingGoods, MessageFromErpDto>
    {
        public NS_OrderCreateController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //OutgoingGoods
        }
    }

    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class NS_OrderUpdateController : FromController<OrderUpdate, MessageFromErpDto>
    {
        public NS_OrderUpdateController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //OrderUpdate
        }
    }

    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class NS_OrderCancelController : FromController<OrderCancel, MessageFromErpDto>
    {
        public NS_OrderCancelController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //OrderCancel
        }
    }

    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class NS_OrderLineCancelController : FromController<OrderLineCancel, MessageFromErpDto>
    {
        public NS_OrderLineCancelController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //OrderLineCancel
        }
    }

    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class NS_ValidationErrorController : FromController<ValidationErrorFromErp, MessageFromErpDto>
    {
        public NS_ValidationErrorController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //ValidationErrorFromErp
        }
    }
}
