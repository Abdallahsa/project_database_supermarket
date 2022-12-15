/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/28/2022 2:52:02 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMER_PRODUCT') and o.name = 'FK_CUSTOMER_REFERENCE_CUSTOMER')
alter table CUSTOMER_PRODUCT
   drop constraint FK_CUSTOMER_REFERENCE_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMER_PRODUCT') and o.name = 'FK_CUSTOMER_REFERENCE_PRODUCT')
alter table CUSTOMER_PRODUCT
   drop constraint FK_CUSTOMER_REFERENCE_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUCT') and o.name = 'FK_PRODUCT_REFERENCE_CATEGORY')
alter table PRODUCT
   drop constraint FK_PRODUCT_REFERENCE_CATEGORY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATEGORY')
            and   type = 'U')
   drop table CATEGORY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER_PRODUCT')
            and   type = 'U')
   drop table CUSTOMER_PRODUCT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUCT')
            and   type = 'U')
   drop table PRODUCT
go

/*==============================================================*/
/* Table: CATEGORY                                              */
/*==============================================================*/
create table CATEGORY (
   CATEID               integer              not null,
   CATENAME             varchar(20)          not null unique,
   constraint PK_CATEGORY primary key (CATEID)
)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   CUSTID               integer              not null,
   CUSTNAME             varchar(20)          not null,
   CUSTPASSWORD         varchar(20)          not null unique,
   constraint PK_CUSTOMER primary key (CUSTID)
)
go

/*==============================================================*/
/* Table: CUSTOMER_PRODUCT                                      */
/*==============================================================*/
create table CUSTOMER_PRODUCT (
   CUSTID               integer              not null,
   PRODID               integer              not null,
   BUYING_DATE          date                 not null,
   constraint PK_CUSTOMER_PRODUCT primary key (CUSTID, PRODID)
)
go

/*==============================================================*/
/* Table: PRODUCT                                               */
/*==============================================================*/
create table PRODUCT (
   PRODID               integer              not null,
   CATEID               integer              not null,
   PRODNAME             varchar(20)          not null unique,
   PRODPRICE            Decimal (4,2)        not null,
   PRODQUANTITY         integer              not null,
   constraint PK_PRODUCT primary key (PRODID)
)
go

alter table CUSTOMER_PRODUCT
   add constraint FK_CUSTOMER_REFERENCE_CUSTOMER foreign key (CUSTID)
      references CUSTOMER (CUSTID)
go

alter table CUSTOMER_PRODUCT
   add constraint FK_CUSTOMER_REFERENCE_PRODUCT foreign key (PRODID)
      references PRODUCT (PRODID)
go

alter table PRODUCT
   add constraint FK_PRODUCT_REFERENCE_CATEGORY foreign key (CATEID)
      references CATEGORY (CATEID)
go







select ProdName from Product where ProdId in 
 (select top 1 ProdId from Customer_Product 
 group by ProdId order by count(ProdId) DESC)

 select ProdName  from Product where PRODID not in 
 (select PRODID from Customer_Product 
 where month(Buying_Date) = '')

 select CustName from Customer where CustId in 
 (select CustId from Customer_Product 
 where year(GETDATE())-year(Buying_Date) > 1 
 and month(GETDATE())-month(Buying_Date) >= 0)

 select CustName from Customer where CustID 
 in (select top 1 CustId from Customer_Product 
 group by CustId order by count(CustId) DESC)

 select top 1 CateName from Category where CateId in (
 select CateId from Product where ProdId in (
 select ProdId from Customer_Product)) and CateName = 'electric appliances' or CateName = 'food'
group by CateName order by (count(CateName)) DESC

select *, count(CUSTOMER_PRODUCT.PRODID) from PRODUCT, CUSTOMER_PRODUCT
WHERE PRODUCT.PRODID = CUSTOMER_PRODUCT.PRODID
GROUP BY PRODUCT.PRODID, PRODUCT.CATEID, PRODUCT.PRODNAME, PRODUCT.PRODPRICE, PRODUCT.PRODQUANTITY,
CUSTOMER_PRODUCT.CUSTID, CUSTOMER_PRODUCT.PRODID, CUSTOMER_PRODUCT.BUYING_DATE