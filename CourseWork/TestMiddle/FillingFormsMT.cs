using CourseWork.TestLight;

namespace CourseWork.TestMiddle
{
    class FillingFormsMT:FilllingOutForms
    {
        FillingMiddleTest fillingMiddleTest = new FillingMiddleTest(24);
        public FillingFormsMT()
        {
            fillingMiddleTest.Search();
            fillingMiddleTest.AllAnswers();
        }
        public override string AddErrorAns(int i)
        {
            return fillingMiddleTest.ErrorAns[i];
        }
        public override string AddQ(int i)
        {
            return fillingMiddleTest.tlQ[i];
        }
        public override string GetTrueAns(int i)
        {
            return fillingMiddleTest.trueAns[i];
        }
    }
}
