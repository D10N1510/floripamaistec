--create database PIZZARIAS09

create table Estado(
id int Primary Key,
nome varchar(20)
);

create table Sabores(
id int identity primary key not null,
sabor varchar(20)
);

create table Massas(
id int identity primary key not null,
nome varchar(20)
);

create table Bordas(
id int identity primary key not null,
nome varchar(20),
);

create table Pizza(
id int identity primary key not null,
id_massas int not null,
id_bordas int not null,
CONSTRAINT FK_massas FOREIGN KEY (id_massas) REFERENCES Massas(id),
CONSTRAINT FK_borda FOREIGN KEY (id_bordas) REFERENCES Bordas(id)
);

create table PizzaSabores(
id int identity primary key not null,
id_pizzas int not null,
id_sabores int not null,
CONSTRAINT FK_pizzas FOREIGN KEY (id_pizzas) REFERENCES Pizza(id),
CONSTRAINT FK_sabor FOREIGN KEY (id_sabores) REFERENCES Sabores(id)
);

create table Pedidos(
id int identity primary key not null,
id_status int not null,
id_pizza int not null,
CONSTRAINT FK_pizza FOREIGN KEY (id_pizza) REFERENCES Pizza(id),
CONSTRAINT FK_status FOREIGN KEY (id_status) REFERENCES Estado(id)
);

