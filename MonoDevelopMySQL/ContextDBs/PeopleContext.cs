using System;
using System.Data.Entity;
using System.Data.Common;
using MonoDevelopMySQL.Models;
using MySql.Data.Entity;

namespace MonoDevelopMySQL.ContextDbs
{
	public class PeopleContext: DbContext
	{
		public PeopleContext ():base("connStr")
		{
		}

		public PeopleContext (DbConnection existingConnection, bool contextOwensConnection)
			: base(existingConnection, contextOwensConnection)
		{

		}

		public DbSet <Person> People { get; set;}
	}
}

