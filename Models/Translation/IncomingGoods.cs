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
	public partial class IncomingGoods : HostMessage // , IIncomingGoods
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
		/// IncomingGoodsNo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string IncomingGoodsNo { get; set; }

		/// <summary>
		/// Client 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Client { get; set; }

		/// <summary>
		/// MovementType 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public Constants.MovementType? MovementType { get; set; }
		/// <summary>
		/// IncomingGoodsPositions
		/// </summary>
		[XmlElement("IncomingGoodsPosition")]
		[JsonProperty]
		public List<IncomingGoodsPosition> Positions { get; set; }

	}
}