﻿using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Concrete
{
    public class MemberManager : IMemberService
    {
        private readonly IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public void TDelete(int id)
        {
            _memberDal.Delete(id);
        }

        public Member TGetById(int id)
        {
            return _memberDal.GetById(id);
        }

        public List<Member> TGetListAll()
        {
            return _memberDal.GetListAll();
        }

        public int TGetMemberCount()
        {
            return _memberDal.GetMemberCount();
        }

        public void TInsert(Member entity)
        {
            _memberDal.Insert(entity);
        }

        public void TUpdate(Member entity)
        {
            _memberDal.Update(entity);
        }
    }
}
