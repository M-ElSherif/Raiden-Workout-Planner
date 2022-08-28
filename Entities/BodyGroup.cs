using Raiden.Core.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiden.Core.Entities
{
    internal class BackBodyGroup : IBodyGroup
    {
        public ExerciseCategory Category => ExerciseCategory.Back;

        private readonly IEnumerable<IExercise> _exercises;

        public BackBodyGroup(IEnumerable<Exercise> exercises)
        {
            if (exercises == null)
            {
                throw new ArgumentNullException(nameof(exercises));
            }

            if (ValidateExercises(exercises))
            {
                _exercises = exercises;
            }
            else
            {
                throw new InvalidOperationException($"Invalid exercise category provided within list of exercises {nameof(exercises)}");
            }
        }

        public IEnumerable<IExercise> GetExercises()
        {
            IEnumerable<IExercise> exercises = new List<IExercise>(_exercises);

            return exercises;
        }

        public bool ValidateExercisesCategory(IEnumerable<IExercise> exercises)
        {
            return exercises.All(e =>
            e is Exercise exercise && exercise.ExCategory == Category);
        }

        public bool ValidateExercises(IEnumerable<IExercise> exercises)
        {
            throw new NotImplementedException();
        }
    }
}
