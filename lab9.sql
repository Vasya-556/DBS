CREATE TABLE Categories (
    category_id INT IDENTITY(1,1) PRIMARY KEY,
    category_name VARCHAR(255) NOT NULL,
    parent_category_id INT,
    FOREIGN KEY (parent_category_id) REFERENCES Categories(category_id)
);

CREATE TABLE Products (
    product_id INT IDENTITY(1,1) PRIMARY KEY,
    product_name VARCHAR(255) UNIQUE NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    category_id INT NOT NULL,
    is_ordered BIT DEFAULT 0,
    product_photo VARBINARY(MAX),
    FOREIGN KEY (category_id) REFERENCES Categories(category_id),
);

CREATE TABLE Users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(255) UNIQUE NOT NULL,
    password VARBINARY(64) NOT NULL, 
    email VARCHAR(255) NOT NULL,
    address VARCHAR(255) NOT NULL,
    is_admin BIT NOT NULL
);

CREATE TABLE Orders (
    order_id INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT NOT NULL,
    product_id INT NOT NULL,
    order_date DATETIME NOT NULL,
    FOREIGN KEY (user_id) REFERENCES Users(id),
    FOREIGN KEY (product_id) REFERENCES Products(product_id)
);

INSERT INTO Categories (category_name)
VALUES
    ('Animals'),
    ('Food'),
    ('Hygiene Products'),
    ('Medicine and Vitamins'),
    ('Other');

INSERT INTO Categories (category_name, parent_category_id)
VALUES
    ('Mammals', 1),
    ('Rodents', 1),
    ('Reptiles', 1),
    ('Birds', 1),
    ('Fish', 1),
    ('Dry Food', 2),
    ('Wet Food', 2),
    ('Bird Food', 2),
    ('Shampoo', 3),
    ('Litter', 3),
    ('Tray', 3),
    ('Flea Medication', 4),
    ('Worm Medication', 4),
    ('Wound Care', 4),
    ('Accessories', 5),
    ('Toys', 5);

SELECT * FROM Categories
SELECT * FROM Products

SELECT * FROM Users
SELECT * FROM Orders

UPDATE Users set is_admin = 1 where username = 'PetShop';

INSERT INTO Products (product_name, price, category_id)
VALUES 
    ('Persian Kitten', 249.99, 6),
    ('Dachshund Puppy', 549.99, 6),
    ('Golden Retriever Puppy', 599.99, 6),
    ('Guinea Pig', 125, 7),
    ('Hamster', 50, 7),
    ('Leopard Gecko', 699.99, 8),
    ('Red-Eared Slider Turtle', 999.99, 8),
    ('Iguana', 749.99, 8),
    ('Python', 649.99, 8),
    ('Cockatiel', 399.99, 9),
    ('Budgerigar', 399.99, 9),
    ('Canary', 399.99, 9),
    ('Angelfish', 120, 10),
    ('Goldfish', 250, 10);

INSERT INTO Products (product_name, price, category_id)
VALUES
    ('Purina Cat Chow', 10.99, 11),
    ('Royal Canin Dog Food', 25.99, 11),
    ('Hill''s Science Diet Cat Food', 15.99, 11),
    ('Iams Dry Dog Food', 19.99, 11),
    ('Fancy Feast Wet Cat Food', 0.99, 12),
    ('Hill''s Science Diet Wet Dog Food', 2.49, 12),
    ('Nutro Wet Cat Food', 1.99, 12),
    ('Blue Buffalo Wet Dog Food', 2.99, 12),
    ('Kaytee Wild Bird Food', 8.99, 13),
    ('Wagner''s Deluxe Blend Bird Food', 12.99, 13);

INSERT INTO Products (product_name, price, category_id)
VALUES
    ('Dog Shampoo', 7.99, 14),
    ('Cat Shampoo', 7.99, 14),
    ('Clumping Cat Litter', 5.49, 15),
    ('Non-Clumping Cat Litter', 4.99, 15),
    ('Cat Litter Box', 12.99, 16),
    ('Dog Litter Box', 14.99, 16);

INSERT INTO Products (product_name, price, category_id)
VALUES
    ('Flea Collar', 12.99, 17),
    ('Flea Spray', 9.99, 17),
    ('Worm Tablets', 7.49, 18),
    ('Worm Liquid Medication', 8.99, 18),
    ('Wound Ointment', 6.99, 19),
    ('First Aid Kit', 15.99, 19);

INSERT INTO Products (product_name, price, category_id)
VALUES
    ('Pet Leash', 11.99, 20),
    ('Cat Collar', 4.99, 20),
    ('Fish Tank Decorations', 8.99, 20),
    ('Bird Cage Accessories', 7.49, 20),
    ('Rubber Chew Toy', 3.99, 21),
    ('Interactive Cat Toy', 6.99, 21),
    ('Squeaky Dog Toy', 5.49, 21),
    ('Feather Wand Toy', 2.99, 21);