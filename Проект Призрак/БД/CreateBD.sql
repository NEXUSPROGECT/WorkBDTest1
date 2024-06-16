create database securities_transactions;
use securities_transactions;

CREATE TABLE OrderType (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Type VARCHAR(255) NOT NULL
);

-- Создание таблицы OrderVeriety
CREATE TABLE OrderVeriety (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Veriety VARCHAR(255) NOT NULL
);

-- Создание таблицы Currency
CREATE TABLE Currency (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    CurrencyFull VARCHAR(255) NOT NULL,
    CurrencyShort VARCHAR(10) NOT NULL
);

-- Создание таблицы Order
CREATE TABLE _order (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    OrderVerietyID INT,
    OrderTypeID INT,
    CurrencyID INT,
    Tiker VARCHAR(10) NOT NULL,
    Count INT NOT NULL,
    Type VARCHAR(50) NOT NULL,
    Number INT NOT NULL,
    Data DATETIME NOT NULL,
    Duration INT NOT NULL,
    FOREIGN KEY (OrderVerietyID) REFERENCES OrderVeriety(ID),
    FOREIGN KEY (OrderTypeID) REFERENCES OrderType(ID),
    FOREIGN KEY (CurrencyID) REFERENCES Currency(ID)
);
