namespace JsonMessageApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    using Newtonsoft.Json;

    /// <summary>
    /// Rückmeldung an das BFS, wenn ein Paket am Ziel abgeworfen wurde
    /// </summary>
    /// 
	public partial class RequestDto
    {
        [NotMapped]
        [JsonProperty("GS_ValidationError")]
        public GS_ValidationErrorDto GS_ValidationError { get; set; }
    }

    [Keyless]
    public partial class GS_ValidationErrorDto
	{
		[JsonProperty("OrderReference")]
		public Guid OrderReference { get; set; }

		public override bool Equals(object obj)
		{
			return obj is GS_ValidationErrorDto dto &&
				   OrderReference == dto.OrderReference;
		}
	}
}
