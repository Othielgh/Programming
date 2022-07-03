#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

string bitConvert (string message, string bits);
string norrisConvert (string bits);

int main(){
    string MESSAGE;
    getline(cin, MESSAGE);

    string bitString = "";
    bitString = bitConvert (MESSAGE, bitString);   
    bitString = norrisConvert (bitString);
    
    cout << bitString << endl;
}

string bitConvert (string message, string bitsConverted){
    for (int counter = 0; counter < message.length(); ++counter)
    {
        char s = message[counter];
        bitset<7> bits(s);
        bitsConverted += bits.to_string();
    }
    return bitsConverted;
}

string norrisConvert (string bits){
    string output = "";
    string temp = "";
    int isZero = -1;
    
    for (string::iterator it = bits.begin(); it != bits.end(); ++it){
        int newIsZero = (*it == '0');
        
        if (newIsZero == isZero)
        {
            temp += "0";
        }
        else
        {
            isZero = newIsZero;
            
            if ((output.length()) > 0)
            {
                output += " ";
            }
            output += temp;  
            if (isZero)
            {
                temp = "00 0";
            }
            else
            {
                temp = "0 0";
            }
        }
    }
    
    if ((temp.length()) > 0){
        if ((output.length()) > 0)
        {
            output += " ";
        }  
        output += temp;
    }
    
    return output;
}