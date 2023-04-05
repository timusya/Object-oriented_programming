#include <iostream>

using namespace std;

// класс Точка
class Point {
private:
	int x{ 0 };
	int y{ 0 };
public:
	// конструктор по умолчанию
	Point() {
		cout << "Point()\n";
	}
	// конструктор с параметрами
	Point(int x, int y) : x(x), y(y) {
		cout << "Point(int x, int y)\n";
	}
	// конструктор копирования
	Point(const Point& p) : x(p.x), y(p.y) {
		cout << "Point(const Point& p)\n";
	}
	// деструктор
	~Point() {
		cout << x << ' ' << y << '\n';
		cout << "~Point()\n";
	}
	// реализация метода в определении класса
	void move(int dx, int dy) {
		x += dx;
		y += dy;
	}
	void reset();
};
// реализация метода после определения класса
void Point::reset() {
	x = 0;
	y = 0;
}

int main() {
	/*
	// Создание, использование и уничтоженеие статически создаваемых объектов
	Point a;
	Point b(1, 3);
	Point c(b);
	Point d(c);
	d.reset();
	d.move(5, 5);
	*/

	// Создание, использование и уничтоженеие динамически создаваемых объектов
	Point *pa = new Point;
	Point *pb = new Point(13, 9);
	Point *pc = new Point(*pb);
	Point* pd = new Point(*pb);
	pd->move(2, 3);
	delete pa;
	delete pb;
	delete pc;
	delete pd;

	return 0;
}