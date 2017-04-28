#ifndef NODO_H
#define NODO_H

#include<iostream>

using namespace std;

class Nodo
{
private:
	int elem;
	bool presente;
public:
	Nodo();
	~Nodo();
	bool getPresente();
	int getElemento();

	void setPresente(bool);
	void setNodo(int);
	void setElemento(int);
};
#endif
