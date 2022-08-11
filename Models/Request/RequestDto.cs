namespace JsonMessageApi.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Globalization;
	using Microsoft.EntityFrameworkCore;

	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

    /// <summary>
    /// Rückmeldung an das BFS, wenn ein Paket am Ziel abgeworfen wurde
    /// </summary>
    ///
    [Keyless]
    public partial class RequestDto
	{
		// Empty request holds request entities
	}
}
