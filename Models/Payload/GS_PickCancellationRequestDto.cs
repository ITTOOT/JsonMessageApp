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
        internal string _GS_PickCancellationRequest { get; set; }

        [NotMapped]
        [JsonProperty("GS_PickCancellationRequest")]
        public GS_PickCancellationRequestDto GS_PickCancellationRequest
        {
            get { return (this._GS_PickCancellationRequest == null) ? null : JsonConvert.DeserializeObject<GS_PickCancellationRequestDto>(this._GS_PickCancellationRequest); }
            set { _GS_PickCancellationRequest = JsonConvert.SerializeObject(value); }
        }
    }

    [Keyless]
    public partial class GS_PickCancellationRequestDto
	{
		[JsonProperty("OrderReference")]
		public Guid OrderReference { get; set; }

		[JsonProperty("BonusNo")]
		public string BonusNo { get; set; }
        
        [JsonProperty("BatchReference")]
        public string BatchReference { get; set; }

        internal string _CancellationRequests { get; set; }

        [NotMapped]
        [JsonProperty("CancellationRequestsDto")]
        public List<CancellationRequestsDto> CancellationRequests
        {
            get { return (this._CancellationRequests == null) ? null : JsonConvert.DeserializeObject<List<CancellationRequestsDto>>(this._CancellationRequests); }
            set { _CancellationRequests = JsonConvert.SerializeObject(value); }
        }

        public override bool Equals(object obj)
		{
			return obj is GS_PickCancellationRequestDto dto &&
				   OrderReference == dto.OrderReference &&
				   BonusNo == dto.BonusNo &&
				   CancellationRequests == dto.CancellationRequests;
		}
	}
}
