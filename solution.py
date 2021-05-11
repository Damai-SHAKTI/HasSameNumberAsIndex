# Solution in python
def HasSameNumberAsIndex(array):
    for i in range(len(array)):
        if i == array[i]:
            return array[i];
    return False


print(HasSameNumberAsIndex([7, 2, 5, 6, 4]))
