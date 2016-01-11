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

		[Fact]
		public void OnReturnNumberShouldBe47()
		{
			var magic = new Magic();
			int result = magic.ReturnNumber();
			Assert.Equal<int>(47, result);
		}

		[Fact]
		public void OnReturnMyNameShouldBeArtsiom()
		{
			var magic = new Magic();
			string name = magic.ReturnMyName();
			Assert.Equal<string>("Artsiom", name);
		}
	}
}
