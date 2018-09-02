namespace Decorator
{
    public abstract class Decorator : LibraryItem
    {
        public LibraryItem LibraryItem { get; private set; }

        protected Decorator(LibraryItem libraryItem)
        {
            this.LibraryItem = libraryItem;
        }

        public override void Display()
        {
            this.LibraryItem.Display();
        }
    }
}
