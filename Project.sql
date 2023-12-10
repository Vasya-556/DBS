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

UPDATE Users SET is_admin = 1 WHERE username = 'PetShop'

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