using Raiden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiden.Core.Managers
{
    public class BodyGroupManager<T> : IBodyGroupManager where T : IBodyGroup
    {
        public void AddExercise(IExercise exercise)
        {
            throw new NotImplementedException();
        }

        public void AddExercises(IEnumerable<IExercise> exercises)
        {
            throw new NotImplementedException();
        }

        public void ClearExercises()
        {
            throw new NotImplementedException();
        }

        public void RemoveExercise(IExercise exercise)
        {
            throw new NotImplementedException();
        }
    }
}
