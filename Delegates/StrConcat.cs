namespace Delegates
{
    public struct StrConcat
    {
        private readonly string _myStr;

        public StrConcat(string myStr)
        {
            _myStr = myStr;
        }

        public void ConcatAndPrint(string other)
        {
            Consola.WriteLine(other + _myStr);
        }
    }
}