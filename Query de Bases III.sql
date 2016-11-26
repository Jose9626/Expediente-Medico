Drop database expediente_medico;
Create database expediente_medico;
USE expediente_medico;


CREATE TABLE Personas(
	cedula_persona numeric(9,0) NOT NULL,
    nombre_pila varchar(45) NOT NULL,
    apellido1 varchar(20) NOT NULL,
    apellido2 varchar(20) NULL,
    fecha_nacimiento date NOT NULL,
    tipo_sangre varchar(3) NOT NULL,
    nacionalidad varchar(20) NOT NULL,
    password varchar(100) NOT NULL,
    PRIMARY KEY(cedula_persona),
    check (cedula_persona>0 && nombre_pila != '' && apellido1 != '' && apellido2 != '' && 
		(Date_Diff(CUR_Date(),fecha_nacimiento)>-1) && tipo_sangre != '' && nacionalidad != '' && 
        password != '')
    );

DELIMITER $$
create trigger encrypt before insert on Personas
	for each row
		BEGIN
			set New.password = MD5(New.password);
        END$$
	
DELIMITER ;

create table Tipos_Centros(tipo_centro varchar(20) primary key check (tipo_centro != ''));

create table Centro_Atencion(
	codigo_centro int NOT NULL,
	nombre varchar(30) NOT NULL,
    provincia_ubicacion varchar(10) NOT NULL,
    canton_ubicacion varchar(30) NOT NULL,
    distrito_ubicacion varchar(20) NOT NULL,
	ubicacion_especifica varchar(120) NOT NULL,
    capacidad_max_pacientes int NOT NULL,
    tipo_centro varchar(20) NOT NULL,
    telefono numeric(8,0) NOT NULL,
    primary key(codigo_centro),
    foreign key (tipo_centro) references Tipos_Centros(tipo_centro),
    check(codigo_centro>1 && nombre != '' && provincia_ubicacion != '' && canton_ubicacion != '' && 
    distrito_ubicacion != '' && ubicacion_especifica!= '' && capacidad_max_pacientes>0 && 
    tipo_centro != '' && telefono > 0 && (telefono like 6 || telefono like 7 || telefono like 8)
    )
	);
   
create table Funcionarios (
	cedula_persona numeric(9,0) primary key,
    codigo_adicional int NULL,
    codigo_centro int NOT NULL,
    area_labora varchar(30) NOT NULL,
    fecha_ingreso_institucion date NOT NULL,
    rol varchar(40) NOT NULL,
    foreign key (cedula_persona) references Personas(cedula_persona),
    check (cedula_persona > 0 && codigo_adicional > 0 && codigo_centro > 0 && area_labora != '' &&
    Date_Diff(CUR_Date(),fecha_ingreso_institucion)>-1)
	);


create table Catalogo_Diagnosticos(
	nombre_diagnostico varchar(20),
    codigo_tratamiento int,
    primary key(nombre_diagnostico,codigo_tratamiento),
    check(nombre_diagnostico != '' && codigo_tratamiento>0)
);

create table Tipos_Tratamiento(tipo_tratamiento varchar(20) primary key check(tipo_tratamiento != ''));

create table Formas_Aplicacion(forma_aplicacion varchar(20) primary key check(forma_aplicacion != ''));

create table Catalogo_de_Tratamientos(
	codigo_tratamiento int primary key,
    nombre_tratamiento varchar(20) NOT NULL,
    dosis int null,
    potencia_dosis int null,
    frecuencia_dosis varchar(60) null,
    tipo_tratamiento varchar(20) null,
    forma_aplicacion varchar(30) null
    check (codigo_tratamiento > 0 && nombre_tratamiento != '' && dosis > 0 && potencia_dosis >0 && 
    frecuencia_dosis != '')
    );

create table Telefonos(
	telefono numeric(8,0) primary key,
    cedula numeric(9,0) NOT NULL);

create table Paises(
	codigo_pais char(3) primary key,
    nombre_pais varchar(40) NOT NULL);
    
create table Diagnosticos(
	codigo_cita int primary key,
    codigo_tratamiento char(10) NOT NULL,
    nombre_diagnostico varchar(30) NOT NULL,
    nivel varchar(10) NOT NULL,
    observaciones varchar(120) null);
    
create table Citas(
	codigo_cita int primary key,
    cedula_paciente numeric (9,0) NOT NULL,
    codigo_centro int NOT NULL, 
    area_atencion varchar(30) NOT NULL,
    fecho_solicitada date NOT NULL, 
    hora_solicitud date NOT NULL,
	observacion varchar(120) NOT NULL,
    estado varchar(40) NOT NULL
    );
    
create table Bitacora_Citas(
	Codigo_cita int,
    estado varchar(20) NOT NULL,
    fecha_modificacion date NOT NULL, 
    hora_modificacion date NOT NULL,
    primary key (Codigo_cita,estado));
    
create table Tipos_Areas(nombre_area varchar(25) primary key);

create table Area_por_Centro(
	codigo_centro int,
    nombre_area varchar(15),
    capacidad int NOT NULL,
	primary key (codigo_centro,nombre_area)
    );
    
create table Tipos_Roles(rol varchar(15) primary key);



insert into Tipos_Roles values ('bhjaXSBHJASD');

update Tipos_Roles set rol = 'CHAOS' where (rol  = 'bhjaXSBHJASD');

delete from Tipos_Roles where(rol = 'CHAOS');

insert into Personas values(1,'sa','das','g','2001-08-08','A+','dasc','sahjhj');

insert into Personas values(6,'sa','das','','2001-08-08','A+','dasc','sahjhj');

insert into Personas values(12,'sa','','','2001-08-08','A+','dasc','sahjhj');

insert into Personas values(-1,'sa','','','2001-08-08','A+','dasc','sahjhj');

insert into Personas values(10,'sa','das','g','2001-08-08','A+','dasc','sahjhj');

insert into Funcionarios values(-1,null,1,'gh','2001-08-08','Administrador de Bases de Datos');

insert into Funcionarios values(6,null,1,'gh','2001-08-08','Doctor');

insert into Funcionarios values(12,null,1,'gh','2001-08-08','Enfermero');

insert into Funcionarios values(1,null,1,'gh','2001-08-08','Secretario');




/*create function Decryption(nombre varchar(100), cedula int)
	select * from Personas where (Personas.password = MD5('sahjhj'));
    */