namespace IfStatements
{
    public static class Task7
    {
        public static int DoSomething(bool b, int i)
        {
            if (b)
            {
                if (i > -7 && i < 7)
                {
                    return 7 - i;
                }
                else
                {
                    return i;
                }
            }
            else
            {
                if (i > -5 && i < 5)
                {
                    return i;
                }
                else
                {
                    return i + 5;
                }
            }
        }
    }
}
