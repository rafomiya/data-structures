#ifndef __STACK_H__
#define __STACK_H__

template <class T>
class Stack
{
private:
    static const int STACK_CAPACITY = 8;
    int _count;
    T _values[STACK_CAPACITY];
    const T EMPTY_VALUE = T();

public:
    Stack() {}

    bool push(T data)
    {
        if (_count == STACK_CAPACITY)
            return false;

        _values[_count] = data;
        ++_count;

        return true;
    }

    bool isEmpty()
    {
        return _count == 0;
    }

    T pop()
    {
        if (isEmpty())
            return EMPTY_VALUE;

        T temp = _values[_count - 1];
        _values[_count - 1] = EMPTY_VALUE;
        --_count;

        return temp;
    }

    T top()
    {
        if (isEmpty())
            return EMPTY_VALUE;

        return _values[_count - 1];
    }

    int count()
    {
        return _count;
    }

    void clear()
    {
        while (!isEmpty())
            pop();
    }
};
#endif