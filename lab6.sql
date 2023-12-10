CREATE TABLE Products (
    product_id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(255),
    price DECIMAL(10, 2),
    category_id INT,
    supplier_id INT
);

CREATE TABLE Categories (
    category_id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(255)
);

CREATE TABLE Suppliers (
    supplier_id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(255),
    contact_info NVARCHAR(255)
);

CREATE TABLE Orders (
    order_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    order_date DATE,
    status NVARCHAR(50)
);

CREATE TABLE Customers (
    customer_id INT IDENTITY(1,1) PRIMARY KEY,
    first_name NVARCHAR(50),
    last_name NVARCHAR(50),
    email NVARCHAR(100)
);

ALTER TABLE Products
ADD FOREIGN KEY (category_id) REFERENCES Categories(category_id);

ALTER TABLE Products
ADD FOREIGN KEY (supplier_id) REFERENCES Suppliers(supplier_id);

ALTER TABLE Orders
ADD FOREIGN KEY (customer_id) REFERENCES Customers(customer_id);

INSERT INTO Products (name, price, category_id, supplier_id)
VALUES ('Product 1', 10.99, 1, 1),   
       ('Product 2', 20.49, 2, 2),
       ('Product 3', 5.99, 1, 3);

INSERT INTO Categories (name)
VALUES ('Category 1'),
       ('Category 2');

INSERT INTO Suppliers (name, contact_info)
VALUES ('Supplier A', 'Contact Info A'),
       ('Supplier B', 'Contact Info B'),
       ('Supplier C', 'Contact Info C');

INSERT INTO Orders (customer_id, order_date, status)
VALUES (1, '2023-10-15', 'in processing'),
       (2, '2023-10-16', 'sent');

INSERT INTO Customers (first_name, last_name, email)
VALUES ('John', 'Doe', 'john.doe@example.com'),
       ('Jane', 'Smith', 'jane.smith@example.com');


CREATE PROCEDURE DeleteProduct
    @ProductName NVARCHAR(255)
AS
BEGIN
    DELETE FROM Products
    WHERE name = @ProductName;
END;



CREATE PROCEDURE AddProduct
    @ProductName NVARCHAR(255)
AS
BEGIN
    SELECT * 
    FROM Products
    WHERE name = @ProductName;

    DECLARE @CategoryID INT;
    SELECT TOP 1 @CategoryID = category_id
    FROM Categories
    ORDER BY NEWID(); 

    DECLARE @SupplierID INT;
    SELECT TOP 1 @SupplierID = supplier_id
    FROM Suppliers
    ORDER BY NEWID(); 

    DECLARE @Price DECIMAL(10, 2) = RAND() * 100;

    INSERT INTO Products (name, price, category_id, supplier_id)
    VALUES (@ProductName, @Price, @CategoryID, @SupplierID);
END;

SELECT * FROM Products

EXEC DeleteProduct @ProductName = 'new';
EXEC AddProduct @ProductName = 'new';