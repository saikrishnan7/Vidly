namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RepopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("TRUNCATE TABLE Movies");
            Sql("SET IDENTITY_INSERT Movies On");
            Sql("INSERT into Movies(Id, Name, GenreId, ReleaseDate, AvailableFrom, NumberInStock) values(1, 'Thalapathi', 3, '1/15/1991', '3/1/2017', 5)");
            Sql("INSERT into Movies(Id, Name, GenreId, ReleaseDate, AvailableFrom, NumberInStock) values(2, 'Panchathanthiram', 1, '10/15/2002', '3/3/2017', 15)");
            Sql("INSERT into Movies(Id, Name, GenreId, ReleaseDate, AvailableFrom, NumberInStock) values(3, 'VTV', 2, '1/1/2010', '3/11/2017', 25)");
            Sql("INSERT into Movies(Id, Name, GenreId, ReleaseDate, AvailableFrom, NumberInStock) values(4, 'America''s Dirty War', 4, '1/1/2011', '3/1/2017', 5)");
            Sql("INSERT into Movies(Id, Name, GenreId, ReleaseDate, AvailableFrom, NumberInStock) values(5, 'Janma Natchathiram', 6, '1/15/1991', '3/10/2017', 7)");
            Sql("INSERT into Movies(Id, Name, GenreId, ReleaseDate, AvailableFrom, NumberInStock) values(6, 'Hey Ram!', 7, '1/15/1999', '3/11/2017', 10)");
            Sql("INSERT into Movies(Id, Name, GenreId, ReleaseDate, AvailableFrom, NumberInStock) values(7, 'Kuruthi Punal', 5, '11/15/1995', '3/13/2017', 14)");
            Sql("SET IDENTITY_INSERT Movies Off");
        }
        
        public override void Down()
        {
        }
    }
}
