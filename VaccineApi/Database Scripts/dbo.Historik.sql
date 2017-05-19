CREATE TABLE [dbo].[Historik] (
    [Dato_Vaccineret] DATE NOT NULL,
    [Barn_Id]         INT  NOT NULL,
    [Vac_Id]          INT  NOT NULL,
    [Vaccineret]      INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Dato_Vaccineret] ASC)
);

