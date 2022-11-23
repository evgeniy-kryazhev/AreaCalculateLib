/****** Script for SelectTopNRows command from SSMS  ******/
SELECT Product.Name, Category.Name
  FROM [test].[dbo].[Product]
  left join [CategoryProduct] as cp on cp.ProductId = Product.Id
  left join [Category] on [Category].Id = cp.CategoryId