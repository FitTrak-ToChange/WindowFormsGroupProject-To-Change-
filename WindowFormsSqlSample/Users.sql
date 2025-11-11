CREATE DATABASE Users;
USE Users;

SHOW DATABASES;

CREATE TABLE Users (
	UserID INT PRIMARY KEY AUTO_INCREMENT,
    Username VARCHAR(50) NOT NULL UNIQUE,
    UserPassword VARCHAR(255) NOT NULL
);

-- Test accounts
INSERT INTO Users (Username, UserPassword) VALUES ('admin', '1234');
INSERT INTO Users (Username, UserPassword) VALUES ('student', 'abcd');
INSERT INTO Users (Username, UserPassword) VALUES ('dangate', 'cute');
INSERT INTO Users (Username, UserPassword) VALUES ('billgwapokatalagakainiskangtaoka','joke');
INSERT INTO Users (Username, UserPassword) VALUES ('cutiecakes','joke');
INSERT INTO Users (Username, UserPassword) VALUES ('eriesgunagwapo','totoo');
INSERT INTO Users (Username, UserPassword) VALUES ('hahaha','rawr');



SELECT * FROM Users;


DROP TABLE Users;
DROP DATABASE Users;