using System;

namespace oop_6115261002_w08
{
    class Program
    {
        static void Main(string[] args)
        {
            Singer s1 = new Singer("Thongchai", "	Bird", "61", "1958 December 8");
            Singer s2 = new Singer("Eve", "Palmy", "39", "1981 August 7");
            Singer s3 = new Singer("Rhatha", "Ying", "37", "1983 May 19 ");
            Musiclabel m1 = new Musiclabel("GMM", "Bangkok", "Rewat", s2);
            Console.WriteLine(m1);
        }
    }
}
