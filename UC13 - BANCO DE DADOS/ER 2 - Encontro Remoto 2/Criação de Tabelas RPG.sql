CREATE DATABASE RPG;
GO

USE RPG;
GO

CREATE TABLE users (
    user_id INT PRIMARY KEY IDENTITY,
    user_name VARCHAR (50) unique NOT NULL,
    email VARCHAR (50) unique NOT NULL,
	password VARCHAR (50) NOT NULL,
);

--drop table users;

CREATE TABLE classes (
    class_id INT PRIMARY KEY IDENTITY,
    class_name VARCHAR (50) unique NOT NULL,
);

--drop table classes;

CREATE TABLE skills (
    skill_id INT PRIMARY KEY IDENTITY,
    skill_name VARCHAR (50) unique NOT NULL,
);

--drop table skill;

CREATE TABLE characters (
    character_id INT PRIMARY KEY IDENTITY,
    character_name VARCHAR (50) unique NOT NULL,
	user_id INT NOT NULL,
    FOREIGN KEY (user_id) REFERENCES users (user_id),
	class_id INT NOT NULL,
    FOREIGN KEY (class_id) REFERENCES classes (class_id)
);

-- drop table characters;

CREATE TABLE classes_skills (
    class_skill_id INT PRIMARY KEY IDENTITY,
	skill_id INT NOT NULL,
    FOREIGN KEY (skill_id) REFERENCES skills (skill_id),
	class_id INT NOT NULL,
    FOREIGN KEY (class_id) REFERENCES classes (class_id)
);

--drop table classes skills