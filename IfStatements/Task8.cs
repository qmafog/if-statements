namespace IfStatements
{
    public static class Task8
    {
        public static bool DoSomething(bool b, int i)
        {
            if (i == 3 || i == -3)
            {
                return b;
            }

            if (i == 0 || (i >= -6 && i < -3) || (i > 3 && i <= 6))
            {
                return false;
            }

            return true;
        }
    }
}
