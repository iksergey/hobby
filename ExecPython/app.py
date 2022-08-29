tests = ["goo", "doo", "foo"]
locals()[tests[0]] = 42go
print(f"goo = {goo}")  # goo = 42

# 2.
globals()[tests[1]] = 2809
print(f"doo = {doo}")  # doo = 2809

value = 2023
exec(f"{tests[2]} = {value}")
print(f"foo = {foo}")  # foo = 2023

code = '''
a = 2
b = 3
c = f"{a} + {b} = {a+b}"
print(c)
'''
print(code)
exec(code)  # 2 + 3 = 5
