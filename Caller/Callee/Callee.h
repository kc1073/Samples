// Callee.h

#pragma once

using namespace System;

namespace Callee {

	public ref class Class1
	{
	public:
		static void process_these_files(
		int arr_length,
		array<System::String^>^ files,
		array<System::Byte>^ calcs,
		array<System::UInt64>^ fil_sizes);
		
	};
}
