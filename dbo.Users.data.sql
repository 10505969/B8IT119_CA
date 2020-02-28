SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([Id], [UserName], [Pword]) VALUES (1, N'Bob', N'1234')
SET IDENTITY_INSERT [dbo].[Users] OFF
