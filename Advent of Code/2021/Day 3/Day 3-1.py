input = [entry.strip() for entry in open('Advent of Code\\2021\\Day 3\\input.txt', 'r').readlines()]

powerConsumption = 0
gamma, epsilon = 0, 0

for i in range(0, len(input[0])):
    numbers = [entry[-(i+1)] for entry in input]
    if numbers.count('0') >= len(input)//2:
        epsilon += 2**i
    else:
        gamma += 2**i

print('gamma: ', gamma)
print('epsilon: ', epsilon)
print('Power consumption: ', gamma * epsilon)