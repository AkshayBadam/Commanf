﻿using System;
namespace CommandDesignPattern
{
    public class OpenCommand : ICommand
    {
        private Document document;

        public OpenCommand(Document doc)
        {
            document = doc;
        }

        public void Execute()
        {
            document.Open();
        }
    }
}
