using S2_Lab10.Data;

namespace S2_Lab10
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            _context = new DataBaseContext();
            _context.DataBaseConnect();
        }

        private DataBaseContext _context;
    }
}