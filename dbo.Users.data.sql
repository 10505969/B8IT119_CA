SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([Id], [UserName], [Pword]) VALUES (1, N'Bob', N'1234')
INSERT INTO [dbo].[Users] ([Id], [UserName], [Pword]) VALUES (2, N'User', N'Pass')
SET IDENTITY_INSERT [dbo].[Users] OFF
