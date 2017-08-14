using ConsoleApp.AuthorServiceReference;
using System;
using System.Collections.Generic;

namespace ConsoleApp.Helpers
{
    public class AuthorListHelper
    {
        private readonly TextHelper _textHelper;
        private int _pageIndex;
        private int _pagSize;

        public AuthorListHelper()
        {
            _textHelper = new TextHelper();
            _pageIndex = 1;
            _pagSize = 10;
        }

        //ask user input
        private void AskPageIndexAndSize()
        {
            Console.WriteLine($"Insert the pageIndex: [{_pageIndex}]");
            string index = Console.ReadLine();

            if (!string.IsNullOrEmpty(index))
            {
                _pageIndex = Int32.Parse(index);
            }

            Console.WriteLine($"Insert the pageSize: [{_pagSize}]");
            string size = Console.ReadLine();

            if (!string.IsNullOrEmpty(size))
            {
                _pagSize = Int32.Parse(size);
            }

            Console.WriteLine();
        }

        //show author related data
        private void ShowInfo()
        {
            AuthorServiceClient proxy = new AuthorServiceClient();
            IEnumerable<Author> authors = proxy.GetAuthors(_pageIndex, _pagSize);

            foreach (Author author in authors)
            {
                _textHelper.AuthorLine(author);
            }

            proxy.Close();
            _textHelper.Continue();
        }

        public void GetAuthorList()
        {
            AskPageIndexAndSize();
            ShowInfo();
        }
    }
}
