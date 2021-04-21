# Test Case Management System (yet another)

## Prerequisites

* install Dotnet SDK 5.0+ from [official site](https://dotnet.microsoft.com/download/dotnet/5.0)

## Setup project

### Creating DB
* install PostgreSQL
* issue the following commands one by one:
** `psql -U postgres -c "CREATE USER tcms WITH PASSWORD 'jw8s0F4' CREATEDB;"`
** `psql -U postgres -c "CREATE DATABASE tcms;"`
** `psql -U postgres -c "GRANT CREATE ON DATABASE tcms TO tcms;"`
* run `dotnet ef database update --project src` to create a database schema

### Auth
* register yourself
* issue the `psql -U postgres -c "UPDATE public.\"AspNetUsers\" SET \"EmailConfirmed\" = true;" tcms` to "confirm" yourself

## Step by step guide

1. project is created with `dotnet new blazorserver ...` command (added auth stuff)
1. removed migrations, updated provider to Postgres and generated initial migration again
1. imported `dotnet ef dbcontext scaffold ...` Kiwi model and excluded it from build
1. moved server source code under src folder
1. defined a Products model (some properties are defined in ApplicationDbContext)
** created migration `dotnet ef migrations add Products`
** update database `dotnet ef database update`
1. added simplistic CRUD forms for products (Pages/Products). Using the article (from the refs) but skipped API/controller part, so the form communicates Db directly
1. changed the db communication to factory/shortlived context and all discovered data issues had gone


## Misc
** `dotnet ef dbcontext scaffold "Host=localhost;Port=5433;Database=kiwi;Username=kiwi;Password=kiwi" Npgsql.EntityFrameworkCore.PostgreSQL -o Data/Kiwi`

## References

* https://docs.microsoft.com/ru-ru/ef/core/
* https://purple.telstra.com/blog/asp-net-core-identity-with-postgresql
* https://docs.microsoft.com/ru-ru/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
* https://codewithmukesh.com/blog/blazor-crud-with-entity-framework-core/ - creating sample CRUD
* https://docs.microsoft.com/en-us/aspnet/core/blazor/blazor-server-ef-core?view=aspnetcore-5.0