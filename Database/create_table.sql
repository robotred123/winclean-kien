create database WinClean
go
use WinClean
go
-- danh muc don vi cap BTL
Create table Donvi_cap1
(
	Units_c1 Varchar(30) NOT NULL,
	Ten_donvi Nvarchar(200) NOT NULL,
	Dia_chi Nvarchar(max) NULL,
	ngayup Datetime NOT NULL,
Primary Key (Units_c1)
)
go
insert into Donvi_cap1 values ('CQBQP', N'Cơ quan Bộ Quốc Phòng', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('BTTM', N'Bộ Tổng Tham Mưu', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('TCCT', N'Tổng Cục Chính Trị', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('TCHC', N'Tổng Cục Hậu Cần', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('TCKT', N'Tổng Cục Kỹ Thuật', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('TCCNQP', N'Tổng Cục Công Nghiệp Quốc Phòng', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('QK1', N'Quân Khu 1', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('QK2', N'Quân Khu 2', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('QK3', N'Quân Khu 3', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('QK4', N'Quân Khu 4', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('QK5', N'Quân Khu 5', N'Đà Nẵng','2022-06-20 10:20')
insert into Donvi_cap1 values ('QK7', N'Quân Khu 7', N'Đồng Nai','2022-06-20 10:20')
insert into Donvi_cap1 values ('QK9', N'Quân Khu 9', N'Cà Mau','2022-06-20 10:20')
insert into Donvi_cap1 values ('QD1', N'Quân Đoàn 1', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('QD2', N'Quân Đoàn 2', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('QD3', N'Quân Đoàn 3', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('QD4', N'Quân Đoàn 4', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('QCHQ', N'Quân Chủng Hải Quân', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('QCPKKQ', N'Quân Chủng Phòng Không Không Quân', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('BCPB', N'Binh Chủng Pháo Binh', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('BCCB', N'Binh Chủng Công Binh', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('BCDC', N'Binh Chủng Đặc Công', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('BCTTG', N'Binh Chủng Tăng Thiết Giáp', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('BCHH', N'Binh Chủng Hóa Học', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('BCTTLL', N'Binh Chủng Thông Tin Liên Lạc', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('BTLTD', N'Bộ Tư Lệnh Thủ Đô', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('BTL86', N'Bộ Tư Lệnh 86', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('BTLBDBP', N'Bộ Tư Lệnh Bộ Đội Biên Phòng', N'Hà Nội','2022-06-20 10:20')
insert into Donvi_cap1 values ('BTLCSB', N'Bộ Tư Lệnh Cảnh Sát Biển', N'Hà Nội','2022-06-20 10:20')
go
-- danh muc don vi cap Su_Lu_BCHQS
Create table Donvi_cap2
(
	Units_c2 Varchar(30) NOT NULL,
	Units_c1 Varchar(30) NOT NULL,
	Ten_donvi Nvarchar(200) NOT NULL,
	Dia_chi Nvarchar(max) NULL,
	ngayup Datetime NOT NULL,
Primary Key (Units_c2)
) 
go
alter table Donvi_cap2 with check add constraint fk_donvi_cap1 foreign key (Units_c1) references Donvi_cap1(Units_c1)
go
-- danh muc don vi cap trung_BanCHQS
Create table Donvi_cap3
(
	Units_c3 Varchar(30) NOT NULL,
	Units_c2 Varchar(30) NOT NULL,
	Ten_donvi Nvarchar(200) NOT NULL,
	Dia_chi Nvarchar(max) NULL,
	ngayup Datetime NOT NULL,
Primary Key (Units_c3)
) 
go
alter table Donvi_cap3 with check add constraint fk_donvi_cap2 foreign key (Units_c2) references Donvi_cap2(Units_c2)
go
-- danh muc don vi cap Xa_phuong
Create table Donvi_cap4
(
	Units_c4 Varchar(30) NOT NULL,
	Units_c3 Varchar(30) NOT NULL,
	Ten_donvi Nvarchar(200) NOT NULL,
	Dia_chi Nvarchar(max) NULL,
	ngayup Datetime NOT NULL,
Primary Key (Units_c4)
) 
go
alter table Donvi_cap4 with check add constraint fk_donvi_cap3 foreign key (Units_c3) references Donvi_cap3(Units_c3)
go
-- danh muc Policy
CREATE TABLE Policy_WinClean
(
	ID varchar(30) PRIMARY KEY NOT NULL,
	Name_policy nvarchar(1000) NOT NULL,
	Name_scripts nvarchar(1000) NOT NULL,
	Details nvarchar(max) NOT NULL,
	bool_policy varchar(10) not null
)
go
-- danh muc can bo
CREATE TABLE Dm_Canbo
(
	MaCB varchar(100) PRIMARY KEY NOT NULL,
	Units_c1 Varchar(30),
	Units_c2 Varchar(30),
	Units_c3 Varchar(30),
	Units_c4 Varchar(30),
	Hoten nvarchar(1000) NULL,
	Computer_name varchar(500) NOT NULL,
	MAC varchar(30) NOT NULL,
	Position nvarchar(200) NULL,
	Auto_start varchar(30) NULL
)
go
-- danh sach tai khoan login
CREATE TABLE Account
(
	Ma int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Login_frm nvarchar(max) NULL,
	nhom_user varchar(200) NOT NULL,
	username varchar(500) NULL,
	password_ varchar(500) NULL,
	password_2 varchar(500) NULL,
	MaCB varchar(100) NOT NULL
)
GO
ALTER TABLE Account WITH CHECK ADD  CONSTRAINT fk_account_ma FOREIGN KEY(MaCB) REFERENCES Dm_Canbo (MaCB)
GO
-- chi tiet thuc thi lenh theo MAC
CREATE TABLE Details_Clean
(
	Ma int IDENTITY(1,1)PRIMARY KEY NOT NULL,
	MAC varchar(30) not NULL,
	Details_ID varchar(1000) NULL,
	Time_Implement varchar(20) NULL,
	Time_Stop varchar(20) NULL,
	ngayup varchar(20)
)
GO
-- nhat ky thuc thi tung policy
CREATE TABLE Log_Status
(
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Status_ID nvarchar(1000) NULL,
	Details nvarchar(max) NULL,
	Ma int NULL,
	Trangthai nvarchar(100) NULL
)
GO
ALTER TABLE Log_Status  WITH CHECK ADD  CONSTRAINT fk_Details_Clean_ma FOREIGN KEY(Ma) REFERENCES Details_Clean (Ma)
GO
-- nhat ky tai khoan
CREATE TABLE Log_account
(
	Event_ nvarchar(max) NOT NULL,
	_insert nvarchar(max) NULL,
	_update nvarchar(max) NULL,
	_delete nvarchar(max) NULL,
	MaCB varchar(100) NOT NULL,
	ngayup varchar(max) NULL
)
GO
ALTER TABLE Log_account  WITH CHECK ADD  CONSTRAINT fk_log_account_macb FOREIGN KEY(MaCB) REFERENCES Dm_Canbo (MaCB)
GO
-- nhat ky cap nhat version PM
CREATE TABLE Update_App
(
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Versions nvarchar(500) NULL,
	Time_update varchar(20) NULL,
	Log_Update nvarchar(max) NULL,
	ID_Account int NULL 
)
GO
ALTER TABLE Update_App  WITH CHECK ADD  CONSTRAINT fk_Acc_app_id FOREIGN KEY(ID_Account) REFERENCES Account (MA)
GO
-- tự động thuc thi lenh
create table Start_Policy
(
	Ma int IDENTITY(1,1) not null,
	ID_Policy varchar(max),
	date_start varchar(50)
)
go
/* check computer online
create table Dm_IP
(
	ID int IDENTITY(1,1) not null,
	MaCB varchar(100) NOT NULL,
	IpAddress varchar(200),
	MAC varchar(100) unique,
	Computer_Name nvarchar(900),
	_start nvarchar(10)
)
go
ALTER TABLE Dm_IP  WITH CHECK ADD  CONSTRAINT fk_Dm_IP_macb FOREIGN KEY(MaCB) REFERENCES Dm_Canbo (MaCB)
go
-- them du lieu danh muc IP ping
create procedure sp_insert_Dm_IP
	@MaCB varchar(100),
	@IpAddress varchar(200),
	@MAC varchar(100),
	@Computer_Name nvarchar(900),
	@_start varchar(10)
as
begin
	set nocount on;
	INSERT INTO Dm_IP(MaCB,IpAddress,MAC,Computer_Name,_Start)
	VALUES (@MaCB,@IpAddress,@MAC,@Computer_Name,@_Start)
end
-- cap nhat du lieu danh muc ping
go
create procedure sp_Update_Dm_IP
	@ID int,
	@IpAddress varchar(200),
	@MAC varchar(100),
	@Computer_Name nvarchar(900),
	@_Start varchar(10)
as
begin
	set nocount on;
	UPDATE Dm_IP SET IpAddress = @IpAddress, Computer_Name = @Computer_Name, _Start = @_Start WHERE ID = @ID and MAC = @MAC
end
-- truy van du lieu danh muc ping
go
create procedure sp_Select_Dm_IP
	@MAC varchar(100)
as
begin
	set nocount on;
	SELECT ID, MaCB,IpAddress,MAC,Computer_Name,_Start FROM Dm_IP WHERE MAC = @MAC
end
go
-- Log ping
create table Log_ping
(
	MAC varchar(100),
	Time_StartPing varchar(100),
	Event_StartPing nvarchar(max),
	Time_StopPing varchar(100),
	Event_StopPing nvarchar(max),
	Time_UpdatePing varchar(100),
	Event_UpdatePing nvarchar(max),
	ngayup varchar(100)
)
go
ALTER TABLE Log_ping  WITH CHECK ADD  CONSTRAINT fk_mac FOREIGN KEY(MAC) REFERENCES Dm_IP (MAC)
-- them du lieu Log_ping
GO
create procedure sp_insert_Log_ping
	@MAC varchar(100),
	@Time_StartPing varchar(100),
	@Event_StartPing nvarchar(max),
	@Time_StopPing varchar(100),
	@Event_StopPing nvarchar(max),
	@Time_UpdatePing varchar(100),
	@Event_UpdatePing nvarchar(max),
	@ngayup varchar(100)
as
begin
	set nocount on;
	INSERT INTO Log_ping (MAC,Time_StartPing,Event_StartPing,Time_StopPing,Event_StopPing,Time_UpdatePing,Event_UpdatePing,ngayup)
	VALUES (@MAC,@Time_StartPing,@Event_StartPing,@Time_StopPing,@Event_StopPing,@Time_UpdatePing,@Event_UpdatePing,@ngayup)
end
-- cap nhat du lieu Log_ping
go
create procedure sp_Update_Log_ping
	@MAC varchar(100),
	@Time_StopPing varchar(100),
	@Event_StopPing nvarchar(max),
	@Time_UpdatePing varchar(100),
	@Event_UpdatePing nvarchar(max),
	@ngayup varchar(100)
as
begin
	set nocount on;
	UPDATE Log_ping SET Time_StopPing = @Time_StopPing, Event_StopPing = @Event_StopPing, Time_UpdatePing = @Time_UpdatePing, Event_UpdatePing = @Event_UpdatePing WHERE MAC = @MAC and ngayup = @ngayup
end
-- truy van du lieu dm_ping and Log Ping
go
create procedure sp_Select_MAC
	@MAC varchar(100),
	@Ngayup varchar(100)
as
begin
	set nocount on;
	SELECT dm.MAC,IpAddress,lg.ngayup
	FROM Dm_IP dm inner join Log_ping lg on dm.MAC=lg.MAC 
	WHERE lg.MAC = @MAC and lg.ngayup = @Ngayup
end
-- truy van du lieu ping
go
create procedure sp_Select_Ping
	@Ngayup varchar(100)
as
begin
	set nocount on;
	SELECT ID,MaCB,IpAddress,dm.MAC,Computer_Name,Time_StartPing,Event_StartPing,Time_UpdatePing,Event_UpdatePing,Time_StopPing,Event_StopPing
	FROM Dm_IP dm inner join Log_ping lg on dm.MAC=lg.MAC 
	WHERE lg.ngayup = @Ngayup
end
-- truy van du lieu ping
go
create procedure sp_Select_Check_Ping
	@Ngayup varchar(100)
as
begin
	set nocount on;
	SELECT ID,MaCB,IpAddress,dm.MAC,Computer_Name,Time_StartPing,Event_StartPing,Time_UpdatePing,Event_UpdatePing,Time_StopPing,Event_StopPing
	FROM Dm_IP dm inner join Log_ping lg on dm.MAC=lg.MAC 
	WHERE lg.ngayup = @Ngayup and Event_StopPing != N'Shutdown máy'
end
GO
*/