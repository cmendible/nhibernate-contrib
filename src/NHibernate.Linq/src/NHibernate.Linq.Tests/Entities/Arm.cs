using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Linq.Tests.Entities
{
	public class Arm
	{
		public virtual int Id { get; set; }
		public virtual string Description { get; set; }
		public virtual Hand LeftHand { get; set; }
		public virtual Hand RightHand { get; set; }
	}

	
}
