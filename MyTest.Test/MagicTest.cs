using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyTest.Test
{
	public class MagicTest
	{
		[Fact]
		public void OnTestCastSpellShouldBeAccio()
		{
			var magic = new Magic();
			string castedSpell = magic.CastSpell();
			Assert.Equal<string>("Accio", castedSpell);
		}
	}
}
