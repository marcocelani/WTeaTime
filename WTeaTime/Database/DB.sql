CREATE TABLE [dbo].[TeaEntity] (
    [Title]     NVARCHAR (256) NOT NULL,
    [Min]       INT            NOT NULL,
    [Sec]       INT            NOT NULL,
    [Message]   NVARCHAR (512) NULL,
    [Action]    NVARCHAR (512) NULL,
    [Beep]      BIT            DEFAULT ((0)) NOT NULL,
    [ShowMex]   BIT            DEFAULT ((0)) NOT NULL,
    [RunAction] BIT            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Title] ASC)
);
