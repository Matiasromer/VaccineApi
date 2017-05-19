CREATE TABLE [dbo].[Kalender] (
    [Kalender_id] INT      IDENTITY (1, 1) NOT NULL,
    [Dato]        DATETIME NOT NULL,
    [Barn_id]     INT      NOT NULL,
    [Vac_id]      INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Kalender_id] ASC)
);

