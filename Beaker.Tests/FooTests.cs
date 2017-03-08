using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Beaker.Tests
{
    public class FooTests
    {
		[Fact]
		public void BarTest()
		{
			var foo = new Foo();
			foo.Bar();
		}
    }
}
