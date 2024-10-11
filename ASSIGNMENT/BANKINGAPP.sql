CREATE TABLE CustomerTable(
  customer_id INT PRIMARY KEY NOT NULL,
  name VARCHAR(50) NOT NULL,
  phone_no VARCHAR(15) NOT NULL UNIQUE,
  email VARCHAR(50) NOT NULL UNIQUE,
  address VARCHAR(50) NOT NULL,
  Date_of_creation DATETIME DEFAULT GETDATE()
);

INSERT INTO CustomerTable (customer_id, name, phone_no, email, address)
VALUES (1, 'John Doe', '1234567890', 'john.doe@example.com', '123 Main St, City');

INSERT INTO CustomerTable (customer_id, name, phone_no, email, address)
VALUES (2, 'Jane Smith', '0987654321', 'jane.smith@example.com', '456 Oak Ave, Town');

INSERT INTO CustomerTable (customer_id, name, phone_no, email, address)
VALUES (3, 'Alice Johnson', '1122334455', 'alice.johnson@example.com', '789 Pine Blvd, Village');

SELECT * FROM CustomerTable;

CREATE TABLE AccountTable(
  account_id BIGINT PRIMARY KEY NOT NULL,
  customer_id INT NOT NULL,
  account_no VARCHAR(50) NOT NULL UNIQUE,
  account_type VARCHAR(50) NOT NULL,
  balance DECIMAL(15, 2),
  status VARCHAR(50) DEFAULT 'ACTIVE',
  Date_of_creation DATETIME DEFAULT GETDATE(),
  CONSTRAINT FK_Account_Customer FOREIGN KEY (customer_id) REFERENCES CustomerTable(customer_id)
);

INSERT INTO AccountTable (account_id, customer_id, account_no, account_type, balance)
VALUES (1, 1, 'ACC1001', 'Savings', 1000.00);

INSERT INTO AccountTable (account_id, customer_id, account_no, account_type, balance)
VALUES (2, 2, 'ACC1002', 'Checking', 1500.50);

INSERT INTO AccountTable (account_id, customer_id, account_no, account_type, balance)
VALUES (3, 3, 'ACC1003', 'Savings', 2000.75);

SELECT * FROM AccountTable;

CREATE TABLE TransactionTable(
  transaction_id BIGINT PRIMARY KEY NOT NULL,
  account_id BIGINT NOT NULL,
  transaction_type VARCHAR(50) NOT NULL,
  amount DECIMAL(15, 2),
  transaction_date DATETIME DEFAULT GETDATE(),
  statement VARCHAR(50) NOT NULL,
  CONSTRAINT FK_Transaction_Account FOREIGN KEY (account_id) REFERENCES AccountTable(account_id)
);

INSERT INTO TransactionTable (transaction_id, account_id, transaction_type, amount, statement)
VALUES (1, 1, 'Deposit', 500.00, 'Initial deposit');

INSERT INTO TransactionTable (transaction_id, account_id, transaction_type, amount, statement)
VALUES (2, 2, 'Withdrawal', 200.00, 'ATM withdrawal');

INSERT INTO TransactionTable (transaction_id, account_id, transaction_type, amount, statement)
VALUES (3, 3, 'Deposit', 1000.00, 'Monthly salary deposit');

SELECT * FROM TransactionTable;

CREATE TABLE TransferTable(
  transfer_id BIGINT PRIMARY KEY NOT NULL,
  from_account_id BIGINT NOT NULL,
  to_account_id BIGINT NOT NULL,
  amount DECIMAL(15, 2),
  transfer_date DATETIME DEFAULT GETDATE(),
  statement VARCHAR(50) NOT NULL,
  CONSTRAINT FK_Transfer_FromAccount FOREIGN KEY (from_account_id) REFERENCES AccountTable(account_id),
  CONSTRAINT FK_Transfer_ToAccount FOREIGN KEY (to_account_id) REFERENCES AccountTable(account_id)
);

INSERT INTO TransferTable (transfer_id, from_account_id, to_account_id, amount, statement)
VALUES (1, 1, 2, 300.00, 'Transfer to checking account');

INSERT INTO TransferTable (transfer_id, from_account_id, to_account_id, amount, statement)
VALUES (2, 2, 3, 150.50, 'Transfer to savings account');

INSERT INTO TransferTable (transfer_id, from_account_id, to_account_id, amount, statement)
VALUES (3, 3, 1, 500.00, 'Transfer back to primary account');

SELECT * FROM TransferTable;

INSERT INTO AccountTable (account_id, customer_id, account_no, account_type, balance)
VALUES (4, 1, 'ACC1004', 'Checking', 800.00);


UPDATE CustomerTable SET phone_no ='8304968619' WHERE customer_id = 2;

SELECT *FROM CustomerTable; 
 --DEPOSIT TO ACCOUNT
UPDATE AccountTable SET balance = balance +1500 WHERE account_id =1;
SELECT account_id,balance FROM AccountTable WHERE account_id =1;
-- WITHDRAW FROM account_id
UPDATE AccountTable SET balance = balance -500 WHERE account_id =2;
SELECT account_id,balance FROM AccountTable WHERE account_id =2;

UPDATE TransferTable SET from_account_id = 2 ,amount = amount +3000 WHERE to_account_id =3;
SELECT balance FROM AccountTable WHERE account_id=3;

-- Deposit into an Account (Add 500 to the balance)
UPDATE AccountTable
SET balance = balance + 500 
WHERE account_id = 1;

-- Record the Deposit Transaction
INSERT INTO TransactionTable (account_id, transaction_type, amount) 
VALUES (1, 'Deposit', 500);


-- Withdraw from an Account (Subtract 200 from the balance)
UPDATE AccountTable
SET balance = balance - 200 
WHERE account_id = 2;

-- Record the Withdrawal Transaction
INSERT INTO TransactionTable (account_id, transaction_type, amount) 
VALUES (2, 'Withdraw', 200);



-- Deduct from Sender Account
UPDATE AccountTable
SET balance = balance - 300 
WHERE account_id = 1;

-- Add to Receiver Account
UPDATE AccountTable
SET balance = balance + 300 
WHERE account_id = 3;

-- Record the Transfer in the Transfers Table
INSERT INTO TransferTable (from_account_id, to_account_id, amount) 
VALUES (1, 3, 300);
SELECT * FROM TransferTable
WHERE transfer_id = 1;