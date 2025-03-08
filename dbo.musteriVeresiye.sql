CREATE TABLE [dbo].[musteriVeresiye] (
    [ID]                     INT             IDENTITY (1, 1) NOT NULL,
    [MusteriID]              INT             NOT NULL,
    [Ad]                     NVARCHAR (100)  NOT NULL,
    [Telefon]                VARCHAR (15)    NOT NULL,
    [Adres]                  NVARCHAR (100)  NOT NULL,
    [Eposta]                 VARCHAR (100)   NULL,
    [BorcTutari]             DECIMAL (18, 2) NOT NULL,
    [veresiyeYazdirmaTarihi] DATETIME        NOT NULL,
    [veresiyeOdemeTarihi]    DATETIME        NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

