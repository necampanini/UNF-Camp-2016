CREATE TABLE [dbo].[BlogPostComments] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [BlogPostId]  INT             NOT NULL,
    [Comment]     NVARCHAR (4000) NOT NULL,
    [DateCreated] DATETIME2 (2)   CONSTRAINT [DF_BlogPostComments_DateCreated] DEFAULT (getutcdate()) NOT NULL,
    CONSTRAINT [PK_BlogPostComments] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_BlogPostComments_BlogPosts] FOREIGN KEY ([BlogPostId]) REFERENCES [dbo].[BlogPosts] ([Id])
);

