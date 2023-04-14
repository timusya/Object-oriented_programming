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

int main() {

	_CrtDumpMemoryLeaks();
	return 0;
}