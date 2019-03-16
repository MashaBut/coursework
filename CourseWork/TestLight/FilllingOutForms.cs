using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.TestLight
{
    class FilllingOutForms
    {
        BuildTestForm buildTestForm = new BuildTestForm();
        public FilllingOutForms()
        {
            buildTestForm.Search();
        }
        public string AddQ(int i)
        {
            return buildTestForm.tlQ[i];
        }
        public string AddTrueAns(int i)
        {
            return buildTestForm.trueAns[i];
        }
        public string AddErrorAns(int i)
        {
            return buildTestForm.ErrorAns[i];
        }
    }
}
