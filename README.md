# WebAPI
Testing API

# Создания базы данных с Sql Server 

create table Users(

	id int NOT NULL PRIMARY KEY,
	name Varchar(200),
	email Varchar(50),
	phone varchar(50)

	);
  
  insert into users
	values(1, 'Arman', 'arman@gmail.com', '+77073456512');
	
	insert into users
	values(2, 'Baglan', 'Baglan@mail.com', '+77074561234');
	
	insert into users
	values(3, 'Nuris', 'nur@gmail.com', '+77011522112');
	
	insert into users
	values(4, 'Erkebulan', 'erke@mail.com', '+77055644565');
	
	insert into users
	values(5, 'Jandaylet', 'janday@gmail.com', '+77024511242');
  
  
 select * from users;
