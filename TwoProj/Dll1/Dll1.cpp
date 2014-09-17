// Dll1.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "Dll1.h"
using namespace std;


// This is the constructor of a class that has been exported.
// see Dll1.h for the class definition
CDll1::CDll1()
{
	return;
}

void CDll1::printFunction()
{
	cout << "bla bla" << endl;
}
