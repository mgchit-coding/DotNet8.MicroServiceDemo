```
create table Tbl_Blog
(
    Blog_Id      int identity
        constraint PK_Tbl_Blog
            primary key,
    Blog_Title   nvarchar(50),
    Blog_Author  nvarchar(50),
    Blog_Content nvarchar(200) 
go

```