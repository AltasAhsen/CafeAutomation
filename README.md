## Veritabanı Kurulumu

Projeyi çalıştırmadan önce PostgreSQL veritabanını kurmanız gerekmektedir. Aşağıdaki adımları izleyebilirsiniz:

1. PostgreSQL'i yükleyin ve çalıştırın.
2. Aşağıdaki komutları kullanarak veritabanını ve tabloları oluşturun:

   CREATE TABLE IF NOT EXISTS Staff(
	id VARCHAR(6) UNIQUE,
	position VARCHAR(20) NOT NULL,
	name VARCHAR(20) NOT NULL,
	surname VARCHAR(20) NOT NULL,
	password VARCHAR(20),
	gender VARCHAR(1),
	isLoggedIn VARCHAR(1) DEFAULT 'f',
	CONSTRAINT chk_position CHECK (position IN ('Owner', 'Barista', 'Cleaner', 'Cashier'))
);

INSERT INTO Staff(id, position, name, surname, password, gender, isLoggedIn)
VALUES ('OWN1', 'Owner', 'John', 'Doe', '12345','m', 'f'),
('BAR1', 'Barista', 'Mary', 'Star', 'abcde','f', 'f'),
('CLN1', 'Cleaner', 'Katy', 'Moon', 'a1b2c3','f', 'f'),
('CSH1', 'Cashier', 'David', 'Allen', 'password','m', 'f');

CREATE TABLE IF NOT EXISTS Customers(
	id SERIAL PRIMARY KEY,
	name VARCHAR(20) NOT NULL,
	surname VARCHAR(20) NOT NULL,
	email VARCHAR(50) NOT NULL UNIQUE,
    phone VARCHAR(14) NOT NULL UNIQUE,
    CHECK (email ~* '^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$'),
    CHECK (phone ~* '^[0-9]{10}$')
);

INSERT INTO Customers(name, surname, email, phone)
VALUES ('Robert', 'Brown', 'robert@mail.com', '5554443322');

CREATE TABLE IF NOT EXISTS Transactions (
    transaction_id SERIAL PRIMARY KEY,
	transaction_type VARCHAR(1),
    staff_id VARCHAR(6),
    cust_id INTEGER,
    transaction_date DATE,
    price DOUBLE PRECISION,
    FOREIGN KEY (staff_id) REFERENCES Staff(id),
    FOREIGN KEY (cust_id) REFERENCES Customers(id)
);

INSERT INTO Transactions(transaction_id, transaction_type, staff_id,
cust_id, transaction_date, price)
VALUES(1, 'i', NULL, NULL, '2024-12-23', 30.00);

CREATE TABLE IF NOT EXISTS Products (
    code SERIAL PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    amount INTEGER NOT NULL
);

INSERT INTO Products (name, price, amount)
VALUES ('Coffee Bean', 300, 0),
('Regular Milk', 25, 0),
('Soy Milk', 40, 0),
('Almond Milk', 50, 0);
