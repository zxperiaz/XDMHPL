﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectQLVeSo.Models;

namespace ProjectQLVeSo.Controllers
{
    public class LoaiVeSoController : Controller
    {
        private readonly QLVeSoContext context;
        const int pageSize = 20;
        int pageNumber = 1;

        public LoaiVeSoController(QLVeSoContext context)
        {
            this.context = context;
        }

        public int TongSoTrang()
        {
            List<LoaiVeSo> list = context.LoaiVeSo.ToList();
            return ((list.Count / pageSize) + 1);
        }

        public IActionResult Index(string thongbao, int? pagenumber)
        {
            if (thongbao != null)
                ViewBag.ThongBao = thongbao;
            pageNumber = pagenumber ?? 1;
            List<LoaiVeSo> dsLoaiVeSo = new List<LoaiVeSo>();
            dsLoaiVeSo = context.LoaiVeSo.OrderBy(vs => vs.Id).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            ViewBag.TongTrang = TongSoTrang();
            ViewBag.TrangHienTai = pageNumber;
            return View(dsLoaiVeSo);
        }

        public IActionResult Search(string txtSearch)
        {
            List<LoaiVeSo> dsLoaiVeSo = new List<LoaiVeSo>();
            dsLoaiVeSo = context.LoaiVeSo.Where(vs => vs.Tinh.Contains(txtSearch)).ToList();
            return View("Index", dsLoaiVeSo);
        }

        public IActionResult Add(string ma, string tinh)
        {
            try
            {
                //Thông báo
                string thongbao = "";
                //Kiểm tra mã có trùng chưa
                LoaiVeSo vs;
                vs = context.LoaiVeSo.Where(v => v.MaLoaiVeSo == ma).FirstOrDefault();
                if (vs == null)
                {
                    vs = new LoaiVeSo();
                    vs.Id = Guid.Parse(Guid.NewGuid().ToString().ToUpper());
                    vs.MaLoaiVeSo = ma;
                    vs.Tinh = tinh;
                    vs.TinhTrang = "Không khoá";
                    context.LoaiVeSo.Add(vs);
                    context.SaveChanges();
                    thongbao = "Thêm thành công";
                }
                else
                {
                    thongbao = "Mã bị trùng";
                }
                return RedirectToAction("Index", "LoaiVeSo", new { thongbao = thongbao });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IActionResult Edit(string maedit, string tinhedit, string tinhtrangedit)
        {
            try
            {
                //Thông báo
                string thongbao = "";
                //Sửa
                LoaiVeSo vs = context.LoaiVeSo.Where(v => v.MaLoaiVeSo == maedit).SingleOrDefault();
                vs.Tinh = tinhedit;
                vs.TinhTrang = tinhtrangedit;
                context.SaveChanges();
                thongbao = "Sửa thành công";
                return RedirectToAction("Index", "LoaiVeSo", new { thongbao = thongbao });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}