namespace IfStatements
{
#pragma warning disable
    public static class Task10
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1 && b2)
            {
                if (i < -9)
                {
                    return i;
                }
                else if (i >= -9 && i <= -2)
                {
                    return 5 + i;
                }
                else if (i > -2 && i < 0)
                {
                    return i;
                }
                else if (i == 0)
                {
                    return -1;
                }
                else if (i > 0 && i < 2)
                {
                    return i;
                }
                else if (i >= 2 && i <= 9)
                {
                    return 10 - i;
                }
                else
                {
                    return i;
                }
            }
            else if (b1 && !b2)
            {
                if (i < -9)
                {
                    return i;
                }
                else if (i >= -9 && i <= -2)
                {
                    return 5 - i;
                }
                else if (i > -2 && i < 0)
                {
                    return i;
                }
                else if (i == 0)
                {
                    return -1;
                }
                else if (i > 0 && i < 2)
                {
                    return i;
                }
                else if (i >= 2 && i <= 9)
                {
                    return 10 + i;
                }
                else
                {
                    return i;
                }
            }
            else if (!b1 && b2)
            {
                if (i <= -10)
                {
                    return i + 1;
                }
                else if (i > -10 && i <= -5)
                {
                    return i;
                }
                else if (i > -5 && i < 0)
                {
                    return i + 10;
                }
                else if (i == 0)
                {
                    return 1;
                }
                else if (i > 0 && i < 5)
                {
                    return i + 10;
                }
                else if (i >= 5 && i < 10)
                {
                    return i;
                }
                else
                {
                    return i + 1;
                }
            }
            else
            {
                if (i <= -10)
                {
                    return i - 1;
                }
                else if (i > -10 && i <= -5)
                {
                    return i;
                }
                else if (i > -5 && i < 0)
                {
                    return i - 10;
                }
                else if (i == 0)
                {
                    return -1;
                }
                else if (i > 0 && i < 5)
                {
                    return i - 10;
                }
                else if (i >= 5 && i < 10)
                {
                    return i;
                }
                else
                {
                    return i - 1;
                }
            }
        }
    }
}
