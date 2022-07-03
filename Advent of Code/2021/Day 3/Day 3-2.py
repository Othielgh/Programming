import numpy as np

input = [entry.strip() for entry in open('Advent of Code\\2021\\Day 3\\input.txt', 'r').readlines()]

# Before searching for either rating value, start with the full list of binary numbers from your diagnostic report and consider just the first bit of those numbers. Then:

# Keep only numbers selected by the bit criteria for the type of rating value for which you are searching. Discard numbers which do not match the bit criteria.
# If you only have one number left, stop; this is the rating value for which you are searching.
# Otherwise, repeat the process, considering the next bit to the right.

for i in range(0, len(input[0])):
    numbers = [entry[-(i+1)] for entry in input]