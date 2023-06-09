﻿using System;
using System.Collections.Generic;

namespace LibraryManager.BLL
{
    public sealed class MemberStore
    {
        public List<Member> members { get; set; }

        private static readonly MemberStore instance = new MemberStore();

        static MemberStore()
        {

        }

        private MemberStore()
        {
            members = new List<Member>();
        }

        public static MemberStore Instance
        {
            get
            {
                return instance;
            }
        }

        public List<Member> GetMembersByName(String name)
        {
            return members.FindAll(m => m.name == name);
        }

        public Member GetMembersByID(String id)
        {
            return members.Find(m => m.id == id);
        }

        public Member GetMemberByNationality(String Nationality)
            {

            return members.Find(m => m.nationality== Nationality);  
        }

        public void AddNewMember(string name, string nationality, string DOB, string id)
        {
            if (!members.Exists(m => m.id == id))
            {
                Member member = new Member(name, nationality,DOB,id);
                members.Add(member);
            }
        }

        public void RemoveMember(Member member)
        {
            if (members.Contains(member))
            {
                _ = members.Remove(member);
            }
        }
    }
}
