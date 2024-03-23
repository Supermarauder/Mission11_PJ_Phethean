using SQLitePCL;

namespace Mission11_PJ_Phethean.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookstoreContext _context;
        public EFBookRepository(BookstoreContext temp) 
        {
            _context = temp;
        } // constructor

        public IQueryable<Book> Books => _context.Books;
    }
}
