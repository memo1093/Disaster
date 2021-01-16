using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using static disaster.entity.Disaster;

namespace disaster.webui.Models
{
    public class DisasterModel
    {
        
        public int DisasterId { get; set; }
        [Display(Name="Seri No")]
        public string SerialNo { get; set; }
        [Display(Name="GLIDE No")]
        public string GlideNo { get; set; }
        [Display(Name="Başlangıç Tarihi")]
        [Required(ErrorMessage="Başlangıç Tarihi Seçilmelidir.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [Display(Name="Bitiş Tarihi")]
        [Required(ErrorMessage="Bitiş Tarihi Seçilmelidir.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FinishDate { get; set; }
        [Display(Name="Geçen Süre")]
        public int ElapsedTime { get; set; }

        [Display(Name="Afet Türü")]
        [Required(ErrorMessage="Afet Türü Seçilmelidir.")]
        public string DisasterType { get; set; }
        
        [Display(Name="İl")]
        [Required(ErrorMessage="İl Seçilmelidir.")]
        public int CityId { get; set; }
        public string CityName { get; set; }

        [Display(Name="İlçe")]
        [Required(ErrorMessage="İlçe Seçilmelidir.")]
        public int TownId { get; set; }
        public string TownName { get; set; }
        [Display(Name="Enlem")]
        [Required(ErrorMessage="Enlem Girilmelidir.")]
         public float Latitute { get; set; }
        [Display(Name="Boylam")]
        [Required(ErrorMessage="Boylam Girilmelidir.")]
        public float Longtitute { get; set; }
        [Display(Name="Neden")]
        [Required(ErrorMessage="Neden girilmelidir.")]
        public string Why { get; set; }
        [Display(Name="Açıklama")]
        [Required(ErrorMessage="Açıklama girilmelidir.")]
        public string Description { get; set; }
        [Display(Name="Etkilenen alanlar")]
        [Required(ErrorMessage="Etkilenen alanlar seçilmelidir.")]
        public string AffectedAreas { get; set; }
        [Display(Name="Kaynak")]
        public List<string> fileNames { get; set; }
        public List<IFormFile> files { get; set; }
        public EnumApproveState ApproveState { get; set; }
    }
}