#include<iostream>
#include"Monticulo.h"
#include"Nodo.h"

using namespace std;

int Menu()
{
	int op;
	cout << "1.- Insertar" << endl;
	cout << "2.- Mostrar por Nivel" << endl;
	cout << "3.- Eliminar" << endl;
	cin >> op;
	return op;
}

int main()
{
	Monticulo arbol;
	Nodo nodo;
	int op;
	do
	{
		op = Menu();
		system("cls");
		if (op == 1)
		{
			int ele;
			cout << "Ingrese un elemento : ";
			cin >> ele;
			nodo.setElemento(ele);
			nodo.setPresente(true);
			arbol.insertar(nodo);
		}
		if (op == 2)
		{
			arbol.MostrarPorNiveles();
		}
		if (op == 3)
		{
			cout << arbol.eliminar() << endl;;
		}
		system("pause");
		system("cls");
	} while (op!=0);
	return 0;
}