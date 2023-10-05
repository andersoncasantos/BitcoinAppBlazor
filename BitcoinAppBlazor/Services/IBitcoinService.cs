using BitcoinAppBlazor.DTOs;

namespace BitcoinAppBlazor.Services
{
    public interface IBitcoinService
    {
        Task<List<BitcoinDataDTO>> FindBy(DateTime startDate);
    }
}
