-- Полный текст https://t.me/iksergeyru/42


-- Создание таблицы
CREATE TABLE clients (
 id INTEGER,
 full_name TEXT,
 date_birth TEXT,
 status INTEGER
)


-- Добавление записи Create-операция
INSERT INTO clients 
 (id, full_name, date_birth, status)
VALUES 
 (1, "Камянецкий С.Ю.", 2022-09-28, 200);


-- Чтение записей Read-операция
 SELECT
  id,
  full_name,
  date_birth,
  status
FROM  clients;


-- Изменение записи Update-операция
UPDATE clients
SET date_birth = "1990-09-28",
    id = 777
WHERE clients.id = 1;


-- Удаление записи Delete-операция
DELETE FROM clients 
WHERE clients.id = 777;