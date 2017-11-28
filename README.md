# ADO.Net with SQLite

## Intro

SQLite is a sql-database that is stored in 1 file.
This makes it easy to include a database into a repo without needing a database-server.

We use the *Copy if newer*-property on the `mydb.db`-file in Visual Studio,
so it always gets copied to the same directory as the executable.

We use a basic connection string found on https://www.connectionstrings.com/sqlite/ :
`"Data Source=mydb.db;Version=3"`.

## SQLite installation and usage

Install the `sqlite3` CLI-program, e.g. with `choco install sqlite` on Windows.

Run `sqlite3 mydb.db` to open the database.

Interesting commands:

- `.schema`
- `.dump`
- `.databases`
- ...

## SQLite syntax

SQLite has a slightly different syntax than other SQL dialects.

https://www.tutorialspoint.com/sqlite/index.htm

# DotNet version and NuGet package

Although the SQLite ADO.Net package is built for the classic DotNet framework,
it seems to work for DotNet Core as well.
