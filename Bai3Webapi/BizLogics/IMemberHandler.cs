using Bai3Webapi.Models;
using System.Collections.Generic;

namespace Bai3Webapi.BizLogics{
    public interface IMemberHandler{
        //return member is Male
         List<Members> MemberIsMale(string gender);
        //return member is the oldest member
        Members GetOldestMember();
        // return member fullname 
        List<string> GetMemberFullName();
        //return list member  has birth year is 2000
        List<Members> GetMemberBirthYear2000(int year);
        //return list member  has birth year is greater than 2000
        List<Members> GetMemberBirthYeargreaterThan(int year);
        //return list member  has birth year is less than 2000
        List<Members> GetMemberBirthYearlessThan(int year);
        
        //return member in HN
        List<Members> GetMemberByBirthPlace(string place);
        
        List<Members> AddNewMember(Members member);

    }
}