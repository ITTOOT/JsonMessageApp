namespace JsonMessageApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Xml.Serialization;

    using Microsoft.EntityFrameworkCore;
	using Microsoft.VisualBasic;

    using Newtonsoft.Json;
    [Serializable()]
	[JsonObject(MemberSerialization.OptIn)]
	public partial class CreateMaterialMaster : HostMessage, ICreateMaterialMaster
	{
        public static Func<IHostMessage, bool> OnHandle;

        public override bool Handle()
        {
            if (OnHandle == null)
            {
                throw new NotImplementedException($"{nameof(OnHandle)} was not set in Class {nameof(CreateMaterialMaster)}");
            }
            else
            {
                return OnHandle.Invoke(this);
            }
        }

        /// <summary>
        /// ArticleNo 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string ArticleNo { get; set; }

		/// <summary>
		/// Description 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Description { get; set; }

		/// <summary>
		/// PackagingUnit 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public Constants.PackagingUnit? PackagingUnit { get; set; }

		/// <summary>
		/// IsLotNoRequired 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public bool? IsLotNoRequired { get; set; }

		/// <summary>
		/// Client 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Client { get; set; }

		/// <summary>
		/// Variant 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Variant { get; set; }

		/// <summary>
		/// StorageArea 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string StorageArea { get; set; }

		/// <summary>
		/// Subdescription1 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Subdescription1 { get; set; }

		/// <summary>
		/// Subdescription2 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Subdescription2 { get; set; }

		/// <summary>
		/// Subdescription3 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Subdescription3 { get; set; }

		/// <summary>
		/// Subdescription4 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Subdescription4 { get; set; }

		/// <summary>
		/// AbcArea 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string AbcArea { get; set; }

        /// <summary>
        /// AbcArea 
        /// </summary>
        [XmlAttribute]
        [JsonProperty]
        public string UserActivity { get; set; } // Added long?

}
}