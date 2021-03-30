using System.Drawing;

namespace S2_Lab02
{
    public class AppSettings
    {
        private Color _color = Color.WhiteSmoke;
        
        private static AppSettings _appSettings;
        private AppSettings() { }
        
        public static AppSettings GetInstance()
        {
            return _appSettings ??= new AppSettings();
        }

        public void DoSomething(MainForm form)
        {
            form.BackColor = _color;
        }
    }
}