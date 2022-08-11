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
        internal string _NS_OrderUpdate { get; set; }

        [NotMapped]
        [JsonProperty("NS_OrderUpdate")]
        public NS_OrderUpdateDto NS_OrderUpdate
        {
            get { return (this._NS_OrderUpdate == null) ? null : JsonConvert.DeserializeObject<NS_OrderUpdateDto>(this._NS_OrderUpdate); }
            set { _NS_OrderUpdate = JsonConvert.SerializeObject(value); }
        }
    }

    [Keyless]
    public partial class NS_OrderUpdateDto
	{
		[JsonProperty("OrderReference")]
		public Guid OrderReference { get; set; }

		[JsonProperty("PickByTime")]
		public DateTime PickByTime { get; set; }

		public override bool Equals(object obj)
		{
			return obj is NS_OrderUpdateDto dto &&
				   OrderReference == dto.OrderReference &&
				   PickByTime == dto.PickByTime;
		}
	}
}
