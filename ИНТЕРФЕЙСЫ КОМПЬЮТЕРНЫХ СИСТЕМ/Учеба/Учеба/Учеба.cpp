#include <iostream>
#include <cmath>
using namespace std;
int main() {
    int min = 100, max = 1;
    const int biba = 15;
    int num[biba]{ 1,2,321,4,543,124,5643,123,5,123,5,2,6,0,23444 };
    for (int i = 0; i != biba; i++) {

        if (min > num[i]) min = num[i];
        if (max < num[i]) max = num[i];

    }
    cout << min << endl;
    cout << max << endl;
    return 0;
}