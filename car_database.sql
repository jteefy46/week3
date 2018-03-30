#create database

create database Car;

#select the database
use Car;

#create a Sql table
create table CarInfo
(
	car_id int primary key AUTO_INCREMENT,
	car_make varchar(50), 
	car_model varchar(50),
	price decimal(10, 2),
	mpg int(3)
);

insert into CarInfo values('Audi', 'R8 Coupe', 176050.00, 22);
insert into CarInfo values('Lotus', 'Evora 400 Coupe', 103035.99, 24);
insert into CarInfo values('Ferrari', 'F12 Berlinetta', 323,745, 13);
insert into CarInfo values('Alfa Romeo', 'Stelvio SUV', 49000.00, 28);

#this is how we inspect the structure of our table
#describe CarInfo;
ALTER TABLE Car AUTO_INCREMENT = 1;
#check content
#select * from CarInfo where mpg >= 15;