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
        [JsonProperty("GS_Activity")]
        public GS_ActivityDto GS_Activity { get; set; }
    }

    [Keyless]
    public partial class GS_ActivityDto
	{
		[JsonProperty("BonusNo")]
		public string BonusNo { get; set; }

		[JsonProperty("EventTime")]
		public DateTime EventTime { get; set; }

		[JsonProperty("BonusActivity")]
		public string BonusActivity { get; set; }

		[JsonProperty("WarehouseCode")]
		public string WarehouseCode { get; set; }

		public override bool Equals(object obj)
		{
			return obj is GS_ActivityDto dto &&
				   BonusNo == dto.BonusNo &&
				   EventTime == dto.EventTime &&
				   BonusActivity == dto.BonusActivity &&
				   WarehouseCode == dto.WarehouseCode;
		}
	}
}
