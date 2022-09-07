import sqlite3 as db
from random import randint

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
    sql = f'''
    INSERT INTO clients
        (id, full_name, date_birth, status)
    VALUES
        ({i}, "ФИО_{i}", 2022-09-28, {randint(100,999)} );
    '''
    cursor.execute(sql)


items = cursor.execute("SELECT * FROM clients").fetchall()

for item in items:
    print(item)

# (1, 'ФИО_1', '1985', 862)
# (2, 'ФИО_2', '1985', 221)
# (3, 'ФИО_3', '1985', 655)
# (4, 'ФИО_4', '1985', 859)
# (5, 'ФИО_5', '1985', 760)
# (6, 'ФИО_6', '1985', 257)
# (7, 'ФИО_7', '1985', 442)
# (8, 'ФИО_8', '1985', 194)
# (9, 'ФИО_9', '1985', 836)
