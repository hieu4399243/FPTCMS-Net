using Server.DTO;

namespace Server.DAO;

public class AccountManagement
{
    private static AccountManagement instance;
    private static readonly object instancelock = new object();
    public AccountManagement() { }
    public static AccountManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new AccountManagement();
            }
            return instance;
        }
    }

    public Account AddAccount(Account account)
    {
        throw new NotImplementedException();
    }

    public Account UpdateAccount(Account account)
    {
        throw new NotImplementedException();
    }

    public Account DeleteAccount(Account account)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Account> GetAccounts()
    {
        throw new NotImplementedException();
    }

    public Account GetAccountById(string? id)
    {
        throw new NotImplementedException();
    }

    public Account GetAccountByUserNameAndPassword(AccountDTO accountDto)
    {
        throw new NotImplementedException();
    }

    public Account GetAccountByUserName(string username)
    {
        throw new NotImplementedException();
    }
}