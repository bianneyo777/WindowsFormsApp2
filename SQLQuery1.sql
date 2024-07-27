/*creando base de datos */
create database Escuela
go
use Escuela 
go

create table Alumno (
id char (8) primary key,
nombre varchar(20)not null,
direccion varchar(50),
fecha_nacimiento datetime);

/*creando tabla asignatura */

create table Asignatura (
id_asig char (8) primary key,
nombre_asig varchar(20) not null);


/*creando tabla asignatura */

create table Profesor(
id_profe char(8) primary key,
nombre_pro varchar(20) not null,
direccion varchar(50),
nivel_academico varchar(20));

/*creando tabla de inscripcion con campos para llave para llave foranea */

create table Inscripcion(
id_ins char(8) primary key,
id char (8) not null,
id_asig char (8) not null,
id_profe char (8) not null,
fecha datetime,
constraint FK_Asignatura Foreign key(id_asig)references Asignatura(id_asig),
constraint FK_Profesor Foreign key(id_profe)references Profesor(id_profe),
constraint FK_Alumno Foreign key(id)references Alumno(id));


ALTER TABLE Inscripcion
ADD FOREIGN key (id_profe) references Profesor(id_profe);


use Escuela

insert into Asignatura values(
1,'matematica');

insert into Asignatura values(
2,'español');

insert into Alumno values(
1,'bianney','por ahi',12/05/1997);

insert into Alumno values(
2,'pepe','por ahi',12/05/1997);

insert into Profesor values(
1,'la maquina','por ahi','doctor');

insert into Inscripcion values(
1,1,1,1,12/05/2024);

insert into Inscripcion values(
2,2,2,1,12/05/2024);

select *from Asignatura;

select emp.id_ins,
dep.nombre,nombre_asig as Alumno 
from Inscripcion as emp
inner join Alumno as dep
on emp.id=dep.id
inner join Asignatura as e
on emp.id=e.id_asig

union

select emp.id_asig,
dep.nombre_asig as Asignatura 
from Inscripcion as emp
inner join Asignatura as dep
on emp.id_asig=dep.id_asig




