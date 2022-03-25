using System;
using System.Collections.Generic;
using System.Text;
using static MoodAnalyserProblems.CustomException;

namespace MoodAnalyserProblems
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string moodMessage)
        {
            try
            {
                if (moodMessage == null)
                {
                    throw new CustomException(ExceptionType.NULL_MESSAGE_EXCEPTION, "Null message passed.");
                }
                if (moodMessage.Equals(string.Empty))
                {
                    throw new CustomException(ExceptionType.EMPTY_MESSAGE_EXCEPTION, "Empty message passed.");
                }
                if (moodMessage.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}