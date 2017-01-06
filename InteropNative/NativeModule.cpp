#include "NativeModule.h"

NATIVE_MODULE_API void Test(TestData data)
{
    bool boolVar = data.boolVar;
    char charVar = data.charVar;
    int intVar = data.IntVar;
}
