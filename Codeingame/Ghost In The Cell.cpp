#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

// // unsure about the classes
// class factory{
//     int id;
//     int owner;
//     int cyborgs;
//     int production;

//     public  factory(int id, int owner, int cyborgs, int production){
//         id = id;
//         owner = owner;
//         cyborgs = cyborgs;
//         production = production;
//     }

// }

// class player{
//      player(string args[]){
//         int number=0;
//         int loopvalue=0;
//         cin >> loopvalue;
//         for(int i = 0; i < loopValue; i++)
//         {
//             std::cin >> number;
//         int factoryCount = number;
//         int linkCount = number;
//         for(int i = 0; i < linkCount; i++){
//             int factory1 = i
//             }
//         }
//     }
// }


int main()
{
    int factoryCount; // the number of factories
    cin >> factoryCount; cin.ignore();
    int linkCount; // the number of links between factories
    cin >> linkCount; cin.ignore();
    for (int i = 0; i < linkCount; i++) {
        int factory1;
        int factory2;
        int distance;
        cin >> factory1 >> factory2 >> distance; cin.ignore();
    }

    // game loop
    while (1) {
        int mainFactory = 0;
        int opponentFactory = 0;
        int initialCyborgCount = 0;
        int entityCount; // the number of entities (e.g. factories and troops)
        cin >> entityCount; cin.ignore();
        for (int i = 0; i < entityCount; i++) {
            int entityId;
            string entityType;
            int arg1;
            int arg2;
            int arg3;
            int arg4;
            int arg5;
            cin >> entityId >> entityType >> arg1 >> arg2 >> arg3 >> arg4 >> arg5; cin.ignore();

            if(entityType == "FACTORY"){
                if (arg1 == 1){
                    mainFactory = entityId;
                    initialCyborgCount = arg2;
                }
                else{
                    opponentFactory = entityId;
                }
            }
        }

        if(mainFactory != -1 && opponentFactory != -1){
            cout << "MOVE " << mainFactory << " " << opponentFactory << " " << initialCyborgCount << endl; 
        }
        else{
        cout << "WAIT " << endl;
        }
    }
}