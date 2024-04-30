using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cofidis.Domain.ViewModels
{
    [JsonSerializable(typeof(AuthenticationVM))]
    public class AuthenticationVM
    {
        [JsonPropertyName("X-Auth-Token")]
        public string? XAuthToken { get; set; }
    }
}
