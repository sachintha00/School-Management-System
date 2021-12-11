	--Create database HNC School Management System

	CREATE DATABASE HNC_School_Management_System;
	
	USE HNC_School_Management_System;

	--CREATE TABLE ACCOUNT

	CREATE TABLE ACCOUNT
	(
		Num						INT		IDENTITY (1,1)  NOT NULL, 

		Roll_Id AS 'R' + RIGHT('000' + CAST (Num AS VARCHAR(7)),7) PERSISTED,	

		Roll_Name               VARCHAR (80)			NOT NULL,
		Login_Username			VARCHAR (50)			NOT NULL, 
		Login_Password			VARCHAR (20)			NOT NULL,
		E_mail					VARCHAR (90)					,
		A_Create_Date			DATE							,
		A_Create_Time			TIME							,

		CONSTRAINT pk_ACCOUNT PRIMARY KEY (Roll_Id)
	);


	--CREATE TABLE LOG IN TEACHER

	CREATE TABLE LOG_IN_TEACHER
	(
		Roll_Id					VARCHAR ( 8)	NOT NULL,
		Roll_name               VARCHAR (80)			,
		First_Name				VARCHAR (100)	NOT NULL,
		Middle_Name				VARCHAR (100)			,
		Surname					VARCHAR (100)	NOT NULL,
		User_Address			VARCHAR (100)			,
		Img                     IMAGE					,
		Gender					VARCHAR (10)			,
		User_Tele_No			INT						,
		Date_Of_Birth			DATE					,						
		Subject					VARCHAR (50)			,
		Salary					DECIMAL					,
		 
		CONSTRAINT pk_LOG_IN_TEACHER PRIMARY KEY (Roll_Id),
		CONSTRAINT fk_LOG_IN_TEACHER FOREIGN KEY (Roll_Id) REFERENCES ACCOUNT 
		ON DELETE CASCADE
	);


	--CREATE TABLE LOG IN STUDENT

	CREATE TABLE LOG_IN_STUDENT
	(
		Roll_Id					VARCHAR ( 8)	NOT NULL,
		Roll_name               VARCHAR (80)			,
		First_Name				VARCHAR (100)	NOT NULL,
		Middle_Name				VARCHAR (100)			,
		Surname					VARCHAR (100)	NOT NULL,
		User_Address			VARCHAR (100)			,
		Img                     IMAGE					,
		Gender					VARCHAR (10)			,
		User_Tele_No			INT						,
		Date_Of_Birth			DATE					,						
		Grade					VARCHAR (50)			,
		 
		CONSTRAINT pk_LOG_IN_STUDENT PRIMARY KEY (Roll_Id),
		CONSTRAINT fk_LOG_IN_STUDENT FOREIGN KEY (Roll_Id) REFERENCES ACCOUNT 
		ON DELETE CASCADE
	);