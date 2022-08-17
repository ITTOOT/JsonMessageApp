using System;
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
    public class GS_StockAdjustmentController : ToController<MessageDto, MessageDto>
    {
        public GS_StockAdjustmentController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_InventorySnapshotController : ToController<MessageDto, MessageDto>
    {
        public GS_InventorySnapshotController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_ToteAssignmentController : ToController<MessageDto, MessageDto>
    {
        public GS_ToteAssignmentController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_PickCancellationController : ToController<MessageDto, MessageDto>
    {
        public GS_PickCancellationController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_PickCancellationRequestController : ToController<MessageDto, MessageDto>
    {
        public GS_PickCancellationRequestController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_ActivityController : ToController<MessageDto, MessageDto>
    {
        public GS_ActivityController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_ValidationErrorController : ToController<MessageDto, MessageDto>
    {
        public GS_ValidationErrorController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
        }
    }
}
