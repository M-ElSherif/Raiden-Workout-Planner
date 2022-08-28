using Raiden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiden.Core.Managers
{
    public interface IBodyGroupManager
    {
        void AddExercise(IExercise exercise);

        void RemoveExercise(IExercise exercise);

        void ClearExercises();

        void AddExercises(IEnumerable<IExercise> exercises);

        bool ValidateExercise(IExercise exercise);
    }
}
