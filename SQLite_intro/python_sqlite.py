import sqlite3 as db
from random import randint
from datetime import datetime, date, time

connection = db.connect("users.db")
cursor = connection.cursor()


result = cursor.execute('''
CREATE TABLE clients (
 id INTEGER,
 full_name TEXT,
 date_birth TEXT,
 status INTEGER
)
''').fetchall()


for i in range(1, 10):
    dt = date(randint(1990, 2020), randint(1, 12), randint(1, 28))
    sql = f'''
    INSERT INTO clients
        (id, full_name, date_birth, status)
    VALUES
        ({i}, "ФИО_{i}", "{dt}", {randint(100,999)} );
    '''
    cursor.execute(sql).fetchall()

# Фиксация изменений
connection.commit()

items = cursor.execute("SELECT * FROM clients").fetchall()

for item in items:
    print(item)

# (1, 'ФИО_1', '1991-09-01', 616)
# (2, 'ФИО_2', '1993-09-08', 602)
# (3, 'ФИО_3', '1990-09-25', 770)
# (4, 'ФИО_4', '2001-12-25', 686)
# (5, 'ФИО_5', '2003-03-06', 227)
# (6, 'ФИО_6', '2019-12-22', 889)
# (7, 'ФИО_7', '2008-11-15', 882)
# (8, 'ФИО_8', '2013-08-23', 868)
# (9, 'ФИО_9', '2005-01-12', 963)
