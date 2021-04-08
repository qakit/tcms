# Random notes

## Prerequisites

* install EF CLI `dotnet tool install --global dotnet-ef`

## Creating DB
* install PostgreSQL
* enter `psql -U postgres -c "CREATE USER tcms WITH PASSWORD 'jw8s0F4' CREATEDB;"` to create a new user
* `dotnet ef database update` to create a database schema

## Auth
* register yourself
* issue the `psql -U postgres -c "UPDATE public.\"AspNetUsers\" SET \"EmailConfirmed\" = true;" tcms` to "confirm" yourself

## References

* https://docs.microsoft.com/ru-ru/ef/core/
* https://purple.telstra.com/blog/asp-net-core-identity-with-postgresql
