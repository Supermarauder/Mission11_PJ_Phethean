namespace Mission11_PJ_Phethean.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
