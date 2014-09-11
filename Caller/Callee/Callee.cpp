// This is the main DLL file.

#include "stdafx.h"

#include "Callee.h"

namespace Callee
{
		void Class1::process_these_files(
		int arr_length,
		array<System::String^>^ files,
		array<System::Byte>^ calcs,
		array<System::UInt64>^ fil_sizes)
		{
			System::Console::WriteLine("In Calls1::process_these_files");
		}
}