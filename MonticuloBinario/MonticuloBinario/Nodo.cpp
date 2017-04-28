#include "Nodo.h"



Nodo::Nodo()
{
	presente = false;
}


Nodo::~Nodo()
{
}

void Nodo::setNodo(int n)
{
	elem = n;
	presente = true;
}

void Nodo::setElemento(int n)
{
	elem = n;
}

void Nodo::setPresente(bool b)
{
	presente = b;
}

int Nodo::getElemento()
{
	return elem;
}

bool Nodo::getPresente()
{
	return presente;
}