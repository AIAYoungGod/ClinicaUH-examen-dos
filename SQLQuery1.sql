CREATE DATABASE CLINICAUH;

GO
USE CLINICAUH;

CREATE TABLE Medicos (
    IdMedico INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Especialidad NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20) NOT NULL
);
CREATE TABLE Pacientes (
    IdPaciente INT IDENTITY(1,1) PRIMARY KEY,
    Cedula NVARCHAR(20) UNIQUE NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    PrimerApellido NVARCHAR(100) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Edad INT NOT NULL,
    Telefono NVARCHAR(20) NOT NULL
);


CREATE TABLE Consultas (
    IdConsulta INT IDENTITY(1,1) PRIMARY KEY,
    IdPaciente INT NOT NULL,
    IdMedico INT NOT NULL,
    FechaAtencion DATE NOT NULL,
    HoraAtencion TIME NOT NULL,
    Consultorio NVARCHAR(50) NOT NULL,
    FOREIGN KEY (IdPaciente) REFERENCES Pacientes(IdPaciente) ON DELETE CASCADE,
    FOREIGN KEY (IdMedico) REFERENCES Medicos(IdMedico) ON DELETE CASCADE
);











DROP TABLE IF EXISTS Consultas;
DROP TABLE IF EXISTS Pacientes;
DROP TABLE IF EXISTS Medicos;
