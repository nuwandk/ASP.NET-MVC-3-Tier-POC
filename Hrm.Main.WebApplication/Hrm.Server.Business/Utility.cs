using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Server.Business
{
    public static class Utility
    {
        public static void CopyPropertiesTo<T, U>(this T source, U dest)
        {
            var plistsource = from prop1 in typeof(T).GetProperties() select prop1;
            var plistdest = from prop2 in typeof(U).GetProperties() select prop2;

            foreach (PropertyInfo destprop in plistdest)
            {
                var sourceprops = plistsource.Where((p) => p.Name == destprop.Name &&
                  destprop.PropertyType.IsAssignableFrom(p.GetType()));
                foreach (PropertyInfo sourceprop in sourceprops)
                { // should only be one
                    destprop.SetValue(dest, sourceprop.GetValue(source, null), null);
                }
            }
        }
    }
}
