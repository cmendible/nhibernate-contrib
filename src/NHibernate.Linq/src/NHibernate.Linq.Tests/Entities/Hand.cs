using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Linq.Tests.Entities
{
	public class Hand
	{
		public virtual int Id { get; set; }
		public virtual Finger Thumb { get; set; }
		public virtual Finger Index { get; set; }
		public virtual Finger Middle { get; set; }
		public virtual Finger Ring { get; set; }
		public virtual Finger Little { get; set; }
	}
}
