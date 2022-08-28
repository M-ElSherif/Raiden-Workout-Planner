using Raiden.Core.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiden.Core.Entities
{
    public interface IBodyGroup
    {
        ExerciseCategory Category { get;}

        IEnumerable<IExercise> GetExercises();

        bool ValidateExercises(IEnumerable<IExercise> exercises);
    }
}
