﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by BLToolkit template for T4.
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;

using BLToolkit.Data;
using BLToolkit.Data.Linq;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Validation;

namespace PostgreSQLDataModel
{
	public partial class PostgreSQLDataModel : DbManager
	{
		public Table<Child>         Child         { get { return this.GetTable<Child>();         } }
		public Table<GrandChild>    GrandChild    { get { return this.GetTable<GrandChild>();    } }
		public Table<LinqDataTypes> LinqDataTypes { get { return this.GetTable<LinqDataTypes>(); } }
		public Table<Parent>        Parent        { get { return this.GetTable<Parent>();        } }
		public Table<Person>        Person        { get { return this.GetTable<Person>();        } }
	}

	[TableName(Name="Child")]
	public partial class Child
	{
		[Nullable] public Int32? ParentID { get; set; } // integer
		[Nullable] public Int32? ChildID  { get; set; } // integer
	}

	[TableName(Name="GrandChild")]
	public partial class GrandChild
	{
		[Nullable] public Int32? ParentID     { get; set; } // integer
		[Nullable] public Int32? ChildID      { get; set; } // integer
		[Nullable] public Int32? GrandChildID { get; set; } // integer
	}

	[TableName(Name="LinqDataTypes")]
	public partial class LinqDataTypes
	{
		[Nullable          ] public Int32?    ID            { get; set; } // integer
		[Nullable          ] public Decimal?  MoneyValue    { get; set; } // numeric(10,4)(10)(4)
		[Nullable          ] public DateTime? DateTimeValue { get; set; } // timestamp without time zone
		[Nullable          ] public Boolean?  BoolValue     { get; set; } // boolean
		[Nullable          ] public Guid?     GuidValue     { get; set; } // uuid
		[          Required] public Byte[]    BinaryValue   { get; set; } // bytea
		[Nullable          ] public Int16?    SmallIntValue { get; set; } // smallint
	}

	[TableName(Name="Parent")]
	public partial class Parent
	{
		[Nullable] public Int32? ParentID { get; set; } // integer
		[Nullable] public Int32? Value1   { get; set; } // integer
	}

	[TableName(Name="Person")]
	public partial class Person
	{
		[Identity, PrimaryKey(1), Required] public Int32  PersonID   { get; set; } // integer
		[                         Required] public String FirstName  { get; set; } // character varying(50)(50)
		[                         Required] public String LastName   { get; set; } // character varying(50)(50)
		[                         Required] public String MiddleName { get; set; } // character varying(50)(50)
		[                         Required] public String Gender     { get; set; } // character(1)(1)
	}
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                