using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly AccountDAO _accountDao;

    public AccountRepository(AccountDAO accountDao)
    {
        _accountDao = accountDao;
    }

    public async Task AddAccountAsync(Account account)
    {
        var acc = await _accountDao.GetAccountByUsernameAsync(account.Username);
        if (acc != null)
        {
            throw new ArgumentException("Username is duplicated!");
        }
        await _accountDao.SaveAsync(account);
    }

    public async Task DeleteAccountAsync(int accountId)
    {
        var acc = await _accountDao.GetByIdAsync(accountId);
        if (acc == null)
        {
            throw new ArgumentException("AccountId not found!");
        }
        await _accountDao.SoftDeleteAsync(acc);
    }

    public async Task<Account?> GetAccountByIdAsync(int accountId)
    {
        return await _accountDao.GetByIdAsync(accountId);
    }

    public Task<Account?> GetAccountByUsernameAsync(string username)
    {
        return _accountDao.GetAccountByUsernameAsync(username.Trim());
    }        

    public async Task<List<Account>> GetAllAccountsAsync()
    {
        return await _accountDao.GetAllAsync();
    }

    public async Task UpdateAccountAsync(Account account)
    {
        // check if account id exist
        var acc = await _accountDao.GetByIdAsync(account.Id);
        if (acc == null)
        {
            throw new ArgumentException("AccountId not found!");
        }
        // check duplicate username with other account
        var acc2 = await _accountDao.GetAccountByUsernameAsync(account.Username);
        if (acc2 != null && acc2.Id != account.Id)
        {
            throw new Exception("Duplicate with other account's usernamed!");
        }
        await _accountDao.UpdateAsync(account);
    }
}
