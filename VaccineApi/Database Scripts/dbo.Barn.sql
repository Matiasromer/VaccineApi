CREATE TABLE [dbo].[Barn] (
    [Barn_Id]      INT          IDENTITY (1, 1) NOT NULL,
    [Barn_Foedsel] DATE         NOT NULL,
    [Barn_Navn]    VARCHAR (50) NOT NULL,
    [Device_id]    INT          DEFAULT ((0)) NOT NULL,
    [Gender]       VARCHAR (6)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Barn_Id] ASC)
);

