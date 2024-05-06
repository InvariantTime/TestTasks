
select 
	pairs.ProductName,
	(select [Name] from Categories where Id = pairs.CategoryId) as CategoryName

from 
	(select 
		[Name] as ProductName,
		(select [CategoryId] from ProductsCategories where ProductId = Products.Id) as CategoryId
	from Products) pairs