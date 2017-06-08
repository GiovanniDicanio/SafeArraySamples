//////////////////////////////////////////////////////////////////////////
//
// This native C-interface DLL produces safe arrays that are exported 
// at the DLL interface.
// 
// Note that the code inside the DLL is C++.
// 
// by Giovanni Dicanio
// 
////////////////////////////////////////////////////////////////////////// 


// C++ Standard Library Includes
#include <exception>    // For std::exception
#include <string>       // For std::wstring
#include <vector>       // For std::vector

// ATL Includes
#include <atlbase.h>    // For ATL::CComBSTR
#include <atlsafe.h>    // For ATL::CComSafeArray


// Demo function that produces a safe array of bytes
extern "C" HRESULT __stdcall ProduceSafeArrayOfBytes(/* [out] */ SAFEARRAY** ppsa)
{
    HRESULT hr = S_OK;

    try
    {
        // Source data
        std::vector<BYTE> v{ 11, 22, 33, 44, 55, 66, 77 };

        // Build the destination safe array from the source data
        const int count = static_cast<int>(v.size());
        CComSafeArray<BYTE> sa(count);
        for (int i = 0; i < count; i++)
        {
            sa[i] = v[i];
        }

        // Return the safe array to the caller (transfer ownership)
        *ppsa = sa.Detach();
    }
    catch (const CAtlException& e)
    {
        hr = e;
    }
    catch (const std::exception& )
    { 
        hr = E_FAIL;
    }

    return hr;
}


// Helper function to convert a std::wstring to the ATL CComBSTR wrapper
inline CComBSTR ToBstr(const std::wstring& s)
{
    // Special case of empty string
    if (s.empty())
    {
        return CComBSTR();
    }

    return CComBSTR(static_cast<int>(s.size()), s.data());
}


// Demo function that produces a safe array of BSTR strings
extern "C" HRESULT __stdcall ProduceSafeArrayOfStrings(/* [out] */ SAFEARRAY** ppsa)
{
    HRESULT hr = S_OK;

    try
    {
        // Source data
        std::vector<std::wstring> v{ L"Gio", L"Connie", L"Hello World" };

        // Build the destination safe array from the source data
        const LONG count = static_cast<LONG>(v.size());
        CComSafeArray<BSTR> sa(count);
        for (LONG i = 0; i < count; i++)
        {
            // Create a BSTR from the std::wstring
            CComBSTR bstr = ToBstr(v[i]);

            // Move the BSTR into the safe array
            hr = sa.SetAt(i, bstr.Detach(), FALSE);
            if (FAILED(hr))
            {
                AtlThrow(hr);
            }
        }

        // Return the safe array to the caller (transfer ownership)
        *ppsa = sa.Detach();
    }
    catch (const CAtlException& e)
    {
        hr = e;
    }
    catch (const std::exception& )
    {
        hr = E_FAIL;
    }

    return hr;
}

