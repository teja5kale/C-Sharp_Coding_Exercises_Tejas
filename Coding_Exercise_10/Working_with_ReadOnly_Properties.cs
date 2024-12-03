using System;

namespace Coding_Exercise_10
{
    public class Working_with_ReadOnly_Properties
    {
        private readonly string _readOnlyField;

        public Working_with_ReadOnly_Properties(string value)
        {
            _readOnlyField = value;
        }

        public string ReadOnlyProperty
        {
            get { return _readOnlyField; }
        }

        static void Main(string[] args)
        {
            var myObject = new Working_with_ReadOnly_Properties("Read-Only Property Value");

            Console.WriteLine(myObject.ReadOnlyProperty);

            Console.ReadKey();
        }
    }
}
