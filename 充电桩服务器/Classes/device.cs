using System;
using System.Collections.Generic;
using ZedGraph;

namespace ChargingPileServer
{
    public partial class SubDevice
    {
        private String name;
        private int id;
        public PointPairList currentAList;
        public PointPairList currentBList;
        private int eStatus;

        public SubDevice()
        {
        }
        public String Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        
        public PointPairList CurrentAList
        {
            set { currentAList = value; }
            get { return currentAList; }
        }
        public PointPairList CurrentBList
        {
            set { currentBList = value; }
            get { return currentBList; }
        }
        public int EStatus
        {
            set { eStatus = value; }
            get { return eStatus; }
        }
    }
    public partial class MainDevice
    {
        
        public bool isActive;

        private int _iWorkCurrent;       // 工作电流
        private String _strBeginWorkTime;// 开始工作时间
        private String _strOverWorkTime; // 工作结束时间
        private String _strRunTime;      // 工作完成时间
        private String _strSurplusTime;  // 剩余时间
        private int id;
        private String name;
        private List<SubDevice> devList;
        private int selectedSubId;//用来指示当前要显示曲线的分机号
        
        public int Id {
            set { id = value; }
            get { return id; }

        }
        public int iWorkCurrent {
            set { _iWorkCurrent = value; }
            get { return _iWorkCurrent; }
        }
        public String strBeginWorkTime {
            set { _strBeginWorkTime = value; }
            get { return _strBeginWorkTime; }
        }
        public String strOverWorkTime {
            set { _strOverWorkTime = value; }
            get { return _strOverWorkTime; }
        }
        public String strRunTime {
            set { _strRunTime = value; }
            get { return _strRunTime; }
        }
        public String strSurplusTime {
            set { _strSurplusTime = value; }
            get { return _strSurplusTime; }
        }

        public int SelectedSubId {
            set { selectedSubId = value; }
            get { return selectedSubId; }

        }
        public String Name  {
            set { name = value; }
            get { return name; }

        }
        public bool IsActive {
            set { isActive = value; }
            get { return isActive; }
        }
        public List<SubDevice> DevList {
            set { devList = value; }
            get { return devList; }
        }
    }
}

