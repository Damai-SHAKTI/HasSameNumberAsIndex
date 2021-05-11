#include <iostream>
#include <string>

int HasSameNumberAsIndex(int Array[]) {
    for (int i = 0; i < sizeof(Array); i++) {
        if (Array[i] == i) {
            return Array[i];
        }
    }
    return -1;
}

int main()
{
    int arr[] = {9, 7, 2, 4};
    int result = HasSameNumberAsIndex(arr);
    std::cout << ((result == -1) ? "False" : std::to_string(result)) << std::endl;
     
}
