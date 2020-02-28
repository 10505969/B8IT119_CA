CREATE TABLE [dbo].[Users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [UserName] VARCHAR (255) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
    [Pword]    VARCHAR (255) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

