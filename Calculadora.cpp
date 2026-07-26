#include <iostream>
using namespace std;

void convertirMaya(int numero, int niveles[], int &cantidad)
{
    cantidad = 0;

    if(numero == 0)
    {
        niveles[cantidad++] = 0;
        return;
    }

    while(numero > 0)
    {
        niveles[cantidad] = numero % 20;
        numero /= 20;
        cantidad++;
    }
}

void dibujarNivel(int valor)
{
    if(valor == 0)
    {
        cout << "   0" << endl;
        return;
    }

    int barras = valor / 5;
    int puntos = valor % 5;

    for(int i=0; i<puntos; i++)
        cout << " ●";

    if(puntos>0)
        cout << endl;

    for(int i=0; i<barras; i++)
        cout << "═════" << endl;
}

void mostrarNumeroMaya(int niveles[], int cantidad)
{
    cout << "\n===== NUMERO MAYA =====\n\n";

    for(int i=cantidad-1; i>=0; i--)
    {
        cout << "Nivel " << cantidad-i << endl;
        dibujarNivel(niveles[i]);
        cout << endl;
    }
}

int main()
{
    int numero;
    int niveles[20];
    int cantidad;

    cout << "Ingrese un numero decimal: ";
    cin >> numero;

    if(numero < 0)
    {
        cout << "Solo se permiten numeros positivos.";
        return 0;
    }

    convertirMaya(numero,niveles,cantidad);

    mostrarNumeroMaya(niveles,cantidad);

    cout << "Programa creado por Jose Argueta";

    return 0;
}