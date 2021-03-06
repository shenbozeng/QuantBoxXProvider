using System;
namespace TaLib
{
    public partial class Core
    {
        public static RetCode Exp(int startIdx, int endIdx, double[] inReal, ref int outBegIdx, ref int outNBElement, double[] outReal)
        {
            if (startIdx < 0) {
                return RetCode.OutOfRangeStartIndex;
            }
            if ((endIdx < 0) || (endIdx < startIdx)) {
                return RetCode.OutOfRangeEndIndex;
            }
            if (inReal == null) {
                return RetCode.BadParam;
            }
            if (outReal == null) {
                return RetCode.BadParam;
            }
            int i = startIdx;
            int outIdx = 0;
            while (i <= endIdx) {
                outReal[outIdx] = Math.Exp(inReal[i]);
                i++;
                outIdx++;
            }
            outNBElement = outIdx;
            outBegIdx = startIdx;
            return RetCode.Success;
        }
        public static RetCode Exp(int startIdx, int endIdx, float[] inReal, ref int outBegIdx, ref int outNBElement, double[] outReal)
        {
            if (startIdx < 0) {
                return RetCode.OutOfRangeStartIndex;
            }
            if ((endIdx < 0) || (endIdx < startIdx)) {
                return RetCode.OutOfRangeEndIndex;
            }
            if (inReal == null) {
                return RetCode.BadParam;
            }
            if (outReal == null) {
                return RetCode.BadParam;
            }
            int i = startIdx;
            int outIdx = 0;
            while (i <= endIdx) {
                outReal[outIdx] = Math.Exp((double)inReal[i]);
                i++;
                outIdx++;
            }
            outNBElement = outIdx;
            outBegIdx = startIdx;
            return RetCode.Success;
        }
        public static int ExpLookback()
        {
            return 0;
        }
    }
}
