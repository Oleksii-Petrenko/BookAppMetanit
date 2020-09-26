using System;
using System.Data.Entity;

namespace BookingAppStore.Models
{
    public class BookContext: DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Purchase> Purchases { get; set; }    // Person - People
    }

    // Класс инициализатор
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Price = 220 });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Price = 180 });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Price = 150 });
            db.Books.Add(new Book { Name = "Буратино", Author = "Л. Подеревлянський", Price = 150 });
            db.Books.Add(new Book { Name = "Война", Author = "Р. Скрипин", Price = 100 });
            db.Books.Add(new Book { Name = "Я из Ростова", Author = "В. Янукович", Price = 250 });

            base.Seed(db);
        }
        
        

    }
}