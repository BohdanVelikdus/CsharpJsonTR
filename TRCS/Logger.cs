namespace TRCS
{
    internal class Logger
    {
        private string _logFileName;

        public Logger(string _logFileName)
        {
            this._logFileName = _logFileName;
        }

        public void Log(Exception ex) {
            using (StreamWriter sw = new StreamWriter(this._logFileName, append: true))
            {
                var entry =
$@"[{DateTime.Now}]
Exception message: {ex.Message}
Stack trace: {ex.StackTrace}


";
                sw.WriteLine(entry);
            }
            
            
        }
    }
}