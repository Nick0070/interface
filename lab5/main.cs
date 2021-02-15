using System;

namespace lab5
{
    class main
    {
        static void Main(string[] args)
        {

            IPCtex PCtex1 = new Server();
            IPCtex PCtex2 = new notebook();
            IPCtex PCtex3 = new PC();

            PCtex1.see();
            PCtex2.see();
            PCtex3.see();
        }

    }
}
