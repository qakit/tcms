# pull necessary postgress image
cmd.exe /c docker pull postgres:13.1
# remove existing postgres container if any
cmd.exe /c docker container rm -f postgres
# up container with postgres
cmd.exe /c docker run --name postgres -p 5432:5432 -e POSTGRES_PASSWORD=1 -d postgres:13.1

Start-Sleep 3

# create tcms user with password
docker exec -t postgres /bin/bash -c "psql -U postgres -c \`"CREATE USER tcms WITH PASSWORD 'jw8s0F4' CREATEDB;\`"";
# create database schema
Set-Location './src'
cmd.exe /c dotnet ef database update

Set-Location '..'
#grant access to schema for previously created user
cmd.exe /c docker exec -t postgres /bin/bash -c "psql -U postgres -c \`"GRANT CREATE ON DATABASE tcms TO tcms;\`"";

