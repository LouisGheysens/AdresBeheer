CREATE TABLE [dbo].[gemeente](
NISCODE int PRIMARY KEY NOT NULL check (NISCODE between 0 and 99999),
gemeentenaam nvarchar(100) NOT NULL
);