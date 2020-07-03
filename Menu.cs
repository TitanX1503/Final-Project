using System;

namespace Final_Project
{
    class Menu
    {
        static void Main(string[] args)
        {
            class Menu
    {
        

        private const int MAIN_MENU_EXIT_OPTION = 9;
        private const int GO_BACK_OPTION = 9;

        List<int> mainMenuOptions = new List<int>(new int[] {1, 2, 3, 4, 5, 6, 9});
        List<int> selectConeOptions = new List<int>(new int[] {1, 2, 9});

        private string tipoCono = "Regular";


        private void DisplayWelcomeMessage() {
            System.Console.WriteLine("ReportCard");
            System.Console.WriteLine();
        }

        private void DisplayMainMenuOptions() {
            System.Console.WriteLine("1) Captura De Alumnos");
            System.Console.WriteLine("2) Borrar Alumnos");
            System.Console.WriteLine("3) Captura de informacion");
            System.Console.WriteLine("4) Borrar Informacion");
            System.Console.WriteLine("5) Exportar Informacion");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        }

        private void DisplayByeMessage() {
            System.Console.WriteLine("Esperemos La Plataforma Haya Resultado Para Su Conveniencia");
        }

        private int RequestOption(List<int> validOptions) {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            while(!isUserInputValid) {
                System.Console.WriteLine("Nombre Del Alumno");
                string userInput = System.Console.ReadLine();


                try {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                } catch (System.Exception) {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }

        private void DisplaySelectConeMessage() {
            System.Console.WriteLine("Nombre Del Alumno");
            System.Console.WriteLine();
        }


        public void Display() 
        {
            int selectedOption = 0;

            DisplayWelcomeMessage();

            while (selectedOption != MAIN_MENU_EXIT_OPTION)
            {
                DisplayMainMenuOptions();

                selectedOption = RequestOption(mainMenuOptions);
                
            }

            DisplayByeMessage();
        }
    }
}