# region datos informativos
                                    // realizado por: danilo duran
                                    // fecha        : 24 de octubre del 2014
                                    // lugar        : laboratorio 3
                                    // materia      : desarrollo 2
                                    // objetivo     : 
# endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appTiposdeDato
{
    public partial class formulariodetipos : Form
    {
        public formulariodetipos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //tipos de datos
            // 1.- valor
            // 2.- referencia

            // valor
# region datos numericos
            byte b1;
            Byte b2;
            short s1;
            Int16 s2;
            
            ushort s3;
            UInt16 s4;

            int i1;
            Int32 i2;

            uint i3;
            UInt32 i4;

            long l1;
            Int64 l2;

            ulong l3;
            ulong l4;
           


# endregion
            # region datos flotantes
            float f1;
            Single f2;

            double d1;
            Double d2;

            decimal d3;
            Decimal d4;

# endregion

# region tipos caracter
            char c1;
            Char c2;

            string ss1;
            String ss2;

# endregion

# region booleanos
            bool b5;
            Boolean b6;
# endregion
        }
    }
}
