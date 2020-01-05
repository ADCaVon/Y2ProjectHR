using HREFEntity;
using HRIBLL;
using HRModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HRUI.Controllers
{
    public class humanResourcesController : Controller
    {
        public Ihuman_fileBLL ihb { get; set; }
        public Iconfig_file_first_kindBLL ifk { get; set; }
        public Iconfig_file_second_kindBLL ifsk { get; set; }
        public Iconfig_file_third_kindBLL iftk { get; set; }
        public Iconfig_major_kindBLL icmk { get; set; }
        public Iconfig_majorBLL icmb { get; set; }
        public Iconfig_public_charBLL icpb { get; set; }
        public Iengage_resumeBLL ierb { get; set; }
        // GET: humanResources
        public ActionResult secondKind(string id)//根据一级查询二级
        {
            List<M_config_file_second_kind> list = ifsk.SelectWhereB(e => e.first_kind_id == id).ToList();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult thirdKind(string id)//根据二级查询三级
        {
            List<M_config_file_third_kind> list = iftk.SelectWhereB(e => e.second_kind_id == id).ToList();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult major(string id)
        {//查职位分类
            List<M_config_major> list = icmb.SelectWhereB(e => e.major_kind_id == id).ToList();
            return Content(JsonConvert.SerializeObject(list));
        }
        public void Getlist()
        {
            //公共字段
            List<config_public_char> zhicheng = icpb.SelbyWhere(e => e.attribute_kind.Equals("职称")).ToList();
            List<config_public_char> guoji = icpb.SelbyWhere(e => e.attribute_kind.Equals("国籍")).ToList();
            List<config_public_char> minzu = icpb.SelbyWhere(e => e.attribute_kind.Equals("民族")).ToList();
            List<config_public_char> zongjiao = icpb.SelbyWhere(e => e.attribute_kind.Equals("宗教信仰")).ToList();
            List<config_public_char> zhengzhi = icpb.SelbyWhere(e => e.attribute_kind.Equals("政治面貌")).ToList();
            List<config_public_char> xueli = icpb.SelbyWhere(e => e.attribute_kind.Equals("学历")).ToList();
            List<config_public_char> jiaoyu = icpb.SelbyWhere(e => e.attribute_kind.Equals("教育年限")).ToList();
            List<config_public_char> zhuanye = icpb.SelbyWhere(e => e.attribute_kind.Equals("专业")).ToList();
            List<config_public_char> xinchou = icpb.SelbyWhere(e => e.attribute_kind.Equals("薪酬设置")).ToList();
            List<config_public_char> techang = icpb.SelbyWhere(e => e.attribute_kind.Equals("特长")).ToList();
            List<config_public_char> aihao = icpb.SelbyWhere(e => e.attribute_kind.Equals("爱好")).ToList();
            //定义容器
            var FselectItemList = new List<SelectListItem>() {
                new SelectListItem(){Value="0",Text="请选择",Selected=true}//设置默认值
            };
            var SselectItemList = new List<SelectListItem>() {
                new SelectListItem(){Value="0",Text="请选择",Selected=true}
            };
            var TselectItemList = new List<SelectListItem>() {
                new SelectListItem(){Value="0",Text="请选择",Selected=true}
            };
            var sexItemList = new List<SelectListItem>() {
                new SelectListItem(){Value="男",Text="男",Selected=true},
                 new SelectListItem(){Value="女",Text="女",Selected=true}
            };
            List<SelectListItem> mkselectItemList = new List<SelectListItem>();
            List<SelectListItem> cmselectItemList = new List<SelectListItem>();
            List<SelectListItem> zhichengList = new List<SelectListItem>();
            List<SelectListItem> guojiList = new List<SelectListItem>();
            List<SelectListItem> minzuList = new List<SelectListItem>();
            List<SelectListItem> zongjiaoList = new List<SelectListItem>();
            List<SelectListItem> zhengzhiList = new List<SelectListItem>();
            List<SelectListItem> xueliList = new List<SelectListItem>();
            List<SelectListItem> jiaoyuList = new List<SelectListItem>();
            List<SelectListItem> zhuanyeList = new List<SelectListItem>();
            List<SelectListItem> xinchouList = new List<SelectListItem>();
            List<SelectListItem> techangList = new List<SelectListItem>();
            List<SelectListItem> aihaoList = new List<SelectListItem>();
            //公共字段
            var zhichenglist = new SelectList(zhicheng, "attribute_name", "attribute_name");
            zhichengList.AddRange(zhichenglist);
            var guojilist = new SelectList(guoji, "attribute_name", "attribute_name");
            guojiList.AddRange(guojilist);
            var minzulist = new SelectList(minzu, "attribute_name", "attribute_name");
            minzuList.AddRange(minzulist);
            var zongjiaolist = new SelectList(zongjiao, "attribute_name", "attribute_name");
            zongjiaoList.AddRange(zongjiaolist);
            var zhengzhilist = new SelectList(zhengzhi, "attribute_name", "attribute_name");
            zhengzhiList.AddRange(zhengzhilist);
            var xuelilist = new SelectList(xueli, "attribute_name", "attribute_name");
            xueliList.AddRange(xuelilist);
            var jiaoyulist = new SelectList(jiaoyu, "attribute_name", "attribute_name");
            jiaoyuList.AddRange(jiaoyulist);
            var zhuanyelist = new SelectList(zhuanye, "attribute_name", "attribute_name");
            zhuanyeList.AddRange(zhuanyelist);
            var xinchoulist = new SelectList(xinchou, "attribute_name", "attribute_name");
            xinchouList.AddRange(xinchoulist);
            var techanglist = new SelectList(techang, "attribute_name", "attribute_name");
            techangList.AddRange(techanglist);
            var aihaolist = new SelectList(aihao, "attribute_name", "attribute_name");
            aihaoList.AddRange(aihaolist);
            //提供视图数据
            ViewBag.flist = FselectItemList;//List<SelectListItem>容器赋给viewbag
            ViewBag.slist = SselectItemList;
            ViewBag.tlist = TselectItemList;
            ViewBag.mklist = mkselectItemList;
            ViewBag.cmlist = cmselectItemList;
            ViewBag.zclist = zhuanyeList;
            ViewBag.gjlist = guojiList;
            ViewBag.mzlist = minzuList;
            ViewBag.zjlist = zongjiaoList;
            ViewBag.zzlist = zhengzhiList;
            ViewBag.xllist = xueliList;
            ViewBag.jymlist = jiaoyuList;
            ViewBag.zylist = zhuanyeList;
            ViewBag.xclist = xinchouList;
            ViewBag.tclist = techangList;
            ViewBag.ahlist = aihaoList;
            ViewBag.sexlist = sexItemList;
            //
        }
        // GET: recruit
        [HttpGet]
        public async Task<ActionResult> human_register(int id)
        {
            ViewBag.resume = ierb.selectById((short)id);
            ViewBag.zc = icpb.SelbyWhere(e => e.attribute_kind.Equals("职称")).ToList();
            ViewBag.guoji = icpb.SelbyWhere(e => e.attribute_kind.Equals("国籍")).ToList();
            ViewBag.mingzi = icpb.SelbyWhere(e => e.attribute_kind.Equals("民族")).ToList();
            ViewBag.zongjiao = icpb.SelbyWhere(e => e.attribute_kind.Equals("宗教信仰")).ToList();
            ViewBag.zhengzhi = icpb.SelbyWhere(e => e.attribute_kind.Equals("政治面貌")).ToList();
            ViewBag.xueli = icpb.SelbyWhere(e => e.attribute_kind.Equals("学历")).ToList();
            ViewBag.jiaoyu = icpb.SelbyWhere(e => e.attribute_kind.Equals("教育年限")).ToList();
            ViewBag.zhanye = icpb.SelbyWhere(e => e.attribute_kind.Equals("专业")).ToList();
            ViewBag.xingchou = icpb.SelbyWhere(e => e.attribute_kind.Equals("薪酬设置")).ToList();
            ViewBag.techang = icpb.SelbyWhere(e => e.attribute_kind.Equals("特长")).ToList();
            ViewBag.aihao = icpb.SelbyWhere(e => e.attribute_kind.Equals("爱好")).ToList();
            //ViewBag.xingchou = ir.Select("select * from salary_standard_details");
            ViewBag.one = await ifk.SelectAll();
            ViewBag.major = await icmk.SelectAllB();
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> human_register(M_human_file hf)
        {
            M_engage_resume ers = ierb.selectById(Convert.ToInt16(Request["resid"]));
            ers.interview_status = 5;
            //hf.salary_standard_name = ir.Select("select * from salary_standard where standard_id='" + hf.salary_standard_id + "'").Rows[0]["standard_name"].ToString();
            //hf.salary_sum = (decimal)ir.Select("select * from salary_standard where standard_id='" + hf.salary_standard_id + "'").Rows[0]["salary_sum"];
            hf.first_kind_name = ifk.SelectWhereB(e => e.first_kind_id.Equals(hf.first_kind_id)).FirstOrDefault().first_kind_name;
            hf.second_kind_name = ifsk.SelectWhereB(e => e.second_kind_id.Equals(hf.second_kind_id)).FirstOrDefault().second_kind_name;
            hf.third_kind_name = iftk.SelectWhereB(e => e.third_kind_id.Equals(hf.third_kind_id)).FirstOrDefault().third_kind_name;
            hf.human_major_kind_name = icmk.SelectWhereB(e => e.major_kind_id.Equals(hf.human_major_kind_id)).FirstOrDefault().major_kind_name;
            hf.human_major_name = icmb.SelectWhereB(e => e.major_id.Equals(hf.human_major_id)).FirstOrDefault().major_name;
            hf.check_status = 0;
            string CGnumber = "";//申明档案号
            var list = ihb.sel();//查询档案信息 //判断档案是否有数据 
            var flowNoStart = DateTime.Now.ToString("yyyyMMdd");
            if (list.Count > 0)
            {

                int Count = list.Count;
                M_human_file huCount = list[Count - 1];//从零开是算所以减一
                int Number = Convert.ToInt32(huCount.human_id.Substring(huCount.human_id.Length - 1, 1));//从截取最后一个字符 
                Number++;
                CGnumber = Number.ToString();
                CGnumber = "bt" + flowNoStart + CGnumber;
            }
            else
            {
                CGnumber = "bt" + flowNoStart + "1";
            }
            List<string> ps = new List<string>();
            PropertyInfo[] propertys = ers.GetType().GetProperties();
            foreach (PropertyInfo item in propertys)
            {
                if (item.GetValue(ers, null) != null)
                {
                    string obj = item.Name.ToString();
                    ps.Add(obj);
                }

            }
            hf.human_id = CGnumber;
            if (await ihb.add(hf) > 0 && ierb.Updateer(ers,ps) > 0)
            {
                return Content("<script>alert('添加成功');window.location.href='/humanResources/register_choose_picture/" + CGnumber + "'</script>");
            }
            else
            {
                Getlist();
                return Content("<script>alert('添加失败');'</script>");
            }
        }
        [HttpGet]
        public ActionResult register_choose_picture(string id)
        {
            ViewBag.hid = id;
            return View();
        }
        [HttpPost]
        public ActionResult register_choose_picture(HttpPostedFileBase file, string hid)
        {
            MD5 md5 = MD5.Create();
            byte[] bt = md5.ComputeHash(file.InputStream);
            StringBuilder sb = new StringBuilder();
            foreach (var item in bt)
            {
                sb.Append(item.ToString("x2"));
            }
            string name = sb.ToString();//获得加密后的文件名
            string ext = Path.GetExtension(file.FileName);//获取文件的后缀名字
            string path = $"~/Uploader/" + name + ext;//拼接图片的相对路径
            string fullPath = Server.MapPath(path);//把相对路径转换为绝对路径
            new FileInfo(fullPath).Directory.Create();//创建文件的父目录
            M_human_file list = ihb.SelectWhere(e=>e.human_id.Equals(hid)).FirstOrDefault();
            list.human_picture = name;
            list.human_file_status = true;
            List<string> ps = new List<string>();
            PropertyInfo[] propertys = list.GetType().GetProperties();
            foreach (PropertyInfo item in propertys)
            {
                if (item.GetValue(list, null) != null)
                {
                    string obj = item.Name.ToString();
                    ps.Add(obj);
                }

            }
            try
            {
                file.SaveAs(fullPath);//文件上传
                ihb.up(list,ps);

                //根据id做对象的修改
            }
            catch (Exception)
            {
                return Content("nook");

            }
            return Content("<script>alert('上传成功');</script>");
        }
        public ActionResult check_list()
        {
            return View();

        }
        [HttpPost]
        public ActionResult check_list(int currentPage)
        {
            int pages = 0;
            int rows = 0;
            Dictionary<string, object> dc = new Dictionary<string, object>();
            dc["list"] = ihb.FenYeemr(e => e.huf_id, e => e.check_status==0, out pages, out rows, currentPage, 5);
            dc["pages"] = pages;
            dc["rows"] = rows;
            return Content(JsonConvert.SerializeObject(dc));
        }
        public ActionResult human_check(int id)
        {
            M_human_file list = ihb.SelectWhere(e => e.huf_id == id).FirstOrDefault();
            Getlist();
            //ViewBag.xingchou = ir.Select("select * from salary_standard_details");
            return View(list);

        }
        [HttpPost]
        public ActionResult human_check(M_human_file hf)
        {

            //hf.salary_standard_name = ir.Select("select * from salary_standard where standard_id='" + hf.salary_standard_id + "'").Rows[0]["standard_name"].ToString();
            //hf.salary_sum = (decimal)ir.Select("select * from salary_standard where standard_id='" + hf.salary_standard_id + "'").Rows[0]["salary_sum"];
            hf.check_status = 1;
            hf.human_file_status = true;
            List<string> ps = new List<string>();
            PropertyInfo[] propertys = hf.GetType().GetProperties();
            foreach (PropertyInfo item in propertys)
            {
                if (item.GetValue(hf, null) != null)
                {
                    string obj = item.Name.ToString();
                    ps.Add(obj);
                }

            }
            if (ihb.up(hf,ps) > 0)
            {
                return Content("ok");
            }
            else
            {
                return View(hf);
            }
        }
        public async Task<ActionResult> locate()
        {
            List<M_config_file_first_kind> fk = await ifk.SelectAll();
            List<M_config_major_kind> mk = await icmk.SelectAllB();
            var FselectItemList = new List<SelectListItem>() {
                new SelectListItem(){Value="0",Text="全部",Selected=true}//设置默认值
            };
            var MselectItemList = new List<SelectListItem>() {
                new SelectListItem(){Value="0",Text="全部",Selected=true}
            };
            var firstList = new SelectList(fk, "first_kind_id", "first_kind_name");//将查询来的数据给selectlist赋键值
            FselectItemList.AddRange(firstList);//给容器追加selectlist数据
            var majorklist = new SelectList(mk, "major_kind_id", "major_kind_name");
            MselectItemList.AddRange(majorklist);
            ViewBag.one = FselectItemList;
            ViewBag.major = MselectItemList;

            return View();
        }
    
        public ActionResult q_list(string fk, string sk, string tk, string mk, string ma, string date_start, string date_end, bool f_status,int status)
        {
            DateTime start = Convert.ToDateTime(date_start);
            DateTime end = Convert.ToDateTime(date_end);

            Expression<Func<human_file, bool>> where = null;
            where = e => (e.first_kind_id.Contains(fk) || e.second_kind_id.Contains(sk) || e.third_kind_id.Contains(tk) || e.human_major_kind_id.Contains(mk)) && e.human_major_id.Contains(ma)&& e.regist_time > start && e.regist_time < end&&e.human_file_status==f_status&&e.check_status==status;
            //将条件保存到session
            Session["where"] = where;
            return Content("yes");

        }

        public Dictionary<string,object> fenye(int currentPage,int status,bool f_status)
        {
            int pages = 0;
            int rows = 0;
            Dictionary<string, object> dc = new Dictionary<string, object>();
            dc["list"] = ihb.FenYeemr(e => e.huf_id, e => e.check_status == 0, out pages, out rows, currentPage, 5);
            if (Session["where"] == null)
            {
                var count = ihb.SelectWhere(e => e.check_status == status && e.human_file_status == f_status).ToList();
                dc["list"] = ihb.FenYeemr(e => e.huf_id,e => e.check_status == status && e.human_file_status == f_status, out pages, out rows, currentPage, 5).OrderByDescending(e=>e.huf_id);
                ViewBag.count = count.Count();
                dc["pages"] = pages;
                dc["rows"] = rows;
            }
            else
            {
                Expression<Func<human_file, bool>> where1 = Session["where"] as Expression<Func<human_file, bool>>;
                var count = ihb.SelectWhere(e => e.check_status == status && e.human_file_status == f_status).ToList();
                dc["list"] = ihb.FenYeemr(e => e.huf_id,where1, out pages, out rows, currentPage, 5).OrderByDescending(e=>e.huf_id);
                dc["pages"] = pages;
                dc["rows"] = rows;
                ViewBag.count = count.Count();
            }
            return dc;
        }
        public async Task<ActionResult> query_locate()
        {
            await locate();
            return View();
        }
        public ActionResult query_list()
        {
            return View();
        }
        [HttpPost]
        public ActionResult query_list(int currentPage)
        {
            int status = 0;
            bool f_status = true;
            return Content(JsonConvert.SerializeObject(fenye(currentPage,status,f_status)));
        }

        public ActionResult query_list_information(string id)
        {
           List<M_human_file> list = ihb.SelectWhere(e=>e.human_id.Equals(id)).ToList();
            return View(list);
        }

        public async Task<ActionResult> change_locate()
        {
            await locate();
            return View();
        }
        public ActionResult change_list()
        {
            return View();
        }
        [HttpPost]
        public ActionResult change_list(int currentPage)
        {
            int status = 0;
            bool f_status = true;
            return Content(JsonConvert.SerializeObject(fenye(currentPage,status,f_status)));
        }

        public ActionResult change_list_information(string id)
        {
           M_human_file list = ihb.SelectWhere(e => e.human_id.Equals(id)).FirstOrDefault();
            Getlist();
            return View(list);
        }
        [HttpPost]
        public ActionResult change_list_information(M_human_file hf)
        {
            
            List<string> ps = new List<string>();
            PropertyInfo[] propertys = hf.GetType().GetProperties();
            foreach (PropertyInfo item in propertys)
            {
                if (item.GetValue(hf, null) != null)
                {
                    string obj = item.Name.ToString();
                    ps.Add(obj);
                }

            }
            if (ihb.up(hf, ps) > 0)
            {
                return Content("ok");
            }
            else
            {
                return View(hf);
            }
        }
        //档案删除
        public async Task<ActionResult> delete_locate()
        {
            await locate();
            return View();
        }
        public ActionResult delete_list()
        {
            return View();
        }
        [HttpPost]
        public ActionResult delete_list(int currentPage)
        {
            int status = 1;
            bool f_status = true;
            return Content(JsonConvert.SerializeObject(fenye(currentPage,status,f_status)));
        }

        public ActionResult delete_list_information(string id)
        {
           M_human_file list = ihb.SelectWhere(e => e.human_id.Equals(id)).FirstOrDefault();
            return View(list);
        }
        [HttpPost]
        public ActionResult delete_list_information(M_human_file hf)
        {
            hf.human_file_status = false;
            hf.check_status = 1;
            List<string> ps = new List<string>();
            PropertyInfo[] propertys = hf.GetType().GetProperties();
            foreach (PropertyInfo item in propertys)
            {
                if (item.GetValue(hf, null) != null)
                {
                    string obj = item.Name.ToString();
                    ps.Add(obj);
                }

            }
            
            if (ihb.up(hf, ps) > 0)
            {
                return Content("ok");
            }
            else
            {
                return View(hf);
            }
        }

        public async Task<ActionResult> recovery_locate()
        {
            await locate();
            return View();
        }
        public ActionResult recovery_list()
        {
            return View();
        }
        [HttpPost]
        public ActionResult recovery_list(int currentPage)
        {
            int status = 1;
            bool f_status = false;
            return Content(JsonConvert.SerializeObject(fenye(currentPage,status,f_status)));
        }

        public ActionResult recovery_list_information(string id)
        {
            M_human_file list = ihb.SelectWhere(e => e.human_id.Equals(id)).FirstOrDefault();
            return View(list);
        }
        [HttpPost]
        public ActionResult recovery_list_information(M_human_file hf)
        {

            hf.human_file_status = true;
            hf.check_status = 1;
            List<string> ps = new List<string>();
            PropertyInfo[] propertys = hf.GetType().GetProperties();
            foreach (PropertyInfo item in propertys)
            {
                if (item.GetValue(hf, null) != null)
                {
                    string obj = item.Name.ToString();
                    ps.Add(obj);
                }

            }

            if (ihb.up(hf, ps) > 0)
            {
                return Content("ok");
            }
            else
            {
                return View(hf);
            }
        }

        public ActionResult delete_forever_list()
        {
            return View();
        }
        [HttpPost]
        public ActionResult delete_forever_list(int currentPage)
        {

            int pages = 0;
            int rows = 0;
            Dictionary<string, object> dc = new Dictionary<string, object>();
            dc["list"] = ihb.FenYeemr(e => e.huf_id, e => e.human_file_status == false, out pages, out rows, currentPage, 5);
            dc["pages"] = pages;
            dc["rows"] = rows;
            return Content(JsonConvert.SerializeObject(dc));
        }

        public async Task<ActionResult> delete_forever_del(short id)
        {
            if (await ihb.del(new M_human_file { huf_id = id }) > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/humanResources/delete_forever_list'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/humanResources/delete_forever_list'</script>");
            }
        }

    }
}