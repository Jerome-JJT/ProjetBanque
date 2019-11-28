/* Délimiteur changé en ; */
/* Connexion à 127.0.0.1 pour MariaDB or MySQL (TCP/IP), nom d'utilisateur root, mot de passe : Yes… */
SELECT CONNECTION_ID();
/* Connecté. ID du processus : 10 */
/* Jeu de caractères : utf8mb4 */
SHOW STATUS;
SELECT NOW();
SHOW VARIABLES;
SHOW DATABASES;
SHOW OPEN TABLES FROM banking WHERE `in_use`!=0;
USE `banking`;
/* Ouverture de la session « Unnamed » */
SELECT `DEFAULT_COLLATION_NAME` FROM `information_schema`.`SCHEMATA` WHERE `SCHEMA_NAME`='banking';
SHOW TABLE STATUS FROM `banking`;
SHOW FUNCTION STATUS WHERE `Db`='banking';
SHOW PROCEDURE STATUS WHERE `Db`='banking';
SHOW TRIGGERS FROM `banking`;
SELECT `DEFAULT_COLLATION_NAME` FROM `information_schema`.`SCHEMATA` WHERE `SCHEMA_NAME`='information_schema';
SHOW TABLE STATUS FROM `information_schema`;
SHOW FUNCTION STATUS WHERE `Db`='information_schema';
SHOW PROCEDURE STATUS WHERE `Db`='information_schema';
SHOW TRIGGERS FROM `information_schema`;
SHOW EVENTS FROM `information_schema`;
SELECT *, EVENT_SCHEMA AS `Db`, EVENT_NAME AS `Name` FROM information_schema.`EVENTS` WHERE `EVENT_SCHEMA`='banking';
/* Loading file "P:\ProjetBanque\SQL\Creation.sql" (418 B) into query tab #1 ... */
/* Loading file "\\sc-file-sv06\Perso\Eleve\sc\INFO\NC\Keanu.TROSSET\ProjetBanque\SQL\Creation.sql" (418 B) into query tab #2 ... */
/* Connexion à 127.0.0.1 pour MariaDB or MySQL (TCP/IP), nom d'utilisateur root, mot de passe : No… */
/* Access denied for user 'root'@'localhost' (using password: NO) */
/* Connexion à 127.0.0.1 pour MariaDB or MySQL (TCP/IP), nom d'utilisateur BanqueConnector, mot de passe : Yes… */
/* Access denied for user 'BanqueConnector'@'localhost' (using password: YES) */
SHOW VARIABLES LIKE 'skip_name_resolve';
FLUSH PRIVILEGES;
SHOW COLUMNS FROM `mysql`.`user`;
SELECT `user`, `host`, authentication_string AS `password` FROM `mysql`.`user`;
CREATE USER 'BanqueConnector'@'localhost' IDENTIFIED BY '12345678';
GRANT SELECT, UPDATE, INSERT  ON *.* TO 'BanqueConnector'@'localhost';
FLUSH PRIVILEGES;
SHOW GRANTS FOR 'BanqueConnector'@'localhost';
REVOKE SELECT, INSERT, UPDATE  ON *.* FROM 'BanqueConnector'@'localhost';
GRANT SELECT, INSERT, UPDATE  ON `banking`.* TO 'BanqueConnector'@'localhost';
FLUSH PRIVILEGES;
SHOW GRANTS FOR 'BanqueConnector'@'localhost';
SET PASSWORD FOR 'BanqueConnector'@'localhost' = '12345678';
RENAME USER 'BanqueConnector'@'localhost' TO 'BankConnector'@'localhost';
FLUSH PRIVILEGES;
SHOW GRANTS FOR 'BankConnector'@'localhost';
SHOW CREATE TABLE `banking`.`users`;
SHOW COLLATION;
SHOW ENGINES;
SELECT * FROM `banking`.`users` LIMIT 1000;
SHOW CREATE TABLE `banking`.`users`;
SELECT * FROM `banking`.`users` LIMIT 1000;
SHOW CREATE TABLE `banking`.`users`;
DELETE FROM `banking`.`users` WHERE  `id`=1;
SELECT * FROM `banking`.`users` LIMIT 1000;
SHOW CREATE TABLE `banking`.`users`;
DELETE FROM `banking`.`users` WHERE  `id`=2;
SHOW VARIABLES LIKE 'skip_name_resolve';
FLUSH PRIVILEGES;
SHOW COLUMNS FROM `mysql`.`user`;
SELECT `user`, `host`, authentication_string AS `password` FROM `mysql`.`user`;
SHOW GRANTS FOR 'BankConnector'@'localhost';
DROP USER 'BankConnector'@'localhost';
FLUSH PRIVILEGES;
CREATE USER 'BankConnector'@'localhost' IDENTIFIED BY '12345678';
GRANT USAGE ON *.* TO 'BankConnector'@'localhost';
GRANT SELECT, INSERT, UPDATE  ON `banking`.* TO 'BankConnector'@'localhost';
FLUSH PRIVILEGES;
SHOW GRANTS FOR 'BankConnector'@'localhost';