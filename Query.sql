CREATE TABLE Product(
	Id bigint IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name text NOT NULL
);

CREATE TABLE Category(
	Id smallint IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name text NOT NULL
);

CREATE TABLE ProductCategory(
	Id bigint IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ProductId smallint NOT NULL,
	CategoryId smallint NOT NULL
);

ALTER TABLE ProductCategory  
ADD CONSTRAINT FK_ProductCategory_Product_ProductId 
FOREIGN KEY(ProductId)
REFERENCES Product (Id);

ALTER TABLE ProductCategory
ADD CONSTRAINT FK_ProductCategory_Category_CategoryId 
FOREIGN KEY(CategoryId)
REFERENCES Category (Id);

SELECT p.Name AS ProductName, c.Name AS CategoryName
FROM Product p LEFT JOIN ProductCategory pc ON pc.ProductId = p.Id
LEFT JOIN Category c ON pc.CategoryId = c.Id
ORDER BY p.Name, c.Name
