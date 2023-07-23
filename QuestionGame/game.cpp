#include <iostream>
#include <unistd.h>
#include <cstdlib>
using namespace std;

int option;
int score = 0;

void DisplayScore(){
    if(score>0){
        system("clear");
        cout << "------"<<endl;
        cout << "Victory"<<endl;
        cout << "\nFinal Score: "<<score<<endl;
        cout << "------";
        sleep(3);
    }
}

void level3(){
    system("clear");
    cout << "Third question ?\n\t-> 37 crows are on a tree. A hunter shot four of them. How many crows remain on tree ?"<<endl;
    cout << "->: ";
    cin >> option;
    while(option!=0){
        cout << "Wrong answer";
        cin >> option;
        score --;
    }
    cout << "Correct answer";
    score ++;
    sleep(1);
}
void level2(){
    system("clear");
    cout << "Second question ?\n\t-> f(x) = 2 + (x^3) , Integral f(2) = ?"<<endl;
    cout << "->: ";
    cin >> option;
    while(option!=8){
        cout << "Wrong answer";
        cin >> option;
        score --;
    }
    cout << "Correct answer";
    score ++;
    sleep(1);

}

void level1(){
	system("clear");
    cout << "First question ?\n\t-> 2 + 5 * (8-3) =  ?"<< endl;
    cout << "->: ";
    cin >> option;
    while(option!=27){
        cout << "Wrong answer";
        cin >> option;
        score --;
    }
    cout << "Correct answer";
    score ++;
    sleep(1);
    
}

void Creadits(){
    system("clear");
    cout << "Programmer: Codidodido";
    sleep(1);
    
}

void Start(){
    system("clear");
    cout << "Menu:\n\t1.Start Game\n\n\t0.Exit"<<endl;
    cout << "->: ";
    cin >> option;
    switch(option){
        case 1:
            level1();
            break;
        case 2:
            Creadits();
            
            break;
        case 0:
            break;
        default:
            cout << "Not valid";
            break;
    }
    
}




int main(){
    cout << "Welcome To Question Game"<<endl;
    cout << "In This Game I Ask you Questions And You Have To Answer"<<endl;
    cout << "------"<<endl;
    sleep(1);

    
    cout << "Are you ready?(y/n): ";
    string order;
    cin >> order;

    if(order=="y"){
        Start();
    }else{
        cout << "Sadly :(";
        return 0;
    }

}