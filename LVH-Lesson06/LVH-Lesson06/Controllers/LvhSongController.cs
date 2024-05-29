using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LVH_Lesson06.Models;

namespace LVH_Lesson06.Controllers
{
    public class LvhSongController : Controller
    {
        private static List<LvhSong> lvhSongs = new List<LvhSong>()
        {
            new LvhSong{Id=2210900024,LvhTitle="Lê Văn Hoàng",LvhAuthor="K22CNT3",LvhArtist="NTU",LvhYearlease=2020},
             new LvhSong{Id=1,LvhTitle="Lê Văn Hoàng",LvhAuthor="K22CNT3",LvhArtist="NTU",LvhYearlease=2020},
        };
        // GET: LvhSong
        /// <summary>
        /// Hiển thị danh sachs bài hát
        /// Author:Lê Văn Hoàng
        /// </summary>
        /// <returns></returns>
        public ActionResult LvhIndex()
        {
            return View(lvhSongs);
        }
        //Get:LvhCreate
        /// <summary>
        /// Form thêm mới bài hát
        /// Author: Lê Văn Hoàng
        /// </summary>
        /// <returns></returns>
        public ActionResult LvhCreate()
        {
            var LvhSong = new LvhSong();
            return View(LvhSong);
        }
    }
}