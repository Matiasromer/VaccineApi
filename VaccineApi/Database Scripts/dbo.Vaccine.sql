CREATE TABLE [dbo].[Vaccine] (
    [Vac_Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Vac_Navn] VARCHAR (50) NOT NULL,
    [Vac_Info] TEXT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Vac_Id] ASC)
);

