﻿#if NET || NETCORE

#pragma warning disable 1591 // 1591 = missing xml

namespace Orchestra.StylesExplorer.MarkupReflection
{
    internal interface ITypeResolver
    {
        IType GetTypeByAssemblyQualifiedName(string name);
        IDependencyPropertyDescriptor GetDependencyPropertyDescriptor(string name, IType ownerType, IType targetType);
    }
}

#endif
