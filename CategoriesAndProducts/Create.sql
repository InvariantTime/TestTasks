create table Products (
	Id int primary key identity,
	Name nvarchar(50) unique,
);

go

create table Categories (
	Id int primary key identity,
	Name nvarchar(50) unique not null
);

go

create table ProductsCategories (
	ProductId int foreign key references Products(Id),
	CategoryId int foreign key references Categories(Id),
	primary key(ProductId, CategoryId)
);