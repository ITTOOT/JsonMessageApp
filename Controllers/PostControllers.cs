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
    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class GS_StockAdjustmentController : ToController<QuantityCorrection, MessageToErpDto> // should be to ERP model
    {
        public GS_StockAdjustmentController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //QuantityCorrection -> GS_StockAdjustment
        }
    }

    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class GS_InventorySnapshotController : ToController<StockReport, MessageToErpDto>
    {
        public GS_InventorySnapshotController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //StockReport -> GS_InventorySnapshot
        }
    }

    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class GS_PickConfirmationController : ToController<OutgoingGoodsPositionConfirmation, MessageToErpDto>
    {
        public GS_PickConfirmationController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //OutgoingGoodsPositionConfirmation -> GS_PickConfirmation
        }
    }

    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class GS_ToteAssignmentController : ToController<TubAssignment, MessageToErpDto>
    {
        public GS_ToteAssignmentController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //TubAssignment -> GS_ToteAssignment
        }
    }

    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class GS_TrolleyCompleteController : ToController<TrolleyComplete, MessageToErpDto>
    {
        public GS_TrolleyCompleteController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //TrolleyComplete -> GS_TrolleyComplete
        }
    }

    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class GS_PickCancellationController : ToController<PickCancelation, MessageToErpDto>
    {
        public GS_PickCancellationController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //PickCancelation -> GS_PickCancellation
        }
    }

    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class GS_PickCancellationRequestController : ToController<CancelRequest, MessageToErpDto>
    {
        public GS_PickCancellationRequestController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //CancelRequest -> GS_PickCancellationRequest
        }
    }

    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class GS_ActivityController : ToController<SystemActivity, MessageToErpDto>
    {
        public GS_ActivityController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //SystemActivity -> GS_Activity
        }
    }

    [Route("WCS/[controller]/v1")]
    [ApiController]
    public class GS_ValidationErrorController : ToController<ValidationErrorToErp, MessageToErpDto>
    {
        public GS_ValidationErrorController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //ValidationErrorToErp -> GS_ValidationError
        }
    }
}