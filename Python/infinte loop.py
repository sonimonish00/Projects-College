def all_even():
    n = 0
    while True:
        yield n
        n += 2
for i in all_even():
    print(i)
