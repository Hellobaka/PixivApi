using System;
using System.Collections.Generic;
using System.Text;

namespace Scighost.PixivApi
{
    public class CommonHelper
    {
        public static int Clamp(int a, int min, int max)
        {
            if (a < min) return min;
            if(a > max) return max;
            return a;
        }
    }
}
