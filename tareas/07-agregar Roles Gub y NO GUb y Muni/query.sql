/****** Script para el comando SelectTopNRows de SSMS  ******/
SELECT TOP (1000) [Id]
      ,[InsertedAt]
      ,[InsertedBy]
      ,[UpdatedAt]
      ,[UpdatedBy]
      ,[DeletedAt]
      ,[DeletedBy]
      ,[IsDeleted]
      ,[Nombre]
      ,[PadreId]
      ,[Geometria]
      ,[FullId]
      ,[TipoZonaId]
  FROM [OranDB].[dbo].[Zonas]

  select * from dbo.Roles
  --insert into dbo.Roles(Id,IsDeleted,Nombre,Descripcion)
  --values('COD_EMPL_MUNICIPAL',0,'Empleado Municipal','Empleado Municipal'),
  --('COD_ORG_GUB',0,'Organismo Gubernamental','Organismo Gubernamental'),
  --('COD_ORG_NOGUB',0,'Organismo No Gubernamental','Organismo No Gubernamental'),
  --('COD_AUTORIDAD_MUNICIPAL',0,'Autoridad Municipal','Autoridad Municipal')

  select * from dbo.Inmuebles
  select * from dbo.Titulares
  select * from dbo.InmueblesTitulares
  select * from dbo.Impuesto_Tsg
  update dbo.Impuesto_Tsg set dFecha_Pago=null,nPago=null where id='B5C6DAC7-3FED-4BD2-BBF1-2BAB587FE9B8'
  --insert into dbo.InmueblesTitulares(Id,IsDeleted,InmuebleId,TitularId)
  --values(newid(),0,'33333','102'),
  --(newid(),0,'55555','103')
