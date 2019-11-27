DROP DATABASE IF EXISTS `Banking`;

CREATE DATABASE `Banking`;
USE `Banking`;

CREATE TABLE IF NOT EXISTS `Users` (
    `id` INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    `active` TINYINT(1) NOT NULL DEFAULT '1',
    `type` ENUM('Public','Entreprise','Admin') NOT NULL DEFAULT 'Public',
    `email` VARCHAR(50) NOT NULL UNIQUE,
    `password` VARCHAR(80) NOT NULL,
    `money` INT NOT NULL DEFAULT '0'
);