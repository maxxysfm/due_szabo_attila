CREATE TABLE [dbo].[Gep] (
    [Id]            INT           NOT NULL,
    [Nev]           VARCHAR (255) NOT NULL,
    [KolcsonzesAra] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Ugyfel] (
    [Id]         INT           NOT NULL,
    [Nev]        VARCHAR (50)  NOT NULL,
    [Cim]        VARCHAR (255) NOT NULL,
    [Kedvezmeny] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Kolcsonzes] (
    [Id]         INT NOT NULL,
    [UgyfelId]   INT NOT NULL,
    [GepId]      INT NOT NULL,
    [NapokSzama] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Kolcsonzes_ToGep] FOREIGN KEY ([GepId]) REFERENCES [dbo].[Gep] ([Id]),
    CONSTRAINT [FK_Kolcsonzes_ToUgyfel] FOREIGN KEY ([UgyfelId]) REFERENCES [dbo].[Ugyfel] ([Id])
);

INSERT INTO [dbo].[Ugyfel] (Id,Nev,Cim,Kedvezmeny) Values (1,'Gipsz Jakab','1000 Csudapest, Futrinka utca 17',5)
INSERT INTO [dbo].[Ugyfel] (Id,Nev,Cim,Kedvezmeny) Values (2,'Kiss János','8000 Székesfehérvár Aba út 23',5)
INSERT INTO [dbo].[Ugyfel] (Id,Nev,Cim,Kedvezmeny) Values (3,'Szabó Amanda','8145 Nádasdladány Kisguba út 65',5)
INSERT INTO [dbo].[Ugyfel] (Id,Nev,Cim,Kedvezmeny) Values (4,'Erdei Zénó','8100 Várpalota Fő út 19',30)
INSERT INTO [dbo].[Ugyfel] (Id,Nev,Cim,Kedvezmeny) Values (5,'Habos Jakab','1200 Narnia Oroszlán út 23',30)
INSERT INTO [dbo].[Ugyfel] (Id,Nev,Cim,Kedvezmeny) Values (6,'Szabó Árpád','1116 Budapest Fehérvári út 299',50)
INSERT INTO [dbo].[Ugyfel] (Id,Nev,Cim,Kedvezmeny) Values (7,'Pintér Béla','1117 Budapest Népliget út 119',50)
INSERT INTO [dbo].[Ugyfel] (Id,Nev,Cim,Kedvezmeny) Values (8,'Nagy Kiss Ferenc','1222 Budapest Kossuth Lajos út 133',70)

INSERT INTO [dbo].[Gep] (Id,Nev,KolcsonzesAra) Values (1,'Fúró', 5500)
INSERT INTO [dbo].[Gep] (Id,Nev,KolcsonzesAra) Values (2,'Fűnyíró', 15900)
INSERT INTO [dbo].[Gep] (Id,Nev,KolcsonzesAra) Values (3,'Habverő', 3200)
INSERT INTO [dbo].[Gep] (Id,Nev,KolcsonzesAra) Values (4,'Csiszoló', 4200)
INSERT INTO [dbo].[Gep] (Id,Nev,KolcsonzesAra) Values (5,'Betonkeverő', 34200)
INSERT INTO [dbo].[Gep] (Id,Nev,KolcsonzesAra) Values (6,'Avarfújó', 9876)
INSERT INTO [dbo].[Gep] (Id,Nev,KolcsonzesAra) Values (7,'Takarító', 23400)
INSERT INTO [dbo].[Gep] (Id,Nev,KolcsonzesAra) Values (8,'Porszívó', 7560)
INSERT INTO [dbo].[Gep] (Id,Nev,KolcsonzesAra) Values (9,'Kapáló gép', 55500)
INSERT INTO [dbo].[Gep] (Id,Nev,KolcsonzesAra) Values (10,'Permetező', 11230)

INSERT INTO [dbo].[Kolcsonzes] (Id,UgyfelId,GepId,NapokSzama)Values(1,5,7,2)
INSERT INTO [dbo].[Kolcsonzes] (Id,UgyfelId,GepId,NapokSzama)Values(2,5,1,2)
INSERT INTO [dbo].[Kolcsonzes] (Id,UgyfelId,GepId,NapokSzama)Values(3,5,2,2)
INSERT INTO [dbo].[Kolcsonzes] (Id,UgyfelId,GepId,NapokSzama)Values(4,4,9,3)
INSERT INTO [dbo].[Kolcsonzes] (Id,UgyfelId,GepId,NapokSzama)Values(5,4,3,1)
INSERT INTO [dbo].[Kolcsonzes] (Id,UgyfelId,GepId,NapokSzama)Values(6,1,6,1)
INSERT INTO [dbo].[Kolcsonzes] (Id,UgyfelId,GepId,NapokSzama)Values(7,1,10,6)
INSERT INTO [dbo].[Kolcsonzes] (Id,UgyfelId,GepId,NapokSzama)Values(8,1,1,10)
INSERT INTO [dbo].[Kolcsonzes] (Id,UgyfelId,GepId,NapokSzama)Values(9,1,4,4)
INSERT INTO [dbo].[Kolcsonzes] (Id,UgyfelId,GepId,NapokSzama)Values(10,2,6,1)
INSERT INTO [dbo].[Kolcsonzes] (Id,UgyfelId,GepId,NapokSzama)Values(11,2,3,1)
INSERT INTO [dbo].[Kolcsonzes] (Id,UgyfelId,GepId,NapokSzama)Values(12,3,1,1)
INSERT INTO [dbo].[Kolcsonzes] (Id,UgyfelId,GepId,NapokSzama)Values(13,6,8,6)
INSERT INTO [dbo].[Kolcsonzes] (Id,UgyfelId,GepId,NapokSzama)Values(14,7,7,1)