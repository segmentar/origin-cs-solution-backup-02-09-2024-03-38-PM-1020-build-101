﻿using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        [Scopexportableisc]
        public partial class XQuadruple
        {
            public ScopexportablelevelBodyXopq_stY[] LevelArray;

            public XQuadruple(ScopexportablelevelBodyXopq_stY[] levelArray)
            {
                this.LevelArray = levelArray;

                return;
            }

            ~XQuadruple()
            {
                return;
            }

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(XQuadruple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(LevelArray) + ':' + ' ' + ". . ." + ' ' + $"<{LevelArray.Length}>", 
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(LevelArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), LevelArray)
                });
            }
        }
    }
}
