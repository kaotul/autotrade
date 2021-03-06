﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuantBox.CSharp2CTP;

namespace autotrade.model
{
    public class OrderRecord : IEquatable<OrderRecord>
    {
        /// <summary>
        /// 报单编号
        /// </summary>
        public string OrderSysID { get; set; }
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID { get; set; }
        /// <summary>
        /// 合约代码
        /// </summary>
        public string InstrumentID { get; set; }
        /// <summary>
        /// 买卖方向
        /// </summary>
        public TThostFtdcDirectionType Direction { get; set; }   
        /// <summary>
        /// 报单价格
        /// </summary>
        public double LimitPrice { get; set; }
        /// <summary>
        /// 报单手数
        /// </summary>
        public int VolumeTotalOriginal { get; set; }
        /// <summary>
        /// 报单状态
        /// </summary>
        public TThostFtdcOrderStatusType OrderStatus { get; set; }
        /// <summary>
        /// 报单类型
        /// </summary>
        public TThostFtdcOrderTypeType OrderType { get; set; }
        /// <summary>
        /// 今成交数量
        /// </summary>
        public int VolumeTraded { get; set; }
        /// <summary>
        /// 剩余数量
        /// </summary>
        public int VolumeTotal { get; set; }
        /// <summary>
        /// 委托时间
        /// </summary>
        public string InsertTime { get; set; }
        /// <summary>
        /// 激活时间
        /// </summary>
        public string ActiveTime { get; set; }

        /// <summary>
        /// 状态信息
        /// </summary>
        public string StatusMsg { get; set; }

        /// <summary>
        /// 交易所代码
        /// </summary>
        public string ExchangeID { get; set; }


        public bool Equals(OrderRecord other)
        {
            return this.RequestID == other.RequestID;
        }
        
    }
}
