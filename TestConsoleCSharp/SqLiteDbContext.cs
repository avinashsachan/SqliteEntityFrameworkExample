using System.Data.Entity;
using System.Data.SQLite;

namespace TestConsoleCSharp
{
    //[DbConfigurationType(typeof(SQLiteConfiguration))]
    public class SqLiteDbContext : DbContext
    {
        
        public SqLiteDbContext() :
            base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = FromConfig.ConnectionString, ForeignKeys = true }.ConnectionString
            }, true)
        {
            Database.SetInitializer<SqLiteDbContext>(null);
            this.Configuration.UseDatabaseNullSemantics = true;
#if DEBUG
            Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
#endif

        }


        public DbSet<Table1> Table1s { get; set; }

    }
}
