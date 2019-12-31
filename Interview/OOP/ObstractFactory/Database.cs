using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;

namespace Interview.OOP.ObstractFactory
{
    public interface IDatabase
    {
        DbConnection Connection { get; set; }
        DbCommand Command { get; set; }
    }

    public class SqlDatabase : IDatabase
    {
        public DbConnection Connection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbCommand Command { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public class OleDbDatabase : IDatabase
    {
        public DbConnection Connection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbCommand Command { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class DatabaseFactory
    {
        public enum DatabaseType
        {
            SQL,
            OLEDB
        }
        public static IDatabase Create(DatabaseType type)
        {
            switch (type)
            {
                case DatabaseType.SQL:
                    return new SqlDatabase();
                case DatabaseType.OLEDB:
                    return new OleDbDatabase();
                default:
                    throw new InvalidOperationException();
            }
        }
    }
    public class Consumer
    {
        public Consumer()
        {
            var db = DatabaseFactory.Create(DatabaseFactory.DatabaseType.SQL);
        }
    }
}
