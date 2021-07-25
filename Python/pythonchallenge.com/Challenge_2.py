from collections import Counter
from os import read

# Reads the file and prints the 10 most rare characters.
# Answer is equality

with open('step2text.txt', 'r') as f:
    text = f.read()

c = Counter(text)
print(c.most_common()[-10:])
