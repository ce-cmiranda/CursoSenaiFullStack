select * from users;
/*
ALTER TABLE users
DROP COLUMN password;

ALTER TABLE users
ADD password varbinary(max) NOT NULL;
*/


select * from characters;

select * from classes;

select * from classes_skills;

select * from skills;

-- Cadastra usuarios
insert into users (user_name,email, password) values ('Aphonso', 'Aphonso@teste.com',PWDENCRYPT('12345'))
insert into users (user_name,email, password) values ('Danox', 'cami@teste.com',PWDENCRYPT('12345'))

select * from users;

-- Atualiza Dados de email do usuario Danox 
UPDATE users SET email = 'deubug@teste.com' WHERE user_id = 8
--delete from users;

--Cadastra Classes
insert into classes (class_name) values ('B�rbaro'),('Monge')
select * from classes


--Cadastra habilidades
insert into skills (skill_name) values ('Lan�a Mortal'), ('Escudo Supremo'), ('Recuperar vida')

select * from skills;

--Cadastra habilidades nas classes
insert into classes_skills (skill_id, class_id) VALUES (1,1), (2,1), (3, 2), (2, 2);

select * from classes_skills
--delete from classes_skills;

-- Conferencia se a associacao estava correta
select * from classes_skills
left join classes on (classes.class_id = classes_skills.class_id);
left join skills on (skills.skill_id = classes_skills.skill_id);


-- Cadastra personagens
insert into characters (character_name,user_id,class_id) values ('BitBug',8,2), ('DeuBug',7,1);

-- Conferencia se a associacao estava correta
select users.user_name, characters.character_name, classes.class_name, skills.skill_name from users
left join characters on (users.user_id = characters.user_id)
left join classes on (characters.class_id = classes.class_id)
left join classes_skills on (classes.class_id = classes_skills.class_id)
left join skills on (skills.skill_id = classes_skills.skill_id)