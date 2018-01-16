using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Spec.Tests
{
    public class CompositeSpecificationTests
    {
        [Fact]
        public void ctor_sets_properties()
        {
            var left = Mock.Of<Specification<int>>();
            var right = Mock.Of<Specification<int>>();

            var compositeSpec = new TestSpec(left, right);

            Assert.Equal(left, compositeSpec.LeftSpec);
            Assert.Equal(right, compositeSpec.RightSpec);
        }

        [Fact]
        public void ctor_throws_exception_if_left_arg_is_null()
        {
            Specification<int> left = null;
            Specification<int> right = Mock.Of<Specification<int>>();

            var ex = Assert.Throws<ArgumentNullException>(() => new TestSpec(left, right));

            Assert.Equal("leftSpec", ex.ParamName);
        }

        [Fact]
        public void ctor_throws_exception_if_right_arg_is_null()
        {
            Specification<int> left = Mock.Of<Specification<int>>();
            Specification<int> right = null;

            var ex = Assert.Throws<ArgumentNullException>(() => new TestSpec(left, right));

            Assert.Equal("rightSpec", ex.ParamName);
        }

        class TestSpec : CompositeSpecification<int>
        {
            public TestSpec(Specification<int> leftSpect, Specification<int> rightSpec) : base(leftSpect, rightSpec)
            {
            }

            public new Specification<int> LeftSpec => base.LeftSpec;
            public new Specification<int> RightSpec => base.RightSpec;

            public override bool IsSatisfiedBy(int candidate)
            {
                throw new NotImplementedException();
            }
        }
    }
}
