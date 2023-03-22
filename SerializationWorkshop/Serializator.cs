using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SerializationWorkshop
{
    public class Serializator
    {
        public static void Save(object obj)
        {
            Type type = obj.GetType();

            StringBuilder result = new StringBuilder();

            foreach (var prop in type.GetProperties())
            {
                result.Append($"{prop.Name}:{prop.GetValue(obj)}|-|");

            }
            using (StreamWriter writer = new StreamWriter($"../../../{type.Name}.txt"))
            {
                writer.Write(result.ToString());
            }
        }

        public static T Load<T>()
        {
            Type type = typeof(T);

            string data;

            using (StreamReader writer = new StreamReader($"../../../{type.Name}"))
            {
                data = writer.ReadToEnd();
            }

            string[] props = data.Split("|-|");

            T obj = (T)Activator.CreateInstance(type);

            foreach (var propPair in props)
            {
                string[] splittedProp = propPair.Split(":");
                var propInfo = type.GetProperty(splittedProp[0]);

                propInfo.SetValue(obj, splittedProp[1]);
            }
            return obj;
        }
    }
}
