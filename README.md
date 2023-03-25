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

* Node & MyLinkedList 클래스

  * Node 클래스는 Key와 Next로 이루어짐.
  
  * MyLinkedList는 Stack 구현에 필요한 기능만 구현하였다.
  
  * LinkedList의 Head 부분을 Stack의 Top 부분으로 사용해서 구현, Pop역시 Head를 삭제하는 방법으로 구현하였다.


* Class & Constructor

  * UseLinkedList라는 클래스에 int top = -1, ```MyLinkedList<T> stack```을 선언하고 생성자에서 새로운 객체를 생성한다.
  * 여기서 top은 Pop을 할 때 counting을 하기 위한 용도로 사용되었다.

* Push

  * ```MyLikedList<T>.addHead(T key)``` 메소드로 Push를 한다(Head를 현재 노드로 최신화). 
  
  * top++
  
* Pop
  
  * 제네릭 타입의 data를 선언하고 ```MyLikedList<T>.getHead()``` 메소드를 통해 리스트의 마지막에 있는 (stack의 top) 값을 data에 할당.
  * ```MyLikedList<T>.deleteHead()```로 top을 삭제하고 data를 return.
  
* GetTop

  * 스택에 있는 모든 데이터를 Pop할 때 리스트의 길이를 넘는 횟수를 반복하지 않기 위해 카운팅한 Top을 return.



#### 테스트 과정


* Array

  * 정수형 타입으로 선언하고 정수 1,2,3을 Push후 전부 Pop

* LinkedList

  * 문자열 타입으로 선언하고 ABC, KSU, OOP 를 Push, 1번의 Pop 이후 C#, STACK을 Push한 후 전부 Pop

#### 실행 결과


<img width="391" alt="테스트화면" src="https://user-images.githubusercontent.com/101866860/226941845-7a0a1550-e45e-4da8-b939-53a656723d62.png">

