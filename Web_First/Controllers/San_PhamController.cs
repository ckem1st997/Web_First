using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_First.Data;
using Web_First.Models;
using X.PagedList;
using X.PagedList.Mvc.Bootstrap4;
using X.PagedList.Mvc.Core;

namespace Web_First.Controllers
{
    //thêm 1 kiểu dạng: collections/ao hoặc collections/quan
    //    b1: tạo class chứa view của phần muốn hiển thị
    //    b2: vào data và thêm phần class muốn hiển thị vào
    //    VD:  public DbSet<Web_First.Models.View> View { get; set; }
    //b3: sửa tên sau collection/ tên view muốn hiển thị
    //    b4:thêm view

    public class San_PhamController : Controller
    {
        private readonly MvcSPContext _context;
        public San_PhamController(MvcSPContext context)
        {
            _context = context;
        }

        public object ao(int? page, string id)
        {

            var products = from a in _context.Ao
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Ao
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Ao
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Ao
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Ao
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Ao
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object san_pham_moi(int? page, string id)
        {

            var products = from a in _context.San_Pham_New
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.San_Pham_New
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.San_Pham_New
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.San_Pham_New
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.San_Pham_New
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.San_Pham_New
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }
        public object san_pham_sale(int? page, string id)
        {

            var products = from a in _context.San_Pham_Sale
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.San_Pham_Sale
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.San_Pham_Sale
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.San_Pham_Sale
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.San_Pham_Sale
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.San_Pham_Sale
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }
        public object pk(int? page, string id)
        {

            var products = from a in _context.PK
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.PK
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.PK
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.PK
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.PK
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.PK
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }
        public object quan(int? page, string id)
        {

            var products = from a in _context.quan
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.quan
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.quan
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.quan
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.quan
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.quan
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }
        public object ao_khoac(int? page, string id)
        {

            var products = from a in _context.Ao_Khoac
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Ao_Khoac
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Ao_Khoac
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Ao_Khoac
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Ao_Khoac
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Ao_Khoac
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object ao_len(int? page, string id)
        {

            var products = from a in _context.Ao_Len
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Ao_Len
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Ao_Len
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Ao_Len
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Ao_Len
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Ao_Len
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object ao_polo(int? page, string id)
        {

            var products = from a in _context.Ao_Polo
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Ao_Polo
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Ao_Polo
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Ao_Polo
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Ao_Polo
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Ao_Polo
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object ao_sm(int? page, string id)
        {

            var products = from a in _context.Ao_SM
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Ao_SM
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Ao_SM
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Ao_SM
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Ao_SM
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Ao_SM
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }
        public object ao_st(int? page, string id)
        {

            var products = from a in _context.Ao_ST
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Ao_ST
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Ao_ST
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Ao_ST
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Ao_ST
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Ao_ST
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object ao_thun(int? page, string id)
        {

            var products = from a in _context.Ao_Thun
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Ao_Thun
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Ao_Thun
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Ao_Thun
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Ao_Thun
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Ao_Thun
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object ao_hd(int? page, string id)
        {

            var products = from a in _context.Ao_HD
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Ao_HD
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Ao_HD
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Ao_HD
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Ao_HD
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Ao_HD
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object ao_tt(int? page, string id)
        {

            var products = from a in _context.Ao_TT
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Ao_TT
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Ao_TT
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Ao_TT
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Ao_TT
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Ao_TT
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object bl_t(int? page, string id)
        {

            var products = from a in _context.BL_T
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.BL_T
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.BL_T
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.BL_T
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.BL_T
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.BL_T
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object giay_dep(int? page, string id)
        {

            var products = from a in _context.Giay_Dep
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Giay_Dep
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Giay_Dep
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Giay_Dep
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Giay_Dep
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Giay_Dep
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object non_vo(int? page, string id)
        {

            var products = from a in _context.Non_Vo
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Non_Vo
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Non_Vo
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Non_Vo
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Non_Vo
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Non_Vo
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object quan_jeans(int? page, string id)
        {

            var products = from a in _context.Quan_Jeans
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Quan_Jeans
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Quan_Jeans
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Quan_Jeans
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Quan_Jeans
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Quan_Jeans
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object quan_jj(int? page, string id)
        {

            var products = from a in _context.Quan_JJ
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Quan_JJ
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Quan_JJ
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Quan_JJ
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Quan_JJ
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Quan_JJ
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object quan_kaki(int? page, string id)
        {

            var products = from a in _context.Quan_Kaki
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Quan_Kaki
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Quan_Kaki
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Quan_Kaki
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Quan_Kaki
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Quan_Kaki
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object quan_short(int? page, string id)
        {

            var products = from a in _context.Quan_Short
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Quan_Short
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Quan_Short
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Quan_Short
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Quan_Short
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Quan_Short
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }

        public object quan_tay(int? page, string id)
        {

            var products = from a in _context.Quan_Tay
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.Quan_Tay
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.Quan_Tay
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.Quan_Tay
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.Quan_Tay
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.Quan_Tay
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }
        public object that_lung(int? page, string id)
        {

            var products = from a in _context.That_Lung
                           select a;//returns IQueryable<Product> representing an unknown number of products. a thousand maybe?
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = products.ToPagedList(pageNumber, 80);
            if (id == "Price_ascending")
            {
                products = from a in _context.That_Lung
                           orderby a.Price_SP
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Price_descending")
            {
                products = from a in _context.That_Lung
                           orderby a.Price_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_A-Z")
            {
                products = from a in _context.That_Lung
                           orderby a.Name_SP ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "Name_Z-A")
            {
                products = from a in _context.That_Lung
                           orderby a.Name_SP descending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else if (id == "mn")
            {
                products = from a in _context.That_Lung
                           orderby a.ngay_add ascending
                           select a;
                onePageOfProducts = products.ToPagedList(pageNumber, 86); // will only contain 25 products max because of the pageSize
            }
            else
                onePageOfProducts = products.ToPagedList(pageNumber, 80); // will only contain 25 products max because of the pageSizee
            ViewBag.OnePageOfProducts = onePageOfProducts;
            return View();
        }




        // GET: San_Pham/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var san_Pham = await _context.San_Pham
                .FirstOrDefaultAsync(m => m.Id_SP == id);
            if (san_Pham == null)
            {
                return NotFound();
            }

            return View(san_Pham);
        }

        // GET: San_Pham/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: San_Pham/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_SP,Loai_SP_1,Loai_SP_2,Name_SP,Price_SP,Mo_Ta")] San_Pham san_Pham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(san_Pham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(san_Pham);
        }

        // GET: San_Pham/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var san_Pham = await _context.San_Pham.FindAsync(id);
            if (san_Pham == null)
            {
                return NotFound();
            }
            return View(san_Pham);
        }

        // POST: San_Pham/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id_SP,Loai_SP_1,Loai_SP_2,Name_SP,Price_SP,Mo_Ta")] San_Pham san_Pham)
        {
            if (id != san_Pham.Id_SP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(san_Pham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!San_PhamExists(san_Pham.Id_SP))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(san_Pham);
        }

        // GET: San_Pham/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var san_Pham = await _context.San_Pham
                .FirstOrDefaultAsync(m => m.Id_SP == id);
            if (san_Pham == null)
            {
                return NotFound();
            }

            return View(san_Pham);
        }

        // POST: San_Pham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var san_Pham = await _context.San_Pham.FindAsync(id);
            _context.San_Pham.Remove(san_Pham);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool San_PhamExists(string id)
        {
            return _context.San_Pham.Any(e => e.Id_SP == id);
        }
    }
}
