#include "Stack.h"
#include <iostream>

int main()
{
    Stack<std::string> *stack = new Stack<std::string>();

    stack->push("1 - a");
    stack->push("2 - b");
    stack->push("3 - c");
    stack->push("4 - d");
    stack->push("5 - e");
    stack->push("6 - f");
    stack->push("7 - g");
    stack->push("8 - h");

    while (!stack->isEmpty())
        std::cout << stack->pop() << std::endl;

    // output:
    // 8 - h
    // 7 - g
    // 6 - f
    // 5 - e
    // 4 - d
    // 3 - c
    // 2 - b
    // 1 - a

    return 0;
}