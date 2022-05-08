CREATE TABLE Product(
	Id bigint IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name nvarchar(128) NOT NULL
);

CREATE TABLE Category(
	Id smallint IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name nvarchar(256) NOT NULL
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

   Select p.Name as ProductName, 
	      c.Name as CategoryName
     from Product p
left join ProductCategory pc on pc.ProductId = p.Id
left join Category c on pc.CategoryId = c.Id
 order by p.Name, c.Name
