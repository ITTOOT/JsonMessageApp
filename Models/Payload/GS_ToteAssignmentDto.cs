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
        [JsonProperty("GS_ToteAssignment")]
        public GS_ToteAssignmentDto GS_ToteAssignment { get; set; }
    }

    [Keyless]
    public partial class GS_ToteAssignmentDto
	{
		[JsonProperty("ToteID")]
		public long ToteId { get; set; }

		[JsonProperty("TrolleyID")]
		public long TrolleyId { get; set; }

		[JsonProperty("OrderReference")]
		public Guid OrderReference { get; set; }

		[JsonProperty("OrderLineNo")]
		public string OrderLineNo { get; set; }

		[JsonProperty("Destination")]
		public long Destination { get; set; }

		[JsonProperty("DestinationPure")]
		public bool DestinationPure { get; set; }

		public override bool Equals(object obj)
		{
			return obj is GS_ToteAssignmentDto dto &&
				   ToteId == dto.ToteId &&
				   TrolleyId == dto.TrolleyId &&
				   OrderReference == dto.OrderReference &&
				   OrderLineNo == dto.OrderLineNo &&
				   Destination == dto.Destination &&
				   DestinationPure == dto.DestinationPure;
		}
	}
}
