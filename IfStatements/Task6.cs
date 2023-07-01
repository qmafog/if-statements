namespace IfStatements
{
    public static class Task6
    {
        public static int DoSomething(int i)
        {
            if (i < 0)
            {
                if (i < -3)
                {
                    return i;
                }
                else
                {
                    return i + (2 * i);
                }
            }
            else if (i <= 3)
            {
                return i - (i * i);
            }
            else
            {
                return i;
            }
        }
    }
}
