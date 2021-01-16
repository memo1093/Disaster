using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace disaster.entity
{
    public class Disaster
    {
        public int DisasterId { get; set; }
        public string SerialNo { get; set; }
        public string GlideNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string DisasterType { get; set; }
        public int CityId { get; set; }
        public List<City> Cities { get; set; }
        public int TownId { get; set; }
        public List<Town> Towns { get; set; }
        public float Latitute { get; set; }
        public float Longtitute { get; set; }
        public string Why { get; set; }
        public string Description { get; set; }
        public string AffectedAreas { get; set; }
        public List<Source> Sources { get; set; }
        public EnumApproveState ApproveState { get; set; }
        public enum EnumApproveState
        {
            [Description("Onay Bekleniyor")]
            waiting=0,
            [Description("Onaylandı")]
            approved=1,
            [Description("Reddedildi")]
            denied=2,
            [Description("Yayında")]
            onair=3
        }


    }

    public class Source
    {
        public int SourceId { get; set; }
        public string SourceName { get; set; }
        public int DisasterId { get; set; }
    }
}