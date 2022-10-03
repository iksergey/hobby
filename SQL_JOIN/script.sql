DROP TABLE T1;
DROP TABLE T2;


CREATE TABLE T1 (
  id serial PRIMARY KEY,
  fname VARCHAR(30) NOT NULL
);


CREATE TABLE T2 (
  id int PRIMARY KEY NOT NULL,
  nick VARCHAR(30) NOT NULL
);


INSERT INTO T1 (fname)
VALUES ('Имя 1'),
       ('Имя 2'),
       ('Имя 3'),
       ('Имя 4'),
       ('Имя 5');


INSERT INTO T2 (id, nick)
VALUES (1,'Имя 3'),
       (2,'Имя 4'),
       (3,'Имя 5'),
       (4,'Имя 6'),
       (5,'Имя 7');


SELECT 
  T1.id,
  T1.fname
FROM T1

-- SELECT * FROM T1


SELECT 
  T2.id,
  T2.nick
FROM T2

-- SELECT * FROM T2


-- LEFT JOIN T1, T2
SELECT
  T1.id as "T1.id", 
  T1.fname as "T1.fname",
  T2.id as "T2.id", 
  T2.nick as "T2.nick"
FROM T1
LEFT JOIN T2
ON T1.fname = T2.nick


-- LEFT JOIN T2, T1
SELECT
  T1.id as "T1.id", 
  T1.fname as "T1.fname",
  T2.id as "T2.id", 
  T2.nick as "T2.nick"
FROM T2
LEFT JOIN T1
ON T1.fname = T2.nick


-- INNER JOIN T1, T2
SELECT
  T1.id as "T1.id", 
  T1.fname as "T1.fname",
  T2.id as "T2.id", 
  T2.nick as "T2.nick"
FROM T1
INNER JOIN T2
ON T1.fname = T2.nick


-- RIGHT JOIN T1, T2
SELECT
  T1.id as "T1.id", 
  T1.fname as "T1.fname",
  T2.id as "T2.id", 
  T2.nick as "T2.nick"
FROM T1
RIGHT JOIN T2
ON T1.fname = T2.nick


-- RIGHT JOIN T2, T1
SELECT
  T1.id as "T1.id", 
  T1.fname as "T1.fname",
  T2.id as "T2.id", 
  T2.nick as "T2.nick"
FROM T2
RIGHT JOIN T1
ON T1.fname = T2.nick


-- FULL JOIN T1, T2
SELECT
  T1.id as "T1.id", 
  T1.fname as "T1.fname",
  T2.id as "T2.id", 
  T2.nick as "T2.nick"
FROM T1
FULL JOIN T2
ON T1.fname = T2.nick


-- FULL JOIN T2, T1
SELECT
  T1.id as "T1.id", 
  T1.fname as "T1.fname",
  T2.id as "T2.id", 
  T2.nick as "T2.nick"
FROM T2
FULL JOIN T1
ON T1.fname = T2.nick


-- UNION ALL
SELECT
  T1.id as "T1.id", 
  T1.fname as "T1.fname",
  T2.id as "T2.id", 
  T2.nick as "T2.nick"
FROM T1 LEFT JOIN T2
  ON T1.fname = T2.nick
UNION ALL
SELECT
  T1.id as "T1.id", 
  T1.fname as "T1.fname",
  T2.id as "T2.id", 
  T2.nick as "T2.nick"
FROM T1 RIGHT JOIN T2 
  ON T1.fname = T2.nick
--WHERE T1.id IS NOT NULL