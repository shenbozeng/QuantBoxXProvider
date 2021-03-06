﻿namespace QuantBox.XApi
{
    public class RspUserLoginField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        public int TradingDay;
        /// <summary>
        /// 登陆时间
        /// </summary>
        public int LoginTime;
        /// <summary>
        /// 
        /// </summary>
        public string SessionID;
        /// <summary>
        /// 
        /// </summary>
        public string UserID;
        /// <summary>
        /// 
        /// </summary>
        public string AccountID;
        /// <summary>
        /// 投资者名称
        /// </summary>
        public string InvestorName;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int XErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        public int RawErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        public string Text;

        public RspUserLoginField()
        {
        }

        internal RspUserLoginField(InternalRspUserLoginField field)
        {
            TradingDay = field.TradingDay;
            LoginTime = field.LoginTime;
            SessionID = field.SessionID;
            UserID = field.UserID;
            AccountID = field.AccountID;
            InvestorName = field.Name();
            XErrorID = field.XErrorID;
            RawErrorID = field.RawErrorID;
            Text = field.Text();
        }
    }
}