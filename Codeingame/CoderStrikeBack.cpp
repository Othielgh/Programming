#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;


int main()
{

    // game loop
    while (1) {
        int x;
        int y;
        int nextCheckpointX; // x position of the next check point
        int nextCheckpointY; // y position of the next check point
        int nextCheckpointDist; // distance to the next checkpoint
        int nextCheckpointAngle; // angle between your pod orientation and the direction of the next checkpoint
        cin >> x >> y >> nextCheckpointX >> nextCheckpointY >> nextCheckpointDist >> nextCheckpointAngle; cin.ignore();
        int opponentX;
        int opponentY;
        cin >> opponentX >> opponentY; cin.ignore();
        string thrust;
        int boost = 0;

        if (nextCheckpointAngle > 120){
            thrust = " 0";
        }
        else if (nextCheckpointAngle > 90 || nextCheckpointDist < 1000){
            thrust = " 20";
        }
        else{
            thrust = " 100";
        }

        if ((boost != 1) && (nextCheckpointDist > 4000)){
            thrust = " BOOST";
            boost = 1;
        }


        cerr << thrust << endl;
        cerr << nextCheckpointDist << endl;

        cout << nextCheckpointX << " " << nextCheckpointY << thrust << endl;
    }
}
        // To debug: cerr << "Debug messages..." << endl;
