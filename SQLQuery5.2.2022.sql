create database CTO;
use CTO

----------------------------List_of_works------------------------------
create table List_of_works
(
Code int primary key identity,
work varchar (100),
duration_of_work date,
worker_Code int,
Code_of_orderings int,  
);
------------------------------
alter table List_of_works
add price int

alter table List_of_works
alter column price money

ALTER TABLE List_of_works
add foreign key(Code_of_orderings) references Ordering(Code_Of_Ordering);

alter table List_of_works
add foreign key(Code_of_orderings) references Ordering(Code_Of_Ordering)

--alter table List_of_Works
--add worker_Code int

alter table List_of_works
drop FK__List_of_w__worke__3F466844

alter table List_of_works
add foreign key(worker_Code) references Worker(worker_Code);

alter table List_of_works
alter column duration_of_work varchar (20)
-------------------------------------------------------------------------


------------------------------Client-------------------------------------
create table Client
(
FirstName varchar(20),
MiddleName varchar (20),
LastName varchar(20),
PhoneNumber int,
);
--------------------------
alter table Client
add Client_Code int primary key;

alter table Client
add ClientID_card varchar (20);

alter table Client
alter column Client_Adress varchar (50);

--alter table Client
--drop column Client_Code
-------------------------------------------------------------------------


---------------------------------Worker----------------------------------
create table Worker
(
FirstName varchar (20),
MiddleName varchar (20),
LastName varchar (20),
Salary float,
workerIDcard varchar (20),
worker_phone_number int,
Adress varchar (50),
Experience varchar (3),
);
-------------------------
alter table Worker
ADD CTO_ID int;

alter table Worker
add foreign key(CTO_ID) references CTO(CTO_ID)

--alter table Worker
--add workerID_number varchar (20);
--drop column workerID
--drop PK__Worker__3CF205B1A138621D;


alter table Worker
ADD worker_Code int primary key

alter table Worker
add foreign key(worker_Code) references Ordering(Client_Code)

alter table Worker
add Type_of_Worker varchar(10)

alter table Worker
drop column worker_Code

alter table Worker
add foreign key (CTO_ID) references CTO(CTO_ID)
--------------------------------------------------------------------


-----------------------------Ordering-------------------------------
create table Ordering
(
Code_Of_Ordering int primary key,
VIN_number varchar (50),
Manager varchar(50),
Client_Code int,
);
--alter table Ordering
--add VIN_number (17)
--alter table Ordering
--add Client_Code int

--alter table Ordering
--add Manager int; 

alter table Ordering
add foreign key(Manager) references Worker(worker_Code)

alter table Ordering
add foreign key(Client_Code) references Client(Client_Code)

alter table Ordering
add foreign key(Code_Of_Ordering) references List_of_spare_parts(order_code)

alter table Ordering
add foreign key(Code_Of_Ordering) references List_Of_works(Code)

alter table Ordering
drop FK__Ordering__Code_O__6C190EBB

ALTER TABLE  Ordering
drop FK__Ordering__Code_O__6383C8BA
-----------------------------------------------------------------------


------------------------List_of_spare__parts----------------------------
create table List_of_spare__parts
(
code int primary key,
order_code int,
code_of_spare_part int,
type_of_spare_part varchar (50),
amount_of_spare_parts int,
price money,
date_of_arrival date,
);

EXEC sp_RENAME 'List_of_spare_parts.order code' , 'order_code', 'COLUMN'
alter table List_of_spare__parts
alter column price money

alter table List_of_spare__parts
add order_code int

alter table List_of_spare__parts
drop [FK__List_of_s__order__1DB06A4F]

alter table List_of_spare__parts
add foreign key(order_code) references Ordering(Code_Of_Ordering)

-----------------------------------------------------------------------


-------------------------------Car-------------------------------------
create table Car
(
VIN_Number varchar (100),
Car_Brand varchar (20),
Car_Model varchar (50),
Year_of_manufacture_of_the_Car date,
Fuel_type varchar (20),
Client_code int,
);

--alter table Car
--drop column VIN_Number

--alter table Car
--add VIN_Number varchar (17) primary key

alter table Car
add foreign key(Client_code) references Client(Client_Code)

--alter table Car
--drop FK__Car__Client_code__6A30C649

--alter table Car
--alter column VIN_number varchar(50);

--EXEC sp_RENAME 'Car.VIN_number' , 'VIN_Number', 'COLUMN'

EXEC sp_RENAME 'Car.Car_Brand' , 'Car_Manufacturer', 'COLUMN'

--alter table Car
--add primary key (VIN_Number)

-----------------------------------------------------------------------


--Operation



-------------------------------CTO-------------------------------------
create table CTO
(
CTO_ID int primary key identity,
Name_of_CTO varchar(25),
Amount_of_workers varchar(10),
);

alter table CTO
add CTO_ID int primary key

------------------------------------------------------------------------




---------------------------Insert values--------------------------------

insert into CTO (CTO_ID, Name_of_CTO, Amount_of_workers)
values (1, 'CTO_King_1', 3)
insert into CTO (CTO_ID, Name_of_CTO, Amount_of_workers)
values (3, 'CTO_King_3', 5)
insert into CTO (CTO_ID, Name_of_CTO, Amount_of_workers)
values (20, 'CTO_King_20', 4)


insert into Client (FirstName, MiddleName, LastName, PhoneNumber , ClientID_card, Client_Adress, Client_Code)
values ('Denys','Serhiyovych', 'Petrushchenko', 0971565481, 'IDUKR150004323095', 'Volodymyr Mayakovsky Avenue, 60/10, Kyiv', 6)
insert into Client (FirstName, MiddleName, LastName, PhoneNumber , ClientID_card, Client_Adress, Client_Code)
values ('Kyrylo','Serhiyovych', 'Sydorenko', 0952780759, 'IDUKR200001538476', 'Radunska Street, 40, Kyiv', 25)


insert into Client (FirstName, MiddleName, LastName, PhoneNumber , ClientID_card, Client_Adress, Client_Code)
values ('Arseniy','Volodymyrovich', 'Kalushenko', 0668910456, 'IDUKR320009271850', 'Hradynska Street, 1, Kyiv', 30),
	   ('Dmytro','Vasylovich', 'Reznychenko', 0678696804, 'IDUKR590003214578', 'Volodymyr Mayakovsky Avenue, 42/13, Kyiv', 32),
	   ('Mykola','Victorych', 'Pron', 0937842857, 'IDUKR220008455120', 'Volodymyr Mayakovsky Avenue, 38/10, Kyiv', 95)

insert into Client (FirstName, MiddleName, LastName, PhoneNumber , ClientID_card, Client_Adress, Client_Code)
values ('Mykyta','Dmytrovych', 'Ostapec', 0992295845, 'IDUKR110002245879', 'Mykola Zakrevskoho Street, 95V, Kyiv', 60),
	   ('Konstantin','Olegovich', 'Yarotnik', 0506759266, 'IDUKR490008711155', 'Academician Palladin Avenue, 16, Kyiv', 70)

	   select * from Worker

insert into Worker (FirstName, MiddleName, LastName, Salary, workerIDcard, worker_phone_number, Adress, Experience, CTO_ID, workerID_number, Type_of_Worker, worker_Code)
values ('Anatoliy', 'Oleksandrovych', 'Antoshchuk', 18000, 'IDUKR4800023450648', 0995624503, 'Kurnatovskoho Street, 15, Kyiv', 'Eld', 1, 13159801, 'Worker', 9),
	   ('Artem', 'Sergeevich', 'Vagin', 12000, 'IDUKR2200014559784', 0952724103, 'Perova Boulevard, 11, Kyiv', 'Nov', 20, 20558034, 'Manager4', 4),
	   ('Sofia', 'Viktorivna', 'Volskaya', 15000, 'IDUKR2400018155984', 0661088540, 'Heroes of Stalingrad Avenue, 8 K4, Kyiv', 'Mid', 3, 31970124, 'Manager3', 3),
	   ('Maxim', 'Alexandrovich', 'Galatenko', 11500, 'IDUKR220002882481', 0973005182, 'Heroes of Stalingrad Avenue, 12GK1, Kyiv', 'Nov', 1, 19321451, 'Worker', 5),
	   ('Alexander', 'Leonidovich', 'Faucist', 15500, 'IDUKR990009866013', 0634374304, 'Theodore Dreiser Street, 34/51, Kyiv', 'Mid', 3, 65956259, 'Worker', 7),
	   ('Mykhailo', 'Andriiovych', 'Hlevatsky', 21000, 'IDUKR160007025884', 0989381314, 'Hradynska Street, 9, Kyiv', 'Eld', 3, 61981341, 'Manager2', 2),
	   ('Vladislava', 'Olehivna', 'Gapon', 13000, 'IDUKR550007025884', 0999929050, 'Andriy Malyshko Street, 39, Kyiv', 'Mid', 1, 61225094, 'Manager1', 1),
	   ('Victor', 'Valerievich', 'Myachin', 17000, 'IDUKR430004140839', 0673022228, 'Lesia Ukrainka Boulevard, 28, Kyiv', 'Mid', 3, 44799919, 'Worker', 10),
	   ('Alexander', 'Borisovich', 'Kusiy', 12000, 'IDUKR110005366464', 0506156619, 'Koltsova Boulevard, 8, Kyiv', 'Nov', 20, 97258869, 'Worker', 11),
	   ('Maxim', 'Alexandrovich', 'Galatenko', 10000, 'IDUKR510003502722', 0733814580, 'Akademika, 11 Akademika Dobrokhotova Street, Kyiv', 'Nov', 20, 24987016, 'Worker', 12),
	   ('Anastasia', 'Vsevolodovna', 'Box', 19000, 'IDUKR370007912405', 0956499066, 'Mezhova Street, 26, Kyiv', 'Eld', 3, 85811838, 'Worker', 8),
	   ('Maxim', 'Alexandrovich', 'Galatenko', 20500, 'IDUKR810003434753', 0966174025, 'Heroes of the Dnieper Street, 7/112, Kyiv', 'Eld', 20, 10528719, 'Worker', 6)

insert into Car (Car_Manufacturer, Car_Model, Year_of_manufacture_of_the_Car, Fuel_type, Client_code, VIN_Number)
values ('Volkswagen', 'Arteon R-Line TDI', '2021-05-10', 'Gasoline AI-95', 95, 'WVWZZZ3HZHG3H6040'),
	   ('SsangYong', 'Rexton II', '2008-10-09', 'Diesel', 32, 'KPTGAA1FS8P535432'),
	   ('Audi', 'A5 Sportback', '2016-03-15', 'Gasoline AI-95', 6, 'WAU8TZGR774989'),
	   ('BMW', 'X3 Standart', '2010-09-09', 'Diesel', 25, 'WBA5A1106FGF19299'),
	   ('SsangYong', 'Kyron', '2020-01-20', 'Diesel', 30, 'KPTS0A1KS5P122357'),
	   ('BMW', '528i', '1999-10-15', 'Gasoline AI-92', 70, 'WBADM6343YGU11738'),
	   ('SsangYong', 'Actyon', '2008-12-01', 'Gasoline AI-95', 60, 'X1CC0A1FS8P608018')


insert into Ordering (Client_Code, Manager, Code_Of_Ordering, VIN_number)
values (95, 1, 6, 'WVWZZZ3HZHG3H6040'),
	   (32, 3, 95, 'KPTGAA1FS8P535432'),
	   (6, 4, 25, 'WAU8TZGR774989'),
	   (25, 3, 60, 'WBA5A1106FGF19299'),
	   (30, 2, 30, 'KPTS0A1KS5P122357'),
	   (70, 1, 32, 'WBADM6343YGU11738'),
	   (60, 2, 70, 'X1CC0A1FS8P608018')


insert into List_of_works (work, duration_of_work, Code_of_orderings, price, worker_Code)
values ('Timing belt replacement', '0000-00-00 05:00:00', 6, 2000, 5),
	   ('Pad replacement', '0000-00-00 00:30:00', 95, 1200, 6),
	   ('Front bumper painting', '0000-00-02 2:30:00', 25, 5000, 12),
	   ('Repairing dents in front bumper', '0000-00-00  01:00:00', 60, 4000, 9),
	   ('Oil change', '0000-00-00 00:30:00', 30, 700, 7),
	   ('Headlight repair', '0000-00-00 01:00:00', 32, 1000, 10),
	   ('Complete painting of the car', '0000-00-04 0:00:00', 70, 40000, 8)


insert into List_of_works (work, duration_of_work, Code_of_orderings, price, worker_Code)
values ('Vehicle update', '0000-00-00 16:00:00', 6, 7000, 12),
	   ('Repairing dents in front right door', '0000-00-00  02:00:00', 95, 5000, 9),
	   ('Front bumper painting', '0000-00-02 2:30:00', 30, 5000, 12)

select *from List_of_works

select *from Worker

select top 1 sum (price) as Cost_of_Works, FirstName, LastName, List_of_works.worker_Code from List_of_works, Worker
where List_of_works.worker_Code = Worker.worker_Code
group by List_of_works.worker_Code, FirstName, LastName
order by Cost_of_Works desc

insert into List_of_spare__parts (code, code_of_spare_part, type_of_spare_part, amount_of_spare_parts, price, date_of_arrival, order_code)
values (36, 605, 'Timing belt', 1, 1000, '2022-05-30', 6),
	   (37, 370, 'Pad', 4, 800, '2022-06-05', 95),
	   (38, 501, 'Autoenamel', 1, 2000, '2022-06-01', 25),
	   (39, 127, 'Instruments', 1, 1000, '2022-06-02', 60),
	   (40, 63, 'Engine Oil', 1, 400, '2022-05-28', 30),
	   (41, 412, 'Headlights and instruments', 2, 800, '2022-06-22', 32),
	   (42, 36, 'Autoenamel', 5, 5000, '2022-06-30', 70)

------------------------------------------------

--Update

Update Worker
Set LastName = 'Krol'
Where workerIDcard= 'IDUKR510003502722'

Update Car
Set Client_code = 60
Where Car_Model = 'Actyon'

Update Car
SET Car_Manufacturer = 'Volkswagen AG'
Where Car_Manufacturer = 'Volkswagen'

Update Car
SET Car_Manufacturer = 'SsangYong Motor Company'
Where Car_Manufacturer = 'SsangYong'

Update Car
SET Car_Manufacturer = 'Bayerische Motoren Werke AG (BMW)'
Where Car_Manufacturer = 'BMW'

Update Car
SET Car_Manufacturer = 'Audi AG'
Where Car_Manufacturer = 'Audi'


-------------------------------Delete-------------------------------
delete from List_of_works
where price > 2000

-------------------------------Select-------------------------------
Select * From CTO
use CTO
Select * From Client
Select * From Ordering
Select *From List_of_works

Select Car_Manufacturer + ' (' + Car_Model + ')' as Model_and_Brand, Year_of_manufacture_of_the_Car, Client_code, VIN_Number
From Car

Select TOP 5 * From Client

Select DISTINCT Car_Manufacturer
From Car

SELECT *FROM Car

Select *From List_of_works


Select * From Client
Where FirstName Like 'A%'

Select *From Car

Select *From Client
Where FirstName Like '[^A]%'

Select *From Car
Where Fuel_type Like '[^Diesel]%'

Select *From List_of_works
Where price Between 1500 AND 10000

----------------------------------AVG/MIN/MAX/COUNT/SUM----------------------------------

Select AVG(price) as Average_Price
From List_of_spare__parts

Select Car_Manufacturer, COUNT(*) as ModelsCount 
From Car
Group by Car_Manufacturer

Select Car_Manufacturer, COUNT(*) as ModelsCount 
From Car
Group by Car_Manufacturer
Having COUNT(*) = 1

Select Car_Manufacturer, COUNT(*) as ModelsCount 
From Car
Group by Car_Manufacturer
Having COUNT(*) > 1

Select MIN(Salary) As Min_Salary,
	   MAX(Salary) As Max_Salary
From Worker


Select SUM(amount_of_spare_parts) as Spare_parts_Sum
From List_of_spare__parts

----------------------------------Order by----------------------------------
Select *From Client 
Order by FirstName 
OFFSET 2 ROW
FETCH NEXT 2 ROWS ONLY;

Select *From Worker 
Order by worker_phone_number ASC

Select *From Worker 
Order by CTO_ID ASC, Type_of_Worker DESC
--OFFSET 2 ROW
--FETCH NEXT 2 ROWS ONLY;



----------------------------------DROP----------------------------------
Select FirstName, LastName
From Client
Union Select FirstName, LastName From Realtor

Select FirstName
From Client
Except select FirstName From Realtor

Select FirstName
From Client
Intersect select FirstName From Realtor

----------------------------------INNER----------------------------------
Select Client.FirstName, Client.LastName, Car.VIN_Number, Car.Car_Manufacturer, Car.Car_Model
From Ordering
Join Client ON Client.Client_Code = Ordering.Client_Code
Join Car ON Car.Client_code = Ordering.Client_Code

-----------------------------------Delete-----------------------------------

Delete Top(1)
From List_of_works

Delete Client
select *from Client

Delete List_of_spare__parts
select *from List_of_spare__parts

----------------------------------Group by----------------------------------
SELECT FirstName, LastName, COUNT(Ordering.Code_Of_Ordering), Worker.worker_Code
From Worker LEFT JOIN Ordering
ON Worker.worker_Code = Ordering.Manager
Group by Worker.FirstName, Worker.LastName, Worker.worker_Code, Ordering.Code_Of_Ordering


------------------------------Except/Intersect------------------------------
SELECT FirstName
From Client
Except Select FirstName
From Worker

SELECT MiddleName
From Client
Intersect Select MiddleName
From Worker

------------------------------UNION------------------------------

SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS FullName
FROM Client
UNION SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS EmployeeName 
FROM Worker
ORDER BY FullName

------------------------------Exist/ALL------------------------------
SELECT *
FROM Client
WHERE EXISTS (SELECT * FROM Ordering 
                  WHERE Ordering.Client_Code = Client.Client_Code)


SELECT * FROM Car
WHERE Year_of_manufacture_of_the_Car < ALL(SELECT Year_of_manufacture_of_the_Car FROM Car WHERE Car_Manufacturer='Audi')




----------------------------------Views-----------------------------------
use CTO
CREATE VIEW Orderings_for_Clients_cars AS
SELECT Worker.FirstName + ' ' + Worker.LastName as Worker_Name,
		Ordering.Manager AS ManagerNumber, 
        Client.FirstName + ' ' + Client.LastName AS Client_Name,
		Client.Client_Code as Code_Client
FROM Worker
Inner Join Ordering on Worker.worker_Code = Ordering.Manager
INNER JOIN Client ON Ordering.Client_Code = Client.Client_Code

drop view Orderings_for_Clients_cars
Select *From Orderings_for_Clients_cars

CREATE VIEW Orderings_for_Clients_cars1 AS
SELECT Client.Client_Code AS Client_Number, 
        Car.Car_Manufacturer + ' ' + Car.Car_Model As Automobile  
From Client
INNER JOIN Car ON Client.Client_Code = Car.Client_code

drop view Orderings_for_Clients_cars1
Select *From Orderings_for_Clients_cars1

Select Orderings_for_Clients_cars.Worker_Name,
		Orderings_for_Clients_cars.ManagerNumber,
		Orderings_for_Clients_cars.Client_Name,
		Orderings_for_Clients_cars1.Client_Number,
		Orderings_for_Clients_cars1.Automobile
From Orderings_for_Clients_cars1
Left Join Orderings_for_Clients_cars on Orderings_for_Clients_cars.Code_Client = Orderings_for_Clients_cars1.Client_Number


----------------------------------Procedure-----------------------------------
GO
use CTO
Create Proc Number_Of_Works_Performed_By_The_Worker
@Worker_Code int = null,
@Count int output-- = null
AS
Begin
	Select @Count = COUNT (*) From List_of_works Where List_of_works.worker_Code = @Worker_Code
	IF @count = 0
		Begin
		Print 'Даний робітник не отримував закази'
		End;
		Else
		Select COUNT (*) as Count_of_Works, @Worker_Code as worker_Code
			From List_of_works
			Where List_of_works.worker_code = @Worker_Code
End;

EXEC Number_Of_Works_Performed_By_The_Worker 12
DROP PROCEDURE Number_Of_Works_Performed_By_The_Worker
-------------------------------------------------------------------------------
Create Proc Get_Count_Of_Works AS
Declare @Price money
Select @Price = AVG(price)
From List_of_spare__parts
Return @Price;

Declare @Result_of_AVG money
EXEC @Result_of_AVG = Get_Count_Of_Works
Print @Result_of_AVG
-------------------------------------------------------------------------------
Create Proc Cursor_for_test
AS
Declare @Work varchar(100), @Duration_of_Work varchar(25), @Code_of_ordering int, @Price money, @Worker_Code int
Declare my_cursor cursor for 
select work, duration_of_work, Code_of_orderings, price, worker_Code
From List_of_works
Open my_cursor
fetch next from my_cursor into @Work, @Duration_of_Work, @Code_of_ordering, @Price, @Worker_Code
While @@FETCH_STATUS = 0
begin 
Print 'Work: ' + Convert(varchar(100),@Work) + ' ' +
		'Duration_of_Work: ' + Convert(varchar(25),@Duration_of_Work) + ' ' +
		'Code_of_ordering: ' + Convert(varchar(100),@Code_of_ordering) + ' ' +
		'Price: ' + Convert(varchar(10),@Price) + ' ' +
		'Worker_Code: ' + Convert(varchar(100),@Worker_Code)
Fetch next from my_cursor into @Work, @Duration_of_Work, @Code_of_ordering, @Price, @Worker_Code
End


Exec Cursor_for_test

DEALLOCATE my_curso
Drop Proc Cursor_for_test

----------------------------------Function-----------------------------------
Go
Create Function Number_of_SsangYong()
Returns int
AS
Begin
Return (Select COUNT (*) From Car where Car.Car_Manufacturer='SsangYong')
End;

Print dbo.Number_of_SsangYong()

Drop Function Number_of_SsangYong


-------------------------------------------------------------------------------
Create function TableAboutWorks (@Manufactere_of_Car varchar(100))
	Returns Table 
	AS 
	Return(
select  Client.FirstName, Client.LastName, Ordering.Client_Code, Worker.worker_Code, Car.Car_Manufacturer, Car.Car_Model, List_of_spare__parts.type_of_spare_part
From Client
JOIN Ordering ON Ordering.Client_Code = Client.Client_Code 
JOIN Worker ON Worker.worker_Code = Ordering.Manager
Join Car ON Car.Client_code = Client.Client_Code
Join List_of_spare__parts on List_of_spare__parts.order_code = Ordering.Code_Of_Ordering
where Car.Car_Manufacturer = @Manufactere_of_Car
)

Select *From TableAboutWorks ('BMW')

Drop Function TableAboutWorks


-------------------------------------------------------------------------------
go
create trigger New_List_Of_Works
on List_of_works
after insert
as print 'Додано новий перелік робіт'

go
use CTO
insert List_of_works( work, duration_of_work, Code_of_orderings, price, worker_Code)
values
('Pad replacement', '0000-00-00 01:00:00', 25, 2000, 6)

go
create trigger Delete_List_of_Works
on List_of_works
after delete
as print 'Видалено заказ'

delete List_of_works where Code_of_orderings = 25

Go 
create trigger CTO_Example
on CTO
Instead of Delete 
AS 
Print 'Видалення неможливе'

delete CTO where CTO_ID = 1

select * from CTO

--------------------------------------------------------------------------------------
insert into Client (FirstName, MiddleName, LastName, PhoneNumber , ClientID_card, Client_Adress, Client_Code)
values ('Dmytro','Sergiyovich', 'Popov', 0993798021, 'IDUKR110004277958', 'Mykola Zakrevskoho Street, 38, Kyiv', 110)

insert into Car (Car_Manufacturer, Car_Model, Year_of_manufacture_of_the_Car, Fuel_type, Client_code, VIN_Number)
values ('Volkswagen', 'Arteon R-Line TDI', '2021-05-10', 'Diesel', 110, 'WVWZZZ4HZHG3H6633')

insert into Ordering (Client_Code, Manager, Code_Of_Ordering, VIN_number)
values (110, 3, 136, 'WVWZZZ4HZHG3H6633')

Delete List_of_works
Where Code_of_orderings = 15

select *from Ordering

select *from Car

GO
Create Trigger New_List_Of_Work_for_Washing_Car
ON Ordering
After Insert
AS
insert into List_of_works (work, duration_of_work, Code_of_orderings, price, worker_Code)
Select work = 'Washing Car', '0000-00-00 00:10:00', inserted.Code_Of_Ordering, 200, 11
From inserted

insert into List_of_works (duration_of_work, Code_of_orderings, price, worker_Code)
values ('0000-00-00 00:10:00', 55, 200, 11)

drop trigger New_List_Of_Work_for_Washing_Car

select * from List_of_works
--------------------------------------------------------------------------------------
GO
Create Trigger New_List_Of_Work_for_Washing_Car2
ON List_of_works
After Insert, update
AS
update List_of_works
Set work = 'Washing Car'
Where Code_of_orderings = (Select Code_of_orderings From inserted)

--------------------------------------------------------------------------------------

go
create procedure addOrdering
@Client_Code int,
@Manager int,
@Code_of_ordering int,
@VIN_Numbers varchar (50)
as
insert into Ordering(Client_Code, Manager, Code_Of_Ordering, VIN_number)
values(@Client_Code, @Manager, @Code_of_ordering, @VIN_Numbers)

drop procedure addOrdering

go
create procedure addList_of_works
@Code int,
@work varchar (100),
@duration_of_work date,
@price money,
@Code_of_orderings int,
@worker_Code int
as
insert into List_of_works(Code, work, duration_of_work, Code_of_orderings, price, worker_Code)
values(@Code, @work, @duration_of_work, @Code_of_orderings, @price, @worker_Code)

drop procedure addList_of_works

use CTO

select *from Ordering

select *from List_of_works