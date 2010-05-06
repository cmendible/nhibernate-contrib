using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Linq.Tests.Entities
{
	public class Finger
	{
		public virtual int Id { get; set; }
		public virtual decimal Length { get; set; }
	}
}
