CREATE USER 'BankConnector'@'localhost' IDENTIFIED BY '12345678';
GRANT USAGE ON *.* TO 'BankConnector'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE  ON `banking`.* TO 'BankConnector'@'localhost';