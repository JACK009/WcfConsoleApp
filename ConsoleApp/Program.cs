using ConsoleApp.Helpers;
using System;

namespace ConsoleApp
{
    class Program
    {
        private static TextHelper _textHelper;
        private static string _listOption;
        private static string _emailOption;

        static void Main(string[] args)
        {
            _textHelper = new TextHelper();
            _listOption = "list";
            _emailOption = "email";

            Init();
        }

        private static void Init()
        {
            Console.WriteLine($"Get list of authors enter: \"{_listOption}\" " +
                              $"\nFind author by email enter: \"{_emailOption}\" " +
                              $"\nDefault: [{_listOption}]");

            //--- text
            _textHelper.BreakSection();
            string findAuthorMethod = Console.ReadLine();

            if (string.IsNullOrEmpty(findAuthorMethod) || findAuthorMethod == _listOption)
            {
                AuthorListHelper authorListHelper = new AuthorListHelper();
                authorListHelper.GetAuthorList();
                Init();
            }
            else if (findAuthorMethod == _emailOption)
            {
                AuthorEmailHelper authorEmailHelper = new AuthorEmailHelper();
                authorEmailHelper.GetAuthorByEmail();
                Init();
            }
            else
            {
                _textHelper.InvalidInput();

                //restart init
                Init();
            }
        }
    }
}
