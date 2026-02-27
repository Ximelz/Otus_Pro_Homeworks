using System;
using System.Collections.Generic;
using System.Text;

//type@@@name@@@value&&&type@@@name@@@value
namespace Homework_6
{
    public class CustomSerializer
    {
        public static string Serialize<T>(T f)
        {
            var type = typeof(T);
            var fields = type.GetFields();
            StringBuilder sb = new StringBuilder();
            foreach (var field in fields)
            {
                sb.Append($"{field.FieldType.Name}@@@{field.Name}@@@{field.GetValue(f)}&&&");
            }
            sb.Remove(sb.Length - 3, 3);
            return sb.ToString();
        }
        public static T Deserialize<T>(string str)
        {
            try
            {
                var type = typeof(T);
                var result = (T)Activator.CreateInstance(type);

                string[] values = str.Split(new string[] { "&&&" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var value in values)
                {
                    string[] attrs = value.Split(new string[] { "@@@" }, StringSplitOptions.RemoveEmptyEntries);
                    if (attrs.Length != 3)
                        throw new Exception();

                    var attrType = type.GetField($"{attrs[1]}");

                    if (attrType.FieldType.Name == attrs[0])
                        attrType.SetValue(result, Convert.ChangeType(attrs[2], attrType.FieldType));
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка преобразования! Ошибка:{ex.Message}");
                return default(T);
            }
        }
    }
}
