Drop database expediente_medico;
Create database expediente_medico;
USE expediente_medico;

CREATE TABLE Personas(
	cedula_persona numeric(9,0) NOT NULL,
    nombre_pila varchar(45),
    apellido1 varchar(20),
    apellido2 varchar(20),
    fecha_nacimiento date,
    tipo_sangre varchar(3),
    nacionalidad varchar(20),
    contraseña varchar(20),
    PRIMARY KEY(cedula_persona)
    );
      
    
create table Tipos_Centros(tipo_centro varchar(20) primary key);

create table Centro_Atencion(
	nombre varchar(30),
    provincia_ubicacion varchar(10),
    canton_ubicacion varchar(30),
    distrito_ubicacion varchar(20),
	ubicacion_especifica varchar(120),
    capacidad_max_pacientes int,
    tipo_centro varchar(20),
    telefono numeric(8,0),
    foreign key (tipo_centro) references Tipos_Centros(tipo_centro),
    check(capacidad_max_pacientes>0)
	);
   
    
create table Funcionario (
	cedula_persona numeric(9,0) primary key,
    codigo_adicional int ,
    codigo_centro int,
    area_labora varchar(30),
    fecha_ingreso_institucion date,
    foreign key (cedula_persona) references Personas(cedula_persona)
	);

create table Catalogo_Diagnosticos(
	nombre_diagnostico varchar(20),
    codigo_tratamiento int,
    primary key(nombre_diagnostico,codigo_tratamiento)
);

create table Tipos_Tratamiento(tipo_tratamiento varchar(20) primary key);
create table Formas_Aplicacion(forma_aplicacion varchar(20) primary key);

create table Catalogo_de_Tratamientos(
	codigo_tratamiento int primary key,
    nombre_tratamiento varchar(20),
    dosis int,
    potencia_dosis int,
    frecuencia_dosis varchar(60),
    tipo_tratamiento varchar(20),
    forma_aplicacion varchar(30));

create table Telefonos(
	telefono numeric(8,0),
    cedula numeric(9,0));

create table Paises(
	codigo_pais char(3),
    nombre_pais varchar(40));
    
create table Diagnosticos(
	codigo_cita int,
    codigo_tratamiento char(10),
    nombre_diagnostico varchar(30),
    nivel varchar(10),
    observaciones varchar(120));
    
create table Citas(
	codigo_cita int primary key,
    cedula_paciente numeric (9,0),
    codigo_centro int, 
    area_atencion varchar(30),
    fecho_solicitada date, 
    hora_solicitud date,
	observacion varchar(120),
    estado varchar(40)
    );
    
create table Bitacora_Citas(
	Codigo_cita int,
    estado varchar(20),
    fecha_modificacion date, 
    hora_modificacion date);
    
create table Area_por_Centro
	(codigo_centro int ,
    nombre_area varchar(15),
    capacidad int
    );
    
create table Tipos_Roles(rol varchar(15) primary key);
