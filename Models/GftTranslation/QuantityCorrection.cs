namespace JsonMessageApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Xml.Serialization;

    using Microsoft.EntityFrameworkCore;

    using Newtonsoft.Json;

    [Serializable()]
	[JsonObject(MemberSerialization.OptIn)]
	public partial class QuantityCorrection : HostMessage, IQuantityCorrection
	{
        public static Func<IHostMessage, bool> OnHandle;

        public override bool Handle()
        {
            if (OnHandle == null)
            {
                throw new NotImplementedException($"{nameof(OnHandle)} was not set in Class {nameof(OrderStart)}");
            }
            else
            {
                return OnHandle.Invoke(this);
            }
        }

        /// <summary>
        /// StorageArea 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string StorageArea { get; set; }

		/// <summary>
		/// ArticleNo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string ArticleNo { get; set; }

		/// <summary>
		/// MovementType 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public Constants.MovementType? MovementType { get; set; }

		/// <summary>
		/// TargetQty 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public decimal? TargetQty { get; set; }

		/// <summary>
		/// ActualQty 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public decimal? ActualQty { get; set; }

		/// <summary>
		/// Barcode 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Barcode { get; set; }

		/// <summary>
		/// ReasonCode 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string ReasonCode { get; set; }

		/// <summary>
		/// Username 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Username { get; set; }

	}
}