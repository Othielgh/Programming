#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{

    // game loop
    while (1) {
        int highest = 0;
        int attack = 0; 
        for (int i = 0; i < 8; i++) { 
            int mountainH; 
            cin >> mountainH; cin.ignore(); 
            if (highest < mountainH){
                highest = mountainH;
                attack = i; 
            }
        
        }
        cout << attack << endl; 
    }
}