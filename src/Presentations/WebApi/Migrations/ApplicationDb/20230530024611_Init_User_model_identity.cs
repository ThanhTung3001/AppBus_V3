using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations.ApplicationDb
{
    public partial class Init_User_model_identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authorize",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsAuthorize = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueId = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ValueName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Introduce = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoID = table.Column<int>(type: "int", nullable: true),
                    ImageID = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Open_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Lattitude = table.Column<double>(type: "float", nullable: true),
                    Longtidute = table.Column<double>(type: "float", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "date", nullable: true),
                    UpdateByID = table.Column<int>(type: "int", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    IsDaily = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    EventTime = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsAvatar = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HB_CauHinh",
                columns: table => new
                {
                    ID = table.Column<byte>(type: "tinyint", nullable: false),
                    PhanAnhHienTruong = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((1440))", comment: "Thời gian đồng bộ dữ liệu phản ánh hiện trường (đơn vị: phút). "),
                    TienIchXungQuanh = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((1440))", comment: "Thời gian đồng bộ dữ liệu tiện ích xung quanh (đơn vị: phút). ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_CauHinh", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HB_Customer",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false),
                    UpdateByID = table.Column<int>(type: "int", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false),
                    CreatedByID = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: false),
                    Phone = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nchar(30)", fixedLength: true, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HB_CustomerType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    UpdateByID = table.Column<int>(type: "int", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    ColorCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_CustomerType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HB_Diem",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoHieu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DiaDiem = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    HoatDong = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_Diem", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HB_DoanhNghiep",
                columns: table => new
                {
                    ID = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSoThue = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GioiThieu = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DienThoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HopThu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangChu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HoatDong = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_DoanhNghiep", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HB_EmailConfig",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Host = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Port = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_EmailConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HB_Feedback",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsReply = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_Feedback", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HB_FeedbackReplyTemplate",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IsActive = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_FeedbackReplyTemplate", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HB_TicketType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UpdateByID = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    Is_VeTuyen = table.Column<bool>(type: "bit", nullable: true),
                    ListEventID = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    TypeValue = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DateToExpired = table.Column<int>(type: "int", nullable: true),
                    NumberOfDayCanUse = table.Column<int>(type: "int", nullable: true),
                    ImageID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_TicketType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HB_Tuyen",
                columns: table => new
                {
                    ID = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoHieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenTuyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DiemDau = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DiemCuoi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CuLy = table.Column<decimal>(type: "decimal(6,3)", nullable: true),
                    KhungGio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TanSuat = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SoChuyen = table.Column<byte>(type: "tinyint", nullable: true),
                    HoatDong = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    SoLuotThich = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_Tuyen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PlaceID = table.Column<int>(type: "int", nullable: true),
                    EventID = table.Column<int>(type: "int", nullable: true),
                    DaiNoiID = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    UpdateByID = table.Column<int>(type: "int", nullable: true),
                    IsAvatar = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('0')"),
                    ServiceID = table.Column<int>(type: "int", nullable: true),
                    TicketTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceErrorLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fid = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true),
                    OrderId = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceErrorLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Icon = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IsActive = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    Path = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    IsLeaf = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    IsAdminTool = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('1')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MyRoles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MyUserRoles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: true),
                    TicketTypeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CustomerType = table.Column<int>(type: "int", nullable: true),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderInvoice",
                columns: table => new
                {
                    Fid = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: false),
                    OrderId = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Pattern = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Serial = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CusCode = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    BuyerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TotalAmount = table.Column<int>(type: "int", nullable: true),
                    TaxCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderInvoice", x => x.Fid);
                });

            migrationBuilder.CreateTable(
                name: "OrderTemp",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UniqId = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsForeign = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    OrderTime = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    Serial = table.Column<int>(type: "int", nullable: true),
                    CounterId = table.Column<int>(type: "int", nullable: true),
                    IsSell = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "((1))"),
                    Remark = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PrintType = table.Column<int>(type: "int", nullable: true),
                    IsUsePosMachine = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    TaxNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    CusCode = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTemp", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentOnlineConfig",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TextValue = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsActive = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOnlineConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleEn = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    ContentEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Introduce = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateByID = table.Column<int>(type: "int", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    VideoID = table.Column<int>(type: "int", nullable: true),
                    ImageID = table.Column<int>(type: "int", nullable: true),
                    Lattitude = table.Column<double>(type: "float", nullable: true),
                    Longtidute = table.Column<double>(type: "float", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    SlideShow = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('0')"),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    ShortTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PlaceDaiNoi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Introduce = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    TitleEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubTitleEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContentEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoID = table.Column<int>(type: "int", nullable: true),
                    ImageID = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateByID = table.Column<int>(type: "int", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Type = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))"),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceDaiNoi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PromotionConfig",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FromDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    ExtendDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Rate = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionConfig", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptConfig",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaiKhoanPhatHanh = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MatKhauPhatHanh = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    TaiKhoanDichVu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MatKhauDichVu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    PublishServiceUrl = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: false),
                    PortalServiceUrl = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: false),
                    BusinessServiceUrl = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TaxNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CusCode = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptTemplateConfig",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptTemplateConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestLogger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestLogger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false),
                    UpdateByID = table.Column<int>(type: "int", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoID = table.Column<int>(type: "int", nullable: true),
                    ImageID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StatisticElement",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    UpdateByID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatisticElement", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StatisticTemplate",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IStatisticElementID = table.Column<int>(type: "int", nullable: false),
                    IS_TrinhDien = table.Column<bool>(type: "bit", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false),
                    UpdateByID = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    BaseTemplate = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatisticTemplate", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StatisticTemplate_Element",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateID = table.Column<int>(type: "int", nullable: false),
                    ElementID = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatisticTemplate_Element", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StatisticTemplate_Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatisticTemplate_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SubOrderDetail",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    OrderId = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: true),
                    TicketTypeId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    CustomerType = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrderQuantity = table.Column<int>(type: "int", nullable: true),
                    QrId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubOrderDetail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Testing",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    username = table.Column<string>(type: "nchar(32)", fixedLength: true, maxLength: 32, nullable: false),
                    password = table.Column<string>(type: "nchar(32)", fixedLength: true, maxLength: 32, nullable: false),
                    fullname = table.Column<string>(type: "nchar(64)", fixedLength: true, maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testing", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TicketCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketCategory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TicketCounter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "((1))"),
                    TicketTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketCounter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PlaceId = table.Column<int>(type: "int", nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: true),
                    ChildrenQuantity = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    AdultQuantity = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    OrderId = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: true),
                    CustomerType = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    QuantityRemain = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TicketTypeId = table.Column<int>(type: "int", nullable: true),
                    QrId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketDetail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TicketOrder",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    OrderTempId = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: true),
                    PayStatus = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('0')"),
                    IsUsed = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsForeign = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    IsCash = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('1')"),
                    PaymentId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsSell = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ReceiptId = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PayType = table.Column<int>(type: "int", nullable: true),
                    PrintType = table.Column<int>(type: "int", nullable: true, comment: "1 là in chung\r\n2 là in riêng"),
                    CounterId = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsUsePosMachine = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketOrder", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TicketPrintLog",
                columns: table => new
                {
                    OrderId = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: false),
                    PrintedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PrintedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PrintCount = table.Column<int>(type: "int", nullable: false),
                    TicketCounter = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TicketScanLog",
                columns: table => new
                {
                    OrderId = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: true),
                    PlaceId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateUse = table.Column<DateTime>(type: "datetime", nullable: false),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false),
                    IsSuccess = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeviceId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Action = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TicketTypeDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceId = table.Column<int>(type: "int", nullable: true),
                    TicketTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketTypeDetail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TicketUsedLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: true),
                    TicketTypeId = table.Column<int>(type: "int", nullable: true),
                    UsedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsUsed = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketUsedLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UpdatePaymentStatusLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    message = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    msgType = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    txnId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    qrTrace = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    bankCode = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    mobile = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    accountNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    amount = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    payDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    checksum = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedDate = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdatePaymentStatusLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UpdatePaymentStatusLogDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<int>(type: "int", nullable: true),
                    productId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    amount = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    tipAndFee = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ccy = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    qty = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdatePaymentStatusLogDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UpdateTicketQuantityLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OldValue = table.Column<int>(type: "int", nullable: true),
                    NewValue = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrderId = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: true),
                    TicketTypeId = table.Column<int>(type: "int", nullable: true),
                    CustomerType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateTicketQuantityLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserCard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    OrderId = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: true),
                    CardHolderName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Pan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AmountAuthorized = table.Column<int>(type: "int", nullable: true),
                    ApplicationLabel = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AuthCode = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserCart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TicketTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserCartDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    TicketTypeId = table.Column<int>(type: "int", nullable: false),
                    CustommerTypeId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    CustomerType = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCartDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PlaceID = table.Column<int>(type: "int", nullable: true),
                    EventID = table.Column<int>(type: "int", nullable: true),
                    DaiNoiID = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    UpdateByID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HB_GopY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoanhNghiepID = table.Column<byte>(type: "tinyint", nullable: true),
                    CustomerID = table.Column<long>(type: "bigint", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    NgayGui = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Loai = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))", comment: "0 - Gửi doanh nghiệp; 1 - Gửi phản ảnh hiện trường HueS"),
                    TiepNhan = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_GopY", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HB_GopY_Customer",
                        column: x => x.CustomerID,
                        principalTable: "HB_Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HB_GopY_HB_DoanhNghiep",
                        column: x => x.DoanhNghiepID,
                        principalTable: "HB_DoanhNghiep",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HB_Xe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoanhNghiepID = table.Column<byte>(type: "tinyint", nullable: true),
                    BienSo = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    NhanHieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NamSanXuat = table.Column<int>(type: "int", nullable: true),
                    MauSon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoMay = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SoKhung = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SoGhe = table.Column<byte>(type: "tinyint", nullable: true),
                    TienNghi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NgayLuuHanh = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())"),
                    NgayKiemDinh = table.Column<DateTime>(type: "date", nullable: true),
                    HoatDong = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_Xe", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HB_Xe_HB_DoanhNghiep",
                        column: x => x.DoanhNghiepID,
                        principalTable: "HB_DoanhNghiep",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "HB_TicketPrice",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerTypeID = table.Column<int>(type: "int", nullable: false),
                    TiketTypeID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    UpdateByID = table.Column<int>(type: "int", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    IsActive = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_TicketPrice", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TicketPrice_CustomerType",
                        column: x => x.CustomerTypeID,
                        principalTable: "HB_CustomerType",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TicketPrice_TicketType",
                        column: x => x.TiketTypeID,
                        principalTable: "HB_TicketType",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HB_Tuyen_Diem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TuyenID = table.Column<byte>(type: "tinyint", nullable: true),
                    DiemID = table.Column<short>(type: "smallint", nullable: true),
                    ThuTu = table.Column<int>(type: "int", nullable: true),
                    ChieuDi = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))", comment: "1 - Chiều đi; 0 - Chiều về")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_Tuyen_Diem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HB_Tuyen_Tram_HB_Tram",
                        column: x => x.DiemID,
                        principalTable: "HB_Diem",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HB_Tuyen_Tram_HB_Tuyen",
                        column: x => x.TuyenID,
                        principalTable: "HB_Tuyen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    UpdateByID = table.Column<int>(type: "int", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PassWord = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Role",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HB_TepKemTheo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiDoiTuong = table.Column<byte>(type: "tinyint", nullable: true),
                    DoiTuongID = table.Column<int>(type: "int", nullable: true),
                    NoiLuuTru = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_TepKemTheo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HB_TepKemTheo_HB_GopY",
                        column: x => x.DoiTuongID,
                        principalTable: "HB_GopY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HB_LichTrinh",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    XeID = table.Column<int>(type: "int", nullable: true),
                    TuyenID = table.Column<byte>(type: "tinyint", nullable: true),
                    ChieuDi = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))", comment: "1 - Chiều đi; 0 - Chiều về"),
                    GioDi = table.Column<TimeSpan>(type: "time", nullable: true),
                    GioDen = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_LichTrinh", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HB_LichTrinh_HB_Tuyen",
                        column: x => x.TuyenID,
                        principalTable: "HB_Tuyen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HB_LichTrinh_HB_Xe",
                        column: x => x.XeID,
                        principalTable: "HB_Xe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HB_NhatKy",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    XeID = table.Column<int>(type: "int", nullable: true),
                    TramID = table.Column<short>(type: "smallint", nullable: true),
                    ThoiDiemDen = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ThoiDiemDi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    LyDo = table.Column<byte>(type: "tinyint", nullable: true, comment: "Lý do trễ chuyến: 0 – Đúng giờ (mặc định); 1 – Tắc đường; 2 – Xe hỏng; 3 – Tai nạn; 4 – Khác"),
                    GhiChu = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_NhatKy", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HB_NhatKy_HB_Tram",
                        column: x => x.TramID,
                        principalTable: "HB_Diem",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HB_NhatKy_HB_Xe",
                        column: x => x.XeID,
                        principalTable: "HB_Xe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HB_BangGiaVe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoanhNghiepID = table.Column<byte>(type: "tinyint", nullable: true),
                    TuyenID = table.Column<byte>(type: "tinyint", nullable: true),
                    TicketPriceID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_BangGiaVe", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HB_BangGiaVe_HB_DoanhNghiep",
                        column: x => x.DoanhNghiepID,
                        principalTable: "HB_DoanhNghiep",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HB_BangGiaVe_HB_Tuyen",
                        column: x => x.TuyenID,
                        principalTable: "HB_Tuyen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HB_BangGiaVe_TicketPrice",
                        column: x => x.TicketPriceID,
                        principalTable: "HB_TicketPrice",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HB_CartDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerTypeID = table.Column<int>(type: "int", nullable: false),
                    TicketTypeID = table.Column<int>(type: "int", nullable: false),
                    TicketPriceID = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CartID = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_CartDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HB_CartDetail_HB_TicketPrice",
                        column: x => x.TicketPriceID,
                        principalTable: "HB_TicketPrice",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HB_Cart",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<long>(type: "bigint", nullable: false),
                    CartDetailID = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_Cart", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cart_CartDetail",
                        column: x => x.CartDetailID,
                        principalTable: "HB_CartDetail",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Cart_Customer",
                        column: x => x.CustomerID,
                        principalTable: "HB_Customer",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_RoleID",
                table: "Employee",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_BangGiaVe_DoanhNghiepID",
                table: "HB_BangGiaVe",
                column: "DoanhNghiepID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_BangGiaVe_TicketPriceID",
                table: "HB_BangGiaVe",
                column: "TicketPriceID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_BangGiaVe_TuyenID",
                table: "HB_BangGiaVe",
                column: "TuyenID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_Cart_CartDetailID",
                table: "HB_Cart",
                column: "CartDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_Cart_CustomerID",
                table: "HB_Cart",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_CartDetail_TicketPriceID",
                table: "HB_CartDetail",
                column: "TicketPriceID");

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20230425-105731",
                table: "HB_Diem",
                column: "DiaDiem",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HB_GopY_CustomerID",
                table: "HB_GopY",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_GopY_DoanhNghiepID",
                table: "HB_GopY",
                column: "DoanhNghiepID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_LichTrinh_TuyenID",
                table: "HB_LichTrinh",
                column: "TuyenID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_LichTrinh_XeID",
                table: "HB_LichTrinh",
                column: "XeID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_NhatKy_TramID",
                table: "HB_NhatKy",
                column: "TramID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_NhatKy_XeID",
                table: "HB_NhatKy",
                column: "XeID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_TepKemTheo_DoiTuongID",
                table: "HB_TepKemTheo",
                column: "DoiTuongID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_TicketPrice_CustomerTypeID",
                table: "HB_TicketPrice",
                column: "CustomerTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_TicketPrice_TiketTypeID",
                table: "HB_TicketPrice",
                column: "TiketTypeID");

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20230425-105755",
                table: "HB_Tuyen",
                column: "TenTuyen",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20230425-105840",
                table: "HB_Tuyen",
                column: "SoHieu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HB_Tuyen_Diem_DiemID",
                table: "HB_Tuyen_Diem",
                column: "DiemID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_Tuyen_Diem_TuyenID",
                table: "HB_Tuyen_Diem",
                column: "TuyenID");

            migrationBuilder.CreateIndex(
                name: "IX_HB_Xe_DoanhNghiepID",
                table: "HB_Xe",
                column: "DoanhNghiepID");

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20230425-151508",
                table: "HB_Xe",
                column: "BienSo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authorize");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "HB_BangGiaVe");

            migrationBuilder.DropTable(
                name: "HB_Cart");

            migrationBuilder.DropTable(
                name: "HB_CauHinh");

            migrationBuilder.DropTable(
                name: "HB_EmailConfig");

            migrationBuilder.DropTable(
                name: "HB_Feedback");

            migrationBuilder.DropTable(
                name: "HB_FeedbackReplyTemplate");

            migrationBuilder.DropTable(
                name: "HB_LichTrinh");

            migrationBuilder.DropTable(
                name: "HB_NhatKy");

            migrationBuilder.DropTable(
                name: "HB_TepKemTheo");

            migrationBuilder.DropTable(
                name: "HB_Tuyen_Diem");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "InvoiceErrorLog");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "MyRoles");

            migrationBuilder.DropTable(
                name: "MyUserRoles");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "OrderInvoice");

            migrationBuilder.DropTable(
                name: "OrderTemp");

            migrationBuilder.DropTable(
                name: "PaymentOnlineConfig");

            migrationBuilder.DropTable(
                name: "PayType");

            migrationBuilder.DropTable(
                name: "Place");

            migrationBuilder.DropTable(
                name: "PlaceDaiNoi");

            migrationBuilder.DropTable(
                name: "PromotionConfig");

            migrationBuilder.DropTable(
                name: "ReceiptConfig");

            migrationBuilder.DropTable(
                name: "ReceiptInfo");

            migrationBuilder.DropTable(
                name: "ReceiptTemplateConfig");

            migrationBuilder.DropTable(
                name: "RequestLogger");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "StatisticElement");

            migrationBuilder.DropTable(
                name: "StatisticTemplate");

            migrationBuilder.DropTable(
                name: "StatisticTemplate_Element");

            migrationBuilder.DropTable(
                name: "StatisticTemplate_Role");

            migrationBuilder.DropTable(
                name: "SubOrderDetail");

            migrationBuilder.DropTable(
                name: "Testing");

            migrationBuilder.DropTable(
                name: "TicketCategory");

            migrationBuilder.DropTable(
                name: "TicketCounter");

            migrationBuilder.DropTable(
                name: "TicketDetail");

            migrationBuilder.DropTable(
                name: "TicketOrder");

            migrationBuilder.DropTable(
                name: "TicketPrintLog");

            migrationBuilder.DropTable(
                name: "TicketScanLog");

            migrationBuilder.DropTable(
                name: "TicketTypeDetail");

            migrationBuilder.DropTable(
                name: "TicketUsedLog");

            migrationBuilder.DropTable(
                name: "UpdatePaymentStatusLog");

            migrationBuilder.DropTable(
                name: "UpdatePaymentStatusLogDetail");

            migrationBuilder.DropTable(
                name: "UpdateTicketQuantityLog");

            migrationBuilder.DropTable(
                name: "UserCard");

            migrationBuilder.DropTable(
                name: "UserCart");

            migrationBuilder.DropTable(
                name: "UserCartDetail");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "HB_CartDetail");

            migrationBuilder.DropTable(
                name: "HB_Xe");

            migrationBuilder.DropTable(
                name: "HB_GopY");

            migrationBuilder.DropTable(
                name: "HB_Diem");

            migrationBuilder.DropTable(
                name: "HB_Tuyen");

            migrationBuilder.DropTable(
                name: "HB_TicketPrice");

            migrationBuilder.DropTable(
                name: "HB_Customer");

            migrationBuilder.DropTable(
                name: "HB_DoanhNghiep");

            migrationBuilder.DropTable(
                name: "HB_CustomerType");

            migrationBuilder.DropTable(
                name: "HB_TicketType");
        }
    }
}
