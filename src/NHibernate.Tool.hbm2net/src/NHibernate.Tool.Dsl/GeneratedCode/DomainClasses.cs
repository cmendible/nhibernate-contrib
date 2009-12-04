﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
namespace NHibernate.NHDesigner
{
	/// <summary>
	/// DomainClass NHibernateModel
	/// The root in which all other elements are embedded. Appears as a diagram.
	/// </summary>
	[DslDesign::DisplayNameResource("NHibernate.NHDesigner.NHibernateModel.DisplayName", typeof(global::NHibernate.NHDesigner.NHDesignerDomainModel), "NHibernate.NHDesigner.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("NHibernate.NHDesigner.NHibernateModel.Description", typeof(global::NHibernate.NHDesigner.NHDesignerDomainModel), "NHibernate.NHDesigner.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("278cf18b-4ba5-41c2-a355-0ed78459b7a2")]
	public partial class NHibernateModel : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// NHibernateModel domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x278cf18b, 0x4ba5, 0x41c2, 0xa3, 0x55, 0x0e, 0xd7, 0x84, 0x59, 0xb7, 0xa2);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public NHibernateModel(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartition : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public NHibernateModel(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Entities opposite domain role accessor
		/// <summary>
		/// Gets a list of Entities.
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Entity> Entities
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return new DslModeling::LinkedElementCollection<Entity>(this, global::NHibernate.NHDesigner.NHibernateModelHasEntities.NHibernateModelDomainRoleId);
			}
		}
		#endregion
		#region ElementGroupPrototype Merge methods
		/// <summary>
		/// Returns a value indicating whether the source element represented by the
		/// specified root ProtoElement can be added to this element.
		/// </summary>
		/// <param name="rootElement">
		/// The root ProtoElement representing a source element.  This can be null, 
		/// in which case the ElementGroupPrototype does not contain an ProtoElements
		/// and the code should inspect the ElementGroupPrototype context information.
		/// </param>
		/// <param name="elementGroupPrototype">The ElementGroupPrototype that contains the root ProtoElement.</param>
		/// <returns>true if the source element represented by the ProtoElement can be added to this target element.</returns>
		protected override bool CanMerge(DslModeling::ProtoElementBase rootElement, DslModeling::ElementGroupPrototype elementGroupPrototype)
		{
			if ( elementGroupPrototype == null ) throw new global::System.ArgumentNullException("elementGroupPrototype");
			
			if (rootElement != null)
			{
				DslModeling::DomainClassInfo rootElementDomainInfo = this.Partition.DomainDataDirectory.GetDomainClass(rootElement.DomainClassId);
				
				if (rootElementDomainInfo.IsDerivedFrom(global::NHibernate.NHDesigner.Entity.DomainClassId)) 
				{
					return true;
				}
			}
			return base.CanMerge(rootElement, elementGroupPrototype);
		}
		
		/// <summary>
		/// Called by the Merge process to create a relationship between 
		/// this target element and the specified source element. 
		/// Typically, a parent-child relationship is established
		/// between the target element (the parent) and the source element 
		/// (the child), but any relationship can be established.
		/// </summary>
		/// <param name="sourceElement">The element that is to be related to this model element.</param>
		/// <param name="elementGroup">The group of source ModelElements that have been rehydrated into the target store.</param>
		/// <remarks>
		/// This method is overriden to create the relationship between the target element and the specified source element.
		/// The base method does nothing.
		/// </remarks>
		protected override void MergeRelate(DslModeling::ModelElement sourceElement, DslModeling::ElementGroup elementGroup)
		{
			// In general, sourceElement is allowed to be null, meaning that the elementGroup must be parsed for special cases.
			// However this is not supported in generated code.  Use double-deriving on this class and then override MergeRelate completely if you 
			// need to support this case.
			if ( sourceElement == null ) throw new global::System.ArgumentNullException("sourceElement");
		
				
			global::NHibernate.NHDesigner.Entity sourceEntity1 = sourceElement as global::NHibernate.NHDesigner.Entity;
			if (sourceEntity1 != null)
			{
				// Create link for path NHibernateModelHasEntities.Entities
				this.Entities.Add(sourceEntity1);

				return;
			}
			// Fall through to base class if this class hasn't handled the merge.
			base.MergeRelate(sourceElement, elementGroup);
		}
		
		/// <summary>
		/// Performs operation opposite to MergeRelate - i.e. disconnects a given
		/// element from the current one (removes links created by MergeRelate).
		/// </summary>
		/// <param name="sourceElement">Element to be unmerged/disconnected.</param>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		protected override void MergeDisconnect(DslModeling::ModelElement sourceElement)
		{
			if (sourceElement == null) throw new global::System.ArgumentNullException("sourceElement");
				
			global::NHibernate.NHDesigner.Entity sourceEntity1 = sourceElement as global::NHibernate.NHDesigner.Entity;
			if (sourceEntity1 != null)
			{
				// Delete link for path NHibernateModelHasEntities.Entities
				
				foreach (DslModeling::ElementLink link in global::NHibernate.NHDesigner.NHibernateModelHasEntities.GetLinks((global::NHibernate.NHDesigner.NHibernateModel)this, sourceEntity1))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::NHibernate.NHDesigner.NHibernateModelHasEntities.NHibernateModelDomainRoleId, global::NHibernate.NHDesigner.NHibernateModelHasEntities.ElementDomainRoleId);
				}

				return;
			}
			// Fall through to base class if this class hasn't handled the unmerge.
			base.MergeDisconnect(sourceElement);
		}
		#endregion
	}
}
namespace NHibernate.NHDesigner
{
	/// <summary>
	/// DomainClass Entity
	/// Elements embedded in the model. Appear as boxes on the diagram.
	/// </summary>
	[DslDesign::DisplayNameResource("NHibernate.NHDesigner.Entity.DisplayName", typeof(global::NHibernate.NHDesigner.NHDesignerDomainModel), "NHibernate.NHDesigner.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("NHibernate.NHDesigner.Entity.Description", typeof(global::NHibernate.NHDesigner.NHDesignerDomainModel), "NHibernate.NHDesigner.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[global::System.Diagnostics.DebuggerDisplay("{GetType().Name,nq} (Name = {namePropertyStorage})")]
	[DslModeling::DomainObjectId("db43c997-4966-46ac-9802-01c040526317")]
	public partial class Entity : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Entity domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xdb43c997, 0x4966, 0x46ac, 0x98, 0x02, 0x01, 0xc0, 0x40, 0x52, 0x63, 0x17);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Entity(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartition : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Entity(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0x16ed2d83, 0xca54, 0x4fe2, 0x93, 0xba, 0x72, 0xa7, 0xf2, 0xe9, 0x43, 0x84);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Description for NHibernate.NHDesigner.Entity.Name
		/// </summary>
		[DslDesign::DisplayNameResource("NHibernate.NHDesigner.Entity/Name.DisplayName", typeof(global::NHibernate.NHDesigner.NHDesignerDomainModel), "NHibernate.NHDesigner.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("NHibernate.NHDesigner.Entity/Name.Description", typeof(global::NHibernate.NHDesigner.NHDesignerDomainModel), "NHibernate.NHDesigner.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("")]
		[DslModeling::ElementName]
		[DslModeling::DomainObjectId("16ed2d83-ca54-4fe2-93ba-72a7f2e94384")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Entity.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<Entity, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Entity.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Entity.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Entity element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Entity element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region NHibernateModel opposite domain role accessor
		/// <summary>
		/// Gets or sets NHibernateModel.
		/// </summary>
		public virtual NHibernateModel NHibernateModel
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::NHibernate.NHDesigner.NHibernateModelHasEntities.ElementDomainRoleId) as NHibernateModel;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::NHibernate.NHDesigner.NHibernateModelHasEntities.ElementDomainRoleId, value);
			}
		}
		#endregion
		#region Subclass opposite domain role accessor
		/// <summary>
		/// Gets a list of Subclass.
		/// Description for NHibernate.NHDesigner.ExampleRelationship.Target
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Entity> Subclass
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return new DslModeling::LinkedElementCollection<Entity>(this, global::NHibernate.NHDesigner.EntityReferencesBase.SourceDomainRoleId);
			}
		}
		#endregion
		#region Baseclass opposite domain role accessor
		/// <summary>
		/// Gets a list of Baseclass.
		/// Description for NHibernate.NHDesigner.ExampleRelationship.Source
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Entity> Baseclass
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return new DslModeling::LinkedElementCollection<Entity>(this, global::NHibernate.NHDesigner.EntityReferencesBase.TargetDomainRoleId);
			}
		}
		#endregion
		#region Properties opposite domain role accessor
		/// <summary>
		/// Gets a list of Properties.
		/// Description for NHibernate.NHDesigner.EntityHasProperties.Entity
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Property> Properties
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return new DslModeling::LinkedElementCollection<Property>(this, global::NHibernate.NHDesigner.EntityHasProperties.EntityDomainRoleId);
			}
		}
		#endregion
		#region JoinedSubclass opposite domain role accessor
		/// <summary>
		/// Gets a list of JoinedSubclass.
		/// Description for NHibernate.NHDesigner.EntityReferencesBaseWithJoin.SourceEntity
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Entity> JoinedSubclass
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return new DslModeling::LinkedElementCollection<Entity>(this, global::NHibernate.NHDesigner.EntityReferencesBaseWithJoin.SourceEntityDomainRoleId);
			}
		}
		#endregion
		#region BaseclassWJoin opposite domain role accessor
		/// <summary>
		/// Gets a list of BaseclassWJoin.
		/// Description for NHibernate.NHDesigner.EntityReferencesBaseWithJoin.TargetEntity
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Entity> BaseclassWJoin
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return new DslModeling::LinkedElementCollection<Entity>(this, global::NHibernate.NHDesigner.EntityReferencesBaseWithJoin.TargetEntityDomainRoleId);
			}
		}
		#endregion
		#region ElementGroupPrototype Merge methods
		/// <summary>
		/// Returns a value indicating whether the source element represented by the
		/// specified root ProtoElement can be added to this element.
		/// </summary>
		/// <param name="rootElement">
		/// The root ProtoElement representing a source element.  This can be null, 
		/// in which case the ElementGroupPrototype does not contain an ProtoElements
		/// and the code should inspect the ElementGroupPrototype context information.
		/// </param>
		/// <param name="elementGroupPrototype">The ElementGroupPrototype that contains the root ProtoElement.</param>
		/// <returns>true if the source element represented by the ProtoElement can be added to this target element.</returns>
		protected override bool CanMerge(DslModeling::ProtoElementBase rootElement, DslModeling::ElementGroupPrototype elementGroupPrototype)
		{
			if ( elementGroupPrototype == null ) throw new global::System.ArgumentNullException("elementGroupPrototype");
			
			if (rootElement != null)
			{
				DslModeling::DomainClassInfo rootElementDomainInfo = this.Partition.DomainDataDirectory.GetDomainClass(rootElement.DomainClassId);
				
				if (rootElementDomainInfo.IsDerivedFrom(global::NHibernate.NHDesigner.Property.DomainClassId)) 
				{
					return true;
				}
			}
			return base.CanMerge(rootElement, elementGroupPrototype);
		}
		
		/// <summary>
		/// Called by the Merge process to create a relationship between 
		/// this target element and the specified source element. 
		/// Typically, a parent-child relationship is established
		/// between the target element (the parent) and the source element 
		/// (the child), but any relationship can be established.
		/// </summary>
		/// <param name="sourceElement">The element that is to be related to this model element.</param>
		/// <param name="elementGroup">The group of source ModelElements that have been rehydrated into the target store.</param>
		/// <remarks>
		/// This method is overriden to create the relationship between the target element and the specified source element.
		/// The base method does nothing.
		/// </remarks>
		protected override void MergeRelate(DslModeling::ModelElement sourceElement, DslModeling::ElementGroup elementGroup)
		{
			// In general, sourceElement is allowed to be null, meaning that the elementGroup must be parsed for special cases.
			// However this is not supported in generated code.  Use double-deriving on this class and then override MergeRelate completely if you 
			// need to support this case.
			if ( sourceElement == null ) throw new global::System.ArgumentNullException("sourceElement");
		
				
			global::NHibernate.NHDesigner.Property sourceProperty1 = sourceElement as global::NHibernate.NHDesigner.Property;
			if (sourceProperty1 != null)
			{
				// Create link for path EntityHasProperties.Properties
				this.Properties.Add(sourceProperty1);

				return;
			}
			// Fall through to base class if this class hasn't handled the merge.
			base.MergeRelate(sourceElement, elementGroup);
		}
		
		/// <summary>
		/// Performs operation opposite to MergeRelate - i.e. disconnects a given
		/// element from the current one (removes links created by MergeRelate).
		/// </summary>
		/// <param name="sourceElement">Element to be unmerged/disconnected.</param>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		protected override void MergeDisconnect(DslModeling::ModelElement sourceElement)
		{
			if (sourceElement == null) throw new global::System.ArgumentNullException("sourceElement");
				
			global::NHibernate.NHDesigner.Property sourceProperty1 = sourceElement as global::NHibernate.NHDesigner.Property;
			if (sourceProperty1 != null)
			{
				// Delete link for path EntityHasProperties.Properties
				
				foreach (DslModeling::ElementLink link in global::NHibernate.NHDesigner.EntityHasProperties.GetLinks((global::NHibernate.NHDesigner.Entity)this, sourceProperty1))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::NHibernate.NHDesigner.EntityHasProperties.EntityDomainRoleId, global::NHibernate.NHDesigner.EntityHasProperties.PropertyDomainRoleId);
				}

				return;
			}
			// Fall through to base class if this class hasn't handled the unmerge.
			base.MergeDisconnect(sourceElement);
		}
		#endregion
	}
}
namespace NHibernate.NHDesigner
{
	/// <summary>
	/// DomainClass Property
	/// Description for NHibernate.NHDesigner.Property
	/// </summary>
	[DslDesign::DisplayNameResource("NHibernate.NHDesigner.Property.DisplayName", typeof(global::NHibernate.NHDesigner.NHDesignerDomainModel), "NHibernate.NHDesigner.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("NHibernate.NHDesigner.Property.Description", typeof(global::NHibernate.NHDesigner.NHDesignerDomainModel), "NHibernate.NHDesigner.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("84d9eca0-bfd1-49ca-8797-57df3abd8810")]
	public partial class Property : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Property domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x84d9eca0, 0xbfd1, 0x49ca, 0x87, 0x97, 0x57, 0xdf, 0x3a, 0xbd, 0x88, 0x10);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Property(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartition : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Property(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0xe5232ec3, 0x67be, 0x43a6, 0xa6, 0xc4, 0x4c, 0xda, 0x50, 0x56, 0x19, 0x05);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Description for NHibernate.NHDesigner.Property.Name
		/// </summary>
		[DslDesign::DisplayNameResource("NHibernate.NHDesigner.Property/Name.DisplayName", typeof(global::NHibernate.NHDesigner.NHDesignerDomainModel), "NHibernate.NHDesigner.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("NHibernate.NHDesigner.Property/Name.Description", typeof(global::NHibernate.NHDesigner.NHDesignerDomainModel), "NHibernate.NHDesigner.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("e5232ec3-67be-43a6-a6c4-4cda50561905")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Property.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<Property, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Property.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Property.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Property element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Property element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Entity opposite domain role accessor
		/// <summary>
		/// Gets or sets Entity.
		/// Description for NHibernate.NHDesigner.EntityHasProperties.Property
		/// </summary>
		public virtual Entity Entity
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::NHibernate.NHDesigner.EntityHasProperties.PropertyDomainRoleId) as Entity;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::NHibernate.NHDesigner.EntityHasProperties.PropertyDomainRoleId, value);
			}
		}
		#endregion
	}
}
namespace NHibernate.NHDesigner
{
	//Autogenerated domain classes
	public partial class Entity : DslModeling::ModelElement
	{
	}
}