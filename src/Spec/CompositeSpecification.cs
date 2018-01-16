using System;
using System.Collections.Generic;
using System.Text;

namespace Spec
{
    /// <summary>
    /// A base class for specifications that compare 2 specs
    /// </summary>
    /// <typeparam name="TCandidate">The candidate type</typeparam>
    public abstract class CompositeSpecification<TCandidate> : Specification<TCandidate>
    {
    }
}
