using Domain.Entities;

namespace Application.IRepositories;

public interface IAccountRepository
{
    Task<Account?> GetAccountByUsernameAsync(string username);
    Task<List<Account>> GetAllAccountsAsync();
    Task<Account?> GetAccountByIdAsync(int accountId);
    Task DeleteAccountAsync(int accountId);
    Task UpdateAccountAsync(Account account);
    Task AddAccountAsync(Account account);
}
