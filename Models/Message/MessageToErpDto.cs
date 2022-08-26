﻿namespace JsonMessageApi.Models
{
	using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Newtonsoft.Json;

    using NextApi.Utilities.JSON;

    /// <summary>
    /// Rückmeldung an das BFS, wenn ein Paket am Ziel abgeworfen wurde
    /// </summary>
    ///
    public partial class MessageToErpDto
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Header
        [NotMapped]
        [JsonProperty("Hdr")]
        public HdrDto Hdr { get; set; }

        // Request
        [NotMapped]
        [JsonProperty("Request")]
        public RequestDto Request { get; set; }
    }
}
