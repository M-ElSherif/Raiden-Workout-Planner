//using Raiden.Core.Entities.Enums;
//using Raiden.Core.Managers;

//namespace Raiden.Core.Entities
//{
//    internal class BodyGroup : ISession, ISessionManager
//    {
//        public ExerciseCategory Category { get; }

//        private readonly IList<Exercise> _exercises;

//        public BodyGroup(
//            IList<Exercise> exercises,
//            ExerciseCategory category)
//        {
//            if (exercises == null)
//            {
//                throw new ArgumentNullException(nameof(exercises));
//            }

//            Category = category;

//            if (ValidateExercisesCategory(exercises))
//            {
//                _exercises = exercises;
//            }
//            else
//            {
//                throw new InvalidOperationException($"Invalid exercise category provided within list of exercises {nameof(exercises)}");
//            }
//        }

//        public IEnumerable<Exercise> GetExercises()
//        {
//            IEnumerable<Exercise> exercises = new List<Exercise>(_exercises);

//            return exercises;
//        }


//        public void AddExercise(Exercise exercise)
//        {
//            if (ValidateExercise(exercise))
//            {
//                _exercises.Append(exercise);
//            }
//        }

//        public void RemoveExercise(Exercise exercise)
//        {
//            if (ValidateExercise(exercise))
//            {
//                _exercises.Remove(exercise);
//            }
//        }

//        public void ClearExercises()
//        {
//            _exercises.Clear();
//        }

//        public void AddExercises(IEnumerable<Exercise> exercises)
//        {
//            if (ValidateExercisesCategory(exercises))
//            {
//                List<Exercise> tempExercises = (List<Exercise>)_exercises;
//                tempExercises.AddRange(exercises);
//            }
//        }

//        public bool ValidateExercisesCategory(IEnumerable<Exercise> exercises)
//        {
//            return exercises.All(e =>
//            e is Exercise exercise && exercise.ExCategory == Category);
//        }

//        public bool ValidateExercise(Exercise exercise)
//        {
//            return exercise.ExCategory == Category;
//        }
//    }
//}
