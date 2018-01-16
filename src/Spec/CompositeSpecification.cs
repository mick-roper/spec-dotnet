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
        /// <summary>
        /// Creates a new instance of the <see cref="CompositeSpecification{TCandidate}"/> class
        /// </summary>
        /// <param name="leftSpec">The left spec that the composite compares</param>
        /// <param name="rightSpec">The right spec that the composite compares</param>
        public CompositeSpecification(Specification<TCandidate> leftSpec, Specification<TCandidate> rightSpec)
        {
            LeftSpec = leftSpec ?? throw new ArgumentNullException(nameof(leftSpec));
            RightSpec = rightSpec ?? throw new ArgumentNullException(nameof(rightSpec));
        }

        protected Specification<TCandidate> LeftSpec { get; }
        protected Specification<TCandidate> RightSpec { get; }
    }
}
