using System.Diagnostics;
using ClangSharp.Interop;

namespace ClangSharp
{
    internal sealed class CXXDestructorDecl : CXXMethodDecl
    {
        public CXXDestructorDecl(CXCursor handle, Cursor parent) : base(handle, parent)
        {
            Debug.Assert(handle.Kind == CXCursorKind.CXCursor_Destructor);
        }
    }
}