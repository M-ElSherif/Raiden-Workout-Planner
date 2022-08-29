using Newtonsoft.Json.Converters;
using Raiden.Core.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Raiden.Core.Entities
{
    public class Exercise
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ExerciseType ExType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ExerciseCategory ExCategory { get; set; }

        public Exercise()
        {
        }

        public Exercise(
            string name,
            string description,
            ExerciseType type,
            ExerciseCategory category)
        {
            Name = name;
            Description = description;
            ExType = type;
            ExCategory = category;
        }
    }
}
