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
        internal string _NS_OrderCancel { get; set; }

        [NotMapped]
        [JsonProperty("NS_OrderCancel")]
        public NS_OrderCancelDto NS_OrderCancel
        {
            get { return (this._NS_OrderCancel == null) ? null : JsonConvert.DeserializeObject<NS_OrderCancelDto>(this._NS_OrderCancel); }
            set { _NS_OrderCancel = JsonConvert.SerializeObject(value); }
        }
    }

    [Keyless]
    public partial class NS_OrderCancelDto
    {
		[JsonProperty("OrderReference")]
		public Guid OrderReference { get; set; }

		public override bool Equals(object obj)
		{
			return obj is NS_OrderCancelDto dto &&
				   OrderReference == dto.OrderReference;
		}
	}
}
