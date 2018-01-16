using System;
using System.Collections.Generic;
using System.Text;

namespace Spec
{
    /// <summary>
    /// Base class for all specifications
    /// </summary>
    /// <typeparam name="T">The type being tested by this candidate</typeparam>
    public abstract class Specification<T>
    {
        /// <summary>
        /// Tests if this specification is satisfied by a candidate
        /// </summary>
        /// <param name="candidate">The candidate</param>
        /// <returns></returns>
        public abstract bool IsSatisfiedBy(T candidate);
    }
}
