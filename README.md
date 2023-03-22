## 객체 지향 프로그래밍

### Report 1: C#으로 배열과 링크드 리스트를 사용해 스택 구현 & 테스트

### <a href="https://github.com/cottonrose1011/OOP/blob/main/StackEx1/Program.cs">작성한 코드</a>

#### 배열을 이용한 스택 구현


* Class & Constructor

  * UseArray라는 클래스에 int top = -1, 제네릭 배열(T[ ]) stack을 선언하고 생성자에서 배열 길이가 0인 객체를 생성한다.

* Push

  * Array.Resize를 통해 배열의 길이를 1 증가 시킨다.
  
  * top을 1 증가 시키고 인자로 받은 data를 stack[top] 에 할당한다.
  
* Pop
  
  * T 타입으로 선언해서 stack[top--]을 return 한다.
  
* GetTop

  * 스택에 있는 모든 데이터를 Pop할 때 top가 배열의 사이즈를 넘는 횟수를 반복하지 않기 위해 작성.


#### 링크드 리스트를 이용한 스택 구현


* Class & Constructor

  * UseLinkedList라는 클래스에 int top = 0, ```LinkedList<T> stack```을 선언하고 생성자에서 새로운 객체를 생성한다.
  * 여기서 top은 Pop을 할 때 counting을 하기 위한 용도로 사용되고, Collection을 사용했기 때문에 따로 Node 클래스는 만들지 않았다.

* Push

  * ```LikedList<T>.AddLast(T value)``` 메소드로 Push를 한다.
  
  * top++
  
* Pop
  
  * 제네릭 타입의 data를 선언하고 ```LikedList<T>.Last()``` 메소드를 통해 리스트의 마지막에 있는 (stack의 top) 값을 data에 할당.
  * ```LikedList<T>.RemoveLast()```로 top을 삭제하고 data를 return.
  
* GetTop

  * 스택에 있는 모든 데이터를 Pop할 때 top가 리스트의 길이를 넘는 횟수를 반복하지 않기 위해 작성.



#### 실행 결과

<img width="391" alt="테스트화면" src="https://user-images.githubusercontent.com/101866860/226941845-7a0a1550-e45e-4da8-b939-53a656723d62.png">

