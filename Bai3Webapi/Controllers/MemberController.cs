using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bai3Webapi.BizLogics;
using Bai3Webapi.Models;

namespace Bai3Webapi.BizLogics
{
    [Route("api/[controller]")]
    [ApiController]

    public class MemberController : Controller
    {
        private IMemberHandler _member;
        public MemberController(IMemberHandler member){
            _member = member;
            
        }
        [HttpGet]
        [Route("/api/Member/memberisMale/{gender}")]
        public List<Members> MemberIsMale(string gender){
            return _member.MemberIsMale(gender);
        }
        [HttpGet]
        [Route("/api/member/getoldestmember/")]
        public Members GetOldestMember(){
            return _member.GetOldestMember();
        }
        [HttpGet]
        [Route("/api/member/getmemberfullname/")]
        public List<string> GetMemberFullName(){
            return _member.GetMemberFullName();
        }
        [HttpGet]
        [Route("/api/member/getmemberbybirthplace/{place}")]
        public List<Members> GetMemberByBirthPlace(string place){
            return _member.GetMemberByBirthPlace(place);
        }
        [HttpGet]
        [Route("/api/member/getmemberbirthyearlessthan/{year}")]
        public List<Members> GetMemberBirthYearlessThan(int year){
            return _member.GetMemberBirthYearlessThan(year);
        }

        [HttpGet]
        [Route("/api/member/getmemberbirthyeargreaterthan/{year}")]
        public List<Members> GetMemberBirthYeargreaterThan(int year){
            return _member.GetMemberBirthYeargreaterThan(year);
        }
        [HttpGet]
        [Route("/api/member/getmemberbirthyear2000/{year}")]
        public List<Members> GetMemberBirthYear2000(int year){
            return _member.GetMemberBirthYear2000(year);
        }
        [HttpPost]
        [Route("/api/member/addnewmember")]
        public  List<Members> AddNewMember(Members member){
            return _member.AddNewMember(member);
        }      
    }
}