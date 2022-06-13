namespace CommandDesignPattern
{
    public class MenuOptions
    {
        private ICommand openCommand;
        private ICommand saveCommand;
        private ICommand closeCommand;

        public MenuOptions(ICommand open, ICommand save)
        {
            this.openCommand = open;
            this.saveCommand = save;
        }

        public void clickOpen()
        {
            openCommand.Execute();
        }

        public void clickSave()
        {
            saveCommand.Execute();
        }
    }
}