
######### Part 1
#commands = [entry.strip() for entry in open("Advent of Code\\2021\\Day 2\\input.txt", "r").readlines()]

# hori, depth, aim = 0, 0, 0
# for command in commands:
#     direction, amount = command.split(' ')[0], int(command.split(' ')[1])
#     if 'forward' in direction:
#         hori += amount
#     elif 'down' in direction:
#         depth += amount
#     elif 'up' in direction:
#         depth -= amount

# print('Horizontal Pos: ', hori)
# print('Depth: ', depth)
# print('Distance: ', hori*depth)
#########
commands = [entry.strip() for entry in open("Advent of Code\\2021\\Day 2\\input.txt", "r").readlines()]

hori, depth, aim = 0, 0, 0
for command in commands:
    direction, amount = command.split(' ')[0], int(command.split(' ')[1])
    if 'forward' in direction:
        hori += amount
        depth += aim*amount
    elif 'down' in direction:
        aim += amount
    elif 'up' in direction:
        aim -= amount

print('Horizontal Pos: ', hori)
print('Depth: ', depth)
print('Distance: ', hori*depth)
print('Aim: ', aim)


