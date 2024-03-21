```
create table Tbl_Blog
(
    BlogId      int identity
        constraint PK_Tbl_Blog
            primary key,
    BlogTitle   nvarchar(50),
    BlogAuthor  nvarchar(50),
    BlogContent nvarchar(200) 
go

```