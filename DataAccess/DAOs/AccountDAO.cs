using DataAccess.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class AccountDAO : BaseDAO<Account>
{
    private readonly AppConfiguration _configuration;
    public AccountDAO(AppConfiguration configuration) : base(configuration)
    {
        _configuration = configuration;
    }

    public async Task<Account?> GetAccountByUsernameAsync(string username)
    {
        Account? account;
        using (var context = new AppDBContext(_configuration))
        {
            account = await context.Accounts.FirstOrDefaultAsync(x => x.Username.Equals(username));
        }
        return account;
    }
}
