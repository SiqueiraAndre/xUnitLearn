using JornadaMilhas.Dados;
using Microsoft.EntityFrameworkCore;

namespace JornadaMilhas.Test.Integracao;

public class ContextoFixture
{
    public JornadaMilhasContext Context { get;}   
    public ContextoFixture()
    {
        var options = new DbContextOptionsBuilder<JornadaMilhasContext>
                ()
            .UseSqlServer(
                "Server=localhost,1433;Database=JornadaMilhas;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False;TrustServerCertificate=true;")
            .Options;

        Context = new JornadaMilhasContext(options);      
    }
}