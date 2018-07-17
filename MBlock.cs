using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MathBlockBuilder_v2
{
    class MBlock
    {      // MBlock class was written by E.Gonzales for the sole purpose of creating block objects with one int and one image variable. Class is not complete. There are no getters or setters.
            public int num;
            public Image block;

            public MBlock()
            {
                num = 0;
                block = Properties.Resources.blk_0;
            }
            public MBlock(int numIn, Image blockIn)
            {
                num = numIn;
                block = blockIn;
            }
    }
}
