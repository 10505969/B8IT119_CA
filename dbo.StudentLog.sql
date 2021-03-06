﻿CREATE TABLE [dbo].[StudentLog] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [ChangeDate]      DATETIME      DEFAULT (getdate()) NOT NULL,
    [Change]          VARCHAR (30)  NOT NULL,
    [FirstName]       VARCHAR (255) NOT NULL,
    [LastName]        VARCHAR (255) NOT NULL,
    [EmailNew]        VARCHAR (255) NULL,
    [EmailOld]        VARCHAR (255) NULL,
    [PhoneNew]        VARCHAR (255) NULL,
    [PhoneOld]        VARCHAR (255) NULL,
    [AddressLine1New] VARCHAR (255) NULL,
    [AddressLine1Old] VARCHAR (255) NULL,
    [AddressLine2New] VARCHAR (255) NULL,
    [AddressLine2Old] VARCHAR (255) NULL,
    [CityNew]         VARCHAR (255) NULL,
    [CityOld]         VARCHAR (255) NULL,
    [CountyNew]       VARCHAR (255) NULL,
    [CountyOld]       VARCHAR (255) NULL,
    [LevelNew]        VARCHAR (255) NULL,
    [LevelOld]        VARCHAR (255) NULL,
    [Course]          VARCHAR (255) NOT NULL,
    [StudentNo]       INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

