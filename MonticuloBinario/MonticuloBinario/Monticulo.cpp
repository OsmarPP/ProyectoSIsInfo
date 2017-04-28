#include "Monticulo.h"



Monticulo::Monticulo()
{
	ultimoHoja = 0;
	pos = 0;
}


Monticulo::~Monticulo()
{
}

void Monticulo::recuperarAbajoArriba(int hoja)
{
	if (hoja != 1)
	{
		if (vec[hoja].getElemento() > vec[hoja / 2].getElemento())
		{
			swap(vec[hoja], vec[pos / 2]);
		}
		recuperarAbajoArriba(hoja / 2);
	}
}

void Monticulo::insertar(Nodo elem)
{
	if (ultimoHoja == 0)
	{
		ultimoHoja = 1;
		vec[ultimoHoja] = elem;
		vec[ultimoHoja].setPresente(true);
	}
	else
	{
		ultimoHoja++;
		vec[ultimoHoja] = elem;
		vec[ultimoHoja].setPresente(true);
		recuperarAbajoArriba(ultimoHoja);
	}
}

void Monticulo::recuperarArribaAbajo(int nodo)
{
	if (ultimoHoja > pos)
	{
		if (ultimoHoja > pos * 2 + 1)
		{
			if (vec[pos * 2].getElemento() > vec[pos * 2 + 1].getElemento())
			{
				if (vec[pos * 2].getElemento() > vec[pos].getElemento())
				{
					swap(vec[pos], vec[pos * 2]);
					recuperarArribaAbajo(pos * 2);
				}
			}
			else
			{
				if (vec[pos * 2 + 1].getElemento() > vec[pos].getElemento())
				{
					swap(vec[pos * 2 + 1], vec[pos]);
					recuperarArribaAbajo(pos * 2 + 1);
				}
			}
		}
		if (ultimoHoja >= pos * 2)
		{
			if (vec[pos].getElemento() > vec[pos * 2].getElemento())
			{
				if (vec[pos * 2].getElemento() > vec[pos].getElemento())
				{
					swap(vec[pos], vec[pos * 2]);
					recuperarArribaAbajo(pos * 2);
				}
			}
		}
	}
}

int Monticulo::eliminar()
{
	int elem;
	if (ultimoHoja < 0)
	{
		elem = 0;
	}
	else
	{
		elem = vec[1].getElemento();
		vec[1] = vec[ultimoHoja];
		vec[ultimoHoja].setPresente(false);
		ultimoHoja = ultimoHoja - 1;
		recuperarArribaAbajo(1);
	}
	return elem;
}

void Monticulo::MostrarPorNiveles()
{
	int temp, pot = 1;
	for (int i = 1; i <= ultimoHoja; i++)
	{
		temp = pow(2, pot);
		if (temp == i)
		{
			pot++;
			cout << endl;
		}
		cout << vec[i].getElemento() << ", ";
	}
	cout << endl;
}