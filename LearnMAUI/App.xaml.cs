using Microsoft.Extensions.DependencyInjection;

namespace LearnMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Загружаем оболочку Appshell
            return new Window(new AppShell());
        }
    }
}