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
        internal string _NS_OrderLineCancel { get; set; }

        [NotMapped]
        [JsonProperty("NS_OrderLineCancel")]
        public NS_OrderLineCancelDto NS_OrderLineCancel
        {
            get { return (this._NS_OrderLineCancel == null) ? null : JsonConvert.DeserializeObject<NS_OrderLineCancelDto>(this._NS_OrderLineCancel); }
            set { _NS_OrderLineCancel = JsonConvert.SerializeObject(value); }
        }
    }

    [Keyless]
    public partial class NS_OrderLineCancelDto
	{
		[JsonProperty("OrderReference")]
		public Guid OrderReference { get; set; }
        
        internal string _OrderLineCancel { get; set; }

        [JsonProperty("OrderLineCancel")]
        public List<OrderLineCancelDto> OrderLineCancel
        {
            get { return (this._OrderLineCancel == null) ? null : JsonConvert.DeserializeObject<List<OrderLineCancelDto>>(this._OrderLineCancel); }
            set { _OrderLineCancel = JsonConvert.SerializeObject(value); }
        }

        public override bool Equals(object obj)
		{
			return obj is NS_OrderLineCancelDto dto &&
				   OrderReference == dto.OrderReference &&
				   OrderLineCancel == dto.OrderLineCancel;
		}
	}
}
