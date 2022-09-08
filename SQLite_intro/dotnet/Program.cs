// dotnet add package Microsoft.Data.Sqlite                    
using Microsoft.Data.Sqlite;
using static System.Random;

string path = "users.db";
if (File.Exists(path)) File.Delete(path);

var connection = new SqliteConnection($"Data Source={path}");
connection.Open();


SqliteCommand command = new SqliteCommand();
command.Connection = connection;

command.CommandText = @"
CREATE TABLE clients (
  id INTEGER,
  full_name TEXT,
  date_birth TEXT,
  status INTEGER
)
";
command.ExecuteNonQuery();

for (int i = 1; i < 10; i++)
{
  var dt = new DateOnly(
          Shared.Next(1990, 2020),
          Shared.Next(1, 12),
          Shared.Next(1, 28)
          ).ToString("yyyy-MM-dd");

  var sql = string.Format(
  @"
    INSERT INTO clients
        (id, full_name, date_birth, status)
    VALUES
        ({0}, 'ФИО_{1}','{2}',{3});
  ",
  i, i, dt, Shared.Next(100, 999)
  );
  command.CommandText = sql;
  command.ExecuteNonQuery();
}


command.CommandText = @"
SELECT
  * 
FROM clients
";

SqliteDataReader reader = command.ExecuteReader();

// Можно проверить есть ли данные
// Console.WriteLine($"reader.HasRows: {reader.HasRows}");

while (reader.Read())
{
  string rec = String.Format("{0} {1} {2} {3}",
    reader["id"],
    reader["full_name"],
    reader["date_birth"],
    reader["status"]
    );
  Console.WriteLine(rec);
}

reader.Close();
command.Cancel();
connection.Close();