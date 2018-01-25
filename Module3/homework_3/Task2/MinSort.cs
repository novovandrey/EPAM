﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    public class MinSort:ISortTypes
    {
        public bool AscFlag { get; set; }

        public MinSort(bool AscFlag)
        {
            this.AscFlag = AscFlag;
        }

        public int Compare(int comp1,int comp2)
        {
            return (comp2 > comp1) ? comp1 : comp2;
        }
    }
}
