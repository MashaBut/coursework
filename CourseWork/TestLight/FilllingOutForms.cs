namespace CourseWork.TestLight
{
    class FilllingOutForms
    {
        BuildTestForm buildTestForm = new BuildTestForm(10);
        public FilllingOutForms()
        {
            buildTestForm.Search();
        }
        public virtual string AddQ(int i)
        {
            return buildTestForm.tlQ[i];
        }
        public virtual string GetTrueAns(int i)
        {
            return buildTestForm.trueAns[i];
        }
        public virtual string AddErrorAns(int i)
        {
            return buildTestForm.ErrorAns[i];
        }
    }
}
