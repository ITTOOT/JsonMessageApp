using System;
using System.Threading.Tasks;

using AutoMapper;

using JsonMessageApi.Context;
using JsonMessageApi.Models;

using JsonMessageApp.Config;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using Serilog;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JsonMessageApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GS_StockAdjustmentController : ToController<QuantityCorrection, QuantityCorrection> // should be to ERP model
    {
        public GS_StockAdjustmentController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_InventorySnapshotController : ToController<MessageToErpDto, MessageToErpDto>
    {
        public GS_InventorySnapshotController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_ToteAssignmentController : ToController<MessageToErpDto, MessageToErpDto>
    {
        public GS_ToteAssignmentController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_PickCancellationController : ToController<MessageToErpDto, MessageToErpDto>
    {
        public GS_PickCancellationController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_PickCancellationRequestController : ToController<MessageToErpDto, MessageToErpDto>
    {
        public GS_PickCancellationRequestController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_ActivityController : ToController<MessageToErpDto, MessageToErpDto>
    {
        public GS_ActivityController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_ValidationErrorController : ToController<MessageToErpDto, MessageToErpDto>
    {
        public GS_ValidationErrorController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }
}
