using System;
using System.Collections.Generic;

namespace todo_uygulamasi
{
    static class Kisiler
    {
        public static Dictionary<int, string> takimUyeleri = new Dictionary<int, string>();

        public static void VarsayilanKisiler()
        {
            takimUyeleri.Add(1, "Ayşe Yılmaz");
            takimUyeleri.Add(2, "Ahmet Yılmaz");
            takimUyeleri.Add(3, "Deniz Arda");
            takimUyeleri.Add(4, "Özcan Coşar");
        }
    }
}
