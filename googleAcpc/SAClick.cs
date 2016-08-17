using System;
using Microsoft.AdCenter.BI.UET.Schema;
using System.IO;
using Microsoft.Bond;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.BI.CFR;
using SparkSchema;
using Microsoft.AdCenter.BI.UET.Common.Helpers;
namespace googleAcpc
{
    [Serializable]
    public class SAClick
    {
        public string RGUID;
        public string ClickId;
        public DateTime Timestamp;

        public PageViewRecord PageView;
        public AdImpressionRecord AdImpression;
        public ClickRecord ClickRecord;
        public FraudInfoRecord FraudInfo;
        public SAClick()
        {

        }
        public SAClick(string rawLine)
        {
            string[] values = rawLine.Split('\t');

            this.RGUID = values[0];
            this.ClickId = values[1];
            this.Timestamp = DateTime.Parse(values[2]);
            this.PageView = PageViewRecord.Deserialize(Convert.FromBase64String(values[3]));
            this.AdImpression = AdImpressionRecord.Deserialize(Convert.FromBase64String(values[4]));
            this.ClickRecord = ClickRecord.Deserialize(Convert.FromBase64String(values[5]));
            this.FraudInfo = FraudInfoRecord.Deserialize(Convert.FromBase64String(values[6]));
        }
        public SAClickSpark Convert2Spark()
        {
            SAClickSpark sa = new SAClickSpark();
            sa.ClickId = this.ClickId;
            var guid = CommonUtils.ParseGuid(this.RGUID);
            if (guid.HasValue)
                sa.RGUID = new GUID(guid.Value);
            else
                sa.RGUID = new GUID(Guid.Empty);
            sa.Timestamp = this.Timestamp.Ticks;

            BondBlob bPV = null;
            if (PageView != null)
                bPV = new BondBlob(PageView.Serialize());
            BondBlob bClick = null;
            if (ClickRecord != null)
                bClick = new BondBlob(ClickRecord.Serialize());
            BondBlob bAdImpression = null;
            if (AdImpression != null)
                bAdImpression = new BondBlob(AdImpression.Serialize());

            BondBlob bFraudInfo = null;
            if (FraudInfo != null)
                bFraudInfo = new BondBlob(FraudInfo.Serialize());

            var cfs = new PSCFRSpark()
            {
                Click = (bClick),
                AdImpression = (bAdImpression),
                FraudInfo = (bFraudInfo),
                PageView = (bPV)
            };
            sa.pscfrdata = cfs;
            return sa;
        }

    }


    [Serializable()]
    public class APInstallClickDetail
    {
        private string _clickid;
        private string _rguid;
        private PageViewRecord _pageview;
        private AdImpressionRecord _adimpression;
        private ClickRecord _clickrecord;
        private FraudInfoRecord _fraudinfo;

        public string ClickId
        {
            set
            {
                _clickid = value;
            }
            get
            {
                return _clickid;
            }
        }

        public string RGUID
        {
            set
            {
                _rguid = value;
            }
            get
            {
                return _rguid;
            }
        }

        public PageViewRecord PageView
        {
            set
            {
                _pageview = value;
            }
            get
            {
                return _pageview;
            }
        }

        public AdImpressionRecord AdImpression
        {
            set
            {
                _adimpression = value;
            }
            get
            {
                return _adimpression;
            }
        }

        public ClickRecord ClickRecord
        {
            set
            {
                _clickrecord = value;
            }
            get
            {
                return _clickrecord;
            }
        }

        public FraudInfoRecord FraudInfo
        {
            set
            {
                _fraudinfo = value;
            }
            get
            {
                return _fraudinfo;
            }
        }

        public APInstallClickDetail(string rawLine)
        {
            string[] values = rawLine.Split('\t');
            this.ClickId = values[0];
            this.RGUID = values[1];
            this.PageView = PageViewRecord.Deserialize(Convert.FromBase64String(values[2]));
            this.AdImpression = AdImpressionRecord.Deserialize(Convert.FromBase64String(values[3]));
            this.FraudInfo = FraudInfoRecord.Deserialize(Convert.FromBase64String(values[4]));
            this.ClickRecord = ClickRecord.Deserialize(Convert.FromBase64String(values[5]));

        }

        public APInstallClickDetail()
        {

        }
    }
}
