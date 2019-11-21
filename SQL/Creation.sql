DROP DATABASE IF EXISTS `Banking`;

CREATE DATABASE `Banking`;

USE `Banking`;

CREATE TABLE IF NOT EXISTS `Users` (
    `id` INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    `type` ENUM('Public','Entreprise','Admin') NOT NULL DEFAULT 'Public',
    `email` VARCHAR(50) NOT NULL,
    `password` VARCHAR(50) NOT NULL,
    `money` INT NOT NULL
);