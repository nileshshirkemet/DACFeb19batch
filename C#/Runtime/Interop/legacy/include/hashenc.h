#pragma once
#include <wchar.h>

long __stdcall HashOfString(const wchar_t* str);

int __stdcall EncodeBuffer(char* buf, int sz);

