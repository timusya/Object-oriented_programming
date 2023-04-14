#include <iostream>
#include <cassert>
#include <ctime>
#define _CRTDBG_MAP_ALLOC
#include <stdlib.h>
#include <crtdbg.h>

using namespace std;

// базовый класс Base
class Base {
public:
	Base() {
		cout << "Base()\n";
	}
	virtual void classname() = 0;
	virtual ~Base() {
		cout << "~Base()\n";
	}
};

// класс Class1 - наследник от Base
class Class1 : public Base {
public:
	Class1() {
		cout << "Class1()\n";
	}
	~Class1() {
		cout << "~Class1()\n";
	}
	void classname() override {
		cout << "Class1::classname\n";
	}
	virtual void mew() {
		cout << "Class1::mew\n";
	}
};

// класс Class2 - наследник от Class1
class Class2 : public Class1 {
public:
	Class2() {
		cout << "Class2()\n";
	}
	~Class2() {
		cout << "~Class2()\n";
	}
	void classname() override {
		cout << "Class2::classname\n";
	}
	void mew() override {
		cout << "Class2::mew\n";
	}
};

// класс Class3 - наследник от Base
class Class3 : public Base {
public:
	Class3() {
		cout << "Class3()\n";
	}
	~Class3() {
		cout << "~Class3()\n";
	}
	void classname() override {
		cout << "Class3::classname\n";
	}
	void wow() {
		cout << "Class3::wow\n";
	}
};

// класс Class4 - наследник от Class3
class Class4 : public Class3 {
public:
	Class4() {
		cout << "Class4()\n";
	}
	~Class4() {
		cout << "~Class4()\n";
	}
	void classname() override {
		cout << "Class4::classname\n";
	}
	void wow() {
		cout << "Class4::wow\n";
	}
};

// класс Container
class Container {
private:
	int size;
	Base** arr;
public:
	// конструктор без параметров
	Container() : size(0), arr(new Base* [size]()) {
		cout << "Container()\n";
	}
	// конструктор с параметрами
	Container(int size) : size(size), arr(new Base* [size]()) {
		cout << "Container(int size)\n";
	}
	// деструктор
	~Container() {
		for (int i = 0; i < size; ++i) {
			if (arr[i]) delete[] arr[i];
		}
		delete[] arr;
		cout << "~Container()\n";
	}
	// метод получения размера контейнера
	int get_size() {
		return size;
	}
	// вспомогательный метод для получения содержимого контейнера
	void info() {
		cout << "size = " << size << "\n";
		cout << "container: \n";
		for (int i = 0; i < size; ++i) {
			if (arr[i]) arr[i]->classname();
			else cout << "NULL\n";
		}
	}
	// метод установки в контейнер по индексу
	void set(int pos, Base* x) {
		assert(0 <= pos && pos < size);
		if (arr[pos]) delete[] arr[pos];
		arr[pos] = x;
	}
	// метод получения из контейнера по индексу
	Base* get(int pos) {
		assert(0 <= pos && pos < size);
		return arr[pos];
	}
	// метод вставки в контейнер по индексу
	void insert(int pos, Base* x) {
		assert(0 <= pos && pos <= size);
		Base** new_arr = new Base * [size + 1];
		for (int i = 0; i < pos; ++i) {
			new_arr[i] = arr[i];
		}
		new_arr[pos] = x;
		for (int i = pos + 1; i <= size; ++i) {
			new_arr[i] = arr[i - 1];
		}
		delete[] arr;
		size++;
		arr = new_arr;
	}
	// метод удаления из контейнера по индексу
	void remove(int pos) {
		assert(0 <= pos && pos < size);
		size--;
		Base** new_arr = new Base * [size];
		for (int i = 0; i < pos; ++i) {
			new_arr[i] = arr[i];
		}
		for (int i = pos; i < size; ++i) {
			new_arr[i] = arr[i + 1];
		}
		delete[] arr[pos];
		delete[] arr;
		arr = new_arr;
	}
};

int main() {

	_CrtDumpMemoryLeaks();
	return 0;
}