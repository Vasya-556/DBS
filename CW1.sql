CREATE TABLE Products (
   Product_ID INT PRIMARY KEY IDENTITY(1,1),
   Name VARCHAR(255),
   Price INT,
   FK_Category INT
);

CREATE TABLE Categories (
    Category_ID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(50)
);

CREATE TABLE Sales (
    Sale_ID INT PRIMARY KEY IDENTITY(1,1),
    Quantity INT,
    Sale_Date DATE,
    FK_Product INT
);

ALTER TABLE Products
ADD CONSTRAINT FK_Category FOREIGN KEY (FK_Category)
REFERENCES Categories(Category_ID);

ALTER TABLE Sales
ADD CONSTRAINT FK_Product FOREIGN KEY (FK_Product)
REFERENCES Products(Product_ID);

INSERT INTO Products (Name, Price, FK_Category)
VALUES
    ('Smartphone', 500, 1),
    ('LED TV', 800, 1),
    ('Refrigerator', 700, 2);

INSERT INTO Categories (Name)
VALUES
    ('Electronics'),
    ('Home Appliances'),
    ('Lighting');

INSERT INTO Sales (Quantity, Sale_Date, FK_Product)
VALUES
    (2, '2023-10-04', 1),
    (1, '2023-10-04', 2),
    (3, '2023-10-04', 3);

SELECT * FROM Products
SELECT * FROM Sales
SELECT * FROM Categories

DROP TABLE Products
DROP TABLE Sales
DROP TABLE Categories