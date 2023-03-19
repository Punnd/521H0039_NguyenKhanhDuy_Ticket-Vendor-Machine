create database ticket
create table destination(
	id    varchar(10),
	place nvarchar(100),
	price money
)

insert into destination values('VT',N'Vung Tau','200.000')
insert into destination values('TN',N'Tay Ninh','100.000')
insert into destination values('TD',N'Thu Duc','15.000')
insert into destination values('Q12',N'Quan 12','10.000')

select * from destination
