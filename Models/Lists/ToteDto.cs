namespace JsonMessageApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;

    using Microsoft.EntityFrameworkCore;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Rückmeldung an das BFS, wenn ein Paket am Ziel abgeworfen wurde
    /// </summary>
    [Keyless]
    public partial class ToteDto
	{
		[JsonProperty("ToteID")]
		public long ToteId { get; set; }

		public override bool Equals(object obj)
		{
			return obj is ToteDto dto &&
				   ToteId == dto.ToteId;
		}
	}
}
