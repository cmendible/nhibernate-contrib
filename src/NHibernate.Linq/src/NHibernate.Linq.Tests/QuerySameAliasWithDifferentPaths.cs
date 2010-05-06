using System.Linq;
using NHibernate.Linq.Tests.Entities;
using NUnit.Framework;
using System.Collections.Generic;

namespace NHibernate.Linq.Tests
{
	[TestFixture]
	public class QuerySameAliasWithDifferentPaths : BaseTest
	{
		protected override ISession CreateSession()
		{
			return GlobalSetup.CreateSession();
		}

		[Test]
		public void QueryArmsByHandsWithSameFinger()
		{
			// Thumb is ussed twice in this linq expression but in diferent paths. 
			// Therefore generated query shoul have 2 joins insted of just one.
			var query = nhib.Arms.Where(a => a.LeftHand.Thumb.Length == 1 || a.RightHand.Thumb.Length == 1);
			Assert.AreEqual(2, query.Count());
			Assert.IsTrue(query.Any(a => a.Description == "Left Arm"));
			Assert.IsTrue(query.Any(a => a.Description == "Right Arm"));
		}
	}
}