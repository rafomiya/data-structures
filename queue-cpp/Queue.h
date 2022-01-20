#ifndef __QUEUE_H__
#define __QUEUE_H__
#include "../stack-cpp/Stack.h"
#include "Queue.h"

template <class T>
class Queue
{
private:
    int _count;
    Stack<T> *_inbox, *_outbox;

public:
    Queue()
    {
        _inbox = new Stack<T>();
        _outbox = new Stack<T>();
    }

    void enqueue(int elem)
    {
        ++_count;

        _inbox->push(elem);
    }

    T dequeue()
    {
        if (_outbox->isEmpty())
            while (!_inbox->isEmpty())
                _outbox->push(_inbox->pop());

        if (!isEmpty())
            --_count;

        return _outbox->pop();
    }

    T front()
    {
        if (_outbox->isEmpty())
            while (!_inbox->isEmpty())
                _outbox->push(_inbox->pop());

        return _outbox->top();
    }

    int count()
    {
        return _count;
    }

    bool isEmpty()
    {
        return _count == 0;
    }

    void clear()
    {
        while (!isEmpty())
            dequeue();
    }
};

#endif