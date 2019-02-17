using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NBrowse.Reflection;

namespace NBrowse.Selection
{
    public static class Is
    {
        public static System.Func<Type, bool> Generated => type => Has.Attribute<CompilerGeneratedAttribute>(type);
    }
}