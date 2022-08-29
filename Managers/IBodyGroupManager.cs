using Raiden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiden.Core.Managers
{
    public interface ISessionManager
    {
        void AddExercise(Exercise exercise);

        void RemoveExercise(Exercise exercise);

        void ClearExercises();

        void AddExercises(IEnumerable<Exercise> exercises);
    }
}
