using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cofidis.Domain.ViewModels
{
    [JsonSerializable(typeof(ResultVM))]
    public class ResultVM
    {
        public string? Result { get; set; }
    }
}
