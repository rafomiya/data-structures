#include <iostream>
#include "Queue.h"

int main()
{
    Queue<char> *testQueue = new Queue<char>();

    testQueue->enqueue('a');
    std::cout << "front: " << testQueue->front() << std::endl;

    testQueue->enqueue('b');
    std::cout << "front: " << testQueue->front() << std::endl;

    testQueue->enqueue('c');
    std::cout << "front: " << testQueue->front() << std::endl;

    testQueue->enqueue('d');
    std::cout << "front: " << testQueue->front() << std::endl;

    testQueue->enqueue('e');
    std::cout << "front: " << testQueue->front() << std::endl;

    std::cout << "isEmpty: " << testQueue->isEmpty() << std::endl;
    std::cout << "count: " << testQueue->count() << std::endl;

    std::cout << "dequeue: " << testQueue->dequeue() << std::endl;
    std::cout << "dequeue: " << testQueue->dequeue() << std::endl;
    std::cout << "dequeue: " << testQueue->dequeue() << std::endl;
    std::cout << "dequeue: " << testQueue->dequeue() << std::endl;
    std::cout << "dequeue: " << testQueue->dequeue() << std::endl;
    std::cout << "dequeue: " << testQueue->dequeue() << std::endl;

    std::cout << "clear: " << std::endl;

    testQueue->clear();

    std::cout << "isEmpty depois do clear: " << testQueue->isEmpty() << std::endl;

    // output:
    // front: a
    // front: a
    // front: a
    // front: a
    // front: a
    // isEmpty: 0
    // count: 5
    // dequeue: a
    // dequeue: b
    // dequeue: c
    // dequeue: d
    // dequeue: e
    // dequeue:
    // clear:
    // isEmpty depois do clear: 1

    return 0;
}