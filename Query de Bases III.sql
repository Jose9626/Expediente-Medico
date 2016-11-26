Drop database expediente_medico;
Create database expediente_medico;
USE expediente_medico;


CREATE TABLE Personas(
	cedula_persona numeric(9,0) NOT NULL,
    nombre_pila varchar(45) NOT NULL,
    apellido1 varchar(20) NOT NULL,
    apellido2 varchar(20),
    fecha_nacimiento date NOT NULL,
    tipo_sangre varchar(3) NOT NULL,
    nacionalidad varchar(20) NOT NULL,
    password varchar(100) NOT NULL,
    PRIMARY KEY(cedula_persona)
    );

DELIMITER $$
create trigger encrypt before insert on Personas
	for each row
		BEGIN
			set New.password = MD5(New.password);
        END$$
	
create trigger check_Insert_Personas before insert on Personas 
	for each row 
		BEGIN  
		if new.cedula_persona < 0 || new.nombre_pila = '' || new.apellido1 = '' || new.apellido2 = '' 
        || (DateDiff(CURDATE(),new.fecha_nacimiento)<-1) || new.tipo_sangre = '' || 
        new.nacionalidad = '' || new.password = ''
        then
			signal sqlstate '45000'   
			set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$

create trigger check_Update_Personas before update on Personas 
	for each row 
		BEGIN  
		if new.cedula_persona < 0 || new.nombre_pila = '' || new.apellido1 = '' || new.apellido2 = '' 
        || (DateDiff(CURDATE(),new.fecha_nacimiento)<-1) || new.tipo_sangre = '' || 
        new.nacionalidad = '' || new.password = ''
        then
			signal sqlstate '45000'   
			set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
DELIMITER ;

create table Tipos_Centros(tipo_centro varchar(20) primary key);

DELIMITER $$
create trigger check_Insert_Tipos_Centro before insert on Tipos_Centros 
	for each row
		BEGIN
		if new.tipo_centro = ''
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
			END if;
		END $$
    
create trigger check_Update_Tipos_Centro before update on Tipos_Centros 
	for each row
    BEGIN
    if new.tipo_centro = ''
		then
			signal sqlstate '45000'   
			set message_text = 'No se pueden agregar los datos, por favor revise los valores';	
		END if;
    END $$
DELIMITER ;


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
    foreign key (tipo_centro) references Tipos_Centros(tipo_centro)
	);
    
DELIMITER $$
create trigger check_Insert_Centro_Atencion before insert on Centro_Atencion 
	for each row
		BEGIN
		if (new.codigo_centro<1 && new.nombre = '' && new.provincia_ubicacion = '' && 
		new.canton_ubicacion = '' && new.distrito_ubicacion = '' && new.ubicacion_especifica = '' 
		&& capacidad_max_pacientes<0 && tipo_centro = '' && telefono < 0 && 
		(new.telefono not like 6 && new.telefono not like 7 && new.telefono not like 8))
		then
			signal sqlstate '45000'   
			set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
    
create trigger check_Update_Centro_Atencion before update on Centro_Atencion 
	for each row
		BEGIN
			if new.codigo_centro<1 && new.nombre = '' && new.provincia_ubicacion = '' && 
			new.canton_ubicacion = '' && new.distrito_ubicacion = '' && new.ubicacion_especifica = '' 
			&& capacidad_max_pacientes<0 && tipo_centro = '' && telefono < 0 && 
			(telefono not like 6 && telefono not like 7 && telefono not like 8)
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
			END if;
		END $$
DELIMITER ;

create table Funcionarios (
	cedula_persona numeric(9,0) primary key,
    codigo_adicional int NULL,
    codigo_centro int NOT NULL,
    area_labora varchar(30) NOT NULL,
    fecha_ingreso_institucion date NOT NULL,
    rol varchar(40) NOT NULL,
    foreign key (cedula_persona) references Personas(cedula_persona)
	);

DELIMITER $$
create trigger check_Insert_Funcionarios before insert on Funcionarios 
	for each row
		BEGIN
		if (new.cedula_persona < 0 && new.codigo_adicional < 0 && new.codigo_centro < 0 && 
		new.area_labora = '' && DateDiff(CURDate(),fecha_ingreso_institucion)<0)
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
			END if;
		END $$
    
create trigger check_Update_Funcionarios before update on Funcionarios 
		for each row
		BEGIN
		if (new.cedula_persona < 0 && new.codigo_adicional < 0 && new.codigo_centro < 0 && 
		new.area_labora = '' && DateDiff(CURDate(),fecha_ingreso_institucion)<0)
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
			END if;
		END $$
DELIMITER ;

create table Catalogo_Diagnosticos(
	nombre_diagnostico varchar(20),
    codigo_tratamiento int,
    primary key(nombre_diagnostico,codigo_tratamiento),
    check(nombre_diagnostico != '' && codigo_tratamiento>0)
);

DELIMITER $$

    create trigger check_Insert_Catalogo_Diagnosticos before insert on Catalogo_Diagnosticos 
	for each row
    BEGIN
    if (new.nombre_diagnostico = '' || new.codigo_tratamiento<0)
		then
			signal sqlstate '45000'   
			set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
    
    create trigger check_Update_Catalogo_Diagnosticos before update on Catalogo_Diagnosticos 
	for each row
    begin
    if (new.nombre_diagnostico = '' || new.codigo_tratamiento<0)
		then
			signal sqlstate '45000'   
			set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
DELIMITER ;

create table Tipos_Tratamiento(tipo_tratamiento varchar(20) primary key check(tipo_tratamiento != ''));

DELIMITER $$

    create trigger check_Insert_Tipos_Tratamientos before insert on Tipos_Tratamiento 
	for each row
    BEGIN
    if (new.tipo_tratamiento = '')
		then
			signal sqlstate '45000'   
			set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
    
    create trigger check_Update_Tipos_Tratamiento before update on Tipos_Tratamiento 
	for each row
    BEGIN
    if (new.tipo_tratamiento = '')
		then
			signal sqlstate '45000'   
			set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
DELIMITER ;

create table Formas_Aplicacion(forma_aplicacion varchar(20) primary key check(forma_aplicacion != ''));

DELIMITER $$

create trigger check_Insert_Formas_Aplicacion before insert on Formas_Aplicacion 
	for each row
		BEGIN
		if (new.forma_aplicacion = '')
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
			END if;
		END $$
    
create trigger check_Update_Formas_Aplicacion before update on Formas_Aplicacion 
	for each row
		BEGIN
		if (new.forma_aplicacion = '')
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
DELIMITER ;

create table Catalogo_de_Tratamientos(
	codigo_tratamiento int primary key,
    nombre_tratamiento varchar(20) NOT NULL,
    dosis int,
    potencia_dosis int,
    frecuencia_dosis varchar(60),
    tipo_tratamiento varchar(20),
    forma_aplicacion varchar(30),
    check (codigo_tratamiento > 0 && nombre_tratamiento != '' && dosis > 0 && potencia_dosis >0 && 
    frecuencia_dosis != '')
    );

DELIMITER $$

create trigger check_Insert_Catalogo_de_Tratamientos before insert on Catalogo_de_Tratamientos 
	for each row
		BEGIN
		if (new.codigo_tratamiento < 0 || new.nombre_tratamiento = '' || new.dosis < 0 || 
        new.potencia_dosis <0 || new.frecuencia_dosis = '' || new.tipo_tratamiento = '' ||
        new.forma_aplicacion = '')
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
			END if;
		END $$
    
create trigger check_Update_Catalogo_de_Tratamientos before update on Catalogo_de_Tratamientos 
	for each row
		BEGIN
		if (new.codigo_tratamiento < 0 || new.nombre_tratamiento = '' || new.dosis < 0 || 
        new.potencia_dosis <0 || new.frecuencia_dosis = '' || new.tipo_tratamiento = '' ||
        new.forma_aplicacion = '')			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
DELIMITER ;

create table Telefonos(
	telefono numeric(8,0) primary key,
    cedula numeric(9,0) NOT NULL);

DELIMITER $$

create trigger check_Insert_Telefonos before insert on Telefonos 
	for each row
		BEGIN
		if ((new.telefono not like 6 && new.telefono not like 7 && new.telefono not like 8)|| 
        new.cedula < 0)
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
			END if;
		END $$
    
create trigger check_Update_Telefonos before update on Telefonos 
	for each row
		BEGIN
		if ((new.telefono not like 6 && new.telefono not like 7 && new.telefono not like 8)|| 
        new.cedula < 0)
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
DELIMITER ;

create table Paises(
	codigo_pais char(3) primary key,
    nombre_pais varchar(40) NOT NULL);
DELIMITER $$

create trigger check_Insert_Paises before insert on Paises 
	for each row
		BEGIN
		if (new.nombre_pais = '')
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
			END if;
		END $$
    
create trigger check_Update_Paises before update on Paises 
	for each row
		BEGIN
		if (new.nombre_pais = '')
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
DELIMITER ;
    
create table Diagnosticos(
	codigo_cita int primary key,
    codigo_tratamiento int NOT NULL,
    nombre_diagnostico varchar(30) NOT NULL,
    nivel varchar(10) NOT NULL,
    observaciones varchar(120));
DELIMITER $$

create trigger check_Insert_Diagnosticos before insert on Diagnosticos 
	for each row
		BEGIN
		if (new.codigo_cita < 0 || new.codigo_tratamiento||new.nombre_diagnostico = '' ||new.nivel = ''
        || new.observaciones = '')
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
			END if;
		END $$
    
create trigger check_Update_Diagnosticos before update on Diagnosticos 
	for each row
		BEGIN
		if (new.codigo_cita < 0 || new.codigo_tratamiento||new.nombre_diagnostico = '' ||new.nivel = ''
        || new.observaciones = '')			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
DELIMITER ;
    
create table Citas(
	codigo_cita int primary key,
    cedula_paciente numeric (9,0) NOT NULL,
    codigo_centro int NOT NULL, 
    area_atencion varchar(30) NOT NULL,
    fecho_solicitada date NOT NULL, 
    hora_solicitud date NOT NULL,
	observacion varchar(120),
    estado varchar(40) NOT NULL
    );
DELIMITER $$

create trigger check_Insert_Citas before insert on Citas 
	for each row
		BEGIN
		if (new.codigo_cita < 0 || new.cedula_paciente < 0|| new.codigo_centro<0 ||new.area_atencion =''
        || new.observacion = '' || new.estado = '')
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
			END if;
		END $$
    
create trigger check_Update_Citas before update on Citas 
	for each row
		BEGIN
		if (new.codigo_cita < 0 || new.cedula_paciente < 0|| new.codigo_centro<0 ||new.area_atencion =''
        || new.observacion = '' || new.estado = '')
        then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
DELIMITER ;
    
create table Bitacora_Citas(
	Codigo_cita int,
    estado varchar(20) NOT NULL,
    fecha_modificacion date NOT NULL, 
    hora_modificacion date NOT NULL,
    primary key (Codigo_cita,estado));
    
DELIMITER $$

create trigger check_Insert_Bitacora_Citas before insert on Bitacora_Citas 
	for each row
		BEGIN
		if (new.Codigo_cita < 0 || new.estado = '')
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
			END if;
		END $$
    
create trigger Bitacora_Citas before update on Bitacora_Citas 
	for each row
		BEGIN
		if (new.Codigo_cita < 0 || new.estado = '')
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
DELIMITER ;
    
create table Tipos_Areas(nombre_area varchar(25) primary key);

DELIMITER $$

create trigger check_Insert_Tipos_Areas before insert on Tipos_Areas 
	for each row
		BEGIN
		if (new.nombre_area = '')
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
			END if;
		END $$
    
create trigger check_Update_Tipos_Areas before update on Tipos_Areas 
	for each row
		BEGIN
		if (new.nombre_area = '')
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
DELIMITER ;

create table Area_por_Centro(
	codigo_centro int,
    nombre_area varchar(15),
    capacidad int NOT NULL,
	primary key (codigo_centro,nombre_area)
    );
DELIMITER $$

create trigger check_Insert_Area_por_Centro before insert on Area_por_Centro 
	for each row
		BEGIN
		if (new.nombre_area = ''|| new.codigo_centro>0||new.capacidad>0)
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
			END if;
		END $$
    
create trigger check_Update_Area_por_Centro before update on Area_por_Centro 
	for each row
		BEGIN
		if (new.nombre_area = ''|| new.codigo_centro>0||new.capacidad>0)
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$
DELIMITER ;
    
create table Tipos_Roles(rol varchar(15) primary key);

DELIMITER $$

create trigger check_Insert_Tipos_Roles before insert on Tipos_Roles 
	for each row
		BEGIN
		if (new.rol = '')
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
			END if;
		END $$
    
create trigger check_Update_Tipos_Roles before update on Tipos_Roles 
	for each row
		BEGIN
		if (new.rol = '')
			then
				signal sqlstate '45000'   
				set message_text = 'No se pueden agregar los datos, por favor revise los valores';
		END if;
    END $$

create procedure Get_Appointment_Number(out num_cita int)
	BEGIN
		select COUNT(codigo_cita)+1 into num_cita from Citas;
    END$$
    
DELIMITER ;

CALL Get_Appointment_Number(var int)

/*
insert into Tipos_Roles values ('bhjaXSBHJASD');

update Tipos_Roles set rol = 'CHAOS' where (rol  = 'bhjaXSBHJASD');

delete from Tipos_Roles where(rol = 'CHAOS');

insert into Personas values(1,'sa','das','g','2001-08-08','A+','dasc','sahjhj');

update Personas SET cedula_persona = 60 where cedula_persona = 1;

update Personas SET cedula_persona = -4 where cedula_persona = 60;

insert into Personas values(6,'sa','das',null,'2001-08-08','A+','dasc','sahjhj');

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