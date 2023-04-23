#include <iostream>
#include <ctime>
#define _CRTDBG_MAP_ALLOC
#include <stdlib.h>
#include <crtdbg.h>

using namespace std;

namespace Sample1 {

	class Car {
	public:
		Car() {
			cout << "Car()\n";
		}
		void drive() {
			cout << "Car is driving\n";
		}
		virtual void stop() {
			cout << "Car stopped\n";
		}
		void bar() {
			bar2();
		}
		virtual void bar2() {
			cout << "Car::bar2()\n";
		}
		virtual ~Car() {
			cout << "~Car()\n";
		}
	};

	class Lada : public Car {
	public:
		Lada() {
			cout << "Lada()\n";
		}
		void drive() {
			cout << "Lada is driving\n";
		}
		void stop() override {
			cout << "Lada stopped\n";
		}
		void bar2() override {
			cout << "Lada::bar2()\n";
		}
		~Lada() {
			cout << "~Lada()\n";
		}	
	};

	void foo1() {
		Lada x;
		x.drive(); // переопределенный метод
		x.Car::drive(); // унаследованный метод
	}

	void foo2() {
		cout << '\n';
		Car* x = new Lada;
		x->drive(); // невиртуальный метод
		x->stop(); // виртуальный метод
		delete x; // виртуальный деструктор
	}

	void foo3() {
		cout << '\n';
		Car *x = new Lada;
		x->bar(); // вызывается перекрытый bar2
		delete x;
	}

	void main() {
		foo1();
		foo2();
		foo3();
	}
}

namespace Sample2 {

	class Animal {
	private:
		string name;
	public:
		Animal() {
			cout << "Animal()\n";
		}
		virtual string classname() {
			return "Animal";
		}
		virtual bool isA(const string& who) {
			return who == "Animal";
		}
		virtual void sound() {
			cout << '\n';
		}
		virtual ~Animal() {
			cout << "~Animal()\n";
		}
	};

	class Cat : public Animal {
	public:
		Cat() {
			cout << "Cat()\n";
		}
		string classname() override {
			return "Cat";
		}
		bool isA(const string& who) override {
			return (who == "Cat") || (Animal::isA(who));
		}
		void sound() override {
			cout << "Mew-mew\n";
		}
		void catchMouse() {}
		~Cat() {
			cout << "~Cat()\n";
		}
	};

	class Dog : public Animal {
	public:
		Dog() {
			cout << "Dog()\n";
		}
		string classname() override {
			return "Dog";
		}
		bool isA(const string& who) override {
			return (who == "Dog") || (Animal::isA(who));
		}
		void sound() override {
			cout << "Wow-wow\n";
		}
		void chaseCat() {}
		~Dog() {
			cout << "~Dog()\n";
		}
	};

	class Manul : public Cat {
	public:
		Manul() {
			cout << "Manul()\n";
		}
		string classname() override {
			return "Manul";
		}
		bool isA(const string& who) override {
			return (who == "Manul") || (Cat::isA(who));
		}
		void sound() override {
			cout << "Mew_mew2\n";
		}
		~Manul() {
			cout << "~Manul()\n";
		}
	};

	void main() {
		srand(time(0));
		const int size = 10;
		Animal* zoo[size];
		for (int i = 0; i < size; ++i) {
			int r = rand() % 3;
			if (r == 0) zoo[i] = new Cat;
			else if (r == 1) zoo[i] = new Dog;
			else zoo[i] = new Manul;
		}
		for (int i = 0; i < size; ++i) {
			zoo[i]->sound();
			// проблемы с classname()
			if (zoo[i]->classname() == "Cat" || zoo[i]->classname() == "Manul") {
			}
			// как работает isA()
			if (zoo[i]->isA("Cat")) {
				// небезопасное приведение типов
				((Cat*)zoo[i])->catchMouse();
				static_cast<Cat*>(zoo[i])->catchMouse();
			}
			// безопасное приведение типов
			Cat* c = dynamic_cast<Cat*>(zoo[i]);
			if (c != nullptr) {
				c->catchMouse();
			}
		}
		for (int i = 0; i < size; ++i) {
			delete zoo[i];
		}
	}
}

namespace Sample3 {

	class Base {
	private:
		int val;
	public:
		Base() : val(0) {
			cout << "Base()\n";
		}
		Base(int val_) : val(val_) {
			cout << "Base(int val_)\n";
		}
		Base(Base* obj) {
			cout << "Base(Base* obj)\n";
		}
		Base(const Base& obj) : val(obj.val) {
			cout << "Base(const Base& obj)\n";
		}
		void setVal(int val_) {
			val = val_;
		}
		~Base() {
			cout << "val = " << val << "\n";
			cout << "~Base()\n";
		}
	};

	class Desc : public Base {
	public:
		Desc() {
			cout << "Desc()\n";
		}
		Desc(Desc* obj) {
			cout << "Desc(Desc* obj)\n";
		}
		Desc(const Desc& obj) {
			cout << "Desc(const Desc& obj)\n";
		}
		~Desc() {
			cout << "~Desc()\n";
		}
	};

	// передача объектов в функцию
	void func1(Base obj) {
		obj.setVal(7);
		cout << "return func1\n";
	}
	
	void func2(Base *obj) {
		obj->setVal(7);
		cout << "return func2\n";
	}

	void func3(Base &obj) {
		obj.setVal(7);
		cout << "return func3\n";
	}

	// возврат объекта из функции
	// статические объекты
	Base out1() {
		Base o(1);
		return o;
	}

	Base* out2() {
		Base o(2);
		return &o;
	}

	Base& out3() {
		Base o(3);
		return o;
	}
	// динамические объекты
	Base out4() {
		Base* o = new Base(4);
		return *o;
	}

	Base* out5() {
		Base *o = new Base(5);
		return o;
	}

	Base& out6() {
		Base* o = new Base(6);
		return *o;
	}

	void main() {	
		/*
		Base* x = new Base(5);
		func1(*x);
		func2(x);
		func3(*x);
		delete x;

		Desc* y = new Desc;
		func1(*y);
		func2(y);
		func3(*y);
		delete y;
		*/

		/*
		Base o1 = out1();
		Base o1; o1 = out1();
		Base* o2 = out2();
		Base& o3 = out3();
		Base o4 = out4();
		Base o4; o4 = out4();
		Base* o5 = out5();
		delete o5;
		Base& o6 = out6();
		delete& o6;
		*/
	}
}

namespace Sample4 {

	class Object {
	private:
		int val;
	public:
		Object() : val(0) {
			cout << "Object()\n";
		}
		Object(int val_) : val(val_) {
			cout << "Object(int val_)\n";
		}
		Object(const Object& obj) : val(obj.val) {
			cout << "Object(const Object& obj)\n";
		}
		void add(int val_) {
			val += val_;
		}
		void get() {
			cout << "val = " << val << "\n";
		}
		void foo() {
			cout << "foo()\n";
		}
		~Object() {
			cout << "~Object()\n";
		}
	};

	void smrt_unq(unique_ptr<Object> obj) {
		obj->add(3);
		obj->get();
	}

	unique_ptr<Object> ret_unq(unique_ptr<Object> obj) {
		obj->add(3);
		obj->get();
		return move(obj);
	}

	void smrt_sh(shared_ptr<Object> obj) {
		obj->add(3);
		obj->get();
	}

	shared_ptr<Object> ret_sh(shared_ptr<Object> obj) {
		obj->add(3);
		obj->get();
		return obj;
	}

	void main() {
		
		unique_ptr<Object> p = make_unique<Object>(5);
		p->foo();
		p->get();
		smrt_unq(move(p));
		// p->get(); // нельзя, Object уже удален

		unique_ptr<Object> p2 = make_unique<Object>(5);
		p2->get();
		p2 = ret_unq(move(p2));
		p2 = ret_unq(move(p2)); // можно
		p2->add(10);  
		p2->get();
		
		/*
		shared_ptr<Object> s = make_shared<Object>(10);
		s->foo();
		s->get();
		smrt_sh(s);
		smrt_sh(s); // можно
		s->add(1);
		s->get();

		shared_ptr<Object> s2 = make_shared<Object>(0);
		s2->get();
		s2 = ret_sh(s2);
		s2 = ret_sh(s2); // можно
		s2->add(7);
		s2->get();
		*/
	}
}

int main() { 
	//Sample1::main();
	//Sample2::main();
	//Sample3::main();
	Sample4::main();
	_CrtDumpMemoryLeaks();
	return 0;
}