namespace Nistec.Printing.View.Pdf
{
    using System;
    using System.Drawing;

    internal class mtd684 : mtd807
    {
        private static int[] var0 = new int[] { 
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0x116, 0, 0, 0, 0, 0, 0, 
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
            0x116, 0x116, 0x163, 0x22c, 0x22c, 0x379, 0x29b, 0xbf, 0x14d, 0x14d, 0x185, 0x248, 0x116, 0x14d, 0x116, 0x116, 
            0x22c, 0x22c, 0x22c, 0x22c, 0x22c, 0x22c, 0x22c, 0x22c, 0x22c, 0x22c, 0x116, 0x116, 0x248, 0x248, 0x248, 0x22c, 
            0x3f7, 0x29b, 0x29b, 0x2d2, 0x2d2, 0x29b, 0x263, 0x30a, 0x2d2, 0x116, 500, 0x29b, 0x22c, 0x341, 0x2d2, 0x30a, 
            0x29b, 0x30a, 0x2d2, 0x29b, 0x263, 0x2d2, 0x29b, 0x3b0, 0x29b, 0x29b, 0x263, 0x116, 0x116, 0x116, 0x1d5, 0x22c, 
            0x14d, 0x22c, 0x22c, 500, 0x22c, 0x22c, 0x116, 0x22c, 0x22c, 0xde, 0xde, 500, 0xde, 0x341, 0x22c, 0x22c, 
            0x22c, 0x22c, 0x14d, 500, 0x116, 0x22c, 500, 0x2d2, 500, 500, 500, 0x14e, 260, 0x14e, 0x248, 350, 
            0x22c, 350, 0xde, 0x22c, 0x14d, 0x3e8, 0x22c, 0x22c, 0x14d, 0x3e8, 0x29b, 0x14d, 0x3e8, 350, 0x263, 350, 
            350, 0xde, 0xde, 0x14d, 0x14d, 350, 0x22c, 0x3e8, 0x14d, 0x3e8, 500, 0x14d, 0x3b0, 350, 500, 0x29b, 
            350, 0x14d, 0x22c, 0x22c, 0x22c, 0x22c, 260, 0x22c, 0x14d, 0x2e1, 370, 0x22c, 0x248, 350, 0x2e1, 0x14d, 
            400, 0x248, 0x14d, 0x14d, 0x14d, 0x22c, 0x219, 0x116, 0x14d, 0x14d, 0x16d, 0x22c, 0x342, 0x342, 0x342, 0x263, 
            0x29b, 0x29b, 0x29b, 0x29b, 0x29b, 0x29b, 0x3e8, 0x2d2, 0x29b, 0x29b, 0x29b, 0x29b, 0x116, 0x116, 0x116, 0x116, 
            0x2d2, 0x2d2, 0x30a, 0x30a, 0x30a, 0x30a, 0x30a, 0x248, 0x30a, 0x2d2, 0x2d2, 0x2d2, 0x2d2, 0x29b, 0x29b, 0x263, 
            0x22c, 0x22c, 0x22c, 0x22c, 0x22c, 0x22c, 0x379, 500, 0x22c, 0x22c, 0x22c, 0x22c, 0x116, 0x116, 0x116, 0x116, 
            0x22c, 0x22c, 0x22c, 0x22c, 0x22c, 0x22c, 0x22c, 0x248, 0x263, 0x22c, 0x22c, 0x22c, 0x22c, 500, 0x22c, 500
         };

        internal mtd684(FontStyle var1)
        {
            base._mtd808 = "Helvetica";
            if ((var1 & FontStyle.Underline) == FontStyle.Underline)
            {
                base._mtd809 = FontStyle.Underline;
            }
        }

        protected override int _mtd810(int var2)
        {
            return var0[var2];
        }
    }
}

