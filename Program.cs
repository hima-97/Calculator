/*
 * The `Program.cs` file serves as the main entry point for the Calculator application.
 * This file contains the `Main` method, which is the first method executed when the application starts.
 * 
 * Key Points:
 * - The `Main` method is marked with the `[STAThread]` attribute, indicating that the application uses a single-threaded apartment model, which is required for Windows Forms applications.
 * - The `ApplicationConfiguration.Initialize()` method is called to apply any custom application configurations such as high DPI settings or default font settings.
 * - The `Application.Run(new Calculator())` method starts the application and opens the main Calculator form, initiating the application's event loop and displaying the user interface.
 *
 * In summary, the `Program.cs` file initializes and starts the Calculator application, setting up necessary configurations and launching the main form.
 */

namespace Calculator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Calculator());
        }
    }
}
