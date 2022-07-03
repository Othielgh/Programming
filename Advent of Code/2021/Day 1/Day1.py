def sub1():
    with open("Python\Advent of Code 2021\Day1\input.txt") as data:
        l = [int(x.strip()) for x in data.readlines()]

    count = 0
    for i, j in enumerate(l[:-1]):
        if j < l[i+1]:
            count += 1

    print("Number of times the depth increases: ", count)

# cheated
def sub2() -> int:
    with open("Python\Advent of Code 2021\Day1\input.txt") as data:
        lines = [x.strip() for x in data.readlines()]

    count = 0

    lst = []
    for i in lines:
        lst.append(int(i))
        
    triplet_list = [lst[i:i+3] for i in range(0, len(lst), 1)]

    sum_list = []

    for i in triplet_list:
        sum_list.append(sum(i))

    for i, j in enumerate(sum_list[:-1]):
        if j < sum_list[i+1]:
            count += 1

    print(count)

sub1()
sub2()



