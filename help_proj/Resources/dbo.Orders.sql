CREATE TABLE [dbo].[Orders] (
    [Id]             INT         IDENTITY (1,1)      NOT NULL,
    [labor_name]     NVARCHAR (50) NOT NULL,
    [order_type]     NVARCHAR (50)  NOT NULL,
    [order_num]      NVARCHAR(50)  NOT NULL,
    [order_note]     NVARCHAR (100) NOT NULL,
    [order_date]     NVARCHAR(50)   NOT NULL,
    [order_customer] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

