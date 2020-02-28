CREATE TABLE [dbo].[Students] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (255) NOT NULL,
    [LastName]     VARCHAR (255) NOT NULL,
    [Email]        VARCHAR (255) NOT NULL,
    [Phone]        VARCHAR (255) NOT NULL,
    [AddressLine1] VARCHAR (255) NOT NULL,
    [AddressLine2] VARCHAR (255) NULL,
    [City]         VARCHAR (255) NULL,
    [County]       VARCHAR (255) NOT NULL,
    [Level]        VARCHAR (255) NOT NULL,
    [Course]       VARCHAR (255) NOT NULL,
    [StudentNo]    INT           NOT NULL,
    [IsDeleted]    BIT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([StudentNo] ASC),
    CHECK ([Level]='Postgrad' OR [Level]='Undergrad')
);


GO
CREATE TRIGGER StudentUpdate
	ON [dbo].[Students]
	FOR UPDATE
	AS
	BEGIN
		INSERT INTO StudentLog (ChangeDate, Change, FirstName, LastName, EmailNew, EmailOld, AddressLine1New, AddressLine1Old, AddressLine2New, AddressLine2Old, CityNew, CityOld, CountyNew, CountyOld, LevelNew, LevelOld, Course, StudentNo)
		SELECT GETDATE(), 'Updated', i.FirstName, i.LastName, i.Email, d.Email, i.AddressLine1, d.AddressLine1, i.AddressLine2, d.AddressLine2, i.City, d.City, i.County, d.County, i.Level, d.Level, i.Course, i.StudentNo
		FROM inserted i, deleted d WHERE i.IsDeleted = d.IsDeleted
	END
GO
CREATE TRIGGER StudentDelete
	ON [dbo].[Students]
	FOR UPDATE
	AS
	BEGIN
		INSERT INTO StudentLog (ChangeDate, Change, FirstName, LastName, EmailOld, AddressLine1Old, AddressLine2Old, CityOld, CountyOld, LevelOld, Course, StudentNo)
		SELECT GETDATE(), 'Deleted', d.FirstName, d.LastName, d.Email, d.AddressLine1, d.AddressLine2, d.City, d.County, d.Level, d.Course, d.StudentNo
		FROM deleted d JOIN inserted i ON d.StudentNo = i.StudentNo WHERE d.IsDeleted != i.IsDeleted
	END
GO
CREATE TRIGGER [StudentAdd]
	ON [dbo].[Students]
	FOR INSERT
	AS
	BEGIN
		INSERT INTO StudentLog (ChangeDate, Change, FirstName, LastName, EmailNew, AddressLine1New, AddressLine2New, CityNew, CountyNew, LevelNew, Course, StudentNo)
		SELECT GETDATE(), 'Added', i.FirstName, i.LastName, i.Email, i.AddressLine1, i.AddressLine2, i.City, i.County, i.Level, i.Course, i.StudentNo
		FROM inserted i
	END
GO
CREATE TRIGGER HardDelete
	ON [dbo].[Students]
	FOR DELETE
	AS
	BEGIN
		INSERT INTO StudentLog (ChangeDate, Change, FirstName, LastName, EmailOld, AddressLine1Old, AddressLine2Old, CityOld, CountyOld, LevelOld, Course, StudentNo)
		SELECT GETDATE(), 'Hard Delete', d.FirstName, d.LastName, d.Email, d.AddressLine1, d.AddressLine2, d.City, d.County, d.Level, d.Course, d.StudentNo
		FROM deleted d
	END