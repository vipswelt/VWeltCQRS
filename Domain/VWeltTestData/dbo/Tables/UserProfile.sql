CREATE TABLE [dbo].[UserProfile] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (255) NULL,
    [Email]     VARCHAR (255) NULL,
    [MobileNo]  VARCHAR (20)  NULL,
    [IsActive]  BIT           NULL,
    [CreatedOn] DATETIME      NULL,
    [UpdatedOn] DATETIME      NULL,
    CONSTRAINT [PK_UserProfile] PRIMARY KEY CLUSTERED ([Id] ASC)
);

