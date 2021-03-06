GO
SET IDENTITY_INSERT [dbo].[Categories] ON

INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (1, N'Chest', N'This is the category for the Chest-related Exercises')
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (2, N'Legs', N'This is the category for Leg-related exercises')
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (3, N'Arms', N'This is the category for Arms-related exercises')
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (4, N'Back', N'This is the category for Back-related exercises')
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (5, N'Shoulders', N'This is the category for Shoulders-related exercises')
SET IDENTITY_INSERT [dbo].[Categories] OFF
    GO
SET IDENTITY_INSERT [dbo].[Exercises] ON

INSERT [dbo].[Exercises] ([Id], [Name], [ShortDescription], [LongDescription], [ImageUrl], [Rating], [CategoryId], [RepetitionCount]) VALUES (1, N'Bench Press', N'This is an great chest exercise', N'Bench Press is the oldest exercise there is', N'https://thumbs.dreamstime.com/b/bench-press-brutal-athletic-man-pumping-up-muscles-50414924.jpg', N'4', 1, 0)
INSERT [dbo].[Exercises] ([Id], [Name], [ShortDescription], [LongDescription], [ImageUrl], [Rating], [CategoryId], [RepetitionCount]) VALUES (2, N'Bicep Curl', N'This is a great exercise for bicep', N'This is a very very very very very goood long description', N'https://manofmany.com/wp-content/uploads/2020/06/best-bicep-exercises.jpg', N'5', 3, 0)
INSERT [dbo].[Exercises] ([Id], [Name], [ShortDescription], [LongDescription], [ImageUrl], [Rating], [CategoryId], [RepetitionCount]) VALUES (3, N'Pushups', N'Chest exercise', N'Chest exercise long description', N'https://assets.gqindia.com/photos/5cee7eb00379a73d25177759/master/pass/Pushup.jpg', N'5', 1, 6)
INSERT [dbo].[Exercises] ([Id], [Name], [ShortDescription], [LongDescription], [ImageUrl], [Rating], [CategoryId], [RepetitionCount]) VALUES (4, N'Leg Press', N'Exercise for leg', N'A great exercise for leg day, a must-have in many people book', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRYTGgsw7K2sX1BEO7txXJoWgDB6UtmVRi0Jcz5vjEIwbPrqmigCzVvaFUx-04Q-jhkllM&usqp=CAU', N'5', 2, 0)
SET IDENTITY_INSERT [dbo].[Exercises] OFF