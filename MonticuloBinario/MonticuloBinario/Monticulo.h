#ifndef MONTICULO_H
#define MONTICULO_H
#include<iostream>
#include"Nodo.h"

using namespace std;

class Monticulo
{
private:
	Nodo vec[11000];
	int ultimoHoja;
	int pos;
public:
	Monticulo();
	~Monticulo();

	void recuperarAbajoArriba(int);
	void insertar(Nodo);
	void recuperarArribaAbajo(int);
	int eliminar();
	void MostrarPorNiveles();
};

#endif