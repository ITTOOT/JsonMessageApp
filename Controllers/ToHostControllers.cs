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
            //QuantityCorrection -> GS_StockAdjustment
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_InventorySnapshotController : ToController<StockReport, StockReport>
    {
        public GS_InventorySnapshotController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //StockReport -> GS_InventorySnapshot
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_PickConfirmationController : ToController<OutgoingGoodsPositionConfirmation, OutgoingGoodsPositionConfirmation>
    {
        public GS_PickConfirmationController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //OutgoingGoodsPositionConfirmation -> GS_PickConfirmation
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_ToteAssignmentController : ToController<TubAssignment, TubAssignment>
    {
        public GS_ToteAssignmentController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //TubAssignment -> GS_ToteAssignment
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_TrolleyCompleteController : ToController<TrolleyComplete, TrolleyComplete>
    {
        public GS_TrolleyCompleteController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //TrolleyComplete -> GS_TrolleyComplete
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_PickCancellationController : ToController<PickCancelation, PickCancelation>
    {
        public GS_PickCancellationController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //PickCancelation -> GS_PickCancellation
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_PickCancellationRequestController : ToController<CancelRequest, CancelRequest>
    {
        public GS_PickCancellationRequestController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //CancelRequest -> GS_PickCancellationRequest
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_ActivityController : ToController<SystemActivity, SystemActivity>
    {
        public GS_ActivityController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //SystemActivity -> GS_Activity
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class GS_ValidationErrorController : ToController<ValidationErrorToErp, ValidationErrorToErp>
    {
        public GS_ValidationErrorController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
        {
            //ValidationErrorToErp -> GS_ValidationError
        }
    }
}
