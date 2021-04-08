# Test Case Management System (yet another)

## Prerequisites

* install EF CLI `dotnet tool install --global dotnet-ef`

## Setup project

### Creating DB
* install PostgreSQL
* enter `psql -U postgres -c "CREATE USER tcms WITH PASSWORD 'jw8s0F4' CREATEDB;"` to create a new user
* `dotnet ef database update` to create a database schema

### Auth
* register yourself
* issue the `psql -U postgres -c "UPDATE public.\"AspNetUsers\" SET \"EmailConfirmed\" = true;" tcms` to "confirm" yourself

## Step by step guide

1. project is created with `dotnet new blazorserver ...` command (added auth stuff)
1. removed migrations, updated provider to Postgres and generated initial migration again
1. imported `dotnet ef dbcontext scaffold ...` Kiwi model and excluded it from build
1. moved server source code under src folder


## Misc
** `dotnet ef dbcontext scaffold "Host=localhost;Port=5433;Database=kiwi;Username=kiwi;Password=kiwi" Npgsql.EntityFrameworkCore.PostgreSQL -o Data/Kiwi`

## References

* https://docs.microsoft.com/ru-ru/ef/core/
* https://purple.telstra.com/blog/asp-net-core-identity-with-postgresql
