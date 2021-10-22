# ADO.Net with SQLite

## Intro

SQLite is a sql-database that is stored in 1 file.
This makes it easy to include a database into a repo without needing a database-server.

We use the *Copy if newer*-property on the `mydb.sqlite3`-file in Visual Studio,
so it always gets copied to the same directory as the executable.

We use a basic connection string `"Data Source=mydb.sqlite3"` to attach to the sqlite-database. Note it's also possible to include this connectionstring in `SqlConnection`'s constructor.

## SQLite installation and usage

The sqlite CLI-tool can be handy to explore exisiting databases
and is worthwhile to explore. https://sqlite.org/cli.html

Install the `sqlite3` CLI-program, e.g. 

- with `choco install sqlite` (Windows)
- by manually downloading the `sql-tools-...` at https://sqlite.org/download.html

Run `sqlite3 mydb.sqlite3` to open the database with the standard sqlite CLI-tool.

These are some interesting commands to try on this interactive CLI-tool:

- `.help` : shows all commands
- `.schema` : shows all available tables
- `.mode box` : output query-results in nicely formatted boxes
- `.mode csv` : output query-results as csv
- `.read file.sql` : reads and executes a file with sql-statements
- `.dump`
- `.databases`
- ...

## SQLite syntax

As with every SQL dialect, SQLite has a slightly different syntax.

https://www.tutorialspoint.com/sqlite/index.htm

# DotNet version and NuGet package

Update 2021-10-22:

- updated to `net5.0`
- the package name changed from `Sytem.Data.Sqlite` to `Microsoft.Data.Sqlite`
- the classes are now called `SqliteConnection`, ... in stead of `SQLiteConnection`, ...
- moved `.csproj` and `.sln` to same directory
- renamed `mydb.db` to `mydb.sqlite3`
