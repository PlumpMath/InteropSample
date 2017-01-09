#include "NativeModule.h"

NATIVE_MODULE_API void Test(TestData data)
{
    const wchar_t*  stringVar = data.stringData;
    bool boolVar = data.boolVar;
    char charVar = data.charVar;
    
    int intVar = data.IntVar;
    int size = sizeof(TestData);
}
