using mentoria_embarque_digital.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infra;

public class ContextFactory : IDesignTimeDbContextFactory<Context>

{
    public Context CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<Context>();
        optionsBuilder.UseSqlite("Data Source=./Infra/Db.sqlite3;Cache=Shared");

        return new Context(optionsBuilder.Options);
    }
}