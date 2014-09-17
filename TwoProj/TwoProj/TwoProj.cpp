// TwoProj.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "../Dll1/Dll1.h"

int _tmain(int argc, _TCHAR* argv[])
{
	CDll1 *obj = new CDll1();
	obj->printFunction();

	CDll1 obj1;
	obj1.printFunction();

	return 0;
}

