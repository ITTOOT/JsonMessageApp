using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml.Linq;

using AutoMapper;

using JsonMessageApi.Context;
using JsonMessageApi.Models;

using JsonMessageApp.Config;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols;

using Serilog;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JsonMessageApi.Controllers
{
    /// This controller allows the client to GET messages from ToErph put there by GFT (POST GFT message)
    /// <typeparam name="NameOfTo"> RecordType == nameof(TelegramName) </typeparam>
    /// <typeparam name="NameOfToDto"> The class used for the serialization </typeparam>
    public abstract class ToController<NameOfTo, NameOfToDto> : ControllerBase
    {
        // Private readonly IHttpContextAccessor _httpContextAccessor;
        private DataContext _context;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;
        bool _mirrorOnPost = false; // Sends a copy of the received object back to the client

        public ToController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings)
        {
            _context = context;
            _mapper = mapper;
            _mirrorOnPost = appSettings.Value.MirrorOnPost;
        }


        [HttpGet]
        [ActionName(nameof(Get))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<QuantityCorrection>> Get() // ERP model
        {
            // Find the entity
            var tempMessage = await _context.MessagesToErp.ToListAsync(); // ERP model

            // HTTP 204 No Content
            if (tempMessage == null)
                return NoContent();

            // HTTP 200 OK
            return Ok(tempMessage);
        }

        [HttpGet]
        //[ActionName(nameof(GetToErp))]
        [Route("[action]")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        // Get all the entities in the current context
        public async Task<ActionResult<List<MessageDto>>> GetToErp()
        {
            // Serializing object to json data
            //JavaScriptSerializer js = new JavaScriptSerializer();

            // Find the entity
            //var tM = _mapper.Map<List<GS_StockAdjustmentDto>>(await _context.MessagesToErp.ToListAsync());
            //var tempMessage = _mapper.Map<List<RequestDto>>(tM);
            //var tempMessage = _mapper.Map<List<RequestDto>>(_mapper.Map<List<GS_StockAdjustmentDto>>(await _context.MessagesToErp.ToListAsync()));
            var tempMessage = _mapper.Map<List<RequestDto>>(_mapper.Map<List<GS_StockAdjustmentDto>>(await _context.MessagesToErp.ToListAsync()));
            // Get sub-entities

            // HTTP 204 No Content
            if (tempMessage == null)
                return NoContent();

            // HTTP 200 OK
            return Ok(tempMessage);
        }

        //      /// <summary>
        ///// Writes an Message into the FromErp Table
        ///// </summary>
        ///// <param name="message"></param>
        ///// <returns>Either Status201Created or Status400BadRequest</returns>
        //[HttpPost]
        //      [ActionName(nameof(Post))]
        //      [ProducesResponseType(StatusCodes.Status200OK)] // For IActionResult
        //      [ProducesResponseType(StatusCodes.Status201Created)]
        //      [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //      [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        //      [ProducesResponseType(StatusCodes.Status409Conflict)]
        //      [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //      public async Task<ActionResult<NameOfToDto>> Post(NameOfToDto message)
        //      {
        //          try
        //          {
        //              // HTTP 400 Bad Request
        //              //if (string.IsNullOrEmpty(entityDto.ToString()))
        //              //    return BadRequest("Bad Request!");

        //              // HTTP 401 Unauthorized
        //              // return Unauthorized();

        //              // HTTP 409 Conflict
        //              //if (_context.Messages.AnyAsync(x => x.id.ToString() == entityDto.id.ToString()))
        //              //    return Conflict("Unique key '" + entityDto.id.ToString() + "' already taken!");


        //              // Map request model to new entity object
        //              //var tempMessage = _mapper.Map<GS_StockAdjustmentDto>(message);
        //              var tempMessage = _mapper.Map<QuantityCorrection>(message); // ERP model
        //              //var tempMessage = _mapper.Map<MessageDto>(message);

        //              // Find an existing entity
        //              //var found = await _context.Messages.FindAsync(tempEntity.Uid);

        //              //// Found object duplicate
        //              //if (found != null)
        //              //    return _mapper.Map<MessagesDto>(found);

        //              // Add entities to the data context
        //              //await _context.Messages.AddAsync(tempMessage);
        //              //await _context.MessagesToErp.AddAsync(tempMessage);
        //              await _context.MessagesToErp.AddAsync(tempMessage);
        //              await _context.SaveChangesAsync();


        //              // Post entity to API
        //              //postedEntity = await _orderService.PostOrder(OrderCreate);

        //              // HTTP 500 Internal Server Error
        //              //if (postedOrder)               
        //              //    return StatusCode(500, postedOrder.Value);

        //              // HTTP 200 OK
        //              //return Ok(tempMessage);

        //              // HTTP 201 created
        //              // return CreatedAtAction(nameof(PostOrder), new { postedOrder.Value.header });

        //              // HTTP 204 No Content
        //              // return NoContent();

        //              Log.Write((Serilog.Events.LogEventLevel)LogLevel.Information, $"Post Ok {nameof(NameOfTo)} Message={message}");
        //              //return Ok(tempMessage);
        //              return CreatedAtAction(nameof(Get), new { id = tempMessage.Id }, _mirrorOnPost ? tempMessage : null);
        //          }
        //          catch (Exception e)
        //          {
        //              Log.Write((Serilog.Events.LogEventLevel)LogLevel.Error, $"!!! BadRequest !!! Post Message={message}");
        //              Log.Write((Serilog.Events.LogEventLevel)LogLevel.Error, e.ToString());

        //              return BadRequest();
        //          }
        //      }



        [HttpPost]
        [ActionName(nameof(PostToErp))]
        [ProducesResponseType(StatusCodes.Status200OK)] // For IActionResult
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<NameOfToDto>> PostToErp(NameOfToDto message)
        {
            try
            {
                //var tempMessage = _mapper.Map<RequestDto>(_mapper.Map<GS_StockAdjustmentDto>(message)); // ERP model
                var tempMessage = _mapper.Map<QuantityCorrection>(message); // ERP model
                await _context.MessagesToErp.AddAsync(tempMessage);
                await _context.SaveChangesAsync();


                //var tempMessage = _mapper.Map<MessageDto>(message);
                //await _context.Messages.AddAsync(tempMessage);
                //await _context.SaveChangesAsync();

                Log.Write((Serilog.Events.LogEventLevel)LogLevel.Information, $"Post Ok {nameof(NameOfTo)} Message={message}");
                //return Ok(tempMessage);
                return CreatedAtAction(nameof(Get), new { id = tempMessage.Id }, _mirrorOnPost ? tempMessage : null);
            }
            catch (Exception e)
            {
                Log.Write((Serilog.Events.LogEventLevel)LogLevel.Error, $"!!! BadRequest !!! Post Message={message}");
                Log.Write((Serilog.Events.LogEventLevel)LogLevel.Error, e.ToString());

                return BadRequest();
            }
        }
    }
}
