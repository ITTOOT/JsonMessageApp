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
        internal string _NS_ArticleCreate { get; set; }

        [NotMapped]
        [JsonProperty("NS_ArticleCreate")]
        public NS_ArticleCreateDto Ns_ArticleCreate
        {
            get { return (this._NS_ArticleCreate == null) ? null : JsonConvert.DeserializeObject<NS_ArticleCreateDto>(this._NS_ArticleCreate); }
            set { _NS_ArticleCreate = JsonConvert.SerializeObject(value); }
        }
    }

    [Keyless]
    public partial class NS_ArticleCreateDto
	{
		[JsonProperty("SKU")]
		public string Sku { get; set; }

		[JsonProperty("WarehouseCode")]
		public string WarehouseCode { get; set; }

		[JsonProperty("Description")]
		public string Description { get; set; }

		[JsonProperty("BonusActivity")]
		public long? BonusActivity { get; set; }

		[JsonProperty("HotZoneClassification")]
		public string HotZoneClassification { get; set; }

		public override bool Equals(object obj)
		{
			return obj is NS_ArticleCreateDto dto &&
				   Sku == dto.Sku &&
				   WarehouseCode == dto.WarehouseCode &&
				   Description == dto.Description &&
				   BonusActivity == dto.BonusActivity &&
				   HotZoneClassification == dto.HotZoneClassification;
		}
	}
}
