using CourseWork.TestLight;

namespace CourseWork.TestHard
{
    class FillingFormsHT:FilllingOutForms
    {
        FillingInfoForHardTest hardTest = new FillingInfoForHardTest(12);
        public FillingFormsHT()
        {
            hardTest.Search();
            hardTest.AllAnswers();
        }
        public override string AddErrorAns(int i)
        {
            return hardTest.ErrorAns[i];
        }
        public override string AddQ(int i)
        {
            return hardTest.tlQ[i];
        }
        public override string GetTrueAns(int i)
        {
            return hardTest.trueAns[i];
        }
    }
}
