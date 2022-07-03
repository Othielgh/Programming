#include <string>
#include <sstream>
#include <limits>

std::string highAndLow(const std::string& numbers){
    int max = numeric_limits<int>::min();
    int min = numeric_limits<int>::max();
    int temp;

    stringstream ss(numbers);
    while(ss>>temp){
        if(temp<min){min=temp;}
        if(temp>max){max=temp;}
    }
    return to_string(max) + " " + to_string(min);
}