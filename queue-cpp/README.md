# What is a Queue?

A `Queue` is a data structure that follows the FIFO (**F**irst **I**n **F**irst **O**ut) principle: in other words, it works just as a normal queue of people, for instance. The first ones to arrive (enqueue) are the first ones to leave (dequeue).
That represents two key ideas of the FIFO principle:

1. elements are enqueued (added) at the end of the queue; and
2. elements are dequeued (removed) at the front of the queue.

![queue](https://user-images.githubusercontent.com/76710601/150443618-038d5fb4-420a-4efe-b126-629f163054ce.png)

## What are the methods available?
The available methods are:

### `enqueue(elem)`
Adds an element to the end of the `Queue`.

```cpp
// Before the enqueue:
// 
//      back    front
//      |_c_|_b_|_a_|

queue->enqueue(d);

// After the enqueue:
// 
//  back        front
//  |_d_|_c_|_b_|_a_|
```

### `dequeue()`
Removes and returns the element at the front of the `Queue`.

```cpp
// Before the dequeue:
// 
//  back        front
//  |_d_|_c_|_b_|_a_|

std::cout << queue->dequeue() << std::endl; // d

// After the dequeue:
// 
//      back    front
//      |_c_|_b_|_a_|
```

### `front()`
Returns the element at the front of the `Queue`.

```cpp
// Before the front:
// 
//  back        front
//  |_d_|_c_|_b_|_a_|

std::cout << "Front: " << queue->front() << std::endl;
// output:
// Front: a

// After the front:
// 
//  back        front
//  |_d_|_c_|_b_|_a_|
```

### `count()`
Returns the amount of elements on the `Queue`.

```cpp
Queue<int> *queue = new Queue<int>();

queue->enqueue(0);
queue->enqueue(1);
queue->enqueue(2);
queue->enqueue(3);
queue->enqueue(4);
queue->enqueue(5);

std::cout << "Count: " << queue->count() << std::endl;
// output:
// Count: 6
```

### `isEmpty()`
Returns whether the `Queue` is empty or not.

```cpp
Queue<int> *queue = new Queue<int>();

std::cout << queue->isEmpty() << std::endl; // 1 (true)

queue->enqueue(0);

std::cout << queue->isEmpty() << std::endl; // 0 (false)
```

### `clear()`
Clears the current instance of `Queue`, making it empty.

```cpp
Queue<int> *queue = new Queue<int>();

for (int i = 1; i <= 1000; i++)
{
    queue->enqueue(i);
}
std::cout << "Count after the for: " << queue->count() << std::endl;

queue->clear();
std::cout << "Count after the clear(): " << queue->count() << std::endl;

// output:
// Count after the for: 1000
// Count after the clear(): 0
```
