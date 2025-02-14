﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JokeBackEnd.Migrations
{
    public partial class initjokes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jokes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contentstory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jokes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "jokes",
                columns: new[] { "Id", "Contentstory" },
                values: new object[,]
                {
                    { 1, "A child asked his father, \"How were people born?\" So his father said, \"Adam and Eve made babies, then their babies became adults and made babies, and so on.\"\r\n\r\nThe child then went to his mother, asked her the same question and she told him, \"We were monkeys then we evolved to become like we are now.\"\r\n\r\nThe child ran back to his father and said, \"You lied to me!\" His father replied, \"No, your mom was talking about her side of the family.\"" },
                    { 2, "Teacher: \"Kids,what does the chicken give you?\" Student: \"Meat!\" Teacher: \"Very good! Now what does the pig give you?\" Student: \"Bacon!\" Teacher: \"Great! And what does the fat cow give you?\" Student: \"Homework!\"\r\n\r\n" },
                    { 3, "The teacher asked Jimmy, \"Why is your cat at school today Jimmy?\" Jimmy replied crying, \"Because I heard my daddy tell my mommy, 'I am going to eat that pussy once Jimmy leaves for school today!'\"\r\n\r\n" },
                    { 4, "A housewife, an accountant and a lawyer were asked \"How much is 2+2?\" The housewife replies: \"Four!\". The accountant says: \"I think it's either 3 or 4. Let me run those figures through my spreadsheet one more time.\" The lawyer pulls the drapes, dims the lights and asks in a hushed voice, \"How much do you want it to be?\"" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jokes");
        }
    }
}
