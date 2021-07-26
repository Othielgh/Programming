#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    int lightX; // the X position of the light of power
    int lightY; // the Y position of the light of power
    int initialTX; // Thor's starting X position
    int initialTY; // Thor's starting Y position
    cin >> lightX >> lightY >> initialTX >> initialTY; cin.ignore();

    int nextTX = lightX - initialTX;
    int nextTY = lightY - initialTY;
    char compass[4] = {'N', 'E', 'S', 'W'};

    while (1) {
        int remainingTurns; 
        cin >> remainingTurns; cin.ignore();
        // make a place to store the next move, 2 values because we can move diagonally
        char direction[2] = {'\0', '\0'};
        char *move = &direction[0];
        // Check if its not already on the right level
        if (nextTX != 0){
            *move = nextTX > 0 ? compass[1] : compass[3];
            nextTX += nextTX > 0 ? -1 : 1;
            move = &direction[1];
        }
        if (nextTY != 0){
            *move = nextTY > 0 ? compass[0] : compass[2];
            nextTY += nextTY > 0 ? -1 : 1;
        }
        if (direction[1] != '\0'){
            cout << direction[0] << direction[1] << endl;
            }
        else{
            cout << direction[0] << endl;
        }
    }
}