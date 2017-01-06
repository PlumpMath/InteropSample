#pragma once

#include "test_data.h"

#ifdef INTEROPNATIVE_EXPORTS
#define NATIVE_MODULE_API extern "C" __declspec(dllexport)
#else
#define NATIVE_MODULE_API extern "C" __declspec(dllimport)
#endif

NATIVE_MODULE_API void Test(TestData data);