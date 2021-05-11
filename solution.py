# Solution in python
def addUpTo(array):
    for i in range(len(array)):
        if i == array[i]:
            return array[i];
    return False


print(addUpTo([7, 2, 5, 3, 2]))
