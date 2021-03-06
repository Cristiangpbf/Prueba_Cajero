USE [Cajero]
GO
/****** Object:  Trigger [dbo].[GETDATE_TRANS]    Script Date: 10/01/2020 15:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[GETDATE_TRANS]
on [dbo].[TRANSACCION]
instead of insert
as
begin
	INSERT INTO [dbo].[TRANSACCION]
           ([ID_TARJ]
           ,[ID_CAJERO]
           ,[FECHA_TRANS]
           ,[TIPO_TRANS]
           ,[VALOR])
     VALUES
           ((select ID_TARJ FROM inserted)
           ,(select ID_CAJERO FROM inserted)
           ,GETDATE()
           ,(select TIPO_TRANS FROM inserted)
           ,(select VALOR FROM inserted))
end

USE [Cajero]
GO
/****** Object:  Trigger [dbo].[retiro_saldo_cuenta]    Script Date: 10/01/2020 15:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Retiro

ALTER trigger [dbo].[retiro_saldo_cuenta]
on [dbo].[TRANSACCION] 
after insert
as
if((select TIPO_TRANS FROM inserted) = 'Retiro')
begin
declare @this_valor decimal(9,2)
declare @this_id_tarjeta int
set @this_valor = (SELECT VALOR FROM inserted)
set @this_id_tarjeta = (SELECT ID_TARJ FROM inserted)
	update CUENTA
	set SALDO_CUENTA = (SALDO_CUENTA-@this_valor)
	where ID_CUENTA = (SELECT ID_CUENTA FROM TARJETA 
						WHERE ID_TARJ = @this_id_tarjeta)
end
	