namespace OnlineBookStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;
        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Book> Books => context.Books;

        public void CreateBook(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }
        public void DeleteBook(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
        public void SaveBook(Book b)
        {
            context.SaveChanges();
        }
    }
}
