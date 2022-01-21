# What is a LinkedList?

A `LinkedList` is a data structure that associates a series of Nodes. The first item (a Node called `head`) points to the second, the second to the third, etc.

But...

## What is a LinkedList `Node`?

![Node](https://user-images.githubusercontent.com/76710601/150411711-0fb5014e-3d37-4d4b-b44d-0ae15c4f5a8e.png)

That's the basic structure of a Node. It has two key elements:

1. the containing data, that may be a `int`, `string` or any other data type; and
2. the next `Node` of the linkedlist.

## So...

![LinkedList](https://user-images.githubusercontent.com/76710601/150413342-773c9d9d-b662-4307-b686-71b8992fde75.png)

That is a possible schematization of a `LinkedList`. One of its main advantages is that it doesn't have a maximum capacity, since we can always add a new `Node` in any  of the structure.

## What are the methods available?
The available methods are:

### `Push(data)`
Pushes the `data` parameter to the end of the `LinkedList`.

```C#
// Before the Push:
// 
// head
//  \/
// [a-]-> [b-]-> [c-]-> null

linkedList.Push("d");

// After the Push:
// 
// head
//  \/
// ["a"-]-> ["b"-]-> ["c"-]-> ["d"-]-> null
```


### `IsEmpty()`
Determines whether the `LinkedList` is empty or not.

```C#
LinkedList<string> linkedList = new LinkedList<string>();

Console.Write(linkedList.IsEmpty()) // true

linkedList.Push("a");

Console.Write(linkedList.IsEmpty()) // false
```


### `IsFull()`
Determines whether the `LinkedList` is full or not. Returns `false` every time, since it doesn't have a maximum capacity.


### `Count()`
Returns the amount of items on the `LinkedList`.

```C#
LinkedList<double> numbers = new LinkedList<double>();

Console.Write(numbers.Count()); // 0

numbers.Push(3.1415926);

Console.Write(numbers.Count()); // 1
```


### `Insert(value, index)`
Inserts an item on the `LinkedList` at a given index. Returns the inserted node.

```c#
// Before the Insert:
// 
// head
//  \/
// [a-]-> [b-]-> [c-]-> null

linkedList.Insert("d", 2);

// After the Insert:
// head
//  \/
// ["a"-]-> ["b"-]-> ["d"-]-> ["c"-]-> null
```


### `Display()`
Prints all the elements of the `LinkedList`, one per line.

```C#
LinkedList<string> alphabet = new LinkedList<string>("a", "b", "c", "d", "e");

alphabet.Display();

// output:
// 0 - a
// 1 - b
// 2 - c
// 3 - d
// 4 - e
```


### `Delete(item)`
Deletes the first item with the value of the parameter. Return its index.

```C#
// Before the Delete:
// 
// head
//  \/
// ["a"-]-> ["b"-]-> ["d"-]-> ["c"-]-> null

linkedList.Delete("d");

// After the Delete:
// head
//  \/
// [a-]-> [b-]-> [c-]-> null
```


### `Delete(index)`
Deletes an item based on its index, and returns the deleted data.

```C#
// Before the Delete:
// 
// head
//  \/
// ["a"-]-> ["b"-]-> ["d"-]-> ["c"-]-> null

linkedList.Delete(2);

// After the Delete:
// head
//  \/
// [a-]-> [b-]-> [c-]-> null
```


### `Search(item)`
Returns the index of the first item with the value equals to the given parameter.

```C#
LinkedList<string> linkedList = new LinkedList<string>("a", "b", "c", "c", "d", "c");
// head
//  \/
// ["a"-]-> ["b"-]-> ["c"-]-> ["c"-]-> ["d"-]-> ["c"-]-> null

Console.Write(linkedList.Search("c")); // 2
```


### `Search(index)`
Returns the value of an item, based on its index.

```C#
LinkedList<string> linkedList = new LinkedList<string>("a", "b", "c", "c", "d", "c");
// head
//  \/
// ["a"-]-> ["b"-]-> ["c"-]-> ["c"-]-> ["d"-]-> ["c"-]-> null

Console.Write(linkedList.Search(3)); // "c"
```


### `Reverse()`
Changes the current instance to its reversed version. Has no return.
Note that this method **changes** the current instance.

```C#
LinkedList<int> toBeReversed = new LinkedList<int>(1, 2, 3, 4, 5);

// Current:
// [1-]-> [2-]-> [3-]-> [4-]-> [5-]-> null

toBeReversed.Reverse();

// After the Reverse():
// [5-]-> [4-]-> [3-]-> [2-]-> [1-]-> null
```


### `Reversed()`
Returns an reversed copy of the current instance.
Note that this method doesn't change the current instance.

```C#
LinkedList<char> chars = new LinkedList<char>('a', 'b', 'c', 'd', 'e', 'f');
LinkedList<char> reversedChars = chars.Reversed();

chars.Display();
// output:
// 0 - a
// 1 - b
// 2 - c
// 3 - d
// 4 - e
// 5 - f
//
// A lista possui 6 itens.

reversedChars.Display();
// output:
// 0 - f
// 1 - e
// 2 - d
// 3 - c
// 4 - b
// 5 - a
//
// A lista possui 6 itens.
```