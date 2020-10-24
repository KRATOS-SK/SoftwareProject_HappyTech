using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    public class AssignCommentCodeRange
    {
        public int baseValue,section1Range,section2Range,section3Range,section4Range;

        public AssignCommentCodeRange(String typeOfTemplate)
        {
            if(typeOfTemplate == "CV")
            {
                baseValue = 100;
                section1Range = 110;
                section2Range = 120;
                section3Range = 130;
                section4Range = 140;
            }
            if (typeOfTemplate == "Online Test")
            {
                baseValue = 200;
                section1Range = 210;
                section2Range = 220;
                section3Range = 230;
                section4Range = 240;
            }
            if (typeOfTemplate == "Interview Report")
            {
                baseValue = 300;
                section1Range = 310;
                section2Range = 320;
                section3Range = 330;
                section4Range = 340;
            }
        }
    }
}
