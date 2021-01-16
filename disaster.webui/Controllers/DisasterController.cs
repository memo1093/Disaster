using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CSharpVitamins;
using disaster.business.Abstract;
using disaster.entity;
using disaster.webui.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static disaster.entity.Disaster;

namespace disaster.webui.Controllers
{

    public class DisasterController : Controller
    {
        private IDisasterService _disasterService;
        private ICityService _cityService;
        private ITownService _townService;
        private readonly IWebHostEnvironment _hostEnvironment;

        public DisasterController(IDisasterService disasterService, ICityService cityService, ITownService townService, IWebHostEnvironment hostEnvironment)
        {
            _disasterService = disasterService;
            _cityService = cityService;
            _townService = townService;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult CreateDisaster()
        {
            DisasterModel model = new DisasterModel();

            Guid guid = Guid.NewGuid();
            ShortGuid shortGuid = guid;

            model.SerialNo = shortGuid.ToString();
            model.GlideNo = shortGuid.ToString();

            var cities = _cityService.GetAll();

            cities.Insert(0, new City { CityId = 0, CityName = "Seçiniz" });

            ViewBag.CityList = new SelectList(cities, "CityId", "CityName");
            ViewBag.ApproveStates = Enum.GetValues(typeof(EnumApproveState));
            model.ApproveState = EnumApproveState.waiting;

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDisaster(DisasterModel model, IFormFile[] files)
        {
            if (ModelState.IsValid)
            {

                if (files.Count() != 0)
                {
                    var entity = new Disaster()
                    {
                        SerialNo = model.SerialNo,
                        GlideNo = model.GlideNo,
                        StartDate = model.StartDate,
                        FinishDate = model.FinishDate,
                        DisasterType = model.DisasterType,
                        CityId = model.CityId,
                        TownId = model.TownId,
                        Why = model.Why,
                        Latitute=model.Latitute,
                        Longtitute=model.Longtitute,
                        Description = model.Description,
                        AffectedAreas = model.AffectedAreas,
                        ApproveState = model.ApproveState,
                    };

                    entity.Sources = new List<Source>();

                    foreach (IFormFile source in files)
                    {
                        string filename = ContentDispositionHeaderValue.Parse(source.ContentDisposition).FileName.Trim('"');

                        filename = this.EnsureCorrectFilename(filename);

                        entity.Sources.Add(
                            new Source() { SourceName = filename }
                            );
                        using (FileStream output = System.IO.File.Create(this.GetPathAndFilename(filename)))
                            await source.CopyToAsync(output);
                        ViewBag.Message += string.Format("<b>{0}</b> dosyası yüklendi.<br />", filename);
                    }


                    _disasterService.Create(entity);
                    return RedirectToAction("Index", "Home");
                }

            }
            Guid guid = Guid.NewGuid();
            ShortGuid shortGuid = guid;

            model.SerialNo = shortGuid.ToString();
            model.GlideNo = shortGuid.ToString();
            ViewBag.ApproveStates = Enum.GetValues(typeof(EnumApproveState));
            var cities = _cityService.GetAll();


            cities.Insert(0, new City { CityId = 0, CityName = "Seçiniz" });

            ViewBag.CityList = new SelectList(cities, "CityId", "CityName");

            return View(model);
        }

        public IActionResult EditDisaster(int id)
        {
            if (id != 0)
            {
                var disaster = _disasterService.GetById(id);
                var model = new DisasterModel()
                {
                    DisasterId = disaster.DisasterId,
                    DisasterType = disaster.DisasterType,
                    StartDate = disaster.StartDate,
                    FinishDate = disaster.FinishDate,
                    AffectedAreas = disaster.AffectedAreas,
                    ApproveState = disaster.ApproveState,
                    CityId = disaster.CityId,
                    TownId = disaster.TownId,
                    Why = disaster.Why,
                    Description = disaster.Description,
                    GlideNo = disaster.GlideNo,
                    SerialNo = disaster.SerialNo,
                    

                };
                var fileNames= disaster.Sources.Select(i=>i.SourceName).ToList();
                model.fileNames=fileNames;
                var cities = _cityService.GetAll();
                cities.Insert(0, new City { CityId = 0, CityName = "Seçiniz" });

                ViewBag.CityList = new SelectList(cities, "CityId", "CityName");
                ViewBag.ApproveStates = Enum.GetValues(typeof(EnumApproveState));
                return View(model);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditDisaster(DisasterModel model, IFormFile[] files)
        {
            if (ModelState.IsValid)
            {

                if (files.Count() != 0)
                {
                    var entity = new Disaster()
                    {
                        SerialNo = model.SerialNo,
                        GlideNo = model.GlideNo,
                        StartDate = model.StartDate,
                        FinishDate = model.FinishDate,
                        DisasterType = model.DisasterType,
                        CityId = model.CityId,
                        TownId = model.TownId,
                        Latitute=model.Latitute,
                        Longtitute=model.Longtitute,
                        Why = model.Why,
                        Description = model.Description,
                        AffectedAreas = model.AffectedAreas,
                        ApproveState = model.ApproveState,
                    };

                    entity.Sources = new List<Source>();

                    foreach (IFormFile source in files)
                    {
                        string filename = ContentDispositionHeaderValue.Parse(source.ContentDisposition).FileName.Trim('"');

                        filename = this.EnsureCorrectFilename(filename);

                        entity.Sources.Add(
                            new Source() { SourceName = filename }
                            );
                        using (FileStream output = System.IO.File.Create(this.GetPathAndFilename(filename)))
                            await source.CopyToAsync(output);
                        ViewBag.Message += string.Format("<b>{0}</b> dosyası yüklendi.<br />", filename);
                    }


                    _disasterService.Update(entity);
                    return RedirectToAction("Index", "Home");
                }
            }

            return NotFound();
        }
        [HttpPost]
        public IActionResult DeleteDisaster(int disasterId)
        {
            if (disasterId != 0)
            {
                var disaster = _disasterService.GetById(disasterId);
                if (disaster.Sources != null)
                {
                    foreach (var sourceName in disaster.Sources.Where(i => i.DisasterId == disaster.DisasterId).Select(i => i.SourceName).ToList())
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads", sourceName);
                        FileInfo file = new FileInfo(path);
                        file.Delete();
                    }

                }
                _disasterService.Delete(disaster);

            }
            return RedirectToAction("Index", "Home");
        }


        public JsonResult GetCityId(int CityId)
        {

            var towns = _townService.GetByCityId(CityId);
            towns.Insert(0, new Town { TownId = 0, TownName = "Seçiniz", CityId = 0 });
            return Json(new SelectList(towns, "TownId", "TownName"));
        }
        public JsonResult GetLatLng(int TownId)
        {

            var town = _townService.GetByTownId(TownId);

            return Json(town);
        }
        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);

            return filename;
        }

        private string GetPathAndFilename(string filename)
        {
            return this._hostEnvironment.WebRootPath + "\\uploads\\" + filename;
        }
        




    }


}
