CREATE TABLE worker (
	id_w INT IDENTITY(1,1) PRIMARY KEY,
	Initial VARCHAR(50) NULL,
	position VARCHAR(50) NULL,
	fk_goods int null,
	fk_checks int null
)

CREATE TABLE checks (
	id_c INT IDENTITY(1,1) PRIMARY KEY,
	fSum float NULL,
	fdate date NULL,
	fk_goods int null,
	fk_worker int null
)

CREATE TABLE distributor (
	id_d INT IDENTITY(1,1) PRIMARY KEY,
	fName VARCHAR(50)  NULL,
	phone INT NULL,
	fk_goods int null
)

CREATE TABLE goods(
	id_g INT IDENTITY(1,1) PRIMARY KEY,
	fName VARCHAR(50)  NULL,
	fCount INT NULL,
	Price INT NULL,
	fk_checks int null,
	fk_distributor int null
)

INSERT INTO worker (Initial, position, fk_goods, fk_checks)
VALUES
    ('John', 'Manager', 4, 1),
    ('Alice', 'Clerk', 3, 3),
    ('Bob', 'Technician', 5, 4),
    ('Eva', 'Supervisor', 2, 2),
    ('Mike', 'Assistant', 1, 5);

INSERT INTO checks (fSum, fdate, fk_goods, fk_worker)
VALUES
    (100.50, '2023-09-26', 5, 1),
    (75.25, '2023-09-25', 1, 2),
    (120.75, '2023-09-24', 4, 3),
    (50.00, '2023-09-23', 2, 5),
    (200.00, '2023-09-22', 3, 4);

INSERT INTO distributor (fName, phone, fk_goods)
VALUES
    ('Distributor A', 879395, 5),
    ('Distributor B', 078235, 2),
    ('Distributor C', 848351, 3),
    ('Distributor D', 615691, 4),
    ('Distributor E', 055608, 1);

INSERT INTO goods (fName, fCount, Price, fk_checks, fk_distributor)
VALUES
    ('Product 1', 50, 20, 5, 3),
    ('Product 2', 50, 10, 1, 1),
    ('Product 3', 50, 15, 2, 3),
    ('Product 4', 100, 25, 3, 4),
    ('Product 5', 100, 30, 4, 2);

SELECT * FROM goods
SELECT * FROM worker
SELECT * FROM distributor
SELECT * FROM checks