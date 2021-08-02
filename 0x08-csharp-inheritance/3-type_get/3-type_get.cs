using System;
using System.Collections.Generic;
using System.Reflection;


/// <summary>Public Obj class.</summary>
class Obj
{
    /// <summary>Public Obj class.</summary>
    public static void Print(object myObj)
    {
        TypeInfo details = myObj.GetType().GetTypeInfo();
        Console.WriteLine("{0} Properties:", details.Name);
        foreach (PropertyInfo p in details.GetProperties())
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine("{0} Methods:", details.Name);
        foreach (MethodInfo m in details.GetMethods())
        {
            Console.WriteLine(m.Name);
        }
        
    }
}
