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
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols;

using Serilog;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JsonMessageApi.Controllers
{
    /// Writes an Message into the FromErp Table for GFT
    /// <typeparam name="NameOfFrom"> RecordType == nameof(TelegramName) </typeparam>
    /// <typeparam name="NameOfFromDto"> The class used for the serialization </typeparam>
    public abstract class FromController<NameOfFrom, NameOfFromDto> : ControllerBase
    {
        // Private readonly IHttpContextAccessor _httpContextAccessor;
        private DataContext _context;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;
        bool _mirrorOnPost = false; // Sends a copy of the received object back to the client

        public FromController(DataContext context, IMapper mapper, IOptions<AppSettings> appSettings)
        {
            _context = context;
            _mapper = mapper;
            _mirrorOnPost = appSettings.Value.MirrorOnPost;
        }

        //GET: api/<NextOrdersController>
        // [Authorize]
        // [Authorize(Roles = "Admin")]
        // [AllowAnon]
        [HttpGet]
        [ActionName(nameof(Get))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<MessageDto>>> Get()
        {

            // Find the entity
            var messages = await _context.MessagesFromErp.ToListAsync();

            // Get sub-entities
            var orderLines = await _context.OrderLines.ToListAsync();

            // Find the entity
            ////var messages = await _context.Messages.ToListAsync();
            //var messages = await _context.MessagesFromErp.ToListAsync();

            // HTTP 204 No Content
            if (messages == null)
                return NoContent();

            // HTTP 200 OK
            return Ok(messages);
        }

        /// <summary>
		/// Writes an Message into the FromErp Table
		/// </summary>
		/// <param name="message"></param>
		/// <returns>Either Status201Created or Status400BadRequest</returns>
		[HttpPost]
        [ActionName(nameof(Post))]
        [ProducesResponseType(StatusCodes.Status200OK)] // For IActionResult
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<NameOfFromDto>> Post(NameOfFromDto message)
        {
            try
            {
                var tempMessage = (dynamic)null;

                // HTTP 400 Bad Request
                //if (string.IsNullOrEmpty(entityDto.ToString()))
                //    return BadRequest("Bad Request!");

                // HTTP 401 Unauthorized
                // return Unauthorized();

                // HTTP 409 Conflict
                //if (_context.Messages.AnyAsync(x => x.id.ToString() == entityDto.id.ToString()))
                //    return Conflict("Unique key '" + entityDto.id.ToString() + "' already taken!");


                // Map request model to new entity object
                //var tempMessage = _mapper.Map<MessageDto>(message);

                // This will be the From ERP table
                //tempMessage = _mapper.Map<IncomingGoodsPosition>(message);
                tempMessage = _mapper.Map<OutgoingGoods>(message);


                //switch (message)
                //{
                //    case "NS_ArticleCreateDto":
                //        tempMessage = _mapper.Map<CreateMaterialMaster>(message);
                //        break;
                //    default:
                //        tempMessage = null;
                //        break;
                //}


                // Find an existing entity
                //var found = await _context.Messages.FindAsync(tempEntity.Uid);

                //// Found object duplicate
                //if (found != null)
                //    return _mapper.Map<MessagesDto>(found);

                // Add entities to the data context
                //_context.Set<CreateMaterialMaster>();
                await _context.MessagesFromErp.AddAsync(tempMessage);
                await _context.SaveChangesAsync();


                // Post entity to API
                //postedEntity = await _orderService.PostOrder(OrderCreate);

                // HTTP 500 Internal Server Error
                //if (postedOrder)               
                //    return StatusCode(500, postedOrder.Value);
                
                // HTTP 200 OK
                //return Ok(tempMessage);

                // HTTP 201 created
                // return CreatedAtAction(nameof(PostOrder), new { postedOrder.Value.header });

                // HTTP 204 No Content
                // return NoContent();

                Log.Write((Serilog.Events.LogEventLevel)LogLevel.Information, $"Post Ok {nameof(NameOfFrom)} Message={message}");

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
