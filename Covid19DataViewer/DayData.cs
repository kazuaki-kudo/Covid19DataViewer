using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19DataViewer
{
    class DayData
    {
        public struct Days
        {
            public DateTime dayDt;
            public int value;
        }
        //public List<Days> daysList;
        public struct CSSEData
        {
            // 基本情報
            public string ProvinceState;
            public string CountryRegion;
            public short Latitude;
            public short Longtude;
            // データ
            public List<Days> daysData;
        }
        private List<CSSEData> dataList = new List<CSSEData>();
        public void Clear()
        {
            dataList.Clear();
        }
        public void Add(List<CSSEData> dl)
        {
            dataList = dl;
        }
    }
}
