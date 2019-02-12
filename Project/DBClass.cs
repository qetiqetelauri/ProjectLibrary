using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class DBClass
    {
        //Models
        public User CreatUserModel(int userid)
        {
            try
            {
                using (LibraryEntities db = new LibraryEntities())
                {
                    User usermodel = new User();
                    usermodel = db.Users.Where(x => x.UserID == userid).FirstOrDefault();
                    return usermodel;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public Author CreatAutherModel(int AuthorID)
        {
            try
            {
                using (LibraryEntities db = new LibraryEntities())
                {
                    Author AuthorModel = new Author();
                    AuthorModel = db.Authors.Where(x => x.AuthorID == AuthorID).FirstOrDefault();
                    return AuthorModel;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        #region BookPage
        public void GetBooksGrid(int pageNumber, int page, DataGridView grid)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var list = from Book in db.Books
                           join Author in db.Authors on Book.BookAuthorID equals Author.AuthorID
                           select new
                           {
                               Book.BookID,
                               Book.BookName,
                               Book.BookReleaseDate,
                               Author.AuthorFirstName,
                               Book.BookPublishHouse
                           };
                grid.DataSource = list.OrderBy(x => x.BookID).Skip(pageNumber * page).Take(pageNumber).ToList();


            }


        }
        public int GetBooksCount()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var list = from Book in db.Books
                           join Author in db.Authors on Book.BookAuthorID equals Author.AuthorID
                           select new
                           {
                               Book.BookID,
                               Book.BookName,
                               Book.BookReleaseDate,
                               Author.AuthorFirstName,
                               Book.BookPublishHouse
                           };
                return list.ToList().Count();


            }


        }
        public void AddORChangeBook(Book bookmodel)
        {
            try
            {
                using (LibraryEntities db = new LibraryEntities())
                {
                    if (bookmodel.BookID == 0)//Insert
                        db.Books.Add(bookmodel);
                    else //Update
                        db.Entry(bookmodel).State = EntityState.Modified;


                    db.SaveChanges();
                    MessageBox.Show("Submitted Successfully");

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void DeleteBook(Book BookModel)
        {
            try
            {
                using (LibraryEntities db = new LibraryEntities())
                {
                    var entry = db.Entry(BookModel);
                    if (entry.State == EntityState.Detached)
                        db.Books.Attach(BookModel);

                    db.Books.Remove(BookModel);
                    db.SaveChanges();
                    MessageBox.Show("Deleted Successfully");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("YOU can not Delet this!");
            }

        }
        public Book GetBookRow(int BookID)
        {
            Book BookModel = new Book();
            using (LibraryEntities db = new LibraryEntities())
            {
                BookModel = db.Books.Where(x => x.BookID == BookID).FirstOrDefault();
                return BookModel;
            }

        }
        public void SearchBook(String Keyword, int page, int pageNumber, DataGridView grid)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var list = from Book in db.Books
                           join Author in db.Authors on Book.BookAuthorID equals Author.AuthorID
                           where (Book.BookName.Contains(Keyword) || Book.BookPublishHouse.Contains(Keyword) || Author.AuthorFirstName.Contains(Keyword))
                           select new
                           {
                               Book.BookID,
                               Book.BookName,
                               Book.BookReleaseDate,
                               Author.AuthorFirstName,
                               Book.BookPublishHouse
                           };
                grid.DataSource = list.OrderBy(x => x.BookID).Skip(pageNumber * page).Take(2).ToList();
            }
        }
        public void AddORChangeBookLoad(ComboBox AuthorcomboBox)
        {
            try
            {
                using (LibraryEntities db = new LibraryEntities())
                {
                    var listAuthor = from Author in db.Authors
                                     select Author;
                    AuthorcomboBox.DisplayMember = "AuthorFullName";
                    AuthorcomboBox.ValueMember = "AuthorID";
                    AuthorcomboBox.DataSource = listAuthor.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public Book GetBook(int BookID)
        {
            try
            {
                using (LibraryEntities db = new LibraryEntities())
                {
                    Book bookmodel = new Book();
                    bookmodel = db.Books.Where(x => x.BookID == BookID).FirstOrDefault();
                    return bookmodel;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion

        #region AuthorPage
        public void GetAuthorsGrid(int pageNumber, int page, DataGridView grid)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var list = from Author in db.Authors
                           select Author;


                grid.DataSource = list.OrderBy(x => x.AuthorID).Skip(pageNumber * page).Take(pageNumber).ToList();
            }
        }
        public int GetAuthorsCount()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var list = from Author in db.Authors
                           select Author;


                return list.ToList().Count();
            }
        }
        public void DeleteAuthor(Author AuthorModel)
        {
            try
            {
                using (LibraryEntities db = new LibraryEntities())
                {
                    var entry = db.Entry(AuthorModel);
                    if (entry.State == EntityState.Detached)
                        db.Authors.Attach(AuthorModel);

                    db.Authors.Remove(AuthorModel);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("You can not delet this record");
            }

        }
        public Author GetAuthorRow(int AuthorID)
        {
            Author AuthorModel = new Author();
            using (LibraryEntities db = new LibraryEntities())
            {
                AuthorModel = db.Authors.Where(x => x.AuthorID == AuthorID).FirstOrDefault();
                return AuthorModel;
            }

        }
        public void SearchAuthor(String Keyword, int page, int pageNumber, DataGridView grid)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var list = from Author in db.Authors
                           where (Author.AuthorFirstName.Contains(Keyword) || Author.AuthorLastName.Contains(Keyword))
                           select new
                           {
                               Author.AuthorID,
                               Author.AuthorFirstName,
                               Author.AuthorLastName,
                               Author.AuthorBirthDate,
                           };

                grid.DataSource = list.OrderBy(x => x.AuthorID).Skip(pageNumber * page).Take(pageNumber).ToList();
            }
        }

        #endregion

        #region RequestPage
        public void GetRequestGrid(int pageNumber, int page, DataGridView grid)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var list = from Request in db.Requests
                           join User in db.Users on Request.UserID equals User.UserID
                           join book in db.Books on Request.BookID equals book.BookID
                           where Request.RequestStatus.Equals(null)
                           select new
                           {
                               Request.RequestID,
                               Request.RequestDate,
                               UserFullName = User.UserFirstName + User.UserLastName,
                               BookTitle = book.BookName,
                               Request.RequestStatus
                           };

                grid.DataSource = list.OrderBy(x => x.RequestID).Skip(pageNumber * page).Take(pageNumber).ToList();
            }
        }
        public void GetAllRequestGrid(int pageNumber, int page, DataGridView grid)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var list = from Request in db.Requests
                           join User in db.Users on Request.UserID equals User.UserID
                           join book in db.Books on Request.BookID equals book.BookID
                           where !Request.RequestStatus.Equals(null)
                           select new
                           {
                               Request.RequestID,
                               Request.RequestDate,
                               UserFullName = User.UserFirstName.ToString() + " " + User.UserLastName.ToString(),
                               BookTitle = book.BookName,
                               RequestStatus = Request.RequestStatus.ToString()
                           };
                grid.DataSource = list.OrderBy(x => x.RequestID).Skip(2 * page).Take(2).ToList();
            }
        }
        public int GetRequestCount()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var list = from Request in db.Requests
                           join User in db.Users on Request.UserID equals User.UserID
                           join book in db.Books on Request.BookID equals book.BookID
                           where !Request.RequestStatus.Equals(null)
                           select new
                           {
                               Request.RequestID,
                               Request.RequestDate,
                               UserFullName = User.UserFirstName + User.UserLastName,
                               BookTitle = book.BookName,
                               Request.RequestStatus
                           };

                return list.ToList().Count();
            }
        }
        public void AcceptRequest(Request requestmodel)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                using (var dbRequestTransaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        requestmodel.RequestStatus = true;
                        db.Entry(requestmodel).State = EntityState.Modified;
                        Book list = (from book in db.Books
                                     where requestmodel.BookID.Equals(book.BookID)
                                     select book).First();
                        list.BookUserID = requestmodel.UserID;
                        db.Entry(requestmodel).State = EntityState.Modified;
                        db.SaveChanges();
                        dbRequestTransaction.Commit();
                        MessageBox.Show("Submitted Successfully");


                    }
                    catch (Exception)
                    {

                        dbRequestTransaction.Rollback();
                    }

                }
            }
        }
        public void RejectRequest(Request requestmodel)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                requestmodel.RequestStatus = false;
                db.Entry(requestmodel).State = EntityState.Modified;


                db.SaveChanges();
                MessageBox.Show("Submitted Successfully");


            }
        }
        public void AddORChangeRequest(Author authormodel)
        {
            using (LibraryEntities db = new LibraryEntities())
            {


                if (authormodel.AuthorID == 0)//Insert
                    db.Authors.Add(authormodel);
                else //Update
                    db.Entry(authormodel).State = EntityState.Modified;


                db.SaveChanges();

            }
        }
        public Request GetRequestRow(int RequestID)
        {
            Request RequestModel = new Request();
            using (LibraryEntities db = new LibraryEntities())
            {
                RequestModel = db.Requests.Where(x => x.RequestID == RequestID).FirstOrDefault();
                return RequestModel;
            }
        }
        public void SearchRequest(String Keyword, int page, int pageNumber, DataGridView grid)
        {
            try
            {
                using (LibraryEntities db = new LibraryEntities())
                {
                    var list = from Request in db.Requests
                               join User in db.Users on Request.UserID equals User.UserID
                               join book in db.Books on Request.BookID equals book.BookID
                               where (book.BookName.Contains(Keyword) || User.UserFirstName.Contains(Keyword) || User.UserLastName.Contains(Keyword))
                               select new
                               {
                                   Request.RequestID,
                                   Request.RequestDate,
                                   UserFullName = User.UserFirstName.ToString() + " " + User.UserLastName.ToString(),
                                   BookTitle = book.BookName,
                                   Request.RequestStatus
                               };

                    grid.DataSource = list.OrderBy(x => x.RequestID).Skip(2 * page).Take(2).ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void AddRequest(Request requestmodel)
        {
            using (LibraryEntities db = new LibraryEntities())
            {

                var entry = db.Entry(requestmodel);
                if (entry.State == EntityState.Detached)
                    db.Requests.Attach(requestmodel);

                db.Requests.Add(requestmodel);
                db.SaveChanges();

            }
        }
        #endregion


    }
}
