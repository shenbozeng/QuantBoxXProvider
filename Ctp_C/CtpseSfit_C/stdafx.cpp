// stdafx.cpp : 只包括标准包含文件的源文件
// Ctp_C.pch 将作为预编译标头
// stdafx.obj 将包含预编译类型信息

#include "stdafx.h"

#ifdef _WIN64
#pragma comment(lib, "..\\external-bin\\ctpse\\x64\\thostmduserapi_se.lib")
#pragma comment(lib, "..\\external-bin\\ctpse\\x64\\thosttraderapi_se.lib")
#else
#pragma comment(lib, "..\\external-bin\\ctpse\\x86\\thostmduserapi_se.lib")
#pragma comment(lib, "..\\external-bin\\ctpse\\x86\\thosttraderapi_se.lib")
#endif // !_WIN64
