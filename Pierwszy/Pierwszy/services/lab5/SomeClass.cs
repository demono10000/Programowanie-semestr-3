﻿namespace Pierwszy.services.lab5
{
    public class SomeClass
    {
        public string Print(string text)
        {
            try
            {
                return text.Length.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new InvalidDepartmentException("Custom exception");
            }
        }
    }
}
