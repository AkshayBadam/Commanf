using System;
namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            ICommand openCommand = new OpenCommand(document);
            ICommand saveCommand = new SaveCommand(document);
            MenuOptions menu = new MenuOptions(openCommand, saveCommand);
            menu.clickOpen();
            menu.clickSave();
        }
    }
}