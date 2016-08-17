using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AdCenter.BI.UET.LookBackSummaryCommon;
using Microsoft.AdCenter.BI.UET.Schema;
using System.IO;
using Microsoft.Bond;
using Newtonsoft.Json;

namespace googleAcpc
{
    [Serializable()]
    public class UMS_ANID
    {
        public Guid ANID;
        public Guid StableIdValue;
        public UETUserIdType StableIdType;
        public UMS_ANID(string line)
        {
            string[] values = line.Split('\t');
            this.ANID = Guid.Parse(values[0]);
            this.StableIdValue = Guid.Parse(values[1]);
            this.StableIdType = Utilities.GetUETUserIdTypeFromStableIdType(values[2]);
        }
        public UMS_ANID() { }
    }

    public class UETUserIdRecord
    {
        public Guid UETUserId;
        public UserAdActivitySummary UserAdActivityData;

        public UETUserIdRecord() { }


        public UETUserIdRecord(string data)
        {

        }
        public void Sort()
        {
            this.UserAdActivityData.UserAdActivities.Sort(
                delegate(UserAdActivityDetail info1, UserAdActivityDetail info2)
                {
                    return info1.AdId.ToString().CompareTo(info2.AdId.ToString());
                }
            );

            foreach (var display in this.UserAdActivityData.UserAdActivities)
            {
                if(display.DisplayClick != null)
                    display.DisplayClick.Sort(
                        delegate(DisplayClick info1, DisplayClick info2)
                        {
                            if (info1.ClickDateTime > info2.ClickDateTime)
                                return 1;
                            return -1;
                        }
                     );
                if(display.SearchClick != null)
                    display.SearchClick.Sort(
                        delegate(SearchClick info1, SearchClick info2)
                        {
                            if (info1.ClickId.CompareTo(info2.ClickId) == 1)
                                return 1;
                            return -1;
                        }
                    );
                if(display.DisplayImpression != null)
                display.DisplayImpression.Sort(
                    delegate(DisplayImpression info1, DisplayImpression info2)
                    {
                        if (info1.ImpressionDateTime > info2.ImpressionDateTime)
                            return 1;
                        return -1;
                    }
                );
            }
        }

    }
}
