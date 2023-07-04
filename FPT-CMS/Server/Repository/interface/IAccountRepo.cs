using Server.DTO;

namespace Server.Repository.@interface;

public interface IAccountRepo
{
    Account AddAccount(Account Account);
    Account UpdateAccount(Account Account);
    Account DeleteAccount(Account Account);
    IEnumerable<Account> GetAccounts();
    Account GetAccountByUserNameAndPassword(AccountDTO accountDTO);
    Account GetAccountByUserName(string username);
    Account GetAccountById(string? id);
}