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
        //[Route("[action]")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        // Get all the entities in the current context
        public async Task<ActionResult<List<NameOfToDto>>> Get()
        {
            // Find the entity
            var tempMessage = _mapper.Map<List<MessageToErpDto>>(await _context.MessagesToErp.ToListAsync());

            // Get sub-entities 

            // HTTP 204 No Content
            if (tempMessage == null)
                return NoContent();

            // HTTP 200 OK
            return Ok(tempMessage);
        }

        [HttpPost]
        [ActionName(nameof(Post))]
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        // Get all the entities in the current context
        public async Task<ActionResult<List<NameOfToDto>>> Post()
        {
            // Find the entity
            var tempMessage = _mapper.Map<List<MessageToErpDto>>(await _context.MessagesToErp.ToListAsync());

            // Get sub-entities 

            // HTTP 204 No Content
            if (tempMessage == null)
                return NoContent();

            // HTTP 200 OK
            return Ok(tempMessage);
        }

        [Route("[action]")]
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
                var tempMessage = _mapper.Map<QuantityCorrection>(message); // ERP model
                await _context.MessagesToErp.AddAsync(tempMessage);
                await _context.SaveChangesAsync();

                Log.Write((Serilog.Events.LogEventLevel)LogLevel.Information, $"Post Ok {nameof(NameOfTo)} Message={message}");
                
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
