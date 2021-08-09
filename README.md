# LTCSDL-IT81-EF
Môn Lập trình Cơ Sở Dữ Liệu
HK 3, năm học 2020-2021
Trường Đại học Mở TP.HCM

Đây là project mẫu chạy trên nền tảng **Dotnet Core**, 
* Sử dụng **Console** kết hợp **Enity Framwork Core** để hỗ trợ kết nối CSDL 
* Project này sử dụng Entity Framework Core, kết nối đến database [Northwind](https://laptrinhthietde.wordpress.com/2017/08/09/co-so-du-lieu-northwind/) của Mircosoft

Câu lệnh để cài Entity Framwork từ **Nuget Console**
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Scaffold-DbContext "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=Password123;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
