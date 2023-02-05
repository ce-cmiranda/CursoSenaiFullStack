CREATE LOGIN dev
with PASSWORD = '1234';

create user dev for login dev;

grant select to dev;