namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreAndMovies : DbMigration
    {
        public override void Up()
        {
            PopulateGenres();
            PopulateMovies();

        }

        public override void Down()
        {
        }
        private void PopulateGenres()
        {
            Sql("INSERT into Genres(Id, Name) values(1, 'Comedy')");
            Sql("INSERT into Genres(Id, Name) values(2, 'Romance')");
            Sql("INSERT into Genres(Id, Name) values(3, 'Action')");
            Sql("INSERT into Genres(Id, Name) values(4, 'Documentary')");
            Sql("INSERT into Genres(Id, Name) values(5, 'Thriller')");
            Sql("INSERT into Genres(Id, Name) values(6, 'Horror')");
            Sql("INSERT into Genres(Id, Name) values(7, 'Drama')");
        }
        private void PopulateMovies()
        {
            Sql("INSERT into Movies(Name, GenreId, ReleaseDate, AvailableFrom, NumberInStock) values('Thalapathi', 3, '1/15/1991', '3/1/2017', 5)");
            Sql("INSERT into Movies(Name, GenreId, ReleaseDate, AvailableFrom, NumberInStock) values('Panchathanthiram', 1, '10/15/2002', '3/3/2017', 15)");
            Sql("INSERT into Movies(Name, GenreId, ReleaseDate, AvailableFrom, NumberInStock) values('VTV', 2, '1/1/2010', '3/11/2017', 25)");
            Sql("INSERT into Movies(Name, GenreId, ReleaseDate, AvailableFrom, NumberInStock) values('America''s Dirty War', 4, '1/1/2011', '3/1/2017', 5)");
            Sql("INSERT into Movies(Name, GenreId, ReleaseDate, AvailableFrom, NumberInStock) values('Janma Natchathiram', 6, '1/15/1991', '3/10/2017', 7)");
            Sql("INSERT into Movies(Name, GenreId, ReleaseDate, AvailableFrom, NumberInStock) values('Hey Ram!', 7, '1/15/1999', '3/11/2017', 10)");
            Sql("INSERT into Movies(Name, GenreId, ReleaseDate, AvailableFrom, NumberInStock) values('Kuruthi Punal', 5, '11/15/1995', '3/13/2017', 14)");
        }
    }
}
