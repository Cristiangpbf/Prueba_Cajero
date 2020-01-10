/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     09/01/2020 20:59:45                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUENTA') and o.name = 'FK_CUENTA_RELATIONS_USUARIO')
alter table CUENTA
   drop constraint FK_CUENTA_RELATIONS_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TARJETA') and o.name = 'FK_TARJETA_RELATIONS_CUENTA')
alter table TARJETA
   drop constraint FK_TARJETA_RELATIONS_CUENTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRANSACCION') and o.name = 'FK_TRANSACC_RELATIONS_TARJETA')
alter table TRANSACCION
   drop constraint FK_TRANSACC_RELATIONS_TARJETA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRANSACCION') and o.name = 'FK_TRANSACC_RELATIONS_CAJERO')
alter table TRANSACCION
   drop constraint FK_TRANSACC_RELATIONS_CAJERO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CAJERO')
            and   type = 'U')
   drop table CAJERO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUENTA')
            and   name  = 'RELATIONSHIP_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUENTA.RELATIONSHIP_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUENTA')
            and   type = 'U')
   drop table CUENTA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TARJETA')
            and   name  = 'RELATIONSHIP_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index TARJETA.RELATIONSHIP_3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TARJETA')
            and   type = 'U')
   drop table TARJETA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRANSACCION')
            and   name  = 'RELATIONSHIP_5_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRANSACCION.RELATIONSHIP_5_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRANSACCION')
            and   name  = 'RELATIONSHIP_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRANSACCION.RELATIONSHIP_4_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRANSACCION')
            and   type = 'U')
   drop table TRANSACCION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

/*==============================================================*/
/* Table: CAJERO                                                */
/*==============================================================*/
create table CAJERO (
   ID_CAJERO            int        IDENTITY          not null,
   DIR_CAJERO           varchar(30)          not null,
   SALDO_CAJERO         decimal(9,2)         not null,
   constraint PK_CAJERO primary key nonclustered (ID_CAJERO)
)
go

/*==============================================================*/
/* Table: CUENTA                                                */
/*==============================================================*/
create table CUENTA (
   ID_CUENTA            int        IDENTITY          not null,
   ID_USER              int                  null,
   TIPO_CUENTA          varchar(20)          not null,
   NUM_CUENTA           varchar(10)          not null,
   SALDO_CUENTA         decimal(9,2)         not null,
   constraint PK_CUENTA primary key nonclustered (ID_CUENTA)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_1_FK on CUENTA (
ID_USER ASC
)
go

/*==============================================================*/
/* Table: TARJETA                                               */
/*==============================================================*/
create table TARJETA (
   ID_TARJ              int         IDENTITY         not null,
   ID_CUENTA            int                  null,
   NUM_TARJ             varchar(10)          not null,
   CLAVE_TARJ           varchar(4)           not null,
   constraint PK_TARJETA primary key nonclustered (ID_TARJ)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_3_FK on TARJETA (
ID_CUENTA ASC
)
go

/*==============================================================*/
/* Table: TRANSACCION                                           */
/*==============================================================*/
create table TRANSACCION (
   ID_TRANS             int         IDENTITY         not null,
   ID_TARJ              int                  null,
   ID_CAJERO            int                  null,
   FECHA_TRANS          datetime             not null,
   TIPO_TRANS           varchar(20)          not null,
   VALOR                decimal(9,2)         null,
   constraint PK_TRANSACCION primary key nonclustered (ID_TRANS)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_4_FK on TRANSACCION (
ID_TARJ ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_5_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_5_FK on TRANSACCION (
ID_CAJERO ASC
)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   ID_USER              int          IDENTITY        not null,
   NOMB_USER            varchar(20)          not null,
   APELL_USER           varchar(20)          not null,
   CED_USER             varchar(10)          not null,
   DIR_USER             varchar(30)          not null,
   TELF_USER            varchar(10)          null,
   constraint PK_USUARIO primary key nonclustered (ID_USER)
)
go

alter table CUENTA
   add constraint FK_CUENTA_RELATIONS_USUARIO foreign key (ID_USER)
      references USUARIO (ID_USER)
go

alter table TARJETA
   add constraint FK_TARJETA_RELATIONS_CUENTA foreign key (ID_CUENTA)
      references CUENTA (ID_CUENTA)
go

alter table TRANSACCION
   add constraint FK_TRANSACC_RELATIONS_TARJETA foreign key (ID_TARJ)
      references TARJETA (ID_TARJ)
go

alter table TRANSACCION
   add constraint FK_TRANSACC_RELATIONS_CAJERO foreign key (ID_CAJERO)
      references CAJERO (ID_CAJERO)
go

