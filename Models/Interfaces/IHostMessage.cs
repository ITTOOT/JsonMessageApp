namespace JsonMessageApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Xml.Serialization;

    using Microsoft.EntityFrameworkCore;

    using Newtonsoft.Json;

    public interface IHostMessage : IHostMessageFunctions // , ICreatorLastAccess
    {
		/// <summary>
		/// Id
		/// Default Value : 
		/// </summary> 
		public int? Id { get; set; }

		/// <summary>
		/// RefId
		/// Default Value : 
		/// </summary> 
		public int? RefId { get; set; }

		/// <summary>
		/// RecordType
		/// Default Value : 
		/// </summary> 
		public Constants.RecordType RecordType { get; set; }

		/// <summary>
		/// Status
		/// Default Value : Status.Pending
		/// </summary> 
		public Constants.Status? Status { get; set; }

		/// <summary>
		/// ErrorInterface
		/// Default Value : 
		/// </summary> 
		public string ErrorInterface { get; set; }

	}
}