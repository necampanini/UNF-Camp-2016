CREATE TABLE [dbo].[BlogPosts] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       VARCHAR (100)  NOT NULL,
    [Body]        NVARCHAR (MAX) NOT NULL,
    [DateCreated] DATETIME2 (2)  CONSTRAINT [DF_BlogPosts_DateCreated] DEFAULT (getutcdate()) NOT NULL,
    CONSTRAINT [PK_BlogPosts] PRIMARY KEY CLUSTERED ([Id] ASC)
);

