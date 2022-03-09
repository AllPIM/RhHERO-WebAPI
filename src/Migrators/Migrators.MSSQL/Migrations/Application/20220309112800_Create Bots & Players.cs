using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    public partial class CreateBotsPlayers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "Group",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.EnsureSchema(
                name: "FunCenter");

            migrationBuilder.CreateTable(
                name: "LuckyBags",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuckyBags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LuckyFruits",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Round = table.Column<int>(type: "int", nullable: true),
                    Fee = table.Column<int>(type: "int", nullable: true),
                    Mode = table.Column<int>(type: "int", nullable: true),
                    Slots = table.Column<int>(type: "int", nullable: true),
                    Winner = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuckyFruits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotorRacings",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Round = table.Column<int>(type: "int", nullable: true),
                    Fee = table.Column<int>(type: "int", nullable: true),
                    Tracks = table.Column<int>(type: "int", nullable: true),
                    Winner = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorRacings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Tag = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LuckyFruitTracks",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LuckyFruitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Odds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chances = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuckyFruitTracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LuckyFruitTracks_LuckyFruits_LuckyFruitId",
                        column: x => x.LuckyFruitId,
                        principalSchema: "FunCenter",
                        principalTable: "LuckyFruits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotorRacingTracks",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MotorRacingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Track = table.Column<int>(type: "int", nullable: true),
                    Motions = table.Column<int>(type: "int", nullable: true),
                    Speeds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lapses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seconds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorRacingTracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotorRacingTracks_MotorRacings_MotorRacingId",
                        column: x => x.MotorRacingId,
                        principalSchema: "FunCenter",
                        principalTable: "MotorRacings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bots",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccessOs = table.Column<int>(type: "int", nullable: true),
                    AccessCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartType = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bots_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalSchema: "FunCenter",
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Game = table.Column<int>(type: "int", nullable: false),
                    ChargeOs = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalSchema: "FunCenter",
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerBalance",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Os = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerBalance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerBalance_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalSchema: "FunCenter",
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerInfo",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: true),
                    LevelDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rank = table.Column<int>(type: "int", nullable: true),
                    RankDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MBIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MBITDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<int>(type: "int", nullable: true),
                    ExpDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerInfo_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalSchema: "FunCenter",
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SignInLogs",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Os = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SceneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SceneId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LogoutOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignInLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignInLogs_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalSchema: "FunCenter",
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Timelines",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timelines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Timelines_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalSchema: "FunCenter",
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BotGame",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Game = table.Column<int>(type: "int", nullable: false),
                    GameMode = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BotGame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BotGame_Bots_BotId",
                        column: x => x.BotId,
                        principalSchema: "FunCenter",
                        principalTable: "Bots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LuckyBagReturns",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LuckyBagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuckyBagReturns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LuckyBagReturns_LuckyBags_LuckyBagId",
                        column: x => x.LuckyBagId,
                        principalSchema: "FunCenter",
                        principalTable: "LuckyBags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LuckyBagReturns_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "FunCenter",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LuckyBagRobbers",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LuckyBagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuckyBagRobbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LuckyBagRobbers_LuckyBags_LuckyBagId",
                        column: x => x.LuckyBagId,
                        principalSchema: "FunCenter",
                        principalTable: "LuckyBags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LuckyBagRobbers_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "FunCenter",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LuckyFruitBets",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LuckyFruitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChargeOs = table.Column<int>(type: "int", nullable: false),
                    Chips = table.Column<int>(type: "int", nullable: false),
                    Slot = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuckyFruitBets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LuckyFruitBets_LuckyFruits_LuckyFruitId",
                        column: x => x.LuckyFruitId,
                        principalSchema: "FunCenter",
                        principalTable: "LuckyFruits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LuckyFruitBets_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "FunCenter",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LuckyFruitIncomes",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LuckyFruitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalBets = table.Column<int>(type: "int", nullable: false),
                    TotalRewards = table.Column<int>(type: "int", nullable: false),
                    Benefits = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuckyFruitIncomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LuckyFruitIncomes_LuckyFruits_LuckyFruitId",
                        column: x => x.LuckyFruitId,
                        principalSchema: "FunCenter",
                        principalTable: "LuckyFruits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LuckyFruitIncomes_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "FunCenter",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LuckyFruitRewards",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LuckyFruitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Spent = table.Column<int>(type: "int", nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuckyFruitRewards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LuckyFruitRewards_LuckyFruits_LuckyFruitId",
                        column: x => x.LuckyFruitId,
                        principalSchema: "FunCenter",
                        principalTable: "LuckyFruits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LuckyFruitRewards_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "FunCenter",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotorRacingBets",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MotorRacingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChargeOs = table.Column<int>(type: "int", nullable: false),
                    Chips = table.Column<int>(type: "int", nullable: false),
                    Track = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorRacingBets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotorRacingBets_MotorRacings_MotorRacingId",
                        column: x => x.MotorRacingId,
                        principalSchema: "FunCenter",
                        principalTable: "MotorRacings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MotorRacingBets_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "FunCenter",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotorRacingIncomes",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MotorRacingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalBets = table.Column<int>(type: "int", nullable: false),
                    TotalRewards = table.Column<int>(type: "int", nullable: false),
                    Benefits = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorRacingIncomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotorRacingIncomes_MotorRacings_MotorRacingId",
                        column: x => x.MotorRacingId,
                        principalSchema: "FunCenter",
                        principalTable: "MotorRacings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MotorRacingIncomes_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "FunCenter",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotorRacingRewards",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MotorRacingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Spent = table.Column<int>(type: "int", nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorRacingRewards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotorRacingRewards_MotorRacings_MotorRacingId",
                        column: x => x.MotorRacingId,
                        principalSchema: "FunCenter",
                        principalTable: "MotorRacings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MotorRacingRewards_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "FunCenter",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChargeOs = table.Column<int>(type: "int", nullable: false),
                    Game = table.Column<int>(type: "int", nullable: false),
                    ReportDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Round = table.Column<int>(type: "int", nullable: true),
                    Operator = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "FunCenter",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rewards",
                schema: "FunCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimelineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rewards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rewards_Timelines_TimelineId",
                        column: x => x.TimelineId,
                        principalSchema: "FunCenter",
                        principalTable: "Timelines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BotGame_BotId",
                schema: "FunCenter",
                table: "BotGame",
                column: "BotId");

            migrationBuilder.CreateIndex(
                name: "IX_Bots_PlayerId",
                schema: "FunCenter",
                table: "Bots",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_LuckyBagReturns_LuckyBagId",
                schema: "FunCenter",
                table: "LuckyBagReturns",
                column: "LuckyBagId");

            migrationBuilder.CreateIndex(
                name: "IX_LuckyBagReturns_OrderId",
                schema: "FunCenter",
                table: "LuckyBagReturns",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_LuckyBagRobbers_LuckyBagId",
                schema: "FunCenter",
                table: "LuckyBagRobbers",
                column: "LuckyBagId");

            migrationBuilder.CreateIndex(
                name: "IX_LuckyBagRobbers_OrderId",
                schema: "FunCenter",
                table: "LuckyBagRobbers",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_LuckyFruitBets_LuckyFruitId",
                schema: "FunCenter",
                table: "LuckyFruitBets",
                column: "LuckyFruitId");

            migrationBuilder.CreateIndex(
                name: "IX_LuckyFruitBets_OrderId",
                schema: "FunCenter",
                table: "LuckyFruitBets",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_LuckyFruitIncomes_LuckyFruitId",
                schema: "FunCenter",
                table: "LuckyFruitIncomes",
                column: "LuckyFruitId");

            migrationBuilder.CreateIndex(
                name: "IX_LuckyFruitIncomes_OrderId",
                schema: "FunCenter",
                table: "LuckyFruitIncomes",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_LuckyFruitRewards_LuckyFruitId",
                schema: "FunCenter",
                table: "LuckyFruitRewards",
                column: "LuckyFruitId");

            migrationBuilder.CreateIndex(
                name: "IX_LuckyFruitRewards_OrderId",
                schema: "FunCenter",
                table: "LuckyFruitRewards",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_LuckyFruitTracks_LuckyFruitId",
                schema: "FunCenter",
                table: "LuckyFruitTracks",
                column: "LuckyFruitId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorRacingBets_MotorRacingId",
                schema: "FunCenter",
                table: "MotorRacingBets",
                column: "MotorRacingId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorRacingBets_OrderId",
                schema: "FunCenter",
                table: "MotorRacingBets",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorRacingIncomes_MotorRacingId",
                schema: "FunCenter",
                table: "MotorRacingIncomes",
                column: "MotorRacingId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorRacingIncomes_OrderId",
                schema: "FunCenter",
                table: "MotorRacingIncomes",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorRacingRewards_MotorRacingId",
                schema: "FunCenter",
                table: "MotorRacingRewards",
                column: "MotorRacingId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorRacingRewards_OrderId",
                schema: "FunCenter",
                table: "MotorRacingRewards",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorRacingTracks_MotorRacingId",
                schema: "FunCenter",
                table: "MotorRacingTracks",
                column: "MotorRacingId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PlayerId",
                schema: "FunCenter",
                table: "Orders",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                schema: "FunCenter",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerBalance_PlayerId",
                schema: "FunCenter",
                table: "PlayerBalance",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerInfo_PlayerId",
                schema: "FunCenter",
                table: "PlayerInfo",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rewards_TimelineId",
                schema: "FunCenter",
                table: "Rewards",
                column: "TimelineId");

            migrationBuilder.CreateIndex(
                name: "IX_SignInLogs_PlayerId",
                schema: "FunCenter",
                table: "SignInLogs",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Timelines_PlayerId",
                schema: "FunCenter",
                table: "Timelines",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BotGame",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "LuckyBagReturns",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "LuckyBagRobbers",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "LuckyFruitBets",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "LuckyFruitIncomes",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "LuckyFruitRewards",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "LuckyFruitTracks",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "MotorRacingBets",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "MotorRacingIncomes",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "MotorRacingRewards",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "MotorRacingTracks",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "Payments",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "PlayerBalance",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "PlayerInfo",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "Rewards",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "SignInLogs",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "Bots",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "LuckyBags",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "LuckyFruits",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "MotorRacings",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "Timelines",
                schema: "FunCenter");

            migrationBuilder.DropTable(
                name: "Players",
                schema: "FunCenter");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Identity",
                table: "RoleClaims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Group",
                schema: "Identity",
                table: "RoleClaims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                schema: "Identity",
                table: "RoleClaims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                schema: "Identity",
                table: "RoleClaims",
                type: "datetime2",
                nullable: true);
        }
    }
}
