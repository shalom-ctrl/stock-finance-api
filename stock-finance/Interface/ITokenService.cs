using stock_finance.Models;

namespace stock_finance.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
