namespace assingment4
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
            Application.Run(new MainForm());

        }

        public static void CreateAnimal(Animal[] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i].ToString());

                if (animals[i] is Dog)
                {
                    ((Dog)animals[i]).Bark();
                }
                else if (animals[i] is Cat)
                {
                    ((Cat)animals[i]).Purr();
                }
            }

        }
    }
}