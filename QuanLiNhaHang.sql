create database QuanLiNhaHang
use QuanLiNhaHang
go

create table TableFood
( 
	id int identity primary key,
	name nvarchar(100) not null default N'Bàn chưa có tên',
	status nvarchar(100) not null default N'Trống' 
)
go

create table account
(
	DisplayName nvarchar(100) not null,
	UserName nvarchar(100) not null primary key,
	Password nvarchar (100) default '0',
	type int not null
)
go

create table FoodCategory
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
)
go

create table Food
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null

	foreign key (idCategory) references dbo.FoodCategory(id)
)
go

--thêm số lượng vào Talbe Food
alter table dbo.Food
add quantity int   ----- số lượng 
go

create table Bill
(
	id int identity primary key,
	DateCheckin date not null default getdate(),
	DateCheckout date,
	idTable int not null,
	status int	not null default 0  --mac dinh chua thanh toan   1:thanh toan || 0:chua thanh toan
	foreign key (idTable) references dbo.TableFood(id)
)
go

create table BillInfor
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0  --so luong do an, mac dinh la 0
	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)
)
go

----chèn vào bill trường discount
alter table dbo.Bill
add discount int 
go
---Thêm trường tổng tiền vào dbo.Bill
alter table dbo.Bill add  totalPrice float
go

-----------------------------------------------------------------------------------------------------
insert into dbo.account(DisplayName,Username,Password,type)
values(N'admin',
	   N'admin',
	   N'admin',
	   1)

select * from Bill
insert into dbo.Bill (id,DateCheckin,DateCheckout,idTable,status,discount,totalPrice)
values(1,'20230707','20230808',1,1,50,100000 )
--insert dbo.TableFood
set identity_insert dbo.Bill on   -------------set về on thì mới insert được, tương tự bảng dưới cũng thế mà phải off cái này rồi mới on cái kia được 
insert into dbo.TableFood(id,name,status)
values
(1,N'Bàn 1',N'Trống'),
(2,N'Bàn 2',N'Trống'),
(3,N'Bàn 3',N'Trống'),
(4,N'Bàn 4',N'Trống'),
(5,N'Bàn 5',N'Trống'),
(6,N'Bàn 6',N'Trống'),
(7,N'Bàn 7',N'Trống'),
(8,N'Bàn 8',N'Trống'),
(9,N'Bàn 9',N'Trống'),
(10,N'Bàn 10',N'Trống'),
(11,N'Bàn 11',N'Trống'),
(12,N'Bàn 12',N'Trống')
 
 -------------------------------------------
set identity_insert dbo.FoodCategory on
insert into dbo.FoodCategory(id,name) 
values (1,N'Đặc sản miền biển'),
		(2,N'Đặc sản vùng cao'),
		(3,N'Đặc sản vùng đồng bằng'),
		(4,N'Nước'),
		(5,N'Rượu'),
		(6,N'Bia')

-----Thêm Food(món ăn)-------------------------------------------------
insert dbo.Food(name, idCategory, price)
values 
(N'Cua Hoàng Đé',1,5000000),
(N'Cua Cà Mau',1,300000),
(N'Ghẹ Đồ Sơn',1,400000),
(N'Tôm hùm Alaska',1,2000000),
(N'Sò huyết hấp',1,100000),
(N'Ốc hương sốt trứng muối',1,150000),
(N'Cá hồi',1,250000),
(N'Vi cá mập',1,3000000),
(N'Mực xào sả ớt',1,200000),

(N'Nậm pịa',2,50000),
(N'Lợn cắp nách',2,300000),
(N'Cá nhảy',2,50000),
(N'Xôi ngũ sắc',2,100000),
(N'Cơm lam',2,100000),
(N'Thịt trâu gác bếp',2,150000),
(N'Thắng cố ngựa',2,200000),
(N'Bê chao Mộc Châu',2,200000),
(N'Cá hồi SaPa',2,250000),
(N'Gỏi cá bỗng sông Gâm',2,150000),
(N'Cá bống vùi tro',2,150000),
(N'Khâu nhục',2,200000),

(N'Cá trắm hấp bia',3,250000),
(N'Vịt om sấu',3,150000),
(N'Ba ba rang muối',3,200000),
(N'Gà rang muối',3,150000),
(N'Ngô chiên',3,50000),
(N'Lẩu gà',3,250000),
(N'Lẩu cá',3,250000),
(N'Gà không lối thoát',3,200000),
(N'Chim câu chiên giòn',3,150000),
(N'Bò xào',3,200000),
(N'Vịt tái chanh',3,150000),
(N'Tôm sú hấp',3,250000),
(N'Cá quả nướng',3,150000),

(N'Nước lọc',4,10000),
(N'Pepsi',4,15000),
(N'Coca',4,15000),
(N'SevenUp',4,15000),
(N'Nước cam ép',4,15000),
(N'Nước dưa hấu ép',4,15000),

(N'Rượu táo mèo',5,50000),
(N'Rượu cần',5,70000),
(N'Rượu mơ',5,50000),
(N'Rượu ngô',5,40000),
(N'Rượu đế',5,30000),

(N'Bia Hà Nội',6,15000),
(N'Bia Sài Gòn',6,15000),
(N'Bia Tiger',6,15000),
(N'Bia Heineken',6,15000),
(N'Bia 333',6,15000)
go

create proc USP_getAcccountByUsername
@userName nvarchar(100)
as
begin
	select * from  dbo.account where UserName = @userName
end
go

-- hạn chế lỗi sql injnection
create proc USP_Login
@username nvarchar(100), @password nvarchar(100)
as 
begin
	select * from dbo.account where UserName = @username and Password = @password
end
go

-------------------------
create proc USP_GetTableList
as select * from dbo.TableFood
go

------ham them Bill
create proc USP_InsertBill
@idTable int
as
begin
	insert dbo.Bill(DateCheckin,DateCheckout,idTable,status,discount)
	values (getdate(),null,@idTable,0,0)
end
go


------ham them BillInfor
alter proc USP_InsertBillInfor
@idBill int,@idFood int,@count int
as	
begin
	declare @soluong int
	select @soluong = quantity from Food where id = @idFood
	declare @isExistsBillInfor int;
	declare @foodCount int = 1
	select @isExistsBillInfor = id, @foodCount = BillInfor.count
	from dbo.BillInfor 
	where idBill = @idBill and idFood = @idFood

	if (@isExistsBillInfor > 0)
	begin
			declare @newCount int = @foodCount + @count
			if(@newCount > 0)
				update dbo.BillInfor set count = @foodCount + @count where idFood = @idFood
			else
				delete dbo.BillInfor where idBill = @idBill and idFood = @idFood
	end
	else
	begin
			insert dbo.BillInfor(idBill,idFood,count)
			values (@idBill,@idFood,@count)
	end	
	-------trừ số lượng món ăn khi order đồ ăn -----
	if   @soluong >= @count
	begin
		UPDATE dbo.Food
		SET quantity = quantity - @count
		WHERE id = @idFood
	end
	else rollback transaction
end
go
----


 ----tạo trigger sau khi thêm món ăn thì TableFood.status = 1 (có người) và ngược lại
 ---khi thêm món ăn thì bảng inserted sẽ được sinh ra
create trigger UTG_UpdateBillInfor
on dbo.BillInfor for insert, update
as
begin
	declare @idBill int 
	select @idBill = idBill from inserted
	declare @idTable int
	select @idTable = idTable from  dbo.Bill where id = @idBill and status = 0
	declare @count int
	select @count = count(*) from dbo.BillInfor where idBill = @idBill
	if(@count > 0 )
		update dbo.TableFood set status = N'Có người' where id = @idTable
	else 
		update dbo.TableFood set status = N'Trống' where id = @idTable
end
go
-------


---tạo trigger sau khi ấn thanh toán thì bàn sẽ chuyển sang table.status = 0 (nghĩa là trống)
-- trigger này sẽ đếm các bản ghi trong dbo.Bill nếu không có bản ghi nào sẽ set bàn được chọn thành trống
create trigger UTG_UpdateBill
on dbo.Bill for update
as
begin
	declare @idBill int 
	select @idBill = id  from  inserted
	declare @idTable int
	select @idTable = idTable from  dbo.Bill where id = @idBill 
	declare @count int = 0
	select count(*) from dbo.Bill where idTable = @idTable and status = 0
	if (@count = 0)
		update  dbo.TableFood set status = N'Trống' where id = @idTable
end
go



---hàm chuyển bàn 
create proc USP_ChuyenBan
@idTable1 int, @idTable2 int
as 
begin
	declare @idFirstBill int
	declare @idSecondBill int
	declare @isFirstTableEmpty int = 1
	declare @isSecondTableEmpty int = 1

	select @idSecondBill = id from dbo.Bill where idTable = @idTable2 and status = 0
	select @idFirstBill = id from dbo.Bill where idTable = @idTable1 and status = 0

	if(@idFirstBill is null)  --khi so sánh với null dùng 'is' chứ không phải '='
	begin
		insert dbo.Bill(DateCheckin,DateCheckout,idTable,status)
		values (getdate(),null,@idTable1,0)
		select @idFirstBill = MAX(id) from  dbo.Bill where idTable = @idTable1 and status = 0
	end

	select @isFirstTableEmpty = count(*) from dbo.BillInfor where idBill = @idFirstBill
	if(@idSecondBill is null)
	begin
		insert dbo.Bill(DateCheckin,DateCheckout,idTable,status)
		values (getdate(),null,@idTable2,0)
		select @idSecondBill = MAX(id) from  dbo.Bill where idTable = @idTable2 and status = 0
		
	end
	select  @isSecondTableEmpty = count(*) from dbo.BillInfor where idBill = @isSecondTableEmpty
	select id into IDBillInforTable from dbo.BillInfor where idBill = @idSecondBill
	update dbo.BillInfor set idBill = @idSecondBill where idBill = @idFirstBill
	update dbo.BillInfor set idBill = @idFirstBill where id in (select * from IDBillInforTable)
	drop table IDBillInforTable
	if(@isFirstTableEmpty = 0)
		update dbo.TableFood set status = N'Trống' where id = @idTable2
	if(@isSecondTableEmpty = 0)
		update dbo.TableFood set status = N'Trống' where id = @idTable1
end
go


------tạo hàm thống kê hóa đơn theo ngày checkin và checkout
create proc USP_GetListBillByDate
@dateCheckIn date, @DateCheckOut date
as
begin
	select TableFood.name, Bill.totalPrice , DateCheckin,DateCheckout,discount 
	from Bill, dbo.TableFood
	where DateCheckin >= @dateCheckIn  and DateCheckout<= @DateCheckOut and Bill.status = 1 and TableFood.id = Bill.idTable 
end
go
select * from Bill
USP_GetListBillByDate '2023-01-01','2023-12-31'

------hàm thay đổi mật khẩu(passWord) và tên hiển thị(DisplayName)
create proc USP_UpdateAccount
@userName nvarchar(100), @displayName nvarchar(100), @password nvarchar(100), @newPassword nvarchar(100)
as
begin
	declare @isRightPass int = 0
	select @isRightPass = count(*) from dbo.account where UserName = @userName and Password = @password
	if (@isRightPass = 1)
	begin 
		if (@newPassword = null or  @newPassword = '')
			begin
			update dbo.account set DisplayName = @displayName where UserName = @userName
			end
		else
			begin
			update dbo.account set DisplayName = @displayName,Password = @newPassword where UserName = @userName
			end
	end
end
go

------

create trigger UTG_DeleteBillInfor
on dbo.BillInfor for delete
as
begin
	declare @idBillInfor int
	declare @idBill int
	select @idBillInfor = id,@idBill = deleted.idBill from deleted
	
	declare @idTable int
	select @idTable = idTable from dbo.Bill where id = @idBill

	declare @count int = 0
	select @count = count(*) from dbo.BillInfor as bi, dbo.Bill as b where b.id = bi.idBill and b.id  = @idBill and b.status = 0
	
	if (@count = 0)
		update dbo.TableFood set status = N'Trống' where  id = @idTable
end
go






