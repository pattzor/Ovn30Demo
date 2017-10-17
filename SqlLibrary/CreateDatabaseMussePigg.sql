use master
go

drop database MussePigg
go

create database MussePigg
go

use MussePigg
go

create table Contact
(
   ID int identity(1,1) primary key not null,
   Firstname varchar(max) not null,
   Lastname varchar(max) not null,
   SSN varchar(13) unique not null
)
go

create table Address
(
   ID int identity(1,1) primary key not null,
   Type varchar(10) not null,
   Street varchar(max) not null,
   City varchar(max) not null
)
go

create table C2A
(
   ID int identity(1,1) primary key not null,
   CID int foreign key references Contact(ID),
   AID int foreign key references Address(ID)
)
go

create table [User]
(
  ID int identity(1,1) primary key not null, 
  Username varchar(24) unique not null,
  Password varchar(24) unique not null,
  Role varchar(12) not null,
  Email varchar(50) unique not null
)
go

create procedure AddContact
  @Firstname varchar(max),
  @Lastname varchar(max),
  @SSN varchar(13),
  @cid int output
as
begin
  insert into Contact (Firstname, Lastname, SSN) values (@Firstname, @Lastname, @SSN)

  set @cid = SCOPE_IDENTITY()
end
go

create procedure AddAddress
  @Type varchar(10),
  @Street varchar(max),
  @City varchar(max),
  @cid int,
  @aid int output
as
begin
  insert into Address (Type, Street, City) values (@Type, @Street, @City)

  set @aid = SCOPE_IDENTITY()

  insert into C2A (CID, AID) values (@cid, @aid)
end
go


-- Create some testdata
declare @cid int, @aid int
execute AddContact 'H�kan', 'Johansson', '19660302-1234', @cid output
execute AddAddress 'Home', 'Kvarnskogen', 'Sollentuna', @cid, @aid output
execute AddAddress 'Work', 'Borgarfjordsgatan 4', 'Kista', @cid, @aid output

execute AddContact 'Rebecca', 'Heden', '19870403-1244', @cid output
execute AddAddress 'Home', 'S�dergatan 2', 'S�der', @cid, @aid output
execute AddAddress 'Work', 'Borgarfjordsgatan 4', 'Kista', @cid, @aid output

execute AddContact 'Frida', 'Ericson', '19840503-1244', @cid output
execute AddAddress 'Home', 'Storgatan 3', '�rsta', @cid, @aid output
execute AddAddress 'Work', 'Borgarfjordsgatan 4', 'Kista', @cid, @aid output

execute AddContact 'Kalle', 'Kula', '19990101-1234', @cid output
execute AddAddress 'Home', 'Bj�rkv�gen 2', 'Norrk�ping', @cid, @aid output

execute AddContact 'Anna', 'Svensson', '19920712-1244', @cid output
execute AddAddress 'Home', 'Bj�rkv�gen 2', 'Norrk�ping', @cid, @aid output

execute AddContact 'Nisse', 'Hult', '19960101-1234', @cid output
execute AddAddress 'Home', 'Bokgatan 12', 'Nyk�ping', @cid, @aid output


insert into [User] (Username, Password, Role, Email) values ('Academy', 'Password1', 'Admin', 'admin@academy.se') 
insert into [User] (Username, Password, Role, Email) values ('Nisse', 'Password2', 'User', 'nisse@academy.se') 
insert into [User] (Username, Password, Role, Email) values ('Anna', 'Password3', 'User', 'anna@academy.se') 