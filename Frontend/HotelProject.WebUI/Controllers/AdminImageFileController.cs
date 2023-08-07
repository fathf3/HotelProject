﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminImageFileController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormFile file)
        {
            var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            var bytes =stream.ToArray();
            ByteArrayContent byteArrayContent = new ByteArrayContent(bytes);
            byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
            MultipartFormDataContent multipartForm = new MultipartFormDataContent();
            multipartForm.Add(byteArrayContent, "file", file.Name);
            var httpClient = new HttpClient();
            await httpClient.PostAsync("http://localhost:5000/api/FileImage", multipartForm);
           
            return View();
        }


    }
}
