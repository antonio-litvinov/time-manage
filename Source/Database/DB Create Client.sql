CREATE TABLE Categories
(
	[ID] uniqueidentifier NOT NULL PRIMARY KEY,
	[Name] nvarchar(50),
	[GroupID] uniqueidentifier
);

CREATE TABLE Groups
(
	[ID] uniqueidentifier NOT NULL PRIMARY KEY,
	[Name] nvarchar(50)
);

CREATE TABLE TaskCategory
(
	[ID] uniqueidentifier NOT NULL PRIMARY KEY,
	[TaskID] uniqueidentifier,
	[CategoryID] uniqueidentifier,
	[GroupID] uniqueidentifier
);

CREATE TABLE TaskContact
(
	[ID] uniqueidentifier NOT NULL PRIMARY KEY,
	[TaskID] uniqueidentifier,
	[ContactID] uniqueidentifier
);

CREATE TABLE TaskDocument
(
	[ID] uniqueidentifier NOT NULL PRIMARY KEY,
	[TaskID] uniqueidentifier,
	[Link] nvarchar(50)
);

CREATE TABLE Tasks
(
	[ID] uniqueidentifier NOT NULL PRIMARY KEY,
	[Name] nvarchar(50),
	[Done] bit,
	[Start] nvarchar(50),
	[Finish] nvarchar(50),
	[Text] nvarchar(1000),
	[Complete] nvarchar(50),
	[Importance] nvarchar(50)
);

CREATE TABLE Contacts
(
	[ID] uniqueidentifier NOT NULL PRIMARY KEY,
	[Name] nvarchar(50),
	[Mobile] nvarchar(50),
	[Home] nvarchar(50),
	[Work] nvarchar(1000),
	[Address] nvarchar(50),
	[Email] nvarchar(50)
);

CREATE TABLE Views
(
	[ID] uniqueidentifier NOT NULL PRIMARY KEY,
	[Caption] nvarchar(50),
	[Name] bit,
	[Text] bit,
	[Done] bit,
	[Start] bit,
	[Finish] bit,
	[Category] bit,
	[Importance] bit,
	[Complete] bit
);