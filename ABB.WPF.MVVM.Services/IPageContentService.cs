using ABB.WPF.MVVM.Models;
using System.Threading.Tasks;

namespace ABB.WPF.MVVM.Services
{
    public interface IPageContentService
    {
        PageContent Get(string name);

        // Wersja asynchroniczna pobierania zawartości strony
        Task<PageContent> GetAsync(string name);
    }

}
