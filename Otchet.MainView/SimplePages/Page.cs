using System.Threading.Tasks;

namespace Otchet.MainView.SimplePages;

public class Page:System.Windows.Controls.Page
{
    protected int _id=0;

    protected virtual Task _refresh()
    {
        return null;
    }
}