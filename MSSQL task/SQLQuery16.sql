SELECT  Products.ProductName,Categories.CategoryName FROM Categories,Products,[MtoM_Categories-Products]
WHERE ([MtoM_Categories-Products].ProductID = Products.Id AND [MtoM_Categories-Products].CategoryID = Categories.Id)

UNION

SELECT  Products.ProductName,NULL FROM Products
WHERE NOT EXISTS(SELECT ProductID FROM [MtoM_Categories-Products] WHERE ProductID = Products.Id);
