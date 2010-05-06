using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using NHibernate.Metadata;

namespace NHibernate.Linq.Expressions
{
	public class EntityExpression : NHibernateExpression
	{
		private readonly string _alias;
		private readonly string _associationPath;
		private readonly IClassMetadata _metaData;
		private readonly Expression _expression;

		public string Alias
		{
			[DebuggerStepThrough]
			get { return _alias; }
		}

		public string AssociationPath
		{
			[DebuggerStepThrough]
			get { return _associationPath; }
		}

		public IClassMetadata MetaData
		{
			[DebuggerStepThrough]
			get { return _metaData; }
		}

		public Expression Expression
		{
			[DebuggerStepThrough]
			get { return _expression; }
		}

		private static string GetUniqueAlias(string associationPath, string alias, IDictionary<string, IList<string>> addedAlias)
		{
			if (addedAlias.ContainsKey(alias))
			{
				if (addedAlias[alias] == null)
					addedAlias[alias] = new List<string>();

				if (!addedAlias[alias].Contains(associationPath))
					addedAlias[alias].Add(associationPath);

				var index = addedAlias[alias].IndexOf(associationPath);
				return index > 0 ? alias + index.ToString() : alias;
			}
			else
			{
				addedAlias.Add(alias, new List<string>() { associationPath });
				return alias;
			}
		}

		public EntityExpression(string associationPath, string alias, System.Type type,
			IClassMetadata metaData, Expression expression, IDictionary<string, IList<string>> addedAlias)
			: base(IsRoot(expression) ? NHibernateExpressionType.RootEntity : NHibernateExpressionType.Entity, type)
		{
			_associationPath = associationPath;
			_alias = GetUniqueAlias(associationPath, alias, addedAlias);
			_metaData = metaData;
			_expression = expression;
		}

		private static bool IsRoot(Expression expr)
		{
			if (expr == null) return true;
			if (!(expr is EntityExpression)) return true;
			return false;
		}

		public override string ToString()
		{
			return Alias;
		}

		public virtual string GetAliasedIdentifierPropertyName()
		{
			if (this.NodeType == NHibernateExpressionType.RootEntity)
			{
				return this.MetaData.IdentifierPropertyName;
			}
			return string.Format("{0}.{1}", this.Alias, this.MetaData.IdentifierPropertyName);
		}
	}
}
