-- SP truy van danh muc don vi cap 1
create procedure sp_Select_Dv_cap1
as
begin
	set nocount on;
	SELECT Units_c1,Ten_donvi,Dia_chi,ngayup FROM Donvi_cap1
end
GO
-- SP truy van danh muc don vi cap 2
create procedure sp_Select_Dv_cap2
	@Units_c1 varchar(30)
as
begin
	set nocount on;
	SELECT Units_c2,Ten_donvi,Dia_chi,ngayup FROM Donvi_cap2 where Units_c1 = @Units_c1
end
GO
-- SP truy van danh muc don vi cap 3
create procedure sp_Select_Dv_cap3
	@Units_c2 varchar(30)
as
begin
	set nocount on;
	SELECT Units_c3,Ten_donvi,Dia_chi,ngayup FROM Donvi_cap3 where Units_c2 = @Units_c2
end
GO
-- SP truy van danh muc don vi cap 4
create procedure sp_Select_Dv_cap4
	@Units_c3 varchar(30)
as
begin
	set nocount on;
	SELECT Units_c4,Ten_donvi,Dia_chi,ngayup FROM Donvi_cap4 where Units_c3 = @Units_c3
end
GO
-- SP truy van ma can bo
create procedure sp_Select_Ma_Canbo
as
begin
	set nocount on;
	SELECT MaCB FROM Dm_Canbo
end
GO
-- SP truy van danh muc can bo
create procedure sp_Select_Dm_canbo
	@MAC varchar(30)
as
begin
	set nocount on;
	SELECT MaCB,c1.Ten_donvi as dv_cap1,c2.Ten_donvi as dv_cap2,c3.Ten_donvi as dv_cap3,c4.Ten_donvi as dv_cap4,Hoten,Computer_name,MAC,Position,Auto_start FROM Dm_Canbo cb inner join Donvi_cap1 c1 on cb.Units_c1=c1.Units_c1 inner join Donvi_cap2 c2 on cb.Units_c2=c2.Units_c2 inner join Donvi_cap3 c3 on cb.Units_c3=c3.Units_c3 inner join Donvi_cap4 c4 on c4.Units_c4=cb.Units_c4 where cb.MAC = @MAC
end
GO
-- SP them du lieu danh muc can bo
create procedure sp_insert_Dm_Canbo
	@MaCB varchar(100),
	@Units_c1 varchar(30),
	@Units_c2 varchar(30),
	@Units_c3 varchar(30),
	@Units_c4 varchar(30),
	@Hoten nvarchar(1000),
	@Computer_name varchar(500),
	@MAC varchar(30),
	@Position nvarchar(200),
	@Auto_start varchar(30)
as
begin
	set nocount on;
	INSERT INTO Dm_Canbo(MaCB,Units_c1,Units_c2,Units_c3,Units_c4,Hoten,Computer_name,MAC,Position,Auto_start)
	VALUES (@MaCB,@Units_c1,@Units_c2,@Units_c3,@Units_c4,@Hoten,@Computer_Name,@MAC,@Position,@Auto_Start)
end
GO
-- SP Cap nhat du lieu danh muc can bo
create procedure sp_Update_Dm_Canbo
	@MaCB varchar(100),
	@Units_c1 varchar(30),
	@Units_c2 varchar(30),
	@Units_c3 varchar(30),
	@Units_c4 varchar(30),
	@Hoten nvarchar(1000),
	@Computer_name varchar(500),
	@MAC varchar(30),
	@Position nvarchar(200),
	@Auto_start varchar(30)
as
begin
	set nocount on;
	UPDATE Dm_Canbo SET Hoten = @Hoten, Units_c1 = @Units_c1, Units_c2 = @Units_c2, Units_c3 = @Units_c3, Units_c4 = @Units_c4, Computer_name = @Computer_name, Position = @Position, Auto_Start = @Auto_start WHERE MaCB = @MaCB and MAC = @MAC
end
GO
-- SP load du lieu Policy
create procedure sp_Policy
as
set nocount on;
select ID,Name_policy,Name_scripts,Details,bool_policy
from Policy_WinClean where bool_policy != 'False'
order by ID asc
GO
-- SP them du lieu Details_Clean
create procedure sp_insert_Details_Clean
	@MAC varchar(30),
	@Details_ID varchar(1000),
	@Time_Implement varchar(20),
	@Time_Stop varchar(20),
	@ngayup varchar(20)
as
begin
	set nocount on;
	INSERT INTO Details_Clean(MAC,Details_ID,Time_Implement,Time_Stop,ngayup)
	VALUES (@MAC,@Details_ID,@Time_Implement,@Time_Stop,@ngayup)
end
GO
-- SP truy van du lieu Details_Clean
create procedure sp_select_Details_Clean
	@MAC varchar(30),
	@Details_ID varchar(1000),
	@ngayup varchar(20)
as
set nocount on;
select Ma, MAC, Details_ID,ngayup
from Details_Clean where MAC = @MAC and Details_ID = @Details_ID and ngayup = @ngayup
GO
-- SP Cap nhat du lieu chi tiet
create procedure sp_Update_Details_Clean
	@MAC varchar(30),
	@Details_ID varchar(1000),
	@Time_Implement varchar(20),
	@Time_Stop varchar(20),
	@ngayup varchar(20)
as
begin
	set nocount on;
	UPDATE Details_Clean SET Time_Implement = @Time_Implement, Time_Stop = @Time_Stop WHERE MAC = @MAC  and Details_ID = @Details_ID and ngayup = @ngayup
end
GO
-- SP them du lieu Log_Status
create procedure sp_insert_Log_Status
	@Status_ID nvarchar(1000),
	@Details nvarchar(max),
	@Ma int,
	@Trangthai nvarchar(100)
as
begin
	set nocount on;
	INSERT INTO Log_Status(Status_ID,Details,Ma,Trangthai)
	VALUES (@Status_ID,@Details,@Ma,@Trangthai)
end
GO
-- SP truy van du lieu Log_Status
create procedure sp_select_Log_Status
	@Status_ID nvarchar(1000),
	@Ma int
as
set nocount on;
select ID,Status_ID,Details,Ma,Trangthai
from Log_Status where Ma = @Ma and Status_ID = @Status_ID
GO
-- SP Cap nhat log thuc thi
create procedure sp_Update_Log_Status
	@ID int,
	@Status_ID nvarchar(1000),
	@Details nvarchar(max),
	@Ma int,
	@Trangthai nvarchar(100)
as
begin
	set nocount on;
	UPDATE Log_Status SET Status_ID = @Status_ID, Details = @Details, Trangthai = @Trangthai WHERE ID = @ID and Ma = @Ma
end
GO
-- truy van thu thi lenh theo ngay
create procedure sp_Select_Start_Policy
	@date_start varchar(50)
as
begin
	set nocount on;
	SELECT ID_Policy,date_start
	FROM Start_Policy
	WHERE date_start = @date_start
end
go
-- SP load du lieu auto Policy
create procedure sp_Auto_Policy
	@ID varchar(30)
as
set nocount on;
select ID,Name_policy,Name_scripts,Details,bool_policy
from Policy_WinClean where ID = @ID
GO