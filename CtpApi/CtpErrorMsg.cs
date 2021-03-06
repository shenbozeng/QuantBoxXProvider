using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantBox.Sfit.Api
{
    public static class CtpErrorMsg
    {        
		public const string NONE = "CTP:正确";
		public const string INVALID_DATA_SYNC_STATUS = "CTP:不在已同步状态";
		public const string INCONSISTENT_INFORMATION = "CTP:会话信息不一致";
		public const string INVALID_LOGIN = "CTP:不合法的登录";
		public const string USER_NOT_ACTIVE = "CTP:用户不活跃";
		public const string DUPLICATE_LOGIN = "CTP:重复的登录";
		public const string NOT_LOGIN_YET = "CTP:还没有登录";
		public const string NOT_INITED = "CTP:还没有初始化";
		public const string FRONT_NOT_ACTIVE = "CTP:前置不活跃";
		public const string NO_PRIVILEGE = "CTP:无此权限";
		public const string CHANGE_OTHER_PASSWORD = "CTP:修改别人的口令";
		public const string USER_NOT_FOUND = "CTP:找不到该用户";
		public const string BROKER_NOT_FOUND = "CTP:找不到该经纪公司";
		public const string INVESTOR_NOT_FOUND = "CTP:找不到投资者";
		public const string OLD_PASSWORD_MISMATCH = "CTP:原口令不匹配";
		public const string BAD_FIELD = "CTP:报单字段有误";
		public const string INSTRUMENT_NOT_FOUND = "CTP:找不到合约";
		public const string INSTRUMENT_NOT_TRADING = "CTP:合约不能交易";
		public const string NOT_EXCHANGE_PARTICIPANT = "CTP:经纪公司不是交易所的会员";
		public const string INVESTOR_NOT_ACTIVE = "CTP:投资者不活跃";
		public const string NOT_EXCHANGE_CLIENT = "CTP:投资者未在交易所开户";
		public const string NO_VALID_TRADER_AVAILABLE = "CTP:该交易席位未连接到交易所";
		public const string DUPLICATE_ORDER_REF = "CTP:报单错误：不允许重复报单";
		public const string BAD_ORDER_ACTION_FIELD = "CTP:错误的报单操作字段";
		public const string DUPLICATE_ORDER_ACTION_REF = "CTP:撤单已报送，不允许重复撤单";
		public const string ORDER_NOT_FOUND = "CTP:撤单找不到相应报单";
		public const string INSUITABLE_ORDER_STATUS = "CTP:报单已全成交或已撤销，不能再撤";
		public const string UNSUPPORTED_FUNCTION = "CTP:不支持的功能";
		public const string NO_TRADING_RIGHT = "CTP:没有报单交易权限";
		public const string CLOSE_ONLY = "CTP:只能平仓";
		public const string OVER_CLOSE_POSITION = "CTP:平仓量超过持仓量";
		public const string INSUFFICIENT_MONEY = "CTP:资金不足";
		public const string DUPLICATE_PK = "CTP:主键重复";
		public const string CANNOT_FIND_PK = "CTP:找不到主键";
		public const string CAN_NOT_INACTIVE_BROKER = "CTP:设置经纪公司不活跃状态失败";
		public const string BROKER_SYNCHRONIZING = "CTP:经纪公司正在同步";
		public const string BROKER_SYNCHRONIZED = "CTP:经纪公司已同步";
		public const string SHORT_SELL = "CTP:现货交易不能卖空";
		public const string INVALID_SETTLEMENT_REF = "CTP:不合法的结算引用";
		public const string CFFEX_NETWORK_ERROR = "CTP:交易所网络连接失败";
		public const string CFFEX_OVER_REQUEST = "CTP:交易所未处理请求超过许可数";
		public const string CFFEX_OVER_REQUEST_PER_SECOND = "CTP:交易所每秒发送请求数超过许可数";
		public const string SETTLEMENT_INFO_NOT_CONFIRMED = "CTP:结算结果未确认";
		public const string DEPOSIT_NOT_FOUND = "CTP:没有对应的入金记录";
		public const string EXCHANG_TRADING = "CTP:交易所已经进入连续交易状态";
		public const string PARKEDORDER_NOT_FOUND = "CTP:找不到预埋（撤单）单";
		public const string PARKEDORDER_HASSENDED = "CTP:预埋（撤单）单已经发送";
		public const string PARKEDORDER_HASDELETE = "CTP:预埋（撤单）单已经删除";
		public const string INVALID_INVESTORIDORPASSWORD = "CTP:无效的投资者或者密码";
		public const string INVALID_LOGIN_IPADDRESS = "CTP:不合法的登录IP地址";
		public const string OVER_CLOSETODAY_POSITION = "CTP:平今仓位不足";
		public const string OVER_CLOSEYESTERDAY_POSITION = "CTP:平昨仓位不足";
		public const string BROKER_NOT_ENOUGH_CONDORDER = "CTP:经纪公司没有足够可用的条件单数量";
		public const string INVESTOR_NOT_ENOUGH_CONDORDER = "CTP:投资者没有足够可用的条件单数量";
		public const string BROKER_NOT_SUPPORT_CONDORDER = "CTP:经纪公司不支持条件单";
		public const string RESEND_ORDER_BROKERINVESTOR_NOTMATCH = "CTP:重发未知单经纪公司/投资者不匹配";
		public const string SYC_OTP_FAILED = "CTP:同步动态令牌失败";
		public const string OTP_MISMATCH = "CTP:动态令牌校验错误";
		public const string OTPPARAM_NOT_FOUND = "CTP:找不到动态令牌配置信息";
		public const string UNSUPPORTED_OTPTYPE = "CTP:不支持的动态令牌类型";
		public const string SINGLEUSERSESSION_EXCEED_LIMIT = "CTP:用户在线会话超出上限";
		public const string EXCHANGE_UNSUPPORTED_ARBITRAGE = "CTP:该交易所不支持套利/做市商类型报单";
		public const string NO_CONDITIONAL_ORDER_RIGHT = "CTP:没有条件单交易权限";
		public const string AUTH_FAILED = "CTP:客户端认证失败";
		public const string NOT_AUTHENT = "CTP:客户端未认证";
		public const string SWAPORDER_UNSUPPORTED = "CTP:该合约不支持互换类型报单";
		public const string OPTIONS_ONLY_SUPPORT_SPEC = "CTP:该期权合约只支持投机类型报单";
		public const string DUPLICATE_EXECORDER_REF = "CTP:执行宣告错误，不允许重复执行";
		public const string RESEND_EXECORDER_BROKERINVESTOR_NOTMATCH = "CTP:重发未知执行宣告经纪公司/投资者不匹配";
		public const string EXECORDER_NOTOPTIONS = "CTP:只有期权合约可执行";
		public const string OPTIONS_NOT_SUPPORT_EXEC = "CTP:该期权合约不支持执行";
		public const string BAD_EXECORDER_ACTION_FIELD = "CTP:执行宣告字段有误";
		public const string DUPLICATE_EXECORDER_ACTION_REF = "CTP:执行宣告撤单已报送，不允许重复撤单";
		public const string EXECORDER_NOT_FOUND = "CTP:执行宣告撤单找不到相应执行宣告";
		public const string OVER_EXECUTE_POSITION = "CTP:执行仓位不足";
		public const string LOGIN_FORBIDDEN = "CTP:连续登录失败次数超限，登录被禁止";
		public const string INVALID_TRANSFER_AGENT = "CTP:非法银期代理关系";
		public const string NO_FOUND_FUNCTION = "CTP:无此功能";
		public const string SEND_EXCHANGEORDER_FAILED = "CTP:发送报单失败";
		public const string SEND_EXCHANGEORDERACTION_FAILED = "CTP:发送报单操作失败";
		public const string PRICETYPE_NOTSUPPORT_BYEXCHANGE = "CTP:交易所不支持的价格类型";
		public const string BAD_EXECUTE_TYPE = "CTP:错误的执行类型";
		public const string BAD_OPTION_INSTR = "CTP:无效的组合合约";
		public const string INSTR_NOTSUPPORT_FORQUOTE = "CTP:该合约不支持询价";
		public const string RESEND_QUOTE_BROKERINVESTOR_NOTMATCH = "CTP:重发未知报价经纪公司/投资者不匹配";
		public const string INSTR_NOTSUPPORT_QUOTE = "CTP:该合约不支持报价";
		public const string QUOTE_NOT_FOUND = "CTP:报价撤单找不到相应报价";
		public const string OPTIONS_NOT_SUPPORT_ABANDON = "CTP:该期权合约不支持放弃执行";
		public const string COMBOPTIONS_SUPPORT_IOC_ONLY = "CTP:该组合期权合约只支持IOC";
		public const string OPEN_FILE_FAILED = "CTP:打开文件失败";
		public const string NEED_RETRY = "CTP：查询未就绪，请稍后重试";
		public const string EXCHANGE_RTNERROR = "CTP：交易所返回的错误";
		public const string QUOTE_DERIVEDORDER_ACTIONERROR = "CTP:报价衍生单要等待交易所返回才能撤单";
		public const string INSTRUMENTMAP_NOT_FOUND = "CTP:找不到组合合约映射";
		public const string CANCEL_OF_EFP_DERIVED_ORDER_NOT_ALLOWED = "CTP:期转现衍生报单不允许撤单";
		public const string NO_TRADING_RIGHT_IN_SEPC_DR = "CTP:用户在本系统没有报单权限";
		public const string NO_DR_NO = "CTP:系统缺少灾备标示号";
		public const string BATCHACTION_NOSUPPORT = "CTP:该交易所不支持批量撤单";
		public const string POSI_LIMIT = "CTP:投资者限仓";
		public const string OUT_OF_TIMEINTERVAL = "CTP:当前时间禁止询价";
		public const string OUT_OF_PRICEINTERVAL = "CTP:当前价差禁止询价";
		public const string ORDER_FREQ_LIMIT = "CTP:下单频率限制";
		public const string WEAK_PASSWORD = "CTP：您当前密码为弱密码，请修改成强密码后重新登录";
		public const string EXEC_FORBIDDEN_TIME = "CTP:当前时间禁止行权";
		public const string FIRST_LOGIN = "CTP:首次登录必须修改密码，请修改密码后重新登录";
		public const string PWD_OUT_OF_DATE = "CTP:您当前密码已过期，请修改后登录";
		public const string PWD_MUST_DIFF = "CTP:修改密码失败。新密码不允许与旧密码相同";
		public const string IP_FORBIDDEN = "CTP:您登录失败次数过多，IP被禁止登入CTP";
		public const string IP_BLACK = "CTP:您当前IP在黑名单中，被禁止登入CTP";
		public const string SEND_INSTITUTION_CODE_ERROR = "CTP:银期转账：发送机构代码错误";
		public const string NO_GET_PLATFORM_SN = "CTP:银期转账：取平台流水号错误";
		public const string ILLEGAL_TRANSFER_BANK = "CTP:银期转账：不合法的转账银行";
		public const string ALREADY_OPEN_ACCOUNT = "CTP:银期转账：已经开户";
		public const string NOT_OPEN_ACCOUNT = "CTP:银期转账：未开户";
		public const string PROCESSING = "CTP:银期转账：处理中";
		public const string OVERTIME = "CTP:银期转账：交易超时";
		public const string RECORD_NOT_FOUND = "CTP:银期转账：找不到记录";
		public const string NO_FOUND_REVERSAL_ORIGINAL_TRANSACTION = "CTP:银期转账：找不到被冲正的原始交易";
		public const string CONNECT_HOST_FAILED = "CTP:银期转账：连接主机失败";
		public const string SEND_FAILED = "CTP:银期转账：发送失败";
		public const string LATE_RESPONSE = "CTP:银期转账：迟到应答";
		public const string REVERSAL_BANKID_NOT_MATCH = "CTP:银期转账：冲正交易银行代码错误";
		public const string REVERSAL_BANKACCOUNT_NOT_MATCH = "CTP:银期转账：冲正交易银行账户错误";
		public const string REVERSAL_BROKERID_NOT_MATCH = "CTP:银期转账：冲正交易经纪公司代码错误";
		public const string REVERSAL_ACCOUNTID_NOT_MATCH = "CTP:银期转账：冲正交易资金账户错误";
		public const string REVERSAL_AMOUNT_NOT_MATCH = "CTP:银期转账：冲正交易交易金额错误";
		public const string DB_OPERATION_FAILED = "CTP:银期转账：数据库操作错误";
		public const string SEND_ASP_FAILURE = "CTP:银期转账：发送到交易系统失败";
		public const string NOT_SIGNIN = "CTP:银期转账：没有签到";
		public const string ALREADY_SIGNIN = "CTP:银期转账：已经签到";
		public const string AMOUNT_OR_TIMES_OVER = "CTP:银期转账：金额或次数超限";
		public const string NOT_IN_TRANSFER_TIME = "CTP:银期转账：这一时间段不能转账";
		public const string BANK_SERVER_ERROR = "银行主机错";
		public const string BANK_SERIAL_IS_REPEALED = "CTP:银期转账：银行已经冲正";
		public const string BANK_SERIAL_NOT_EXIST = "CTP:银期转账：银行流水不存在";
		public const string NOT_ORGAN_MAP = "CTP:银期转账：机构没有签约";
		public const string EXIST_TRANSFER = "CTP:银期转账：存在转账，不能销户";
		public const string BANK_FORBID_REVERSAL = "CTP:银期转账：银行不支持冲正";
		public const string DUP_BANK_SERIAL = "CTP:银期转账：重复的银行流水";
		public const string FBT_SYSTEM_BUSY = "CTP:银期转账：转账系统忙，稍后再试";
		public const string MACKEY_SYNCING = "CTP:银期转账：MAC密钥正在同步";
		public const string ACCOUNTID_ALREADY_REGISTER = "CTP:银期转账：资金账户已经登记";
		public const string BANKACCOUNT_ALREADY_REGISTER = "CTP:银期转账：银行账户已经登记";
		public const string DUP_BANK_SERIAL_REDO_OK = "CTP:银期转账：重复的银行流水,重发成功";
		public const string CURRENCYID_NOT_SUPPORTED = "CTP:银期转账：该币种代码不支持";
		public const string INVALID_MAC = "CTP:银期转账：MAC值验证失败";
		public const string NOT_SUPPORT_SECAGENT_BY_BANK = "CTP:银期转账：不支持银行端发起的二级代理商转账和查询";
		public const string PINKEY_SYNCING = "CTP:银期转账：PIN密钥正在同步";
		public const string SECAGENT_QUERY_BY_CCB = "CTP:银期转账：建行发起的二级代理商查询";
		public const string BANKACCOUNT_NOT_EMPTY = "CTP:银期转账：银行账户不能为空";
		public const string INVALID_RESERVE_OPEN_ACCOUNT = "CTP:银期转账：资金账户存在，预约开户失败";
		public const string OPEN_ACCOUNT_NOT_DEFAULT_ACCOUNT = "CTP:银期转账：开户请求的银行卡号和预留的账号不同";
		public const string NO_VALID_BANKOFFER_AVAILABLE = "CTP:该报盘未连接到银行";
		public const string PASSWORD_MISMATCH = "CTP:资金密码错误";
		public const string DUPLATION_BANK_SERIAL = "CTP:银行流水号重复";
		public const string DUPLATION_OFFER_SERIAL = "CTP:报盘流水号重复";
		public const string SERIAL_NOT_EXSIT = "CTP:被冲正流水不存在(冲正交易)";
		public const string SERIAL_IS_REPEALED = "CTP:原流水已冲正(冲正交易)";
		public const string SERIAL_MISMATCH = "CTP:与原流水信息不符(冲正交易)";
		public const string IdentifiedCardNo_MISMATCH = "CTP:证件号码或类型错误";
		public const string ACCOUNT_NOT_FUND = "CTP:资金账户不存在";
		public const string ACCOUNT_NOT_ACTIVE = "CTP:资金账户已经销户";
		public const string NOT_ALLOW_REPEAL_BYMANUAL = "CTP:该交易不能执行手工冲正";
		public const string AMOUNT_OUTOFTHEWAY = "CTP:转帐金额错误";
		public const string EXCHANGERATE_NOT_FOUND = "CTP:找不到汇率";
		public const string RESERVE_OPEN_ACCOUNT_NOT_FUND = "CTP:找不到预约开户请求";
		public const string DUPLICATE_RESERVE_OPEN_ACCOUNT_NOT_FUND = "CTP:重复的预约开户请求";
		public const string WAITING_OFFER_RSP = "CTP:等待银期报盘处理结果";
		public const string FBE_NO_GET_PLATFORM_SN = "CTP:银期换汇：取平台流水号错误";
		public const string FBE_ILLEGAL_TRANSFER_BANK = "CTP:银期换汇：不合法的转账银行";
		public const string FBE_PROCESSING = "CTP:银期换汇：处理中";
		public const string FBE_OVERTIME = "CTP:银期换汇：交易超时";
		public const string FBE_RECORD_NOT_FOUND = "CTP:银期换汇：找不到记录";
		public const string FBE_CONNECT_HOST_FAILED = "CTP:银期换汇：连接主机失败";
		public const string FBE_SEND_FAILED = "CTP:银期换汇：发送失败";
		public const string FBE_LATE_RESPONSE = "CTP:银期换汇：迟到应答";
		public const string FBE_DB_OPERATION_FAILED = "CTP:银期换汇：数据库操作错误";
		public const string FBE_NOT_SIGNIN = "CTP:银期换汇：没有签到";
		public const string FBE_ALREADY_SIGNIN = "CTP:银期换汇：已经签到";
		public const string FBE_AMOUNT_OR_TIMES_OVER = "CTP:银期换汇：金额或次数超限";
		public const string FBE_NOT_IN_TRANSFER_TIME = "CTP:银期换汇：这一时间段不能换汇";
		public const string FBE_BANK_SERVER_ERROR = "CTP:银期换汇：银行主机错";
		public const string FBE_NOT_ORGAN_MAP = "CTP:银期换汇：机构没有签约";
		public const string FBE_SYSTEM_BUSY = "CTP:银期换汇：换汇系统忙，稍后再试";
		public const string FBE_CURRENCYID_NOT_SUPPORTED = "CTP:银期换汇：该币种代码不支持";
		public const string FBE_WRONG_BANK_ACCOUNT = "CTP:银期换汇：银行帐号不正确";
		public const string FBE_BANK_ACCOUNT_NO_FUNDS = "CTP:银期换汇：银行帐户余额不足";
		public const string FBE_DUP_CERT_NO = "CTP:银期换汇：凭证号重复";
		public const string API_UNSUPPORTED_VERSION = "CTP: 不支持该API版本";
		public const string API_INVALID_KEY = "CTP: 无效的API KEY";
		public const string OPTION_SELF_CLOSE_NOT_OPTION = "CTP:期权对冲,履约对冲:非期权合约";
		public const string OPTION_SELF_CLOSE_DUPLICATE_REF = "CTP:期权对冲,履约对冲:请求引用不合法";
		public const string OPTION_SELF_CLOSE_BAD_FIELD = "CTP:期权对冲,履约对冲:非法字段 ";
		public const string OPTION_SELF_CLOSE_REC_NOT_FOUND = "CTP:期权对冲,履约对冲:撤销未找到记录";
		public const string OPTION_SELF_CLOSE_STATUS_ERR = "CTP:期权对冲,履约对冲:对冲状态不对，不能撤销";
		public const string OPTION_SELF_CLOSE_DOUBLE_SET_ERR = "CTP:期权对冲,履约对冲:不能重复设置，只能先撤销再设置";
	}
}
