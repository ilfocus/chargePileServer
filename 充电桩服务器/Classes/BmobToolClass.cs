using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// bmob方法
using cn.bmob.api;
using cn.bmob.io;
using cn.bmob.json;
using cn.bmob.tools;

namespace ChargingPileServer {
    class BmobToolClass {
        //创建Bmob实例
        private BmobWindows bmob;
        public BmobToolClass () {
            bmob = new BmobWindows();
            Bmob.initialize("278382c756ccf9a0c7d461054b9cff45", "e08b0f700b424129448c19c4160048e2");
        }
        public BmobWindows Bmob {
            get { return bmob; }
        }
        //对应要操作的数据表
        public const String TABLE_NAME = "ChargePile";
        //接下来要操作的数据的数据
        private ChargePileObject _chargePileData = new ChargePileObject(TABLE_NAME);

        public void saveData(ChargePileObject cpObj) {
            //保存数据
            var future = Bmob.CreateTaskAsync(cpObj);
            // ！！！ 直接获取异步对象结果会阻塞主线程！ 建议使用async + await/callback的形式， 可以参考文件上传功能的实现。
            // 获取创建记录的objectId
            //cpObj.objectId = future.Result.objectId;
        }

        public ChargePileObject chargePileData {
            get {
                return _chargePileData;
            }
            set {
                _chargePileData = value;
            }
        }

    }

    class CurrentAlarmInfoClass : BmobTable {
        public BmobBoolean cpInOverVol { get; set; }
        public BmobBoolean cpOutOverVol { get; set; }
        public BmobBoolean cpInUnderVol { get; set; }
        public BmobBoolean cpOutUnderVol { get; set; }
        public BmobBoolean cpInOverCur { get; set; }
        public BmobBoolean cpOutOverCur { get; set; }
        public BmobBoolean cpInUnderCur { get; set; }
        public BmobBoolean cpOutUnderCur { get; set; }
        public BmobBoolean cpTempHigh { get; set; }
        public BmobBoolean cpOutShort { get; set; }

        public override void readFields(BmobInput input) {
            base.readFields(input);

            this.cpInOverVol = input.getBoolean("cpInOverVol");
            this.cpOutOverVol = input.getBoolean("cpInOverVol");
            this.cpInUnderVol = input.getBoolean("cpInUnderVol");
            this.cpOutUnderVol = input.getBoolean("cpOutUnderVol");

            this.cpInOverCur = input.getBoolean("cpInOverCur");
            this.cpOutOverCur = input.getBoolean("cpOutOverCur");
            this.cpInUnderCur = input.getBoolean("cpInUnderCur");
            this.cpOutUnderCur = input.getBoolean("cpOutUnderCur");

            this.cpTempHigh = input.getBoolean("cpTempHigh");
            this.cpOutShort = input.getBoolean("cpOutShort");
        }

        public override void write(BmobOutput output, Boolean all) {
            base.write(output, all);

            output.Put("cpInOverVol", this.cpInOverVol);
            output.Put("cpOutOverVol", this.cpOutOverVol);
            output.Put("cpInUnderVol", this.cpInUnderVol);
            output.Put("cpOutUnderVol", this.cpOutUnderVol);
            output.Put("cpInOverCur", this.cpInOverCur);
            output.Put("cpOutOverCur", this.cpOutOverCur);
            output.Put("cpInUnderCur", this.cpInUnderCur);
            output.Put("cpOutUnderCur", this.cpOutUnderCur);
            output.Put("cpTempHigh", this.cpTempHigh);
            output.Put("cpOutShort", this.cpOutShort);
        }
    }
    //Game表对应的模型类
    class ChargePileObject : BmobTable {

        private String fTable;
        //以下对应云端字段名称
//         public BmobInt score { get; set; }
//         public String playerName { get; set; }
//         public BmobBoolean cheatMode { get; set; }
        public BmobLong ChargePileAddress { get; set; }
        public BmobInt CurrentState { get; set; }
        public BmobInt CommState { get; set; }
        public BmobDouble CurrentSOC { get; set; } // 初始值38%，一分钟增加1%，< 90%
        public BmobInt ChargeTime { get; set; }
        public BmobInt RemainTime { get; set; }  // 步长为一分钟，< 10分钟，大于0分钟

        public BmobDouble CurrentVOL { get; set; }
        public BmobDouble CurrentCur { get; set; }
        /// <summary>
        /// RT Info:_CurrentVOL,_CurrentCur
        /// </summary>
        public BmobDouble OutPower { get; set; }// 输出功率，P= _CurrentVOL * _CurrentCur / 1000
        public BmobDouble OutQuantity { get; set; }// 输出电量，Q=P*T(T为小时)
        public BmobInt ACCTime { get; set; }// T初始30分钟，步长1分钟

        /// <summary>
        /// 故障信息
        /// </summary>
        //public BmobPointer<CurrentAlarmInfoClass> CurrentAlarmInfo { get; set; }// 里面存10种故障信息
        public BmobBoolean cpInOverVol { get; set; }
        public BmobBoolean cpOutOverVol { get; set; }
        public BmobBoolean cpInUnderVol { get; set; }
        public BmobBoolean cpOutUnderVol { get; set; }
        public BmobBoolean cpInOverCur { get; set; }
        public BmobBoolean cpOutOverCur { get; set; }
        public BmobBoolean cpInUnderCur { get; set; }
        public BmobBoolean cpOutUnderCur { get; set; }
        public BmobBoolean cpTempHigh { get; set; }
        public BmobBoolean cpOutShort { get; set; }
        /// <summary>
        /// 费率信息
        /// </summary>

        public BmobDouble TotalQuantity { get; set; } //总电量<100度
        public BmobDouble TotalFee { get; set; }      //总费用< 100元

        public BmobDouble JianQ { get; set; }      //尖
        public BmobDouble JianPrice { get; set; }  //1.2-1.3 元
        public BmobDouble JianFee { get; set; }

        public BmobDouble fengQ { get; set; }    //峰
        public BmobDouble fengPrice { get; set; }//1.0-1.1
        public BmobDouble fengFee { get; set; }

        public BmobDouble PingQ { get; set; }    //平
        public BmobDouble PingPrice { get; set; }//0.7-0.8
        public BmobDouble PingFee { get; set; }

        public BmobDouble GUQ { get; set; }   //谷
        public BmobDouble GUPrice { get; set; }//0.3-0.4
        public BmobDouble GUFee { get; set; }

        /// <summary>
        /// Battery array Info（option)
        /// </summary>
        /// 
        public BmobDouble BatterySoc { get; set; } //电池组SOC60%
        public BmobBoolean BMSState { get; set; }  //BMS状态正常
        public BmobDouble PortVol { get; set; }   //端电压  538.80  V
        public BmobInt CellNum { get; set; }  //单体数量0  个
        public BmobInt TempNum { get; set; }  //温度点数量0  个
        public BmobDouble MaxVol { get; set; }    //最高允许充电单体电压3.921  V
        public BmobDouble MaxCTemp { get; set; }   //最高允许充电温度 60 度

        /// <summary>
        /// Battery safty Info
        /// </summary>
        public BmobDouble CellMaxVol { get; set; }  //单体最高电压3.412 V
        public BmobInt CellPos { get; set; }    //单体最高电压位置2 
        public BmobDouble CellMinVol { get; set; } //单体最低电压 0.000 V
        public BmobInt CellMinVolPos { get; set; } //单体最低电压位置0
        public BmobDouble MaxTemp { get; set; }  //最高温度 38 度
        public BmobDouble MinTemp { get; set; }  //最低温度31 度

        /// <summary>
        /// BMS alarm info
        /// </summary>
        public BmobBoolean VolDataAlarm { get; set; }  //电压数据异常无故障
        public BmobBoolean SampleVolFault { get; set; } //电压采样故障
        public BmobBoolean UvorOvAlarm { get; set; }    //单体欠压过压报警
        public BmobBoolean SystemParaAlarm { get; set; } //系统参数报警
        public BmobBoolean FanFailFault { get; set; }    //风扇故障
        public BmobBoolean SampleTempFault { get; set; }  //温度采样错误
        //构造函数
        public ChargePileObject() { }
        //构造函数
        public ChargePileObject(String tableName) {
            this.fTable = tableName;
        }
        public override string table {
            get {
                if (fTable != null) {
                    return fTable;
                }
                return base.table;
            }
        }
        //读字段信息
        public override void readFields(BmobInput input) {
            base.readFields(input);

            this.ChargePileAddress = input.getLong("ChargePileAddress");
            this.CurrentState = input.getInt("CurrentState");
            this.CommState = input.getInt("CommState");
            this.CurrentSOC = input.getDouble("CurrentSOC");
            this.ChargeTime = input.getInt("ChargeTime");
            this.RemainTime = input.getInt("RemainTime");
            this.CurrentVOL = input.getDouble("currentVOL");
            this.CurrentCur = input.getDouble("currentCur");
            this.OutPower = input.getDouble("OutPower");
            this.OutQuantity = input.getDouble("OutQuantity");
            this.ACCTime = input.getInt("ACCTime");

            //this.CurrentAlarmInfo = input.Get<BmobPointer<CurrentAlarmInfoClass>>("CurrentAlarmInfo");
            this.cpInOverVol = input.getBoolean("cpInOverVol");
            this.cpOutOverVol = input.getBoolean("cpInOverVol");
            this.cpInUnderVol = input.getBoolean("cpInUnderVol");
            this.cpOutUnderVol = input.getBoolean("cpOutUnderVol");
            this.cpInOverCur = input.getBoolean("cpInOverCur");
            this.cpOutOverCur = input.getBoolean("cpOutOverCur");
            this.cpInUnderCur = input.getBoolean("cpInUnderCur");
            this.cpOutUnderCur = input.getBoolean("cpOutUnderCur");
            this.cpTempHigh = input.getBoolean("cpTempHigh");
            this.cpOutShort = input.getBoolean("cpOutShort");

            this.TotalQuantity = input.getDouble("TotalQuantity");
            this.TotalFee = input.getDouble("TotalFee");
            this.JianQ = input.getDouble("JianQ");
            this.JianPrice = input.getDouble("JianPrice");
            this.JianFee = input.getDouble("JianFee");
            this.fengQ = input.getDouble("fengQ");
            this.fengPrice = input.getDouble("fengPrice");
            this.fengFee = input.getDouble("fengFee");
            this.PingQ = input.getDouble("PingQ");
            this.PingPrice = input.getDouble("PingPrice");
            this.PingFee = input.getDouble("PingFee");
            this.GUQ = input.getDouble("GUQ");
            this.GUPrice = input.getDouble("GUPrice");
            this.GUFee = input.getDouble("GUFee");

            this.BatterySoc = input.getDouble("BatterySoc");
            this.BMSState = input.getBoolean("BMSState");
            this.PortVol = input.getDouble("PortVol");
            this.CellNum = input.getInt("CellNum");
            this.TempNum = input.getInt("TempNum");
            this.MaxVol = input.getDouble("MaxVol");
            this.MaxCTemp = input.getDouble("MaxCTemp");

            this.CellMaxVol = input.getDouble("CellMaxVol");
            this.CellPos = input.getInt("CellPos");
            this.CellMinVol = input.getDouble("CellMinVol");
            this.CellMinVolPos = input.getInt("CellMinVolPos");
            this.MaxTemp = input.getDouble("MaxTemp");
            this.MinTemp = input.getDouble("MinTemp");

            this.VolDataAlarm = input.getBoolean("VolDataAlarm");
            this.SampleVolFault = input.getBoolean("SampleVolFault");
            this.UvorOvAlarm = input.getBoolean("UvorOvAlarm");
            this.SystemParaAlarm = input.getBoolean("SystemParaAlarm");
            this.FanFailFault = input.getBoolean("FanFailFault");
            this.SampleTempFault = input.getBoolean("SampleTempFault");
        }
        //写字段信息
        public override void write(BmobOutput output, bool all) {
            base.write(output, all);
            output.Put("ChargePileAddress", this.ChargePileAddress);
            output.Put("CurrentState", this.CurrentState);
            output.Put("CommState", this.CommState);
            output.Put("CurrentSOC", this.CurrentSOC);
            output.Put("ChargeTime", this.ChargeTime);
            output.Put("RemainTime", this.RemainTime);
            output.Put("currentVOL", this.CurrentVOL);
            output.Put("currentCur", this.CurrentCur);
            output.Put("OutPower", this.OutPower);
            output.Put("OutQuantity", this.OutQuantity);
            output.Put("ACCTime", this.ACCTime);

            //output.Put("CurrentAlarmInfo", this.CurrentAlarmInfo);
            output.Put("cpInOverVol", this.cpInOverVol);
            output.Put("cpOutOverVol", this.cpOutOverVol);
            output.Put("cpInUnderVol", this.cpInUnderVol);
            output.Put("cpOutUnderVol", this.cpOutUnderVol);
            output.Put("cpInOverCur", this.cpInOverCur);
            output.Put("cpOutOverCur", this.cpOutOverCur);
            output.Put("cpInUnderCur", this.cpInUnderCur);
            output.Put("cpOutUnderCur", this.cpOutUnderCur);
            output.Put("cpTempHigh", this.cpTempHigh);
            output.Put("cpOutShort", this.cpOutShort);

            output.Put("TotalQuantity", this.TotalQuantity);
            output.Put("TotalFee", this.TotalFee);
            output.Put("JianQ", this.JianQ);
            output.Put("JianPrice", this.JianPrice);
            output.Put("JianFee", this.JianFee);
            output.Put("fengQ", this.fengQ);
            output.Put("fengPrice", this.fengPrice);
            output.Put("fengFee", this.fengFee);
            output.Put("PingQ", this.PingQ);
            output.Put("PingPrice", this.PingPrice);
            output.Put("PingFee", this.PingFee);
            output.Put("GUQ", this.GUQ);
            output.Put("GUPrice", this.GUPrice);
            output.Put("GUFee", this.GUFee);

            output.Put("BatterySoc", this.BatterySoc);
            output.Put("BMSState", this.BMSState);
            output.Put("PortVol", this.PortVol);
            output.Put("CellNum", this.CellNum);
            output.Put("TempNum", this.TempNum);
            output.Put("MaxVol", this.MaxVol);
            output.Put("MaxCTemp", this.MaxCTemp);

            output.Put("CellMaxVol", this.CellMaxVol);
            output.Put("CellPos", this.CellPos);
            output.Put("CellMinVol", this.CellMinVol);
            output.Put("CellMinVolPos", this.CellMinVolPos);
            output.Put("MaxTemp", this.MaxTemp);
            output.Put("MinTemp", this.MinTemp);

            output.Put("VolDataAlarm", this.VolDataAlarm);
            output.Put("SampleVolFault", this.SampleVolFault);
            output.Put("UvorOvAlarm", this.UvorOvAlarm);
            output.Put("SystemParaAlarm", this.SystemParaAlarm);
            output.Put("FanFailFault", this.FanFailFault);
            output.Put("SampleTempFault", this.SampleTempFault);
        }
    }
}
