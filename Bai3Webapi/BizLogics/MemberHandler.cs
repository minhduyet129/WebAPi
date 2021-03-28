using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bai3Webapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bai3Webapi.BizLogics
{
    public class MemberHandler : IMemberHandler
    {
        private List<Members> _listmember;
        public MemberHandler(){
            SeedingData();
        }
        public List<Members> GetMemberBirthYear2000(int year)
        {
            var result=_listmember.Where(x=>x.DateOfBirth.Year==year).ToList();
            return result;
        }

        public List<Members> GetMemberBirthYeargreaterThan(int year)
        {
            var result=_listmember.Where(x=>x.DateOfBirth.Year>year).ToList();
            return result;
        }

        public List<Members> GetMemberBirthYearlessThan(int year)
        {
             var result=_listmember.Where(x=>x.DateOfBirth.Year<year).ToList();
            return result;
        }

        public List<Members> GetMemberByBirthPlace(string place)
        {
            var result =_listmember.Where(x=>x.BirthPlace==place).ToList();
            return result;
        }

        public List<string> GetMemberFullName()
        {
            var result=_listmember.Select(x=>$"{x.FirstName+x.LastName}").ToList();
            return result;
        }

        public Members GetOldestMember()
        {
            var a=_listmember.Min(x=>x.DateOfBirth);
            var result= _listmember.FirstOrDefault(x=>x.DateOfBirth==a);
            return result;

        }

        public List<Members> MemberIsMale(string gender)
        {
            var result= _listmember.Where(x=>x.Gender==gender).ToList();
            return result;
        }
        public List<Members> AddNewMember(Members member){
            _listmember.Add(member);
            return _listmember;
        }

        private void SeedingData(){
            _listmember=new List<Members>{
                new Members{
                    FirstName ="Duyet",
                    LastName="Tran",
                    BirthPlace="Ha Noi",
                    DateOfBirth=DateTime.Now.AddYears(-30),
                    Gender="Male",
                    Phone="1203102391",
                    IsGraduated=true,
                    StartDate=DateTime.Now.AddYears(-10),
                    EndDate=DateTime.Now.AddYears(5)
                },
                new Members{
                    FirstName ="Quan",
                    LastName="Dao",
                    BirthPlace="Ha Nam",
                    DateOfBirth=DateTime.Now.AddYears(-25),
                    Gender="Male",
                    Phone="1203102391",
                    IsGraduated=true,
                    StartDate=DateTime.Now.AddYears(-9),
                    EndDate=DateTime.Now.AddYears(5)
                },
                new Members{
                    FirstName ="Tuan",
                    LastName="Le",
                    BirthPlace="Cao Bang",
                    DateOfBirth=DateTime.Now.AddYears(-20),
                    Gender="FeMale",
                    Phone="1203102391",
                    IsGraduated=true,
                    StartDate=DateTime.Now.AddYears(-18),
                    EndDate=DateTime.Now.AddYears(4)
                },
                new Members{
                    FirstName ="Dung",
                    LastName="Tran",
                    BirthPlace="Hai Phong",
                    DateOfBirth=DateTime.Now.AddYears(-22),
                    Gender="Male",
                    Phone="1203102391",
                    IsGraduated=true,
                    StartDate=DateTime.Now.AddYears(-4),
                    EndDate=DateTime.Now.AddYears(3)
                },
                new Members{
                    FirstName ="Quyen",
                    LastName="Tran",
                    BirthPlace="Ha Noi",
                    DateOfBirth=DateTime.Now.AddYears(-40),
                    Gender="Male",
                    Phone="1203102391",
                    IsGraduated=true,
                    StartDate=DateTime.Now.AddYears(-20),
                    EndDate=DateTime.Now.AddYears(-10)
                }

            };
        }
    }
}