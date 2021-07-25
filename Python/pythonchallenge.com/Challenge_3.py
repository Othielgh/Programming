import re

data = open('step3data.txt', 'r').read()

t = re.findall('[^A-Z]+[A-Z]{3}([a-z])[A-Z]{3}[^A-Z]+', data)
print(t)