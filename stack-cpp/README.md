# What is a Stack?

`Stack` is the data structure that follows the LIFO (**L**ast **I**n **F**irst **O**ut) principle: that represents two key ideas, that are the principal two operations we can do within a `Stack`.

## What are the `Stack` operations?

1. elements are pushed (added) on the top of the stack; and
2. popped (removed) also on the top of the stack.

These two behaviors are schematized here:

![push](https://user-images.githubusercontent.com/76710601/150433010-9417df37-bcfb-4690-a7b5-e21a634b5b75.png)
![pop](https://user-images.githubusercontent.com/76710601/150433037-ccf3da5e-f184-4cfc-bc8e-e52c0ba60078.png)

## What are the methods available?
The available methods are:

### `push(elem)`
Pushes the `elem` parameter to the top of the `Stack`.

```cpp
// Before the push:
// 
// |   |
// |   |
// | c |
// | b |
// |_a_|

stack.push(d);

// After the push:
// 
// |   |
// | d |
// | c |
// | b |
// |_a_|
```

### `isEmpty()`
Returns whether the stack is empty or not.

```cpp
// initializing the empty stack
Stack<string> *stack = new Stack<string>();

std::cout << stack->isEmpty() << std::endl; // 1 (true)

stack->push("a");

std::cout << stack->isEmpty() << std::endl; // 0 (false)
```

### `pop()`
Removes the top element and returns it.

```cpp
// Before the pop:
// 
// |   |
// | d |
// | c |
// | b |
// |_a_|

std::cout << stack->pop() << std::endl; // d

// After the pop:
// 
// |   |
// |   |
// | c |
// | b |
// |_a_|
```

### `top()`
Returns the top element, but without removing it, differently from the `pop()` method.

```cpp
// Before the top:
// 
// |   |
// | e |
// | d |
// | c |
// | b |
// |_a_|

std::cout << stack->top() << std::endl; // e

// After the top:
// 
// |   |
// | e |
// | d |
// | c |
// | b |
// |_a_|
```

### `count()`
Returns the amount of items on the stack.

```cpp
Stack<int> *stack = new Stack<int>();

for (int i = 0; int i < 5; i++)
{
    stack->push(i);
    std::cout << stack->count() << std::endl;
}

// output:
// 1
// 2
// 3
// 4
// 5
```

### `clear()`
Removes all the items of the `Stack`, leaving it empty.

```cpp
Stack<int> *stack = new Stack<int>();

for (int i = 1; i <= 1000; i++)
{
    stack->push(i);
}
std::cout << "Count after the for: " << stack->count() << std::endl;

stack->clear();
std::cout << "Count after the clear(): " << stack->count() << std::endl;

// output:
// Count after the for: 1000
// Count after the clear(): 0
```
